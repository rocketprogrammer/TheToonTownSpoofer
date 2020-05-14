using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns21;

namespace ns28
{
	// Token: 0x020004A6 RID: 1190
	internal sealed class Class503
	{
		// Token: 0x06002C46 RID: 11334 RVA: 0x000AB368 File Offset: 0x000A9568
		public static void smethod_0(Graphics g, RectangleF drawRectF, Color drawColor, Orientation orientation)
		{
			Color color = Class188.smethod_0(Class188.smethod_1(drawColor, Color.Black, 100), Color.White, 40);
			Color color2 = Class188.smethod_0(Class188.smethod_1(drawColor, Color.FromArgb(64, 64, 64), 100), Color.White, 20);
			Color color3 = Class188.smethod_1(drawColor, Color.FromArgb(128, 128, 128), 100);
			Color color4 = Class188.smethod_1(drawColor, Color.FromArgb(192, 192, 192), 100);
			Color color5 = Class188.smethod_2(Class188.smethod_1(drawColor, Color.White, 100), Color.White, 75);
			ColorBlend colorBlend = new ColorBlend();
			colorBlend.Colors = new Color[]
			{
				color,
				color2,
				color3,
				color4,
				color5
			};
			colorBlend.Positions = new float[]
			{
				0f,
				0.25f,
				0.5f,
				0.75f,
				1f
			};
			using (LinearGradientBrush linearGradientBrush = (orientation == Orientation.Horizontal) ? new LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top - 1), new Point((int)drawRectF.Left, (int)drawRectF.Top + (int)drawRectF.Height + 1), color, color5) : new LinearGradientBrush(new Point((int)drawRectF.Left - 1, (int)drawRectF.Top), new Point((int)drawRectF.Left + (int)drawRectF.Width + 1, (int)drawRectF.Top), color, color5))
			{
				linearGradientBrush.InterpolationColors = colorBlend;
				Class503.smethod_2(g, drawRectF, linearGradientBrush);
			}
			color2 = Color.White;
			colorBlend.Colors = new Color[]
			{
				color2,
				color3,
				color4,
				color5
			};
			colorBlend.Positions = new float[]
			{
				0f,
				0.5f,
				0.75f,
				1f
			};
			using (LinearGradientBrush linearGradientBrush2 = (orientation == Orientation.Horizontal) ? new LinearGradientBrush(new Point((int)drawRectF.Left + 1, (int)drawRectF.Top), new Point((int)drawRectF.Left + 1, (int)drawRectF.Top + (int)drawRectF.Height - 1), color2, color5) : new LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top + 1), new Point((int)drawRectF.Left + (int)drawRectF.Width - 1, (int)drawRectF.Top + 1), color2, color5))
			{
				linearGradientBrush2.InterpolationColors = colorBlend;
				Class503.smethod_2(g, RectangleF.Inflate(drawRectF, -3f, -3f), linearGradientBrush2);
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000AB65C File Offset: 0x000A985C
		public static void smethod_1(Graphics g, RectangleF drawRectF, Color drawColor, Orientation orientation)
		{
			Color color = ControlPaint.Light(drawColor);
			Color color2 = ControlPaint.Light(color);
			Color color3 = ControlPaint.Light(color2);
			ColorBlend colorBlend = new ColorBlend();
			colorBlend.Colors = new Color[]
			{
				drawColor,
				color,
				color2,
				color3
			};
			colorBlend.Positions = new float[]
			{
				0f,
				0.25f,
				0.65f,
				1f
			};
			using (LinearGradientBrush linearGradientBrush = (orientation == Orientation.Horizontal) ? new LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top), new Point((int)drawRectF.Left, (int)drawRectF.Top + (int)drawRectF.Height), drawColor, color3) : new LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top), new Point((int)drawRectF.Left + (int)drawRectF.Width, (int)drawRectF.Top), drawColor, color3))
			{
				linearGradientBrush.InterpolationColors = colorBlend;
				Class503.smethod_2(g, drawRectF, linearGradientBrush);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000AB794 File Offset: 0x000A9994
		public static void smethod_2(Graphics g, RectangleF rect, Brush b)
		{
			if (rect.Width > rect.Height)
			{
				g.FillEllipse(b, new RectangleF(rect.Left, rect.Top, rect.Height, rect.Height));
				g.FillEllipse(b, new RectangleF(rect.Left + rect.Width - rect.Height, rect.Top, rect.Height, rect.Height));
				float width = rect.Width - rect.Height;
				float x = rect.Left + rect.Height / 2f;
				g.FillRectangle(b, new RectangleF(x, rect.Top, width, rect.Height));
				return;
			}
			if (rect.Width < rect.Height)
			{
				g.FillEllipse(b, new RectangleF(rect.Left, rect.Top, rect.Width, rect.Width));
				g.FillEllipse(b, new RectangleF(rect.Left, rect.Top + rect.Height - rect.Width, rect.Width, rect.Width));
				float y = rect.Top + rect.Width / 2f;
				float height = rect.Height - rect.Width;
				g.FillRectangle(b, new RectangleF(rect.Left, y, rect.Width, height));
				return;
			}
			if (rect.Width == rect.Height)
			{
				g.FillEllipse(b, rect);
			}
		}
	}
}
