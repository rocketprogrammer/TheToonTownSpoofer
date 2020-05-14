using System;
using System.Runtime.CompilerServices;

namespace ns17
{
	// Token: 0x0200027B RID: 635
	internal sealed class EventArgs19 : EventArgs
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0000995A File Offset: 0x00007B5A
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x00009962 File Offset: 0x00007B62
		public bool Cancel { get; set; }

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0000996B File Offset: 0x00007B6B
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00009973 File Offset: 0x00007B73
		public string CancelReason { get; set; }

		// Token: 0x0400080E RID: 2062
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400080F RID: 2063
		[CompilerGenerated]
		private string string_0;
	}
}
