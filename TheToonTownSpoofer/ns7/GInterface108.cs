using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x02000103 RID: 259
	[TypeLibType(4160)]
	[Guid("95F45AA2-ED0A-11D2-BA67-0000F80855E6")]
	[ComImport]
	public interface GInterface108
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D3A RID: 3386
		// (set) Token: 0x06000D3B RID: 3387
		[DispId(5009)]
		string cursor { [DispId(5009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D3C RID: 3388
		// (set) Token: 0x06000D3D RID: 3389
		[DispId(5005)]
		float min { [DispId(5005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D3E RID: 3390
		// (set) Token: 0x06000D3F RID: 3391
		[DispId(5006)]
		float max { [DispId(5006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D40 RID: 3392
		// (set) Token: 0x06000D41 RID: 3393
		[DispId(5010)]
		float value { [DispId(5010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D42 RID: 3394
		// (set) Token: 0x06000D43 RID: 3395
		[DispId(5011)]
		string toolTip { [DispId(5011)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5011)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D44 RID: 3396
		// (set) Token: 0x06000D45 RID: 3397
		[DispId(5002)]
		string positionImage { [DispId(5002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D46 RID: 3398
		// (set) Token: 0x06000D47 RID: 3399
		[DispId(5001)]
		string image { [DispId(5001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D48 RID: 3400
		// (set) Token: 0x06000D49 RID: 3401
		[DispId(5003)]
		string hoverImage { [DispId(5003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D4A RID: 3402
		// (set) Token: 0x06000D4B RID: 3403
		[DispId(5004)]
		string disabledImage { [DispId(5004)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D4C RID: 3404
		// (set) Token: 0x06000D4D RID: 3405
		[DispId(5012)]
		string downImage { [DispId(5012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D4E RID: 3406
		// (set) Token: 0x06000D4F RID: 3407
		[DispId(5008)]
		string transparencyColor { [DispId(5008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
