using System;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x02000322 RID: 802
	internal sealed class Class309
	{
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0000C2ED File Offset: 0x0000A4ED
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x0000C2F5 File Offset: 0x0000A4F5
		public string FileName { get; private set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0000C2FE File Offset: 0x0000A4FE
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0000C306 File Offset: 0x0000A506
		public bool FileExists { get; set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0000C30F File Offset: 0x0000A50F
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0000C317 File Offset: 0x0000A517
		public string ClientMd5 { get; set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0000C320 File Offset: 0x0000A520
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0000C328 File Offset: 0x0000A528
		public string ExpectedMd5 { get; set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0000C331 File Offset: 0x0000A531
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0000C339 File Offset: 0x0000A539
		public bool UpToDate { get; set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0000C342 File Offset: 0x0000A542
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000C34A File Offset: 0x0000A54A
		public int ClientSize { get; set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0000C353 File Offset: 0x0000A553
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0000C35B File Offset: 0x0000A55B
		public int ExpectedSize { get; set; }

		// Token: 0x06001F2C RID: 7980 RVA: 0x0000C364 File Offset: 0x0000A564
		public Class309(string fileName)
		{
			this.FileName = fileName;
			this.FileExists = false;
			this.ClientMd5 = null;
			this.ExpectedMd5 = null;
			this.UpToDate = false;
			this.ClientSize = 0;
			this.ExpectedSize = 0;
		}

		// Token: 0x04000C00 RID: 3072
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000C01 RID: 3073
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000C02 RID: 3074
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000C03 RID: 3075
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000C04 RID: 3076
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000C05 RID: 3077
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000C06 RID: 3078
		[CompilerGenerated]
		private int int_1;
	}
}
