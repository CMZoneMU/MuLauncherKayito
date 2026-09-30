using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography;
// External
using Shared.Utils;

namespace Shared.LauncherConfig
{
	public static class ConfigHelper
	{
		private const string SecretKey = "KayitoIsTheBest!";

		public static void SaveFile(ConfigModel config, string filepath)
		{
			if (config == null)
			{
				throw new ArgumentNullException(nameof(config));
			}

			Validate(config);

			string json = JsonHelper.Serialize(config);

			byte[] encrypted = CryptoHelper.Encrypt(json, SecretKey);

			string normalizedPath = PathHelper.NormalizePath(filepath);

			Directory.CreateDirectory(Path.GetDirectoryName(normalizedPath));

			string tempFile = normalizedPath + ".tmp";

			File.WriteAllBytes(tempFile, encrypted);

			if (File.Exists(normalizedPath))
			{
				File.Replace(tempFile, normalizedPath, null);
			}
			else
			{
				File.Move(tempFile, normalizedPath);
			}
		}

		public static ConfigModel LoadFile(string filepath)
		{
			if (!File.Exists(filepath))
			{
				throw new FileNotFoundException("Config file not found.", filepath);
			}

			try
			{
				byte[] encrypted = File.ReadAllBytes(filepath);

				string json = CryptoHelper.Decrypt(encrypted, SecretKey);

				ConfigModel config = JsonHelper.Deserialize<ConfigModel>(json);

				if (config == null)
				{
					throw new InvalidDataException("Configuration file is invalid.");
				}

				Validate(config);

				return config;
			}
			catch (CryptographicException ex)
			{
				throw new CryptographicException("Failed to decrypt configuration file.", ex);
			}
			catch (SerializationException ex)
			{
				throw new SerializationException("Failed to serialize configuration file.", ex);
			}
			catch (IOException ex)
			{
				throw new IOException("Error reading configuration file.", ex);
			}
		}

		private static void Validate(ConfigModel config)
		{
			if (string.IsNullOrWhiteSpace(config.GameExecutable))
			{
				throw new InvalidDataException("Game Executable is missing.");
			}

			if (!config.GameExecutable.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidDataException("Game executable must be an .exe file.");
			}

			Uri uri;

			if (!Uri.TryCreate(config.UpdatesURL, UriKind.Absolute, out uri))
			{
				throw new InvalidDataException("Updates URL is invalid.");
			}

			if (string.IsNullOrWhiteSpace(config.UpdateFilename))
			{
				throw new InvalidDataException("Update File is missing.");
			}

			if (string.IsNullOrWhiteSpace(config.MutexName))
			{
				throw new InvalidDataException("Launcher Mutex is missing.");
			}
		}
	}
}
