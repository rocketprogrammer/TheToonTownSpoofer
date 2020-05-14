using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x02000090 RID: 144
	[Guid("AB7C88BB-143E-4EA4-ACC3-E4350B2106C3")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface35 : GInterface7
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600061D RID: 1565
		[DispId(763)]
		bool isIdentical { [DispId(763)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600061E RID: 1566
		[DispId(751)]
		string sourceURL { [DispId(751)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600061F RID: 1567
		// (set) Token: 0x06000620 RID: 1568
		[DispId(764)]
		string name { [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000621 RID: 1569
		[DispId(752)]
		int imageSourceWidth { [DispId(752)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000622 RID: 1570
		[DispId(753)]
		int imageSourceHeight { [DispId(753)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000623 RID: 1571
		[DispId(754)]
		int markerCount { [DispId(754)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000624 RID: 1572
		[DispId(755)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		double imethod_2([In] int MarkerNum);

		// Token: 0x06000625 RID: 1573
		[DispId(756)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_3([In] int MarkerNum);

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000626 RID: 1574
		[DispId(757)]
		double duration { [DispId(757)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000627 RID: 1575
		[DispId(758)]
		string durationString { [DispId(758)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000628 RID: 1576
		[DispId(759)]
		int attributeCount { [DispId(759)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000629 RID: 1577
		[DispId(760)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_4([In] int lIndex);

		// Token: 0x0600062A RID: 1578
		[DispId(761)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600062B RID: 1579
		[DispId(762)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x0600062C RID: 1580
		[DispId(765)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_13([In] int lAtom);

		// Token: 0x0600062D RID: 1581
		[DispId(766)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_14([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x0600062E RID: 1582
		[DispId(767)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600062F RID: 1583
		[DispId(768)]
		GInterface27 Error { [DispId(768)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
