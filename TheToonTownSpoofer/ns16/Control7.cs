using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns18;
using ns20;
using ns23;
using ns24;
using ns28;
using ns30;
using ns31;

namespace ns16
{
	// Token: 0x020003C5 RID: 965
	internal sealed class Control7 : UserControl
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x00010574 File Offset: 0x0000E774
		private void method_0()
		{
			this.icontainer_0 = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x06002537 RID: 9527 RVA: 0x0008001C File Offset: 0x0007E21C
		// (remove) Token: 0x06002538 RID: 9528 RVA: 0x00080054 File Offset: 0x0007E254
		public event EventHandler ScrollPosChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x00010588 File Offset: 0x0000E788
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x00010590 File Offset: 0x0000E790
		public Enum61 DrawingToolSize { get; set; }

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00010599 File Offset: 0x0000E799
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x000105A1 File Offset: 0x0000E7A1
		public Enum125 DrawingTool { get; set; }

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000105AA File Offset: 0x0000E7AA
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x0008008C File Offset: 0x0007E28C
		[DefaultValue(typeof(Bitmap), null)]
		public Bitmap Image
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
					this.method_3();
					if (this.bitmap_0 != null)
					{
						this.method_5();
						this.method_4();
					}
					this.rectangle_0 = Rectangle.Empty;
					this.float_0 = 1f;
					this.method_15();
					this.method_16();
					this.method_7();
					this.method_6();
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000105B2 File Offset: 0x0000E7B2
		public Bitmap Overlay
		{
			get
			{
				return this.bitmap_1;
			}
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000800F8 File Offset: 0x0007E2F8
		public Class95<T> method_1<T>() where T : Interface17
		{
			Class95<T> result;
			using (Class125 @class = new Class125(this.bitmap_1))
			{
				using (Class125 class2 = new Class125(this.bitmap_0))
				{
					result = new Class95<T>(@class, class2);
				}
			}
			return result;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00080158 File Offset: 0x0007E358
		public void method_2<T>(Class95<T> value) where T : Interface17
		{
			this.method_3();
			if (value == null)
			{
				if (this.bitmap_0 != null)
				{
					this.method_5();
				}
			}
			else
			{
				if (this.bitmap_0 == null)
				{
					throw new InvalidOperationException("Cannot use jagged bitmap without an base image.");
				}
				this.bitmap_1 = value.method_5(new Color?(this.color_0));
			}
			this.method_4();
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000105BA File Offset: 0x0000E7BA
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x000105C2 File Offset: 0x0000E7C2
		public MouseButtons PanButton { get; set; }

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000105CB File Offset: 0x0000E7CB
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x000105D8 File Offset: 0x0000E7D8
		public Point Origin
		{
			get
			{
				return this.rectangle_0.Location;
			}
			set
			{
				if (this.rectangle_0.Location != value)
				{
					this.rectangle_0.Location = value;
					this.method_17();
					this.method_6();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x0001060B File Offset: 0x0000E80B
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x000801B0 File Offset: 0x0007E3B0
		public float ZoomFactor
		{
			get
			{
				return this.float_0;
			}
			set
			{
				if (this.float_0 != value)
				{
					this.float_0 = value;
					if (this.float_0 > 15f)
					{
						this.float_0 = 15f;
					}
					if (this.float_0 < 0.05f)
					{
						this.float_0 = 0.05f;
					}
					if (this.bitmap_0 != null)
					{
						this.method_16();
						this.method_7();
						this.method_17();
					}
					if (this.CursorRectangle != null)
					{
						this.method_8();
					}
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x00010613 File Offset: 0x0000E813
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x00080234 File Offset: 0x0007E434
		private Rectangle? CursorRectangle
		{
			get
			{
				return this.nullable_0;
			}
			set
			{
				if (this.nullable_0 != value)
				{
					this.nullable_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0008028C File Offset: 0x0007E48C
		public Control7()
		{
			this.method_0();
			this.color_0 = Color.FromArgb(160, 64, 233, 96);
			this.solidBrush_0 = new SolidBrush(this.color_0);
			this.pen_0 = new Pen(this.solidBrush_0, 0f);
			this.solidBrush_1 = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
			this.pen_1 = new Pen(this.solidBrush_1, 0f);
			this.solidBrush_2 = new SolidBrush(Color.FromArgb(195, 255, 255, 255));
			this.DrawingTool = Enum125.const_0;
			this.PanButton = MouseButtons.Right;
			this.DrawingToolSize = Enum61.const_2;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00080364 File Offset: 0x0007E564
		protected override void Dispose(bool disposing)
		{
			if (this.pen_1 != null)
			{
				this.pen_1.Dispose();
			}
			if (this.solidBrush_2 != null)
			{
				this.solidBrush_2.Dispose();
			}
			if (this.solidBrush_1 != null)
			{
				this.solidBrush_1.Dispose();
			}
			if (this.pen_0 != null)
			{
				this.pen_0.Dispose();
			}
			if (this.graphics_0 != null)
			{
				this.graphics_0.Dispose();
			}
			if (this.bitmap_1 != null)
			{
				this.bitmap_1.Dispose();
			}
			if (this.solidBrush_0 != null)
			{
				this.solidBrush_0.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0001061B File Offset: 0x0000E81B
		private void method_3()
		{
			if (this.bitmap_1 != null)
			{
				this.bitmap_1.Dispose();
				this.graphics_0.Dispose();
				this.bitmap_1 = null;
				this.graphics_0 = null;
			}
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00010649 File Offset: 0x0000E849
		private void method_4()
		{
			this.graphics_0 = Graphics.FromImage(this.bitmap_1);
			this.graphics_0.CompositingMode = CompositingMode.SourceCopy;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00010668 File Offset: 0x0000E868
		private void method_5()
		{
			this.bitmap_1 = new Bitmap(this.bitmap_0.Width, this.bitmap_0.Height);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00080414 File Offset: 0x0007E614
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.Clear(this.BackColor);
			if (this.bitmap_0 == null)
			{
				return;
			}
			e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
			e.Graphics.SmoothingMode = SmoothingMode.None;
			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			e.Graphics.DrawImage(this.bitmap_0, base.ClientRectangle, this.rectangle_0, GraphicsUnit.Pixel);
			e.Graphics.DrawImage(this.bitmap_1, base.ClientRectangle, this.rectangle_0, GraphicsUnit.Pixel);
			if (this.CursorRectangle != null)
			{
				switch (this.DrawingTool)
				{
				case Enum125.const_1:
					e.Graphics.FillEllipse(this.solidBrush_0, this.CursorRectangle.Value);
					return;
				case Enum125.const_2:
					e.Graphics.FillEllipse(this.solidBrush_2, this.CursorRectangle.Value);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x0001068B File Offset: 0x0000E88B
		protected override void OnSizeChanged(EventArgs e)
		{
			this.method_7();
			base.OnSizeChanged(e);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0008050C File Offset: 0x0007E70C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this.bitmap_0 == null)
			{
				return;
			}
			if (this.bool_0)
			{
				int num = this.point_0.X - e.X;
				int num2 = this.point_0.Y - e.Y;
				this.Origin = new Point(this.rectangle_0.X + (int)((float)num / this.float_0), this.rectangle_0.Y + (int)((float)num2 / this.float_0));
			}
			else if (this.bool_1)
			{
				this.method_9(e.Location);
			}
			this.point_0 = e.Location;
			switch (this.DrawingTool)
			{
			case Enum125.const_1:
			case Enum125.const_2:
				this.method_8();
				return;
			default:
				return;
			}
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0001069A File Offset: 0x0000E89A
		protected override void OnMouseEnter(EventArgs e)
		{
			this.method_8();
			base.OnMouseEnter(e);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000805D0 File Offset: 0x0007E7D0
		protected override void OnMouseLeave(EventArgs e)
		{
			this.CursorRectangle = null;
			base.OnMouseLeave(e);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000106A9 File Offset: 0x0000E8A9
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			if (e.Delta > 0)
			{
				this.method_13(true);
				return;
			}
			if (e.Delta < 0)
			{
				this.method_13(false);
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000805F4 File Offset: 0x0007E7F4
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this.bitmap_0 == null)
			{
				return;
			}
			if (e.Button == MouseButtons.Left)
			{
				this.method_9(e.Location);
				this.bool_1 = true;
				return;
			}
			if (e.Button == MouseButtons.Right)
			{
				this.bool_0 = true;
				this.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000106D3 File Offset: 0x0000E8D3
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (this.bool_0)
			{
				this.bool_0 = false;
				this.Cursor = Cursors.Default;
				return;
			}
			if (this.bool_1)
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00010706 File Offset: 0x0000E906
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_7();
			this.method_15();
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0001071B File Offset: 0x0000E91B
		private void method_6()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00010736 File Offset: 0x0000E936
		private void method_7()
		{
			this.rectangle_0.Size = new Size((int)Math.Ceiling((double)((float)base.Width / this.float_0)), (int)Math.Ceiling((double)((float)base.Height / this.float_0)));
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00010772 File Offset: 0x0000E972
		private void method_8()
		{
			this.CursorRectangle = new Rectangle?(this.point_0.smethod_5(this.method_14().smethod_3(this.float_0)));
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00080654 File Offset: 0x0007E854
		private void method_9(Point p)
		{
			switch (this.DrawingTool)
			{
			case Enum125.const_1:
				this.method_10(p, this.solidBrush_0, this.pen_0);
				return;
			case Enum125.const_2:
				this.method_10(p, this.solidBrush_1, this.pen_1);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000806A0 File Offset: 0x0007E8A0
		private void method_10(Point point, SolidBrush sb, Pen p)
		{
			Point point2 = new Point((int)(((float)this.rectangle_0.X * this.float_0 + (float)this.point_0.X) / this.float_0), (int)(((float)this.rectangle_0.Y * this.float_0 + (float)this.point_0.Y) / this.float_0));
			Point point3 = new Point((int)(((float)this.rectangle_0.X * this.float_0 + (float)point.X) / this.float_0), (int)(((float)this.rectangle_0.Y * this.float_0 + (float)point.Y) / this.float_0));
			Size sz = this.method_14();
			p.Width = (float)sz.Width;
			this.graphics_0.DrawLine(p, point2, point3);
			this.graphics_0.FillEllipse(sb, point2.smethod_5(sz));
			this.graphics_0.FillEllipse(sb, point3.smethod_5(sz));
			sz = sz.smethod_3(this.float_0);
			base.Invalidate(point.smethod_5(sz));
			base.Invalidate(this.point_0.smethod_5(sz));
			base.Invalidate(Rectangle.FromLTRB(Math.Min(point.X, this.point_0.X), Math.Min(point.Y, this.point_0.Y), Math.Max(point.X, this.point_0.X), Math.Max(point.Y, this.point_0.Y)).smethod_5(sz));
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0001079B File Offset: 0x0000E99B
		public void method_11()
		{
			this.method_13(true);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000107A4 File Offset: 0x0000E9A4
		public void method_12()
		{
			this.method_13(false);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00080838 File Offset: 0x0007EA38
		private void method_13(bool zoomIn)
		{
			PointF pointF = new PointF((float)this.rectangle_0.X + (float)this.rectangle_0.Width / 2f, (float)this.rectangle_0.Y + (float)this.rectangle_0.Height / 2f);
			if (zoomIn)
			{
				this.ZoomFactor = (float)Math.Round((double)(this.float_0 * 1.1f), 2);
			}
			else
			{
				this.ZoomFactor = (float)Math.Round((double)(this.float_0 * 0.9f), 2);
			}
			this.Origin = new Point((int)(pointF.X - (float)base.ClientSize.Width / this.float_0 / 2f), (int)(pointF.Y - (float)base.ClientSize.Height / this.float_0 / 2f));
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00080918 File Offset: 0x0007EB18
		private Size method_14()
		{
			switch (this.DrawingToolSize)
			{
			case Enum61.const_0:
				return new Size(8, 8);
			case Enum61.const_1:
				return new Size(16, 16);
			case Enum61.const_2:
				return new Size(32, 32);
			case Enum61.const_3:
				return new Size(64, 64);
			case Enum61.const_4:
				return new Size(128, 128);
			case Enum61.const_5:
				return new Size(256, 256);
			default:
				return Size.Empty;
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00080998 File Offset: 0x0007EB98
		public void method_15()
		{
			this.Origin = new Point(0, 0);
			if (this.bitmap_0 == null)
			{
				return;
			}
			float num = 1f;
			if (this.bitmap_0.Size != base.ClientSize)
			{
				if (num * (float)this.bitmap_0.Width > (float)base.ClientSize.Width)
				{
					num = (float)base.ClientSize.Width / (float)this.bitmap_0.Width;
				}
				if (num * (float)this.bitmap_0.Height > (float)base.ClientSize.Height)
				{
					num = (float)base.ClientSize.Height / (float)this.bitmap_0.Height;
				}
				if (num * (float)this.bitmap_0.Width < (float)base.ClientSize.Width)
				{
					num = (float)base.ClientSize.Width / (float)this.bitmap_0.Width;
				}
				if (num * (float)this.bitmap_0.Height < (float)base.ClientSize.Height)
				{
					num = (float)base.ClientSize.Height / (float)this.bitmap_0.Height;
				}
			}
			this.ZoomFactor = num;
			this.method_6();
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00080AE0 File Offset: 0x0007ECE0
		private void method_16()
		{
			if (this.bitmap_0 != null)
			{
				bool flag = false;
				if ((float)this.bitmap_0.Height * this.float_0 < (float)base.Height)
				{
					flag = true;
					this.float_0 = (float)base.Height / (float)this.bitmap_0.Height;
				}
				if ((float)this.bitmap_0.Width * this.float_0 < (float)base.Width)
				{
					flag = true;
					this.float_0 = (float)base.Width / (float)this.bitmap_0.Width;
				}
				if (flag)
				{
					this.method_7();
					this.method_17();
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00080B80 File Offset: 0x0007ED80
		private void method_17()
		{
			if (this.bitmap_0 == null)
			{
				return;
			}
			bool flag = false;
			if (this.rectangle_0.X < 0)
			{
				this.rectangle_0.X = 0;
				flag = true;
			}
			if (this.rectangle_0.Y < 0)
			{
				this.rectangle_0.Y = 0;
				flag = true;
			}
			if ((float)this.rectangle_0.X > (float)this.bitmap_0.Width - (float)base.ClientSize.Width / this.float_0)
			{
				this.rectangle_0.X = this.bitmap_0.Width - (int)((float)base.ClientSize.Width / this.float_0);
				flag = true;
			}
			if (this.rectangle_0.Y > this.bitmap_0.Height - (int)((float)base.ClientSize.Height / this.float_0))
			{
				this.rectangle_0.Y = this.bitmap_0.Height - (int)((float)base.ClientSize.Height / this.float_0);
				flag = true;
			}
			if (this.rectangle_0.X < 0)
			{
				this.rectangle_0.X = 0;
				flag = true;
			}
			if (this.rectangle_0.Y < 0)
			{
				this.rectangle_0.Y = 0;
				flag = true;
			}
			if (flag)
			{
				this.method_6();
			}
		}

		// Token: 0x0400117A RID: 4474
		private IContainer icontainer_0;

		// Token: 0x0400117B RID: 4475
		private EventHandler eventHandler_0;

		// Token: 0x0400117C RID: 4476
		private SolidBrush solidBrush_0;

		// Token: 0x0400117D RID: 4477
		private Pen pen_0;

		// Token: 0x0400117E RID: 4478
		private SolidBrush solidBrush_1;

		// Token: 0x0400117F RID: 4479
		private Pen pen_1;

		// Token: 0x04001180 RID: 4480
		private SolidBrush solidBrush_2;

		// Token: 0x04001181 RID: 4481
		private Point point_0;

		// Token: 0x04001182 RID: 4482
		private Rectangle rectangle_0;

		// Token: 0x04001183 RID: 4483
		private Bitmap bitmap_0;

		// Token: 0x04001184 RID: 4484
		private float float_0 = 1f;

		// Token: 0x04001185 RID: 4485
		private Graphics graphics_0;

		// Token: 0x04001186 RID: 4486
		private Bitmap bitmap_1;

		// Token: 0x04001187 RID: 4487
		private Color color_0;

		// Token: 0x04001188 RID: 4488
		private Rectangle? nullable_0;

		// Token: 0x04001189 RID: 4489
		private bool bool_0;

		// Token: 0x0400118A RID: 4490
		private bool bool_1;

		// Token: 0x0400118B RID: 4491
		[CompilerGenerated]
		private Enum61 enum61_0;

		// Token: 0x0400118C RID: 4492
		[CompilerGenerated]
		private Enum125 enum125_0;

		// Token: 0x0400118D RID: 4493
		[CompilerGenerated]
		private MouseButtons mouseButtons_0;
	}
}
