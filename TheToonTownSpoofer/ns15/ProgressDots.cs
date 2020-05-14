using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns23;
using ns27;

namespace ns15
{
	// Token: 0x02000210 RID: 528
	internal sealed class ProgressDots : UserControl
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x00006F07 File Offset: 0x00005107
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.method_0();
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00037BC8 File Offset: 0x00035DC8
		private void method_0()
		{
			foreach (ProgressDots.Class158 @class in this.list_0)
			{
				@class.Dispose();
			}
			this.list_0.Clear();
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00037C24 File Offset: 0x00035E24
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 50;
			this.timer_0.Tick += this.timer_0_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "ProgressDots";
			base.Size = new Size(100, 100);
			base.SizeChanged += this.ProgressDots_SizeChanged;
			base.Paint += this.ProgressDots_Paint;
			base.ResumeLayout(false);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00037CE4 File Offset: 0x00035EE4
		public ProgressDots()
		{
			this.SurroundColor = Color.FromArgb(255, 177, 234, 250);
			this.CenterColor = Color.FromArgb(255, 82, 160, 239);
			this.BorderColor = Color.FromArgb(255, 158, 242, 239);
			base.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.InitializeComponent();
			this.method_1();
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00006F2C File Offset: 0x0000512C
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00006F34 File Offset: 0x00005134
		public Color SurroundColor
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
					this.method_1();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00006F57 File Offset: 0x00005157
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00006F5F File Offset: 0x0000515F
		public Color CenterColor
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
					this.method_1();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00006F82 File Offset: 0x00005182
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00006F8A File Offset: 0x0000518A
		public Color BorderColor
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
					this.method_1();
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00006FAD File Offset: 0x000051AD
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00006FB5 File Offset: 0x000051B5
		public int OffsetAngle
		{
			get
			{
				return this.int_3;
			}
			set
			{
				if (this.int_3 != value)
				{
					this.int_3 = value;
					this.method_1();
					base.Invalidate();
				}
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00037D94 File Offset: 0x00035F94
		private void ProgressDots_Paint(object sender, PaintEventArgs e)
		{
			this.bool_0 = false;
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			foreach (ProgressDots.Class158 @class in this.list_0)
			{
				using (PathGradientBrush pathGradientBrush = new PathGradientBrush(@class.graphicsPath_0))
				{
					List<ProgressDots.Class158>.Enumerator enumerator;
					pathGradientBrush.CenterPoint = enumerator.Current.point_0;
					pathGradientBrush.CenterColor = Color.FromArgb(enumerator.Current.int_0, this.color_1);
					pathGradientBrush.FocusScales = new PointF(0f, 0f);
					pathGradientBrush.SetBlendTriangularShape(0f, 0.8429412f);
					pathGradientBrush.SurroundColors = new Color[]
					{
						Color.FromArgb(enumerator.Current.int_0, this.color_0)
					};
					e.Graphics.FillEllipse(pathGradientBrush, enumerator.Current.rectangle_0);
					using (Pen pen = new Pen(Color.FromArgb(enumerator.Current.int_0, this.color_2)))
					{
						e.Graphics.DrawEllipse(pen, enumerator.Current.rectangle_0);
					}
				}
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00006FD3 File Offset: 0x000051D3
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00006FE0 File Offset: 0x000051E0
		public bool Running
		{
			get
			{
				return this.timer_0.Enabled;
			}
			set
			{
				this.timer_0.Enabled = value;
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00037F30 File Offset: 0x00036130
		private void method_1()
		{
			this.method_0();
			Point point = new Point(base.Width / 2, base.Height / 2);
			for (int i = 0; i < this.int_0; i++)
			{
				double num = Class477.smethod_11((double)((360 / this.int_0 * i + this.int_3) % 360));
				int num2 = Math.Min(base.Width - this.size_0.Width - base.Margin.Horizontal, base.Height - this.size_0.Height - base.Margin.Vertical) / 2;
				Point point_ = new Point((int)Math.Round((double)point.X + (double)num2 * Math.Cos(num)), (int)Math.Round((double)point.Y + (double)num2 * Math.Sin(num)));
				Point location = new Point(point_.X - this.size_0.Width / 2, point_.Y - this.size_0.Height / 2);
				ProgressDots.Class158 @class = null;
				try
				{
					@class = new ProgressDots.Class158();
					@class.rectangle_0 = new Rectangle(location, this.size_0);
					@class.graphicsPath_0 = new GraphicsPath();
					@class.graphicsPath_0.AddEllipse(@class.rectangle_0);
					@class.point_0 = point_;
					this.list_0.Add(@class);
				}
				catch (Exception ex)
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					@class = null;
					ex.smethod_0();
				}
			}
			this.method_2();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000380CC File Offset: 0x000362CC
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				if (this.bool_1)
				{
					for (int i = 0; i < this.list_0.Count; i++)
					{
						if (i != this.int_1)
						{
							this.list_0[i].int_0 -= (int)(255f * (1f / (float)this.int_2));
							if (this.list_0[i].int_0 < 0)
							{
								this.list_0[i].int_0 = 0;
							}
						}
					}
				}
				else
				{
					this.int_1++;
					if (this.int_1 >= this.int_0)
					{
						this.int_1 = 0;
					}
					this.method_2();
				}
				this.bool_1 = !this.bool_1;
				base.Invalidate();
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000381A4 File Offset: 0x000363A4
		private void method_2()
		{
			int num = 255;
			foreach (ProgressDots.Class158 @class in this.list_0)
			{
				@class.int_0 = 0;
			}
			int num2 = this.int_1;
			for (int i = 0; i < this.int_2; i++)
			{
				if (num2 > this.int_0 - 1)
				{
					num2 = 0;
				}
				this.list_0[num2].int_0 = (int)((float)num * (((float)i + 1f) / (float)this.int_2));
				num2++;
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00006FEE File Offset: 0x000051EE
		private void ProgressDots_SizeChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0400050E RID: 1294
		private IContainer icontainer_0;

		// Token: 0x0400050F RID: 1295
		private Timer timer_0;

		// Token: 0x04000510 RID: 1296
		private bool bool_0;

		// Token: 0x04000511 RID: 1297
		private int int_0 = 8;

		// Token: 0x04000512 RID: 1298
		private Size size_0 = new Size(16, 16);

		// Token: 0x04000513 RID: 1299
		private List<ProgressDots.Class158> list_0 = new List<ProgressDots.Class158>();

		// Token: 0x04000514 RID: 1300
		private int int_1;

		// Token: 0x04000515 RID: 1301
		private int int_2 = 6;

		// Token: 0x04000516 RID: 1302
		private bool bool_1;

		// Token: 0x04000517 RID: 1303
		private Color color_0;

		// Token: 0x04000518 RID: 1304
		private Color color_1;

		// Token: 0x04000519 RID: 1305
		private Color color_2;

		// Token: 0x0400051A RID: 1306
		private int int_3;

		// Token: 0x02000211 RID: 529
		private sealed class Class158 : IDisposable
		{
			// Token: 0x0600172A RID: 5930 RVA: 0x00006FF6 File Offset: 0x000051F6
			public void Dispose()
			{
				if (this.graphicsPath_0 != null)
				{
					this.graphicsPath_0.Dispose();
					this.graphicsPath_0 = null;
				}
			}

			// Token: 0x0400051B RID: 1307
			public GraphicsPath graphicsPath_0;

			// Token: 0x0400051C RID: 1308
			public Rectangle rectangle_0;

			// Token: 0x0400051D RID: 1309
			public Point point_0;

			// Token: 0x0400051E RID: 1310
			public int int_0;
		}
	}
}
