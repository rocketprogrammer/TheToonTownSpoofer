using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000B0 RID: 176
	[TypeLibType(4160)]
	[Guid("2A2E0DA3-19FA-4F82-BE18-CD7D7A3B977F")]
	[ComImport]
	public interface GInterface67
	{
		// Token: 0x0600099C RID: 2460
		[DispId(3221)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x0600099D RID: 2461
		[DispId(3222)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x0600099E RID: 2462
		[DispId(3211)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x0600099F RID: 2463
		[DispId(3220)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060009A0 RID: 2464
		[DispId(3223)]
		int DPI { [DispId(3223)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060009A1 RID: 2465
		[DispId(3200)]
		string mode { [DispId(3200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060009A3 RID: 2467
		// (set) Token: 0x060009A2 RID: 2466
		[DispId(3206)]
		int burn_selectedDrive { [DispId(3206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060009A4 RID: 2468
		// (set) Token: 0x060009A5 RID: 2469
		[DispId(3216)]
		int sync_selectedDevice { [DispId(3216)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3216)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060009A6 RID: 2470
		[DispId(3208)]
		int burn_numDiscsSpanned { [DispId(3208)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060009A7 RID: 2471
		[DispId(3225)]
		object editPlaylist { [DispId(3225)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009A8 RID: 2472
		[DispId(3227)]
		string basketPlaylistName { [DispId(3227)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060009A9 RID: 2473
		[DispId(3228)]
		bool isHighContrastMode { [DispId(3228)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009AA RID: 2474
		[DispId(3229)]
		bool allowRating { [DispId(3229)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009AB RID: 2475
		[DispId(3230)]
		bool allowShop { [DispId(3230)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009AC RID: 2476
		[DispId(3201)]
		string burn_mediaType { [DispId(3201)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009AD RID: 2477
		[DispId(3202)]
		string burn_contentType { [DispId(3202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009AE RID: 2478
		[DispId(3203)]
		int burn_freeSpace { [DispId(3203)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009AF RID: 2479
		[DispId(3204)]
		int burn_totalSpace { [DispId(3204)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009B0 RID: 2480
		[DispId(3205)]
		string burn_driveName { [DispId(3205)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009B1 RID: 2481
		[DispId(3207)]
		int burn_numDevices { [DispId(3207)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009B2 RID: 2482
		[DispId(3209)]
		int burn_spaceToUse { [DispId(3209)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009B3 RID: 2483
		[DispId(3210)]
		int burn_percentComplete { [DispId(3210)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009B4 RID: 2484
		[DispId(3212)]
		int sync_spaceToUse { [DispId(3212)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009B5 RID: 2485
		[DispId(3213)]
		int sync_spaceUsed { [DispId(3213)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060009B6 RID: 2486
		[DispId(3214)]
		int sync_totalSpace { [DispId(3214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060009B7 RID: 2487
		[DispId(3215)]
		string sync_deviceName { [DispId(3215)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060009B8 RID: 2488
		[DispId(3217)]
		int sync_numDevices { [DispId(3217)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060009B9 RID: 2489
		[DispId(3218)]
		string sync_oemName { [DispId(3218)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060009BA RID: 2490
		[DispId(3219)]
		int sync_percentComplete { [DispId(3219)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060009BB RID: 2491
		[DispId(3224)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string ID, [MarshalAs(UnmanagedType.BStr)] [In] string data);

		// Token: 0x060009BC RID: 2492
		[DispId(3226)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_5([In] int value);
	}
}
