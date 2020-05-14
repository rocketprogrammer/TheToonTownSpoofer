using System;
using System.Runtime.CompilerServices;

namespace ns15
{
	// Token: 0x02000206 RID: 518
	internal sealed class EventArgs8 : EventArgs
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00006BF6 File Offset: 0x00004DF6
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00006BFE File Offset: 0x00004DFE
		public Exception Exception { get; private set; }

		// Token: 0x060016DC RID: 5852 RVA: 0x00006C07 File Offset: 0x00004E07
		public EventArgs8(Exception ex)
		{
			this.Exception = ex;
		}

		// Token: 0x040004F5 RID: 1269
		[CompilerGenerated]
		private Exception exception_0;
	}
}
