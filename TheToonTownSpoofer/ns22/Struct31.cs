using System;
using System.Runtime.InteropServices;
using ns23;
using ns31;
using TSN.Native.Enums;

namespace ns22
{
	// Token: 0x02000361 RID: 865
	internal struct Struct31 : IDisposable, IEquatable<Struct31>, IComparable<Struct31>, ICloneable
	{
		// Token: 0x06002217 RID: 8727 RVA: 0x000741C8 File Offset: 0x000723C8
		public Struct31(string str)
		{
			if (str == null)
			{
				this.ushort_0 = 0;
				this.ushort_1 = 0;
				this.intptr_0 = IntPtr.Zero;
				return;
			}
			Struct31 @struct;
			if (!Class265.RtlCreateUnicodeString(out @struct, str))
			{
				throw new OutOfMemoryException();
			}
			this = @struct;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0000E3EA File Offset: 0x0000C5EA
		public int method_0(Struct31 unicodeString, bool caseInsensitive)
		{
			return Class265.RtlCompareUnicodeString(ref this, ref unicodeString, caseInsensitive);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0000E3F5 File Offset: 0x0000C5F5
		public int CompareTo(Struct31 unicodeString)
		{
			return this.method_0(unicodeString, false);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0000E3FF File Offset: 0x0000C5FF
		public void Dispose()
		{
			if (this.intptr_0 == IntPtr.Zero)
			{
				return;
			}
			Class265.RtlFreeUnicodeString(ref this);
			this.intptr_0 = IntPtr.Zero;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0000E425 File Offset: 0x0000C625
		public object Clone()
		{
			return this.method_1();
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0007420C File Offset: 0x0007240C
		public Struct31 method_1()
		{
			Struct31 result;
			NtStatus status = Class265.RtlDuplicateUnicodeString(Enum80.flag_1 | Enum80.flag_2, ref this, out result);
			status.smethod_6();
			return result;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0000E432 File Offset: 0x0000C632
		public bool method_2(Struct31 unicodeString, bool caseInsensitive)
		{
			return Class265.RtlEqualUnicodeString(ref this, ref unicodeString, caseInsensitive);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0000E43D File Offset: 0x0000C63D
		public bool Equals(Struct31 unicodeString)
		{
			return this.method_2(unicodeString, false);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0000E447 File Offset: 0x0000C647
		public override int GetHashCode()
		{
			return this.method_5();
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0007422C File Offset: 0x0007242C
		public int method_3(Enum73 algorithm, bool caseInsensitive)
		{
			int result;
			NtStatus status = Class265.RtlHashUnicodeString(ref this, caseInsensitive, algorithm, out result);
			status.smethod_6();
			return result;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0000E44F File Offset: 0x0000C64F
		public int method_4(Enum73 algorithm)
		{
			return this.method_3(algorithm, false);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0000E459 File Offset: 0x0000C659
		public int method_5()
		{
			return this.method_4(Enum73.flag_0);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0000E462 File Offset: 0x0000C662
		public string method_6()
		{
			if (this.ushort_0 == 0)
			{
				return "";
			}
			return Marshal.PtrToStringUni(this.intptr_0, (int)(this.ushort_0 / 2));
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0000E485 File Offset: 0x0000C685
		public override string ToString()
		{
			return this.method_6();
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0000E48D File Offset: 0x0000C68D
		public bool method_7(Struct31 unicodeString, bool caseInsensitive)
		{
			return Class265.RtlPrefixUnicodeString(ref this, ref unicodeString, caseInsensitive);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0000E498 File Offset: 0x0000C698
		public bool method_8(Struct31 unicodeString)
		{
			return this.method_7(unicodeString, false);
		}

		// Token: 0x04000E1C RID: 3612
		public ushort ushort_0;

		// Token: 0x04000E1D RID: 3613
		public ushort ushort_1;

		// Token: 0x04000E1E RID: 3614
		internal IntPtr intptr_0;
	}
}
