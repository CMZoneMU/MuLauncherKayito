using System;

namespace Shared.Update
{
	public static class ManifestManager
	{
		public static UpdateManifest Current
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

		public static void Set(UpdateManifest config)
		{
			_current = config ?? throw new ArgumentNullException(nameof(config));
		}

		private static UpdateManifest _current;
	}
}
