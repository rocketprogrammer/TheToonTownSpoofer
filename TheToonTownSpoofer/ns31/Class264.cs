using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns31
{
	// Token: 0x020002D6 RID: 726
	internal sealed class Class264 : FlowLayoutPanel
	{
		// Token: 0x06001CD4 RID: 7380 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
		protected override Point ScrollToControl(Control activeControl)
		{
			if (this.bool_0)
			{
				return base.ScrollToControl(activeControl);
			}
			return this.DisplayRectangle.Location;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0000AF84 File Offset: 0x00009184
		public void method_0(Control activeControl)
		{
			this.bool_0 = true;
			base.ScrollControlIntoView(activeControl);
			this.bool_0 = false;
		}

		// Token: 0x04000A8B RID: 2699
		private bool bool_0;
	}
}
