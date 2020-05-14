using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns30;

namespace ns14
{
	// Token: 0x020001D6 RID: 470
	internal sealed class Blinker : UserControl
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000059FC File Offset: 0x00003BFC
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x00005A04 File Offset: 0x00003C04
		[DefaultValue(typeof(Image), null)]
		public Image OffImage
		{
			get
			{
				return this.image_1;
			}
			set
			{
				if (this.image_1 != value)
				{
					this.image_1 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00005A1C File Offset: 0x00003C1C
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00005A24 File Offset: 0x00003C24
		[DefaultValue(typeof(Image), null)]
		public Image OnImage
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
					base.Invalidate();
				}
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00005A44 File Offset: 0x00003C44
		public int MinimumBlinkDelay
		{
			get
			{
				return this.int_2;
			}
			set
			{
				if (this.int_1 != value)
				{
					this.int_2 = value;
					this.bool_0 = false;
					this.method_0();
				}
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00005A63 File Offset: 0x00003C63
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00005A6B File Offset: 0x00003C6B
		public int MaximumBlinkDelay
		{
			get
			{
				return this.int_1;
			}
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.bool_0 = false;
					this.method_0();
				}
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00005A8A File Offset: 0x00003C8A
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x00005A92 File Offset: 0x00003C92
		public int BlinkSpeed
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
					this.bool_0 = false;
					this.method_0();
				}
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000318A8 File Offset: 0x0002FAA8
		public Blinker()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.int_0 = 200;
			this.int_1 = 5000;
			this.int_2 = 1000;
			this.bool_0 = false;
			this.method_0();
			this.timer_0.Enabled = true;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00005AB1 File Offset: 0x00003CB1
		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);
			this.bool_0 = false;
			this.timer_0.Enabled = base.Enabled;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00031908 File Offset: 0x0002FB08
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.bool_0)
			{
				if (this.OnImage != null)
				{
					e.Graphics.DrawImage(this.OnImage, base.ClientRectangle);
					return;
				}
			}
			else if (this.OffImage != null)
			{
				e.Graphics.DrawImage(this.OffImage, base.ClientRectangle);
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00005AD2 File Offset: 0x00003CD2
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.bool_0 = !this.bool_0;
			if (this.bool_0)
			{
				this.timer_0.Interval = this.int_0;
			}
			else
			{
				this.method_0();
			}
			base.Invalidate();
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00005B0A File Offset: 0x00003D0A
		private void method_0()
		{
			this.timer_0.Interval = Class124.Instance.method_6(this.int_2, this.int_1);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00005B2D File Offset: 0x00003D2D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00031964 File Offset: 0x0002FB64
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Tick += this.timer_0_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "Blinker";
			base.ResumeLayout(false);
		}

		// Token: 0x040002E6 RID: 742
		private bool bool_0;

		// Token: 0x040002E7 RID: 743
		private int int_0;

		// Token: 0x040002E8 RID: 744
		private int int_1;

		// Token: 0x040002E9 RID: 745
		private int int_2;

		// Token: 0x040002EA RID: 746
		private Image image_0;

		// Token: 0x040002EB RID: 747
		private Image image_1;

		// Token: 0x040002EC RID: 748
		private IContainer icontainer_0;

		// Token: 0x040002ED RID: 749
		private Timer timer_0;
	}
}
