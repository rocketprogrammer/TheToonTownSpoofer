using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ns29
{
	// Token: 0x020004DB RID: 1243
	internal static class Class528
	{
		// Token: 0x06002E2E RID: 11822 RVA: 0x000B0D34 File Offset: 0x000AEF34
		public static void smethod_0(Point[] pnts, GraphicsPath gp, Point hs)
		{
			gp.Reset();
			gp.StartFigure();
			for (int i = 0; i < pnts.Length - 1; i++)
			{
				gp.AddLine(hs.X + pnts[i].X, hs.Y + pnts[i].Y, hs.X + pnts[i + 1].X, hs.Y + pnts[i + 1].Y);
			}
			gp.CloseFigure();
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000B0DC0 File Offset: 0x000AEFC0
		public static void smethod_1(int degrees, Point[] points)
		{
			degrees %= 360;
			double num = 0.017453292519943295 * (double)degrees;
			double num2 = Math.Cos(num);
			double num3 = Math.Sin(num);
			for (int i = 0; i < 8; i++)
			{
				int x = points[i].X;
				int y = points[i].Y;
				double num4 = (double)x * num2 - (double)y * num3;
				double num5 = (double)y * num2 + (double)x * num3;
				points[i].X = (int)num4;
				points[i].Y = (int)num5;
			}
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000B0E54 File Offset: 0x000AF054
		public static void smethod_2(int dx, int m_nRotDeg, ref Point m_CntPnt, Point[] m_pnts)
		{
			if (m_nRotDeg >= 0 && m_nRotDeg <= 90)
			{
				int num = m_pnts[1].Y - dx / 2;
				if (num > 0)
				{
					m_CntPnt.Y -= num;
				}
				int num2 = m_pnts[0].X + dx / 2;
				if (num2 < 0)
				{
					m_CntPnt.X -= num2;
				}
			}
			if (m_nRotDeg >= 91 && m_nRotDeg <= 180)
			{
				int num3 = m_pnts[0].Y - dx / 2;
				if (num3 > 0)
				{
					m_CntPnt.Y += num3;
				}
				int num4 = m_pnts[1].X + dx / 2;
				if (num4 < 0)
				{
					m_CntPnt.X -= num4;
				}
			}
			if (m_nRotDeg >= 181 && m_nRotDeg <= 270)
			{
				int num5 = m_pnts[1].Y + dx / 2;
				if (num5 < 0)
				{
					m_CntPnt.Y -= num5;
				}
				int num6 = m_pnts[1].X + dx / 2;
				if (num6 < 0)
				{
					m_CntPnt.X -= num6;
				}
			}
			if (m_nRotDeg >= 271 && m_nRotDeg <= 360)
			{
				int num7 = m_pnts[0].Y - dx / 2;
				if (num7 > 0)
				{
					m_CntPnt.Y += num7;
				}
				int num8 = m_pnts[1].X - dx / 2;
				if (num8 > 0)
				{
					m_CntPnt.X -= num8;
				}
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000B0FBC File Offset: 0x000AF1BC
		public static void smethod_3(int dx, out Point[] points)
		{
			points = new Point[8];
			points[0] = new Point(-dx / 4, dx / 2);
			points[1] = new Point(dx / 4, dx / 2);
			points[2] = new Point(dx / 4, 0);
			points[3] = new Point(dx / 2, 0);
			points[4] = new Point(0, -dx / 2);
			points[5] = new Point(-dx / 2, 0);
			points[6] = new Point(-dx / 4, 0);
			points[7] = new Point(-dx / 4, dx / 2);
		}
	}
}
