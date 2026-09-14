using System;
using System.IO;

namespace Shared.Utils
{
	public static class PathHelper
	{
		public static string GetRelativePath(string basePath, string fullPath)
		{
			if (basePath[basePath.Length - 1] != Path.DirectorySeparatorChar)
			{
				basePath += Path.DirectorySeparatorChar;
			}

			if (!fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException("Path is not inside base path.");
			}

			return fullPath.Substring(basePath.Length);
		}

		public static string NormalizePath(string path)
		    => path.Replace("\\", "/");

		public static string GetLocalPath(string path)
		{
			string normalized = path.Replace('/', Path.DirectorySeparatorChar);

			string fullPath = Path.GetFullPath(
				Path.Combine(AppDomain.CurrentDomain.BaseDirectory, normalized)
			);

			string baseDir = AppDomain.CurrentDomain.BaseDirectory;

			if (!fullPath.StartsWith(baseDir, StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException($"Invalid path given: {fullPath}");
			}

			return fullPath;
		}
	}
}
