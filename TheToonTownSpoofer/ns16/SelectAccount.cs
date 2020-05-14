using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns24;
using ns26;
using ns31;

namespace ns16
{
	// Token: 0x020003AE RID: 942
	internal sealed partial class SelectAccount : Form
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0000FE87 File Offset: 0x0000E087
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0000FE8F File Offset: 0x0000E08F
		public Class91 SelectedAccount { get; private set; }

		// Token: 0x0600249D RID: 9373 RVA: 0x0000FE98 File Offset: 0x0000E098
		public SelectAccount()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0007C860 File Offset: 0x0007AA60
		private void method_0()
		{
			this.lbAccounts.BeginUpdate();
			this.lbAccounts.Items.Clear();
			this.lbAccounts.Items.AddRange(Class110.Instance.ConnectSettings.ToonTownAccounts.ToArray());
			this.lbAccounts.EndUpdate();
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (this.lbAccounts.SelectedItems.Count > 0)
			{
				this.SelectedAccount = (this.lbAccounts.SelectedItem as Class91);
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00006181 File Offset: 0x00004381
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
		private void btnManager_Click(object sender, EventArgs e)
		{
			using (AccountManager accountManager = new AccountManager())
			{
				accountManager.ShowDialog();
			}
			Class110.smethod_1();
			this.method_0();
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0000FEDE File Offset: 0x0000E0DE
		private void lbAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnSelect.Enabled = (this.lbAccounts.SelectedIndex > -1);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
		private void lbAccounts_DoubleClick(object sender, EventArgs e)
		{
			if (this.lbAccounts.SelectedIndex > -1)
			{
				this.SelectedAccount = (this.lbAccounts.SelectedItem as Class91);
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x040010FF RID: 4351
		[CompilerGenerated]
		private Class91 class91_0;
	}
}
