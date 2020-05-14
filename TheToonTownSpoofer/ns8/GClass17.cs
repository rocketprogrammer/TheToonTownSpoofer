using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns8
{
	// Token: 0x02000104 RID: 260
	[Guid("DDDA102E-0E17-11D3-A2E2-00C04F79F88E")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass17 : GInterface109, GInterface110
	{
		// Token: 0x06000D50 RID: 3408
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass17();

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D51 RID: 3409
		// (set) Token: 0x06000D52 RID: 3410
		[DispId(5201)]
		public extern string backgroundColor { [DispId(5201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5201)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D53 RID: 3411
		// (set) Token: 0x06000D54 RID: 3412
		[DispId(5206)]
		public extern string fontFace { [DispId(5206)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D55 RID: 3413
		// (set) Token: 0x06000D56 RID: 3414
		[DispId(5207)]
		public extern string fontStyle { [DispId(5207)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5207)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D57 RID: 3415
		// (set) Token: 0x06000D58 RID: 3416
		[DispId(5208)]
		public extern int fontSize { [DispId(5208)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5208)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D59 RID: 3417
		// (set) Token: 0x06000D5A RID: 3418
		[DispId(5209)]
		public extern string foregroundColor { [DispId(5209)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5209)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D5B RID: 3419
		// (set) Token: 0x06000D5C RID: 3420
		[DispId(5210)]
		public extern string hoverBackgroundColor { [DispId(5210)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5210)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D5D RID: 3421
		// (set) Token: 0x06000D5E RID: 3422
		[DispId(5211)]
		public extern string hoverForegroundColor { [DispId(5211)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5211)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D5F RID: 3423
		// (set) Token: 0x06000D60 RID: 3424
		[DispId(5212)]
		public extern string hoverFontStyle { [DispId(5212)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000D61 RID: 3425
		// (set) Token: 0x06000D62 RID: 3426
		[DispId(5213)]
		public extern string value { [DispId(5213)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5213)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D63 RID: 3427
		// (set) Token: 0x06000D64 RID: 3428
		[DispId(5214)]
		public extern string toolTip { [DispId(5214)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5214)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D65 RID: 3429
		// (set) Token: 0x06000D66 RID: 3430
		[DispId(5215)]
		public extern string disabledFontStyle { [DispId(5215)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5215)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000D67 RID: 3431
		// (set) Token: 0x06000D68 RID: 3432
		[DispId(5216)]
		public extern string disabledForegroundColor { [DispId(5216)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000D69 RID: 3433
		// (set) Token: 0x06000D6A RID: 3434
		[DispId(5217)]
		public extern string disabledBackgroundColor { [DispId(5217)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5217)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000D6B RID: 3435
		// (set) Token: 0x06000D6C RID: 3436
		[DispId(5221)]
		public extern bool fontSmoothing { [DispId(5221)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5221)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000D6D RID: 3437
		// (set) Token: 0x06000D6E RID: 3438
		[DispId(5222)]
		public extern string justification { [DispId(5222)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5222)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000D6F RID: 3439
		// (set) Token: 0x06000D70 RID: 3440
		[DispId(5223)]
		public extern bool wordWrap { [DispId(5223)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5223)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000D71 RID: 3441
		// (set) Token: 0x06000D72 RID: 3442
		[DispId(5224)]
		public extern string cursor { [DispId(5224)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5224)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000D73 RID: 3443
		// (set) Token: 0x06000D74 RID: 3444
		[DispId(5225)]
		public extern bool scrolling { [DispId(5225)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5225)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000D75 RID: 3445
		// (set) Token: 0x06000D76 RID: 3446
		[DispId(5226)]
		public extern string scrollingDirection { [DispId(5226)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5226)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000D77 RID: 3447
		// (set) Token: 0x06000D78 RID: 3448
		[DispId(5227)]
		public extern int scrollingDelay { [DispId(5227)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5227)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000D79 RID: 3449
		// (set) Token: 0x06000D7A RID: 3450
		[DispId(5228)]
		public extern int scrollingAmount { [DispId(5228)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5228)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000D7B RID: 3451
		[DispId(5229)]
		public extern int textWidth { [DispId(5229)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000D7C RID: 3452
		// (set) Token: 0x06000D7D RID: 3453
		[DispId(5230)]
		public extern bool onGlass { [DispId(5230)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5230)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000D7E RID: 3454
		// (set) Token: 0x06000D7F RID: 3455
		[DispId(5231)]
		public extern bool disableGlassBlurBackground { [DispId(5231)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5231)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
