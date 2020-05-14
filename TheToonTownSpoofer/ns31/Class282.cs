using System;
using System.Runtime.CompilerServices;
using ns20;
using ns21;

namespace ns31
{
	// Token: 0x020002F4 RID: 756
	internal sealed class Class282 : Interface15<Class282>
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0000B24F File Offset: 0x0000944F
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000B257 File Offset: 0x00009457
		public uint ExpectedFileSize { get; set; }

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0000B260 File Offset: 0x00009460
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000B268 File Offset: 0x00009468
		public uint ResultingFileSize { get; set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0000B271 File Offset: 0x00009471
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000B279 File Offset: 0x00009479
		public Struct43 ExpectedHash { get; set; }

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0000B282 File Offset: 0x00009482
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000B28A File Offset: 0x0000948A
		public Struct43 ResultingHash { get; set; }

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0000B293 File Offset: 0x00009493
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000B29B File Offset: 0x0000949B
		public string Version { get; set; }

		// Token: 0x06001D9F RID: 7583 RVA: 0x0005F14C File Offset: 0x0005D34C
		public Class186 method_0()
		{
			return new Class186
			{
				ExpectedHash = this.ResultingHash,
				ExpectedSize = (long)((ulong)this.ResultingFileSize),
				Version = this.Version
			};
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0005F188 File Offset: 0x0005D388
		public Class282 imethod_0()
		{
			return new Class282
			{
				ExpectedFileSize = this.ExpectedFileSize,
				ResultingFileSize = this.ResultingFileSize,
				ExpectedHash = this.ExpectedHash,
				ResultingHash = this.ResultingHash,
				Version = this.Version
			};
		}

		// Token: 0x04000B01 RID: 2817
		[CompilerGenerated]
		private uint uint_0;

		// Token: 0x04000B02 RID: 2818
		[CompilerGenerated]
		private uint uint_1;

		// Token: 0x04000B03 RID: 2819
		[CompilerGenerated]
		private Struct43 struct43_0;

		// Token: 0x04000B04 RID: 2820
		[CompilerGenerated]
		private Struct43 struct43_1;

		// Token: 0x04000B05 RID: 2821
		[CompilerGenerated]
		private string string_0;
	}
}
