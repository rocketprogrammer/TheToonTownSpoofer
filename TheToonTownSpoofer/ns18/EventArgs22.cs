using System;
using System.Runtime.CompilerServices;
using ns29;

namespace ns18
{
	// Token: 0x020002AC RID: 684
	internal sealed class EventArgs22 : EventArgs
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x0000A59E File Offset: 0x0000879E
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000A5A6 File Offset: 0x000087A6
		public Struct56 Coordinates { get; private set; }

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0000A5AF File Offset: 0x000087AF
		public EventArgs22(Struct56 coords)
		{
			this.Coordinates = coords;
		}

		// Token: 0x0400098E RID: 2446
		[CompilerGenerated]
		private Struct56 struct56_0;
	}
}
