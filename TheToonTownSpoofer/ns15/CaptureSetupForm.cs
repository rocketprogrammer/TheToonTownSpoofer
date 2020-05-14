using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns19;
using ns20;
using ns21;
using ns23;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;

namespace ns15
{
	// Token: 0x02000212 RID: 530
	internal partial class CaptureSetupForm : SaveForm
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x00007012 File Offset: 0x00005212
		public CaptureSetupForm()
		{
			this.InitializeComponent_1();
			this.class141_0 = new Class141();
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0003824C File Offset: 0x0003644C
		protected bool method_10(string message, string question, Struct46 ratio, out Class125 bmp, out Struct46 resulting_ratio)
		{
			bmp = null;
			resulting_ratio = default(Struct46);
			if (!this.class141_0.ProcessOpen && !this.class141_0.smethod_1(this))
			{
				return false;
			}
			using (Class499 @class = new Class499(this, true))
			{
				using (DialogBox dialogBox = new DialogBox(question, "Are you ready?", Enum90.const_0, null, false, Enum121.const_1, new Enum39[]
				{
					Enum39.const_0,
					Enum39.const_1
				}))
				{
					@class.method_1(dialogBox, DialogResult.OK);
					DialogResult dialogResult = dialogBox.ShowDialog();
					if (dialogResult != DialogResult.OK)
					{
						return false;
					}
					@class.method_4();
					@class.method_6();
				}
				if (this.class141_0.ProcessOpen)
				{
					Class410.smethod_8(this, this.class141_0.MainWindowHandle);
					using (CountDown countDown = new CountDown())
					{
						@class.method_1(countDown, DialogResult.OK);
						if (countDown.ShowDialog() == DialogResult.OK)
						{
							@class.method_6();
							@class.method_4();
							if (this.class141_0.ProcessOpen)
							{
								Class410.smethod_8(this, this.class141_0.MainWindowHandle);
								EventHandler eventHandler = null;
								CaptureSetupForm.Class159 class2 = new CaptureSetupForm.Class159();
								class2.regionSelector_0 = new RegionSelector(this.class141_0.MainWindowHandle);
								try
								{
									@class.method_0(class2.regionSelector_0);
									Rectangle rectangle = Class410.smethod_16(this.class141_0.MainWindowHandle);
									class2.regionSelector_0.SelectionBounds = Rectangle.Empty;
									class2.regionSelector_0.SelectedRegion = ratio.method_0(rectangle.Size);
									class2.regionSelector_0.RegionSelectorType = Enum124.const_0;
									class2.regionSelector_0.FullSelect = false;
									class2.regionSelector_0.FullSize = true;
									class2.regionSelector_0.FullScreenCapture = true;
									class2.regionSelector_0.MovableResizeMessage = message + " Press any key to accept or escape to cancel.";
									Form regionSelector_ = class2.regionSelector_0;
									if (eventHandler == null)
									{
										eventHandler = new EventHandler(class2.method_0);
									}
									regionSelector_.Shown += eventHandler;
									if (class2.regionSelector_0.ShowDialog() == DialogResult.OK && class2.regionSelector_0.SelectedRegion.smethod_2())
									{
										bmp = class2.regionSelector_0.SelectedBitmap;
										resulting_ratio = Struct46.smethod_3(class2.regionSelector_0.SelectedRegion, new Rectangle(Point.Empty, rectangle.Size));
										return true;
									}
								}
								finally
								{
									if (class2.regionSelector_0 != null)
									{
										((IDisposable)class2.regionSelector_0).Dispose();
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00038514 File Offset: 0x00036714
		protected static void smethod_0(Class150 pix, Control12 led)
		{
			if (pix == null)
			{
				led.BaseColor = Color.FromArgb(255, 255, 128, 128);
				return;
			}
			led.BaseColor = Color.FromArgb(255, 153, 255, 54);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0000702B File Offset: 0x0000522B
		protected void method_11(Class150 pix, Control ctr)
		{
			this.method_12();
			this.pixelatorRenderer_0 = new PixelatorRenderer(pix);
			this.class359_0 = new Class359(this.pixelatorRenderer_0);
			this.class359_0.method_1(ctr);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0000705C File Offset: 0x0000525C
		protected void method_12()
		{
			if (this.pixelatorRenderer_0 != null)
			{
				this.pixelatorRenderer_0.Dispose();
				this.pixelatorRenderer_0 = null;
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00038560 File Offset: 0x00036760
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CaptureSetupForm));
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.ClientSize = new Size(284, 262);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "CaptureSetupForm";
			base.ResumeLayout(false);
		}

		// Token: 0x0400051F RID: 1311
		protected Class141 class141_0;

		// Token: 0x04000520 RID: 1312
		protected Class359 class359_0;

		// Token: 0x04000521 RID: 1313
		protected PixelatorRenderer pixelatorRenderer_0;

		// Token: 0x02000213 RID: 531
		[CompilerGenerated]
		private sealed class Class159
		{
			// Token: 0x06001733 RID: 5939 RVA: 0x00007078 File Offset: 0x00005278
			public void method_0(object sender, EventArgs e)
			{
				this.regionSelector_0.BringToFront();
				this.regionSelector_0.Activate();
			}

			// Token: 0x04000522 RID: 1314
			public RegionSelector regionSelector_0;
		}
	}
}
