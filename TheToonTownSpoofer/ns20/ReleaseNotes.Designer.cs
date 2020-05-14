namespace ns20
{
	// Token: 0x02000451 RID: 1105
	internal sealed partial class ReleaseNotes : global::System.Windows.Forms.Form
	{
		// Token: 0x0600297E RID: 10622 RVA: 0x000131E4 File Offset: 0x000113E4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0009F044 File Offset: 0x0009D244
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns20.ReleaseNotes));
			this.ReleaseNotesRTF = new global::ns21.Class185();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.smoothGroup1 = new global::ns24.Class310();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.smoothGroup1.SuspendLayout();
			base.SuspendLayout();
			this.ReleaseNotesRTF.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ReleaseNotesRTF.Location = new global::System.Drawing.Point(8, 39);
			this.ReleaseNotesRTF.Name = "ReleaseNotesRTF";
			this.ReleaseNotesRTF.ReadOnly = true;
			this.ReleaseNotesRTF.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.ReleaseNotesRTF.Size = new global::System.Drawing.Size(484, 256);
			this.ReleaseNotesRTF.TabIndex = 1;
			this.ReleaseNotesRTF.Text = "";
			this.ReleaseNotesRTF.DetectUrls = false;
			this.OKButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Location = new global::System.Drawing.Point(429, 310);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "&OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			this.smoothGroup1.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.smoothGroup1.Controls.Add(this.TitleLabel);
			this.smoothGroup1.Controls.Add(this.ReleaseNotesRTF);
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(4, 4);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(500, 303);
			this.smoothGroup1.TabIndex = 2;
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.TitleLabel.ForeColor = global::System.Drawing.Color.Gray;
			this.TitleLabel.Location = new global::System.Drawing.Point(10, 8);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(274, 19);
			this.TitleLabel.TabIndex = 11;
			this.TitleLabel.Text = "The ToonTown Spoofer : Release Notes";
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.CancelButton = this.OKButton;
			base.ClientSize = new global::System.Drawing.Size(508, 335);
			base.Controls.Add(this.smoothGroup1);
			base.Controls.Add(this.OKButton);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "ReleaseNotes";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Release Notes";
			base.Load += new global::System.EventHandler(this.ReleaseNotes_Load);
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400158E RID: 5518
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400158F RID: 5519
		private global::ns21.Class185 ReleaseNotesRTF;

		// Token: 0x04001590 RID: 5520
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x04001591 RID: 5521
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x04001592 RID: 5522
		private global::System.Windows.Forms.Label TitleLabel;
	}
}
