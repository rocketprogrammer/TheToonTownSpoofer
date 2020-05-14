using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000080 RID: 128
	[TypeLibType(4160)]
	[Guid("9104D1AB-80C9-4FED-ABF0-2E6417A6DF14")]
	[ComImport]
	public interface GInterface19
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000549 RID: 1353
		[DispId(113)]
		bool isAvailable { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600054A RID: 1354
		// (set) Token: 0x0600054B RID: 1355
		[DispId(101)]
		bool autoStart { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600054C RID: 1356
		// (set) Token: 0x0600054D RID: 1357
		[DispId(108)]
		string baseURL { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600054E RID: 1358
		// (set) Token: 0x0600054F RID: 1359
		[DispId(109)]
		string defaultFrame { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000550 RID: 1360
		// (set) Token: 0x06000551 RID: 1361
		[DispId(103)]
		bool invokeURLs { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000552 RID: 1362
		// (set) Token: 0x06000553 RID: 1363
		[DispId(104)]
		bool mute { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000554 RID: 1364
		// (set) Token: 0x06000555 RID: 1365
		[DispId(105)]
		int playCount { [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(105)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000556 RID: 1366
		// (set) Token: 0x06000557 RID: 1367
		[DispId(106)]
		double rate { [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(106)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000558 RID: 1368
		// (set) Token: 0x06000559 RID: 1369
		[DispId(102)]
		int balance { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600055A RID: 1370
		// (set) Token: 0x0600055B RID: 1371
		[DispId(107)]
		int volume { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600055C RID: 1372
		[DispId(110)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_53([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode);

		// Token: 0x0600055D RID: 1373
		[DispId(111)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_54([MarshalAs(UnmanagedType.BStr)] [In] string bstrMode, [In] bool varfMode);

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600055E RID: 1374
		// (set) Token: 0x0600055F RID: 1375
		[DispId(112)]
		bool enableErrorDialogs { [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(112)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
