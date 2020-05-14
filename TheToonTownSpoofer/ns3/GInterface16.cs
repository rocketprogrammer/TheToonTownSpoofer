using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x0200007B RID: 123
	[Guid("BC17E5B7-7561-4C18-BB90-17D485775659")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface16 : GInterface17
	{
		// Token: 0x0600050E RID: 1294
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_56();

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600050F RID: 1295
		// (set) Token: 0x06000510 RID: 1296
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000511 RID: 1297
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000512 RID: 1298
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000513 RID: 1299
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000514 RID: 1300
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000515 RID: 1301
		// (set) Token: 0x06000516 RID: 1302
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000517 RID: 1303
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000518 RID: 1304
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000519 RID: 1305
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600051A RID: 1306
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600051B RID: 1307
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600051C RID: 1308
		// (set) Token: 0x0600051D RID: 1309
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600051E RID: 1310
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600051F RID: 1311
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000520 RID: 1312
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000521 RID: 1313
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000522 RID: 1314
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000523 RID: 1315
		[DispId(40)]
		GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
