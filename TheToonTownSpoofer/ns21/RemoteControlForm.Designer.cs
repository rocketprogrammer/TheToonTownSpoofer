namespace ns21
{
	// Token: 0x02000248 RID: 584
	internal partial class RemoteControlForm : global::ns14.Form0
	{
		// Token: 0x060018FF RID: 6399 RVA: 0x00008378 File Offset: 0x00006578
		protected override void Dispose(bool disposing)
		{
			this.class141_0.Dispose();
			this.class141_1.Dispose();
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00044D04 File Offset: 0x00042F04
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Interval = 10;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Name = "RemoteControlForm";
			base.ResumeLayout(false);
		}

		// Token: 0x040006CF RID: 1743
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040006D0 RID: 1744
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006D6 RID: 1750
		private global::ns16.Class141 class141_0;

		// Token: 0x040006D7 RID: 1751
		private global::ns16.Class141 class141_1;
	}
}
