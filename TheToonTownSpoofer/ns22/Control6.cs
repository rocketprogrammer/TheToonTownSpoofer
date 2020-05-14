using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns25;

namespace ns22
{
	// Token: 0x02000376 RID: 886
	internal sealed class Control6 : UserControl
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x0000EBEE File Offset: 0x0000CDEE
		public Control6()
		{
			this.method_3();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.enum69_0 = Enum69.const_0;
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0000EC0F File Offset: 0x0000CE0F
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0000EC17 File Offset: 0x0000CE17
		[Category("Appearance")]
		[DefaultValue(typeof(Image), null)]
		public Image ImageEnter
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0000EC2F File Offset: 0x0000CE2F
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0000EC37 File Offset: 0x0000CE37
		[Category("Appearance")]
		[DefaultValue(typeof(Image), null)]
		public Image ImageNormal
		{
			get
			{
				return this.image_2;
			}
			set
			{
				if (this.image_2 != value)
				{
					this.image_2 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0000EC4F File Offset: 0x0000CE4F
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0000EC57 File Offset: 0x0000CE57
		[DefaultValue(typeof(Image), null)]
		[Category("Appearance")]
		public Image ImageDown
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

		// Token: 0x060022D1 RID: 8913 RVA: 0x0000EC6F File Offset: 0x0000CE6F
		protected override void OnMouseEnter(EventArgs e)
		{
			this.enum69_0 = Enum69.const_1;
			base.Invalidate();
			base.OnMouseEnter(e);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0000EC85 File Offset: 0x0000CE85
		protected override void OnMouseLeave(EventArgs e)
		{
			this.enum69_0 = Enum69.const_0;
			base.Invalidate();
			base.OnMouseLeave(e);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00076498 File Offset: 0x00074698
		protected override void OnPaint(PaintEventArgs e)
		{
			switch (this.enum69_0)
			{
			default:
				this.method_2(e);
				break;
			case Enum69.const_1:
				this.method_1(e);
				break;
			case Enum69.const_2:
				this.method_0(e);
				break;
			}
			base.OnPaint(e);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0000EC9B File Offset: 0x0000CE9B
		private void method_0(PaintEventArgs e)
		{
			if (this.ImageDown != null)
			{
				e.Graphics.DrawImage(this.ImageDown, base.ClientRectangle);
				return;
			}
			this.method_2(e);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		private void method_1(PaintEventArgs e)
		{
			if (this.ImageEnter != null)
			{
				e.Graphics.DrawImage(this.ImageEnter, base.ClientRectangle);
				return;
			}
			this.method_2(e);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0000ECED File Offset: 0x0000CEED
		private void method_2(PaintEventArgs e)
		{
			if (this.ImageNormal != null)
			{
				e.Graphics.DrawImage(this.ImageNormal, base.ClientRectangle);
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0000ED0E File Offset: 0x0000CF0E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0000ED2D File Offset: 0x0000CF2D
		private void method_3()
		{
			this.icontainer_0 = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x04001003 RID: 4099
		private Enum69 enum69_0;

		// Token: 0x04001004 RID: 4100
		private Image image_0;

		// Token: 0x04001005 RID: 4101
		private Image image_1;

		// Token: 0x04001006 RID: 4102
		private Image image_2;

		// Token: 0x04001007 RID: 4103
		private IContainer icontainer_0;
	}
}
