using System;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000340 RID: 832
	internal sealed class Class319
	{
		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0000D118 File Offset: 0x0000B318
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0000D120 File Offset: 0x0000B320
		public Uri DownloadUri { get; private set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0000D129 File Offset: 0x0000B329
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0000D131 File Offset: 0x0000B331
		public Version MinimumVersion { get; private set; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0000D13A File Offset: 0x0000B33A
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x0000D142 File Offset: 0x0000B342
		public Version ExpectedContentPackVersion { get; private set; }

		// Token: 0x0600203D RID: 8253 RVA: 0x0000D14B File Offset: 0x0000B34B
		public Class319(Uri downloadUri, Version minimumVersion, Version expectedContentPackVersion)
		{
			this.DownloadUri = downloadUri;
			this.MinimumVersion = minimumVersion;
			this.ExpectedContentPackVersion = expectedContentPackVersion;
		}

		// Token: 0x04000D01 RID: 3329
		[CompilerGenerated]
		private Uri uri_0;

		// Token: 0x04000D02 RID: 3330
		[CompilerGenerated]
		private Version version_0;

		// Token: 0x04000D03 RID: 3331
		[CompilerGenerated]
		private Version version_1;
	}
}
