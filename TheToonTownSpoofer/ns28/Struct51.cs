using System;

namespace ns28
{
	// Token: 0x0200049C RID: 1180
	internal struct Struct51
	{
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x0001470E File Offset: 0x0001290E
		public bool IsEmpty
		{
			get
			{
				return this.double_0 == 0.0;
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x00014721 File Offset: 0x00012921
		public Struct51(double value)
		{
			this.double_0 = value;
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0001472A File Offset: 0x0001292A
		public int method_0(int max_value)
		{
			return (int)(this.double_0 * (double)max_value);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00014736 File Offset: 0x00012936
		public static bool smethod_0(Struct51 left, Struct51 right)
		{
			return left.double_0 == right.double_0;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00014748 File Offset: 0x00012948
		public static bool smethod_1(Struct51 left, Struct51 right)
		{
			return !Struct51.smethod_0(left, right);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00014754 File Offset: 0x00012954
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000AAAE8 File Offset: 0x000A8CE8
		public override bool Equals(object obj)
		{
			return obj is Struct51 && ((Struct51)obj).double_0 == this.double_0;
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000AAB18 File Offset: 0x000A8D18
		public static Struct51 smethod_2(int value, int max_value)
		{
			if (value > max_value)
			{
				value = max_value;
			}
			double value2;
			if ((double)max_value > 0.0)
			{
				value2 = (double)value / (double)max_value;
			}
			else
			{
				value2 = 0.0;
			}
			return new Struct51(value2);
		}

		// Token: 0x0400172F RID: 5935
		public static readonly Struct51 struct51_0 = new Struct51(0.0);

		// Token: 0x04001730 RID: 5936
		public readonly double double_0;
	}
}
