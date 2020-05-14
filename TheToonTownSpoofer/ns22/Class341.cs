using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ns22
{
	// Token: 0x02000377 RID: 887
	internal static class Class341
	{
		// Token: 0x060022D9 RID: 8921 RVA: 0x000764E0 File Offset: 0x000746E0
		public static GraphicsPath smethod_0(Rectangle rec)
		{
			GraphicsPath graphicsPath = null;
			GraphicsPath result;
			try
			{
				graphicsPath = new GraphicsPath();
				graphicsPath.StartFigure();
				graphicsPath.AddEllipse(rec);
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
