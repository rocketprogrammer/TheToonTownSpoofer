using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x0200008B RID: 139
	[TypeLibType(4160)]
	[Guid("54062B68-052A-4C25-A39F-8B63346511D4")]
	[ComImport]
	public interface GInterface30 : GInterface16
	{
		// Token: 0x060005A6 RID: 1446
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A7 RID: 1447
		// (set) Token: 0x060005A8 RID: 1448
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005A9 RID: 1449
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005AA RID: 1450
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005AB RID: 1451
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005AC RID: 1452
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005AD RID: 1453
		// (set) Token: 0x060005AE RID: 1454
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005AF RID: 1455
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005B0 RID: 1456
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005B1 RID: 1457
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060005B2 RID: 1458
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005B3 RID: 1459
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005B4 RID: 1460
		// (set) Token: 0x060005B5 RID: 1461
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005B6 RID: 1462
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005B7 RID: 1463
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005B8 RID: 1464
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005B9 RID: 1465
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005BA RID: 1466
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005BB RID: 1467
		[DispId(40)]
		GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005BC RID: 1468
		// (set) Token: 0x060005BD RID: 1469
		[DispId(19)]
		bool enabled { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005BE RID: 1470
		// (set) Token: 0x060005BF RID: 1471
		[DispId(21)]
		bool fullScreen { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005C0 RID: 1472
		// (set) Token: 0x060005C1 RID: 1473
		[DispId(22)]
		bool enableContextMenu { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005C3 RID: 1475
		// (set) Token: 0x060005C2 RID: 1474
		[DispId(23)]
		string uiMode { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005C4 RID: 1476
		// (set) Token: 0x060005C5 RID: 1477
		[DispId(24)]
		bool stretchToFit { [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005C6 RID: 1478
		// (set) Token: 0x060005C7 RID: 1479
		[DispId(25)]
		bool windowlessVideo { [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
