namespace ns31
{
	// Token: 0x020002D5 RID: 725
	internal sealed partial class AboutForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x0000AF5D File Offset: 0x0000915D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0005D9FC File Offset: 0x0005BBFC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns31.AboutForm));
			this.AboutBanner = new global::System.Windows.Forms.PictureBox();
			this.TitleVersionLabel = new global::System.Windows.Forms.Label();
			this.CopyrightLabel = new global::System.Windows.Forms.Label();
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.LicenseAgreementLink = new global::System.Windows.Forms.LinkLabel();
			this.OKButton = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.AboutBanner).BeginInit();
			this.MainPanel.SuspendLayout();
			base.SuspendLayout();
			this.AboutBanner.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("AboutBanner.Image");
			this.AboutBanner.Location = new global::System.Drawing.Point(12, 12);
			this.AboutBanner.Name = "AboutBanner";
			this.AboutBanner.Size = new global::System.Drawing.Size(438, 172);
			this.AboutBanner.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.AboutBanner.TabIndex = 0;
			this.AboutBanner.TabStop = false;
			this.TitleVersionLabel.Font = new global::System.Drawing.Font("Times New Roman", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TitleVersionLabel.Location = new global::System.Drawing.Point(12, 189);
			this.TitleVersionLabel.Name = "TitleVersionLabel";
			this.TitleVersionLabel.Size = new global::System.Drawing.Size(438, 15);
			this.TitleVersionLabel.TabIndex = 1;
			this.TitleVersionLabel.Text = "The ToonTown Spoofer {0} for Microsoft Windows®";
			this.TitleVersionLabel.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.CopyrightLabel.Font = new global::System.Drawing.Font("Times New Roman", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CopyrightLabel.Location = new global::System.Drawing.Point(12, 211);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new global::System.Drawing.Size(438, 15);
			this.CopyrightLabel.TabIndex = 1;
			this.CopyrightLabel.Text = "Copyright ©{0} The Spoof Net";
			this.CopyrightLabel.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.MainPanel.BackColor = global::System.Drawing.Color.White;
			this.MainPanel.Controls.Add(this.LicenseAgreementLink);
			this.MainPanel.Controls.Add(this.AboutBanner);
			this.MainPanel.Controls.Add(this.TitleVersionLabel);
			this.MainPanel.Controls.Add(this.CopyrightLabel);
			this.MainPanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.MainPanel.Location = new global::System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new global::System.Drawing.Size(462, 256);
			this.MainPanel.TabIndex = 3;
			this.LicenseAgreementLink.AutoSize = true;
			this.LicenseAgreementLink.LinkColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.LicenseAgreementLink.Location = new global::System.Drawing.Point(157, 233);
			this.LicenseAgreementLink.Name = "LicenseAgreementLink";
			this.LicenseAgreementLink.Size = new global::System.Drawing.Size(149, 13);
			this.LicenseAgreementLink.TabIndex = 3;
			this.LicenseAgreementLink.TabStop = true;
			this.LicenseAgreementLink.Text = "View User License Agreement";
			this.LicenseAgreementLink.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LicenseAgreementLink_LinkClicked);
			this.OKButton.Location = new global::System.Drawing.Point(375, 262);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 4;
			this.OKButton.Text = "&OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(462, 291);
			base.Controls.Add(this.OKButton);
			base.Controls.Add(this.MainPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About The ToonTown Spoofer";
			((global::System.ComponentModel.ISupportInitialize)this.AboutBanner).EndInit();
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A84 RID: 2692
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000A85 RID: 2693
		private global::System.Windows.Forms.PictureBox AboutBanner;

		// Token: 0x04000A86 RID: 2694
		private global::System.Windows.Forms.Label TitleVersionLabel;

		// Token: 0x04000A87 RID: 2695
		private global::System.Windows.Forms.Label CopyrightLabel;

		// Token: 0x04000A88 RID: 2696
		private global::System.Windows.Forms.Panel MainPanel;

		// Token: 0x04000A89 RID: 2697
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x04000A8A RID: 2698
		private global::System.Windows.Forms.LinkLabel LicenseAgreementLink;
	}
}
