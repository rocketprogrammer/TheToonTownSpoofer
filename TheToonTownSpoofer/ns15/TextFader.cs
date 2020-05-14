using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x0200020B RID: 523
	internal sealed class TextFader : Control
	{
		// Token: 0x060016F7 RID: 5879 RVA: 0x00006D7E File Offset: 0x00004F7E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00037A50 File Offset: 0x00035C50
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Interval = 10;
			this.timer_0.Tick += this.timer_0_Tick;
			base.Name = "TextFader";
			base.ResumeLayout(false);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00006D9D File Offset: 0x00004F9D
		public TextFader()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.FadeOutDelay = 5000;
			this.FadeOutRate = 10;
			this.FadeOutAlphaRate = 5;
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00006DD1 File Offset: 0x00004FD1
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00006DD9 File Offset: 0x00004FD9
		public int FadeOutDelay { get; set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00006DE2 File Offset: 0x00004FE2
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00006DEA File Offset: 0x00004FEA
		public int FadeOutRate { get; set; }

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00006DF3 File Offset: 0x00004FF3
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x00006DFB File Offset: 0x00004FFB
		public int FadeOutAlphaRate { get; set; }

		// Token: 0x06001700 RID: 5888 RVA: 0x00006E04 File Offset: 0x00005004
		public void method_0()
		{
			this.int_0 = 255;
			this.timer_0.Enabled = false;
			this.timer_0.Interval = this.FadeOutDelay;
			this.timer_0.Enabled = true;
			base.Invalidate();
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00006E40 File Offset: 0x00005040
		public void method_1()
		{
			if (this.int_0 > 0)
			{
				this.timer_0.Interval = this.FadeOutRate;
				this.timer_0.Enabled = true;
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00037AB8 File Offset: 0x00035CB8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.timer_0.Interval = this.FadeOutRate;
			this.int_0 -= this.FadeOutAlphaRate;
			if (this.int_0 <= 0)
			{
				this.int_0 = 0;
				this.timer_0.Enabled = false;
			}
			base.Invalidate();
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00037B0C File Offset: 0x00035D0C
		protected override void OnPaint(PaintEventArgs e)
		{
			if (base.DesignMode)
			{
				this.int_0 = 255;
			}
			if (this.int_0 > 0)
			{
				using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(this.int_0, this.ForeColor)))
				{
					using (StringFormat stringFormat = new StringFormat())
					{
						stringFormat.Alignment = StringAlignment.Center;
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Trimming = StringTrimming.EllipsisCharacter;
						e.Graphics.DrawString(this.Text, this.Font, solidBrush, base.ClientRectangle, stringFormat);
					}
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x04000501 RID: 1281
		private IContainer icontainer_0;

		// Token: 0x04000502 RID: 1282
		private Timer timer_0;

		// Token: 0x04000503 RID: 1283
		private int int_0;

		// Token: 0x04000504 RID: 1284
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000505 RID: 1285
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04000506 RID: 1286
		[CompilerGenerated]
		private int int_3;
	}
}
