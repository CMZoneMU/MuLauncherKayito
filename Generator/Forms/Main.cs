using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// External
using Generator.FileEntry;
using Generator.Update;
using Shared.Utils;

namespace Generator
{
	public partial class Main : Form
	{
		private FileModel m_Launcher = null;
		private BindingList<FileModel> m_Files = new BindingList<FileModel>();

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.FileList_Box.AutoGenerateColumns = false;

			this.FileList_Box.DataSource = this.m_Files;

			this.UpdateGenerateButton();
		}

		private void Btn_Launcher_Click(object sender, EventArgs e)
		{
			this.m_Launcher = null;

			this.Launcher_Box.Clear();

			this.OpenFile_handler.Title = "Open the Launcher.exe file";

			this.OpenFile_handler.Filter = "Executable Files (*.exe)|*.exe";

			this.OpenFile_handler.FileName = "Launcher.exe";

			if (this.OpenFile_handler.ShowDialog() == DialogResult.OK)
			{
				string launcherPath = this.OpenFile_handler.FileName;

				string directoryPath = Path.GetDirectoryName(launcherPath);

				var entry = new FileModel
					{
						FullPath = launcherPath,
						RelativePath = PathHelper.GetRelativePath(directoryPath, launcherPath),
					};
				
				this.m_Launcher = entry;

				this.Launcher_Box.Text = launcherPath;
			}
		}

		private void Btn_Clear_Click(object sender, EventArgs e)
		{
			this.m_Files.Clear();

			this.UpdateGenerateButton();
		}

		private void Btn_Delete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in this.FileList_Box.SelectedRows.Cast<DataGridViewRow>().OrderByDescending(r => r.Index))
			{
				this.m_Files.RemoveAt(row.Index);
			}

			this.UpdateGenerateButton();
		}

		private async void Btn_Open_Click(object sender, EventArgs e)
		{
			this.FolderBrowser_handler.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;

			if (this.FolderBrowser_handler.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			this.ResetProgress();

			this.Function_panel.Enabled = false;

			string basePath = this.FolderBrowser_handler.SelectedPath;

			var files = Directory
				.EnumerateFiles(basePath, "*", SearchOption.AllDirectories)
				.ToArray();

			int total = files.Length;
			int processed = 0;
			int lastPercent = -1;

			IProgress<(int, string)> progress =
				new Progress<(int value, string text)>(t => this.UpdateProgress(t.value, t.text));

			var result = await Task.Run(() =>
			{
				var entries = new FileModel[total];

				Parallel.For(0, total, i =>
				{
					string file = files[i];

					entries[i] = new FileModel
						{
							FullPath = file,
							RelativePath = PathHelper.GetRelativePath(basePath, file),
						};

					int current = Interlocked.Increment(ref processed);
					int percent = current * 100 / total;

					int prev = Interlocked.Exchange(ref lastPercent, percent);

					if (percent > prev)
					{
						progress.Report((percent, $"Loading files: {percent}%"));
					}
				});

				progress.Report((99, "Preparing file list..."));

				return entries;
			});

			this.FileList_Box.SuspendLayout();

			this.m_Files = new BindingList<FileModel>(result.ToList());

			this.FileList_Box.DataSource = this.m_Files;

			this.FileList_Box.ResumeLayout();

			this.UpdateGenerateButton();

			this.Function_panel.Enabled = true;

			this.UpdateProgress(100, "Folder loading completed");
		}

		private async void Btn_Generate_Click(object sender, EventArgs e)
		{
			var manifestName = this.Filename_Box.Text.Trim();

			if (string.IsNullOrWhiteSpace(manifestName))
			{
				MessageBox.Show(
				    "Update filename cannot be empty.",
				    "Error",
				    MessageBoxButtons.OK,
				    MessageBoxIcon.Error
				);

				return;
			}

			this.SaveFile_handler.FileName = "Update.zip";
			this.SaveFile_handler.Filter = "Zip files (*.zip)|*.zip";

			if (this.SaveFile_handler.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			if (File.Exists(this.SaveFile_handler.FileName))
			{
				MessageBox.Show(
					"Cannot overwrite zip. Please use another name.",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			this.Function_panel.Enabled = false;

			this.ResetProgress();

			IProgress<(int, string)> progress =
				new Progress<(int value, string text)>(t => this.UpdateProgress(t.value, t.text));

			try
			{
				await Task.Run(() =>
				{
					UpdateHelper.BuildUpdatePackage(
						this.SaveFile_handler.FileName,
						manifestName,
						this.m_Files.ToList(),
						this.m_Launcher,
						progress
					);
				});

				MessageBox.Show(
					"Update package created",
					"Success",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			finally
			{
				this.Function_panel.Enabled = true;
			}
		}

		private void FileList_Box_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.FileList_Box.Columns[e.ColumnIndex].DataPropertyName == "Size")
			{
				e.Value = FileHelper.FormatSize((long)e.Value);
			}
		}

		private void UpdateGenerateButton()
		{
			this.Btn_Generate.Enabled = this.m_Files.Count > 0;
		}

		private void UpdateProgress(int value, string text)
		{
			if (value < 0 || value > 100)
			{
				return;
			}

			float width = 600.0f * (float)value / 100.0f;

			this.CurrentProgress.Width = (int)width;

			this.ProgressText.Text = text;
		}

		private void ResetProgress()
		{
			this.CurrentProgress.Width = 0;

			this.ProgressText.Text = "Progress";
		}
	}
}
