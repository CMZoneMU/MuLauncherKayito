using System;
using System.Collections.Generic;
using System.Windows.Forms;
// External
using Shared.GameSettings;
using Shared.Languages;
using Shared.UI;

namespace Launcher
{
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}

		private void Options_Load(object sender, EventArgs e)
		{
			this.SetTextureHandlers();

			this.SetInitialValues();

			this.LoadRegistryValues();

			SettingsService.Instance.OnLanguageChanged += lang =>
			{
				LanguageHelper.ApplyTranslations(this, lang);
			};
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			this.SaveRegistryValues();

			this.Close();
		}

		private void SetTextureHandlers()
		{
			UITextureHelper.ApplyTextureControl(
				this.Btn_Save,
				Properties.Resources.Button_n,
				Properties.Resources.Button_n,
				Properties.Resources.Button_h,
				Properties.Resources.Button_h
			);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Close,
				Properties.Resources.Button_n,
				Properties.Resources.Button_n,
				Properties.Resources.Button_h,
				Properties.Resources.Button_h
			);
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

			string Language = "Eng";

			if (this.Language_Eng.Checked)
			{
				Language = "Eng";
			}
			else if (this.Language_Spn.Checked)
			{
				Language = "Spn";
			}
			else if (this.Language_Por.Checked)
			{
				Language = "Por";
			}

			service.SetLanguage(Language);

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
	}
}
