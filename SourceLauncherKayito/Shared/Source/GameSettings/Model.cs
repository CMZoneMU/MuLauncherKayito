using System.Collections.Generic;

namespace Shared.GameSettings
{
	public class SettingsDictionary
	{
		public static IDictionary<string, string> Lang = new Dictionary<string, string>()
		{
		    {"Eng", "English"},
		    {"Spn", "Español"},
		    {"Por", "Português"},
		};

		public static IDictionary<int, string> Resolution = new Dictionary<int, string>()
		{
		    {0, "640x480"},
		    {1, "800x600"},
		    {2, "1024x768"},
		    {3, "1280x1024"},
		    {4, "1366x768"},
		    {5, "1440x900"},
		    {6, "1600x900"},
		    {7, "1920x1080"}
		};
	}

	public class SettingsModel
	{
		public string Account
		{
			get; set;
		} = null;

		public string Language
		{
			get; set;
		} = null;

		public int? Resolution
		{
			get; set;
		}

		public bool? WindowMode
		{
			get; set;
		}

		public bool? Music
		{
			get; set;
		}

		public bool? Sound
		{
			get; set;
		}

		public int? Volume
		{
			get; set;
		}
	}
}
