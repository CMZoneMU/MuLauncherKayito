using System;
using System.Threading.Tasks;
using System.Windows.Forms;
// External
using Shared.Update;
using Updater.Languages;

namespace Updater
{
	public partial class Main : Form
	{
		private string _currentLanguage = "Eng";

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			_ = this.Main_LoadAsync();
		}

		private async Task Main_LoadAsync()
		{
			var updater = new UpdateStarter();

			IProgress<UpdateProgress> progress = new Progress<UpdateProgress>(UpdateUI);

			try
			{
				await updater.Start(progress);

				Application.Exit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Updater error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				Application.Exit();
			}
		}

		private void UpdateUI(UpdateProgress p)
		{
			if (!string.IsNullOrEmpty(p.StatusKey))
			{
				this.StatusText.Text = LanguageHelper.Get(
					p.StatusKey,
					this._currentLanguage,
					p.Args
				);
			}

			if (p.TotalBytes > 0)
			{
				float percent = (float)p.TotalBytesDownloaded / p.TotalBytes;

				int width = (int)(182 * percent);
				width = Math.Min(width, 182);

				this.CompleteBar.Width = width;
			}
		}
	}
}
