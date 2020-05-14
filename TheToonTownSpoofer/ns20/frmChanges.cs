using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns21;

namespace ns20
{
	// Token: 0x02000426 RID: 1062
	internal sealed partial class frmChanges : Form
	{
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x00012557 File Offset: 0x00010757
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x0001255F File Offset: 0x0001075F
		public bool UpdateNow { get; private set; }

		// Token: 0x06002865 RID: 10341 RVA: 0x00098C98 File Offset: 0x00096E98
		public frmChanges(string version, string changes, bool isRTF, bool showUpdateNow)
		{
			this.Font = SystemFonts.MessageBoxFont;
			this.InitializeComponent();
			if (isRTF)
			{
				this.richChanges.Rtf = changes;
			}
			else
			{
				this.richChanges.Text = changes;
			}
			this.Text = (this.lblTitle.Text = string.Format("Changes in version {0}", version));
			Label label = this.lblTitle;
			label.Text += ":";
			this.btnUpdateNow.Text = "Update now";
			this.btnOK.Text = "Close";
			this.btnUpdateNow.Left = this.btnOK.Left - this.btnUpdateNow.Width - 6;
			this.MinimumSize = new Size(this.richChanges.Left + base.Right - this.btnUpdateNow.Left, 250);
			if (!showUpdateNow)
			{
				this.btnUpdateNow.Visible = false;
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00098D98 File Offset: 0x00096F98
		protected override void OnLayout(LayoutEventArgs levent)
		{
			base.OnLayout(levent);
			if (this.richChanges != null)
			{
				this.richChanges.Width = base.ClientRectangle.Width - 2 * this.richChanges.Left;
				this.richChanges.Height = base.ClientRectangle.Height - this.richChanges.Top - this.richChanges.Left - (base.ClientRectangle.Height - this.btnOK.Top);
			}
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000050D4 File Offset: 0x000032D4
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00012568 File Offset: 0x00010768
		private void btnUpdateNow_Click(object sender, EventArgs e)
		{
			this.UpdateNow = true;
			base.Close();
		}

		// Token: 0x0400146D RID: 5229
		[CompilerGenerated]
		private bool bool_0;
	}
}
