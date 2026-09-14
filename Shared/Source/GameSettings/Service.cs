using System;

namespace Shared.GameSettings
{
	public sealed class SettingsService
	{
		private static readonly Lazy<SettingsService> _instance =
			new Lazy<SettingsService>(() => new SettingsService());

		public static SettingsService Instance => _instance.Value;

		private SettingsModel _settings;

		public SettingsModel Current => _settings;

		public event Action<string> OnLanguageChanged;

		private SettingsService()
		{
			Load();
		}

		public void Load()
		{
			_settings = SettingsHelper.Load();
		}

		public void Save()
		{
			SettingsHelper.Save(_settings);
		}

		public void SetLanguage(string lang)
		{
			if (string.IsNullOrWhiteSpace(lang))
			{
				return;
			}

			if (_settings.Language == lang)
			{
				return;
			}

			_settings.Language = lang;

			OnLanguageChanged?.Invoke(lang);
		}
	}
}