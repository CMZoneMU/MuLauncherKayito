using System;

namespace Generator.FileEntry
{
	public static class FileHelper
	{
		public static string FormatSize(long size)
		{
			if (size < 1024)
			{
				return $"{size} B";
			}

			if (size < 1024 * 1024)
			{
				return $"{Math.Max(1, size / 1024)} KB";
			}

			return $"{size / (1024 * 1024)} MB";
		}
	}
}
