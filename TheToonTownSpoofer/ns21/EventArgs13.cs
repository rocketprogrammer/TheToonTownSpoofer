using System;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x0200023B RID: 571
	internal class EventArgs13 : EventArgs
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00007EC1 File Offset: 0x000060C1
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x00007EC9 File Offset: 0x000060C9
		public IntPtr Handle { get; private set; }

		// Token: 0x06001878 RID: 6264 RVA: 0x00007ED2 File Offset: 0x000060D2
		public EventArgs13(IntPtr hWnd)
		{
			this.Handle = hWnd;
		}

		// Token: 0x04000679 RID: 1657
		[CompilerGenerated]
		private IntPtr intptr_0;
	}
}
