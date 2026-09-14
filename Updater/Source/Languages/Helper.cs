using System;

namespace Updater.Languages
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
	}
}
