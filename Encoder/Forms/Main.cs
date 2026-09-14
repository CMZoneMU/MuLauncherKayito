using System;
using System.IO;
using System.Windows.Forms;
// External
using Shared.LauncherConfig;
using Shared.UI;

namespace Encoder
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.SetTextureHandlers();

			this.SetLabelTooltips();
		}

		private void Btn_Load_Click(object sender, EventArgs e)
		{
			this.FolderBrowser_handler.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;

			if (this.FolderBrowser_handler.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string filePath = Path.Combine(
						this.FolderBrowser_handler.SelectedPath,
						ConfigManager.ConfigFile
					);

					ConfigModel config = ConfigHelper.LoadFile(filePath);

					this.SetConfigValues(config);

					MessageBox.Show(
						"Configuration file loaded successfully.",
						"Success",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
				}
				catch (Exception ex)
				{
					MessageBox.Show(
						"Failed to load configuration file.\n\n" + ex.Message,
						"Load Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			if (!this.ValidateInputs())
			{
				return;
			}

			this.SaveFile();
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void SetTextureHandlers()
		{
			UITextureHelper.ApplyTextureControl(
					this.Btn_Save,
					Properties.Resources.Save_n,
					Properties.Resources.Save_n,
					Properties.Resources.Save_h,
					Properties.Resources.Save_c
				);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Load,
				Properties.Resources.Load_n,
				Properties.Resources.Load_n,
				Properties.Resources.Load_h,
				Properties.Resources.Load_c
			);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Close,
				Properties.Resources.Close_n,
				Properties.Resources.Close_n,
				Properties.Resources.Close_h,
				Properties.Resources.Close_c
			);
		}

		private void SetLabelTooltips()
		{
			this.Tooltip_handler.SetToolTip(this.WindowTitle_txt,
				"Title of the launcher window.\nExample: Launcher Mu Online Version 0.97k");

			this.Tooltip_handler.SetToolTip(this.Executable_txt,
				"Name of the executable.\nExample: main.exe | game.exe | play.exe");

			this.Tooltip_handler.SetToolTip(this.UpdatesUrl_txt,
				"URL folder where to find the update content.\nExample: https://mymuserver.com/launcher/updates/");

			this.Tooltip_handler.SetToolTip(this.UpdateFile_txt,
				"Name of the update file.\nExample: LauncherUpdate.json");

			this.Tooltip_handler.SetToolTip(this.Website_txt,
				"Website of the html panel.\nExample: https://mymuserver.com/launcher/panel.html");

			this.Tooltip_handler.SetToolTip(this.MutexName_txt,
				"Mutex to identify the Launcher instance.\nExample: MyLauncherMutex");
		}

		private void SaveFile()
		{
			this.FolderBrowser_handler.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;

			if (this.FolderBrowser_handler.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ConfigModel config = this.GetConfigValues();

					string filePath = Path.Combine(
						this.FolderBrowser_handler.SelectedPath,
						ConfigManager.ConfigFile
					);

					ConfigHelper.SaveFile(config, filePath);

					MessageBox.Show(
						$"Configuration file saved successfully.\n\n{filePath}",
						"Success",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
				}
				catch (Exception ex)
				{
					MessageBox.Show(
						"Failed to save configuration file.\n\n" + ex.Message,
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		private bool ValidateInputs()
		{
			this.Error_handler.Clear();

			bool valid = true;
			Control firstError = null;

			void SetError(Control control, string message)
			{
				this.Error_handler.SetError(control, message);

				if (firstError == null)
				{
					firstError = control;
				}

				valid = false;
			}

			if (string.IsNullOrWhiteSpace(this.Executable_Box.Text))
			{
				SetError(this.Executable_Box, "Executable name is required.");
			}

			if (string.IsNullOrWhiteSpace(this.UpdateFile_Box.Text))
			{
				SetError(this.UpdateFile_Box, "Update filename is required.");
			}

			Uri uri;
			if (!Uri.TryCreate(this.UpdatesUrl_Box.Text, UriKind.Absolute, out uri)
				|| (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
			{
				SetError(this.UpdatesUrl_Box, "Invalid URL.");
			}

			if (!string.IsNullOrWhiteSpace(this.Website_Box.Text))
			{
				if (!Uri.TryCreate(this.Website_Box.Text, UriKind.Absolute, out uri))
				{
					SetError(this.Website_Box, "Invalid URL.");
				}
			}

			if (string.IsNullOrWhiteSpace(this.MutexName_Box.Text))
			{
				SetError(this.MutexName_Box, "Launcher Mutex is required.");
			}

			this.ActiveControl = firstError;

			return valid;
		}

		private void SetConfigValues(ConfigModel config)
		{
			this.WindowTitle_Box.Text = config.WindowTitle ?? "";

			this.Executable_Box.Text = config.GameExecutable ?? "";

			this.UpdatesUrl_Box.Text = config.UpdatesURL ?? "";

			this.UpdateFile_Box.Text = config.UpdateFilename ?? "";

			this.Website_Box.Text = config.WebsiteURL ?? "";

			this.MutexName_Box.Text = config.MutexName ?? "";
		}

		private ConfigModel GetConfigValues()
		{
			return new ConfigModel
			{
				WindowTitle = this.WindowTitle_Box.Text.Trim(),

				GameExecutable = this.Executable_Box.Text.Trim(),

				UpdatesURL = this.UpdatesUrl_Box.Text.Trim(),

				UpdateFilename = this.UpdateFile_Box.Text.Trim(),

				WebsiteURL = this.Website_Box.Text.Trim(),

				MutexName = this.MutexName_Box.Text.Trim()
			};
		}
	}
}
