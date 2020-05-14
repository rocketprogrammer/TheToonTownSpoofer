using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000204 RID: 516
	internal partial class InputFormBase : Form
	{
		// Token: 0x060016C5 RID: 5829 RVA: 0x00006B0B File Offset: 0x00004D0B
		public InputFormBase()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00006B19 File Offset: 0x00004D19
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00006B26 File Offset: 0x00004D26
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string LabelMessage
		{
			get
			{
				return this.lblMessage.Text;
			}
			set
			{
				this.lblMessage.Text = value;
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00006181 File Offset: 0x00004381
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00006B34 File Offset: 0x00004D34
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!this.vmethod_0())
			{
				return;
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00005B66 File Offset: 0x00003D66
		protected virtual bool vmethod_0()
		{
			return true;
		}
	}
}
