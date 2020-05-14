using System;
using System.Runtime.CompilerServices;
using ns21;

namespace ns17
{
	// Token: 0x0200027A RID: 634
	internal sealed class EventArgs18 : EventArgs
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0000993A File Offset: 0x00007B3A
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x00009942 File Offset: 0x00007B42
		public Class183 State { get; private set; }

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0000994B File Offset: 0x00007B4B
		public EventArgs18(Class183 state)
		{
			this.State = state;
		}

		// Token: 0x0400080D RID: 2061
		[CompilerGenerated]
		private Class183 class183_0;
	}
}
