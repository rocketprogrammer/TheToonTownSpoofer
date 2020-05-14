using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns18;
using ns20;
using ns26;

namespace ns24
{
	// Token: 0x02000325 RID: 805
	internal sealed class Class310 : Panel
	{
		// Token: 0x06001F35 RID: 7989 RVA: 0x0000C3E7 File Offset: 0x0000A5E7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0000C406 File Offset: 0x0000A606
		private void method_0()
		{
			base.SuspendLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0000C415 File Offset: 0x0000A615
		public Class310()
		{
			this.method_0();
			this.color_0 = Color.White;
			this.int_0 = 30;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0000C442 File Offset: 0x0000A642
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00066D0C File Offset: 0x00064F0C
		public Point ImageLocation
		{
			get
			{
				return this.rectangle_0.Location;
			}
			set
			{
				if (this.rectangle_0.Location != value)
				{
					this.ImageBounds = new Rectangle(value, this.ImageBounds.Size);
				}
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0000C44F File Offset: 0x0000A64F
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00066D48 File Offset: 0x00064F48
		public Rectangle ImageBounds
		{
			get
			{
				return this.rectangle_0;
			}
			set
			{
				if (this.rectangle_0 != value)
				{
					if (this.rectangle_0.smethod_2())
					{
						base.Invalidate(this.rectangle_0);
					}
					this.rectangle_0 = value;
					if (this.rectangle_0.smethod_2())
					{
						base.Invalidate(this.rectangle_0);
					}
				}
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0000C457 File Offset: 0x0000A657
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000C45F File Offset: 0x0000A65F
		[DefaultValue(typeof(Image), null)]
		public Image Image
		{
			get
			{
				return this.image_0;
			}
			set
			{
				if (this.image_0 != value)
				{
					this.image_0 = value;
					if (this.rectangle_0.Size != Size.Empty)
					{
						base.Invalidate(this.rectangle_0);
					}
				}
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0000C494 File Offset: 0x0000A694
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x0000C49C File Offset: 0x0000A69C
		[Category("Appearance")]
		public int HeaderHeight
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		[Category("Appearance")]
		public Color CenterColor
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

		// Token: 0x06001F42 RID: 8002 RVA: 0x00066D9C File Offset: 0x00064F9C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			int num = base.Height - base.Margin.Vertical;
			int width = base.Width - base.Margin.Horizontal;
			using (GraphicsPath graphicsPath = Class476.smethod_0(new Rectangle(base.Margin.Left, base.Margin.Top, width, this.int_0), 5, Enum48.flag_1 | Enum48.flag_2))
			{
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(base.Margin.Left, base.Margin.Top), new Point(base.Margin.Left, this.int_0 + base.Margin.Top), Color.White, Color.LightGray))
				{
					Point point = new Point(base.Margin.Left, base.Height - base.Margin.Bottom);
					Point point2 = new Point(base.Width - base.Margin.Right, base.Height - base.Margin.Bottom);
					Point pt = new Point(base.Margin.Left, this.int_0 + base.Margin.Top);
					Point pt2 = new Point(point2.X, pt.Y);
					Rectangle rect = new Rectangle(base.Margin.Left, base.Margin.Top + this.int_0, width, num - this.int_0);
					using (SolidBrush solidBrush = new SolidBrush(this.color_0))
					{
						e.Graphics.FillRectangle(solidBrush, rect);
					}
					e.Graphics.DrawLine(Pens.LightGray, pt, point);
					e.Graphics.DrawLine(Pens.LightGray, point, point2);
					e.Graphics.DrawLine(Pens.LightGray, point2, pt2);
					e.Graphics.FillPath(linearGradientBrush, graphicsPath);
					e.Graphics.DrawPath(Pens.LightGray, graphicsPath);
					if (this.rectangle_0.smethod_2() && this.image_0 != null)
					{
						graphicsPath.AddRectangle(rect);
						e.Graphics.SetClip(graphicsPath);
						e.Graphics.DrawImage(this.image_0, this.rectangle_0);
						e.Graphics.ResetClip();
					}
				}
			}
		}

		// Token: 0x04000C07 RID: 3079
		private IContainer icontainer_0;

		// Token: 0x04000C08 RID: 3080
		private int int_0;

		// Token: 0x04000C09 RID: 3081
		private Color color_0;

		// Token: 0x04000C0A RID: 3082
		private Image image_0;

		// Token: 0x04000C0B RID: 3083
		private Rectangle rectangle_0;
	}
}
