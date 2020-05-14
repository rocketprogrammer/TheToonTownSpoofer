using System;

namespace ns15
{
	// Token: 0x02000208 RID: 520
	internal sealed class EventArgs10 : EventArgs9
	{
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00006C8F File Offset: 0x00004E8F
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x00006C97 File Offset: 0x00004E97
		public long TotalDownloaded
		{
			get
			{
				return base.TotalCompleted;
			}
			protected set
			{
				base.TotalCompleted = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x00006CA0 File Offset: 0x00004EA0
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public long TotalToDownload
		{
			get
			{
				return base.TotalToComplete;
			}
			protected set
			{
				base.TotalToComplete = value;
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00006CB1 File Offset: 0x00004EB1
		public EventArgs10(long totalDownloaded, long totalToDownload) : base(totalDownloaded, totalToDownload)
		{
			this.TotalDownloaded = totalDownloaded;
			this.TotalToDownload = totalToDownload;
		}
	}
}
