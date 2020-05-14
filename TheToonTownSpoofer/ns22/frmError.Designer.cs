namespace ns22
{
	// Token: 0x02000360 RID: 864
	internal sealed partial class frmError : global::System.Windows.Forms.Form
	{
		// Token: 0x0600220F RID: 8719 RVA: 0x0000E3AB File Offset: 0x0000C5AB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00073D54 File Offset: 0x00071F54
		private void InitializeComponent()
		{
			this.btnOK = new global::System.Windows.Forms.Button();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.richError = new global::ns21.Class185();
			this.btnTryAgainLater = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.AutoSize = true;
			this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new global::System.Drawing.Point(259, 228);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(68, 22);
			this.btnOK.TabIndex = 2;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new global::System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(0, 13);
			this.lblTitle.TabIndex = 3;
			this.richError.BackColor = global::System.Drawing.SystemColors.Window;
			this.richError.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richError.Location = new global::System.Drawing.Point(12, 27);
			this.richError.Name = "richError";
			this.richError.ReadOnly = true;
			this.richError.Size = new global::System.Drawing.Size(315, 184);
			this.richError.TabIndex = 1;
			this.richError.Text = "";
			this.richError.DetectUrls = false;
			this.btnTryAgainLater.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTryAgainLater.AutoSize = true;
			this.btnTryAgainLater.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnTryAgainLater.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btnTryAgainLater.Location = new global::System.Drawing.Point(161, 228);
			this.btnTryAgainLater.Name = "btnTryAgainLater";
			this.btnTryAgainLater.Size = new global::System.Drawing.Size(92, 22);
			this.btnTryAgainLater.TabIndex = 5;
			this.btnTryAgainLater.UseVisualStyleBackColor = true;
			this.btnTryAgainLater.Click += new global::System.EventHandler(this.btnTryAgainLater_Click);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnOK;
			base.ClientSize = new global::System.Drawing.Size(339, 262);
			base.Controls.Add(this.btnTryAgainLater);
			base.Controls.Add(this.lblTitle);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.richError);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmError";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000E16 RID: 3606
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000E17 RID: 3607
		private global::ns21.Class185 richError;

		// Token: 0x04000E18 RID: 3608
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000E19 RID: 3609
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000E1A RID: 3610
		private global::System.Windows.Forms.Button btnTryAgainLater;
	}
}
