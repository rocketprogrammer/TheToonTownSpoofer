namespace ns25
{
	// Token: 0x02000349 RID: 841
	internal sealed partial class RTFEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x0000D476 File Offset: 0x0000B676
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0006E6E0 File Offset: 0x0006C8E0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns25.RTFEditor));
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAccept = new global::System.Windows.Forms.Button();
			this.rtfValue = new global::ns26.RichTextBoxExtended();
			base.SuspendLayout();
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(440, 241);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAccept.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAccept.Location = new global::System.Drawing.Point(359, 241);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new global::System.Drawing.Size(75, 23);
			this.btnAccept.TabIndex = 1;
			this.btnAccept.Text = "&Accept";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new global::System.EventHandler(this.btnAccept_Click);
			this.rtfValue.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.rtfValue.Location = new global::System.Drawing.Point(11, 11);
			this.rtfValue.Name = "rtfValue";
			this.rtfValue.Rtf = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\deflang1049{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
			this.rtfValue.Size = new global::System.Drawing.Size(504, 224);
			this.rtfValue.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(527, 271);
			base.Controls.Add(this.btnAccept);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.rtfValue);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "RTFEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Value";
			base.ResumeLayout(false);
		}

		// Token: 0x04000D6D RID: 3437
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000D6E RID: 3438
		private global::ns26.RichTextBoxExtended rtfValue;

		// Token: 0x04000D6F RID: 3439
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000D70 RID: 3440
		private global::System.Windows.Forms.Button btnAccept;
	}
}
