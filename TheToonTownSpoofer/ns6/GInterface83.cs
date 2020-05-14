using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000CE RID: 206
	[TypeLibType(4160)]
	[Guid("A9EFAB80-0A60-4C3F-BBD1-4558DD2A9769")]
	[ComImport]
	public interface GInterface83
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000B1D RID: 2845
		// (set) Token: 0x06000B1E RID: 2846
		[DispId(5500)]
		bool windowed { [DispId(5500)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5500)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B1F RID: 2847
		// (set) Token: 0x06000B20 RID: 2848
		[DispId(5501)]
		bool allowAll { [DispId(5501)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5501)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B22 RID: 2850
		// (set) Token: 0x06000B21 RID: 2849
		[DispId(5507)]
		string currentEffectType { [DispId(5507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5507)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B23 RID: 2851
		[DispId(5506)]
		string currentEffectTitle { [DispId(5506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000B24 RID: 2852
		[DispId(5502)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x06000B25 RID: 2853
		[DispId(5503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x06000B26 RID: 2854
		[DispId(5504)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B27 RID: 2855
		// (set) Token: 0x06000B28 RID: 2856
		[DispId(5505)]
		object currentEffect { [DispId(5505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(5505)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x06000B29 RID: 2857
		[DispId(5509)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x06000B2A RID: 2858
		[DispId(5510)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x06000B2B RID: 2859
		[DispId(5511)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x06000B2C RID: 2860
		[DispId(5512)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6();

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B2D RID: 2861
		// (set) Token: 0x06000B2E RID: 2862
		[DispId(5513)]
		int currentPreset { [DispId(5513)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5513)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B2F RID: 2863
		[DispId(5514)]
		string currentPresetTitle { [DispId(5514)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B30 RID: 2864
		[DispId(5515)]
		int currentEffectPresetCount { [DispId(5515)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B31 RID: 2865
		// (set) Token: 0x06000B32 RID: 2866
		[DispId(5516)]
		bool fullScreen { [DispId(5516)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5516)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B33 RID: 2867
		[DispId(5517)]
		bool effectCanGoFullScreen { [DispId(5517)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B34 RID: 2868
		[DispId(5518)]
		bool effectHasPropertyPage { [DispId(5518)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B35 RID: 2869
		[DispId(5520)]
		int effectCount { [DispId(5520)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B36 RID: 2870
		[DispId(5521)]
		string effectTitle { [DispId(5521)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B37 RID: 2871
		[DispId(5522)]
		string effectType { [DispId(5522)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
