using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns18
{
	// Token: 0x020002C4 RID: 708
	internal sealed class Control3 : Control
	{
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0000A9B1 File Offset: 0x00008BB1
		public Color SelectedColor
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0000A9CE File Offset: 0x00008BCE
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0000A9D6 File Offset: 0x00008BD6
		public bool DrawBorder
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0000A9EE File Offset: 0x00008BEE
		public Control3()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00005104 File Offset: 0x00003304
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0005B9D0 File Offset: 0x00059BD0
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Rectangle rect;
			if (this.color_0.A < 255)
			{
				bool flag = false;
				for (int i = 0; i < base.Height; i += 8)
				{
					for (int j = 0; j < base.Width; j += 8)
					{
						rect = new Rectangle(j, i, 8, 8);
						if (flag)
						{
							e.Graphics.FillRectangle(Brushes.LightGray, rect);
						}
						else
						{
							e.Graphics.FillRectangle(Brushes.White, rect);
						}
						flag = !flag;
					}
				}
			}
			rect = new Rectangle(Point.Empty, new Size(base.Size.Width - 1, base.Size.Height - 1));
			if (this.color_0.A > 0)
			{
				using (SolidBrush solidBrush = new SolidBrush(this.color_0))
				{
					e.Graphics.FillRectangle(solidBrush, rect);
				}
			}
			using (Pen pen = new Pen(this.ForeColor))
			{
				e.Graphics.DrawRectangle(pen, rect);
			}
		}

		// Token: 0x04000A0A RID: 2570
		private Color color_0;

		// Token: 0x04000A0B RID: 2571
		private bool bool_0 = true;
	}
}
