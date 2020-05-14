using System;
using System.IO;

namespace ns23
{
	// Token: 0x0200039F RID: 927
	internal static class Class369
	{
		// Token: 0x060023FA RID: 9210 RVA: 0x00079FC8 File Offset: 0x000781C8
		public static bool smethod_0(string directory)
		{
			if (Class369.smethod_2(directory) && Class369.smethod_1(directory))
			{
				bool result;
				try
				{
					Directory.Delete(directory);
					result = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						"Directory: " + directory
					});
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0007A024 File Offset: 0x00078224
		public static bool smethod_1(string directory)
		{
			bool result;
			try
			{
				result = (Directory.GetFiles(directory).Length > 0 && Directory.GetDirectories(directory).Length > 0);
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					"Directory: " + directory
				});
				result = true;
			}
			return result;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0007A080 File Offset: 0x00078280
		public static bool smethod_2(string directory)
		{
			bool result;
			try
			{
				result = Directory.Exists(directory);
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					"Directory: " + directory
				});
				result = false;
			}
			return result;
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0007A0C8 File Offset: 0x000782C8
		public static bool smethod_3(string fileName)
		{
			if (!Class369.smethod_4(fileName))
			{
				return false;
			}
			bool result;
			try
			{
				File.Delete(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					"FileName: " + fileName
				});
				result = false;
			}
			return result;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0007A11C File Offset: 0x0007831C
		public static bool smethod_4(string fileName)
		{
			bool result;
			try
			{
				result = File.Exists(fileName);
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					"FileName: " + fileName
				});
				result = false;
			}
			return result;
		}
	}
}
