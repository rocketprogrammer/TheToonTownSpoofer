using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns14;

namespace ns27
{
	// Token: 0x02000494 RID: 1172
	internal sealed class Control10 : Control
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		static Control10()
		{
			Control10.graphicsPath_0.AddPolygon(new Point[]
			{
				new Point(25, 1),
				new Point(30, 1),
				new Point(30, 10),
				new Point(53, 34),
				new Point(50, 38),
				new Point(28, 15),
				new Point(27, 15),
				new Point(5, 38),
				new Point(2, 34),
				new Point(25, 10)
			});
			Control10.graphicsPath_0.AddPolygon(new Point[]
			{
				new Point(9, 40),
				new Point(27, 20),
				new Point(28, 20),
				new Point(46, 40),
				new Point(46, 62),
				new Point(33, 62),
				new Point(33, 37),
				new Point(22, 37),
				new Point(22, 42),
				new Point(33, 42),
				new Point(33, 47),
				new Point(22, 47),
				new Point(22, 62),
				new Point(9, 62)
			});
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000A9E38 File Offset: 0x000A8038
		private static SolidBrush smethod_0(Enum13 estate)
		{
			switch (estate)
			{
			case Enum13.const_0:
				return new SolidBrush(Color.Red);
			case Enum13.const_1:
				return new SolidBrush(Color.Green);
			case Enum13.const_2:
				return new SolidBrush(Color.Purple);
			case Enum13.const_4:
				return new SolidBrush(Color.Pink);
			case Enum13.const_5:
				return new SolidBrush(Color.Yellow);
			}
			return new SolidBrush(Color.Blue);
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000144D9 File Offset: 0x000126D9
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x000144E1 File Offset: 0x000126E1
		public Enum13 EstateHome
		{
			get
			{
				return this.enum13_0;
			}
			set
			{
				if (this.enum13_0 != value)
				{
					this.enum13_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000144F9 File Offset: 0x000126F9
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x00014500 File Offset: 0x00012700
		public new Size Size
		{
			get
			{
				return Control10.size_0;
			}
			set
			{
				base.Size = Control10.size_0;
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0001450D File Offset: 0x0001270D
		public Control10()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00014528 File Offset: 0x00012728
		protected override void OnSizeChanged(EventArgs e)
		{
			if (base.Size != Control10.size_0)
			{
				base.Size = Control10.size_0;
			}
			base.OnSizeChanged(e);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000A9EAC File Offset: 0x000A80AC
		protected override void OnPaint(PaintEventArgs e)
		{
			using (SolidBrush solidBrush = new SolidBrush(this.BackColor))
			{
				e.Graphics.FillRectangle(solidBrush, base.ClientRectangle);
			}
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (SolidBrush solidBrush2 = Control10.smethod_0(this.enum13_0))
			{
				e.Graphics.FillPath(solidBrush2, Control10.graphicsPath_0);
			}
			base.OnPaint(e);
		}

		// Token: 0x04001706 RID: 5894
		private static readonly Size size_0 = new Size(56, 64);

		// Token: 0x04001707 RID: 5895
		private static readonly GraphicsPath graphicsPath_0 = new GraphicsPath();

		// Token: 0x04001708 RID: 5896
		private Enum13 enum13_0 = Enum13.const_3;
	}
}
