using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns18
{
	// Token: 0x02000298 RID: 664
	internal partial class Form1 : Form
	{
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x00009FF4 File Offset: 0x000081F4
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x00009FFC File Offset: 0x000081FC
		private protected bool FullScreen { protected get; private set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0000A005 File Offset: 0x00008205
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0000A00D File Offset: 0x0000820D
		private protected FormWindowState PreviousWindowState { protected get; private set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0000A016 File Offset: 0x00008216
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0000A01E File Offset: 0x0000821E
		private protected Rectangle PreviousWindowBounds { protected get; private set; }

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0000A027 File Offset: 0x00008227
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0000A02F File Offset: 0x0000822F
		private protected FormBorderStyle PreviousFormBorderStyle { protected get; private set; }

		// Token: 0x06001B6E RID: 7022 RVA: 0x00055708 File Offset: 0x00053908
		protected void method_0(bool fullScreen)
		{
			base.SuspendLayout();
			if (fullScreen)
			{
				this.PreviousWindowState = base.WindowState;
				base.WindowState = FormWindowState.Normal;
				this.PreviousWindowBounds = base.Bounds;
				this.PreviousFormBorderStyle = base.FormBorderStyle;
				base.FormBorderStyle = FormBorderStyle.None;
				base.Bounds = Screen.FromControl(this).Bounds;
				this.FullScreen = true;
			}
			else
			{
				base.FormBorderStyle = this.PreviousFormBorderStyle;
				base.Bounds = this.PreviousWindowBounds;
				base.WindowState = this.PreviousWindowState;
				this.FullScreen = false;
			}
			base.ResumeLayout(true);
		}

		// Token: 0x0400091B RID: 2331
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400091C RID: 2332
		[CompilerGenerated]
		private FormWindowState formWindowState_0;

		// Token: 0x0400091D RID: 2333
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x0400091E RID: 2334
		[CompilerGenerated]
		private FormBorderStyle formBorderStyle_0;
	}
}
