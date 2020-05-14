namespace ns20
{
	// Token: 0x02000426 RID: 1062
	internal sealed partial class frmChanges : global::System.Windows.Forms.Form
	{
		// Token: 0x06002861 RID: 10337 RVA: 0x00012538 File Offset: 0x00010738
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00098978 File Offset: 0x00096B78
		private void InitializeComponent()
		{
			this.btnOK = new global::System.Windows.Forms.Button();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.richChanges = new global::ns21.Class185();
			this.btnUpdateNow = new global::System.Windows.Forms.Button();
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
			this.richChanges.BackColor = global::System.Drawing.SystemColors.Window;
			this.richChanges.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richChanges.Location = new global::System.Drawing.Point(12, 27);
			this.richChanges.Name = "richChanges";
			this.richChanges.ReadOnly = true;
			this.richChanges.Size = new global::System.Drawing.Size(315, 184);
			this.richChanges.TabIndex = 1;
			this.richChanges.Text = "";
			this.richChanges.DetectUrls = false;
			this.btnUpdateNow.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnUpdateNow.AutoSize = true;
			this.btnUpdateNow.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnUpdateNow.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btnUpdateNow.Location = new global::System.Drawing.Point(161, 228);
			this.btnUpdateNow.Name = "btnUpdateNow";
			this.btnUpdateNow.Size = new global::System.Drawing.Size(92, 22);
			this.btnUpdateNow.TabIndex = 4;
			this.btnUpdateNow.UseVisualStyleBackColor = true;
			this.btnUpdateNow.Click += new global::System.EventHandler(this.btnUpdateNow_Click);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnOK;
			base.ClientSize = new global::System.Drawing.Size(339, 262);
			base.Controls.Add(this.btnUpdateNow);
			base.Controls.Add(this.lblTitle);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.richChanges);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmChanges";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001468 RID: 5224
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001469 RID: 5225
		private global::ns21.Class185 richChanges;

		// Token: 0x0400146A RID: 5226
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x0400146B RID: 5227
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400146C RID: 5228
		private global::System.Windows.Forms.Button btnUpdateNow;
	}
}
