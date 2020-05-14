using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x020000A3 RID: 163
	[TypeLibType(256)]
	[InterfaceType(1)]
	[Guid("B22C85F9-263C-4372-A0DA-B518DB9B4098")]
	[ComImport]
	public interface GInterface54 : GInterface53
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006D8 RID: 1752
		// (set) Token: 0x060006D9 RID: 1753
		[DispId(1610678272)]
		string friendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006DA RID: 1754
		[DispId(1610678274)]
		string deviceName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006DB RID: 1755
		[DispId(1610678275)]
		string deviceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006DC RID: 1756
		[DispId(1610678276)]
		int partnershipIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006DD RID: 1757
		[DispId(1610678277)]
		bool connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006DE RID: 1758
		[DispId(1610678278)]
		Enum1 status { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006DF RID: 1759
		[DispId(1610678279)]
		Enum2 syncState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006E0 RID: 1760
		[DispId(1610678280)]
		int progress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006E1 RID: 1761
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060006E2 RID: 1762
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([In] bool vbShowUI);

		// Token: 0x060006E3 RID: 1763
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_17();

		// Token: 0x060006E4 RID: 1764
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_18();

		// Token: 0x060006E5 RID: 1765
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_19();

		// Token: 0x060006E6 RID: 1766
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_20();

		// Token: 0x060006E7 RID: 1767
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_21([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060006E8 RID: 1768
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_22([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x060006E9 RID: 1769
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_23([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pNonRulePlaylist, [MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pRulesPlaylist);

		// Token: 0x060006EA RID: 1770
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_24();
	}
}
