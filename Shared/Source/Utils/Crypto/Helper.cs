using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Shared.Utils
{
	public static class CryptoHelper
	{
		private const int SaltSize = 16;
		private const int IvSize = 16;
		private const int KeySize = 32;
		private const int Iterations = 100000;

		public static byte[] Encrypt(string plainText, string password)
		{
			byte[] salt = new byte[SaltSize];
			byte[] iv = new byte[IvSize];

			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(salt);
				rng.GetBytes(iv);
			}

			byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

			using (var key = new Rfc2898DeriveBytes(password, salt, Iterations))
			{
				using (var aes = Aes.Create())
				{
					aes.Mode = CipherMode.CBC;
					aes.Padding = PaddingMode.PKCS7;
					aes.Key = key.GetBytes(KeySize);
					aes.IV = iv;

					using (var ms = new MemoryStream())
					{
						ms.Write(salt, 0, salt.Length);
						ms.Write(iv, 0, iv.Length);

						using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
						{
							cs.Write(plainBytes, 0, plainBytes.Length);
							cs.FlushFinalBlock();
						}

						return ms.ToArray();
					}
				}
			}
		}

		public static string Decrypt(byte[] encryptedData, string password)
		{
			if (encryptedData.Length < SaltSize + IvSize)
			{
				throw new InvalidDataException("Encrypted data is invalid.");
			}

			byte[] salt = new byte[SaltSize];
			byte[] iv = new byte[IvSize];

			Array.Copy(encryptedData, 0, salt, 0, SaltSize);
			Array.Copy(encryptedData, SaltSize, iv, 0, IvSize);

			int cipherStart = SaltSize + IvSize;
			int cipherLength = encryptedData.Length - cipherStart;

			byte[] cipherBytes = new byte[cipherLength];
			Array.Copy(encryptedData, cipherStart, cipherBytes, 0, cipherLength);

			using (var key = new Rfc2898DeriveBytes(password, salt, Iterations))
			{
				using (var aes = Aes.Create())
				{
					aes.Mode = CipherMode.CBC;
					aes.Padding = PaddingMode.PKCS7;
					aes.Key = key.GetBytes(KeySize);
					aes.IV = iv;

					using (var ms = new MemoryStream(cipherBytes))
					{
						using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
						{
							using (var sr = new StreamReader(cs))
							{
								return sr.ReadToEnd();
							}
						}
					}
				}
			}
		}
	}
}