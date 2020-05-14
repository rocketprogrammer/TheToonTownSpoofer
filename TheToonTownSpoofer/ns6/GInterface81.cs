using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000CB RID: 203
	[Guid("61CECF10-FC3A-11D2-A1CD-005004602752")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface81
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000AF0 RID: 2800
		// (set) Token: 0x06000AEF RID: 2799
		[DispId(5700)]
		bool windowless { [DispId(5700)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5700)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000AF2 RID: 2802
		// (set) Token: 0x06000AF1 RID: 2801
		[DispId(5701)]
		string cursor { [DispId(5701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5701)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000AF4 RID: 2804
		// (set) Token: 0x06000AF3 RID: 2803
		[DispId(5702)]
		string backgroundColor { [DispId(5702)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5702)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000AF6 RID: 2806
		// (set) Token: 0x06000AF5 RID: 2805
		[DispId(5704)]
		bool maintainAspectRatio { [DispId(5704)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5704)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000AF8 RID: 2808
		// (set) Token: 0x06000AF7 RID: 2807
		[DispId(5706)]
		string toolTip { [DispId(5706)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5706)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000AF9 RID: 2809
		// (set) Token: 0x06000AFA RID: 2810
		[DispId(5707)]
		bool fullScreen { [DispId(5707)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5707)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000AFC RID: 2812
		// (set) Token: 0x06000AFB RID: 2811
		[DispId(5703)]
		bool shrinkToFit { [DispId(5703)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5703)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000AFE RID: 2814
		// (set) Token: 0x06000AFD RID: 2813
		[DispId(5708)]
		bool stretchToFit { [DispId(5708)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5708)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000B00 RID: 2816
		// (set) Token: 0x06000AFF RID: 2815
		[DispId(5709)]
		int zoom { [DispId(5709)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5709)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
