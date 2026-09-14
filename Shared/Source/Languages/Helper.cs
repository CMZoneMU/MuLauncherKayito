using System;
using System.Windows.Forms;

namespace Shared.Languages
{
	public static class LanguageHelper
	{
		public static string Get(string key, string lang, params object[] args)
		{
			if (LanguageModel.translations.TryGetValue(lang, out var langDict) &&
			    langDict.TryGetValue(key, out var value))
			{
				return args != null && args.Length > 0
					? string.Format(value, args)
					: value;
			}

			// fallback simple
			if (LanguageModel.translations["Eng"].TryGetValue(key, out var fallback))
			{
				return args != null && args.Length > 0
					? string.Format(fallback, args)
					: fallback;
			}

			return $"[{key}]";
		}

		public static void ApplyTranslations(Control parent, string CurrentLanguage)
		{
			foreach (Control c in parent.Controls)
			{
				if (c.Tag is string key && !string.IsNullOrEmpty(key))
				{
					c.Text = LanguageHelper.Get(key, CurrentLanguage);
				}

				if (c.HasChildren)
				{
					ApplyTranslations(c, CurrentLanguage);
				}
			}
		}
	}
}
