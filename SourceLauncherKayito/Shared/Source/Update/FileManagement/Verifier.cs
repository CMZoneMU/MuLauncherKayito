using System;
using System.IO;
using System.Security.Cryptography;
// External
using Shared.Utils;

namespace Shared.Update
{
	public static class FileVerifier
	{
		public static bool NeedsUpdate(UpdateFileInfo file)
		{
			string fullPath = PathHelper.GetLocalPath(file.Path);

			if (!File.Exists(fullPath))
			{
				return true;
			}

			FileInfo info = new FileInfo(fullPath);

			if (info.Length != file.Size)
			{
				return true;
			}

			string hash = ComputeHash(fullPath);

			return !hash.Equals(file.Hash, StringComparison.OrdinalIgnoreCase);
		}

		public static bool Verify(UpdateFileInfo file)
		{
			string fullPath = PathHelper.GetLocalPath(file.Path);

			if (!File.Exists(fullPath))
			{
				return false;
			}

			string hash = ComputeHash(fullPath);

			return hash.Equals(file.Hash, StringComparison.OrdinalIgnoreCase);
		}

		public static string ComputeHash(string path)
		{
			using (var sha = SHA256.Create())
			{
				using (var stream = new FileStream(
					path,
					FileMode.Open,
					FileAccess.Read,
					FileShare.Read,
					65536))
				{
					byte[] hash = sha.ComputeHash(stream);

					return BitConverter
						.ToString(hash)
						.Replace("-", "")
						.ToLowerInvariant();
				}
			}
		}
	}
}
