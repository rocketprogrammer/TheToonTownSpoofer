using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x020000A0 RID: 160
	[InterfaceType(1)]
	[TypeLibType(256)]
	[Guid("DD578A4E-79B1-426C-BF8F-3ADD9072500B")]
	[ComImport]
	public interface GInterface51 : GInterface8
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006B7 RID: 1719
		[DispId(1610678272)]
		string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006B8 RID: 1720
		[DispId(1610678273)]
		Enum6 type { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006B9 RID: 1721
		[DispId(1610678274)]
		GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060006BA RID: 1722
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_1([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pIWMPLibrary);

		// Token: 0x060006BB RID: 1723
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);
	}
}
