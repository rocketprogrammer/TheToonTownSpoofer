using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns15;

namespace ns18
{
	// Token: 0x020002C9 RID: 713
	internal sealed partial class IntegerInputForm : IntegerInputFormBase
	{
		// Token: 0x06001C7C RID: 7292 RVA: 0x0000AB9C File Offset: 0x00008D9C
		public IntegerInputForm()
		{
			this.InitializeComponent_2();
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0005BD1C File Offset: 0x00059F1C
		private void InitializeComponent_2()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(523, 68);
			base.Name = "IntegerInputForm";
			this.Text = "The ToonTown Spoofer : Input";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
