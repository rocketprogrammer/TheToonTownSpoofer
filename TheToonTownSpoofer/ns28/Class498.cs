using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns17;
using ns25;

namespace ns28
{
	// Token: 0x020004A0 RID: 1184
	internal sealed class Class498
	{
		// Token: 0x06002C17 RID: 11287 RVA: 0x000AABEC File Offset: 0x000A8DEC
		internal static void smethod_0(Stream source, Stream destination, string sPassword, string sSalt)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(Class498.string_0);
			byte[] bytes2 = asciiencoding.GetBytes(sPassword);
			byte[] bytes3 = asciiencoding.GetBytes(sSalt);
			try
			{
				using (PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(bytes2, bytes3, Class498.string_1, Class498.int_1))
				{
					byte[] bytes4 = passwordDeriveBytes.GetBytes(Class498.int_0 / 8);
					using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
					{
						rijndaelManaged.Mode = CipherMode.CBC;
						using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes4, bytes))
						{
							using (CryptoStream cryptoStream = new CryptoStream(source, cryptoTransform, CryptoStreamMode.Read))
							{
								cryptoStream.CopyTo(destination);
							}
						}
						rijndaelManaged.Clear();
					}
				}
			}
			finally
			{
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000AACF4 File Offset: 0x000A8EF4
		internal static byte[] smethod_1(string productID, string name, string key)
		{
			byte[] result;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.GenerateKey();
				rijndaelManaged.GenerateIV();
				byte[] array;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor())
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
						{
							using (BinaryWriter binaryWriter = new BinaryWriter(cryptoStream, Class217.encoding_0))
							{
								binaryWriter.Write(name);
								binaryWriter.Write(key);
								binaryWriter.Write(Class317.HashedUniqueSerial);
								binaryWriter.Write(productID);
							}
						}
					}
					array = memoryStream.ToArray();
				}
				byte[] key2 = rijndaelManaged.Key;
				rijndaelManaged.GenerateKey();
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (BinaryWriter binaryWriter2 = new BinaryWriter(memoryStream2, Class217.encoding_0))
					{
						binaryWriter2.Write(array.Length);
						binaryWriter2.Write(array);
						binaryWriter2.Write(rijndaelManaged.IV.Length);
						binaryWriter2.Write(rijndaelManaged.IV);
						byte[] array2;
						using (MemoryStream memoryStream3 = new MemoryStream())
						{
							using (ICryptoTransform cryptoTransform2 = rijndaelManaged.CreateEncryptor())
							{
								using (CryptoStream cryptoStream2 = new CryptoStream(memoryStream3, cryptoTransform2, CryptoStreamMode.Write))
								{
									using (BinaryWriter binaryWriter3 = new BinaryWriter(cryptoStream2, Class217.encoding_0))
									{
										binaryWriter3.Write(key2);
									}
								}
							}
							array2 = memoryStream3.ToArray();
						}
						binaryWriter2.Write(array2.Length);
						binaryWriter2.Write(array2);
						binaryWriter2.Write(rijndaelManaged.Key.Length);
						binaryWriter2.Write(rijndaelManaged.Key);
						result = memoryStream2.ToArray();
					}
				}
			}
			return result;
		}

		// Token: 0x04001731 RID: 5937
		private static readonly string string_0 = "M3)c:qgE6}3cA0Cx";

		// Token: 0x04001732 RID: 5938
		private static readonly int int_0 = 256;

		// Token: 0x04001733 RID: 5939
		private static readonly int int_1 = 2;

		// Token: 0x04001734 RID: 5940
		private static readonly string string_1 = "SHA1";
	}
}
