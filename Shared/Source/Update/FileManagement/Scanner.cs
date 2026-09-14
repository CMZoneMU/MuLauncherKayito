using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shared.Update
{
	public class FileScanner
	{
		public async Task<List<UpdateFileInfo>> ScanFiles(List<UpdateFileInfo> files, IProgress<UpdateProgress> progress)
		{
			return await Task.Run(() =>
			{
				var result = new List<UpdateFileInfo>();

				long current = 0;
				long total = files.Count;

				foreach (var file in files)
				{
					current++;

					progress.Report(new UpdateProgress
					{
						StatusKey = "UPDATE_CHECKING",

						Args = new object[] { current, total, file.Path },

						TotalBytesDownloaded = current,

						TotalBytes = total
					});

					if (FileVerifier.NeedsUpdate(file))
					{
						result.Add(file);
					}
				}

				return result;
			});
		}
	}
}
