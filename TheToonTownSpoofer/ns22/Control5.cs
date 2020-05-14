using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns20;
using ns23;
using ns27;
using ns28;

namespace ns22
{
	// Token: 0x02000354 RID: 852
	internal sealed class Control5 : Control
	{
		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0000DC46 File Offset: 0x0000BE46
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000DC4E File Offset: 0x0000BE4E
		public string LockedMessage { get; set; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0000DC57 File Offset: 0x0000BE57
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x0000DC5F File Offset: 0x0000BE5F
		public string MovableMessage { get; set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x0000DC68 File Offset: 0x0000BE68
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x0000DC70 File Offset: 0x0000BE70
		public string MovableResizeMessage { get; set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x0000DC79 File Offset: 0x0000BE79
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x0000DC81 File Offset: 0x0000BE81
		public bool FullScreen
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

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0000DC99 File Offset: 0x0000BE99
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x0000DCA1 File Offset: 0x0000BEA1
		public Color WindowRegionOverlayColor
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

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0000DCBE File Offset: 0x0000BEBE
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x0000DCC6 File Offset: 0x0000BEC6
		public Color CloseMessageTextColor
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0000DCE3 File Offset: 0x0000BEE3
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x0000DCEB File Offset: 0x0000BEEB
		public Color CloseMessageBorderTextColor
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

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x0000DD08 File Offset: 0x0000BF08
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000DD15 File Offset: 0x0000BF15
		public Rectangle SelectedRegion
		{
			get
			{
				return this.rectangle_0.smethod_24();
			}
			set
			{
				if (this.rectangle_0 != value)
				{
					this.rectangle_0 = value.smethod_24();
					this.method_0();
					base.Invalidate();
				}
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x0000DD3D File Offset: 0x0000BF3D
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000DD45 File Offset: 0x0000BF45
		public Enum124 SelectorType
		{
			get
			{
				return this.enum124_0;
			}
			set
			{
				if (this.enum124_0 != value)
				{
					this.enum124_0 = value;
				}
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0000DD57 File Offset: 0x0000BF57
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000DD5F File Offset: 0x0000BF5F
		public Color BorderColor
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0000DD84 File Offset: 0x0000BF84
		public Color BackgroundOverlayColor
		{
			get
			{
				return this.color_4;
			}
			set
			{
				if (this.color_4 != value)
				{
					this.color_4 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0000DDA1 File Offset: 0x0000BFA1
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public Bitmap ScreenCapture
		{
			get
			{
				return this.bitmap_0;
			}
			set
			{
				if (this.bitmap_0 != value)
				{
					this.bitmap_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0000DDC1 File Offset: 0x0000BFC1
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		public Rectangle SelectionBounds
		{
			get
			{
				return this.rectangle_1;
			}
			set
			{
				if (this.rectangle_1 != value)
				{
					this.rectangle_1 = value;
					this.method_1();
					this.method_0();
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0000DDF2 File Offset: 0x0000BFF2
		public Control5()
		{
			this.LockedMessage = string.Empty;
			this.MovableMessage = string.Empty;
			this.MovableResizeMessage = string.Empty;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0000DE2E File Offset: 0x0000C02E
		protected override void Dispose(bool disposing)
		{
			if (this.region_1 != null)
			{
				this.region_1.Dispose();
			}
			if (this.region_0 != null)
			{
				this.region_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0000DE5D File Offset: 0x0000C05D
		protected override void OnSizeChanged(EventArgs e)
		{
			this.method_1();
			this.method_0();
			base.Invalidate();
			base.OnSizeChanged(e);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00070218 File Offset: 0x0006E418
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			if (this.bitmap_0 != null)
			{
				e.Graphics.DrawImage(this.bitmap_0, base.ClientRectangle);
				if (this.region_1 != null)
				{
					using (SolidBrush solidBrush = new SolidBrush(this.color_4))
					{
						e.Graphics.FillRegion(solidBrush, this.region_1);
					}
					if (this.region_0 != null)
					{
						using (SolidBrush solidBrush2 = new SolidBrush(this.color_1))
						{
							e.Graphics.FillRegion(solidBrush2, this.region_0);
						}
						using (Pen pen = new Pen(Color.Red))
						{
							Rectangle rectangle = this.rectangle_0.smethod_24();
							Point pt = new Point(rectangle.X, rectangle.Y);
							Point pt2 = new Point(pt.X + rectangle.Width, pt.Y);
							Point pt3 = new Point(pt.X, pt.Y + rectangle.Height);
							Point pt4 = new Point(pt2.X, pt2.Y + rectangle.Height);
							e.Graphics.DrawLine(pen, new Point(this.rectangle_1.X, pt2.Y), pt2);
							e.Graphics.DrawLine(pen, new Point(pt4.X, this.rectangle_1.Y), pt4);
							e.Graphics.DrawLine(pen, pt3, new Point(this.rectangle_1.X + this.rectangle_1.Width, pt3.Y));
							e.Graphics.DrawLine(pen, pt, new Point(pt.X, this.rectangle_1.Y + this.rectangle_1.Height));
						}
					}
					using (Pen pen2 = new Pen(this.color_3, 2f))
					{
						e.Graphics.DrawRectangle(pen2, this.rectangle_1.smethod_3(2, 2).smethod_4(-1, -1));
					}
				}
			}
			if (this.bool_0)
			{
				using (StringFormat stringFormat = new StringFormat())
				{
					stringFormat.Alignment = StringAlignment.Near;
					stringFormat.LineAlignment = StringAlignment.Near;
					for (int i = 0; i < Screen.AllScreens.Length; i++)
					{
						Screen screen = Screen.AllScreens[i];
						Rectangle r = new Rectangle(screen.Bounds.X - SystemInformation.VirtualScreen.X, screen.Bounds.Y - SystemInformation.VirtualScreen.Y, screen.Bounds.Width, screen.Bounds.Height);
						switch (this.enum124_0)
						{
						case Enum124.const_0:
							Class490.smethod_1(e.Graphics, this.Font, this.MovableResizeMessage, 0.4f, r, this.CloseMessageTextColor, this.color_2, stringFormat);
							break;
						case Enum124.const_1:
							Class490.smethod_1(e.Graphics, this.Font, this.MovableMessage, 0.4f, r, this.CloseMessageTextColor, this.color_2, stringFormat);
							break;
						case Enum124.const_2:
							Class490.smethod_1(e.Graphics, this.Font, this.LockedMessage, 0.4f, r, this.CloseMessageTextColor, this.color_2, stringFormat);
							break;
						}
					}
					goto IL_557;
				}
			}
			using (StringFormat stringFormat2 = new StringFormat())
			{
				stringFormat2.Alignment = StringAlignment.Near;
				stringFormat2.LineAlignment = StringAlignment.Near;
				stringFormat2.Trimming = StringTrimming.None;
				stringFormat2.FormatFlags = StringFormatFlags.NoClip;
				SizeF sizeF = SizeF.Empty;
				switch (this.enum124_0)
				{
				case Enum124.const_0:
					sizeF = e.Graphics.MeasureString(this.MovableResizeMessage, this.Font, base.ClientSize, stringFormat2);
					break;
				case Enum124.const_1:
					sizeF = e.Graphics.MeasureString(this.MovableMessage, this.Font, base.ClientSize, stringFormat2);
					break;
				case Enum124.const_2:
					sizeF = e.Graphics.MeasureString(this.LockedMessage, this.Font, base.ClientSize, stringFormat2);
					break;
				}
				if (sizeF.Width <= (float)base.ClientSize.Width && sizeF.Height <= (float)base.ClientSize.Height)
				{
					switch (this.enum124_0)
					{
					case Enum124.const_0:
						Class490.smethod_1(e.Graphics, this.Font, this.MovableResizeMessage, 0.4f, base.ClientRectangle, this.CloseMessageTextColor, this.color_2, stringFormat2);
						break;
					case Enum124.const_1:
						Class490.smethod_1(e.Graphics, this.Font, this.MovableMessage, 0.4f, base.ClientRectangle, this.CloseMessageTextColor, this.color_2, stringFormat2);
						break;
					case Enum124.const_2:
						Class490.smethod_1(e.Graphics, this.Font, this.LockedMessage, 0.4f, base.ClientRectangle, this.CloseMessageTextColor, this.color_2, stringFormat2);
						break;
					}
				}
			}
			IL_557:
			base.OnPaint(e);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00070818 File Offset: 0x0006EA18
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				switch (this.enum124_0)
				{
				case Enum124.const_0:
					if (this.rectangle_1.Contains(e.Location))
					{
						this.rectangle_0.Location = e.Location;
						this.rectangle_0.Size = Size.Empty;
						this.method_0();
						base.Invalidate(this.rectangle_1);
						this.bool_1 = true;
					}
					break;
				case Enum124.const_1:
					if (this.rectangle_1.Contains(e.Location))
					{
						this.rectangle_0.Location = Control5.smethod_0(new Point(e.X - this.rectangle_0.Width / 2, e.Y - this.rectangle_0.Height / 2), this.rectangle_0.Size, this.rectangle_1);
						this.method_0();
						base.Invalidate(this.rectangle_1);
						this.bool_1 = true;
					}
					break;
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00070928 File Offset: 0x0006EB28
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.bool_1)
			{
				Point point = e.Location.smethod_2(this.rectangle_1);
				switch (this.enum124_0)
				{
				case Enum124.const_0:
					this.rectangle_0.Size = new Size(point.X - this.rectangle_0.X, point.Y - this.rectangle_0.Y);
					this.method_0();
					base.Invalidate(this.rectangle_1);
					break;
				case Enum124.const_1:
					this.rectangle_0.Location = Control5.smethod_0(new Point(point.X - this.rectangle_0.Width / 2, point.Y - this.rectangle_0.Height / 2), this.rectangle_0.Size, this.rectangle_1);
					this.method_0();
					base.Invalidate(this.rectangle_1);
					break;
				}
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0000DE78 File Offset: 0x0000C078
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.bool_1 = false;
			base.OnMouseUp(e);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00070A20 File Offset: 0x0006EC20
		private static Point smethod_0(Point p, Size sz, Rectangle max)
		{
			if (p.X + sz.Width > max.Right)
			{
				p.X = max.Right - sz.Width;
			}
			if (p.X < max.Left)
			{
				p.X = max.Left;
			}
			if (p.Y + sz.Height > max.Bottom)
			{
				p.Y = max.Bottom - sz.Height;
			}
			if (p.Y < max.Top)
			{
				p.Y = max.Top;
			}
			return p;
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00070AC8 File Offset: 0x0006ECC8
		private void method_0()
		{
			if (this.bitmap_0 != null)
			{
				if (this.rectangle_1 == Rectangle.Empty)
				{
					if (this.region_0 != null)
					{
						this.region_0.Dispose();
						this.region_0 = null;
						return;
					}
				}
				else
				{
					if (this.region_0 == null)
					{
						this.region_0 = new Region();
					}
					else
					{
						this.region_0.MakeEmpty();
					}
					this.region_0.Union(this.rectangle_1);
					this.region_0.Exclude(this.rectangle_0);
				}
			}
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00070B4C File Offset: 0x0006ED4C
		private void method_1()
		{
			if (this.bitmap_0 != null)
			{
				if (this.region_1 == null)
				{
					this.region_1 = new Region();
				}
				else
				{
					this.region_1.MakeEmpty();
				}
				this.region_1.Union(base.ClientRectangle);
				this.region_1.Exclude(this.rectangle_1);
			}
		}

		// Token: 0x04000DA8 RID: 3496
		private Enum124 enum124_0 = Enum124.const_1;

		// Token: 0x04000DA9 RID: 3497
		private Bitmap bitmap_0;

		// Token: 0x04000DAA RID: 3498
		private Region region_0;

		// Token: 0x04000DAB RID: 3499
		private Region region_1;

		// Token: 0x04000DAC RID: 3500
		private Rectangle rectangle_0;

		// Token: 0x04000DAD RID: 3501
		private Rectangle rectangle_1;

		// Token: 0x04000DAE RID: 3502
		private Color color_0;

		// Token: 0x04000DAF RID: 3503
		private Color color_1;

		// Token: 0x04000DB0 RID: 3504
		private Color color_2;

		// Token: 0x04000DB1 RID: 3505
		private Color color_3;

		// Token: 0x04000DB2 RID: 3506
		private Color color_4;

		// Token: 0x04000DB3 RID: 3507
		private bool bool_0;

		// Token: 0x04000DB4 RID: 3508
		private bool bool_1;

		// Token: 0x04000DB5 RID: 3509
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000DB6 RID: 3510
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000DB7 RID: 3511
		[CompilerGenerated]
		private string string_2;
	}
}
