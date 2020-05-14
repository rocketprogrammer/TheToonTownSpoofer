using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x0200008C RID: 140
	[TypeLibType(4160)]
	[Guid("0E6B01D1-D407-4C85-BF5F-1C01F6150280")]
	[ComImport]
	public interface GInterface31 : GInterface17
	{
		// Token: 0x060005C8 RID: 1480
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005C9 RID: 1481
		// (set) Token: 0x060005CA RID: 1482
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005CB RID: 1483
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005CC RID: 1484
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005CD RID: 1485
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005CE RID: 1486
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005CF RID: 1487
		// (set) Token: 0x060005D0 RID: 1488
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005D1 RID: 1489
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005D2 RID: 1490
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005D3 RID: 1491
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060005D4 RID: 1492
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005D5 RID: 1493
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005D6 RID: 1494
		// (set) Token: 0x060005D7 RID: 1495
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005D8 RID: 1496
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005D9 RID: 1497
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005DA RID: 1498
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005DB RID: 1499
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005DC RID: 1500
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005DD RID: 1501
		// (set) Token: 0x060005DE RID: 1502
		[DispId(19)]
		bool enabled { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005DF RID: 1503
		// (set) Token: 0x060005E0 RID: 1504
		[DispId(21)]
		bool fullScreen { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005E1 RID: 1505
		// (set) Token: 0x060005E2 RID: 1506
		[DispId(22)]
		bool enableContextMenu { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005E4 RID: 1508
		// (set) Token: 0x060005E3 RID: 1507
		[DispId(23)]
		string uiMode { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005E5 RID: 1509
		// (set) Token: 0x060005E6 RID: 1510
		[DispId(24)]
		bool stretchToFit { [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005E7 RID: 1511
		// (set) Token: 0x060005E8 RID: 1512
		[DispId(25)]
		bool windowlessVideo { [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
