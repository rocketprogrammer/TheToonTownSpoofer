using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000EA RID: 234
	[TypeLibType(4160)]
	[Guid("58D507B1-2354-11D3-BD41-00C04F6EA5AE")]
	[ComImport]
	public interface GInterface102
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000C6B RID: 3179
		// (set) Token: 0x06000C6C RID: 3180
		[DispId(5300)]
		string image { [DispId(5300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5300)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000C6D RID: 3181
		// (set) Token: 0x06000C6E RID: 3182
		[DispId(5301)]
		string hoverImage { [DispId(5301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5301)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000C6F RID: 3183
		// (set) Token: 0x06000C70 RID: 3184
		[DispId(5302)]
		string downImage { [DispId(5302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5302)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000C71 RID: 3185
		// (set) Token: 0x06000C72 RID: 3186
		[DispId(5303)]
		string hoverDownImage { [DispId(5303)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5303)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000C73 RID: 3187
		// (set) Token: 0x06000C74 RID: 3188
		[DispId(5317)]
		string hoverHoverImage { [DispId(5317)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5317)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000C75 RID: 3189
		// (set) Token: 0x06000C76 RID: 3190
		[DispId(5304)]
		string disabledImage { [DispId(5304)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5304)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000C77 RID: 3191
		// (set) Token: 0x06000C78 RID: 3192
		[DispId(5305)]
		string mappingImage { [DispId(5305)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5305)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000C79 RID: 3193
		// (set) Token: 0x06000C7A RID: 3194
		[DispId(5306)]
		string transparencyColor { [DispId(5306)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5306)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000C7B RID: 3195
		// (set) Token: 0x06000C7C RID: 3196
		[DispId(5308)]
		string cursor { [DispId(5308)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5308)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000C7D RID: 3197
		// (set) Token: 0x06000C7E RID: 3198
		[DispId(5309)]
		bool showBackground { [DispId(5309)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5309)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000C7F RID: 3199
		// (set) Token: 0x06000C80 RID: 3200
		[DispId(5310)]
		bool radio { [DispId(5310)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5310)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000C81 RID: 3201
		[DispId(5311)]
		int buttonCount { [DispId(5311)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C82 RID: 3202
		[DispId(5312)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object imethod_0();

		// Token: 0x06000C83 RID: 3203
		[DispId(5313)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object imethod_1([In] int nButton);

		// Token: 0x06000C84 RID: 3204
		[DispId(5314)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] int nButton);

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000C85 RID: 3205
		// (set) Token: 0x06000C86 RID: 3206
		[DispId(5315)]
		float hueShift { [DispId(5315)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5315)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000C87 RID: 3207
		// (set) Token: 0x06000C88 RID: 3208
		[DispId(5316)]
		float saturation { [DispId(5316)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5316)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
