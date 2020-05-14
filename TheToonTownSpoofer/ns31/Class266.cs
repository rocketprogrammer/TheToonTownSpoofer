using System;
using System.IO;
using ns17;

namespace ns31
{
	// Token: 0x020002E1 RID: 737
	internal static class Class266
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x0005E1A4 File Offset: 0x0005C3A4
		public static string smethod_0(string path, string fileNameFormat)
		{
			if (string.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException("path");
			}
			if (string.IsNullOrWhiteSpace(fileNameFormat))
			{
				throw new ArgumentNullException("fileNameFormat");
			}
			int num = 0;
			for (;;)
			{
				string text = string.Format(Class217.cultureInfo_0, fileNameFormat, new object[]
				{
					num
				});
				string text2 = Path.Combine(path, text);
				if (text.Equals(fileNameFormat, StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				if (!File.Exists(text2))
				{
					return text2;
				}
				num++;
			}
			throw new ArgumentException("The resulting filename equals the fileNameFormat.");
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0005E228 File Offset: 0x0005C428
		public static string smethod_1(string directory, string fileNameFormat, string appendFormat)
		{
			if (string.IsNullOrWhiteSpace(directory))
			{
				throw new ArgumentNullException("path");
			}
			if (string.IsNullOrWhiteSpace(fileNameFormat))
			{
				throw new ArgumentNullException("fileNameFormat");
			}
			if (string.IsNullOrWhiteSpace(appendFormat))
			{
				throw new ArgumentNullException("appendFormat");
			}
			int num = 0;
			for (;;)
			{
				int num2 = num;
				string text;
				if (num2 == 0)
				{
					text = Path.Combine(directory, string.Format(Class217.cultureInfo_0, fileNameFormat, new object[]
					{
						string.Empty
					}));
				}
				else
				{
					string text2 = string.Format(Class217.cultureInfo_0, fileNameFormat, new object[]
					{
						string.Format(Class217.cultureInfo_0, appendFormat, new object[]
						{
							num
						})
					});
					if (text2.Equals(fileNameFormat, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					text = Path.Combine(directory, text2);
				}
				if (!File.Exists(text))
				{
					return text;
				}
				num++;
			}
			throw new ArgumentException("The resulting filename equals the fileNameFormat.");
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x0005E30C File Offset: 0x0005C50C
		public static string smethod_2(string directory, string extension)
		{
			string text;
			do
			{
				text = Path.Combine(directory, Guid.NewGuid().ToString() + extension);
			}
			while (File.Exists(text));
			return text;
		}
	}
}
