using System;
using System.Drawing;
using ns23;

namespace ns20
{
	// Token: 0x0200042B RID: 1067
	internal struct Struct42
	{
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x00012577 File Offset: 0x00010777
		public bool IsEmpty
		{
			get
			{
				return this.double_0 == 0.0 && this.double_1 == 0.0;
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0001259D File Offset: 0x0001079D
		public Struct42(double width, double height)
		{
			this.double_0 = width;
			this.double_1 = height;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000125AD File Offset: 0x000107AD
		public Point method_0(Point max_point)
		{
			return new Point((int)(this.double_0 * (double)max_point.X), (int)(this.double_1 * (double)max_point.Y));
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000125D4 File Offset: 0x000107D4
		public static bool smethod_0(Struct42 left, Struct42 right)
		{
			return left.double_0 == right.double_0 && left.double_1 == right.double_1;
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000125F8 File Offset: 0x000107F8
		public static bool smethod_1(Struct42 left, Struct42 right)
		{
			return !Struct42.smethod_0(left, right);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00012604 File Offset: 0x00010804
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00098E28 File Offset: 0x00097028
		public override bool Equals(object obj)
		{
			if (!(obj is Struct42))
			{
				return false;
			}
			Struct42 @struct = (Struct42)obj;
			return @struct.double_0 == this.double_0 && @struct.double_1 == this.double_1;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00098E68 File Offset: 0x00097068
		public static Struct42 smethod_2(Point bounds, Point max_bounds)
		{
			bounds = bounds.smethod_0(max_bounds);
			double width;
			if ((double)max_bounds.X > 0.0)
			{
				width = (double)bounds.X / (double)max_bounds.X;
			}
			else
			{
				width = 0.0;
			}
			double height;
			if ((double)max_bounds.Y > 0.0)
			{
				height = (double)bounds.Y / (double)max_bounds.Y;
			}
			else
			{
				height = 0.0;
			}
			return new Struct42(width, height);
		}

		// Token: 0x04001493 RID: 5267
		public static readonly Struct42 struct42_0 = new Struct42(0.0, 0.0);

		// Token: 0x04001494 RID: 5268
		public readonly double double_0;

		// Token: 0x04001495 RID: 5269
		public readonly double double_1;
	}
}
