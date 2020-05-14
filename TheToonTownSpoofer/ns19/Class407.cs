using System;
using System.Drawing;
using ns16;
using ns17;
using ns24;

namespace ns19
{
	// Token: 0x020003EB RID: 1003
	internal sealed class Class407 : Interface16
	{
		// Token: 0x06002652 RID: 9810 RVA: 0x000885E8 File Offset: 0x000867E8
		public void imethod_0(EventArgs34 e)
		{
			Rectangle bounds = e.Bounds;
			int num = bounds.Height / 7;
			bounds.Height /= 7;
			bounds.Width -= num + 2;
			bounds.X += bounds.Height / 2 + 1;
			Rectangle rect = new Rectangle(bounds.Right - num / 2, bounds.Y, num, num);
			Rectangle rect2 = new Rectangle(bounds.Left - num / 2, bounds.Y, bounds.Height, bounds.Height);
			using (SolidBrush solidBrush = new SolidBrush(Class294.color_0))
			{
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_1;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_2;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_3;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_4;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_5;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
				solidBrush.Color = Class294.color_6;
				rect2.Y = (rect.Y = (bounds.Y += bounds.Height));
				e.Graphics.FillRectangle(solidBrush, bounds);
				e.Graphics.FillEllipse(solidBrush, rect2);
				e.Graphics.FillEllipse(solidBrush, rect);
			}
		}
	}
}
