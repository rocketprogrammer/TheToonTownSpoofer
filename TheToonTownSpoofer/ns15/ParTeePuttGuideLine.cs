using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns14;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x0200022A RID: 554
	internal sealed partial class ParTeePuttGuideLine : Form0
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x000406F4 File Offset: 0x0003E8F4
		public ParTeePuttGuideLine()
		{
			this.InitializeComponent();
			Class265.SetLayeredWindowAttributes(new HandleRef(this, base.Handle), 0U, byte.MaxValue, Enum21.const_0);
			base.CustomPainting = true;
			this.UseOpacity = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(0, 0);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00040754 File Offset: 0x0003E954
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 134217888;
				return createParams;
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0004077C File Offset: 0x0003E97C
		protected override void vmethod_0(Graphics g)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, base.Height), Color.FromArgb(39, ParTeePuttGuideLine.color_0), Color.FromArgb(190, ParTeePuttGuideLine.color_0)))
			{
				using (Pen pen = new Pen(linearGradientBrush, (float)(base.Width / 2)))
				{
					pen.StartCap = LineCap.ArrowAnchor;
					pen.EndCap = LineCap.NoAnchor;
					g.DrawLine(pen, new Point(base.Width / 2, 0), new Point(base.Width / 2, base.Height));
				}
			}
		}

		// Token: 0x040005F8 RID: 1528
		private static Color color_0 = Color.Red;
	}
}
