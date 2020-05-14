using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns18;

namespace ns24
{
	// Token: 0x02000310 RID: 784
	internal sealed partial class StringInputForm : StringInputFormBase
	{
		// Token: 0x06001EA2 RID: 7842 RVA: 0x0000BDFA File Offset: 0x00009FFA
		public StringInputForm()
		{
			this.InitializeComponent_2();
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00064BD0 File Offset: 0x00062DD0
		private void InitializeComponent_2()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(523, 68);
			base.Name = "StringInputForm";
			this.Text = "The ToonTown Spoofer : Input";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
