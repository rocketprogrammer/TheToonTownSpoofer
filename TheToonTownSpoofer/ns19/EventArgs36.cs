using System;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x02000402 RID: 1026
	internal sealed class EventArgs36 : EventArgs
	{
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00011805 File Offset: 0x0000FA05
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x0001180D File Offset: 0x0000FA0D
		public Exception Exception { get; private set; }

		// Token: 0x06002713 RID: 10003 RVA: 0x00011816 File Offset: 0x0000FA16
		public EventArgs36(Exception ex)
		{
			this.Exception = ex;
		}

		// Token: 0x0400133E RID: 4926
		[CompilerGenerated]
		private Exception exception_0;
	}
}
