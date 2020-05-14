using System;
using System.Drawing;
using ns31;

namespace ns19
{
	// Token: 0x020003FD RID: 1021
	internal struct Struct41
	{
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00011698 File Offset: 0x0000F898
		public bool IsEmpty
		{
			get
			{
				return this.double_0 == 0.0 && this.double_1 == 0.0;
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000116BE File Offset: 0x0000F8BE
		public Struct41(double width, double height)
		{
			this.double_0 = width;
			this.double_1 = height;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000116CE File Offset: 0x0000F8CE
		public Size method_0(Size max_size)
		{
			return new Size((int)(this.double_0 * (double)max_size.Width), (int)(this.double_1 * (double)max_size.Height));
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000116F5 File Offset: 0x0000F8F5
		public static bool smethod_0(Struct41 left, Struct41 right)
		{
			return left.double_0 == right.double_0 && left.double_1 == right.double_1;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00011719 File Offset: 0x0000F919
		public static bool smethod_1(Struct41 left, Struct41 right)
		{
			return !Struct41.smethod_0(left, right);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00011725 File Offset: 0x0000F925
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x0008C3E4 File Offset: 0x0008A5E4
		public override bool Equals(object obj)
		{
			if (!(obj is Struct41))
			{
				return false;
			}
			Struct41 @struct = (Struct41)obj;
			return @struct.double_0 == this.double_0 && @struct.double_1 == this.double_1;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x0008C424 File Offset: 0x0008A624
		public static Struct41 smethod_2(Size bounds, Size max_bounds)
		{
			bounds = bounds.smethod_0(max_bounds);
			double width;
			if ((double)max_bounds.Width > 0.0)
			{
				width = (double)bounds.Width / (double)max_bounds.Width;
			}
			else
			{
				width = 0.0;
			}
			double height;
			if ((double)max_bounds.Height > 0.0)
			{
				height = (double)bounds.Height / (double)max_bounds.Height;
			}
			else
			{
				height = 0.0;
			}
			return new Struct41(width, height);
		}

		// Token: 0x04001331 RID: 4913
		public static readonly Struct41 struct41_0 = new Struct41(0.0, 0.0);

		// Token: 0x04001332 RID: 4914
		public readonly double double_0;

		// Token: 0x04001333 RID: 4915
		public readonly double double_1;
	}
}
