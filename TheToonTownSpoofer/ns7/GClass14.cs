using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000E8 RID: 232
	[ClassInterface(0)]
	[Guid("AE3B6831-25A9-11D3-BD41-00C04F6EA5AE")]
	[ComImport]
	public sealed class GClass14 : GInterface101, GInterface102
	{
		// Token: 0x06000C4C RID: 3148
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass14();

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000C4D RID: 3149
		// (set) Token: 0x06000C4E RID: 3150
		[DispId(5300)]
		public extern string image { [DispId(5300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5300)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000C4F RID: 3151
		// (set) Token: 0x06000C50 RID: 3152
		[DispId(5301)]
		public extern string hoverImage { [DispId(5301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5301)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000C51 RID: 3153
		// (set) Token: 0x06000C52 RID: 3154
		[DispId(5302)]
		public extern string downImage { [DispId(5302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5302)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000C53 RID: 3155
		// (set) Token: 0x06000C54 RID: 3156
		[DispId(5303)]
		public extern string hoverDownImage { [DispId(5303)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5303)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000C55 RID: 3157
		// (set) Token: 0x06000C56 RID: 3158
		[DispId(5317)]
		public extern string hoverHoverImage { [DispId(5317)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5317)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000C57 RID: 3159
		// (set) Token: 0x06000C58 RID: 3160
		[DispId(5304)]
		public extern string disabledImage { [DispId(5304)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5304)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000C59 RID: 3161
		// (set) Token: 0x06000C5A RID: 3162
		[DispId(5305)]
		public extern string mappingImage { [DispId(5305)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5305)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000C5B RID: 3163
		// (set) Token: 0x06000C5C RID: 3164
		[DispId(5306)]
		public extern string transparencyColor { [DispId(5306)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5306)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000C5D RID: 3165
		// (set) Token: 0x06000C5E RID: 3166
		[DispId(5308)]
		public extern string cursor { [DispId(5308)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5308)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000C5F RID: 3167
		// (set) Token: 0x06000C60 RID: 3168
		[DispId(5309)]
		public extern bool showBackground { [DispId(5309)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5309)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000C61 RID: 3169
		// (set) Token: 0x06000C62 RID: 3170
		[DispId(5310)]
		public extern bool radio { [DispId(5310)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5310)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000C63 RID: 3171
		[DispId(5311)]
		public extern int buttonCount { [DispId(5311)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C64 RID: 3172
		[DispId(5312)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public extern object imethod_0();

		// Token: 0x06000C65 RID: 3173
		[DispId(5313)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public extern object imethod_1([In] int nButton);

		// Token: 0x06000C66 RID: 3174
		[DispId(5314)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2([In] int nButton);

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000C67 RID: 3175
		// (set) Token: 0x06000C68 RID: 3176
		[DispId(5315)]
		public extern float hueShift { [DispId(5315)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5315)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000C69 RID: 3177
		// (set) Token: 0x06000C6A RID: 3178
		[DispId(5316)]
		public extern float saturation { [DispId(5316)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5316)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
