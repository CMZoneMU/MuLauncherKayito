using Microsoft.Win32;

namespace Shared.GameSettings
{
	public static class SettingsHelper
	{
		private const string RegistryPath = @"Software\Webzen\Mu\Config";

		public static SettingsModel Load()
		{
			SettingsModel settings = new SettingsModel();

			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
			{
				if (key == null)
				{
					return settings;
				}

				settings.Account = key.GetValue("ID", "").ToString();

				settings.Language = key.GetValue("LangSelection", "Eng").ToString();

				settings.Resolution = (int)(key.GetValue("Resolution", 2));

				settings.WindowMode = ((int)key.GetValue("WindowMode", 1)) == 1;

				settings.Sound = ((int)key.GetValue("SoundOnOFF", 1)) == 1;

				settings.Music = ((int)key.GetValue("MusicOnOFF", 0)) == 1;

				settings.Volume = (int)(key.GetValue("VolumeLevel", 5));
			}

			return settings;
		}

		public static string GetStringValue(string name, string defaultValue)
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
			{
				if (key == null)
				{
					return defaultValue;
				}

				return key.GetValue(name, defaultValue).ToString();
			}
		}

		public static int GetIntValue(string name, int defaultValue)
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
			{
				if (key == null)
				{
					return defaultValue;
				}

				return (int)key.GetValue(name, defaultValue);
			}
		}

		public static void Save(SettingsModel settings)
		{
			using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
			{
				if (settings.Account != null)
				{
					key.SetValue("ID", settings.Account, RegistryValueKind.String);
				}

				if (settings.Language != null)
				{
					key.SetValue("LangSelection", settings.Language, RegistryValueKind.String);
				}

				if (settings.Resolution.HasValue)
				{
					key.SetValue("Resolution", settings.Resolution.Value, RegistryValueKind.DWord);
				}

				if (settings.WindowMode.HasValue)
				{
					key.SetValue("WindowMode", settings.WindowMode.Value ? 1 : 0, RegistryValueKind.DWord);
				}

				if (settings.Sound.HasValue)
				{
					key.SetValue("SoundOnOFF", settings.Sound.Value ? 1 : 0, RegistryValueKind.DWord);
				}

				if (settings.Music.HasValue)
				{
					key.SetValue("MusicOnOFF", settings.Music.Value ? 1 : 0, RegistryValueKind.DWord);
				}

				if (settings.Volume.HasValue)
				{
					key.SetValue("VolumeLevel", settings.Volume.Value, RegistryValueKind.DWord);
				}
			}
		}

		public static void SetStringValue(string name, string value)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return;
			}

			using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
			{
				key.SetValue(name, value, RegistryValueKind.String);
			}
		}

		public static void SetIntValue(string name, int value)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return;
			}

			using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
			{
				key.SetValue(name, value, RegistryValueKind.DWord);
			}
		}
	}
}
