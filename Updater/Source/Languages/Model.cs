using System;
using System.Collections.Generic;

namespace Updater.Languages
{
	public static class LanguageModel
	{
		public static Dictionary<string, Dictionary<string, string>> translations =
		    new Dictionary<string, Dictionary<string, string>>
		    {
			    // English (default)
			    ["Eng"] = new Dictionary<string, string>
			    {
				    // Status
				    ["UPDATE_CONNECTING"] = "Connecting...",
				    ["UPDATE_DOWNLOADING_MANIFEST"] = "Downloading manifest...",
				    ["UPDATE_SCANNING"] = "Scanning local files...",
				    ["UPDATE_CHECKING"] = "Checking {0}/{1}: {2}",
				    ["UPDATE_CHECKING_RESULT"] = "{0} files need update",
				    ["UPDATE_DOWNLOADING"] = "Downloading {0}",
				    ["UPDATE_COMPLETE"] = "Update complete",

				    ["UPDATE_CHECKING_LAUNCHER"] = "Checking Launcher...",
				    ["UPDATE_UPDATING_LAUNCHER"] = "Updating Launcher...",
				    ["UPDATE_STARTING_LAUNCHER"] = "Starting launcher..."
			    }
		    };
	}
}
