using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x02000091 RID: 145
	[Guid("F118EFC7-F03A-4FB4-99C9-1C02A5C1065B")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface36 : GInterface35
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000630 RID: 1584
		[DispId(763)]
		bool isIdentical { [DispId(763)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000631 RID: 1585
		[DispId(751)]
		string sourceURL { [DispId(751)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000632 RID: 1586
		// (set) Token: 0x06000633 RID: 1587
		[DispId(764)]
		string name { [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000634 RID: 1588
		[DispId(752)]
		int imageSourceWidth { [DispId(752)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000635 RID: 1589
		[DispId(753)]
		int imageSourceHeight { [DispId(753)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000636 RID: 1590
		[DispId(754)]
		int markerCount { [DispId(754)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000637 RID: 1591
		[DispId(755)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		double imethod_16([In] int MarkerNum);

		// Token: 0x06000638 RID: 1592
		[DispId(756)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_17([In] int MarkerNum);

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000639 RID: 1593
		[DispId(757)]
		double duration { [DispId(757)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600063A RID: 1594
		[DispId(758)]
		string durationString { [DispId(758)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600063B RID: 1595
		[DispId(759)]
		int attributeCount { [DispId(759)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600063C RID: 1596
		[DispId(760)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_18([In] int lIndex);

		// Token: 0x0600063D RID: 1597
		[DispId(761)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600063E RID: 1598
		[DispId(762)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_20([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x0600063F RID: 1599
		[DispId(765)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_21([In] int lAtom);

		// Token: 0x06000640 RID: 1600
		[DispId(766)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_22([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x06000641 RID: 1601
		[DispId(767)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_23([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000642 RID: 1602
		[DispId(768)]
		GInterface27 Error { [DispId(768)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000643 RID: 1603
		[DispId(769)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_34([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage);

		// Token: 0x06000644 RID: 1604
		[DispId(770)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object imethod_35([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage, [In] int lIndex);
	}
}
