using System;
using System.Runtime.InteropServices;
using ns26;
using ns28;

namespace ns30
{
	// Token: 0x020001F3 RID: 499
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct15
	{
		// Token: 0x040003AC RID: 940
		public uint uint_0;

		// Token: 0x040003AD RID: 941
		public uint uint_1;

		// Token: 0x040003AE RID: 942
		public uint uint_2;

		// Token: 0x040003AF RID: 943
		public uint uint_3;

		// Token: 0x040003B0 RID: 944
		public Enum113 enum113_0;

		// Token: 0x040003B1 RID: 945
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		// Token: 0x040003B2 RID: 946
		public ushort ushort_0;

		// Token: 0x040003B3 RID: 947
		public ushort ushort_1;

		// Token: 0x040003B4 RID: 948
		public Enum112 enum112_0;

		// Token: 0x040003B5 RID: 949
		public Enum128 enum128_0;

		// Token: 0x040003B6 RID: 950
		public byte byte_0;
	}
}
