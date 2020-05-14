namespace ns14
{
	// Token: 0x020001D1 RID: 465
	internal sealed partial class AccountManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06001522 RID: 5410 RVA: 0x00005906 File Offset: 0x00003B06
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0002BBF8 File Offset: 0x00029DF8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns14.AccountManager));
			this.AccountsList = new global::ns31.Class293();
			this.txtAccountName = new global::System.Windows.Forms.TextBox();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.btnSaveAccount = new global::System.Windows.Forms.Button();
			this.CancelEditButton = new global::System.Windows.Forms.Button();
			this.btnDeleteAccount = new global::System.Windows.Forms.Button();
			this.btnChangeAccount = new global::System.Windows.Forms.Button();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.radTestServer = new global::System.Windows.Forms.RadioButton();
			this.radOpenServer = new global::System.Windows.Forms.RadioButton();
			this.smoothGroup1 = new global::ns24.Class310();
			this.MoveDownButton = new global::System.Windows.Forms.Button();
			this.MoveUpButton = new global::System.Windows.Forms.Button();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.smoothGroup1.SuspendLayout();
			base.SuspendLayout();
			this.AccountsList.Font = new global::System.Drawing.Font("Georgia", 9.75f);
			this.AccountsList.FormattingEnabled = true;
			this.AccountsList.ItemHeight = 16;
			this.AccountsList.Location = new global::System.Drawing.Point(323, 41);
			this.AccountsList.Name = "AccountsList";
			this.AccountsList.Size = new global::System.Drawing.Size(237, 116);
			this.AccountsList.TabIndex = 5;
			this.AccountsList.SelectedIndexChanged += new global::System.EventHandler(this.AccountsList_SelectedIndexChanged);
			this.txtAccountName.Font = new global::System.Drawing.Font("Georgia", 9.75f);
			this.txtAccountName.Location = new global::System.Drawing.Point(161, 41);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new global::System.Drawing.Size(156, 22);
			this.txtAccountName.TabIndex = 0;
			this.txtUsername.Font = new global::System.Drawing.Font("Georgia", 9.75f);
			this.txtUsername.Location = new global::System.Drawing.Point(161, 72);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(156, 22);
			this.txtUsername.TabIndex = 1;
			this.txtPassword.Font = new global::System.Drawing.Font("Georgia", 9.75f);
			this.txtPassword.Location = new global::System.Drawing.Point(161, 103);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(156, 22);
			this.txtPassword.TabIndex = 2;
			this.btnSaveAccount.Location = new global::System.Drawing.Point(323, 160);
			this.btnSaveAccount.Name = "btnSaveAccount";
			this.btnSaveAccount.Size = new global::System.Drawing.Size(26, 26);
			this.btnSaveAccount.TabIndex = 6;
			this.toolTip_0.SetToolTip(this.btnSaveAccount, "Save the account");
			this.btnSaveAccount.UseVisualStyleBackColor = true;
			this.btnSaveAccount.Click += new global::System.EventHandler(this.btnSaveAccount_Click);
			this.CancelEditButton.Enabled = false;
			this.CancelEditButton.Location = new global::System.Drawing.Point(355, 160);
			this.CancelEditButton.Name = "CancelEditButton";
			this.CancelEditButton.Size = new global::System.Drawing.Size(26, 26);
			this.CancelEditButton.TabIndex = 7;
			this.toolTip_0.SetToolTip(this.CancelEditButton, "Cancel changes");
			this.CancelEditButton.UseVisualStyleBackColor = true;
			this.CancelEditButton.Click += new global::System.EventHandler(this.CancelEditButton_Click);
			this.btnDeleteAccount.Enabled = false;
			this.btnDeleteAccount.Location = new global::System.Drawing.Point(387, 160);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new global::System.Drawing.Size(26, 26);
			this.btnDeleteAccount.TabIndex = 8;
			this.toolTip_0.SetToolTip(this.btnDeleteAccount, "Delete the selected account");
			this.btnDeleteAccount.UseVisualStyleBackColor = true;
			this.btnDeleteAccount.Click += new global::System.EventHandler(this.btnDeleteAccount_Click);
			this.btnChangeAccount.Enabled = false;
			this.btnChangeAccount.Location = new global::System.Drawing.Point(419, 160);
			this.btnChangeAccount.Name = "btnChangeAccount";
			this.btnChangeAccount.Size = new global::System.Drawing.Size(26, 26);
			this.btnChangeAccount.TabIndex = 9;
			this.toolTip_0.SetToolTip(this.btnChangeAccount, "Edit the selected account");
			this.btnChangeAccount.UseVisualStyleBackColor = true;
			this.btnChangeAccount.Click += new global::System.EventHandler(this.btnChangeAccount_Click);
			this.OKButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.OKButton.Location = new global::System.Drawing.Point(451, 160);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(26, 26);
			this.OKButton.TabIndex = 10;
			this.toolTip_0.SetToolTip(this.OKButton, "Return");
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			this.radTestServer.AutoSize = true;
			this.radTestServer.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.radTestServer.Font = new global::System.Drawing.Font("Georgia", 8.25f);
			this.radTestServer.ForeColor = global::System.Drawing.Color.DimGray;
			this.radTestServer.Location = new global::System.Drawing.Point(218, 132);
			this.radTestServer.Name = "radTestServer";
			this.radTestServer.Size = new global::System.Drawing.Size(49, 18);
			this.radTestServer.TabIndex = 4;
			this.radTestServer.Text = "Test";
			this.radTestServer.UseVisualStyleBackColor = false;
			this.radOpenServer.AutoSize = true;
			this.radOpenServer.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.radOpenServer.Checked = true;
			this.radOpenServer.Font = new global::System.Drawing.Font("Georgia", 8.25f);
			this.radOpenServer.ForeColor = global::System.Drawing.Color.DimGray;
			this.radOpenServer.Location = new global::System.Drawing.Point(157, 132);
			this.radOpenServer.Name = "radOpenServer";
			this.radOpenServer.Size = new global::System.Drawing.Size(55, 18);
			this.radOpenServer.TabIndex = 3;
			this.radOpenServer.TabStop = true;
			this.radOpenServer.Text = "Open";
			this.radOpenServer.UseVisualStyleBackColor = false;
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.smoothGroup1.Controls.Add(this.MoveDownButton);
			this.smoothGroup1.Controls.Add(this.MoveUpButton);
			this.smoothGroup1.Controls.Add(this.HowToOpenHelpLabel);
			this.smoothGroup1.Controls.Add(this.label8);
			this.smoothGroup1.Controls.Add(this.label7);
			this.smoothGroup1.Controls.Add(this.label1);
			this.smoothGroup1.Controls.Add(this.label4);
			this.smoothGroup1.Controls.Add(this.label6);
			this.smoothGroup1.Controls.Add(this.radTestServer);
			this.smoothGroup1.Controls.Add(this.radOpenServer);
			this.smoothGroup1.Controls.Add(this.AccountsList);
			this.smoothGroup1.Controls.Add(this.txtAccountName);
			this.smoothGroup1.Controls.Add(this.OKButton);
			this.smoothGroup1.Controls.Add(this.txtUsername);
			this.smoothGroup1.Controls.Add(this.txtPassword);
			this.smoothGroup1.Controls.Add(this.btnSaveAccount);
			this.smoothGroup1.Controls.Add(this.CancelEditButton);
			this.smoothGroup1.Controls.Add(this.btnChangeAccount);
			this.smoothGroup1.Controls.Add(this.btnDeleteAccount);
			this.smoothGroup1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(4, 4);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(565, 191);
			this.smoothGroup1.TabIndex = 12;
			this.MoveDownButton.Enabled = false;
			this.MoveDownButton.Location = new global::System.Drawing.Point(502, 160);
			this.MoveDownButton.Name = "MoveDownButton";
			this.MoveDownButton.Size = new global::System.Drawing.Size(26, 26);
			this.MoveDownButton.TabIndex = 11;
			this.toolTip_0.SetToolTip(this.MoveDownButton, "Move the selected account down");
			this.MoveDownButton.UseVisualStyleBackColor = true;
			this.MoveDownButton.Click += new global::System.EventHandler(this.MoveDownButton_Click);
			this.MoveUpButton.Enabled = false;
			this.MoveUpButton.Location = new global::System.Drawing.Point(534, 160);
			this.MoveUpButton.Name = "MoveUpButton";
			this.MoveUpButton.Size = new global::System.Drawing.Size(26, 26);
			this.MoveUpButton.TabIndex = 12;
			this.toolTip_0.SetToolTip(this.MoveUpButton, "Move the selected account up");
			this.MoveUpButton.UseVisualStyleBackColor = true;
			this.MoveUpButton.Click += new global::System.EventHandler(this.MoveUpButton_Click);
			this.HowToOpenHelpLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(3, 176);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 25;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.DimGray;
			this.label8.Location = new global::System.Drawing.Point(47, 40);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(104, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Account Name:";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.DimGray;
			this.label7.Location = new global::System.Drawing.Point(7, 71);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(144, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "ToonTown Username:";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.DimGray;
			this.label1.Location = new global::System.Drawing.Point(98, 132);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Server:";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.DimGray;
			this.label4.Location = new global::System.Drawing.Point(80, 102);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(71, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Password:";
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 95);
			this.label6.Location = new global::System.Drawing.Point(4, 4);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(206, 19);
			this.label6.TabIndex = 13;
			this.label6.Text = "ToonTown Account Manager";
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.ClientSize = new global::System.Drawing.Size(573, 199);
			base.Controls.Add(this.smoothGroup1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "AccountManager";
			base.Padding = new global::System.Windows.Forms.Padding(4);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "The ToonTown Spoofer : ToonTown Account Manager";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.AccountManager_HelpRequested);
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040002AF RID: 687
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040002B0 RID: 688
		private global::ns31.Class293 AccountsList;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Forms.TextBox txtAccountName;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.Button btnSaveAccount;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.Button CancelEditButton;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.Button btnDeleteAccount;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.Button btnChangeAccount;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.RadioButton radTestServer;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.RadioButton radOpenServer;

		// Token: 0x040002BB RID: 699
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.Button MoveDownButton;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.Button MoveUpButton;
	}
}
