using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns29
{
	// Token: 0x020004CA RID: 1226
	internal sealed class Control12 : Control
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x00016125 File Offset: 0x00014325
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x0001612D File Offset: 0x0001432D
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "153, 255, 54")]
		public Color BaseColor
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
					this.method_0();
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00016150 File Offset: 0x00014350
		private void method_0()
		{
			this.DarkColor = ControlPaint.Dark(this.color_0);
			this.DarkDarkColor = ControlPaint.DarkDark(this.color_0);
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x00016174 File Offset: 0x00014374
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x0001617C File Offset: 0x0001437C
		public Color DarkColor { get; private set; }

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x00016185 File Offset: 0x00014385
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x0001618D File Offset: 0x0001438D
		public Color DarkDarkColor { get; private set; }

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x00016196 File Offset: 0x00014396
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x0001619E File Offset: 0x0001439E
		public bool On
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000161B6 File Offset: 0x000143B6
		public Control12()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.color_0 = Color.FromArgb(255, 153, 255, 54);
			this.method_0();
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000161F3 File Offset: 0x000143F3
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			this.method_1(e.Graphics);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000B0160 File Offset: 0x000AE360
		private void method_1(Graphics g)
		{
			Color color = this.bool_0 ? this.BaseColor : this.DarkColor;
			Color color2 = this.bool_0 ? this.DarkColor : this.DarkDarkColor;
			Rectangle rectangle = new Rectangle(base.Padding.Left, base.Padding.Top, base.Width - base.Padding.Horizontal, base.Height - base.Padding.Vertical);
			int num = (rectangle.Width < rectangle.Height) ? rectangle.Width : rectangle.Height;
			num--;
			Rectangle rect = new Rectangle(rectangle.X, rectangle.Y, num, num);
			if (rect.Width < 1)
			{
				rect.Width = 1;
			}
			if (rect.Height < 1)
			{
				rect.Height = 1;
			}
			using (SolidBrush solidBrush = new SolidBrush(color2))
			{
				g.FillEllipse(solidBrush, rect);
			}
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddEllipse(rect);
				using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath))
				{
					pathGradientBrush.CenterColor = color;
					pathGradientBrush.SurroundColors = new Color[]
					{
						Color.FromArgb(0, color)
					};
					g.FillEllipse(pathGradientBrush, rect);
				}
				using (GraphicsPath graphicsPath2 = new GraphicsPath())
				{
					graphicsPath2.AddEllipse(rect);
					g.SetClip(graphicsPath2);
				}
				using (GraphicsPath graphicsPath3 = new GraphicsPath())
				{
					Rectangle rect2 = new Rectangle(rect.X - Convert.ToInt32((float)rect.Width * 0.15f), rect.Y - Convert.ToInt32((float)rect.Width * 0.15f), Convert.ToInt32((float)rect.Width * 0.8f), Convert.ToInt32((float)rect.Height * 0.8f));
					graphicsPath3.AddEllipse(rect2);
					using (PathGradientBrush pathGradientBrush2 = new PathGradientBrush(graphicsPath))
					{
						pathGradientBrush2.CenterColor = Color.FromArgb(180, 255, 255, 255);
						pathGradientBrush2.SurroundColors = new Color[]
						{
							Color.FromArgb(0, 255, 255, 255)
						};
						g.FillEllipse(pathGradientBrush2, rect2);
					}
				}
			}
			g.SetClip(base.ClientRectangle);
			if (this.bool_0)
			{
				using (Pen pen = new Pen(Color.FromArgb(85, Color.Black), 1f))
				{
					g.DrawEllipse(pen, rect);
				}
			}
		}

		// Token: 0x04001819 RID: 6169
		private Color color_0;

		// Token: 0x0400181A RID: 6170
		private bool bool_0 = true;

		// Token: 0x0400181B RID: 6171
		[CompilerGenerated]
		private Color color_1;

		// Token: 0x0400181C RID: 6172
		[CompilerGenerated]
		private Color color_2;
	}
}
