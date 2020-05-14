using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns6;

namespace ns5
{
	// Token: 0x020000C6 RID: 198
	[ComSourceInterfaces("WMPLib.IWMPVideoCtrlEvents\0\0")]
	[ClassInterface(0)]
	[Guid("61CECF11-FC3A-11D2-A1CD-005004602752")]
	[ComImport]
	public sealed class GClass4 : Interface8, GInterface80, GInterface81
	{
		// Token: 0x06000AD0 RID: 2768
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass4();

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000AD2 RID: 2770
		// (set) Token: 0x06000AD1 RID: 2769
		[DispId(5700)]
		public extern bool windowless { [DispId(5700)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5700)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000AD4 RID: 2772
		// (set) Token: 0x06000AD3 RID: 2771
		[DispId(5701)]
		public extern string cursor { [DispId(5701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5701)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000AD6 RID: 2774
		// (set) Token: 0x06000AD5 RID: 2773
		[DispId(5702)]
		public extern string backgroundColor { [DispId(5702)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5702)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000AD8 RID: 2776
		// (set) Token: 0x06000AD7 RID: 2775
		[DispId(5704)]
		public extern bool maintainAspectRatio { [DispId(5704)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5704)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000ADA RID: 2778
		// (set) Token: 0x06000AD9 RID: 2777
		[DispId(5706)]
		public extern string toolTip { [DispId(5706)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5706)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000ADB RID: 2779
		// (set) Token: 0x06000ADC RID: 2780
		[DispId(5707)]
		public extern bool fullScreen { [DispId(5707)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5707)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000ADE RID: 2782
		// (set) Token: 0x06000ADD RID: 2781
		[DispId(5703)]
		public extern bool shrinkToFit { [DispId(5703)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5703)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000AE0 RID: 2784
		// (set) Token: 0x06000ADF RID: 2783
		[DispId(5708)]
		public extern bool stretchToFit { [DispId(5708)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5708)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000AE2 RID: 2786
		// (set) Token: 0x06000AE1 RID: 2785
		[DispId(5709)]
		public extern int zoom { [DispId(5709)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5709)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x06000AE3 RID: 2787
		// (remove) Token: 0x06000AE4 RID: 2788
		public extern event Delegate67 onvideostart;

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06000AE5 RID: 2789
		// (remove) Token: 0x06000AE6 RID: 2790
		public extern event Delegate68 onvideoend;
	}
}
