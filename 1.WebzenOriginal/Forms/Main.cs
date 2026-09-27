using MuLauncher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
// External
using Shared.GameSettings;
using Shared.Languages;
using Shared.Utils;



namespace Launcher
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			this.InitializeValues();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.SetInitialValues();

			SettingsService.Instance.OnLanguageChanged += lang =>
			{
				LanguageHelper.ApplyTranslations(this, lang);
			};

			this.LoadRegistryValues();
		}

		private async void Btn_Play_Click(object sender, EventArgs e)
		{
			this.Function_panel.Enabled = false;

			this.Btn_Play.Enabled = false;

			this.SaveRegistryValues();

			var progress = new Progress<UpdateProgressReport>(this.UpdateUI);

			try
			{
				var config = LauncherConfig.Load();
				var updater = new LaunchUpdater(config, AppDomain.CurrentDomain.BaseDirectory);
				bool success = await updater.StartCheckAndUpdateAsync(progress);

				if (success)
				{
					await System.Threading.Tasks.Task.Delay(300);
					await GameLauncher.Launch(config);
				}
				else
				{
					this.Btn_Play.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Update error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				this.Function_panel.Enabled = true;

				this.Btn_Play.Enabled = true;

				Application.Exit();
			}
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Btn_Web_Click(object sender, EventArgs e)
		{
			// Update Kayito 92 2.4.9 -> 97K SSeMU Update (Issue 3) - Safe web navigation and protocol handler validation
			var config = LauncherConfig.Load();

			if (!WebHelper.TryParseSafeWebUri(config.WebsiteUrl, out Uri? uri))
			{
				return;
			}

			var baseUri = new Uri(uri!.GetLeftPart(UriPartial.Authority));

			WebHelper.TryOpenExternalUrl(baseUri);
		}
	
		private void InitializeValues()
		{
			var config = LauncherConfig.Load();

			{
			}
		}

		private void SetInitialValues()
		{
			this.Resolution_box.DataSource = new BindingSource(SettingsDictionary.Resolution, null);
			this.Resolution_box.DisplayMember = "Value";
			this.Resolution_box.ValueMember = "Key";
		}

		private void LoadRegistryValues()
		{
			var settings = SettingsService.Instance.Current;

			if (settings.Resolution.HasValue)
			{
				if (SettingsDictionary.Resolution.ContainsKey(settings.Resolution.Value))
				{
					this.Resolution_box.SelectedValue = settings.Resolution;
				}
			}

			if (settings.WindowMode.HasValue)
			{
				this.WindowMode.Checked = settings.WindowMode.Value;
			}

			if (settings.Sound.HasValue)
			{
				this.Sound_check.Checked = settings.Sound.Value;
			}

			if (settings.Music.HasValue)
			{
				this.Music_check.Checked = settings.Music.Value;
			}

			if (settings.Volume.HasValue)
			{
				this.VolumeLevel.Value = settings.Volume.Value;
			}

			if (settings.Account != null)
			{
				this.User_box.Text = settings.Account;
			}

			if (settings.Language != null)
			{
				if (SettingsDictionary.Lang.ContainsKey(settings.Language))
				{
					switch (settings.Language)
					{
						case "Eng":
						{
							this.Language_Eng.Checked = true;

							break;
						}

						case "Spn":
						{
							this.Language_Spn.Checked = true;

							break;
						}

						case "Por":
						{
							this.Language_Por.Checked = true;

							break;
						}
					}
				}
			}
		}

		private void SaveRegistryValues()
		{
			var service = SettingsService.Instance;

			var settings = service.Current;

			settings.Account = this.User_box.Text.Trim();

			settings.Resolution = ((KeyValuePair<int, string>)this.Resolution_box.SelectedItem).Key;

			settings.WindowMode = this.WindowMode.Checked;

			settings.Sound = this.Sound_check.Checked;

			settings.Music = this.Music_check.Checked;

			settings.Volume = this.VolumeLevel.Value;

			if (this.Language_Eng.Checked)
			{
				settings.Language = "Eng";
			}
			else if (this.Language_Spn.Checked)
			{
				settings.Language = "Spn";
			}
			else if (this.Language_Por.Checked)
			{
				settings.Language = "Por";
			}

			service.Save();
		}

		private void Language_Eng_CheckedChanged(object sender, EventArgs e)
		{
			string lang = "Eng";

			LanguageHelper.ApplyTranslations(this, lang);
		}

		private void Language_Spn_CheckedChanged(object sender, EventArgs e)
		{
			string lang = "Spn";

			LanguageHelper.ApplyTranslations(this, lang);
		}

		private void Language_Por_CheckedChanged(object sender, EventArgs e)
		{
			string lang = "Por";

			LanguageHelper.ApplyTranslations(this, lang);
		}

		private void UpdateUI(UpdateProgressReport p)
		{
			if (!string.IsNullOrEmpty(p.StatusMessage))
			{
				this.Status_txt.Text = p.StatusMessage;
			}

			if (true)
			{
				int value = (int)p.TotalPercent;

				value = Math.Min(100, Math.Max(0, value));

				this.CurrentProgress.Value = value;
			}
		}
	}
}





