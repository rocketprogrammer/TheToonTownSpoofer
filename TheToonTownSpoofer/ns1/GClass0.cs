using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns2;
using ns3;
using ns4;

namespace ns1
{
	// Token: 0x02000037 RID: 55
	[TypeLibType(2)]
	[ComSourceInterfaces("WMPLib._WMPOCXEvents\0\0")]
	[ClassInterface(0)]
	[Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")]
	[ComImport]
	public sealed class GClass0 : GInterface6, GInterface7, GInterface9, Interface5, GInterface13, GInterface14, GInterface18, GInterface19, GInterface20, GInterface23, GInterface25, GInterface26, GInterface27, GInterface28, GInterface30, GInterface31, GInterface32, GInterface33, GInterface34, GInterface35, GInterface36, GInterface37, GInterface38, GInterface39, GInterface40, GInterface41, GInterface42, GInterface44
	{
		// Token: 0x060001BC RID: 444
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern GClass0();

		// Token: 0x060001BD RID: 445
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_56();

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001BE RID: 446
		// (set) Token: 0x060001BF RID: 447
		[DispId(1)]
		public extern string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001C0 RID: 448
		[DispId(2)]
		public extern Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001C1 RID: 449
		[DispId(10)]
		public extern Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001C2 RID: 450
		[DispId(4)]
		public extern GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001C3 RID: 451
		[DispId(5)]
		public extern GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001C4 RID: 452
		// (set) Token: 0x060001C5 RID: 453
		[DispId(6)]
		public extern GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001C6 RID: 454
		[DispId(8)]
		public extern GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001C7 RID: 455
		[DispId(9)]
		public extern GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001C8 RID: 456
		[DispId(11)]
		public extern string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060001C9 RID: 457
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001CA RID: 458
		[DispId(7)]
		public extern GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CC RID: 460
		[DispId(13)]
		public extern GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001CD RID: 461
		[DispId(14)]
		public extern GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001CE RID: 462
		[DispId(15)]
		public extern GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001CF RID: 463
		[DispId(16)]
		public extern bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001D0 RID: 464
		[DispId(17)]
		public extern GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D1 RID: 465
		[DispId(18)]
		public extern string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001D2 RID: 466
		[DispId(40)]
		public extern GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060001D3 RID: 467
		[DispId(41)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_60([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x060001D4 RID: 468
		[DispId(42)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface7 imethod_61([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001D5 RID: 469
		// (set) Token: 0x060001D6 RID: 470
		[DispId(19)]
		public extern bool enabled { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001D7 RID: 471
		// (set) Token: 0x060001D8 RID: 472
		[DispId(21)]
		public extern bool fullScreen { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001D9 RID: 473
		// (set) Token: 0x060001DA RID: 474
		[DispId(22)]
		public extern bool enableContextMenu { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001DC RID: 476
		// (set) Token: 0x060001DB RID: 475
		[DispId(23)]
		public extern string uiMode { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001DD RID: 477
		// (set) Token: 0x060001DE RID: 478
		[DispId(24)]
		public extern bool stretchToFit { [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001DF RID: 479
		// (set) Token: 0x060001E0 RID: 480
		[DispId(25)]
		public extern bool windowlessVideo { [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001E1 RID: 481
		[DispId(26)]
		public extern bool isRemote { [DispId(26)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001E2 RID: 482
		[DispId(27)]
		public extern GInterface29 playerApplication { [DispId(27)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060001E3 RID: 483
		[DispId(28)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_62([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x060001E4 RID: 484
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001E5 RID: 485
		// (set) Token: 0x060001E6 RID: 486
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001E7 RID: 487
		public extern Enum9 openState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001E8 RID: 488
		public extern Enum10 playState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E9 RID: 489
		public extern GInterface18 controls { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001EA RID: 490
		public extern GInterface19 settings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001EB RID: 491
		// (set) Token: 0x060001EC RID: 492
		public extern GInterface7 currentMedia { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001ED RID: 493
		public extern GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001EE RID: 494
		public extern GInterface20 playlistCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001EF RID: 495
		public extern string versionInfo { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060001F0 RID: 496
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F1 RID: 497
		public extern GInterface22 network { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001F2 RID: 498
		// (set) Token: 0x060001F3 RID: 499
		public extern GInterface6 currentPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F4 RID: 500
		public extern GInterface23 cdromCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F5 RID: 501
		public extern GInterface25 closedCaption { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F6 RID: 502
		public extern bool isOnline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F7 RID: 503
		public extern GInterface26 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F8 RID: 504
		public extern string status { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F9 RID: 505
		public extern GInterface28 dvd { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001FA RID: 506
		// (set) Token: 0x060001FB RID: 507
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001FC RID: 508
		// (set) Token: 0x060001FD RID: 509
		public extern bool fullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FE RID: 510
		// (set) Token: 0x060001FF RID: 511
		public extern bool enableContextMenu { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000201 RID: 513
		// (set) Token: 0x06000200 RID: 512
		public extern string uiMode { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000202 RID: 514
		// (set) Token: 0x06000203 RID: 515
		public extern bool stretchToFit { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000204 RID: 516
		// (set) Token: 0x06000205 RID: 517
		public extern bool windowlessVideo { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000206 RID: 518
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000207 RID: 519
		// (set) Token: 0x06000208 RID: 520
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000209 RID: 521
		public extern Enum9 openState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600020A RID: 522
		public extern Enum10 playState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600020B RID: 523
		public extern GInterface18 controls { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600020C RID: 524
		public extern GInterface19 settings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600020D RID: 525
		// (set) Token: 0x0600020E RID: 526
		public extern GInterface7 currentMedia { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020F RID: 527
		public extern GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000210 RID: 528
		public extern GInterface20 playlistCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000211 RID: 529
		public extern string versionInfo { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000212 RID: 530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000213 RID: 531
		public extern GInterface22 network { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000214 RID: 532
		// (set) Token: 0x06000215 RID: 533
		public extern GInterface6 currentPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000216 RID: 534
		public extern GInterface23 cdromCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000217 RID: 535
		public extern GInterface25 closedCaption { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000218 RID: 536
		public extern bool isOnline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000219 RID: 537
		public extern GInterface26 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600021A RID: 538
		public extern string status { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600021B RID: 539
		// (set) Token: 0x0600021C RID: 540
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600021D RID: 541
		// (set) Token: 0x0600021E RID: 542
		public extern bool fullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021F RID: 543
		// (set) Token: 0x06000220 RID: 544
		public extern bool enableContextMenu { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000222 RID: 546
		// (set) Token: 0x06000221 RID: 545
		public extern string uiMode { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000223 RID: 547
		// (set) Token: 0x06000224 RID: 548
		public extern bool stretchToFit { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000225 RID: 549
		// (set) Token: 0x06000226 RID: 550
		public extern bool windowlessVideo { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000227 RID: 551
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000228 RID: 552
		// (set) Token: 0x06000229 RID: 553
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600022A RID: 554
		public extern Enum9 openState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022B RID: 555
		public extern Enum10 playState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600022C RID: 556
		public extern GInterface18 controls { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600022D RID: 557
		public extern GInterface19 settings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600022E RID: 558
		// (set) Token: 0x0600022F RID: 559
		public extern GInterface7 currentMedia { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000230 RID: 560
		public extern GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000231 RID: 561
		public extern GInterface20 playlistCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000232 RID: 562
		public extern string versionInfo { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000233 RID: 563
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000234 RID: 564
		public extern GInterface22 network { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000235 RID: 565
		// (set) Token: 0x06000236 RID: 566
		public extern GInterface6 currentPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000237 RID: 567
		public extern GInterface23 cdromCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000238 RID: 568
		public extern GInterface25 closedCaption { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000239 RID: 569
		public extern bool isOnline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600023A RID: 570
		public extern GInterface26 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600023B RID: 571
		public extern string status { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600023C RID: 572
		// (set) Token: 0x0600023D RID: 573
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600023E RID: 574
		// (set) Token: 0x0600023F RID: 575
		public extern bool fullScreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000240 RID: 576
		// (set) Token: 0x06000241 RID: 577
		public extern bool enableContextMenu { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000243 RID: 579
		// (set) Token: 0x06000242 RID: 578
		public extern string uiMode { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000244 RID: 580
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000245 RID: 581
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_25();

		// Token: 0x06000246 RID: 582
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_26();

		// Token: 0x06000247 RID: 583
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_27();

		// Token: 0x06000248 RID: 584
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_28();

		// Token: 0x06000249 RID: 585
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_29();

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024A RID: 586
		// (set) Token: 0x0600024B RID: 587
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024C RID: 588
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600024D RID: 589
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_30();

		// Token: 0x0600024E RID: 590
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_31();

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600024F RID: 591
		// (set) Token: 0x06000250 RID: 592
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000251 RID: 593
		// (set) Token: 0x06000252 RID: 594
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000253 RID: 595
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_32([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000254 RID: 596
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000255 RID: 597
		// (set) Token: 0x06000256 RID: 598
		public extern bool autoStart { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000257 RID: 599
		// (set) Token: 0x06000258 RID: 600
		public extern string baseURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000259 RID: 601
		// (set) Token: 0x0600025A RID: 602
		public extern string defaultFrame { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600025B RID: 603
		// (set) Token: 0x0600025C RID: 604
		public extern bool invokeURLs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025D RID: 605
		// (set) Token: 0x0600025E RID: 606
		public extern bool mute { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600025F RID: 607
		// (set) Token: 0x06000260 RID: 608
		public extern int playCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000261 RID: 609
		// (set) Token: 0x06000262 RID: 610
		public extern double rate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000263 RID: 611
		// (set) Token: 0x06000264 RID: 612
		public extern int balance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000265 RID: 613
		// (set) Token: 0x06000266 RID: 614
		public extern int volume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000267 RID: 615
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_53([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x06000268 RID: 616
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_54([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000269 RID: 617
		// (set) Token: 0x0600026A RID: 618
		public extern bool enableErrorDialogs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600026B RID: 619
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600026C RID: 620
		// (set) Token: 0x0600026D RID: 621
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600026E RID: 622
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600026F RID: 623
		public extern string attributeName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000270 RID: 624
		public extern GInterface7 Item { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000271 RID: 625
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000272 RID: 626
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000273 RID: 627
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000274 RID: 628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x06000275 RID: 629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3([In] int lIndex, [MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000276 RID: 630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000277 RID: 631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000278 RID: 632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6(int lIndexOld, int lIndexNew);

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000279 RID: 633
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600027A RID: 634
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600027B RID: 635
		// (set) Token: 0x0600027C RID: 636
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600027D RID: 637
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600027E RID: 638
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600027F RID: 639
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000280 RID: 640
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_7([In] int MarkerNum);

		// Token: 0x06000281 RID: 641
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_8([In] int MarkerNum);

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000282 RID: 642
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000283 RID: 643
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000284 RID: 644
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000285 RID: 645
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_9([In] int lIndex);

		// Token: 0x06000286 RID: 646
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000287 RID: 647
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x06000288 RID: 648
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_10([In] int lAtom);

		// Token: 0x06000289 RID: 649
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x0600028A RID: 650
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_12([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600028B RID: 651
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface7 imethod_13([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x0600028C RID: 652
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_14();

		// Token: 0x0600028D RID: 653
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x0600028E RID: 654
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_16([MarshalAs(UnmanagedType.BStr)] [In] string bstrGenre);

		// Token: 0x0600028F RID: 655
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_17([MarshalAs(UnmanagedType.BStr)] [In] string bstrAuthor);

		// Token: 0x06000290 RID: 656
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_18([MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum);

		// Token: 0x06000291 RID: 657
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000292 RID: 658
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_20([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfDeleteFile);

		// Token: 0x06000293 RID: 659
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface10 imethod_21([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x06000294 RID: 660
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_22([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000295 RID: 661
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_23([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfIsDeleted);

		// Token: 0x06000296 RID: 662
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_24([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem);

		// Token: 0x06000297 RID: 663
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_63([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000298 RID: 664
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface21 imethod_0();

		// Token: 0x06000299 RID: 665
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface21 imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x0600029A RID: 666
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_64([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x0600029B RID: 667
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_65([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem, [In] bool varfIsDeleted);

		// Token: 0x0600029C RID: 668
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_66([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x0600029D RID: 669
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_67([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600029E RID: 670
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600029F RID: 671
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface24 imethod_0([In] int lIndex);

		// Token: 0x060002A0 RID: 672
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface24 imethod_68([MarshalAs(UnmanagedType.BStr)] [In] string bstrDriveSpecifier);

		// Token: 0x060002A1 RID: 673
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_58();

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002A2 RID: 674
		public extern int errorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002A3 RID: 675
		public extern GInterface27 Item { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060002A4 RID: 676
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_59();

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002A5 RID: 677
		public extern int errorCode { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002A6 RID: 678
		public extern string errorDescription { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A7 RID: 679
		public extern object errorContext { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A8 RID: 680
		public extern int remedy { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A9 RID: 681
		public extern string customUrl { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002AA RID: 682
		public extern int errorCode { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002AB RID: 683
		public extern string errorDescription { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002AC RID: 684
		public extern object errorContext { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002AD RID: 685
		public extern int remedy { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002AE RID: 686
		public extern string customUrl { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002AF RID: 687
		public extern int condition { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B0 RID: 688
		// (set) Token: 0x060002B1 RID: 689
		public extern string SAMIStyle { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B2 RID: 690
		// (set) Token: 0x060002B3 RID: 691
		public extern string SAMILang { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002B4 RID: 692
		// (set) Token: 0x060002B5 RID: 693
		public extern string SAMIFileName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B6 RID: 694
		// (set) Token: 0x060002B7 RID: 695
		public extern string captioningId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B8 RID: 696
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B9 RID: 697
		public extern string domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060002BA RID: 698
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_36();

		// Token: 0x060002BB RID: 699
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_37();

		// Token: 0x060002BC RID: 700
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_38();

		// Token: 0x060002BD RID: 701
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_39();

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002BE RID: 702
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002BF RID: 703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x060002C0 RID: 704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1();

		// Token: 0x060002C1 RID: 705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x060002C2 RID: 706
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3();

		// Token: 0x060002C3 RID: 707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4();

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C4 RID: 708
		// (set) Token: 0x060002C5 RID: 709
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C6 RID: 710
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060002C7 RID: 711
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5();

		// Token: 0x060002C8 RID: 712
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6();

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C9 RID: 713
		// (set) Token: 0x060002CA RID: 714
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CB RID: 715
		// (set) Token: 0x060002CC RID: 716
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060002CD RID: 717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_7([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x060002CE RID: 718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_33([In] int lStep);

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002CF RID: 719
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002D0 RID: 720
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002D1 RID: 721
		// (set) Token: 0x060002D2 RID: 722
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002D3 RID: 723
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D4 RID: 724
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002D5 RID: 725
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002D6 RID: 726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_2([In] int MarkerNum);

		// Token: 0x060002D7 RID: 727
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_3([In] int MarkerNum);

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002D8 RID: 728
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002D9 RID: 729
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002DA RID: 730
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002DB RID: 731
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_4([In] int lIndex);

		// Token: 0x060002DC RID: 732
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060002DD RID: 733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x060002DE RID: 734
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_13([In] int lAtom);

		// Token: 0x060002DF RID: 735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_14([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x060002E0 RID: 736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002E1 RID: 737
		public extern GInterface27 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E2 RID: 738
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E3 RID: 739
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002E4 RID: 740
		// (set) Token: 0x060002E5 RID: 741
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E6 RID: 742
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E7 RID: 743
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002E8 RID: 744
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002E9 RID: 745
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_16([In] int MarkerNum);

		// Token: 0x060002EA RID: 746
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_17([In] int MarkerNum);

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002EB RID: 747
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002EC RID: 748
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002ED RID: 749
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002EE RID: 750
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_18([In] int lIndex);

		// Token: 0x060002EF RID: 751
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060002F0 RID: 752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_20([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x060002F1 RID: 753
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_21([In] int lAtom);

		// Token: 0x060002F2 RID: 754
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_22([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x060002F3 RID: 755
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_23([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002F4 RID: 756
		public extern GInterface27 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060002F5 RID: 757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_34([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage);

		// Token: 0x060002F6 RID: 758
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public extern object imethod_35([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage, [In] int lIndex);

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F7 RID: 759
		public extern string mimeType { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002F8 RID: 760
		public extern string pictureType { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002F9 RID: 761
		public extern string Description { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002FA RID: 762
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002FB RID: 763
		public extern string Description { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002FC RID: 764
		public extern string text { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002FD RID: 765
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		public extern bool autoStart { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		public extern string baseURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000302 RID: 770
		// (set) Token: 0x06000303 RID: 771
		public extern string defaultFrame { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000304 RID: 772
		// (set) Token: 0x06000305 RID: 773
		public extern bool invokeURLs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000306 RID: 774
		// (set) Token: 0x06000307 RID: 775
		public extern bool mute { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000308 RID: 776
		// (set) Token: 0x06000309 RID: 777
		public extern int playCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600030A RID: 778
		// (set) Token: 0x0600030B RID: 779
		public extern double rate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600030C RID: 780
		// (set) Token: 0x0600030D RID: 781
		public extern int balance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600030E RID: 782
		// (set) Token: 0x0600030F RID: 783
		public extern int volume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000310 RID: 784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x06000311 RID: 785
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000312 RID: 786
		// (set) Token: 0x06000313 RID: 787
		public extern bool enableErrorDialogs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000314 RID: 788
		public extern int defaultAudioLanguage { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000315 RID: 789
		public extern string mediaAccessRights { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000316 RID: 790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_55([MarshalAs(UnmanagedType.BStr)] [In] string bstrDesiredAccess);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000317 RID: 791
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000318 RID: 792
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_8();

		// Token: 0x06000319 RID: 793
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_9();

		// Token: 0x0600031A RID: 794
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_10();

		// Token: 0x0600031B RID: 795
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_11();

		// Token: 0x0600031C RID: 796
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_12();

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031D RID: 797
		// (set) Token: 0x0600031E RID: 798
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600031F RID: 799
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000320 RID: 800
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_13();

		// Token: 0x06000321 RID: 801
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_14();

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000322 RID: 802
		// (set) Token: 0x06000323 RID: 803
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000324 RID: 804
		// (set) Token: 0x06000325 RID: 805
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000326 RID: 806
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_15([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000327 RID: 807
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_16([In] int lStep);

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000328 RID: 808
		public extern int audioLanguageCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000329 RID: 809
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_50([In] int lIndex);

		// Token: 0x0600032A RID: 810
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_51([In] int lIndex);

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600032B RID: 811
		// (set) Token: 0x0600032C RID: 812
		public extern int currentAudioLanguage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600032D RID: 813
		// (set) Token: 0x0600032E RID: 814
		public extern int currentAudioLanguageIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600032F RID: 815
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_52([In] int lLangID);

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000330 RID: 816
		// (set) Token: 0x06000331 RID: 817
		public extern string currentPositionTimecode { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000332 RID: 818
		// (set) Token: 0x06000333 RID: 819
		public extern string SAMIStyle { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000334 RID: 820
		// (set) Token: 0x06000335 RID: 821
		public extern string SAMILang { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000336 RID: 822
		// (set) Token: 0x06000337 RID: 823
		public extern string SAMIFileName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000338 RID: 824
		// (set) Token: 0x06000339 RID: 825
		public extern string captioningId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600033A RID: 826
		public extern int SAMILangCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600033B RID: 827
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_40([In] int nIndex);

		// Token: 0x0600033C RID: 828
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_41([In] int nIndex);

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600033D RID: 829
		public extern int SAMIStyleCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600033E RID: 830
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_42([In] int nIndex);

		// Token: 0x0600033F RID: 831
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface7 imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x06000340 RID: 832
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_1();

		// Token: 0x06000341 RID: 833
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000342 RID: 834
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string bstrGenre);

		// Token: 0x06000343 RID: 835
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string bstrAuthor);

		// Token: 0x06000344 RID: 836
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum);

		// Token: 0x06000345 RID: 837
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000346 RID: 838
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_7([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfDeleteFile);

		// Token: 0x06000347 RID: 839
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface10 imethod_8([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x06000348 RID: 840
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_9([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000349 RID: 841
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_10([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfIsDeleted);

		// Token: 0x0600034A RID: 842
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem);

		// Token: 0x0600034B RID: 843
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface43 imethod_43();

		// Token: 0x0600034C RID: 844
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_44([MarshalAs(UnmanagedType.Interface)] [In] GInterface43 pQuery, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSortAttribute, [In] bool fSortAscending);

		// Token: 0x0600034D RID: 845
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface10 imethod_45([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.Interface)] [In] GInterface43 pQuery, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSortAttribute, [In] bool fSortAscending);

		// Token: 0x0600034E RID: 846
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_46([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600034F RID: 847
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000350 RID: 848
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_1([In] int lIndex);

		// Token: 0x06000351 RID: 849
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_2([MarshalAs(UnmanagedType.Interface)] [In] GInterface44 pIWMPStringCollection2);

		// Token: 0x06000352 RID: 850
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_47([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000353 RID: 851
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_48([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage);

		// Token: 0x06000354 RID: 852
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public extern object imethod_49([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage, [In] int lAttributeIndex);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000355 RID: 853
		// (remove) Token: 0x06000356 RID: 854
		public extern event Delegate0 OpenStateChange;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000357 RID: 855
		// (remove) Token: 0x06000358 RID: 856
		public extern event Delegate1 PlayStateChange;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000359 RID: 857
		// (remove) Token: 0x0600035A RID: 858
		public extern event Delegate2 AudioLanguageChange;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600035B RID: 859
		// (remove) Token: 0x0600035C RID: 860
		public extern event Delegate3 StatusChange;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600035D RID: 861
		// (remove) Token: 0x0600035E RID: 862
		public extern event Delegate4 ScriptCommand;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600035F RID: 863
		// (remove) Token: 0x06000360 RID: 864
		public extern event Delegate5 NewStream;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000361 RID: 865
		// (remove) Token: 0x06000362 RID: 866
		public extern event Delegate6 Disconnect;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000363 RID: 867
		// (remove) Token: 0x06000364 RID: 868
		public extern event Delegate7 Buffering;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000365 RID: 869
		// (remove) Token: 0x06000366 RID: 870
		public extern event Delegate8 Error;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000367 RID: 871
		// (remove) Token: 0x06000368 RID: 872
		public extern event Delegate9 Warning;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000369 RID: 873
		// (remove) Token: 0x0600036A RID: 874
		public extern event Delegate10 EndOfStream;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600036B RID: 875
		// (remove) Token: 0x0600036C RID: 876
		public extern event Delegate11 PositionChange;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600036D RID: 877
		// (remove) Token: 0x0600036E RID: 878
		public extern event Delegate12 MarkerHit;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600036F RID: 879
		// (remove) Token: 0x06000370 RID: 880
		public extern event Delegate13 DurationUnitChange;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000371 RID: 881
		// (remove) Token: 0x06000372 RID: 882
		public extern event Delegate14 CdromMediaChange;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000373 RID: 883
		// (remove) Token: 0x06000374 RID: 884
		public extern event Delegate15 PlaylistChange;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000375 RID: 885
		// (remove) Token: 0x06000376 RID: 886
		public extern event Delegate16 CurrentPlaylistChange;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000377 RID: 887
		// (remove) Token: 0x06000378 RID: 888
		public extern event Delegate17 CurrentPlaylistItemAvailable;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000379 RID: 889
		// (remove) Token: 0x0600037A RID: 890
		public extern event Delegate18 MediaChange;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600037B RID: 891
		// (remove) Token: 0x0600037C RID: 892
		public extern event Delegate19 CurrentMediaItemAvailable;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600037D RID: 893
		// (remove) Token: 0x0600037E RID: 894
		public extern event Delegate20 CurrentItemChange;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600037F RID: 895
		// (remove) Token: 0x06000380 RID: 896
		public extern event Delegate21 MediaCollectionChange;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000381 RID: 897
		// (remove) Token: 0x06000382 RID: 898
		public extern event Delegate22 MediaCollectionAttributeStringAdded;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000383 RID: 899
		// (remove) Token: 0x06000384 RID: 900
		public extern event Delegate23 MediaCollectionAttributeStringRemoved;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000385 RID: 901
		// (remove) Token: 0x06000386 RID: 902
		public extern event Delegate24 MediaCollectionAttributeStringChanged;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000387 RID: 903
		// (remove) Token: 0x06000388 RID: 904
		public extern event Delegate25 PlaylistCollectionChange;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000389 RID: 905
		// (remove) Token: 0x0600038A RID: 906
		public extern event Delegate26 PlaylistCollectionPlaylistAdded;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600038B RID: 907
		// (remove) Token: 0x0600038C RID: 908
		public extern event Delegate27 PlaylistCollectionPlaylistRemoved;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600038D RID: 909
		// (remove) Token: 0x0600038E RID: 910
		public extern event Delegate28 PlaylistCollectionPlaylistSetAsDeleted;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600038F RID: 911
		// (remove) Token: 0x06000390 RID: 912
		public extern event Delegate29 ModeChange;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000391 RID: 913
		// (remove) Token: 0x06000392 RID: 914
		public extern event Delegate30 MediaError;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000393 RID: 915
		// (remove) Token: 0x06000394 RID: 916
		public extern event Delegate31 OpenPlaylistSwitch;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000395 RID: 917
		// (remove) Token: 0x06000396 RID: 918
		public extern event Delegate32 DomainChange;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000397 RID: 919
		// (remove) Token: 0x06000398 RID: 920
		public extern event Delegate33 SwitchedToPlayerApplication;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000399 RID: 921
		// (remove) Token: 0x0600039A RID: 922
		public extern event Delegate34 SwitchedToControl;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x0600039B RID: 923
		// (remove) Token: 0x0600039C RID: 924
		public extern event Delegate35 PlayerDockedStateChange;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600039D RID: 925
		// (remove) Token: 0x0600039E RID: 926
		public extern event Delegate36 PlayerReconnect;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600039F RID: 927
		// (remove) Token: 0x060003A0 RID: 928
		public extern event Delegate37 Click;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060003A1 RID: 929
		// (remove) Token: 0x060003A2 RID: 930
		public extern event Delegate38 DoubleClick;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060003A3 RID: 931
		// (remove) Token: 0x060003A4 RID: 932
		public extern event Delegate39 KeyDown;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060003A5 RID: 933
		// (remove) Token: 0x060003A6 RID: 934
		public extern event Delegate40 KeyPress;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060003A7 RID: 935
		// (remove) Token: 0x060003A8 RID: 936
		public extern event Delegate41 KeyUp;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060003A9 RID: 937
		// (remove) Token: 0x060003AA RID: 938
		public extern event Delegate42 MouseDown;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060003AB RID: 939
		// (remove) Token: 0x060003AC RID: 940
		public extern event Delegate43 MouseMove;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060003AD RID: 941
		// (remove) Token: 0x060003AE RID: 942
		public extern event Delegate44 MouseUp;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060003AF RID: 943
		// (remove) Token: 0x060003B0 RID: 944
		public extern event Delegate45 DeviceConnect;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060003B1 RID: 945
		// (remove) Token: 0x060003B2 RID: 946
		public extern event Delegate46 DeviceDisconnect;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060003B3 RID: 947
		// (remove) Token: 0x060003B4 RID: 948
		public extern event Delegate47 DeviceStatusChange;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060003B5 RID: 949
		// (remove) Token: 0x060003B6 RID: 950
		public extern event Delegate48 DeviceSyncStateChange;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060003B7 RID: 951
		// (remove) Token: 0x060003B8 RID: 952
		public extern event Delegate49 DeviceSyncError;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060003B9 RID: 953
		// (remove) Token: 0x060003BA RID: 954
		public extern event Delegate50 CreatePartnershipComplete;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060003BB RID: 955
		// (remove) Token: 0x060003BC RID: 956
		public extern event Delegate51 DeviceEstimation;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060003BD RID: 957
		// (remove) Token: 0x060003BE RID: 958
		public extern event Delegate52 CdromRipStateChange;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060003BF RID: 959
		// (remove) Token: 0x060003C0 RID: 960
		public extern event Delegate53 CdromRipMediaError;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060003C1 RID: 961
		// (remove) Token: 0x060003C2 RID: 962
		public extern event Delegate54 CdromBurnStateChange;

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060003C3 RID: 963
		// (remove) Token: 0x060003C4 RID: 964
		public extern event Delegate55 CdromBurnMediaError;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060003C5 RID: 965
		// (remove) Token: 0x060003C6 RID: 966
		public extern event Delegate56 CdromBurnError;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060003C7 RID: 967
		// (remove) Token: 0x060003C8 RID: 968
		public extern event Delegate57 LibraryConnect;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060003C9 RID: 969
		// (remove) Token: 0x060003CA RID: 970
		public extern event Delegate58 LibraryDisconnect;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060003CB RID: 971
		// (remove) Token: 0x060003CC RID: 972
		public extern event Delegate59 FolderScanStateChange;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060003CD RID: 973
		// (remove) Token: 0x060003CE RID: 974
		public extern event Delegate60 StringCollectionChange;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060003CF RID: 975
		// (remove) Token: 0x060003D0 RID: 976
		public extern event Delegate61 MediaCollectionMediaAdded;

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060003D1 RID: 977
		// (remove) Token: 0x060003D2 RID: 978
		public extern event Delegate62 MediaCollectionMediaRemoved;
	}
}
