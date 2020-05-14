using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns17
{
	// Token: 0x02000288 RID: 648
	internal sealed class CircleProgressBar : UserControl
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x00009BE2 File Offset: 0x00007DE2
		public CircleProgressBar()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00009C0B File Offset: 0x00007E0B
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00009C18 File Offset: 0x00007E18
		[Category("Appearance")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool On
		{
			get
			{
				return this.timer_0.Enabled;
			}
			set
			{
				this.timer_0.Enabled = value;
				base.Invalidate();
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00009C2C File Offset: 0x00007E2C
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x00009C34 File Offset: 0x00007E34
		[DefaultValue(5)]
		[Category("Behavior")]
		[Browsable(true)]
		public int NoOfCircles
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00009C43 File Offset: 0x00007E43
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00009C4B File Offset: 0x00007E4B
		[Category("Behavior")]
		[Browsable(true)]
		[DefaultValue(75)]
		public short AnimationSpeed
		{
			get
			{
				return this.short_0;
			}
			set
			{
				if (value > 100)
				{
					value = 100;
				}
				if (value < 1)
				{
					value = 1;
				}
				this.short_0 = value;
				this.timer_0.Interval = (int)(101 - this.short_0);
				base.Invalidate();
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00009C7E File Offset: 0x00007E7E
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_0 = (this.int_0 + 5) % 360;
			base.Invalidate();
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000517BC File Offset: 0x0004F9BC
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			float num = (float)Math.Min(base.Height - base.Margin.Vertical, base.Width - base.Margin.Horizontal);
			float num2 = (float)(Math.Min(base.Height, base.Width) / 2);
			using (Pen pen = new Pen(this.ForeColor))
			{
				for (int i = 1; i <= this.int_1; i++)
				{
					float num3 = num / (float)this.int_1 * (float)i / 2f;
					RectangleF rect = new RectangleF(num2 - num3, num2 - num3, 2f * num3, 2f * num3);
					switch (i % 4)
					{
					case 0:
						e.Graphics.DrawArc(pen, rect, (float)this.int_0, 300f);
						break;
					case 1:
						e.Graphics.DrawArc(pen, rect, (float)(360 - this.int_0 + 90), 300f);
						break;
					case 2:
						e.Graphics.DrawArc(pen, rect, (float)(360 - this.int_0 + 180), 300f);
						break;
					default:
						e.Graphics.DrawArc(pen, rect, (float)(360 - this.int_0 + 270), 300f);
						break;
					}
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00009C9A File Offset: 0x00007E9A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0005194C File Offset: 0x0004FB4C
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Tick += this.timer_0_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "CircleProgressBar";
			base.ResumeLayout(false);
		}

		// Token: 0x0400087F RID: 2175
		private int int_0;

		// Token: 0x04000880 RID: 2176
		private int int_1 = 5;

		// Token: 0x04000881 RID: 2177
		private short short_0 = 75;

		// Token: 0x04000882 RID: 2178
		private IContainer icontainer_0;

		// Token: 0x04000883 RID: 2179
		private Timer timer_0;
	}
}
