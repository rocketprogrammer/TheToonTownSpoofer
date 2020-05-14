using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns16;
using ns17;
using ns23;
using ns26;
using ns27;
using ns30;
using ns31;

namespace ns22
{
	// Token: 0x02000357 RID: 855
	internal sealed class ImageRenderer : UserControl
	{
		// Token: 0x060021AE RID: 8622 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.image_0 != null)
				{
					this.image_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00071B50 File Offset: 0x0006FD50
		private void InitializeComponent()
		{
			this.Loader = new ProgressDots();
			base.SuspendLayout();
			this.Loader.Anchor = AnchorStyles.None;
			this.Loader.BackColor = Color.Transparent;
			this.Loader.BorderColor = Color.Purple;
			this.Loader.CenterColor = Color.FromArgb(192, 0, 192);
			this.Loader.Location = new Point(160, 110);
			this.Loader.Name = "Loader";
			this.Loader.OffsetAngle = 0;
			this.Loader.Running = false;
			this.Loader.Size = new Size(80, 80);
			this.Loader.SurroundColor = Color.MediumOrchid;
			this.Loader.TabIndex = 1;
			this.Loader.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.Loader);
			base.Name = "ImageRenderer";
			base.Size = new Size(400, 300);
			base.ResumeLayout(false);
		}

		// Token: 0x1400019A RID: 410
		// (add) Token: 0x060021B0 RID: 8624 RVA: 0x00071C90 File Offset: 0x0006FE90
		// (remove) Token: 0x060021B1 RID: 8625 RVA: 0x00071CC8 File Offset: 0x0006FEC8
		public event EventHandler ErrorLoading
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

		// Token: 0x1400019B RID: 411
		// (add) Token: 0x060021B2 RID: 8626 RVA: 0x00071D00 File Offset: 0x0006FF00
		// (remove) Token: 0x060021B3 RID: 8627 RVA: 0x00071D38 File Offset: 0x0006FF38
		public event EventHandler ImageLoaded
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

