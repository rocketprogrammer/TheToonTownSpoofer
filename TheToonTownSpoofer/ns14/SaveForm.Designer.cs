namespace ns14
{
	// Token: 0x020001C9 RID: 457
	internal partial class SaveForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600149E RID: 5278 RVA: 0x00005156 File Offset: 0x00003356
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00025B2C File Offset: 0x00023D2C
		private void InitializeComponent()
		{
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			base.SuspendLayout();
			this.openFileDialog_0.FileName = "";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Name = "SaveForm";
			this.Text = "SaveForm";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.SaveForm_FormClosing);
			base.ResumeLayout(false);
		}

		// Token: 0x04000220 RID: 544
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000221 RID: 545
		protected global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;

		// Token: 0x04000222 RID: 546
		protected global::System.Windows.Forms.OpenFileDialog openFileDialog_0;
	}
}
