using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000BA RID: 186
	[Guid("FC1880CE-83B9-43A7-A066-C44CE8C82583")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface73
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A22 RID: 2594
		// (set) Token: 0x06000A23 RID: 2595
		[DispId(6108)]
		int selectedItem { [DispId(6108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A24 RID: 2596
		// (set) Token: 0x06000A25 RID: 2597
		[DispId(6100)]
		bool sorted { [DispId(6100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A26 RID: 2598
		// (set) Token: 0x06000A27 RID: 2599
		[DispId(6101)]
		bool multiselect { [DispId(6101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A28 RID: 2600
		// (set) Token: 0x06000A29 RID: 2601
		[DispId(6102)]
		bool readOnly { [DispId(6102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A2A RID: 2602
		// (set) Token: 0x06000A2B RID: 2603
		[DispId(6103)]
		string foregroundColor { [DispId(6103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A2C RID: 2604
		// (set) Token: 0x06000A2D RID: 2605
		[DispId(6104)]
		string backgroundColor { [DispId(6104)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A2E RID: 2606
		// (set) Token: 0x06000A2F RID: 2607
		[DispId(6105)]
		int fontSize { [DispId(6105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A30 RID: 2608
		// (set) Token: 0x06000A31 RID: 2609
		[DispId(6106)]
		string fontStyle { [DispId(6106)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A32 RID: 2610
		// (set) Token: 0x06000A33 RID: 2611
		[DispId(6107)]
		string fontFace { [DispId(6107)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A34 RID: 2612
		[DispId(6109)]
		int itemCount { [DispId(6109)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000A35 RID: 2613
		// (set) Token: 0x06000A36 RID: 2614
		[DispId(6110)]
		int firstVisibleItem { [DispId(6110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003D0 RID: 976
		// (set) Token: 0x06000A37 RID: 2615
		[DispId(6120)]
		bool popUp { [DispId(6120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000A38 RID: 2616
		// (set) Token: 0x06000A39 RID: 2617
		[DispId(6121)]
		int focusItem { [DispId(6121)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6121)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000A3A RID: 2618
		// (set) Token: 0x06000A3B RID: 2619
		[DispId(6125)]
		bool border { [DispId(6125)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6125)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000A3C RID: 2620
		[DispId(6111)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([In] int nPos);

		// Token: 0x06000A3D RID: 2621
		[DispId(6112)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] int nPos, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A3E RID: 2622
		[DispId(6113)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A3F RID: 2623
		[DispId(6114)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int nPos, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A40 RID: 2624
		[DispId(6115)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([In] int nPos);

		// Token: 0x06000A41 RID: 2625
		[DispId(6116)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x06000A42 RID: 2626
		[DispId(6117)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_6([In] int nStartIndex, [MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000A43 RID: 2627
		[DispId(6118)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_7([In] int nStartIndex);

		// Token: 0x06000A44 RID: 2628
		[DispId(6122)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([In] int nPos, [In] bool vbSelected);

		// Token: 0x06000A45 RID: 2629
		[DispId(6123)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9();

		// Token: 0x06000A46 RID: 2630
		[DispId(6124)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10();
	}
}
