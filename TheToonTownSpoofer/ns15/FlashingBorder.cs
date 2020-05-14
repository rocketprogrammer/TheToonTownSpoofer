using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x02000218 RID: 536
	internal sealed class FlashingBorder : UserControl
	{
		// Token: 0x06001778 RID: 6008 RVA: 0x000072CC File Offset: 0x000054CC
		protected override void Dispose(bool disposing)
		{
			if (this.region_0 != null)
			{
				this.region_0.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0003D94C File Offset: 0x0003BB4C
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += this.timer_0_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "FlashingBorder";
			base.ResumeLayout(false);
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x000072FE File Offset: 0x000054FE
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00007306 File Offset: 0x00005506
		public int BorderSize
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					base.Invalidate(this.region_0);
					this.method_0();
					base.Invalidate(this.region_0);
				}
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x00007336 File Offset: 0x00005536
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000733E File Offset: 0x0000553E
		public bool EnableFlashing
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				if (this.bool_1 != value)
				{
					this.bool_1 = value;
					this.timer_0.Enabled = this.bool_1;
					if (!this.bool_1)
					{
						this.bool_0 = false;
						base.Invalidate(this.region_0);
					}
				}
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0000737C File Offset: 0x0000557C
		public FlashingBorder()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.region_0 = new Region();
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0003D9D0 File Offset: 0x0003BBD0
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.bool_0)
			{
				using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
				{
					e.Graphics.FillRegion(solidBrush, this.region_0);
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0003DA28 File Offset: 0x0003BC28
		private void method_0()
		{
			this.region_0.MakeEmpty();
			this.region_0.Union(new Rectangle(Point.Empty, new Size(base.Width, this.int_0)));
			this.region_0.Union(new Rectangle(new Point(0, this.int_0), new Size(this.int_0, base.Height - this.int_0 * 2)));
			this.region_0.Union(new Rectangle(new Point(base.Width - this.int_0, this.int_0), new Size(this.int_0, base.Height - this.int_0 * 2)));
			this.region_0.Union(new Rectangle(new Point(0, base.Height - this.int_0), new Size(base.Width, this.int_0)));
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000073A1 File Offset: 0x000055A1
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.method_0();
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000073B0 File Offset: 0x000055B0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.bool_0 = !this.bool_0;
			base.Invalidate(this.region_0);
		}

		// Token: 0x040005A8 RID: 1448
		private IContainer icontainer_0;

		// Token: 0x040005A9 RID: 1449
		private Timer timer_0;

		// Token: 0x040005AA RID: 1450
		private bool bool_0;

		// Token: 0x040005AB RID: 1451
		private int int_0;

		// Token: 0x040005AC RID: 1452
		private Region region_0;

		// Token: 0x040005AD RID: 1453
		private bool bool_1;
	}
}
