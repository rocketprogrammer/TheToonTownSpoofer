using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x0200007A RID: 122
	[TypeLibType(4160)]
	[Guid("7587C667-628F-499F-88E7-6A6F4E888464")]
	[ComImport]
	public interface GInterface15 : GInterface16
	{
		// Token: 0x060004F6 RID: 1270
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_56();

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004F7 RID: 1271
		// (set) Token: 0x060004F8 RID: 1272
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004F9 RID: 1273
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004FA RID: 1274
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004FB RID: 1275
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004FC RID: 1276
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004FD RID: 1277
		// (set) Token: 0x060004FE RID: 1278
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004FF RID: 1279
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000500 RID: 1280
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000501 RID: 1281
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000502 RID: 1282
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000503 RID: 1283
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000504 RID: 1284
		// (set) Token: 0x06000505 RID: 1285
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000506 RID: 1286
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000507 RID: 1287
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000508 RID: 1288
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000509 RID: 1289
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600050A RID: 1290
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600050B RID: 1291
		[DispId(40)]
		GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600050C RID: 1292
		[DispId(41)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_60([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x0600050D RID: 1293
		[DispId(42)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface7 imethod_61([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);
	}
}
