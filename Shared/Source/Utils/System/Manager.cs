using System;
using System.Security.Principal;

namespace Shared.Utils
{
	public static class SystemManager
	{
		public static bool IsRunningAsAdmin()
		{
			using (var identity = WindowsIdentity.GetCurrent())
			{
				var principal = new WindowsPrincipal(identity);

				return principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
		}
	}
}
