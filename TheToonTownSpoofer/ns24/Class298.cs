using System;

namespace ns24
{
	// Token: 0x02000311 RID: 785
	internal sealed class Class298
	{
		// Token: 0x06001EA5 RID: 7845 RVA: 0x00064C34 File Offset: 0x00062E34
		public Class298(int x, int y, bool defaultValue)
		{
			if (x < 0)
			{
				throw new ArgumentOutOfRangeException("x", "Requires non-negative number.");
			}
			if (y < 0)
			{
				throw new ArgumentOutOfRangeException("y", "Requires non-negative number.");
			}
			this.int_0 = new int[Class298.smethod_0(x * y, 32)];
			this.int_1 = x;
			this.int_2 = y;
			int num = defaultValue ? -1 : 0;
			for (int i = 0; i < this.int_0.Length; i++)
			{
				this.int_0[i] = num;
			}
		}

		// Token: 0x1700081F RID: 2079
		public bool this[int x, int y]
		{
			get
			{
				return this.method_0(x, y);
			}
			set
			{
				this.method_2(x, y, value);
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00064CB8 File Offset: 0x00062EB8
		public bool method_0(int x, int y)
		{
			if (x < 0 || x >= this.int_1)
			{
				throw new ArgumentOutOfRangeException("x", string.Format("Value must be greater or equal to 0 and less then maximum: '{0}'", this.int_1));
			}
			if (y < 0 || y >= this.int_2)
			{
				throw new ArgumentOutOfRangeException("y", string.Format("Value must be greater or equal to 0 and less then maximum: '{0}'", this.int_1));
			}
			return this.method_1(x * this.int_1 + y);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0000BE3C File Offset: 0x0000A03C
		private bool method_1(int index)
		{
			return (this.int_0[index / 32] & 1 << index % 32) != 0;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00064D30 File Offset: 0x00062F30
		public void method_2(int x, int y, bool value)
		{
			if (x < 0 || x >= this.int_1)
			{
				throw new ArgumentOutOfRangeException("x", string.Format("Value must be greater or equal to 0 and less then maximum: '{0}'", this.int_1));
			}
			if (y < 0 || y >= this.int_2)
			{
				throw new ArgumentOutOfRangeException("y", string.Format("Value must be greater or equal to 0 and less then maximum: '{0}'", this.int_1));
			}
			this.method_3(x * this.int_1 + y, value);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00064DA8 File Offset: 0x00062FA8
		private void method_3(int index, bool value)
		{
			if (value)
			{
				this.int_0[index / 32] |= 1 << index % 32;
				return;
			}
			this.int_0[index / 32] &= ~(1 << index % 32);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0000BE59 File Offset: 0x0000A059
		private static int smethod_0(int n, int div)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / div + 1;
		}

		// Token: 0x04000BBF RID: 3007
		private int[] int_0;

		// Token: 0x04000BC0 RID: 3008
		private int int_1;

		// Token: 0x04000BC1 RID: 3009
		private int int_2;
	}
}
