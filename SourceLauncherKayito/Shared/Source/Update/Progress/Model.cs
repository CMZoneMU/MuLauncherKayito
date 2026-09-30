namespace Shared.Update
{
	public class UpdateProgress
	{
		public string StatusKey
		{
			get; set;
		}

		public object[] Args
		{
			get; set;
		}

		public long CurrentFileDownloaded
		{
			get; set;
		}

		public long CurrentFileSize
		{
			get; set;
		}

		public long TotalBytesDownloaded
		{
			get; set;
		}

		public long TotalBytes
		{
			get; set;
		}
	}
}
