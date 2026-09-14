using System;
// External
using Shared.LauncherPayload;
using Shared.Utils;

namespace Launcher
{
	internal static class PayloadHelper
	{
		public static LauncherPayload ReadFromStdIn()
		{
			try
			{
				if (Console.IsInputRedirected)
				{
					string input = Console.In.ReadToEnd();

					if (string.IsNullOrWhiteSpace(input))
					{
						return null;
					}

					return JsonHelper.Deserialize<LauncherPayload>(input);
				}

				return null;
			}
			catch
			{
				return null;
			}
		}
	}
}
