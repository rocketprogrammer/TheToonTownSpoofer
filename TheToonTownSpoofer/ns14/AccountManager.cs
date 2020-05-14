using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns17;
using ns20;
using ns22;
using ns24;
using ns26;
using ns27;
using ns31;

namespace ns14
{
	// Token: 0x020001D1 RID: 465
	internal sealed partial class AccountManager : Form
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x0002B6E8 File Offset: 0x000298E8
		public AccountManager()
		{
			this.InitializeComponent();
			this.class99_0 = Class110.Instance.ConnectSettings;
			this.btnSaveAccount.Image = Class480.Save_16x16;
			this.CancelEditButton.Image = Class480.Cancel_16x16;
			this.btnDeleteAccount.Image = Class480.Delete_16x16;
			this.OKButton.Image = Class480.Checkmark_16x16;
			this.btnChangeAccount.Image = Class480.Edit_16x16;
			this.MoveDownButton.Image = Class480.Down_16x16;
			this.MoveUpButton.Image = Class480.Up_16x16;
			this.AccountsList.Items.AddRange(this.class99_0.ToonTownAccounts.ToArray());
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0002B7A4 File Offset: 0x000299A4
		private void btnChangeAccount_Click(object sender, EventArgs e)
		{
			this.class91_0 = (this.AccountsList.SelectedItem as Class91);
			this.txtAccountName.Text = this.class91_0.ReferenceName;
			this.txtUsername.Text = this.class91_0.Username;
			this.txtPassword.Text = this.class91_0.Password;
			if (this.class91_0.ToonTownAccountType == Enum101.const_1)
			{
				this.radOpenServer.Checked = true;
			}
			else
			{
				this.radTestServer.Checked = true;
			}
			this.method_1();
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0002B838 File Offset: 0x00029A38
		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			Class91 @class = this.AccountsList.SelectedItem as Class91;
			if (DialogResult.Yes == DialogBox.smethod_6(string.Format(AccountManager.string_6, @class.ReferenceName), AccountManager.string_7, new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}))
			{
				this.class99_0.ToonTownAccounts.Remove(@class);
				this.AccountsList.Items.Remove(@class);
				this.method_1();
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000058C7 File Offset: 0x00003AC7
		private void CancelEditButton_Click(object sender, EventArgs e)
		{
			this.class91_0 = null;
			this.method_0();
			this.method_1();
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0002B8AC File Offset: 0x00029AAC
		private void btnSaveAccount_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtAccountName.Text))
			{
				DialogBox.smethod_3(AccountManager.string_0, AccountManager.string_1);
				this.txtAccountName.Focus();
				return;
			}
			if (string.IsNullOrEmpty(this.txtUsername.Text))
			{
				DialogBox.smethod_3(AccountManager.string_2, AccountManager.string_3);
				this.txtUsername.Focus();
				return;
			}
			if (string.IsNullOrEmpty(this.txtPassword.Text))
			{
				DialogBox.smethod_3(AccountManager.string_4, AccountManager.string_5);
				this.txtPassword.Focus();
				return;
			}
			Enum101 @enum;
			if (this.radOpenServer.Checked)
			{
				@enum = Enum101.const_1;
			}
			else
			{
				@enum = Enum101.const_2;
			}
			if (this.class91_0 == null)
			{
				Class91 item = new Class91(this.txtAccountName.Text, this.txtUsername.Text, this.txtPassword.Text, @enum);
				this.class99_0.ToonTownAccounts.Add(item);
				this.AccountsList.Items.Add(item);
			}
			else
			{
				this.class91_0.ReferenceName = this.txtAccountName.Text;
				this.class91_0.Username = this.txtUsername.Text;
				this.class91_0.Password = this.txtPassword.Text;
				this.class91_0.ToonTownAccountType = @enum;
				this.AccountsList.imethod_0(this.AccountsList.SelectedIndex);
				this.class91_0 = null;
			}
			this.method_0();
			this.method_1();
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0002BA24 File Offset: 0x00029C24
		private void method_0()
		{
			this.txtAccountName.Text = string.Empty;
			this.txtUsername.Text = string.Empty;
			this.txtPassword.Text = string.Empty;
			this.radOpenServer.Checked = true;
			this.radTestServer.Checked = false;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000058DC File Offset: 0x00003ADC
		private void AccountsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0002BA7C File Offset: 0x00029C7C
		private void method_1()
		{
			if (this.class91_0 == null)
			{
				this.btnChangeAccount.Enabled = (this.btnDeleteAccount.Enabled = (this.AccountsList.SelectedIndex > -1));
				this.AccountsList.Enabled = true;
				this.CancelEditButton.Enabled = false;
				this.MoveDownButton.Enabled = (this.AccountsList.SelectedIndex < this.AccountsList.Items.Count - 1);
				this.MoveUpButton.Enabled = (this.AccountsList.SelectedIndex > 0);
				return;
			}
			Control moveUpButton = this.MoveUpButton;
			Control moveDownButton = this.MoveDownButton;
			Control accountsList = this.AccountsList;
			Control control = this.btnChangeAccount;
			this.btnDeleteAccount.Enabled = false;
			control.Enabled = false;
			accountsList.Enabled = false;
			moveDownButton.Enabled = false;
			moveUpButton.Enabled = false;
			this.CancelEditButton.Enabled = true;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00005870 File Offset: 0x00003A70
		private void OKButton_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000058E4 File Offset: 0x00003AE4
		private void AccountManager_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_26);
			e.Handled = true;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0002BB60 File Offset: 0x00029D60
		private void method_2(bool move_up)
		{
			int selectedIndex = this.AccountsList.SelectedIndex;
			int num;
			if (move_up)
			{
				num = selectedIndex - 1;
			}
			else
			{
				num = selectedIndex + 1;
			}
			Class91 item = this.AccountsList.SelectedItem as Class91;
			this.AccountsList.SelectedItem = null;
			this.AccountsList.Items.RemoveAt(selectedIndex);
			this.AccountsList.Items.Insert(num, item);
			this.class99_0.ToonTownAccounts.RemoveAt(selectedIndex);
			this.class99_0.ToonTownAccounts.Insert(num, item);
			this.AccountsList.SelectedIndex = num;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000058F4 File Offset: 0x00003AF4
		private void MoveDownButton_Click(object sender, EventArgs e)
		{
			this.method_2(false);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000058FD File Offset: 0x00003AFD
		private void MoveUpButton_Click(object sender, EventArgs e)
		{
			this.method_2(true);
		}

		// Token: 0x040002A5 RID: 677
		private static readonly string string_0 = "Please enter a name to identify this account.";

		// Token: 0x040002A6 RID: 678
		private static readonly string string_1 = "Missing Account Name";

		// Token: 0x040002A7 RID: 679
		private static readonly string string_2 = "Please enter your ToonTown username.";

		// Token: 0x040002A8 RID: 680
		private static readonly string string_3 = "Missing Username";

		// Token: 0x040002A9 RID: 681
		private static readonly string string_4 = "Please enter your ToonTown password.";

		// Token: 0x040002AA RID: 682
		private static readonly string string_5 = "Missing Password";

		// Token: 0x040002AB RID: 683
		private static readonly string string_6 = "Are you sure you want to delete the account named '{0}'?";

		// Token: 0x040002AC RID: 684
		private static readonly string string_7 = "Confirm Delete";

		// Token: 0x040002AD RID: 685
		private Class99 class99_0;

		// Token: 0x040002AE RID: 686
		private Class91 class91_0;
	}
}
