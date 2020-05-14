using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns24;

namespace ns17
{
	// Token: 0x0200028B RID: 651
	internal sealed class EventArgs21 : EventArgs20
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00009CD9 File Offset: 0x00007ED9
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x00009CE1 File Offset: 0x00007EE1
		public MouseButtons MouseButton { get; private set; }

		// Token: 0x06001B05 RID: 6917 RVA: 0x00009CEA File Offset: 0x00007EEA
		public EventArgs21(Control4.Class311 buttonBoardButton, MouseButtons button) : base(buttonBoardButton)
		{
			this.MouseButton = button;
		}

		// Token: 0x04000885 RID: 2181
		[CompilerGenerated]
		private MouseButtons mouseButtons_0;
	}
}
