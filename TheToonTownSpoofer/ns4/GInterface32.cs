using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x0200008D RID: 141
	[TypeLibType(4160)]
	[Guid("6BF52A4F-394A-11D3-B153-00C04F79FAA6")]
	[ComImport]
	public interface GInterface32 : GInterface17
	{
		// Token: 0x060005E9 RID: 1513
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005EA RID: 1514
		// (set) Token: 0x060005EB RID: 1515
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005EC RID: 1516
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005ED RID: 1517
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005EE RID: 1518
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005EF RID: 1519
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005F0 RID: 1520
		// (set) Token: 0x060005F1 RID: 1521
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005F2 RID: 1522
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005F3 RID: 1523
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005F4 RID: 1524
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060005F5 RID: 1525
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005F6 RID: 1526
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005F7 RID: 1527
		// (set) Token: 0x060005F8 RID: 1528
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005F9 RID: 1529
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005FA RID: 1530
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005FB RID: 1531
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005FC RID: 1532
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005FD RID: 1533
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005FE RID: 1534
		// (set) Token: 0x060005FF RID: 1535
		[DispId(19)]
		bool enabled { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000600 RID: 1536
		// (set) Token: 0x06000601 RID: 1537
		[DispId(21)]
		bool fullScreen { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000602 RID: 1538
		// (set) Token: 0x06000603 RID: 1539
		[DispId(22)]
		bool enableContextMenu { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000605 RID: 1541
		// (set) Token: 0x06000604 RID: 1540
		[DispId(23)]
		string uiMode { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
