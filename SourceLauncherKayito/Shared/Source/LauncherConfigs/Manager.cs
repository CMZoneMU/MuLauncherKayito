using System;
using System.IO;

namespace Shared.LauncherConfig
{
	public static class ConfigManager
	{
		public const string ConfigFile = "LauncherInfo.bmd";

		public static string ConfigPath =>
			Path.Combine(
				AppDomain.CurrentDomain.BaseDirectory,
				"Data",
				"Local",
				ConfigFile
			);

		public static ConfigModel Current
		{
			get
			{
				if (_current == null)
				{
					throw new InvalidOperationException("Configuration not loaded.");
				}

				return _current;
			}
		}

		public static void Set(ConfigModel config)
		{
			_current = config ?? throw new ArgumentNullException(nameof(config));
		}

		private static ConfigModel _current;
	}
}