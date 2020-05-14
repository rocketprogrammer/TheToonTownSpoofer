namespace ns23
{
	// Token: 0x0200038E RID: 910
	internal sealed partial class CountDown : global::ns14.Form0
	{
		// Token: 0x06002388 RID: 9096 RVA: 0x0000F322 File Offset: 0x0000D522
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00077F90 File Offset: 0x00076190
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(233f, 447f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(600, 600);
			this.Font = new global::System.Drawing.Font("Arial", 300f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(116, 103, 116, 103);
			base.Name = "CountDown";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Count Down";
			base.TopMost = true;
			base.Shown += new global::System.EventHandler(this.CountDown_Shown);
			base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.CountDown_KeyPress);
			base.ResumeLayout(false);
		}

		// Token: 0x04001057 RID: 4183
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001058 RID: 4184
		private global::System.Windows.Forms.Timer timer_0;
	}
}
