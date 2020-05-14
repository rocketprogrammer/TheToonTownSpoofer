using System;
using System.Drawing;
using ns20;

namespace ns26
{
	// Token: 0x02000460 RID: 1120
	internal struct Struct46
	{
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0009FBC4 File Offset: 0x0009DDC4
		public bool IsEmpty
		{
			get
			{
				return this.double_0 == 0.0 && this.double_1 == 0.0 && this.double_2 == 0.0 && this.double_3 == 0.0;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0001343B File Offset: 0x0001163B
		public bool IsSizeEmpty
		{
			get
			{
				return this.double_2 == 0.0 || this.double_3 == 0.0;
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00013461 File Offset: 0x00011661
		public Struct46(double width, double height)
		{
			this = new Struct46(0.0, 0.0, width, height);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0001347D File Offset: 0x0001167D
		public Struct46(double x, double y, double width, double height)
		{
			this.double_0 = x;
			this.double_1 = y;
			this.double_2 = width;
			this.double_3 = height;
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0001349C File Offset: 0x0001169C
		public Rectangle method_0(Size max_size)
		{
			return this.method_1(new Rectangle(Point.Empty, max_size));
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0009FC18 File Offset: 0x0009DE18
		public Rectangle method_1(Rectangle max_bounds)
		{
			max_bounds = max_bounds.smethod_24();
			int num = max_bounds.Right - max_bounds.Left;
			int num2 = max_bounds.Bottom - max_bounds.Top;
			return new Rectangle((int)(this.double_0 * (double)num + (double)max_bounds.X), (int)(this.double_1 * (double)num2 + (double)max_bounds.Y), (int)(this.double_2 * (double)num), (int)(this.double_3 * (double)num2));
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0009FC8C File Offset: 0x0009DE8C
		public static bool smethod_0(Struct46 left, Struct46 right)
		{
			return left.double_0 == right.double_0 && left.double_1 == right.double_1 && left.double_2 == right.double_2 && left.double_3 == right.double_3;
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000134AF File Offset: 0x000116AF
		public static bool smethod_1(Struct46 left, Struct46 right)
		{
			return !Struct46.smethod_0(left, right);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0009FCDC File Offset: 0x0009DEDC
		public override int GetHashCode()
		{
			return (int)((uint)this.double_0 ^ ((uint)this.double_1 << 13 | (uint)this.double_1 >> 19) ^ ((uint)this.double_2 << 26 | (uint)this.double_2 >> 6) ^ ((uint)this.double_3 << 7 | (uint)this.double_3 >> 25));
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0009FD30 File Offset: 0x0009DF30
		public override bool Equals(object obj)
		{
			if (!(obj is Struct46))
			{
				return false;
			}
			Struct46 @struct = (Struct46)obj;
			return @struct.double_0 == this.double_0 && @struct.double_1 == this.double_1 && @struct.double_2 == this.double_2 && @struct.double_3 == this.double_3;
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000134BB File Offset: 0x000116BB
		public static Struct46 smethod_2(Rectangle bounds, Size size)
		{
			return Struct46.smethod_3(bounds, new Rectangle(Point.Empty, size));
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0009FD8C File Offset: 0x0009DF8C
		public static Struct46 smethod_3(Rectangle bounds, Rectangle max_bounds)
		{
			bounds = bounds.smethod_1(max_bounds);
			double x;
			double width;
			if ((double)max_bounds.Width > 0.0)
			{
				x = (double)bounds.X / (double)max_bounds.Width;
				width = (double)bounds.Width / (double)max_bounds.Width;
			}
			else
			{
				double num = 0.0;
				x = (double)0f;
				width = num;
			}
			double y;
			double height;
			if ((double)max_bounds.Height > 0.0)
			{
				y = (double)bounds.Y / (double)max_bounds.Height;
				height = (double)bounds.Height / (double)max_bounds.Height;
			}
			else
			{
				double num2 = 0.0;
				y = (double)0f;
				height = num2;
			}
			return new Struct46(x, y, width, height);
		}

		// Token: 0x040015E2 RID: 5602
		public static readonly Struct46 struct46_0 = new Struct46(0.0, 0.0, 0.0, 0.0);

		// Token: 0x040015E3 RID: 5603
		public readonly double double_0;

		// Token: 0x040015E4 RID: 5604
		public readonly double double_1;

		// Token: 0x040015E5 RID: 5605
		public readonly double double_2;

		// Token: 0x040015E6 RID: 5606
		public readonly double double_3;
	}
}
