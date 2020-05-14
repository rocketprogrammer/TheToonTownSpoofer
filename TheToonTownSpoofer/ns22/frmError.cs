using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns21;
using ns24;

namespace ns22
{
	// Token: 0x02000360 RID: 864
	internal sealed partial class frmError : Form
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0000E3CA File Offset: 0x0000C5CA
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x0000E3D2 File Offset: 0x0000C5D2
		public bool TryAgainLater { get; private set; }

		// Token: 0x06002213 RID: 8723 RVA: 0x00074074 File Offset: 0x00072274
		public frmError(EventArgs26 failArgs)
		{
			this.Font = SystemFonts.MessageBoxFont;
			this.InitializeComponent();
			this.richError.Text = failArgs.ErrorMessage;
			this.Text = "Error";
			this.btnOK.Text = "Close";
			this.btnTryAgainLater.Text = "Try again later";
			this.lblTitle.Text = failArgs.ErrorTitle;
			this.btnTryAgainLater.Left = this.btnOK.Left - this.btnTryAgainLater.Width - 6;
			this.MinimumSize = new Size(this.richError.Left + base.Right - this.btnTryAgainLater.Left, 250);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00074138 File Offset: 0x00072338
		protected override void OnLayout(LayoutEventArgs levent)
		{
			base.OnLayout(levent);
			if (this.richError != null)
			{
				this.richError.Width = base.ClientRectangle.Width - 2 * this.richError.Left;
				this.richError.Height = base.ClientRectangle.Height - this.richError.Top - this.richError.Left - (base.ClientRectangle.Height - this.btnOK.Top);
			}
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000050D4 File Offset: 0x000032D4
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0000E3DB File Offset: 0x0000C5DB
		private void btnTryAgainLater_Click(object sender, EventArgs e)
		{
			this.TryAgainLater = true;
			base.Close();
		}

		// Token: 0x04000E1B RID: 3611
		[CompilerGenerated]
		private bool bool_0;
	}
}
