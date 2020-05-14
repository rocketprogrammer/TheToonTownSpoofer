using System;
using System.Runtime.CompilerServices;
using ns21;

namespace ns24
{
	// Token: 0x02000321 RID: 801
	internal class Class307
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0000C241 File Offset: 0x0000A441
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x0000C249 File Offset: 0x0000A449
		public string PhaseName { get; private set; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0000C252 File Offset: 0x0000A452
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x0000C25A File Offset: 0x0000A45A
		public string FileName { get; private set; }

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0000C263 File Offset: 0x0000A463
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0000C26B File Offset: 0x0000A46B
		public string FilePath { get; private set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0000C274 File Offset: 0x0000A474
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000C27C File Offset: 0x0000A47C
		public string AltFileName { get; private set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0000C285 File Offset: 0x0000A485
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000C28D File Offset: 0x0000A48D
		public string AltFilePath { get; private set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0000C296 File Offset: 0x0000A496
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000C29E File Offset: 0x0000A49E
		public Class186 FileDetails { get; protected set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0000C2A7 File Offset: 0x0000A4A7
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000C2AF File Offset: 0x0000A4AF
		public bool Virtualized { get; private set; }

		// Token: 0x06001F1D RID: 7965 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		public Class307(string phaseName, string fileName, string filePath, string altFileName, string altFilePath, bool virtualized)
		{
			this.PhaseName = phaseName;
			this.FileName = fileName;
			this.FilePath = filePath;
			this.AltFileName = altFileName;
			this.AltFilePath = altFilePath;
			this.Virtualized = virtualized;
		}

		// Token: 0x04000BF9 RID: 3065
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000BFA RID: 3066
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000BFB RID: 3067
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000BFC RID: 3068
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000BFD RID: 3069
		[CompilerGenerated]
		private string string_4;

		// Token: 0x04000BFE RID: 3070
		[CompilerGenerated]
		private Class186 class186_0;

		// Token: 0x04000BFF RID: 3071
		[CompilerGenerated]
		private bool bool_0;
	}
}
