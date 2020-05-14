using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AF RID: 175
	[Guid("504F112E-77CC-4E3C-A073-5371B31D9B36")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface66
	{
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000939 RID: 2361
		[DispId(2901)]
		string viewFriendlyName { [DispId(2901)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600093A RID: 2362
		[DispId(2902)]
		int viewPresetCount { [DispId(2902)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600093B RID: 2363
		[DispId(2903)]
		string viewPresetName { [DispId(2903)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600093C RID: 2364
		[DispId(2904)]
		string effectFriendlyName { [DispId(2904)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600093D RID: 2365
		[DispId(2905)]
		string effectPresetName { [DispId(2905)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600093E RID: 2366
		[DispId(2909)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([In] bool fSafe);

		// Token: 0x0600093F RID: 2367
		[DispId(2910)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrView);

		// Token: 0x06000940 RID: 2368
		[DispId(2911)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_2();

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000941 RID: 2369
		[DispId(2912)]
		bool captionsAvailable { [DispId(2912)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000942 RID: 2370
		[DispId(2913)]
		int linkAvailable { [DispId(2913)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000943 RID: 2371
		// (set) Token: 0x06000944 RID: 2372
		[DispId(2914)]
		int linkRequest { [DispId(2914)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2914)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000945 RID: 2373
		// (set) Token: 0x06000946 RID: 2374
		[DispId(2915)]
		string linkRequestParams { [DispId(2915)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2915)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000947 RID: 2375
		[DispId(2917)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_3([In] bool fLargeArt);

		// Token: 0x06000948 RID: 2376
		[DispId(2918)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_4([In] double dTime);

		// Token: 0x06000949 RID: 2377
		[DispId(2919)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrType);

		// Token: 0x0600094A RID: 2378
		[DispId(2920)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([In] int lWidth, [In] int lHeight, [In] bool vbCaptions, [In] bool vbBanner);

		// Token: 0x0600094B RID: 2379
		[DispId(2921)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_7([In] int nProp);

		// Token: 0x0600094C RID: 2380
		[DispId(2922)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object imethod_8([MarshalAs(UnmanagedType.IDispatch)] [In] object pPlaylist);

		// Token: 0x0600094D RID: 2381
		[DispId(2923)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_9();

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600094E RID: 2382
		// (set) Token: 0x0600094F RID: 2383
		[DispId(2926)]
		object editObj { [DispId(2926)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [DispId(2926)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IUnknown)] [param: In] set; }

		// Token: 0x06000950 RID: 2384
		[DispId(2927)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_10([MarshalAs(UnmanagedType.BStr)] [In] string bstrStatusId);

		// Token: 0x06000951 RID: 2385
		[DispId(2939)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_11([MarshalAs(UnmanagedType.BStr)] [In] string bstrStatusId);

		// Token: 0x06000952 RID: 2386
		[DispId(2940)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_12([MarshalAs(UnmanagedType.BStr)] [In] string bstrStatusId);

		// Token: 0x06000953 RID: 2387
		[DispId(2941)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_13([MarshalAs(UnmanagedType.BStr)] [In] string bstrStatusId);

		// Token: 0x06000954 RID: 2388
		[DispId(2942)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_14();

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000955 RID: 2389
		[DispId(2928)]
		string notificationString { [DispId(2928)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000956 RID: 2390
		// (set) Token: 0x06000957 RID: 2391
		[DispId(2930)]
		string htmlViewBaseURL { [DispId(2930)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2930)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000958 RID: 2392
		// (set) Token: 0x06000959 RID: 2393
		[DispId(2933)]
		string htmlViewFullURL { [DispId(2933)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2933)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600095A RID: 2394
		// (set) Token: 0x0600095B RID: 2395
		[DispId(2929)]
		int htmlViewSecureLock { [DispId(2929)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2929)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600095C RID: 2396
		// (set) Token: 0x0600095D RID: 2397
		[DispId(2931)]
		bool htmlViewBusy { [DispId(2931)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2931)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600095E RID: 2398
		// (set) Token: 0x0600095F RID: 2399
		[DispId(2932)]
		bool htmlViewShowCert { [DispId(2932)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2932)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000960 RID: 2400
		// (set) Token: 0x06000961 RID: 2401
		[DispId(2934)]
		bool previousEnabled { [DispId(2934)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2934)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000962 RID: 2402
		// (set) Token: 0x06000963 RID: 2403
		[DispId(2935)]
		bool doPreviousNow { [DispId(2935)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2935)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000964 RID: 2404
		[DispId(2936)]
		int DPI { [DispId(2936)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000965 RID: 2405
		[DispId(2937)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_15();

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000966 RID: 2406
		// (set) Token: 0x06000967 RID: 2407
		[DispId(2938)]
		string lastMessage { [DispId(2938)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2938)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000968 RID: 2408
		[DispId(2943)]
		bool inVistaPlus { [DispId(2943)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000969 RID: 2409
		[DispId(2944)]
		bool isBidi { [DispId(2944)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600096A RID: 2410
		[DispId(2945)]
		bool isOCX { [DispId(2945)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600096B RID: 2411
		[DispId(2946)]
		bool hoverTransportsEnabled { [DispId(2946)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600096C RID: 2412
		[DispId(2947)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16();

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600096D RID: 2413
		// (set) Token: 0x0600096E RID: 2414
		[DispId(2948)]
		bool isAudioCD { [DispId(2948)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2948)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600096F RID: 2415
		// (set) Token: 0x06000970 RID: 2416
		[DispId(2949)]
		bool canRip { [DispId(2949)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2949)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000971 RID: 2417
		// (set) Token: 0x06000972 RID: 2418
		[DispId(2950)]
		bool isRipping { [DispId(2950)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2950)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000973 RID: 2419
		// (set) Token: 0x06000974 RID: 2420
		[DispId(2951)]
		string currentDrive { [DispId(2951)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2951)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000975 RID: 2421
		[DispId(2952)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_17();

		// Token: 0x06000976 RID: 2422
		[DispId(2953)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_18();

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000977 RID: 2423
		// (set) Token: 0x06000978 RID: 2424
		[DispId(2954)]
		bool showMMO { [DispId(2954)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2954)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000979 RID: 2425
		[DispId(2971)]
		bool MMOVisible { [DispId(2971)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600097A RID: 2426
		[DispId(2955)]
		bool suggestionsVisible { [DispId(2955)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600097B RID: 2427
		[DispId(2956)]
		string suggestionsTextColor { [DispId(2956)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600097C RID: 2428
		[DispId(2964)]
		string fontFace { [DispId(2964)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600097D RID: 2429
		[DispId(2965)]
		int fontSize { [DispId(2965)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600097E RID: 2430
		[DispId(2966)]
		string backgroundColor { [DispId(2966)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600097F RID: 2431
		[DispId(2957)]
		int doubleClickTime { [DispId(2957)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000980 RID: 2432
		[DispId(2958)]
		bool playAgain { [DispId(2958)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000981 RID: 2433
		[DispId(2959)]
		bool previousPlaylistAvailable { [DispId(2959)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000982 RID: 2434
		[DispId(2960)]
		bool nextPlaylistAvailable { [DispId(2960)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000983 RID: 2435
		[DispId(2961)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_19();

		// Token: 0x06000984 RID: 2436
		[DispId(2962)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_20();

		// Token: 0x06000985 RID: 2437
		[DispId(2972)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_21([In] int iOffset);

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000986 RID: 2438
		// (set) Token: 0x06000987 RID: 2439
		[DispId(2963)]
		bool basketVisible { [DispId(2963)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2963)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000988 RID: 2440
		[DispId(2967)]
		string mmoTextColor { [DispId(2967)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000989 RID: 2441
		[DispId(2968)]
		bool backgroundVisible { [DispId(2968)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600098B RID: 2443
		// (set) Token: 0x0600098A RID: 2442
		[DispId(2969)]
		bool backgroundEnabled { [DispId(2969)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2969)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600098D RID: 2445
		// (set) Token: 0x0600098C RID: 2444
		[DispId(2970)]
		int backgroundIndex { [DispId(2970)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2970)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600098E RID: 2446
		[DispId(2973)]
		string upNext { [DispId(2973)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600098F RID: 2447
		[DispId(2974)]
		bool playbackOverlayVisible { [DispId(2974)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000990 RID: 2448
		[DispId(2975)]
		bool remoted { [DispId(2975)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000991 RID: 2449
		[DispId(2976)]
		bool glassEnabled { [DispId(2976)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000992 RID: 2450
		[DispId(2977)]
		bool highContrast { [DispId(2977)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037B RID: 891
		// (set) Token: 0x06000993 RID: 2451
		[DispId(2978)]
		string testHighContrast { [DispId(2978)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000994 RID: 2452
		[DispId(2979)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_22(out int pVal);

		// Token: 0x06000995 RID: 2453
		[DispId(2980)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_23([MarshalAs(UnmanagedType.IDispatch)] [In] object pObject, [In] int newVal);

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000996 RID: 2454
		// (set) Token: 0x06000997 RID: 2455
		[DispId(2981)]
		string metadataString { [DispId(2981)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2981)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000998 RID: 2456
		[DispId(2982)]
		int albumArtAlpha { [DispId(2982)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000999 RID: 2457
		[DispId(2983)]
		bool playerModeAlbumArtSelected { [DispId(2983)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600099A RID: 2458
		[DispId(2984)]
		bool inFullScreen { [DispId(2984)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600099B RID: 2459
		[DispId(2985)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_24([MarshalAs(UnmanagedType.IDispatch)] [In] object pObject, [In] int iOffsetFromCurrentMedia, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFallbackImage);
	}
}
