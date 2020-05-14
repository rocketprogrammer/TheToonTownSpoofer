using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns30
{
	// Token: 0x020001F2 RID: 498
	internal sealed class Class124 : Class123
	{
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00006931 File Offset: 0x00004B31
		public static Class124 Instance
		{
			get
			{
				return Class124.lazy_0.Value;
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0000693D File Offset: 0x00004B3D
		public Class124()
		{
			this.rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00036688 File Offset: 0x00034888
		public int method_4()
		{
			byte[] array = new byte[4];
			this.rngcryptoServiceProvider_0.GetBytes(array);
			return BitConverter.ToInt32(array, 0) & int.MaxValue;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00006950 File Offset: 0x00004B50
		[DebuggerStepThrough]
		public int method_5(int maxValue)
		{
			return this.method_6(0, maxValue);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000366B8 File Offset: 0x000348B8
		[DebuggerStepThrough]
		public int method_6(int minValue, int maxValue)
		{
			if (maxValue < minValue)
			{
				throw new ArgumentException("Max should be greater than or equal to min.");
			}
			if (minValue < 0)
			{
				throw new ArgumentOutOfRangeException("minValue", minValue, "Value must be positive.");
			}
			if (maxValue < 0)
			{
				throw new ArgumentOutOfRangeException("maxValue", maxValue, "Value must be positive.");
			}
			if (maxValue == minValue)
			{
				return minValue;
			}
			long num = (long)(maxValue - minValue);
			uint num2;
			long num3;
			do
			{
				byte[] array = new byte[4];
				this.rngcryptoServiceProvider_0.GetBytes(array);
				num2 = BitConverter.ToUInt32(array, 0);
				num3 = 4294967296L % num;
			}
			while ((ulong)num2 >= (ulong)(4294967296L - num3));
			return (int)((long)minValue + (long)((ulong)num2 % (ulong)num));
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000695A File Offset: 0x00004B5A
		[DebuggerStepThrough]
		public void method_7(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			this.rngcryptoServiceProvider_0.GetBytes(buffer);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00036754 File Offset: 0x00034954
		[DebuggerStepThrough]
		public double method_8()
		{
			byte[] array = new byte[4];
			this.rngcryptoServiceProvider_0.GetBytes(array);
			uint num = BitConverter.ToUInt32(array, 0);
			return num / 4294967296.0;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00006976 File Offset: 0x00004B76
		protected override void vmethod_0()
		{
			this.rngcryptoServiceProvider_0.Dispose();
			base.vmethod_0();
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00006989 File Offset: 0x00004B89
		// Note: this type is marked as 'beforefieldinit'.
		static Class124()
		{
			if (Class124.func_0 == null)
			{
				Class124.func_0 = new Func<Class124>(Class124.smethod_0);
			}
			Class124.lazy_0 = new Lazy<Class124>(Class124.func_0);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000069B2 File Offset: 0x00004BB2
		[CompilerGenerated]
		private static Class124 smethod_0()
		{
			return new Class124();
		}

		// Token: 0x040003A9 RID: 937
		private static readonly Lazy<Class124> lazy_0;

		// Token: 0x040003AA RID: 938
		private RNGCryptoServiceProvider rngcryptoServiceProvider_0;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private static Func<Class124> func_0;
	}
}
