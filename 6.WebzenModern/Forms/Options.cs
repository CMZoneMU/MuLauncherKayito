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

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			this.SaveRegistryValues();

			this.Close();
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SetTextureHandlers()
		{
			UITextureHelper.ApplyTextureControl(
				this.Btn_Save,
				Properties.Resources.Accept_n,
				Properties.Resources.Accept_n,
				Properties.Resources.Accept_h,
				Properties.Resources.Accept_c
			);

			UITextureHelper.ApplyTextureControl(
				this.Btn_Close,
				Properties.Resources.Cerrar_n,
				Properties.Resources.Cerrar_n,
				Properties.Resources.Cerrar_h,
				Properties.Resources.Cerrar_c
			);

			UITextureHelper.CheckBoxApply(
				this.WindowMode,
				Properties.Resources.CheckBox_c,
				Properties.Resources.CheckBox_u
			);

			UITextureHelper.CheckBoxApply(
				this.Sound_check,
				Properties.Resources.CheckBox_c,
				Properties.Resources.CheckBox_u
			);

			UITextureHelper.CheckBoxApply(
				this.Music_check,
				Properties.Resources.CheckBox_c,
				Properties.Resources.CheckBox_u
			);
		}

		private void SetInitialValues()
		{
			this.Language_box.DataSource = new BindingSource(SettingsDictionary.Lang, null);
			this.Language_box.DisplayMember = "Value";
			this.Language_box.ValueMember = "Key";

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
					this.Language_box.SelectedValue = settings.Language;
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

			string Language = ((KeyValuePair<string, string>)this.Language_box.SelectedItem).Key;

			service.SetLanguage(Language);

			service.Save();
		}

		private void Language_box_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Language_box.SelectedItem is KeyValuePair<string, string> item)
			{
				LanguageHelper.ApplyTranslations(this, item.Key);
			}
		}
	}
}
