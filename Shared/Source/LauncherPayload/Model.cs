using System.Runtime.Serialization;
// External
using Shared.LauncherConfig;
using Shared.Update;

namespace Shared.LauncherPayload
{
	[DataContract]
	public class LauncherPayload
	{
		[DataMember(Order = 1)]
		public string Token
		{
			get; set;
		}

		[DataMember(Order = 2)]
		public ConfigModel Config
		{
			get; set;
		}

		[DataMember(Order = 3)]
		public UpdateManifest Manifest
		{
			get; set;
		}
	}
}
