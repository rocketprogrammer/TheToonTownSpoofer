using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x020000A5 RID: 165
	[Guid("E41C88DD-2364-4FF7-A0F5-CA9859AF783F")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface56
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000745 RID: 1861
		// (set) Token: 0x06000746 RID: 1862
		[DispId(100)]
		bool titlebarVisible { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000747 RID: 1863
		// (set) Token: 0x06000748 RID: 1864
		[DispId(101)]
		bool titlebarAutoHide { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000749 RID: 1865
		// (set) Token: 0x0600074A RID: 1866
		[DispId(102)]
		string currentTask { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600074B RID: 1867
		// (set) Token: 0x0600074C RID: 1868
		[DispId(145)]
		int libraryBasketMode { [DispId(145)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(145)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600074D RID: 1869
		[DispId(146)]
		int libraryBasketWidth { [DispId(146)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600074E RID: 1870
		[DispId(147)]
		int breadcrumbItemCount { [DispId(147)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600074F RID: 1871
		[DispId(148)]
		string breadcrumbItemName { [DispId(148)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000750 RID: 1872
		[DispId(149)]
		bool breadcrumbItemHasMenu { [DispId(149)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000751 RID: 1873
		[DispId(150)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([In] int lIndex);

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000752 RID: 1874
		// (set) Token: 0x06000753 RID: 1875
		[DispId(103)]
		bool settingsVisible { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000754 RID: 1876
		// (set) Token: 0x06000755 RID: 1877
		[DispId(104)]
		bool playlistVisible { [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(104)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000756 RID: 1878
		[DispId(105)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x06000757 RID: 1879
		[DispId(143)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x06000758 RID: 1880
		[DispId(144)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int lButton);

		// Token: 0x06000759 RID: 1881
		[DispId(125)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x0600075A RID: 1882
		[DispId(126)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x0600075B RID: 1883
		[DispId(142)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6();

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600075C RID: 1884
		[DispId(141)]
		bool fullScreenEnabled { [DispId(141)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600075D RID: 1885
		[DispId(132)]
		bool serviceLoginVisible { [DispId(132)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600075E RID: 1886
		[DispId(133)]
		bool serviceLoginSignedIn { [DispId(133)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600075F RID: 1887
		[DispId(134)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7();

		// Token: 0x06000760 RID: 1888
		[DispId(135)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8();

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000761 RID: 1889
		[DispId(140)]
		object serviceGetInfo { [DispId(140)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000762 RID: 1890
		[DispId(123)]
		bool navigatePreviousEnabled { [DispId(123)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000763 RID: 1891
		[DispId(124)]
		bool navigateNextEnabled { [DispId(124)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000764 RID: 1892
		[DispId(130)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([MarshalAs(UnmanagedType.BStr)] [In] string address);

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000765 RID: 1893
		[DispId(131)]
		bool glassEnabled { [DispId(131)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000766 RID: 1894
		[DispId(136)]
		bool inVistaPlus { [DispId(136)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000767 RID: 1895
		[DispId(106)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([In] int nDistance);

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000768 RID: 1896
		// (set) Token: 0x06000769 RID: 1897
		[DispId(107)]
		bool taskbarVisible { [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(107)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600076A RID: 1898
		[DispId(116)]
		int DPI { [DispId(116)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600076B RID: 1899
		[DispId(114)]
		bool previousEnabled { [DispId(114)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600076C RID: 1900
		[DispId(139)]
		bool playLibraryItemEnabled { [DispId(139)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600076D RID: 1901
		[DispId(115)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11();

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600076E RID: 1902
		[DispId(108)]
		bool titlebarCurrentlyVisible { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600076F RID: 1903
		[DispId(137)]
		bool menubarCurrentlyVisible { [DispId(137)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000770 RID: 1904
		[DispId(109)]
		bool bgPluginRunning { [DispId(109)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000771 RID: 1905
		[DispId(110)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12([In] int nType);

		// Token: 0x06000772 RID: 1906
		[DispId(111)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_13([In] double dTime);

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000773 RID: 1907
		[DispId(113)]
		bool maximized { [DispId(113)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000774 RID: 1908
		// (set) Token: 0x06000775 RID: 1909
		[DispId(117)]
		int top { [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(117)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000776 RID: 1910
		// (set) Token: 0x06000777 RID: 1911
		[DispId(118)]
		int left { [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(118)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000778 RID: 1912
		// (set) Token: 0x06000779 RID: 1913
		[DispId(119)]
		int width { [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600077A RID: 1914
		// (set) Token: 0x0600077B RID: 1915
		[DispId(120)]
		int height { [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(120)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600077C RID: 1916
		[DispId(121)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14([In] int lTop, [In] int lLeft, [In] int lWidth, [In] int lHeight);

		// Token: 0x0600077D RID: 1917
		[DispId(122)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string ID, [MarshalAs(UnmanagedType.BStr)] [In] string data);

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600077E RID: 1918
		[DispId(127)]
		string powerPersonality { [DispId(127)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600077F RID: 1919
		[DispId(128)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([MarshalAs(UnmanagedType.BStr)] [In] string address);

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000780 RID: 1920
		[DispId(129)]
		string exclusiveService { [DispId(129)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700024D RID: 589
		// (set) Token: 0x06000781 RID: 1921
		[DispId(138)]
		string windowText { [DispId(138)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
