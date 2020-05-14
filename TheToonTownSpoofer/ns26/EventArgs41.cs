using System;
using System.Runtime.CompilerServices;

namespace ns26
{
	// Token: 0x0200045C RID: 1116
	internal sealed class EventArgs41 : EventArgs
	{
		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0001341B File Offset: 0x0001161B
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00013423 File Offset: 0x00011623
		public int HotkeyID { get; private set; }

		// Token: 0x060029AA RID: 10666 RVA: 0x0001342C File Offset: 0x0001162C
		public EventArgs41(int hotkeyID)
		{
			this.HotkeyID = hotkeyID;
		}

		// Token: 0x040015CC RID: 5580
		[CompilerGenerated]
		private int int_0;
	}
}
