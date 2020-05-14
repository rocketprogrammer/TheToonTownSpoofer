namespace ns30
{
	// Token: 0x020001E3 RID: 483
	internal sealed partial class ToonTownParentForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06001611 RID: 5649 RVA: 0x000063A2 File Offset: 0x000045A2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00035104 File Offset: 0x00033304
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(518, 353);
			base.Name = "ToonTownParentForm";
			this.Text = "ToonTown : Close this window to remove the ParTee Putt golf guide line.";
			base.ResumeLayout(false);
		}

		// Token: 0x04000367 RID: 871
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.Timer timer_0;
	}
}
