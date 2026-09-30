using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Shared.Update
{
	[DataContract]
	public class UpdateFileInfo
	{
		[DataMember(Order = 1)]
		public string Path
		{
			get; set;
		}

		[DataMember(Order = 2)]
		public long Size
		{
			get; set;
		}

		[DataMember(Order = 3)]
		public string Hash
		{
			get; set;
		}
	}

	[DataContract]
	public class UpdateManifest
	{
		[DataMember(Order = 1)]
		public UpdateFileInfo Launcher
		{
			get; set;
		}

		[DataMember(Order = 2)]
		public List<UpdateFileInfo> FileList
		{
			get; set;
		}
	}
}
