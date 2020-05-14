using System;
using System.Runtime.CompilerServices;

namespace ns15
{
	// Token: 0x0200020F RID: 527
	internal sealed class EventArgs11 : EventArgs
	{
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00006EE7 File Offset: 0x000050E7
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00006EEF File Offset: 0x000050EF
		public string DataReceived { get; private set; }

		// Token: 0x06001716 RID: 5910 RVA: 0x00006EF8 File Offset: 0x000050F8
		public EventArgs11(string dataReceived)
		{
			this.DataReceived = dataReceived;
		}

		// Token: 0x0400050D RID: 1293
		[CompilerGenerated]
		private string string_0;
	}
}
