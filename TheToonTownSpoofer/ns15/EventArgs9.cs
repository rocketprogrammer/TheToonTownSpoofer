using System;
using System.Runtime.CompilerServices;

namespace ns15
{
	// Token: 0x02000207 RID: 519
	internal class EventArgs9 : EventArgs
	{
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00006C16 File Offset: 0x00004E16
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00006C1E File Offset: 0x00004E1E
		public long TotalCompleted { get; protected set; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00006C27 File Offset: 0x00004E27
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00006C2F File Offset: 0x00004E2F
		public long TotalToComplete { get; protected set; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00006C38 File Offset: 0x00004E38
		public long TotalRemaining
		{
			get
			{
				return this.TotalToComplete - this.TotalCompleted;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00006C47 File Offset: 0x00004E47
		public int PercentComplete
		{
			get
			{
				return EventArgs9.smethod_0(this.TotalCompleted, this.TotalToComplete);
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00006C5A File Offset: 0x00004E5A
		public EventArgs9(long totalCompleted, long totalToComplete)
		{
			this.TotalCompleted = totalCompleted;
			this.TotalToComplete = totalToComplete;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00006C70 File Offset: 0x00004E70
		public static int smethod_0(long totalCompleted, long totalToComplete)
		{
			if (totalToComplete <= 0L)
			{
				return 100;
			}
			return (int)(totalCompleted * 100L / totalToComplete);
		}

		// Token: 0x040004F6 RID: 1270
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040004F7 RID: 1271
		[CompilerGenerated]
		private long long_1;
	}
}
