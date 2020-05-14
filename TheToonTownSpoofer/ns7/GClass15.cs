using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000EC RID: 236
	[ClassInterface(0)]
	[ComSourceInterfaces("WMPLib.IWMPRegionalButtonEvents\0\0")]
	[Guid("09AEFF11-69EF-11D3-BD4D-00C04F6EA5AE")]
	[ComImport]
	public sealed class GClass15 : Interface9, GInterface104, GInterface105
	{
		// Token: 0x06000C95 RID: 3221
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass15();

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000C96 RID: 3222
		// (set) Token: 0x06000C97 RID: 3223
		[DispId(5330)]
		public extern string upToolTip { [DispId(5330)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5330)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000C98 RID: 3224
		// (set) Token: 0x06000C99 RID: 3225
		[DispId(5331)]
		public extern string downToolTip { [DispId(5331)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5331)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000C9A RID: 3226
		// (set) Token: 0x06000C9B RID: 3227
		[DispId(5332)]
		public extern string mappingColor { [DispId(5332)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5332)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000C9C RID: 3228
		// (set) Token: 0x06000C9D RID: 3229
		[DispId(5333)]
		public extern bool enabled { [DispId(5333)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5333)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000C9E RID: 3230
		// (set) Token: 0x06000C9F RID: 3231
		[DispId(5339)]
		public extern bool sticky { [DispId(5339)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5339)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000CA0 RID: 3232
		// (set) Token: 0x06000CA1 RID: 3233
		[DispId(5340)]
		public extern bool down { [DispId(5340)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5340)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000CA2 RID: 3234
		[DispId(5341)]
		public extern int index { [DispId(5341)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000CA3 RID: 3235
		// (set) Token: 0x06000CA4 RID: 3236
		[DispId(5342)]
		public extern bool tabStop { [DispId(5342)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5342)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000CA5 RID: 3237
		// (set) Token: 0x06000CA6 RID: 3238
		[DispId(5343)]
		public extern string cursor { [DispId(5343)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5343)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000CA7 RID: 3239
		[DispId(5344)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000CA8 RID: 3240
		// (set) Token: 0x06000CA9 RID: 3241
		[DispId(5345)]
		public extern string accName { [DispId(5345)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5345)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CAA RID: 3242
		// (set) Token: 0x06000CAB RID: 3243
		[DispId(5346)]
		public extern string accDescription { [DispId(5346)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5346)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000CAC RID: 3244
		// (set) Token: 0x06000CAD RID: 3245
		[DispId(5347)]
		public extern string accKeyboardShortcut { [DispId(5347)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5347)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06000CAE RID: 3246
		// (remove) Token: 0x06000CAF RID: 3247
		public extern event Delegate69 onblur;

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06000CB0 RID: 3248
		// (remove) Token: 0x06000CB1 RID: 3249
		public extern event Delegate70 onfocus;

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x06000CB2 RID: 3250
		// (remove) Token: 0x06000CB3 RID: 3251
		public extern event Delegate71 onclick;

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x06000CB4 RID: 3252
		// (remove) Token: 0x06000CB5 RID: 3253
		public extern event Delegate72 ondblclick;

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x06000CB6 RID: 3254
		// (remove) Token: 0x06000CB7 RID: 3255
		public extern event Delegate73 onmousedown;

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06000CB8 RID: 3256
		// (remove) Token: 0x06000CB9 RID: 3257
		public extern event Delegate74 onmouseup;

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x06000CBA RID: 3258
		// (remove) Token: 0x06000CBB RID: 3259
		public extern event Delegate75 onmousemove;

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06000CBC RID: 3260
		// (remove) Token: 0x06000CBD RID: 3261
		public extern event Delegate76 onmouseover;

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06000CBE RID: 3262
		// (remove) Token: 0x06000CBF RID: 3263
		public extern event Delegate77 onmouseout;

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000CC0 RID: 3264
		// (remove) Token: 0x06000CC1 RID: 3265
		public extern event Delegate78 onkeypress;

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000CC2 RID: 3266
		// (remove) Token: 0x06000CC3 RID: 3267
		public extern event Delegate79 onkeydown;

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06000CC4 RID: 3268
		// (remove) Token: 0x06000CC5 RID: 3269
		public extern event Delegate80 onkeyup;
	}
}
