using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns20;
using ns23;
using ns26;

namespace ns29
{
	// Token: 0x020004C2 RID: 1218
	internal static class Class513
	{
		// Token: 0x06002DA9 RID: 11689 RVA: 0x000AF814 File Offset: 0x000ADA14
		public static Struct43 smethod_0(string fileName)
		{
			Struct43 result;
			using (Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				result = stream.smethod_2();
			}
			return result;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000AF850 File Offset: 0x000ADA50
		public static string smethod_1(string data)
		{
			if (data == null)
			{
				return null;
			}
			string result;
			try
			{
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				result = Class513.smethod_2(unicodeEncoding.GetBytes(data));
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000AF890 File Offset: 0x000ADA90
		public static string smethod_2(byte[] data)
		{
			if (data == null)
			{
				return null;
			}
			new UnicodeEncoding();
			string result;
			using (SHA1 sha = new SHA1CryptoServiceProvider())
			{
				try
				{
					result = BitConverter.ToString(sha.ComputeHash(data)).Replace("-", "");
				}
				catch (Exception ex)
				{
					ex.smethod_0();
					result = null;
				}
			}
			return result;
		}
	}
}
