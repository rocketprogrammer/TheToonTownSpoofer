using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000B8 RID: 184
	[ClassInterface(0)]
	[Guid("FC1880CF-83B9-43A7-A066-C44CE8C82583")]
	[ComImport]
	public sealed class GClass2 : GInterface72, GInterface73
	{
		// Token: 0x060009FC RID: 2556
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass2();

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060009FD RID: 2557
		// (set) Token: 0x060009FE RID: 2558
		[DispId(6108)]
		public extern int selectedItem { [DispId(6108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060009FF RID: 2559
		// (set) Token: 0x06000A00 RID: 2560
		[DispId(6100)]
		public extern bool sorted { [DispId(6100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A01 RID: 2561
		// (set) Token: 0x06000A02 RID: 2562
		[DispId(6101)]
		public extern bool multiselect { [DispId(6101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A03 RID: 2563
		// (set) Token: 0x06000A04 RID: 2564
		[DispId(6102)]
		public extern bool readOnly { [DispId(6102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A05 RID: 2565
		// (set) Token: 0x06000A06 RID: 2566
		[DispId(6103)]
		public extern string foregroundColor { [DispId(6103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A07 RID: 2567
		// (set) Token: 0x06000A08 RID: 2568
		[DispId(6104)]
		public extern string backgroundColor { [DispId(6104)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A09 RID: 2569
		// (set) Token: 0x06000A0A RID: 2570
		[DispId(6105)]
		public extern int fontSize { [DispId(6105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A0B RID: 2571
		// (set) Token: 0x06000A0C RID: 2572
		[DispId(6106)]
		public extern string fontStyle { [DispId(6106)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A0D RID: 2573
		// (set) Token: 0x06000A0E RID: 2574
		[DispId(6107)]
		public extern string fontFace { [DispId(6107)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A0F RID: 2575
		[DispId(6109)]
		public extern int itemCount { [DispId(6109)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A10 RID: 2576
		// (set) Token: 0x06000A11 RID: 2577
		[DispId(6110)]
		public extern int firstVisibleItem { [DispId(6110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C2 RID: 962
		// (set) Token: 0x06000A12 RID: 2578
		[DispId(6120)]
		public extern bool popUp { [DispId(6120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A13 RID: 2579
		// (set) Token: 0x06000A14 RID: 2580
		[DispId(6121)]
		public extern int focusItem { [DispId(6121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A15 RID: 2581
		// (set) Token: 0x06000A16 RID: 2582
		[DispId(6125)]
		public extern bool border { [DispId(6125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000A17 RID: 2583
		[DispId(6111)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([In] int nPos);

		// Token: 0x06000A18 RID: 2584
		[DispId(6112)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([In] int nPos, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A19 RID: 2585
		[DispId(6113)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A1A RID: 2586
		[DispId(6114)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3([In] int nPos, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A1B RID: 2587
		[DispId(6115)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4([In] int nPos);

		// Token: 0x06000A1C RID: 2588
		[DispId(6116)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5();

		// Token: 0x06000A1D RID: 2589
		[DispId(6117)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_6([In] int nStartIndex, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A1E RID: 2590
		[DispId(6118)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_7([In] int nStartIndex);

		// Token: 0x06000A1F RID: 2591
		[DispId(6122)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_8([In] int nPos, [In] bool vbSelected);

		// Token: 0x06000A20 RID: 2592
		[DispId(6123)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_9();

		// Token: 0x06000A21 RID: 2593
		[DispId(6124)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_10();
	}
}
