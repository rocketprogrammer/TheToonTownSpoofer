using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000B3 RID: 179
	[ComSourceInterfaces("WMPLib.IWMPButtonCtrlEvents\0\0")]
	[Guid("87291B51-0C8E-11D3-BB2A-00A0C93CA73A")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass1 : Interface6, GInterface70, GInterface71
	{
		// Token: 0x060009C5 RID: 2501
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass1();

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060009C6 RID: 2502
		// (set) Token: 0x060009C7 RID: 2503
		[DispId(5102)]
		public extern string image { [DispId(5102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060009C8 RID: 2504
		// (set) Token: 0x060009C9 RID: 2505
		[DispId(5103)]
		public extern string hoverImage { [DispId(5103)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060009CA RID: 2506
		// (set) Token: 0x060009CB RID: 2507
		[DispId(5104)]
		public extern string downImage { [DispId(5104)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060009CC RID: 2508
		// (set) Token: 0x060009CD RID: 2509
		[DispId(5105)]
		public extern string disabledImage { [DispId(5105)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060009CE RID: 2510
		// (set) Token: 0x060009CF RID: 2511
		[DispId(5106)]
		public extern string hoverDownImage { [DispId(5106)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060009D0 RID: 2512
		// (set) Token: 0x060009D1 RID: 2513
		[DispId(5107)]
		public extern bool tiled { [DispId(5107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060009D2 RID: 2514
		// (set) Token: 0x060009D3 RID: 2515
		[DispId(5108)]
		public extern string transparencyColor { [DispId(5108)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060009D4 RID: 2516
		// (set) Token: 0x060009D5 RID: 2517
		[DispId(5109)]
		public extern bool down { [DispId(5109)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060009D6 RID: 2518
		// (set) Token: 0x060009D7 RID: 2519
		[DispId(5110)]
		public extern bool sticky { [DispId(5110)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5110)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060009D8 RID: 2520
		// (set) Token: 0x060009D9 RID: 2521
		[DispId(5112)]
		public extern string upToolTip { [DispId(5112)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060009DA RID: 2522
		// (set) Token: 0x060009DB RID: 2523
		[DispId(5113)]
		public extern string downToolTip { [DispId(5113)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5113)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060009DC RID: 2524
		// (set) Token: 0x060009DD RID: 2525
		[DispId(5114)]
		public extern string cursor { [DispId(5114)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5114)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x060009DE RID: 2526
		// (remove) Token: 0x060009DF RID: 2527
		public extern event Delegate63 onclick;
	}
}
