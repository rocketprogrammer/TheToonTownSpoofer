namespace ns23
{
	// Token: 0x020003AC RID: 940
	internal sealed partial class ContentPackAgreement : global::System.Windows.Forms.Form
	{
		// Token: 0x06002487 RID: 9351 RVA: 0x0000FDDA File Offset: 0x0000DFDA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0007BD5C File Offset: 0x00079F5C
		private void InitializeComponent()
		{
			this.AcceptBtn = new global::System.Windows.Forms.Button();
			this.ViewContentPackAgreement = new global::System.Windows.Forms.LinkLabel();
			this.AgreementLabel = new global::System.Windows.Forms.Label();
			this.ContentPackAgreementTitle = new global::System.Windows.Forms.Label();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.AcceptBtn.Location = new global::System.Drawing.Point(266, 115);
			this.AcceptBtn.Name = "AcceptBtn";
			this.AcceptBtn.Size = new global::System.Drawing.Size(75, 23);
			this.AcceptBtn.TabIndex = 8;
			this.AcceptBtn.Text = "&Accept";
			this.AcceptBtn.UseVisualStyleBackColor = true;
			this.AcceptBtn.Click += new global::System.EventHandler(this.AcceptBtn_Click);
			this.ViewContentPackAgreement.ActiveLinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.ViewContentPackAgreement.AutoSize = true;
			this.ViewContentPackAgreement.BackColor = global::System.Drawing.Color.Transparent;
			this.ViewContentPackAgreement.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.ViewContentPackAgreement.LinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.ViewContentPackAgreement.Location = new global::System.Drawing.Point(72, 82);
			this.ViewContentPackAgreement.Name = "ViewContentPackAgreement";
			this.ViewContentPackAgreement.Size = new global::System.Drawing.Size(205, 19);
			this.ViewContentPackAgreement.TabIndex = 18;
			this.ViewContentPackAgreement.TabStop = true;
			this.ViewContentPackAgreement.Text = "View Content Pack Agreement";
			this.ViewContentPackAgreement.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewContentPackAgreement_LinkClicked);
			this.AgreementLabel.Location = new global::System.Drawing.Point(33, 48);
			this.AgreementLabel.Name = "AgreementLabel";
			this.AgreementLabel.Size = new global::System.Drawing.Size(283, 29);
			this.AgreementLabel.TabIndex = 19;
			this.AgreementLabel.Text = "By using Content Packs in any way, you agree to and are bound by the Content Pack Agreement.";
			this.ContentPackAgreementTitle.AutoSize = true;
			this.ContentPackAgreementTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ContentPackAgreementTitle.Location = new global::System.Drawing.Point(12, 9);
			this.ContentPackAgreementTitle.Name = "ContentPackAgreementTitle";
			this.ContentPackAgreementTitle.Size = new global::System.Drawing.Size(224, 26);
			this.ContentPackAgreementTitle.TabIndex = 20;
			this.ContentPackAgreementTitle.Text = "Content Pack Agreement";
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(185, 115);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 8;
			this.CancelBtn.Text = "&Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(349, 144);
			base.Controls.Add(this.ContentPackAgreementTitle);
			base.Controls.Add(this.AgreementLabel);
			base.Controls.Add(this.ViewContentPackAgreement);
			base.Controls.Add(this.CancelBtn);
			base.Controls.Add(this.AcceptBtn);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "ContentPackAgreement";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Content Packs : Agreement";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040010EF RID: 4335
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040010F0 RID: 4336
		private global::System.Windows.Forms.Button AcceptBtn;

		// Token: 0x040010F1 RID: 4337
		private global::System.Windows.Forms.LinkLabel ViewContentPackAgreement;

		// Token: 0x040010F2 RID: 4338
		private global::System.Windows.Forms.Label AgreementLabel;

		// Token: 0x040010F3 RID: 4339
		private global::System.Windows.Forms.Label ContentPackAgreementTitle;

		// Token: 0x040010F4 RID: 4340
		private global::System.Windows.Forms.Button CancelBtn;
	}
}
