using System;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x020001DB RID: 475
	internal sealed class EventArgs2 : EventArgs
	{
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x00005F7E File Offset: 0x0000417E
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00005F86 File Offset: 0x00004186
		public long DownloadSize { get; protected set; }

		// Token: 0x060015C0 RID: 5568 RVA: 0x00005F8F File Offset: 0x0000418F
		public EventArgs2(long downloadSize)
		{
			this.DownloadSize = downloadSize;
		}

		// Token: 0x04000318 RID: 792
		[CompilerGenerated]
		private long long_0;
	}
}
