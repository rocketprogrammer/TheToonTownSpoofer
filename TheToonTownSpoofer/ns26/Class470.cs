using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns30;

namespace ns26
{
	// Token: 0x02000465 RID: 1125
	internal static class Class470
	{
		// Token: 0x060029CA RID: 10698 RVA: 0x000A02B8 File Offset: 0x0009E4B8
		internal static void smethod_0(string initialVector, Stream source, Stream destination)
		{
			byte[] array = new byte[40];
			Class124.Instance.method_7(array);
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(initialVector);
			byte[] array2 = new byte[16];
			Class124.Instance.method_7(array2);
			byte[] array3 = new byte[array.Length + array2.Length];
			Array.Copy(array, 0, array3, 0, 40);
			Array.Copy(array2, 0, array3, 40, 16);
			array3 = Class470.smethod_2(array3);
			destination.Write(array3, 0, array3.Length);
			using (PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(array, array2, Class470.string_0, Class470.int_1))
			{
				byte[] bytes2 = passwordDeriveBytes.GetBytes(Class470.int_0 / 8);
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.Mode = CipherMode.CBC;
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(bytes2, bytes))
					{
						using (CryptoStream cryptoStream = new CryptoStream(destination, cryptoTransform, CryptoStreamMode.Write))
						{
							source.CopyTo(cryptoStream);
						}
					}
					rijndaelManaged.Clear();
				}
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000A03FC File Offset: 0x0009E5FC
		internal static void smethod_1(string initialVector, Stream source, Stream destination)
		{
			byte[] array = new byte[56];
			byte[] array2 = new byte[40];
			byte[] array3 = new byte[16];
			source.Read(array, 0, 56);
			array = Class470.smethod_3(array);
			Array.Copy(array, 0, array2, 0, 40);
			Array.Copy(array, 40, array3, 0, 16);
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(initialVector);
			using (PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(array2, array3, Class470.string_0, Class470.int_1))
			{
				byte[] bytes2 = passwordDeriveBytes.GetBytes(Class470.int_0 / 8);
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.Mode = CipherMode.CBC;
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes2, bytes))
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

		// Token: 0x060029CC RID: 10700 RVA: 0x000A0520 File Offset: 0x0009E720
		private static byte[] smethod_2(byte[] data)
		{
			if (data.Length % 2 != 0)
			{
				throw new ArgumentException();
			}
			byte[] array = new byte[data.Length];
			data.CopyTo(array, 0);
			Array.Reverse(array);
			return Class470.smethod_5(Class470.smethod_4(Class470.smethod_6(array)));
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000A0564 File Offset: 0x0009E764
		private static byte[] smethod_3(byte[] data)
		{
			if (data.Length % 2 != 0)
			{
				throw new ArgumentException();
			}
			byte[] array = Class470.smethod_6(Class470.smethod_4(Class470.smethod_5(data)));
			Array.Reverse(array);
			return array;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000A0598 File Offset: 0x0009E798
		private static byte[] smethod_4(byte[] data)
		{
			byte[] array = new byte[data.Length];
			int i;
			for (i = 0; i < data.Length - 2; i += 3)
			{
				array[i] = data[i + 2];
				array[i + 1] = data[i + 1];
				array[i + 2] = data[i];
			}
			while (i < data.Length)
			{
				array[i] = data[i];
				i++;
			}
			return array;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000A05EC File Offset: 0x0009E7EC
		private static byte[] smethod_5(byte[] data)
		{
			byte[] array = new byte[data.Length];
			int i;
			for (i = 0; i < data.Length - 1; i += 2)
			{
				array[i] = data[i + 1];
				array[i + 1] = data[i];
			}
			while (i < data.Length)
			{
				array[i] = data[i];
				i++;
			}
			return array;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000A0638 File Offset: 0x0009E838
		private static byte[] smethod_6(byte[] data)
		{
			byte[] array = new byte[data.Length];
			int num = data.Length / 2;
			for (int i = 0; i < num; i++)
			{
				array[num + i] = data[i];
			}
			for (int j = data.Length - 1; j >= num; j--)
			{
				array[j - num] = data[j];
			}
			return array;
		}

		// Token: 0x040015E8 RID: 5608
		private static readonly string string_0 = "SHA1";

		// Token: 0x040015E9 RID: 5609
		private static readonly int int_0 = 256;

		// Token: 0x040015EA RID: 5610
		private static readonly int int_1 = 7;
	}
}
