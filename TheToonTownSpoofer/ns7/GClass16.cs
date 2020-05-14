using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000FD RID: 253
	[Guid("95F45AA3-ED0A-11D2-BA67-0000F80855E6")]
	[ComSourceInterfaces("WMPLib.IWMPCustomSliderCtrlEvents\0\0")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass16 : Interface10, GInterface107, GInterface108
	{
		// Token: 0x06000D11 RID: 3345
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass16();

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D12 RID: 3346
		// (set) Token: 0x06000D13 RID: 3347
		[DispId(5009)]
		public extern string cursor { [DispId(5009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D14 RID: 3348
		// (set) Token: 0x06000D15 RID: 3349
		[DispId(5005)]
		public extern float min { [DispId(5005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D16 RID: 3350
		// (set) Token: 0x06000D17 RID: 3351
		[DispId(5006)]
		public extern float max { [DispId(5006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D18 RID: 3352
		// (set) Token: 0x06000D19 RID: 3353
		[DispId(5010)]
		public extern float value { [DispId(5010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D1A RID: 3354
		// (set) Token: 0x06000D1B RID: 3355
		[DispId(5011)]
		public extern string toolTip { [DispId(5011)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5011)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D1C RID: 3356
		// (set) Token: 0x06000D1D RID: 3357
		[DispId(5002)]
		public extern string positionImage { [DispId(5002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D1E RID: 3358
		// (set) Token: 0x06000D1F RID: 3359
		[DispId(5001)]
		public extern string image { [DispId(5001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D20 RID: 3360
		// (set) Token: 0x06000D21 RID: 3361
		[DispId(5003)]
		public extern string hoverImage { [DispId(5003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D22 RID: 3362
		// (set) Token: 0x06000D23 RID: 3363
		[DispId(5004)]
		public extern string disabledImage { [DispId(5004)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D24 RID: 3364
		// (set) Token: 0x06000D25 RID: 3365
		[DispId(5012)]
		public extern string downImage { [DispId(5012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D26 RID: 3366
		// (set) Token: 0x06000D27 RID: 3367
		[DispId(5008)]
		public extern string transparencyColor { [DispId(5008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000D28 RID: 3368
		// (remove) Token: 0x06000D29 RID: 3369
		public extern event Delegate81 ondragbegin;

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000D2A RID: 3370
		// (remove) Token: 0x06000D2B RID: 3371
		public extern event Delegate82 ondragend;

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06000D2C RID: 3372
		// (remove) Token: 0x06000D2D RID: 3373
		public extern event Delegate83 onpositionchange;
	}
}
