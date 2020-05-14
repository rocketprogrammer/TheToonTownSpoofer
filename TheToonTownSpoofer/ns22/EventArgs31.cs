using System;
using System.Runtime.CompilerServices;
using ns31;

namespace ns22
{
	// Token: 0x0200036F RID: 879
	internal sealed class EventArgs31 : EventArgs
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0000E7E2 File Offset: 0x0000C9E2
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x0000E7EA File Offset: 0x0000C9EA
		public Struct26 InvasionState { get; private set; }

		// Token: 0x0600226E RID: 8814 RVA: 0x0000E7F3 File Offset: 0x0000C9F3
		public EventArgs31(Struct26 state)
		{
			this.InvasionState = state;
		}

		// Token: 0x04000FCB RID: 4043
		[CompilerGenerated]
		private Struct26 struct26_0;
	}
}
