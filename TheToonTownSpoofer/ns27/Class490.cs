using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ns27
{
	// Token: 0x02000492 RID: 1170
	internal sealed class Class490
	{
		// Token: 0x06002B88 RID: 11144 RVA: 0x000A9848 File Offset: 0x000A7A48
		public static Image smethod_0(string text, Font font, Color forecolor, Color glowColor, StringFormat sf, Size layout, int blurAmount = 6)
		{
			Bitmap bitmap = null;
			using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
			{
				SizeF size = graphics.MeasureString(text, font, layout, sf);
				using (Bitmap bitmap2 = new Bitmap((int)size.Width, (int)size.Height))
				{
					using (Graphics graphics2 = Graphics.FromImage(bitmap2))
					{
						using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(16, (int)glowColor.R, (int)glowColor.G, (int)glowColor.B)))
						{
							using (SolidBrush solidBrush2 = new SolidBrush(forecolor))
							{
								graphics2.SmoothingMode = SmoothingMode.HighQuality;
								graphics2.InterpolationMode = InterpolationMode.HighQualityBilinear;
								graphics2.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
								graphics2.DrawString(text, font, solidBrush, new RectangleF(PointF.Empty, size), sf);
								try
								{
									bitmap = new Bitmap(bitmap2.Width + blurAmount, bitmap2.Height + blurAmount);
									using (Graphics graphics3 = Graphics.FromImage(bitmap))
									{
										graphics3.SmoothingMode = SmoothingMode.AntiAlias;
										graphics3.InterpolationMode = InterpolationMode.HighQualityBilinear;
										graphics3.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
										for (int i = 0; i <= blurAmount; i++)
										{
											for (int j = 0; j <= blurAmount; j++)
											{
												graphics3.DrawImageUnscaled(bitmap2, i, j);
											}
										}
										graphics3.DrawString(text, font, solidBrush2, new RectangleF(new PointF((float)(blurAmount / 2), (float)(blurAmount / 2)), size), sf);
									}
								}
								catch
								{
									if (bitmap != null)
									{
										bitmap.Dispose();
									}
									bitmap = null;
									throw;
								}
							}
						}
					}
				}
			}
			return bitmap;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x000A9A84 File Offset: 0x000A7C84
		public static void smethod_1(Graphics gr, Font Font, string text, float outlineSize, RectangleF layout, Color textColor, Color borderColor, StringFormat sf)
		{
			gr.SmoothingMode = SmoothingMode.AntiAlias;
			gr.TextRenderingHint = TextRenderingHint.AntiAlias;
			float emSize = gr.DpiY * Font.SizeInPoints / 72f;
			if (outlineSize > 0f)
			{
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					graphicsPath.AddString(text, Font.FontFamily, 0, emSize, layout, sf);
					graphicsPath.Widen(Pens.Black);
					using (SolidBrush solidBrush = new SolidBrush(borderColor))
					{
						gr.FillPath(solidBrush, graphicsPath);
					}
				}
			}
			using (GraphicsPath graphicsPath2 = new GraphicsPath())
			{
				graphicsPath2.AddString(text, Font.FontFamily, 0, emSize, layout, sf);
				using (SolidBrush solidBrush2 = new SolidBrush(textColor))
				{
					gr.FillPath(solidBrush2, graphicsPath2);
				}
			}
		}
	}
}
