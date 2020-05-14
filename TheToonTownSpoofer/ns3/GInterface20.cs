using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x02000081 RID: 129
	[Guid("10A13217-23A7-439B-B1C0-D847C79B7774")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface20
	{
		// Token: 0x06000560 RID: 1376
		[DispId(552)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_63([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000561 RID: 1377
		[DispId(553)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface21 imethod_0();

		// Token: 0x06000562 RID: 1378
		[DispId(554)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface21 imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000563 RID: 1379
		[DispId(556)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_64([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x06000564 RID: 1380
		[DispId(560)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_65([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem, [In] bool varfIsDeleted);

		// Token: 0x06000565 RID: 1381
		[DispId(561)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_66([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x06000566 RID: 1382
		[DispId(562)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_67([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);
	}
}
