using System;
using System.Diagnostics;
using ns21;

namespace ns20
{
	// Token: 0x0200042D RID: 1069
	internal struct Struct43 : IComparable<Struct43>, IEquatable<Struct43>, IComparable
	{
		// Token: 0x0600288B RID: 10379 RVA: 0x00099214 File Offset: 0x00097414
		[DebuggerStepThrough]
		public Struct43(string hash)
		{
			if (string.IsNullOrEmpty(hash))
			{
				throw new NullReferenceException("hash");
			}
			hash = hash.Replace("-", "").ToLower();
			if (!hash.smethod_13())
			{
				throw new ArgumentException(string.Format("The specified hash value is invalid: '{0}'.", hash), "hash");
			}
			Struct43.smethod_0(hash, out this.uint_0, out this.uint_1, out this.uint_2, out this.uint_3);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00012869 File Offset: 0x00010A69
		[DebuggerStepThrough]
		public Struct43(uint val0, uint val1, uint val2, uint val3)
		{
			this.uint_0 = val0;
			this.uint_1 = val1;
			this.uint_2 = val2;
			this.uint_3 = val3;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00099288 File Offset: 0x00097488
		[DebuggerStepThrough]
		public Struct43(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (bytes.Length != 16)
			{
				throw new ArgumentException(string.Format("Invalid number of bytes: '{0}'.", bytes.Length), "bytes");
			}
			this.uint_0 = BitConverter.ToUInt32(bytes, 0);
			this.uint_1 = BitConverter.ToUInt32(bytes, 4);
			this.uint_2 = BitConverter.ToUInt32(bytes, 8);
			this.uint_3 = BitConverter.ToUInt32(bytes, 12);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000992FC File Offset: 0x000974FC
		[DebuggerStepThrough]
		public byte[] method_0()
		{
			byte[] array = new byte[16];
			BitConverter.GetBytes(this.uint_0).CopyTo(array, 0);
			BitConverter.GetBytes(this.uint_1).CopyTo(array, 4);
			BitConverter.GetBytes(this.uint_2).CopyTo(array, 8);
			BitConverter.GetBytes(this.uint_3).CopyTo(array, 12);
			return array;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0009935C File Offset: 0x0009755C
		[DebuggerStepThrough]
		public override string ToString()
		{
			char[] value = new char[32];
			Struct43.smethod_2(this.uint_0, ref value, 0);
			Struct43.smethod_2(this.uint_1, ref value, 8);
			Struct43.smethod_2(this.uint_2, ref value, 16);
			Struct43.smethod_2(this.uint_3, ref value, 24);
			return new string(value);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000993B4 File Offset: 0x000975B4
		[DebuggerStepThrough]
		public static void smethod_0(string hash, out uint val0, out uint val1, out uint val2, out uint val3)
		{
			char[] array = hash.ToCharArray();
			Struct43.smethod_1(ref array, 0, out val0);
			Struct43.smethod_1(ref array, 8, out val1);
			Struct43.smethod_1(ref array, 16, out val2);
			Struct43.smethod_1(ref array, 24, out val3);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000993F0 File Offset: 0x000975F0
		[DebuggerStepThrough]
		private static void smethod_1(ref char[] hash, int hashIndex, out uint val)
		{
			val = (Struct43.smethod_4(hash[hashIndex]) << 28 | Struct43.smethod_4(hash[1 + hashIndex]) << 24 | Struct43.smethod_4(hash[2 + hashIndex]) << 20 | Struct43.smethod_4(hash[3 + hashIndex]) << 16 | Struct43.smethod_4(hash[4 + hashIndex]) << 12 | Struct43.smethod_4(hash[5 + hashIndex]) << 8 | Struct43.smethod_4(hash[6 + hashIndex]) << 4 | Struct43.smethod_4(hash[7 + hashIndex]));
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00099470 File Offset: 0x00097670
		[DebuggerStepThrough]
		private static void smethod_2(uint number, ref char[] Result, int ResultIndex)
		{
			Result[ResultIndex] = Struct43.smethod_3(number >> 28);
			Result[1 + ResultIndex] = Struct43.smethod_3(number >> 24);
			Result[2 + ResultIndex] = Struct43.smethod_3(number >> 20);
			Result[3 + ResultIndex] = Struct43.smethod_3(number >> 16);
			Result[4 + ResultIndex] = Struct43.smethod_3(number >> 12);
			Result[5 + ResultIndex] = Struct43.smethod_3(number >> 8);
			Result[6 + ResultIndex] = Struct43.smethod_3(number >> 4);
			Result[7 + ResultIndex] = Struct43.smethod_3(number);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00012888 File Offset: 0x00010A88
		[DebuggerStepThrough]
		private static char smethod_3(uint value)
		{
			value &= 15U;
			if (value < 10U)
			{
				return (char)(value + 48U);
			}
			return (char)(value - 10U + 97U);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000128A3 File Offset: 0x00010AA3
		[DebuggerStepThrough]
		private static uint smethod_4(char digit)
		{
			if (char.IsDigit(digit))
			{
				return (uint)(digit - '0');
			}
			return (uint)(char.ToLower(digit) - 'a' + '\n');
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000994F0 File Offset: 0x000976F0
		[DebuggerStepThrough]
		public override int GetHashCode()
		{
			int num = 925 + this.uint_0.GetHashCode();
			num = num * 37 + this.uint_1.GetHashCode();
			num = num * 37 + this.uint_2.GetHashCode();
			return num * 37 + this.uint_3.GetHashCode();
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000128BE File Offset: 0x00010ABE
		[DebuggerStepThrough]
		public static bool smethod_5(Struct43 val1, Struct43 val2)
		{
			return val1.Equals(val2);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000128C8 File Offset: 0x00010AC8
		[DebuggerStepThrough]
		public static bool smethod_6(Struct43 val1, Struct43 val2)
		{
			return !Struct43.smethod_5(val1, val2);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000128D4 File Offset: 0x00010AD4
		[DebuggerStepThrough]
		public int CompareTo(object obj)
		{
			if (!(obj is Struct43))
			{
				throw new ArgumentException("obj is not Hash");
			}
			return this.CompareTo((Struct43)obj);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00099548 File Offset: 0x00097748
		[DebuggerStepThrough]
		public int CompareTo(Struct43 other)
		{
			if (other.uint_0 != this.uint_0)
			{
				return Struct43.smethod_7(this.uint_0, other.uint_0);
			}
			if (other.uint_1 != this.uint_1)
			{
				return Struct43.smethod_7(this.uint_1, other.uint_1);
			}
			if (other.uint_2 != this.uint_2)
			{
				return Struct43.smethod_7(this.uint_2, other.uint_2);
			}
			if (other.uint_3 != this.uint_3)
			{
				return Struct43.smethod_7(this.uint_3, other.uint_3);
			}
			return 0;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000128F5 File Offset: 0x00010AF5
		[DebuggerStepThrough]
		private static int smethod_7(uint me, uint them)
		{
			if (me < them)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000128FE File Offset: 0x00010AFE
		[DebuggerStepThrough]
		public override bool Equals(object obj)
		{
			return this.Equals((Struct43)obj);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0001290C File Offset: 0x00010B0C
		[DebuggerStepThrough]
		public bool Equals(Struct43 other)
		{
			return this.uint_0 == other.uint_0 && this.uint_1 == other.uint_1 && this.uint_2 == other.uint_2 && this.uint_3 == other.uint_3;
		}

		// Token: 0x04001496 RID: 5270
		public static readonly Struct43 struct43_0 = new Struct43("00000000000000000000000000000000");

		// Token: 0x04001497 RID: 5271
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint uint_0;

		// Token: 0x04001498 RID: 5272
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint uint_1;

		// Token: 0x04001499 RID: 5273
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint uint_2;

		// Token: 0x0400149A RID: 5274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint uint_3;
	}
}
