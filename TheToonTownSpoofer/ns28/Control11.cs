using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using ns25;

namespace ns28
{
	// Token: 0x020004A9 RID: 1193
	internal sealed class Control11 : Control
	{
		// Token: 0x140001DF RID: 479
		// (add) Token: 0x06002C65 RID: 11365 RVA: 0x000ABCBC File Offset: 0x000A9EBC
		// (remove) Token: 0x06002C66 RID: 11366 RVA: 0x000ABCF4 File Offset: 0x000A9EF4
		public event EventHandler ValueChanged
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

		// Token: 0x06002C67 RID: 11367 RVA: 0x000ABD2C File Offset: 0x000A9F2C
		public Control11()
		{
			this.color_0 = Color.FromArgb(24, 130, 198);
			this.color_2 = Color.FromArgb(43, 86, 114);
			this.color_1 = Color.FromArgb(92, 185, 245);
			this.color_4 = Color.FromArgb(92, 185, 245);
			this.color_3 = Color.FromArgb(90, 93, 90);
			this.rectangleF_0.Width = 20f;
			this.rectangleF_0.Height = 20f;
			this.int_1 = 3;
			base.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00014EAC File Offset: 0x000130AC
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00014EC7 File Offset: 0x000130C7
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x00014ECF File Offset: 0x000130CF
		public float MaxValue
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
					if (this.float_1 > this.float_0)
					{
						this.float_1 = this.float_0;
					}
					this.method_3();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00014F07 File Offset: 0x00013107
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x000ABE38 File Offset: 0x000AA038
		public float Value
		{
			get
			{
				return this.float_1;
			}
			set
			{
				if (this.float_1 != value)
				{
					if (value < 0f || value > this.float_0)
					{
						throw new ArgumentOutOfRangeException("The value must be equal or greater to 0 and less then the maximum value.");
					}
					this.float_1 = value;
					this.method_3();
					this.method_2();
					this.method_0();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00014F0F File Offset: 0x0001310F
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00014F17 File Offset: 0x00013117
		[Description("Gets or set tracker's color.")]
		[Category("Appearance")]
		public Color TrackerColor
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

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x00014F34 File Offset: 0x00013134
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x00014F3C File Offset: 0x0001313C
		[Description("Gets or sets the color of the track line.")]
		[Category("Appearance")]
		public Color TrackLineColor
		{
			get
			{
				return this.color_3;
			}
			set
			{
				if (value != this.color_3)
				{
					this.color_3 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000ABE8C File Offset: 0x000AA08C
		private void method_1()
		{
			this.rectangleF_2 = new RectangleF((float)(base.Margin.Left + Control11.int_0), (float)base.Height / 2f - (float)this.int_1 / 2f, (float)(base.Width - base.Margin.Horizontal - Control11.int_0 * 2), (float)this.int_1);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000ABEFC File Offset: 0x000AA0FC
		private void method_2()
		{
			this.rectangleF_1 = new RectangleF((float)(base.Margin.Left + Control11.int_0), (float)base.Height / 2f - (float)this.int_1 / 2f, this.rectangleF_0.X - (float)base.Margin.Left, (float)this.int_1);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000ABF68 File Offset: 0x000AA168
		private void method_3()
		{
			float num = (float)(base.Width - base.Margin.Horizontal) - this.rectangleF_0.Width;
			float num2 = num * this.float_1 / this.float_0;
			this.rectangleF_0.X = num2 + (float)base.Margin.Left;
			this.rectangleF_0.Y = (float)base.Height / 2f - this.rectangleF_0.Height / 2f;
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00014F59 File Offset: 0x00013159
		protected override void OnSizeChanged(EventArgs e)
		{
			this.method_3();
			this.method_1();
			this.method_2();
			base.OnSizeChanged(e);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000ABFF0 File Offset: 0x000AA1F0
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Class503.smethod_1(e.Graphics, this.rectangleF_2, this.color_3, Orientation.Horizontal);
			Class503.smethod_1(e.Graphics, this.rectangleF_1, this.color_0, Orientation.Horizontal);
			switch (this.enum69_0)
			{
			case Enum69.const_1:
				Class503.smethod_0(e.Graphics, this.rectangleF_0, this.color_1, Orientation.Horizontal);
				break;
			case Enum69.const_2:
				Class503.smethod_0(e.Graphics, this.rectangleF_0, this.color_2, Orientation.Horizontal);
				break;
			default:
				Class503.smethod_0(e.Graphics, this.rectangleF_0, this.color_0, Orientation.Horizontal);
				break;
			}
			base.OnPaint(e);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000AC0A4 File Offset: 0x000AA2A4
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.enum69_0 == Enum69.const_2)
			{
				float num = (float)(base.Width - base.Margin.Horizontal) - this.rectangleF_0.Width;
				float num2 = (float)(e.X - this.int_2) + this.float_2;
				if (num2 < (float)base.Margin.Left)
				{
					num2 = (float)base.Margin.Left;
				}
				if (num2 > (float)(base.Width - base.Margin.Right) - this.rectangleF_0.Width)
				{
					num2 = (float)(base.Width - base.Margin.Right) - this.rectangleF_0.Width;
				}
				float num3 = (num2 - (float)base.Margin.Left) / num;
				float num4 = num3 * this.float_0;
				if (num4 != this.float_1)
				{
					this.float_1 = num4;
					this.rectangleF_0.X = num2;
					this.method_2();
					base.Invalidate();
					this.method_0();
				}
			}
			else if (this.rectangleF_0.Contains(e.Location))
			{
				if (this.enum69_0 != Enum69.const_1)
				{
					this.enum69_0 = Enum69.const_1;
					base.Invalidate();
				}
			}
			else if (this.enum69_0 == Enum69.const_1)
			{
				this.enum69_0 = Enum69.const_0;
				base.Invalidate();
			}
			base.OnMouseMove(e);
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00014F74 File Offset: 0x00013174
		protected override void OnMouseLeave(EventArgs e)
		{
			if (this.enum69_0 == Enum69.const_2)
			{
				this.enum69_0 = Enum69.const_0;
				base.Invalidate();
			}
			else if (this.enum69_0 == Enum69.const_1)
			{
				this.enum69_0 = Enum69.const_0;
				base.Invalidate();
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000AC200 File Offset: 0x000AA400
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (this.enum69_0 == Enum69.const_1)
			{
				this.float_2 = this.rectangleF_0.X;
				this.int_2 = e.Location.X;
				this.enum69_0 = Enum69.const_2;
				base.Invalidate();
			}
			base.OnMouseDown(e);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00014FAB File Offset: 0x000131AB
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this.enum69_0 == Enum69.const_2)
			{
				if (this.rectangleF_0.Contains(e.Location))
				{
					this.enum69_0 = Enum69.const_1;
				}
				else
				{
					this.enum69_0 = Enum69.const_0;
				}
				base.Invalidate();
			}
			base.OnMouseUp(e);
		}

		// Token: 0x04001751 RID: 5969
		private static readonly int int_0 = 6;

		// Token: 0x04001752 RID: 5970
		private Color color_0 = SystemColors.Control;

		// Token: 0x04001753 RID: 5971
		private Color color_1 = SystemColors.Control;

		// Token: 0x04001754 RID: 5972
		private Color color_2 = SystemColors.Control;

		// Token: 0x04001755 RID: 5973
		private Enum69 enum69_0;

		// Token: 0x04001756 RID: 5974
		private RectangleF rectangleF_0 = RectangleF.Empty;

		// Token: 0x04001757 RID: 5975
		private Color color_3 = SystemColors.Control;

		// Token: 0x04001758 RID: 5976
		private Color color_4 = SystemColors.Control;

		// Token: 0x04001759 RID: 5977
		private RectangleF rectangleF_1;

		// Token: 0x0400175A RID: 5978
		private int int_1 = 3;

		// Token: 0x0400175B RID: 5979
		private RectangleF rectangleF_2 = RectangleF.Empty;

		// Token: 0x0400175C RID: 5980
		private float float_0 = 100f;

		// Token: 0x0400175D RID: 5981
		private float float_1;

		// Token: 0x0400175E RID: 5982
		private float float_2;

		// Token: 0x0400175F RID: 5983
		private int int_2;

		// Token: 0x04001760 RID: 5984
		private EventHandler eventHandler_0;
	}
}
