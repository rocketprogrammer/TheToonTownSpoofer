namespace ns20
{
	// Token: 0x02000450 RID: 1104
	internal sealed partial class PointFInput : global::System.Windows.Forms.Form
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x000131C5 File Offset: 0x000113C5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns20.PointFInput));
			this.YLabel = new global::System.Windows.Forms.Label();
			this.XLabel = new global::System.Windows.Forms.Label();
			this.OKBtn = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.XTxt = new global::ns23.Class182();
			this.YTxt = new global::ns23.Class182();
			base.SuspendLayout();
			this.YLabel.AutoSize = true;
			this.YLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.YLabel.Location = new global::System.Drawing.Point(137, 15);
			this.YLabel.Name = "YLabel";
			this.YLabel.Size = new global::System.Drawing.Size(17, 13);
			this.YLabel.TabIndex = 44;
			this.YLabel.Text = "Y:";
			this.XLabel.AutoSize = true;
			this.XLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.XLabel.Location = new global::System.Drawing.Point(8, 15);
			this.XLabel.Name = "XLabel";
			this.XLabel.Size = new global::System.Drawing.Size(17, 13);
			this.XLabel.TabIndex = 43;
			this.XLabel.Text = "X:";
			this.OKBtn.Location = new global::System.Drawing.Point(266, 10);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new global::System.Drawing.Size(75, 23);
			this.OKBtn.TabIndex = 2;
			this.OKBtn.Text = "&OK";
			this.OKBtn.UseVisualStyleBackColor = true;
			this.OKBtn.Click += new global::System.EventHandler(this.OKBtn_Click);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(347, 10);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.XTxt.Location = new global::System.Drawing.Point(31, 11);
			this.XTxt.MaximumValue = 3.402823E+38f;
			this.XTxt.MaxLength = 32;
			this.XTxt.MinimumValue = -3.402823E+38f;
			this.XTxt.Name = "XTxt";
			this.XTxt.Size = new global::System.Drawing.Size(100, 20);
			this.XTxt.TabIndex = 0;
			this.XTxt.Value = 0f;
			this.YTxt.Location = new global::System.Drawing.Point(160, 11);
			this.YTxt.MaximumValue = 3.402823E+38f;
			this.YTxt.MaxLength = 32;
			this.YTxt.MinimumValue = -3.402823E+38f;
			this.YTxt.Name = "YTxt";
			this.YTxt.Size = new global::System.Drawing.Size(100, 20);
			this.YTxt.TabIndex = 1;
			this.YTxt.Value = 0f;
			base.AcceptButton = this.OKBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(434, 41);
			base.Controls.Add(this.CancelBtn);
			base.Controls.Add(this.OKBtn);
			base.Controls.Add(this.YTxt);
			base.Controls.Add(this.XTxt);
			base.Controls.Add(this.YLabel);
			base.Controls.Add(this.XLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "PointFInput";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "The ToonTown Spoofer : Input Point";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PointFInput_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001587 RID: 5511
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001588 RID: 5512
		private global::System.Windows.Forms.Label YLabel;

		// Token: 0x04001589 RID: 5513
		private global::System.Windows.Forms.Label XLabel;

		// Token: 0x0400158A RID: 5514
		private global::ns23.Class182 XTxt;

		// Token: 0x0400158B RID: 5515
		private global::ns23.Class182 YTxt;

		// Token: 0x0400158C RID: 5516
		private global::System.Windows.Forms.Button OKBtn;

		// Token: 0x0400158D RID: 5517
		private global::System.Windows.Forms.Button CancelBtn;
	}
}
