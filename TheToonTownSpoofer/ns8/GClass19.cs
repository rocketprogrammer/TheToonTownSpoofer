using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns3;
using ns4;
using ns9;

namespace ns8
{
	// Token: 0x0200010B RID: 267
	[Guid("09428D37-E0B9-11D2-B147-00C04F79FAA6")]
	[ClassInterface(0)]
	[ComSourceInterfaces("WMPLib._WMPCoreEvents\0\0")]
	[ComImport]
	public sealed class GClass19 : GInterface6, GInterface7, GInterface9, GInterface10, GInterface15, GInterface16, GInterface17, GInterface18, GInterface19, GInterface20, GInterface23, GInterface24, GInterface25, GInterface26, GInterface27, GInterface28, GInterface34, GInterface35, GInterface36, GInterface37, GInterface38, GInterface39, GInterface40, GInterface41, Interface11, GInterface114
	{
		// Token: 0x06000E31 RID: 3633
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass19();

		// Token: 0x06000E32 RID: 3634
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_56();

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E33 RID: 3635
		// (set) Token: 0x06000E34 RID: 3636
		[DispId(1)]
		public extern string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E35 RID: 3637
		[DispId(2)]
		public extern Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E36 RID: 3638
		[DispId(10)]
		public extern Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E37 RID: 3639
		[DispId(4)]
		public extern GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E38 RID: 3640
		[DispId(5)]
		public extern GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E39 RID: 3641
		// (set) Token: 0x06000E3A RID: 3642
		[DispId(6)]
		public extern GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E3B RID: 3643
		[DispId(8)]
		public extern GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E3C RID: 3644
		[DispId(9)]
		public extern GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000E3D RID: 3645
		[DispId(11)]
		public extern string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000E3E RID: 3646
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000E3F RID: 3647
		[DispId(7)]
		public extern GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000E40 RID: 3648
		// (set) Token: 0x06000E41 RID: 3649
		[DispId(13)]
		public extern GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000E42 RID: 3650
		[DispId(14)]
		public extern GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000E43 RID: 3651
		[DispId(15)]
		public extern GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000E44 RID: 3652
		[DispId(16)]
		public extern bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000E45 RID: 3653
		[DispId(17)]
		public extern GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000E46 RID: 3654
		[DispId(18)]
		public extern string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000E47 RID: 3655
		[DispId(40)]
		public extern GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000E48 RID: 3656
		[DispId(41)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_60([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x06000E49 RID: 3657
		[DispId(42)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface7 imethod_61([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x06000E4A RID: 3658
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_56();

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000E4B RID: 3659
		// (set) Token: 0x06000E4C RID: 3660
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000E4D RID: 3661
		public extern Enum9 openState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000E4E RID: 3662
		public extern Enum10 playState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000E4F RID: 3663
		public extern GInterface18 controls { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000E50 RID: 3664
		public extern GInterface19 settings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000E51 RID: 3665
		// (set) Token: 0x06000E52 RID: 3666
		public extern GInterface7 currentMedia { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000E53 RID: 3667
		public extern GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000E54 RID: 3668
		public extern GInterface20 playlistCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000E55 RID: 3669
		public extern string versionInfo { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000E56 RID: 3670
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000E57 RID: 3671
		public extern GInterface22 network { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000E58 RID: 3672
		// (set) Token: 0x06000E59 RID: 3673
		public extern GInterface6 currentPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000E5A RID: 3674
		public extern GInterface23 cdromCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000E5B RID: 3675
		public extern GInterface25 closedCaption { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000E5C RID: 3676
		public extern bool isOnline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000E5D RID: 3677
		public extern GInterface26 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000E5E RID: 3678
		public extern string status { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000E5F RID: 3679
		public extern GInterface28 dvd { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000E60 RID: 3680
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_56();

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000E61 RID: 3681
		// (set) Token: 0x06000E62 RID: 3682
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000E63 RID: 3683
		public extern Enum9 openState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000E64 RID: 3684
		public extern Enum10 playState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000E65 RID: 3685
		public extern GInterface18 controls { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000E66 RID: 3686
		public extern GInterface19 settings { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000E67 RID: 3687
		// (set) Token: 0x06000E68 RID: 3688
		public extern GInterface7 currentMedia { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000E69 RID: 3689
		public extern GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000E6A RID: 3690
		public extern GInterface20 playlistCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000E6B RID: 3691
		public extern string versionInfo { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000E6C RID: 3692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000E6D RID: 3693
		public extern GInterface22 network { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000E6E RID: 3694
		// (set) Token: 0x06000E6F RID: 3695
		public extern GInterface6 currentPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000E70 RID: 3696
		public extern GInterface23 cdromCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000E71 RID: 3697
		public extern GInterface25 closedCaption { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000E72 RID: 3698
		public extern bool isOnline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000E73 RID: 3699
		public extern GInterface26 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000E74 RID: 3700
		public extern string status { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000E75 RID: 3701
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E76 RID: 3702
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_25();

		// Token: 0x06000E77 RID: 3703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_26();

		// Token: 0x06000E78 RID: 3704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_27();

		// Token: 0x06000E79 RID: 3705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_28();

		// Token: 0x06000E7A RID: 3706
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_29();

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000E7B RID: 3707
		// (set) Token: 0x06000E7C RID: 3708
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000E7D RID: 3709
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000E7E RID: 3710
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_30();

		// Token: 0x06000E7F RID: 3711
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_31();

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000E80 RID: 3712
		// (set) Token: 0x06000E81 RID: 3713
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000E82 RID: 3714
		// (set) Token: 0x06000E83 RID: 3715
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000E84 RID: 3716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_32([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000E85 RID: 3717
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000E86 RID: 3718
		// (set) Token: 0x06000E87 RID: 3719
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000E88 RID: 3720
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000E89 RID: 3721
		public extern string attributeName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000E8A RID: 3722
		public extern GInterface7 Item { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000E8B RID: 3723
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000E8C RID: 3724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000E8D RID: 3725
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000E8E RID: 3726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x06000E8F RID: 3727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3([In] int lIndex, [MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000E90 RID: 3728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000E91 RID: 3729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000E92 RID: 3730
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6(int lIndexOld, int lIndexNew);

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000E93 RID: 3731
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000E94 RID: 3732
		// (set) Token: 0x06000E95 RID: 3733
		public extern bool autoStart { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000E96 RID: 3734
		// (set) Token: 0x06000E97 RID: 3735
		public extern string baseURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000E98 RID: 3736
		// (set) Token: 0x06000E99 RID: 3737
		public extern string defaultFrame { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000E9A RID: 3738
		// (set) Token: 0x06000E9B RID: 3739
		public extern bool invokeURLs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000E9C RID: 3740
		// (set) Token: 0x06000E9D RID: 3741
		public extern bool mute { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000E9E RID: 3742
		// (set) Token: 0x06000E9F RID: 3743
		public extern int playCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000EA0 RID: 3744
		// (set) Token: 0x06000EA1 RID: 3745
		public extern double rate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000EA2 RID: 3746
		// (set) Token: 0x06000EA3 RID: 3747
		public extern int balance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000EA4 RID: 3748
		// (set) Token: 0x06000EA5 RID: 3749
		public extern int volume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000EA6 RID: 3750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_53([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x06000EA7 RID: 3751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_54([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000EA8 RID: 3752
		// (set) Token: 0x06000EA9 RID: 3753
		public extern bool enableErrorDialogs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000EAA RID: 3754
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000EAB RID: 3755
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000EAC RID: 3756
		// (set) Token: 0x06000EAD RID: 3757
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000EAE RID: 3758
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000EAF RID: 3759
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000EB0 RID: 3760
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EB1 RID: 3761
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_7([In] int MarkerNum);

		// Token: 0x06000EB2 RID: 3762
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_8([In] int MarkerNum);

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000EB3 RID: 3763
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000EB4 RID: 3764
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000EB5 RID: 3765
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EB6 RID: 3766
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_9([In] int lIndex);

		// Token: 0x06000EB7 RID: 3767
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000EB8 RID: 3768
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x06000EB9 RID: 3769
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_10([In] int lAtom);

		// Token: 0x06000EBA RID: 3770
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x06000EBB RID: 3771
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_12([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000EBC RID: 3772
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EBD RID: 3773
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([In] int lIndex);

		// Token: 0x06000EBE RID: 3774
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface7 imethod_13([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x06000EBF RID: 3775
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_14();

		// Token: 0x06000EC0 RID: 3776
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000EC1 RID: 3777
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_16([MarshalAs(UnmanagedType.BStr)] [In] string bstrGenre);

		// Token: 0x06000EC2 RID: 3778
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_17([MarshalAs(UnmanagedType.BStr)] [In] string bstrAuthor);

		// Token: 0x06000EC3 RID: 3779
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_18([MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum);

		// Token: 0x06000EC4 RID: 3780
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000EC5 RID: 3781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_20([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfDeleteFile);

		// Token: 0x06000EC6 RID: 3782
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface10 imethod_21([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x06000EC7 RID: 3783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_22([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000EC8 RID: 3784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_23([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfIsDeleted);

		// Token: 0x06000EC9 RID: 3785
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_24([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem);

		// Token: 0x06000ECA RID: 3786
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_63([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000ECB RID: 3787
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface21 imethod_0();

		// Token: 0x06000ECC RID: 3788
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface21 imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000ECD RID: 3789
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_64([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x06000ECE RID: 3790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_65([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem, [In] bool varfIsDeleted);

		// Token: 0x06000ECF RID: 3791
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_66([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x06000ED0 RID: 3792
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface6 imethod_67([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pItem);

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000ED1 RID: 3793
		public extern int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000ED2 RID: 3794
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface24 imethod_0([In] int lIndex);

		// Token: 0x06000ED3 RID: 3795
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public extern GInterface24 imethod_68([MarshalAs(UnmanagedType.BStr)] [In] string bstrDriveSpecifier);

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000ED4 RID: 3796
		public extern string driveSpecifier { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000ED5 RID: 3797
		public extern GInterface6 Playlist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000ED6 RID: 3798
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_43();

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000ED7 RID: 3799
		public extern int errorCode { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000ED8 RID: 3800
		public extern string errorDescription { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000ED9 RID: 3801
		public extern object errorContext { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000EDA RID: 3802
		public extern int remedy { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000EDB RID: 3803
		public extern string customUrl { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000EDC RID: 3804
		// (set) Token: 0x06000EDD RID: 3805
		public extern string SAMIStyle { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000EDE RID: 3806
		// (set) Token: 0x06000EDF RID: 3807
		public extern string SAMILang { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000EE0 RID: 3808
		// (set) Token: 0x06000EE1 RID: 3809
		public extern string SAMIFileName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000EE2 RID: 3810
		// (set) Token: 0x06000EE3 RID: 3811
		public extern string captioningId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000EE4 RID: 3812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_58();

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000EE5 RID: 3813
		public extern int errorCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000EE6 RID: 3814
		public extern GInterface27 Item { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000EE7 RID: 3815
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_59();

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000EE8 RID: 3816
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000EE9 RID: 3817
		public extern string domain { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000EEA RID: 3818
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_36();

		// Token: 0x06000EEB RID: 3819
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_37();

		// Token: 0x06000EEC RID: 3820
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_38();

		// Token: 0x06000EED RID: 3821
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_39();

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000EEE RID: 3822
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000EEF RID: 3823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x06000EF0 RID: 3824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1();

		// Token: 0x06000EF1 RID: 3825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x06000EF2 RID: 3826
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3();

		// Token: 0x06000EF3 RID: 3827
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4();

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000EF4 RID: 3828
		// (set) Token: 0x06000EF5 RID: 3829
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000EF6 RID: 3830
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000EF7 RID: 3831
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5();

		// Token: 0x06000EF8 RID: 3832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6();

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000EF9 RID: 3833
		// (set) Token: 0x06000EFA RID: 3834
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000EFB RID: 3835
		// (set) Token: 0x06000EFC RID: 3836
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000EFD RID: 3837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_7([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000EFE RID: 3838
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_33([In] int lStep);

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000EFF RID: 3839
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000F00 RID: 3840
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000F01 RID: 3841
		// (set) Token: 0x06000F02 RID: 3842
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000F03 RID: 3843
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000F04 RID: 3844
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000F05 RID: 3845
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F06 RID: 3846
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_2([In] int MarkerNum);

		// Token: 0x06000F07 RID: 3847
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_3([In] int MarkerNum);

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000F08 RID: 3848
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000F09 RID: 3849
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000F0A RID: 3850
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F0B RID: 3851
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_4([In] int lIndex);

		// Token: 0x06000F0C RID: 3852
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000F0D RID: 3853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x06000F0E RID: 3854
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_13([In] int lAtom);

		// Token: 0x06000F0F RID: 3855
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_14([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x06000F10 RID: 3856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000F11 RID: 3857
		public extern GInterface27 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000F12 RID: 3858
		public extern bool isIdentical { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000F13 RID: 3859
		public extern string sourceURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000F14 RID: 3860
		// (set) Token: 0x06000F15 RID: 3861
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000F16 RID: 3862
		public extern int imageSourceWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000F17 RID: 3863
		public extern int imageSourceHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000F18 RID: 3864
		public extern int markerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F19 RID: 3865
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double imethod_16([In] int MarkerNum);

		// Token: 0x06000F1A RID: 3866
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_17([In] int MarkerNum);

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000F1B RID: 3867
		public extern double duration { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000F1C RID: 3868
		public extern string durationString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000F1D RID: 3869
		public extern int attributeCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F1E RID: 3870
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_18([In] int lIndex);

		// Token: 0x06000F1F RID: 3871
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000F20 RID: 3872
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_20([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x06000F21 RID: 3873
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_21([In] int lAtom);

		// Token: 0x06000F22 RID: 3874
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_22([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x06000F23 RID: 3875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_23([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000F24 RID: 3876
		public extern GInterface27 Error { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000F25 RID: 3877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_34([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage);

		// Token: 0x06000F26 RID: 3878
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public extern object imethod_35([MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage, [In] int lIndex);

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000F27 RID: 3879
		public extern string mimeType { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000F28 RID: 3880
		public extern string pictureType { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000F29 RID: 3881
		public extern string Description { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000F2A RID: 3882
		public extern string URL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000F2B RID: 3883
		public extern string Description { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000F2C RID: 3884
		public extern string text { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000F2D RID: 3885
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000F2E RID: 3886
		// (set) Token: 0x06000F2F RID: 3887
		public extern bool autoStart { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000F30 RID: 3888
		// (set) Token: 0x06000F31 RID: 3889
		public extern string baseURL { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000F32 RID: 3890
		// (set) Token: 0x06000F33 RID: 3891
		public extern string defaultFrame { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000F34 RID: 3892
		// (set) Token: 0x06000F35 RID: 3893
		public extern bool invokeURLs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000F36 RID: 3894
		// (set) Token: 0x06000F37 RID: 3895
		public extern bool mute { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000F38 RID: 3896
		// (set) Token: 0x06000F39 RID: 3897
		public extern int playCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000F3A RID: 3898
		// (set) Token: 0x06000F3B RID: 3899
		public extern double rate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000F3C RID: 3900
		// (set) Token: 0x06000F3D RID: 3901
		public extern int balance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000F3E RID: 3902
		// (set) Token: 0x06000F3F RID: 3903
		public extern int volume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000F40 RID: 3904
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x06000F41 RID: 3905
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000F42 RID: 3906
		// (set) Token: 0x06000F43 RID: 3907
		public extern bool enableErrorDialogs { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000F44 RID: 3908
		public extern int defaultAudioLanguage { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000F45 RID: 3909
		public extern string mediaAccessRights { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000F46 RID: 3910
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool imethod_55([MarshalAs(UnmanagedType.BStr)] [In] string bstrDesiredAccess);

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000F47 RID: 3911
		public extern bool isAvailable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F48 RID: 3912
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_8();

		// Token: 0x06000F49 RID: 3913
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_9();

		// Token: 0x06000F4A RID: 3914
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_10();

		// Token: 0x06000F4B RID: 3915
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_11();

		// Token: 0x06000F4C RID: 3916
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_12();

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000F4D RID: 3917
		// (set) Token: 0x06000F4E RID: 3918
		public extern double currentPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000F4F RID: 3919
		public extern string currentPositionString { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000F50 RID: 3920
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_13();

		// Token: 0x06000F51 RID: 3921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_14();

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000F52 RID: 3922
		// (set) Token: 0x06000F53 RID: 3923
		public extern GInterface7 currentItem { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000F54 RID: 3924
		// (set) Token: 0x06000F55 RID: 3925
		public extern int currentMarker { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000F56 RID: 3926
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_15([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000F57 RID: 3927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_16([In] int lStep);

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000F58 RID: 3928
		public extern int audioLanguageCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F59 RID: 3929
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_50([In] int lIndex);

		// Token: 0x06000F5A RID: 3930
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_51([In] int lIndex);

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000F5B RID: 3931
		// (set) Token: 0x06000F5C RID: 3932
		public extern int currentAudioLanguage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000F5D RID: 3933
		// (set) Token: 0x06000F5E RID: 3934
		public extern int currentAudioLanguageIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000F5F RID: 3935
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_52([In] int lLangID);

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000F60 RID: 3936
		// (set) Token: 0x06000F61 RID: 3937
		public extern string currentPositionTimecode { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000F62 RID: 3938
		// (set) Token: 0x06000F63 RID: 3939
		public extern string SAMIStyle { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000F64 RID: 3940
		// (set) Token: 0x06000F65 RID: 3941
		public extern string SAMILang { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000F66 RID: 3942
		// (set) Token: 0x06000F67 RID: 3943
		public extern string SAMIFileName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000F68 RID: 3944
		// (set) Token: 0x06000F69 RID: 3945
		public extern string captioningId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000F6A RID: 3946
		public extern int SAMILangCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F6B RID: 3947
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_40([In] int nIndex);

		// Token: 0x06000F6C RID: 3948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_41([In] int nIndex);

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000F6D RID: 3949
		public extern int SAMIStyleCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F6E RID: 3950
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_42([In] int nIndex);

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x06000F6F RID: 3951
		// (remove) Token: 0x06000F70 RID: 3952
		public extern event Delegate84 OpenStateChange;

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06000F71 RID: 3953
		// (remove) Token: 0x06000F72 RID: 3954
		public extern event Delegate85 PlayStateChange;

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000F73 RID: 3955
		// (remove) Token: 0x06000F74 RID: 3956
		public extern event Delegate86 AudioLanguageChange;

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x06000F75 RID: 3957
		// (remove) Token: 0x06000F76 RID: 3958
		public extern event Delegate87 StatusChange;

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x06000F77 RID: 3959
		// (remove) Token: 0x06000F78 RID: 3960
		public extern event Delegate88 ScriptCommand;

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x06000F79 RID: 3961
		// (remove) Token: 0x06000F7A RID: 3962
		public extern event Delegate89 NewStream;

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x06000F7B RID: 3963
		// (remove) Token: 0x06000F7C RID: 3964
		public extern event Delegate90 Disconnect;

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x06000F7D RID: 3965
		// (remove) Token: 0x06000F7E RID: 3966
		public extern event Delegate91 Buffering;

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x06000F7F RID: 3967
		// (remove) Token: 0x06000F80 RID: 3968
		public extern event Delegate92 Error;

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x06000F81 RID: 3969
		// (remove) Token: 0x06000F82 RID: 3970
		public extern event Delegate93 Warning;

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x06000F83 RID: 3971
		// (remove) Token: 0x06000F84 RID: 3972
		public extern event Delegate94 EndOfStream;

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x06000F85 RID: 3973
		// (remove) Token: 0x06000F86 RID: 3974
		public extern event Delegate95 PositionChange;

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x06000F87 RID: 3975
		// (remove) Token: 0x06000F88 RID: 3976
		public extern event Delegate96 MarkerHit;

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x06000F89 RID: 3977
		// (remove) Token: 0x06000F8A RID: 3978
		public extern event Delegate97 DurationUnitChange;

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x06000F8B RID: 3979
		// (remove) Token: 0x06000F8C RID: 3980
		public extern event Delegate98 CdromMediaChange;

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x06000F8D RID: 3981
		// (remove) Token: 0x06000F8E RID: 3982
		public extern event Delegate99 PlaylistChange;

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x06000F8F RID: 3983
		// (remove) Token: 0x06000F90 RID: 3984
		public extern event Delegate100 CurrentPlaylistChange;

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x06000F91 RID: 3985
		// (remove) Token: 0x06000F92 RID: 3986
		public extern event Delegate101 CurrentPlaylistItemAvailable;

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x06000F93 RID: 3987
		// (remove) Token: 0x06000F94 RID: 3988
		public extern event Delegate102 MediaChange;

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x06000F95 RID: 3989
		// (remove) Token: 0x06000F96 RID: 3990
		public extern event Delegate103 CurrentMediaItemAvailable;

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x06000F97 RID: 3991
		// (remove) Token: 0x06000F98 RID: 3992
		public extern event Delegate104 CurrentItemChange;

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x06000F99 RID: 3993
		// (remove) Token: 0x06000F9A RID: 3994
		public extern event Delegate105 MediaCollectionChange;

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x06000F9B RID: 3995
		// (remove) Token: 0x06000F9C RID: 3996
		public extern event Delegate106 MediaCollectionAttributeStringAdded;

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06000F9D RID: 3997
		// (remove) Token: 0x06000F9E RID: 3998
		public extern event Delegate107 MediaCollectionAttributeStringRemoved;

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06000F9F RID: 3999
		// (remove) Token: 0x06000FA0 RID: 4000
		public extern event Delegate108 MediaCollectionAttributeStringChanged;

		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06000FA1 RID: 4001
		// (remove) Token: 0x06000FA2 RID: 4002
		public extern event Delegate109 PlaylistCollectionChange;

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x06000FA3 RID: 4003
		// (remove) Token: 0x06000FA4 RID: 4004
		public extern event Delegate110 PlaylistCollectionPlaylistAdded;

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x06000FA5 RID: 4005
		// (remove) Token: 0x06000FA6 RID: 4006
		public extern event Delegate111 PlaylistCollectionPlaylistRemoved;

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06000FA7 RID: 4007
		// (remove) Token: 0x06000FA8 RID: 4008
		public extern event Delegate112 PlaylistCollectionPlaylistSetAsDeleted;

		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x06000FA9 RID: 4009
		// (remove) Token: 0x06000FAA RID: 4010
		public extern event Delegate113 ModeChange;

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06000FAB RID: 4011
		// (remove) Token: 0x06000FAC RID: 4012
		public extern event Delegate114 MediaError;

		// Token: 0x140000C8 RID: 200
		// (add) Token: 0x06000FAD RID: 4013
		// (remove) Token: 0x06000FAE RID: 4014
		public extern event Delegate115 OpenPlaylistSwitch;

		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x06000FAF RID: 4015
		// (remove) Token: 0x06000FB0 RID: 4016
		public extern event Delegate116 DomainChange;

		// Token: 0x140000CA RID: 202
		// (add) Token: 0x06000FB1 RID: 4017
		// (remove) Token: 0x06000FB2 RID: 4018
		public extern event Delegate117 StringCollectionChange;

		// Token: 0x140000CB RID: 203
		// (add) Token: 0x06000FB3 RID: 4019
		// (remove) Token: 0x06000FB4 RID: 4020
		public extern event Delegate118 MediaCollectionMediaAdded;

		// Token: 0x140000CC RID: 204
		// (add) Token: 0x06000FB5 RID: 4021
		// (remove) Token: 0x06000FB6 RID: 4022
		public extern event Delegate119 MediaCollectionMediaRemoved;
	}
}
