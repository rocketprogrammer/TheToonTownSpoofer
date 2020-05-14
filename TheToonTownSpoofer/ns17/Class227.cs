using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace ns17
{
	// Token: 0x0200028D RID: 653
	internal static class Class227
	{
		// Token: 0x06001B06 RID: 6918 RVA: 0x000519C0 File Offset: 0x0004FBC0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int smethod_0(int min)
		{
			if (min < 0)
			{
				throw new ArgumentException("Capacity Overflow");
			}
			for (int i = 0; i < Class227.int_0.Length; i++)
			{
				int num = Class227.int_0[i];
				if (num >= min)
				{
					return num;
				}
			}
			for (int j = min | 1; j < 2147483647; j += 2)
			{
				if (Class227.smethod_1(j))
				{
					return j;
				}
			}
			return min;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00051A1C File Offset: 0x0004FC1C
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool smethod_1(int candidate)
		{
			if ((candidate & 1) == 0)
			{
				return candidate == 2;
			}
			int num = (int)Math.Sqrt((double)candidate);
			for (int i = 3; i <= num; i += 2)
			{
				if (candidate % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00051A50 File Offset: 0x0004FC50
		public static int smethod_2(int coprime_a, int coprime_b, params object[] objects)
		{
			int num = coprime_b;
			foreach (object obj in objects)
			{
				num = num * coprime_a + obj.GetHashCode();
			}
			return num;
		}

		// Token: 0x0400088D RID: 2189
		public static readonly int[] int_0 = new int[]
		{
			3,
			7,
			11,
			17,
			23,
			29,
			37,
			47,
			59,
			71,
			89,
			107,
			131,
			163,
			197,
			239,
			293,
			353,
			431,
			521,
			631,
			761,
			919,
			1103,
			1327,
			1597,
			1931,
			2333,
			2801,
			3371,
			4049,
			4861,
			5839,
			7013,
			8419,
			10103,
			12143,
			14591,
			17519,
			21023,
			25229,
			30293,
			36353,
			43627,
			52361,
			62851,
			75431,
			90523,
			108631,
			130363,
			156437,
			187751,
			225307,
			270371,
			324449,
			389357,
			467237,
			560689,
			672827,
			807403,
			968897,
			1162687,
			1395263,
			1674319,
			2009191,
			2411033,
			2893249,
			3471899,
			4166287,
			4999559,
			5999471,
			7199369
		};
	}
}
