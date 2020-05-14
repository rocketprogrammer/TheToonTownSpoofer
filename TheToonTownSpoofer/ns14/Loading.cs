using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns17;

namespace ns14
{
	// Token: 0x020001CE RID: 462
	internal sealed partial class Loading : Form0
	{
		// Token: 0x060014FD RID: 5373 RVA: 0x0000578C File Offset: 0x0000398C
		public Loading() : base(false)
		{
			this.InitializeComponent();
			base.FormClosing += this.Loading_FormClosing;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0002A40C File Offset: 0x0002860C
		private void Loading_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown && !this.bool_5)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000057AD File Offset: 0x000039AD
		protected override void vmethod_1(EventArgs19 e)
		{
			e.Cancel = true;
			e.CancelReason = Loading.string_0;
			base.vmethod_1(e);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000057C8 File Offset: 0x000039C8
		public void method_1()
		{
			this.bool_5 = true;
			base.Close();
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000057D7 File Offset: 0x000039D7
		public void method_2()
		{
			this.method_1();
		}

		// Token: 0x04000290 RID: 656
		private static readonly string string_0 = "One moment, loading...";

		// Token: 0x04000291 RID: 657
		private bool bool_5;
	}
}
