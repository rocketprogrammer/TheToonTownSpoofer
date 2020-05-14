using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000E1 RID: 225
	[Guid("5D0AD945-289E-45C5-A9C6-F301F0152108")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface96
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000C2E RID: 3118
		// (set) Token: 0x06000C2F RID: 3119
		[DispId(6201)]
		string backgroundColor { [DispId(6201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000C30 RID: 3120
		// (set) Token: 0x06000C31 RID: 3121
		[DispId(6202)]
		string objectID { [DispId(6202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000C32 RID: 3122
		[DispId(6203)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000C33 RID: 3123
		[DispId(6204)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.Struct)] [In] object newVal);
	}
}
