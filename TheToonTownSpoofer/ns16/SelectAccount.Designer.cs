namespace ns16
{
	// Token: 0x020003AE RID: 942
	internal sealed partial class SelectAccount : global::System.Windows.Forms.Form
	{
		// Token: 0x06002499 RID: 9369 RVA: 0x0000FE68 File Offset: 0x0000E068
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0007C338 File Offset: 0x0007A538
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns16.SelectAccount));
			this.smoothGroup1 = new global::ns24.Class310();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSelect = new global::System.Windows.Forms.Button();
			this.btnManager = new global::System.Windows.Forms.Button();
			this.lbAccounts = new global::ns31.Class293();
			this.label6 = new global::System.Windows.Forms.Label();
			this.smoothGroup1.SuspendLayout();
			base.SuspendLayout();
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.smoothGroup1.Controls.Add(this.btnCancel);
			this.smoothGroup1.Controls.Add(this.btnSelect);
			this.smoothGroup1.Controls.Add(this.btnManager);
			this.smoothGroup1.Controls.Add(this.lbAccounts);
			this.smoothGroup1.Controls.Add(this.label6);
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(4, 4);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(331, 229);
			this.smoothGroup1.TabIndex = 0;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(248, 197);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Close";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnSelect.Enabled = false;
			this.btnSelect.Location = new global::System.Drawing.Point(167, 197);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new global::System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new global::System.EventHandler(this.btnSelect_Click);
			this.btnManager.Location = new global::System.Drawing.Point(12, 197);
			this.btnManager.Name = "btnManager";
			this.btnManager.Size = new global::System.Drawing.Size(75, 23);
			this.btnManager.TabIndex = 3;
			this.btnManager.Text = "Manager";
			this.btnManager.UseVisualStyleBackColor = true;
			this.btnManager.Click += new global::System.EventHandler(this.btnManager_Click);
			this.lbAccounts.Font = new global::System.Drawing.Font("Georgia", 9.75f);
			this.lbAccounts.FormattingEnabled = true;
			this.lbAccounts.ItemHeight = 16;
			this.lbAccounts.Location = new global::System.Drawing.Point(12, 43);
			this.lbAccounts.Name = "lbAccounts";
			this.lbAccounts.Size = new global::System.Drawing.Size(311, 148);
			this.lbAccounts.TabIndex = 0;
			this.lbAccounts.SelectedIndexChanged += new global::System.EventHandler(this.lbAccounts_SelectedIndexChanged);
			this.lbAccounts.DoubleClick += new global::System.EventHandler(this.lbAccounts_DoubleClick);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 95);
			this.label6.Location = new global::System.Drawing.Point(8, 8);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(186, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "Select ToonTown Account";
			base.AcceptButton = this.btnSelect;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(339, 237);
			base.Controls.Add(this.smoothGroup1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "SelectAccount";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "The ToonTown Spoofer : Select ToonTown Account";
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040010F8 RID: 4344
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040010F9 RID: 4345
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x040010FA RID: 4346
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040010FB RID: 4347
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040010FC RID: 4348
		private global::System.Windows.Forms.Button btnSelect;

		// Token: 0x040010FD RID: 4349
		private global::System.Windows.Forms.Button btnManager;

		// Token: 0x040010FE RID: 4350
		private global::ns31.Class293 lbAccounts;
	}
}