		// Token: 0x060021B4 RID: 8628 RVA: 0x0000E0EF File Offset: 0x0000C2EF
		public ImageRenderer()
		{
			this.object_0 = new object();
			this.InitializeComponent();
			this.class111_0 = Class110.Instance.MyGallerySettings;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0000E124 File Offset: 0x0000C324
		public void method_0()
		{
			if (base.IsHandleCreated)
			{
				if (this.short_0 == 0)
				{
					Class265.SendMessage_4(new HandleRef(this, base.Handle), Enum16.const_9, false, 0);
				}
				this.short_0 += 1;
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0000E15B File Offset: 0x0000C35B
		public void method_1()
		{
			this.short_0 -= 1;
			if (this.short_0 == 0)
			{
				Class265.SendMessage_4(new HandleRef(this, base.Handle), Enum16.const_9, true, 0);
				base.Invalidate();
			}
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00071D70 File Offset: 0x0006FF70
		private void method_2()
		{
			if (this.image_0 != null)
			{
				this.image_0.Dispose();
				this.image_0 = null;
				if (this.rectangle_0 != Rectangle.Empty)
				{
					base.Invalidate(this.rectangle_0);
				}
				this.rectangle_0 = Rectangle.Empty;
				base.Update();
			}
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00071DC8 File Offset: 0x0006FFC8
		public void method_3(string imagePath)
		{
			WaitCallback waitCallback = null;
			ImageRenderer.Class327 @class = new ImageRenderer.Class327();
			@class.string_0 = imagePath;
			@class.imageRenderer_0 = this;
			if (!string.IsNullOrEmpty(@class.string_0) && File.Exists(@class.string_0))
			{
				lock (this.object_0)
				{
					this.string_0 = @class.string_0;
				}
				this.Loader.Visible = true;
				this.Loader.Running = true;
				try
				{
					if (waitCallback == null)
					{
						waitCallback = new WaitCallback(@class.method_0);
					}
					ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				return;
			}
			lock (this.object_0)
			{
				this.string_0 = null;
			}
			this.method_2();
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00071ED0 File Offset: 0x000700D0
		public void method_4()
		{
			if (this.image_0 != null)
			{
				Rectangle rectangle = this.rectangle_0;
				switch (this.class111_0.ScreenshotScaling)
				{
				default:
					this.rectangle_0.Size = new Size(base.Width, base.Height);
					break;
				case Enum24.const_1:
					this.rectangle_0.Size = this.image_0.Size.smethod_2(base.Width, base.Height);
					break;
				case Enum24.const_2:
				{
					float num = (float)this.image_0.Width / (float)this.image_0.Height;
					float num2 = (float)base.Width / (float)base.Height;
					if (num > num2)
					{
						this.rectangle_0.Width = base.Width;
						this.rectangle_0.Height = (int)((float)base.Width / (float)this.image_0.Width * (float)this.image_0.Height);
					}
					else
					{
						this.rectangle_0.Height = base.Height;
						this.rectangle_0.Width = (int)((float)base.Height / (float)this.image_0.Height * (float)this.image_0.Width);
					}
					break;
				}
				}
				this.rectangle_0.Location = new Point(base.Width / 2 - this.rectangle_0.Width / 2, base.Height / 2 - this.rectangle_0.Height / 2);
				if (this.image_0 != null && this.rectangle_0 != Rectangle.Empty)
				{
					base.Invalidate(this.rectangle_0);
				}
				if (rectangle != Rectangle.Empty)
				{
					base.Invalidate(rectangle);
				}
				base.Update();
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0000E190 File Offset: 0x0000C390
		protected override void OnSizeChanged(EventArgs e)
		{
			if (this.image_0 != null)
			{
				this.method_4();
			}
			base.OnSizeChanged(e);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00072084 File Offset: 0x00070284
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			using (SolidBrush solidBrush = new SolidBrush(this.BackColor))
			{
				e.Graphics.FillRectangle(solidBrush, base.ClientRectangle);
			}
			if (this.image_0 != null)
			{
				e.Graphics.InterpolationMode = InterpolationMode.High;
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				e.Graphics.DrawImage(this.image_0, this.rectangle_0);
			}
		}

		// Token: 0x04000DD4 RID: 3540
		private IContainer icontainer_0;

		// Token: 0x04000DD5 RID: 3541
		private ProgressDots Loader;

		// Token: 0x04000DD6 RID: 3542
		private EventHandler eventHandler_0;

		// Token: 0x04000DD7 RID: 3543
		private EventHandler eventHandler_1;

		// Token: 0x04000DD8 RID: 3544
		private Image image_0;

		// Token: 0x04000DD9 RID: 3545
		private Class111 class111_0;

		// Token: 0x04000DDA RID: 3546
		private Rectangle rectangle_0;

		// Token: 0x04000DDB RID: 3547
		private short short_0;

		// Token: 0x04000DDC RID: 3548
		private string string_0;

		// Token: 0x04000DDD RID: 3549
		private readonly object object_0;

		// Token: 0x02000358 RID: 856
		[CompilerGenerated]
		private sealed class Class327
		{
			// Token: 0x060021BD RID: 8637 RVA: 0x00072104 File Offset: 0x00070304
			public void method_0(object _)
			{
				MethodInvoker methodInvoker = null;
				ImageRenderer.Class327.Class328 @class = new ImageRenderer.Class327.Class328();
				@class.class327_0 = this;
				@class.image_0 = null;
				try
				{
					@class.image_0 = Image.FromFile(this.string_0);
					Control sender = this.imageRenderer_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					sender.smethod_4(methodInvoker);
				}
				catch (Exception exception_)
				{
					ImageRenderer.Class327.Class329 class2 = new ImageRenderer.Class327.Class329();
					class2.class328_0 = @class;
					class2.class327_0 = this;
					class2.exception_0 = exception_;
					if (@class.image_0 != null)
					{
						@class.image_0.Dispose();
						@class.image_0 = null;
					}
					class2.exception_0.smethod_1(new object[]
					{
						this.string_0
					});
					this.imageRenderer_0.smethod_4(new MethodInvoker(class2.method_0));
				}
			}

			// Token: 0x04000DDE RID: 3550
			public ImageRenderer imageRenderer_0;

			// Token: 0x04000DDF RID: 3551
			public string string_0;

			// Token: 0x02000359 RID: 857
			private sealed class Class328
			{
				// Token: 0x060021BF RID: 8639 RVA: 0x000721D4 File Offset: 0x000703D4
				public void method_0()
				{
					lock (this.class327_0.imageRenderer_0.object_0)
					{
						if (this.class327_0.imageRenderer_0.string_0 != this.class327_0.string_0)
						{
							this.image_0.Dispose();
							return;
						}
					}
					if (this.class327_0.imageRenderer_0.Disposing || this.class327_0.imageRenderer_0.IsDisposed)
					{
						this.image_0.Dispose();
						return;
					}
					if (this.class327_0.imageRenderer_0.image_0 != null)
					{
						this.class327_0.imageRenderer_0.image_0.Dispose();
					}
					this.class327_0.imageRenderer_0.image_0 = this.image_0;
					this.class327_0.imageRenderer_0.method_4();
					this.class327_0.imageRenderer_0.Loader.Visible = false;
					this.class327_0.imageRenderer_0.Loader.Running = false;
					if (this.class327_0.imageRenderer_0.eventHandler_1 != null)
					{
						this.class327_0.imageRenderer_0.eventHandler_1(this.class327_0.imageRenderer_0, EventArgs.Empty);
					}
				}

				// Token: 0x04000DE0 RID: 3552
				public ImageRenderer.Class327 class327_0;

				// Token: 0x04000DE1 RID: 3553
				public Image image_0;
			}

			// Token: 0x0200035A RID: 858
			private sealed class Class329
			{
				// Token: 0x060021C1 RID: 8641 RVA: 0x00072334 File Offset: 0x00070534
				public void method_0()
				{
					this.class327_0.imageRenderer_0.method_2();
					this.class327_0.imageRenderer_0.Loader.Visible = false;
					this.class327_0.imageRenderer_0.Loader.Running = false;
					DialogBox.smethod_7(this.exception_0, this.class327_0.string_0);
					if (this.class327_0.imageRenderer_0.eventHandler_0 != null)
					{
						this.class327_0.imageRenderer_0.eventHandler_0(this.class327_0.imageRenderer_0, EventArgs.Empty);
					}
				}

				// Token: 0x04000DE2 RID: 3554
				public ImageRenderer.Class327.Class328 class328_0;

				// Token: 0x04000DE3 RID: 3555
				public ImageRenderer.Class327 class327_0;

				// Token: 0x04000DE4 RID: 3556
				public Exception exception_0;
			}
		}
	}
}
