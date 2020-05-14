using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns31;

namespace ns30
{
	// Token: 0x020001E2 RID: 482
	internal sealed partial class WindowSelect_1 : WindowSelect
	{
		// Token: 0x0600160D RID: 5645 RVA: 0x00006365 File Offset: 0x00004565
		public WindowSelect_1()
		{
			this.InitializeComponent_1();
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00006373 File Offset: 0x00004573
		private void WindowSelect_1_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_15);
			e.Handled = true;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0003508C File Offset: 0x0003328C
		private void InitializeComponent_1()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(341, 98);
			base.Name = "WindowSelect";
			this.Text = "The ToonTown Spoofer : Select Window";
			base.HelpRequested += this.WindowSelect_1_HelpRequested;
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
