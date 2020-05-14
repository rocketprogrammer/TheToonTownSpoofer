using System;
using System.Runtime.CompilerServices;
using ns21;

namespace ns20
{
	// Token: 0x0200042E RID: 1070
	internal sealed class EventArgs15 : EventArgs13
	{
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0001295D File Offset: 0x00010B5D
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x00012965 File Offset: 0x00010B65
		public bool IsValid { get; set; }

		// Token: 0x060028A0 RID: 10400 RVA: 0x00007EE1 File Offset: 0x000060E1
		public EventArgs15(IntPtr hWnd) : base(hWnd)
		{
		}

		// Token: 0x0400149B RID: 5275
		[CompilerGenerated]
		private bool bool_0;
	}
}
