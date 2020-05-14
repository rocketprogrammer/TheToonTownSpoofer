using System;

namespace ns28
{
	// Token: 0x020004BD RID: 1213
	internal static class Class510
	{
		// Token: 0x06002D8F RID: 11663 RVA: 0x00015CEB File Offset: 0x00013EEB
		public static string smethod_0(this int bytes)
		{
			return ((long)bytes).smethod_1();
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000AF3E8 File Offset: 0x000AD5E8
		public static string smethod_1(this long bytes)
		{
			string[] array = new string[]
			{
				"GB",
				"MB",
				"KB",
				"Bytes"
			};
			long num = (long)Math.Pow(1024.0, (double)(array.Length - 1));
			foreach (string arg in array)
			{
				if (bytes > num)
				{
					return string.Format("{0:##.##} {1}", decimal.Divide(bytes, num), arg);
				}
				num /= 1024L;
			}
			return "0 Bytes";
		}
	}
}
