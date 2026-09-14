using System.Linq;

namespace Launcher
{
	public static class RuntimeFlags
	{
		public static bool BypassUpdater
		{
			get; private set;
		}

		public static void Initialize(string[] args)
		{
			BypassUpdater =
#if DEBUG
			    args.Any(x => x == "--no-updater")
#else
			    false
#endif
			;
		}
	}
}
