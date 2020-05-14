using System;
using ns23;
using ns30;
using ns31;
using TSN.Native.Enums;

namespace ns16
{
	// Token: 0x020003DA RID: 986
	internal static class Class398
	{
		// Token: 0x060025D6 RID: 9686 RVA: 0x00085D70 File Offset: 0x00083F70
		public static Enum22 smethod_0(this Win32Error errorCode)
		{
			if (((long)errorCode & 2147483648L) == 2147483648L)
			{
				return (Enum22)errorCode;
			}
			return (Enum22)((Win32Error)2147942400U | (errorCode & (Win32Error)65535U));
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00085DA8 File Offset: 0x00083FA8
		public unsafe static string smethod_1(this Win32Error errorCode)
		{
			Struct35 @struct = default(Struct35);
			if ((@struct.byte_0 = (byte)Class265.FormatMessage(12800, IntPtr.Zero, (int)errorCode, 0, new IntPtr((void*)(&@struct.struct36_0.char_0)), Struct35.int_0, IntPtr.Zero)) == 0)
			{
				return string.Format("Unknown error (0x{0:x})", (int)errorCode);
			}
			Struct35 struct2 = default(Struct35);
			for (int i = 0; i < (int)@struct.byte_0; i++)
			{
				char c = (&@struct.struct36_0.char_0)[i];
				if (!char.IsLetterOrDigit(c) && !char.IsPunctuation(c) && !char.IsSymbol(c) && !char.IsWhiteSpace(c))
				{
					break;
				}
				struct2.method_0(c);
			}
			return struct2.ToString().Replace("\r\n", "");
		}
	}
}
