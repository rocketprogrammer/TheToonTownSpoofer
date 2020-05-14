using System;
using System.Runtime.InteropServices;

namespace ns28
{
	// Token: 0x0200049F RID: 1183
	internal static class Class497
	{
		// Token: 0x06002BFA RID: 11258 RVA: 0x00014794 File Offset: 0x00012994
		public static int smethod_0(this IntPtr ptr, IntPtr ptr2)
		{
			if (ptr.smethod_17() > ptr2.smethod_17())
			{
				return 1;
			}
			if (ptr.smethod_17() < ptr2.smethod_17())
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000147B7 File Offset: 0x000129B7
		public static int smethod_1(this IntPtr ptr, int ptr2)
		{
			return ptr.smethod_2((uint)ptr2);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000147C0 File Offset: 0x000129C0
		public static int smethod_2(this IntPtr ptr, uint ptr2)
		{
			if (ptr.smethod_17() > (ulong)ptr2)
			{
				return 1;
			}
			if (ptr.smethod_17() < (ulong)ptr2)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000147DB File Offset: 0x000129DB
		public static IntPtr smethod_3(this IntPtr ptr, IntPtr ptr2)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() - ptr2.ToInt32());
			}
			return new IntPtr(ptr.ToInt64() - ptr2.ToInt64());
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0001480E File Offset: 0x00012A0E
		public static IntPtr smethod_4(this IntPtr ptr, int value)
		{
			return ptr.smethod_11(-value);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00014818 File Offset: 0x00012A18
		public static IntPtr smethod_5(this IntPtr ptr, long value)
		{
			return ptr.smethod_12(-value);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00014822 File Offset: 0x00012A22
		public static bool smethod_6(this IntPtr ptr, IntPtr ptr2)
		{
			return ptr == ptr2;
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x0001482B File Offset: 0x00012A2B
		public static bool smethod_7(this IntPtr ptr, int value)
		{
			return ptr.ToInt32() == value;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00014837 File Offset: 0x00012A37
		public static bool smethod_8(this IntPtr ptr, uint value)
		{
			return ptr.smethod_16() == value;
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00014842 File Offset: 0x00012A42
		public static bool smethod_9(this IntPtr ptr, long value)
		{
			return ptr.ToInt64() == value;
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0001484E File Offset: 0x00012A4E
		public static bool smethod_10(this IntPtr ptr, ulong value)
		{
			return ptr.smethod_17() == value;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00014859 File Offset: 0x00012A59
		public static IntPtr smethod_11(this IntPtr ptr, int value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() + value);
			}
			return new IntPtr(ptr.ToInt64() + (long)value);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00014881 File Offset: 0x00012A81
		public static IntPtr smethod_12(this IntPtr ptr, long value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr((int)((long)ptr.ToInt32() + value));
			}
			return new IntPtr(ptr.ToInt64() + value);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000148AA File Offset: 0x00012AAA
		public static IntPtr smethod_13(this IntPtr ptr, IntPtr ptr2)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() + ptr2.ToInt32());
			}
			return new IntPtr(ptr.ToInt64() + ptr2.ToInt64());
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000148DD File Offset: 0x00012ADD
		public static IntPtr smethod_14<T>(this IntPtr ptr)
		{
			return ptr.smethod_11(Marshal.SizeOf(typeof(T)));
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000AAB80 File Offset: 0x000A8D80
		public static T smethod_15<T>(this IntPtr ptr, int index)
		{
			int value = Marshal.SizeOf(typeof(T)) * index;
			IntPtr ptr2 = ptr.smethod_11(value);
			return (T)((object)Marshal.PtrToStructure(ptr2, typeof(T)));
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000AABBC File Offset: 0x000A8DBC
		public unsafe static uint smethod_16(this IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			return ptr2;
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000AABD4 File Offset: 0x000A8DD4
		public unsafe static ulong smethod_17(this IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			return ptr2;
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000148F4 File Offset: 0x00012AF4
		public static IntPtr smethod_18(this int value)
		{
			return new IntPtr(value);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000148F4 File Offset: 0x00012AF4
		public static IntPtr smethod_19(this uint value)
		{
			return new IntPtr((int)value);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000148FC File Offset: 0x00012AFC
		public static IntPtr smethod_20(this long value)
		{
			if (value > 0L && value <= 4294967295L)
			{
				return new IntPtr((int)value);
			}
			return new IntPtr(value);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00014924 File Offset: 0x00012B24
		public static IntPtr smethod_21(this ulong value)
		{
			return ((long)value).smethod_20();
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0001492C File Offset: 0x00012B2C
		public static bool smethod_22(this IntPtr ptr, IntPtr ptr2)
		{
			return ptr.smethod_0(ptr2) >= 0;
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0001493B File Offset: 0x00012B3B
		public static bool smethod_23(this IntPtr ptr, IntPtr ptr2)
		{
			return ptr.smethod_0(ptr2) <= 0;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0001494A File Offset: 0x00012B4A
		public static IntPtr smethod_24(this IntPtr ptr, int value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() & value);
			}
			return new IntPtr(ptr.ToInt64() & (long)value);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00014972 File Offset: 0x00012B72
		public static IntPtr smethod_25(this IntPtr ptr, IntPtr value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() & value.ToInt32());
			}
			return new IntPtr(ptr.ToInt64() & value.ToInt64());
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000149A5 File Offset: 0x00012BA5
		public static IntPtr smethod_26(this IntPtr ptr)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(~ptr.ToInt32());
			}
			return new IntPtr(~ptr.ToInt64());
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000149CA File Offset: 0x00012BCA
		public static IntPtr smethod_27(this IntPtr ptr, IntPtr value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() | value.ToInt32());
			}
			return new IntPtr(ptr.ToInt64() | value.ToInt64());
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000149FD File Offset: 0x00012BFD
		public static IntPtr smethod_28(this IntPtr ptr, IntPtr value)
		{
			if (IntPtr.Size == 4)
			{
				return new IntPtr(ptr.ToInt32() ^ value.ToInt32());
			}
			return new IntPtr(ptr.ToInt64() ^ value.ToInt64());
		}
	}
}
