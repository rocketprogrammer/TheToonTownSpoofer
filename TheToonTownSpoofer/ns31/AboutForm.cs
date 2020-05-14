using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns28;

namespace ns31
{
	// Token: 0x020002D5 RID: 725
	internal sealed partial class AboutForm : Form
	{
		// Token: 0x06001CCE RID: 7374 RVA: 0x0005D990 File Offset: 0x0005BB90
		public AboutForm()
		{
			this.InitializeComponent();
			this.TitleVersionLabel.Text = string.Format(this.TitleVersionLabel.Text, Class500.Current.FileVersion);
			this.CopyrightLabel.Text = string.Format(this.CopyrightLabel.Text, DateTime.Now.Year);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000050D4 File Offset: 0x000032D4
		private void OKButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0000AF54 File Offset: 0x00009154
		private void LicenseAgreementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class462.smethod_0(Enum51.const_17);
		}
	}
}
