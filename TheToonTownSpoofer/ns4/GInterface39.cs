using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns3;

namespace ns4
{
	// Token: 0x02000094 RID: 148
	[TypeLibType(4160)]
	[Guid("FDA937A4-EECE-4DA5-A0B6-39BF89ADE2C2")]
	[ComImport]
	public interface GInterface39 : GInterface19
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600064B RID: 1611
		[DispId(113)]
		bool isAvailable { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600064C RID: 1612
		// (set) Token: 0x0600064D RID: 1613
		[DispId(101)]
		bool autoStart { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600064E RID: 1614
		// (set) Token: 0x0600064F RID: 1615
		[DispId(108)]
		string baseURL { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000650 RID: 1616
		// (set) Token: 0x06000651 RID: 1617
		[DispId(109)]
		string defaultFrame { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000652 RID: 1618
		// (set) Token: 0x06000653 RID: 1619
		[DispId(103)]
		bool invokeURLs { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000654 RID: 1620
		// (set) Token: 0x06000655 RID: 1621
		[DispId(104)]
		bool mute { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000656 RID: 1622
		// (set) Token: 0x06000657 RID: 1623
		[DispId(105)]
		int playCount { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000658 RID: 1624
		// (set) Token: 0x06000659 RID: 1625
		[DispId(106)]
		double rate { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600065A RID: 1626
		// (set) Token: 0x0600065B RID: 1627
		[DispId(102)]
		int balance { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600065C RID: 1628
		// (set) Token: 0x0600065D RID: 1629
		[DispId(107)]
		int volume { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600065E RID: 1630
		[DispId(110)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x0600065F RID: 1631
		[DispId(111)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000660 RID: 1632
		// (set) Token: 0x06000661 RID: 1633
		[DispId(112)]
		bool enableErrorDialogs { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000662 RID: 1634
		[DispId(114)]
		int defaultAudioLanguage { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000663 RID: 1635
		[DispId(115)]
		string mediaAccessRights { [DispId(115)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000664 RID: 1636
		[DispId(116)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_55([MarshalAs(UnmanagedType.BStr)] [In] string bstrDesiredAccess);
	}
}
