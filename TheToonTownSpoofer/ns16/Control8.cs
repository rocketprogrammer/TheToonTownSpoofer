using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns26;
using ns29;

namespace ns16
{
	// Token: 0x020003E0 RID: 992
	[Description("Arrow Button Control")]
	[Designer(typeof(Control9))]
	internal sealed class Control8 : Control
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x00086118 File Offset: 0x00084318
		protected override void Dispose(bool disposing)
		{
			if (this.graphicsPath_0 != null)
			{
				this.graphicsPath_0.Dispose();
			}
			this.graphicsPath_0 = null;
			this.bitArray_0 = null;
			this.point_0 = null;
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0008616C File Offset: 0x0008436C
		private void method_0()
		{
			this.icontainer_0 = new Container();
			base.MouseUp += this.Control8_MouseUp;
			base.MouseEnter += this.Control8_MouseEnter;
			base.MouseLeave += this.Control8_MouseLeave;
			base.MouseDown += this.Control8_MouseDown;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00010C12 File Offset: 0x0000EE12
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x00010C1A File Offset: 0x0000EE1A
		[Category("ArrowButton")]
		[Description("The start color")]
		public Color NormalStartColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				if (this.color_0 != value)
				{
					this.color_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x00010C37 File Offset: 0x0000EE37
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x00010C3F File Offset: 0x0000EE3F
		[Category("ArrowButton")]
		[Description("The end color")]
		public Color NormalEndColor
		{
			get
			{
				return this.color_1;
			}
			set
			{
				if (this.color_1 != value)
				{
					this.color_1 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00010C5C File Offset: 0x0000EE5C
		// (set) Token: 0x060025F8 RID: 9720 RVA: 0x00010C64 File Offset: 0x0000EE64
		[Category("ArrowButton")]
		[Description("The hover start color")]
		public Color HoverStartColor
		{
			get
			{
				return this.color_2;
			}
			set
			{
				if (this.color_2 != value)
				{
					this.color_2 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x00010C81 File Offset: 0x0000EE81
		// (set) Token: 0x060025FA RID: 9722 RVA: 0x00010C89 File Offset: 0x0000EE89
		[Description("The hover end color")]
		[Category("ArrowButton")]
		public Color HoverEndColor
		{
			get
			{
				return this.color_3;
			}
			set
			{
				if (this.color_3 != value)
				{
					this.color_3 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x00010CA6 File Offset: 0x0000EEA6
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x00010CAE File Offset: 0x0000EEAE
		[Description("Pointing direction")]
		[Category("ArrowButton")]
		public int Rotation
		{
			get
			{
				return this.int_1;
			}
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.method_2();
					this.method_1();
					base.Invalidate();
				}
			}
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000861CC File Offset: 0x000843CC
		public Control8()
		{
			this.method_0();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00010CD2 File Offset: 0x0000EED2
		private void Control8_MouseUp(object sender, MouseEventArgs e)
		{
			this.bitArray_0[0] = false;
			base.Invalidate();
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00010CE7 File Offset: 0x0000EEE7
		private void Control8_MouseLeave(object sender, EventArgs e)
		{
			this.bitArray_0[1] = false;
			base.Invalidate();
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00010CFC File Offset: 0x0000EEFC
		private void Control8_MouseEnter(object sender, EventArgs e)
		{
			this.bitArray_0[1] = true;
			base.Invalidate();
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00010D11 File Offset: 0x0000EF11
		private void Control8_MouseDown(object sender, MouseEventArgs e)
		{
			this.bitArray_0[0] = true;
			base.Invalidate();
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00010D26 File Offset: 0x0000EF26
		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);
			this.bitArray_0[0] = false;
			this.bitArray_0[1] = false;
			base.Invalidate();
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00010D4F File Offset: 0x0000EF4F
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.method_2();
			this.method_1();
			base.Invalidate();
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00086234 File Offset: 0x00084434
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (!base.DesignMode)
			{
				e.Graphics.SetClip(this.graphicsPath_0);
			}
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (LinearGradientBrush linearGradientBrush = this.bitArray_0[1] ? new LinearGradientBrush(base.ClientRectangle, this.color_2, this.color_3, 0f, true) : new LinearGradientBrush(base.ClientRectangle, this.color_0, this.color_1, 0f, true))
			{
				e.Graphics.FillPath(linearGradientBrush, this.graphicsPath_0);
			}
			this.method_3(e, this.bitArray_0);
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000862F4 File Offset: 0x000844F4
		private void method_1()
		{
			this.smethod_3(Control8.int_0);
			int dx = base.Width - 3;
			Class528.smethod_3(dx, out this.point_0);
			this.point_1 = new Point(base.Width / 2, base.Width / 2);
			Class528.smethod_1(this.int_1, this.point_0);
			Class528.smethod_2(dx, this.int_1, ref this.point_1, this.point_0);
			Class528.smethod_0(this.point_0, this.graphicsPath_0, this.point_1);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00010D6A File Offset: 0x0000EF6A
		private void method_2()
		{
			this.point_0 = null;
			this.graphicsPath_0.Reset();
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0008637C File Offset: 0x0008457C
		private void method_3(PaintEventArgs e, BitArray butstate)
		{
			if (base.Enabled)
			{
				if (!butstate[0])
				{
					for (int i = 0; i < 7; i++)
					{
						using (Pen pen = (this.point_0[i].Y <= this.point_0[i + 1].Y) ? new Pen(SystemColors.ControlLightLight, 2f) : new Pen(SystemColors.ControlDark, 2f))
						{
							e.Graphics.DrawLine(pen, this.point_1.X + this.point_0[i].X, this.point_1.Y + this.point_0[i].Y, this.point_1.X + this.point_0[i + 1].X, this.point_1.Y + this.point_0[i + 1].Y);
						}
					}
					return;
				}
				for (int j = 0; j < 7; j++)
				{
					using (Pen pen2 = (this.point_0[j].Y <= this.point_0[j + 1].Y) ? new Pen(SystemColors.ControlDark, 2f) : new Pen(SystemColors.ControlLightLight, 2f))
					{
						e.Graphics.DrawLine(pen2, this.point_1.X + this.point_0[j].X, this.point_1.Y + this.point_0[j].Y, this.point_1.X + this.point_0[j + 1].X, this.point_1.Y + this.point_0[j + 1].Y);
					}
				}
			}
		}

		// Token: 0x0400128C RID: 4748
		private IContainer icontainer_0;

		// Token: 0x0400128D RID: 4749
		private static readonly int int_0 = 24;

		// Token: 0x0400128E RID: 4750
		private Point[] point_0;

		// Token: 0x0400128F RID: 4751
		private Point point_1;

		// Token: 0x04001290 RID: 4752
		private Color color_0 = Color.WhiteSmoke;

		// Token: 0x04001291 RID: 4753
		private Color color_1 = Color.DarkGray;

		// Token: 0x04001292 RID: 4754
		private Color color_2 = Color.WhiteSmoke;

		// Token: 0x04001293 RID: 4755
		private Color color_3 = Color.DarkRed;

		// Token: 0x04001294 RID: 4756
		private int int_1;

		// Token: 0x04001295 RID: 4757
		private GraphicsPath graphicsPath_0 = new GraphicsPath();

		// Token: 0x04001296 RID: 4758
		private BitArray bitArray_0 = new BitArray(2);

		// Token: 0x020003E1 RID: 993
		private enum Enum91
		{
			// Token: 0x04001298 RID: 4760
			const_0,
			// Token: 0x04001299 RID: 4761
			const_1
		}
	}
}
