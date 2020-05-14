using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ns18
{
	// Token: 0x020002A9 RID: 681
	internal sealed class Control2 : Control
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0000A4B7 File Offset: 0x000086B7
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000A4BF File Offset: 0x000086BF
		public int AnimationInterval
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.timer_0.Interval = this.int_0;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0000A4D9 File Offset: 0x000086D9
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x00057264 File Offset: 0x00055464
		[DefaultValue(typeof(Image), null)]
		public Image BaseImage
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
					if (this.image_0 != null)
					{
						if (this.bool_0)
						{
							base.Width = (this.int_5 = this.image_0.Width);
							base.Height = (this.int_6 = this.image_0.Height);
							return;
						}
						base.Width = (this.int_5 = this.image_0.Width / this.int_2);
						base.Height = (this.int_6 = this.image_0.Height / this.int_1);
						return;
					}
					else
					{
						this.int_5 = 0;
						base.Width = 0;
						this.int_6 = 0;
						base.Height = 0;
					}
				}
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0000A4E1 File Offset: 0x000086E1
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000A4E9 File Offset: 0x000086E9
		public int Columns
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0000A4F2 File Offset: 0x000086F2
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000A4FA File Offset: 0x000086FA
		public int Rows
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0000A503 File Offset: 0x00008703
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0000A50B File Offset: 0x0000870B
		public bool StaticImage
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0000A514 File Offset: 0x00008714
		public bool CurrentlyAnimating
		{
			get
			{
				return this.timer_0.Enabled;
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0005732C File Offset: 0x0005552C
		public Control2()
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
			this.timer_0 = new Timer();
			this.timer_0.Enabled = false;
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_0.Interval = this.int_0;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.FixedWidth | ControlStyles.FixedHeight | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, false);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0000A521 File Offset: 0x00008721
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.timer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00057428 File Offset: 0x00055628
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				if (this.float_0[3][3] >= 1f)
				{
					this.method_1();
					this.float_0[3][3] = 1f;
				}
				else
				{
					this.float_0[3][3] += 0.05f;
				}
			}
			else if (this.int_3 == this.int_2)
			{
				if (this.int_4 == this.int_1)
				{
					this.int_3 = 1;
					this.int_4 = 1;
				}
				else
				{
					this.int_3 = 1;
					this.int_4++;
				}
			}
			else
			{
				this.int_3++;
			}
			this.Refresh();
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000574E0 File Offset: 0x000556E0
		public void method_0()
		{
			if (!this.timer_0.Enabled)
			{
				this.timer_0.Start();
				if (this.bool_0)
				{
					this.float_0[3][3] = 0.05f;
				}
				else
				{
					this.int_3++;
				}
				this.Refresh();
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0000A538 File Offset: 0x00008738
		public void method_1()
		{
			this.timer_0.Stop();
			this.int_3 = 1;
			this.int_4 = 1;
			this.Refresh();
			this.float_0[3][3] = 0f;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00057534 File Offset: 0x00055734
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
			e.Graphics.InterpolationMode = InterpolationMode.Low;
			if (this.image_0 != null)
			{
				if (this.bool_0)
				{
					using (ImageAttributes imageAttributes = new ImageAttributes())
					{
						imageAttributes.SetColorMatrix(new ColorMatrix(this.float_0), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
						e.Graphics.DrawImage(this.image_0, new Rectangle(0, 0, this.int_5, this.int_6), 0, 0, this.int_5, this.int_6, GraphicsUnit.Pixel, imageAttributes);
						return;
					}
				}
				e.Graphics.DrawImage(this.image_0, new Rectangle(0, 0, this.int_5, this.int_6), new Rectangle((this.int_3 - 1) * this.int_5, (this.int_4 - 1) * this.int_6, this.int_5, this.int_6), GraphicsUnit.Pixel);
			}
		}

		// Token: 0x0400097E RID: 2430
		private Image image_0;

		// Token: 0x0400097F RID: 2431
		private Timer timer_0;

		// Token: 0x04000980 RID: 2432
		private int int_0 = 1000;

		// Token: 0x04000981 RID: 2433
		private int int_1 = 1;

		// Token: 0x04000982 RID: 2434
		private int int_2 = 1;

		// Token: 0x04000983 RID: 2435
		private int int_3 = 1;

		// Token: 0x04000984 RID: 2436
		private int int_4 = 1;

		// Token: 0x04000985 RID: 2437
		private int int_5;

		// Token: 0x04000986 RID: 2438
		private int int_6;

		// Token: 0x04000987 RID: 2439
		private bool bool_0;

		// Token: 0x04000988 RID: 2440
		private readonly float[][] float_0;
	}
}
