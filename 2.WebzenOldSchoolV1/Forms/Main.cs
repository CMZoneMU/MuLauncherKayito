using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
// External
using Shared.GameSettings;
using Shared.Languages;
using Shared.LauncherConfig;
using Shared.UI;
using Shared.Update;

namespace Launcher
{
	public partial class Main : Form
	{
		private Uri m_WebPanelUri;
		private bool m_WebsiteLoaded = false;

		public Main()
		{
			InitializeComponent();

			this.InitializeValues();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.SetTextureHandlers();

			string CurrentLanguage = SettingsService.Instance.Current.Language ?? "Eng";

			LanguageHelper.ApplyTranslations(this, CurrentLanguage);

			SettingsService.Instance.OnLanguageChanged += lang =>
			{
				LanguageHelper.ApplyTranslations(this, lang);
			};

			this.InitializeWebsite();
		}

		private void Btn_Options_Click(object sender, EventArgs e)
		{
			this.Opacity = 0.0f;

			using (Options dialog = new Options())
			{
				dialog.ShowDialog(this);
			}

			this.Opacity = 1.0f;
		}

		private async void Btn_Play_Click(object sender, EventArgs e)
		{
			this.Btn_Play.Enabled = false;

			var updater = new UpdateStarter();

			var progress = new Progress<UpdateProgress>(UpdateUI);

			try
			{
				await updater.Start(progress);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Update error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				this.Btn_Play.Enabled = true;

				Application.Exit();
			}
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void InitializeValues()
		{
			var config = ConfigManager.Current;

			if (!string.IsNullOrWhiteSpace(config.WindowTitle))
			{
				this.Text = config.WindowTitle;

				this.Title_txt.Text = config.WindowTitle;
			}

			this.Web_panel.Visible = false;

			this.m_WebsiteLoaded = false;
		}

		private void SetTextureHandlers()
		{
			UITextureHelper.ApplyTextureControl(
				this.Btn_Play,
				Properties.Resources.Button_n,
				Properties.Resources.Button_d,
				Properties.Resources.Button_h,
				Properties.Resources.Button_h
			);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Options,
				Properties.Resources.Button_n,
				Properties.Resources.Button_d,
				Properties.Resources.Button_h,
				Properties.Resources.Button_h
			);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Close,
				Properties.Resources.Button_n,
				Properties.Resources.Button_d,
				Properties.Resources.Button_h,
				Properties.Resources.Button_h
			);
		}

		private void InitializeWebsite()
		{
			var config = ConfigManager.Current;

			if (string.IsNullOrWhiteSpace(config.WebsiteURL))
			{
				return;
			}

			if (!Uri.TryCreate(config.WebsiteURL, UriKind.Absolute, out Uri uri))
			{
				return;
			}

			this.m_WebPanelUri = uri;

			this.Web_panel.Visible = false;

			this.Web_panel.Navigate(uri);
		}

		private void Web_panel_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.m_WebPanelUri == null)
			{
				return;
			}

			if (this.m_WebsiteLoaded)
			{
				return;
			}

			if (this.Web_panel.ReadyState != WebBrowserReadyState.Complete)
			{
				return;
			}

			this.m_WebsiteLoaded = true;

			this.Web_panel.Visible = true;
		}

		private void Web_panel_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			if (this.m_WebPanelUri == null)
			{
				return;
			}

			if (e.Url.Host == this.m_WebPanelUri.Host)
			{
				return;
			}

			e.Cancel = true;

			Process.Start(new ProcessStartInfo
			{
				FileName = e.Url.ToString(),
				UseShellExecute = true
			});
		}

		private void Web_panel_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;

			string url = this.Web_panel.StatusText;

			if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = uri.ToString(),
					UseShellExecute = true
				});
			}
		}

		private void UpdateUI(UpdateProgress p)
		{
			if (!string.IsNullOrEmpty(p.StatusKey))
			{
				this.Status_txt.Text = LanguageHelper.Get(
					p.StatusKey,
					SettingsService.Instance.Current.Language,
					p.Args
				);
			}

			if (p.TotalBytes > 0)
			{
				int value = (int)((p.TotalBytesDownloaded / (double)p.TotalBytes) * 100);

				value = Math.Min(100, Math.Max(0, value));

				this.Complete_bar.Value = value;
			}
		}

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;

		private void Header_panel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();

				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}
	}
}
