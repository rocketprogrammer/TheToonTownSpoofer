using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000B7 RID: 183
	[Guid("87291B50-0C8E-11D3-BB2A-00A0C93CA73A")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface71
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060009E4 RID: 2532
		// (set) Token: 0x060009E5 RID: 2533
		[DispId(5102)]
		string image { [DispId(5102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060009E6 RID: 2534
		// (set) Token: 0x060009E7 RID: 2535
		[DispId(5103)]
		string hoverImage { [DispId(5103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060009E8 RID: 2536
		// (set) Token: 0x060009E9 RID: 2537
		[DispId(5104)]
		string downImage { [DispId(5104)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060009EA RID: 2538
		// (set) Token: 0x060009EB RID: 2539
		[DispId(5105)]
		string disabledImage { [DispId(5105)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060009EC RID: 2540
		// (set) Token: 0x060009ED RID: 2541
		[DispId(5106)]
		string hoverDownImage { [DispId(5106)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060009EE RID: 2542
		// (set) Token: 0x060009EF RID: 2543
		[DispId(5107)]
		bool tiled { [DispId(5107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060009F0 RID: 2544
		// (set) Token: 0x060009F1 RID: 2545
		[DispId(5108)]
		string transparencyColor { [DispId(5108)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060009F2 RID: 2546
		// (set) Token: 0x060009F3 RID: 2547
		[DispId(5109)]
		bool down { [DispId(5109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060009F4 RID: 2548
		// (set) Token: 0x060009F5 RID: 2549
		[DispId(5110)]
		bool sticky { [DispId(5110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060009F6 RID: 2550
		// (set) Token: 0x060009F7 RID: 2551
		[DispId(5112)]
		string upToolTip { [DispId(5112)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060009F8 RID: 2552
		// (set) Token: 0x060009F9 RID: 2553
		[DispId(5113)]
		string downToolTip { [DispId(5113)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060009FA RID: 2554
		// (set) Token: 0x060009FB RID: 2555
		[DispId(5114)]
		string cursor { [DispId(5114)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
