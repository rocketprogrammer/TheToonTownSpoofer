using System;
using System.Globalization;
using System.Text;

namespace ns17
{
	// Token: 0x02000279 RID: 633
	internal static class Class217
	{
		// Token: 0x04000806 RID: 2054
		public static readonly CultureInfo cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");

		// Token: 0x04000807 RID: 2055
		public static CultureInfo cultureInfo_1 = CultureInfo.GetCultureInfo("en-US");

		// Token: 0x04000808 RID: 2056
		public static StringComparer stringComparer_0 = StringComparer.Create(Class217.cultureInfo_1, true);

		// Token: 0x04000809 RID: 2057
		public static StringComparer stringComparer_1 = StringComparer.Create(Class217.cultureInfo_1, true);

		// Token: 0x0400080A RID: 2058
		public static readonly Encoding encoding_0 = Encoding.Unicode;

		// Token: 0x0400080B RID: 2059
		public static readonly Encoding encoding_1 = Encoding.ASCII;

		// Token: 0x0400080C RID: 2060
		public static readonly Encoding encoding_2 = Encoding.ASCII;
	}
}
