using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x02000095 RID: 149
	[TypeLibType(4160)]
	[Guid("A1D1110E-D545-476A-9A78-AC3E4CB1E6BD")]
	[ComImport]
	public interface GInterface40 : GInterface34
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000665 RID: 1637
		[DispId(62)]
		bool isAvailable { [DispId(62)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000666 RID: 1638
		[DispId(51)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8();

		// Token: 0x06000667 RID: 1639
		[DispId(52)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9();

		// Token: 0x06000668 RID: 1640
		[DispId(53)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10();

		// Token: 0x06000669 RID: 1641
		[DispId(54)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11();

		// Token: 0x0600066A RID: 1642
		[DispId(55)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12();

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600066B RID: 1643
		// (set) Token: 0x0600066C RID: 1644
		[DispId(56)]
		double currentPosition { [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600066D RID: 1645
		[DispId(57)]
		string currentPositionString { [DispId(57)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600066E RID: 1646
		[DispId(58)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_13();

		// Token: 0x0600066F RID: 1647
		[DispId(59)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14();

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000670 RID: 1648
		// (set) Token: 0x06000671 RID: 1649
		[DispId(60)]
		GInterface7 currentItem { [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000672 RID: 1650
		// (set) Token: 0x06000673 RID: 1651
		[DispId(61)]
		int currentMarker { [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000674 RID: 1652
		[DispId(63)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_15([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000675 RID: 1653
		[DispId(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([In] int lStep);

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000676 RID: 1654
		[DispId(65)]
		int audioLanguageCount { [DispId(65)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000677 RID: 1655
		[DispId(66)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_50([In] int lIndex);

		// Token: 0x06000678 RID: 1656
		[DispId(67)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_51([In] int lIndex);

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000679 RID: 1657
		// (set) Token: 0x0600067A RID: 1658
		[DispId(68)]
		int currentAudioLanguage { [DispId(68)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(68)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600067B RID: 1659
		// (set) Token: 0x0600067C RID: 1660
		[DispId(69)]
		int currentAudioLanguageIndex { [DispId(69)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(69)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600067D RID: 1661
		[DispId(70)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_52([In] int lLangID);

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600067E RID: 1662
		// (set) Token: 0x0600067F RID: 1663
		[DispId(71)]
		string currentPositionTimecode { [DispId(71)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(71)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
