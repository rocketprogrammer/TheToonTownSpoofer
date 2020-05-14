using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x0200007C RID: 124
	[Guid("D84CCA99-CCE2-11D2-9ECC-0000F8085981")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface17
	{
		// Token: 0x06000524 RID: 1316
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_56();

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000525 RID: 1317
		// (set) Token: 0x06000526 RID: 1318
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000527 RID: 1319
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000528 RID: 1320
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000529 RID: 1321
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600052A RID: 1322
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600052B RID: 1323
		// (set) Token: 0x0600052C RID: 1324
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600052D RID: 1325
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600052E RID: 1326
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600052F RID: 1327
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000530 RID: 1328
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000531 RID: 1329
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000532 RID: 1330
		// (set) Token: 0x06000533 RID: 1331
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000534 RID: 1332
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000535 RID: 1333
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000536 RID: 1334
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000537 RID: 1335
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000538 RID: 1336
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
