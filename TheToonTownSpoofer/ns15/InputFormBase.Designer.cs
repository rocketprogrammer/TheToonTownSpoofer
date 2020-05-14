namespace ns15
{
	// Token: 0x02000204 RID: 516
	internal partial class InputFormBase : global::System.Windows.Forms.Form
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x00006AEC File Offset: 0x00004CEC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000373CC File Offset: 0x000355CC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns15.InputFormBase));
			this.lblMessage = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOK = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.lblMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblMessage.Location = new global::System.Drawing.Point(12, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new global::System.Drawing.Size(502, 23);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(439, 35);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.Location = new global::System.Drawing.Point(358, 35);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(523, 68);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.lblMessage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(6, 96);
			base.Name = "InputFormBase";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.ResumeLayout(false);
		}

		// Token: 0x040004ED RID: 1261
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040004EE RID: 1262
		private global::System.Windows.Forms.Label lblMessage;

		// Token: 0x040004EF RID: 1263
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040004F0 RID: 1264
		private global::System.Windows.Forms.Button btnOK;
	}
}
