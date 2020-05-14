using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ns17;
using ns20;
using ns26;
using ns27;
using ns31;

namespace ns23
{
	// Token: 0x020003AC RID: 940
	internal sealed partial class ContentPackAgreement : Form
	{
		// Token: 0x06002489 RID: 9353 RVA: 0x0007C138 File Offset: 0x0007A338
		public ContentPackAgreement()
		{
			this.InitializeComponent();
			this.class112_0 = Class110.Instance.ApplicationSettings;
			base.Icon = Class480.PenPaper_Icon;
			if (!File.Exists(Class291.string_24))
			{
				this.AcceptBtn.Enabled = false;
				DialogBox.smethod_3(string.Format("The help file appears to be missing. You will be unable to read the Content Pack Agreement without the file '{0}'. Reinstalling The ToonTown Spoofer may fix this problem.", Path.GetFileName(Class291.string_24)), "File Not Found");
			}
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0000FDF9 File Offset: 0x0000DFF9
		private void AcceptBtn_Click(object sender, EventArgs e)
		{
			this.class112_0.AcceptedContentPackAgreement = true;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0000587F File Offset: 0x00003A7F
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0000FE14 File Offset: 0x0000E014
		private void ViewContentPackAgreement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class462.smethod_0(Enum51.const_16);
		}

		// Token: 0x040010F5 RID: 4341
		private Class112 class112_0;
	}
}
