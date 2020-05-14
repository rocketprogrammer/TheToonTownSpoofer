using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns4;

namespace ns8
{
	// Token: 0x02000107 RID: 263
	[Guid("5F9CFD93-8CAD-11D3-9A7E-00C04F8EFB70")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass18 : GInterface55, GInterface111
	{
		// Token: 0x06000DAF RID: 3503
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass18();

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000DB0 RID: 3504
		// (set) Token: 0x06000DB1 RID: 3505
		[DispId(5601)]
		public extern GInterface6 Playlist { [DispId(5601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(5601)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000DB2 RID: 3506
		// (set) Token: 0x06000DB3 RID: 3507
		[DispId(5602)]
		public extern string columns { [DispId(5602)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5602)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000DB4 RID: 3508
		[DispId(5603)]
		public extern int columnCount { [DispId(5603)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000DB5 RID: 3509
		// (set) Token: 0x06000DB6 RID: 3510
		[DispId(5604)]
		public extern string columnOrder { [DispId(5604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5604)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DB7 RID: 3511
		// (set) Token: 0x06000DB8 RID: 3512
		[DispId(5605)]
		public extern bool columnsVisible { [DispId(5605)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5605)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000DB9 RID: 3513
		// (set) Token: 0x06000DBA RID: 3514
		[DispId(5607)]
		public extern bool dropDownVisible { [DispId(5607)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5607)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000DBB RID: 3515
		// (set) Token: 0x06000DBC RID: 3516
		[DispId(5608)]
		public extern bool playlistItemsVisible { [DispId(5608)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5608)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000DBD RID: 3517
		// (set) Token: 0x06000DBE RID: 3518
		[DispId(5609)]
		public extern bool checkboxesVisible { [DispId(5609)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5609)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000DBF RID: 3519
		// (set) Token: 0x06000DC0 RID: 3520
		[DispId(5612)]
		public extern string backgroundColor { [DispId(5612)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5612)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000DC1 RID: 3521
		// (set) Token: 0x06000DC2 RID: 3522
		[DispId(5613)]
		public extern string foregroundColor { [DispId(5613)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5613)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000DC3 RID: 3523
		// (set) Token: 0x06000DC4 RID: 3524
		[DispId(5614)]
		public extern string disabledItemColor { [DispId(5614)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5614)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000DC5 RID: 3525
		// (set) Token: 0x06000DC6 RID: 3526
		[DispId(5615)]
		public extern string itemPlayingColor { [DispId(5615)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5615)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000DC7 RID: 3527
		// (set) Token: 0x06000DC8 RID: 3528
		[DispId(5616)]
		public extern string itemPlayingBackgroundColor { [DispId(5616)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5616)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000DC9 RID: 3529
		// (set) Token: 0x06000DCA RID: 3530
		[DispId(5617)]
		public extern string backgroundImage { [DispId(5617)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5617)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000DCB RID: 3531
		// (set) Token: 0x06000DCC RID: 3532
		[DispId(5618)]
		public extern bool allowItemEditing { [DispId(5618)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5618)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000DCD RID: 3533
		// (set) Token: 0x06000DCE RID: 3534
		[DispId(5619)]
		public extern bool allowColumnSorting { [DispId(5619)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5619)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000DCF RID: 3535
		// (set) Token: 0x06000DD0 RID: 3536
		[DispId(5620)]
		public extern string dropDownList { [DispId(5620)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5620)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000DD1 RID: 3537
		// (set) Token: 0x06000DD2 RID: 3538
		[DispId(5621)]
		public extern string dropDownToolTip { [DispId(5621)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5621)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000DD3 RID: 3539
		// (set) Token: 0x06000DD4 RID: 3540
		[DispId(5622)]
		public extern bool copying { [DispId(5622)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5622)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000DD5 RID: 3541
		[DispId(5623)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x06000DD6 RID: 3542
		[DispId(5624)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1();

		// Token: 0x06000DD7 RID: 3543
		[DispId(5625)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x06000DD8 RID: 3544
		[DispId(5626)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3();

		// Token: 0x06000DD9 RID: 3545
		[DispId(5628)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4();

		// Token: 0x06000DDA RID: 3546
		[DispId(5629)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5();

		// Token: 0x06000DDB RID: 3547
		[DispId(5630)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pdispPlaylist);

		// Token: 0x06000DDC RID: 3548
		[DispId(5631)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_7([In] int nStartIndex);

		// Token: 0x06000DDD RID: 3549
		[DispId(5632)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_8([In] int nStartIndex);

		// Token: 0x06000DDE RID: 3550
		[DispId(5633)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_9([In] int nIndex, [In] bool vbSelected);

		// Token: 0x06000DDF RID: 3551
		[DispId(5634)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_10([In] int nIndex, [In] bool vbChecked);

		// Token: 0x06000DE0 RID: 3552
		[DispId(5635)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_11([In] int nIndex);

		// Token: 0x06000DE1 RID: 3553
		[DispId(5636)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_12([In] int nIndex, [MarshalAs(UnmanagedType.BStr)] [In] string newMode);

		// Token: 0x06000DE2 RID: 3554
		[DispId(5637)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_13([In] int nIndex, [In] int nWidth);

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000DE3 RID: 3555
		// (set) Token: 0x06000DE4 RID: 3556
		[DispId(5642)]
		public extern string itemErrorColor { [DispId(5642)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5642)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000DE5 RID: 3557
		[DispId(5643)]
		public extern int itemCount { [DispId(5643)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000DE6 RID: 3558
		[DispId(5644)]
		public extern GInterface7 itemMedia { [DispId(5644)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000DE7 RID: 3559
		[DispId(5645)]
		public extern GInterface6 itemPlaylist { [DispId(5645)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000DE8 RID: 3560
		[DispId(5646)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_14([In] int nStartIndex);

		// Token: 0x06000DE9 RID: 3561
		[DispId(5647)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_15([In] int nStartIndex);

		// Token: 0x06000DEA RID: 3562
		[DispId(5648)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_16([In] int nIndex, [In] bool vbSelected);

		// Token: 0x06000DEB RID: 3563
		[DispId(5649)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_17([In] int nIndex, [In] bool vbChecked);

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000DEC RID: 3564
		// (set) Token: 0x06000DED RID: 3565
		[DispId(5650)]
		public extern string leftStatus { [DispId(5650)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5650)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000DEE RID: 3566
		// (set) Token: 0x06000DEF RID: 3567
		[DispId(5651)]
		public extern string rightStatus { [DispId(5651)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5651)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000DF0 RID: 3568
		// (set) Token: 0x06000DF1 RID: 3569
		[DispId(5652)]
		public extern bool editButtonVisible { [DispId(5652)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5652)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000DF2 RID: 3570
		// (set) Token: 0x06000DF3 RID: 3571
		[DispId(5653)]
		public extern string dropDownImage { [DispId(5653)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5653)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000DF4 RID: 3572
		// (set) Token: 0x06000DF5 RID: 3573
		[DispId(5654)]
		public extern string dropDownBackgroundImage { [DispId(5654)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5654)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000DF6 RID: 3574
		// (set) Token: 0x06000DF7 RID: 3575
		[DispId(5655)]
		public extern float hueShift { [DispId(5655)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5655)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000DF8 RID: 3576
		// (set) Token: 0x06000DF9 RID: 3577
		[DispId(5656)]
		public extern float saturation { [DispId(5656)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5656)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000DFA RID: 3578
		// (set) Token: 0x06000DFB RID: 3579
		[DispId(5658)]
		public extern string statusColor { [DispId(5658)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5658)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000DFC RID: 3580
		// (set) Token: 0x06000DFD RID: 3581
		[DispId(5660)]
		public extern bool toolbarVisible { [DispId(5660)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5660)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000DFE RID: 3582
		// (set) Token: 0x06000DFF RID: 3583
		[DispId(5662)]
		public extern string itemSelectedColor { [DispId(5662)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5662)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E00 RID: 3584
		// (set) Token: 0x06000E01 RID: 3585
		[DispId(5663)]
		public extern string itemSelectedFocusLostColor { [DispId(5663)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5663)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E02 RID: 3586
		// (set) Token: 0x06000E03 RID: 3587
		[DispId(5664)]
		public extern string itemSelectedBackgroundColor { [DispId(5664)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5664)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E04 RID: 3588
		// (set) Token: 0x06000E05 RID: 3589
		[DispId(5665)]
		public extern string itemSelectedBackgroundFocusLostColor { [DispId(5665)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5665)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E06 RID: 3590
		// (set) Token: 0x06000E07 RID: 3591
		[DispId(5666)]
		public extern string backgroundSplitColor { [DispId(5666)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5666)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E08 RID: 3592
		// (set) Token: 0x06000E09 RID: 3593
		[DispId(5667)]
		public extern string statusTextColor { [DispId(5667)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5667)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
