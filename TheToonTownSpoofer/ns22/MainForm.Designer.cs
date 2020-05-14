namespace ns22
{
	// Token: 0x02000372 RID: 882
	internal sealed partial class MainForm : global::ns14.Form0
	{
		// Token: 0x06002278 RID: 8824 RVA: 0x00074FF8 File Offset: 0x000731F8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.font_0 != null)
				{
					this.font_0.Dispose();
				}
				if (this.class134_0 != null)
				{
					foreach (global::ns22.MainForm.Class134 @class in this.class134_0)
					{
						@class.Dispose();
					}
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0007505C File Offset: 0x0007325C
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(295, 342);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(295, 342);
			this.MinimumSize = new global::System.Drawing.Size(295, 342);
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer";
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			base.PreviewKeyDown += new global::System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
			base.ResumeLayout(false);
		}

		// Token: 0x04000FD7 RID: 4055
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000FEC RID: 4076
		private readonly global::ns22.MainForm.Class134[] class134_0;

		// Token: 0x04000FED RID: 4077
		private readonly global::System.Drawing.Font font_0;
	}
}
