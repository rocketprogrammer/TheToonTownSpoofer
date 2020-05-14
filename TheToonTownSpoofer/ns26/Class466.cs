using System;
using System.IO;
using System.Security.Cryptography;
using ns20;

namespace ns26
{
	// Token: 0x02000461 RID: 1121
	internal static class Class466
	{
		// Token: 0x060029B8 RID: 10680 RVA: 0x0009FE40 File Offset: 0x0009E040
		public static Struct43 smethod_0(this byte[] data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			Struct43 result;
			using (MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				result = new Struct43(BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(data, 0, data.Length)));
			}
			return result;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0009FE94 File Offset: 0x0009E094
		public static Struct43 smethod_1(this Stream stream, int startPosition, int length)
		{
			long position = stream.Position;
			stream.Position = (long)startPosition;
			byte[] buffer = new byte[length];
			stream.Read(buffer, 0, length);
			Struct43 result;
			using (MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				result = new Struct43(BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(buffer, 0, length)));
			}
			stream.Position = position;
			return result;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0009FF00 File Offset: 0x0009E100
		public static Struct43 smethod_2(this Stream stream)
		{
			long position = stream.Position;
			stream.Position = 0L;
			Struct43 result;
			using (MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				result = new Struct43(BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(stream)));
			}
			stream.Position = position;
			return result;
		}
	}
}
