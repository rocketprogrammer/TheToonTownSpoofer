using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using ns25;

namespace ns21
{
	// Token: 0x0200025A RID: 602
	internal sealed class Control0 : Control
	{
		// Token: 0x1400017B RID: 379
		// (add) Token: 0x060019D5 RID: 6613 RVA: 0x00047A90 File Offset: 0x00045C90
		// (remove) Token: 0x060019D6 RID: 6614 RVA: 0x00047AC8 File Offset: 0x00045CC8
		public event EventHandler ShowScreenshot
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

		// Token: 0x1400017C RID: 380
		// (add) Token: 0x060019D7 RID: 6615 RVA: 0x00047B00 File Offset: 0x00045D00
		// (remove) Token: 0x060019D8 RID: 6616 RVA: 0x00047B38 File Offset: 0x00045D38
		public event EventHandler ButtonSelected
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0000908A File Offset: 0x0000728A
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00009092 File Offset: 0x00007292
		[DefaultValue(typeof(Bitmap), null)]
		public Bitmap Image
		{
			get
			{
				return this.bitmap_0;
			}
			set
			{
				if (this.bitmap_0 == value)
				{
					return;
				}
				this.bitmap_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000090AB File Offset: 0x000072AB
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x000090B3 File Offset: 0x000072B3
		public bool Selected
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				base.Invalidate();
				if (this.bool_0 && this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00047B70 File Offset: 0x00045D70
		public Control0()
		{
			float[][] array = new float[5][];
			float[][] array2 = array;
			int num = 0;
			float[] array3 = new float[5];
			array3[0] = 1f;
			array2[num] = array3;
			float[][] array4 = array;
			int num2 = 1;
			float[] array5 = new float[5];
			array5[1] = 1f;
			array4[num2] = array5;
			float[][] array6 = array;
			int num3 = 2;
			float[] array7 = new float[5];
			array7[2] = 1f;
			array6[num3] = array7;
			float[][] array8 = array;
			int num4 = 3;
			float[] array9 = new float[5];
			array8[num4] = array9;
			array[4] = new float[]
			{
				0f,
				0f,
				0f,
				0f,
				1f
			};
			this.float_0 = array;
			base..ctor();
			base.TabStop = false;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.PreviewKeyDown += this.Control0_PreviewKeyDown;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000090ED File Offset: 0x000072ED
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0003220C File Offset: 0x0003040C
		private void Control0_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Tab)
			{
				return;
			}
			e.IsInputKey = true;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00047C14 File Offset: 0x00045E14
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.Image != null)
			{
				Rectangle rectangle = new Rectangle(base.Padding.Left, base.Padding.Top, base.Width - base.Padding.Horizontal, base.Height - base.Padding.Vertical);
				using (ImageAttributes imageAttributes = new ImageAttributes())
				{
					if (!this.enum69_0.HasFlag(Enum69.const_1) && !this.Selected)
					{
						this.float_0[3][3] = 0.9f;
					}
					else
					{
						this.float_0[3][3] = 1f;
					}
					imageAttributes.SetColorMatrix(new ColorMatrix(this.float_0), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
					e.Graphics.DrawImage(this.Image, rectangle, 0, 0, this.Image.Width, this.Image.Height, GraphicsUnit.Pixel, imageAttributes);
					if (this.Selected)
					{
						using (Pen pen = new Pen(Color.FromArgb(209, 19, 19, 19), 6f))
						{
							e.Graphics.DrawRectangle(pen, rectangle);
							goto IL_16F;
						}
					}
					if (this.enum69_0.HasFlag(Enum69.const_1))
					{
						using (Pen pen2 = new Pen(Color.FromArgb(209, 51, 153, 255), 6f))
						{
							e.Graphics.DrawRectangle(pen2, rectangle);
						}
					}
					IL_16F:;
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00009108 File Offset: 0x00007308
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.enum69_0 |= Enum69.const_1;
			base.Invalidate();
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00009125 File Offset: 0x00007325
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.enum69_0 &= (Enum69)(-2);
			base.Invalidate();
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00009143 File Offset: 0x00007343
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.Selected = true;
			this.enum69_0 |= Enum69.const_2;
			base.Invalidate();
			this.method_0();
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0000916D File Offset: 0x0000736D
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.enum69_0 &= (Enum69)(-3);
			base.Invalidate();
		}

		// Token: 0x0400075A RID: 1882
		private Bitmap bitmap_0;

		// Token: 0x0400075B RID: 1883
		private Enum69 enum69_0;

		// Token: 0x0400075C RID: 1884
		private bool bool_0;

		// Token: 0x0400075D RID: 1885
		private EventHandler eventHandler_0;

		// Token: 0x0400075E RID: 1886
		private EventHandler eventHandler_1;

		// Token: 0x0400075F RID: 1887
		private readonly float[][] float_0;
	}
}
