using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000CC RID: 204
	[ClassInterface(0)]
	[Guid("47DEA830-D619-4154-B8D8-6B74845D6A2D")]
	[ComImport]
	public sealed class GClass5 : GInterface82, GInterface83
	{
		// Token: 0x06000B01 RID: 2817
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass5();

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000B02 RID: 2818
		// (set) Token: 0x06000B03 RID: 2819
		[DispId(5500)]
		public extern bool windowed { [DispId(5500)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5500)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000B04 RID: 2820
		// (set) Token: 0x06000B05 RID: 2821
		[DispId(5501)]
		public extern bool allowAll { [DispId(5501)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5501)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000B07 RID: 2823
		// (set) Token: 0x06000B06 RID: 2822
		[DispId(5507)]
		public extern string currentEffectType { [DispId(5507)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5507)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000B08 RID: 2824
		[DispId(5506)]
		public extern string currentEffectTitle { [DispId(5506)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000B09 RID: 2825
		[DispId(5502)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x06000B0A RID: 2826
		[DispId(5503)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1();

		// Token: 0x06000B0B RID: 2827
		[DispId(5504)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000B0C RID: 2828
		// (set) Token: 0x06000B0D RID: 2829
		[DispId(5505)]
		public extern object currentEffect { [DispId(5505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(5505)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x06000B0E RID: 2830
		[DispId(5509)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3();

		// Token: 0x06000B0F RID: 2831
		[DispId(5510)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4();

		// Token: 0x06000B10 RID: 2832
		[DispId(5511)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5();

		// Token: 0x06000B11 RID: 2833
		[DispId(5512)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_6();

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000B12 RID: 2834
		// (set) Token: 0x06000B13 RID: 2835
		[DispId(5513)]
		public extern int currentPreset { [DispId(5513)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5513)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000B14 RID: 2836
		[DispId(5514)]
		public extern string currentPresetTitle { [DispId(5514)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000B15 RID: 2837
		[DispId(5515)]
		public extern int currentEffectPresetCount { [DispId(5515)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000B16 RID: 2838
		// (set) Token: 0x06000B17 RID: 2839
		[DispId(5516)]
		public extern bool fullScreen { [DispId(5516)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5516)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000B18 RID: 2840
		[DispId(5517)]
		public extern bool effectCanGoFullScreen { [DispId(5517)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000B19 RID: 2841
		[DispId(5518)]
		public extern bool effectHasPropertyPage { [DispId(5518)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000B1A RID: 2842
		[DispId(5520)]
		public extern int effectCount { [DispId(5520)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000B1B RID: 2843
		[DispId(5521)]
		public extern string effectTitle { [DispId(5521)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000B1C RID: 2844
		[DispId(5522)]
		public extern string effectType { [DispId(5522)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
