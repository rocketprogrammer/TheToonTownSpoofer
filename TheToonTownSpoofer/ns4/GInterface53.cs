using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x020000A2 RID: 162
	[Guid("88AFB4B2-140A-44D2-91E6-4543DA467CD1")]
	[TypeLibType(256)]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface53 : GInterface2
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006C7 RID: 1735
		// (set) Token: 0x060006C8 RID: 1736
		[DispId(1610678272)]
		string friendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006C9 RID: 1737
		[DispId(1610678274)]
		string deviceName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006CA RID: 1738
		[DispId(1610678275)]
		string deviceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006CB RID: 1739
		[DispId(1610678276)]
		int partnershipIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006CC RID: 1740
		[DispId(1610678277)]
		bool connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006CD RID: 1741
		[DispId(1610678278)]
		Enum1 status { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006CE RID: 1742
		[DispId(1610678279)]
		Enum2 syncState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006CF RID: 1743
		[DispId(1610678280)]
		int progress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006D0 RID: 1744
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_7([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060006D1 RID: 1745
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([In] bool vbShowUI);

		// Token: 0x060006D2 RID: 1746
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9();

		// Token: 0x060006D3 RID: 1747
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10();

		// Token: 0x060006D4 RID: 1748
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11();

		// Token: 0x060006D5 RID: 1749
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12();

		// Token: 0x060006D6 RID: 1750
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_13([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060006D7 RID: 1751
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);
	}
}
