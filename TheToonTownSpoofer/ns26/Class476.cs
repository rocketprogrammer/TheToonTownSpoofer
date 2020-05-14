using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ns18;

namespace ns26
{
	// Token: 0x02000471 RID: 1137
	internal static class Class476
	{
		// Token: 0x06002A18 RID: 10776 RVA: 0x000A1BE4 File Offset: 0x0009FDE4
		public static GraphicsPath smethod_0(Rectangle rect, int radius, Enum48 corners)
		{
			int num = rect.X + rect.Width;
			int num2 = rect.Y + rect.Height;
			int num3 = num - radius;
			int num4 = num2 - radius;
			int num5 = rect.X + radius;
			int num6 = rect.Y + radius;
			int num7 = radius * 2;
			int x = num - num7;
			int y = num2 - num7;
			GraphicsPath graphicsPath = null;
			GraphicsPath result;
			try
			{
				graphicsPath = new GraphicsPath();
				graphicsPath.StartFigure();
				if (corners.HasFlag(Enum48.flag_1))
				{
					graphicsPath.AddArc(rect.X, rect.Y, num7, num7, 180f, 90f);
				}
				else
				{
					graphicsPath.AddLine(rect.X, num6, rect.X, rect.Y);
					graphicsPath.AddLine(rect.X, rect.Y, num5, rect.Y);
				}
				graphicsPath.AddLine(num5, rect.Y, num3, rect.Y);
				if (corners.HasFlag(Enum48.flag_2))
				{
					graphicsPath.AddArc(x, rect.Y, num7, num7, 270f, 90f);
				}
				else
				{
					graphicsPath.AddLine(num3, rect.Y, num, rect.Y);
					graphicsPath.AddLine(num, rect.Y, num, num6);
				}
				graphicsPath.AddLine(num, num6, num, num4);
				if (corners.HasFlag(Enum48.flag_4))
				{
					graphicsPath.AddArc(x, y, num7, num7, 0f, 90f);
				}
				else
				{
					graphicsPath.AddLine(num, num4, num, num2);
					graphicsPath.AddLine(num, num2, num3, num2);
				}
				graphicsPath.AddLine(num3, num2, num5, num2);
				if (corners.HasFlag(Enum48.flag_3))
				{
					graphicsPath.AddArc(rect.X, y, num7, num7, 90f, 90f);
				}
				else
				{
					graphicsPath.AddLine(num5, num2, rect.X, num2);
					graphicsPath.AddLine(rect.X, num2, rect.X, num4);
				}
				graphicsPath.AddLine(rect.X, num4, rect.X, num6);
				graphicsPath.CloseFigure();
				result = graphicsPath;
			}
			catch
			{
				if (graphicsPath != null)
				{
					graphicsPath.Dispose();
				}
				throw;
			}
			return result;
		}
	}
}
