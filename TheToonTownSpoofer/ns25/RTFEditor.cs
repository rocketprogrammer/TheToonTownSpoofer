using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns26;

namespace ns25
{
	// Token: 0x02000349 RID: 841
	internal sealed partial class RTFEditor : Form
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x0000D44D File Offset: 0x0000B64D
		public RTFEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0000D45B File Offset: 0x0000B65B
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0000D468 File Offset: 0x0000B668
		public string Value
		{
			get
			{
				return this.rtfValue.Rtf;
			}
			set
			{
				this.rtfValue.Rtf = value;
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0000A641 File Offset: 0x00008841
		private void btnAccept_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00006181 File Offset: 0x00004381
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}
	}
}
