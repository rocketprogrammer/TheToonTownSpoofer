using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns8
{
	// Token: 0x02000106 RID: 262
	[Guid("237DAC8E-0E32-11D3-A2E2-00C04F79F88E")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface110
	{
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000D80 RID: 3456
		// (set) Token: 0x06000D81 RID: 3457
		[DispId(5201)]
		string backgroundColor { [DispId(5201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000D82 RID: 3458
		// (set) Token: 0x06000D83 RID: 3459
		[DispId(5206)]
		string fontFace { [DispId(5206)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000D84 RID: 3460
		// (set) Token: 0x06000D85 RID: 3461
		[DispId(5207)]
		string fontStyle { [DispId(5207)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000D86 RID: 3462
		// (set) Token: 0x06000D87 RID: 3463
		[DispId(5208)]
		int fontSize { [DispId(5208)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5208)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000D88 RID: 3464
		// (set) Token: 0x06000D89 RID: 3465
		[DispId(5209)]
		string foregroundColor { [DispId(5209)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5209)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000D8A RID: 3466
		// (set) Token: 0x06000D8B RID: 3467
		[DispId(5210)]
		string hoverBackgroundColor { [DispId(5210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000D8C RID: 3468
		// (set) Token: 0x06000D8D RID: 3469
		[DispId(5211)]
		string hoverForegroundColor { [DispId(5211)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000D8E RID: 3470
		// (set) Token: 0x06000D8F RID: 3471
		[DispId(5212)]
		string hoverFontStyle { [DispId(5212)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000D90 RID: 3472
		// (set) Token: 0x06000D91 RID: 3473
		[DispId(5213)]
		string value { [DispId(5213)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000D92 RID: 3474
		// (set) Token: 0x06000D93 RID: 3475
		[DispId(5214)]
		string toolTip { [DispId(5214)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5214)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000D94 RID: 3476
		// (set) Token: 0x06000D95 RID: 3477
		[DispId(5215)]
		string disabledFontStyle { [DispId(5215)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000D96 RID: 3478
		// (set) Token: 0x06000D97 RID: 3479
		[DispId(5216)]
		string disabledForegroundColor { [DispId(5216)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000D98 RID: 3480
		// (set) Token: 0x06000D99 RID: 3481
		[DispId(5217)]
		string disabledBackgroundColor { [DispId(5217)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000D9A RID: 3482
		// (set) Token: 0x06000D9B RID: 3483
		[DispId(5221)]
		bool fontSmoothing { [DispId(5221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000D9C RID: 3484
		// (set) Token: 0x06000D9D RID: 3485
		[DispId(5222)]
		string justification { [DispId(5222)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000D9E RID: 3486
		// (set) Token: 0x06000D9F RID: 3487
		[DispId(5223)]
		bool wordWrap { [DispId(5223)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DA0 RID: 3488
		// (set) Token: 0x06000DA1 RID: 3489
		[DispId(5224)]
		string cursor { [DispId(5224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DA2 RID: 3490
		// (set) Token: 0x06000DA3 RID: 3491
		[DispId(5225)]
		bool scrolling { [DispId(5225)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DA4 RID: 3492
		// (set) Token: 0x06000DA5 RID: 3493
		[DispId(5226)]
		string scrollingDirection { [DispId(5226)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5226)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DA6 RID: 3494
		// (set) Token: 0x06000DA7 RID: 3495
		[DispId(5227)]
		int scrollingDelay { [DispId(5227)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000DA8 RID: 3496
		// (set) Token: 0x06000DA9 RID: 3497
		[DispId(5228)]
		int scrollingAmount { [DispId(5228)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000DAA RID: 3498
		[DispId(5229)]
		int textWidth { [DispId(5229)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000DAB RID: 3499
		// (set) Token: 0x06000DAC RID: 3500
		[DispId(5230)]
		bool onGlass { [DispId(5230)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000DAD RID: 3501
		// (set) Token: 0x06000DAE RID: 3502
		[DispId(5231)]
		bool disableGlassBlurBackground { [DispId(5231)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
