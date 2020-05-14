using System;
using System.Runtime.CompilerServices;
using ns24;

namespace ns17
{
	// Token: 0x0200028A RID: 650
	internal class EventArgs20 : EventArgs
	{
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00009CB9 File Offset: 0x00007EB9
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x00009CC1 File Offset: 0x00007EC1
		public Control4.Class311 ButtonBoardButton { get; private set; }

		// Token: 0x06001B02 RID: 6914 RVA: 0x00009CCA File Offset: 0x00007ECA
		public EventArgs20(Control4.Class311 buttonBoardButton)
		{
			this.ButtonBoardButton = buttonBoardButton;
		}

		// Token: 0x04000884 RID: 2180
		[CompilerGenerated]
		private Control4.Class311 class311_0;
	}
}
