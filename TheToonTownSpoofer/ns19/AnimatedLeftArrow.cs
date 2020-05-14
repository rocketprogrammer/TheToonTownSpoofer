using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns29;

namespace ns19
{
	// Token: 0x020003EC RID: 1004
	internal sealed class AnimatedLeftArrow : UserControl
	{
		// Token: 0x06002654 RID: 9812 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		protected override void Dispose(bool disposing)
		{
			if (this.graphicsPath_0 != null)
			{
				this.graphicsPath_0.Dispose();
			}
			this.graphicsPath_0 = null;
			this.point_0 = null;
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00088934 File Offset: 0x00086B34
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.timer_0.Enabled = true;
			this.timer_0.Tick += this.timer_0_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "AnimatedLeftArrow";
			base.Size = new Size(100, 20);
			base.ResumeLayout(false);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00011000 File Offset: 0x0000F200
		public AnimatedLeftArrow()
		{
			this.InitializeComponent();
			this.timer_0.Interval = AnimatedLeftArrow.int_0;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.method_0();
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000889C4 File Offset: 0x00086BC4
		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);
			this.timer_0.Enabled = false;
			this.timer_0.Interval = AnimatedLeftArrow.int_0;
			using (Matrix matrix = new Matrix())
			{
				matrix.Translate((float)(this.int_3 - this.int_4), 0f);
				this.int_4 = this.int_3;
				this.graphicsPath_0.Transform(matrix);
			}
			this.bool_0 = false;
			base.Invalidate();
			this.timer_0.Enabled = base.Enabled;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0001103B File Offset: 0x0000F23B
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.method_0();
			base.Invalidate();
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00011050 File Offset: 0x0000F250
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.FillPath(Brushes.Red, this.graphicsPath_0);
			e.Graphics.DrawPath(Pens.Black, this.graphicsPath_0);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00088A68 File Offset: 0x00086C68
		private void method_0()
		{
			this.int_2 = base.Height - base.Margin.Vertical;
			Class528.smethod_3(this.int_2, out this.point_0);
			this.graphicsPath_0.Reset();
			this.graphicsPath_0.StartFigure();
			for (int i = 0; i < this.point_0.Length - 1; i++)
			{
				this.graphicsPath_0.AddLine(this.point_0[i].X, this.point_0[i].Y, this.point_0[i + 1].X, this.point_0[i + 1].Y);
			}
			this.graphicsPath_0.CloseFigure();
			using (Matrix matrix = new Matrix())
			{
				matrix.Rotate(270f);
				this.graphicsPath_0.Transform(matrix);
			}
			this.int_5 = -(this.int_2 + 1);
			using (Matrix matrix2 = new Matrix())
			{
				matrix2.Translate((float)(base.Width + this.int_2 / 2), (float)(base.Height / 2));
				this.graphicsPath_0.Transform(matrix2);
			}
			this.int_4 = (this.int_3 = (int)Math.Floor((double)this.graphicsPath_0.PathPoints[4].X));
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00088BEC File Offset: 0x00086DEC
		private void timer_0_Tick(object sender, EventArgs e)
		{
			using (Matrix matrix = new Matrix())
			{
				if (this.bool_0)
				{
					this.timer_0.Interval = AnimatedLeftArrow.int_0;
					this.int_4 = this.int_3;
					matrix.Translate((float)(this.int_4 - this.int_5), 0f);
					this.bool_0 = false;
				}
				else
				{
					if (this.int_4 - AnimatedLeftArrow.int_1 < this.int_5)
					{
						matrix.Translate((float)(this.int_5 - this.int_4), 0f);
						this.int_4 = this.int_5;
					}
					else
					{
						matrix.Translate((float)(-(float)AnimatedLeftArrow.int_1), 0f);
						this.int_4 -= AnimatedLeftArrow.int_1;
					}
					if (this.int_4 == this.int_5)
					{
						this.bool_0 = true;
						this.timer_0.Interval = 500;
					}
				}
				this.graphicsPath_0.Transform(matrix);
				base.Invalidate();
				base.Update();
			}
		}

		// Token: 0x040012BC RID: 4796
		private IContainer icontainer_0;

		// Token: 0x040012BD RID: 4797
		private Timer timer_0;

		// Token: 0x040012BE RID: 4798
		private static readonly int int_0 = 30;

		// Token: 0x040012BF RID: 4799
		private static readonly int int_1 = 4;

		// Token: 0x040012C0 RID: 4800
		private Point[] point_0;

		// Token: 0x040012C1 RID: 4801
		private GraphicsPath graphicsPath_0 = new GraphicsPath();

		// Token: 0x040012C2 RID: 4802
		private int int_2;

		// Token: 0x040012C3 RID: 4803
		private int int_3;

		// Token: 0x040012C4 RID: 4804
		private int int_4;

		// Token: 0x040012C5 RID: 4805
		private bool bool_0;

		// Token: 0x040012C6 RID: 4806
		private int int_5;
	}
}
