using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x020000A9 RID: 169
	[Guid("172E905D-80D9-4C2F-B7CE-2CCB771787A2")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface60 : GInterface59
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000808 RID: 2056
		[DispId(2000)]
		string ID { [DispId(2000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000809 RID: 2057
		[DispId(2001)]
		string elementType { [DispId(2001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600080A RID: 2058
		// (set) Token: 0x0600080B RID: 2059
		[DispId(2002)]
		int left { [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600080C RID: 2060
		// (set) Token: 0x0600080D RID: 2061
		[DispId(2003)]
		int top { [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600080E RID: 2062
		// (set) Token: 0x0600080F RID: 2063
		[DispId(2022)]
		int right { [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000810 RID: 2064
		// (set) Token: 0x06000811 RID: 2065
		[DispId(2023)]
		int bottom { [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000812 RID: 2066
		// (set) Token: 0x06000813 RID: 2067
		[DispId(2004)]
		int width { [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000814 RID: 2068
		// (set) Token: 0x06000815 RID: 2069
		[DispId(2005)]
		int height { [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000816 RID: 2070
		// (set) Token: 0x06000817 RID: 2071
		[DispId(2006)]
		int zIndex { [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000818 RID: 2072
		// (set) Token: 0x06000819 RID: 2073
		[DispId(2007)]
		string clippingImage { [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600081A RID: 2074
		// (set) Token: 0x0600081B RID: 2075
		[DispId(2008)]
		string clippingColor { [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600081C RID: 2076
		// (set) Token: 0x0600081D RID: 2077
		[DispId(2009)]
		bool visible { [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600081E RID: 2078
		// (set) Token: 0x0600081F RID: 2079
		[DispId(2010)]
		bool enabled { [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000820 RID: 2080
		// (set) Token: 0x06000821 RID: 2081
		[DispId(2011)]
		bool tabStop { [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000822 RID: 2082
		// (set) Token: 0x06000823 RID: 2083
		[DispId(2012)]
		bool passThrough { [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000824 RID: 2084
		// (set) Token: 0x06000825 RID: 2085
		[DispId(2013)]
		string horizontalAlignment { [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000826 RID: 2086
		// (set) Token: 0x06000827 RID: 2087
		[DispId(2014)]
		string verticalAlignment { [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000828 RID: 2088
		[DispId(2015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x06000829 RID: 2089
		[DispId(2021)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x0600082A RID: 2090
		[DispId(2026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([In] int newX, [In] int newY, [In] int newWidth, [In] int newHeight, [In] int moveTime, [In] bool fSlide);

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600082B RID: 2091
		// (set) Token: 0x0600082C RID: 2092
		[DispId(2016)]
		int alphaBlend { [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600082D RID: 2093
		[DispId(2017)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([In] int newVal, [In] int alphaTime);

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600082E RID: 2094
		// (set) Token: 0x0600082F RID: 2095
		[DispId(2018)]
		string accName { [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000830 RID: 2096
		// (set) Token: 0x06000831 RID: 2097
		[DispId(2019)]
		string accDescription { [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000832 RID: 2098
		// (set) Token: 0x06000833 RID: 2099
		[DispId(2020)]
		string accKeyboardShortcut { [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000834 RID: 2100
		// (set) Token: 0x06000835 RID: 2101
		[DispId(2024)]
		bool resizeImages { [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000836 RID: 2102
		// (set) Token: 0x06000837 RID: 2103
		[DispId(2025)]
		string nineGridMargins { [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000838 RID: 2104
		// (set) Token: 0x06000839 RID: 2105
		[DispId(2027)]
		string resizeOptimize { [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600083A RID: 2106
		// (set) Token: 0x0600083B RID: 2107
		[DispId(2028)]
		float rotation { [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600083C RID: 2108
		// (set) Token: 0x0600083D RID: 2109
		[DispId(2300)]
		string transparencyColor { [DispId(2300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2300)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600083E RID: 2110
		// (set) Token: 0x0600083F RID: 2111
		[DispId(2301)]
		string backgroundColor { [DispId(2301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2301)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000840 RID: 2112
		// (set) Token: 0x06000841 RID: 2113
		[DispId(2302)]
		string backgroundImage { [DispId(2302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2302)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000842 RID: 2114
		// (set) Token: 0x06000843 RID: 2115
		[DispId(2303)]
		bool backgroundTiled { [DispId(2303)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2303)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000844 RID: 2116
		// (set) Token: 0x06000845 RID: 2117
		[DispId(2304)]
		float backgroundImageHueShift { [DispId(2304)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2304)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000846 RID: 2118
		// (set) Token: 0x06000847 RID: 2119
		[DispId(2305)]
		float backgroundImageSaturation { [DispId(2305)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2305)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000848 RID: 2120
		// (set) Token: 0x06000849 RID: 2121
		[DispId(2306)]
		bool resizeBackgroundImage { [DispId(2306)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2306)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600084A RID: 2122
		// (set) Token: 0x0600084B RID: 2123
		[DispId(2307)]
		string title { [DispId(2307)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2307)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600084C RID: 2124
		// (set) Token: 0x0600084D RID: 2125
		[DispId(2308)]
		string category { [DispId(2308)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2308)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600084E RID: 2126
		// (set) Token: 0x0600084F RID: 2127
		[DispId(2309)]
		string focusObjectID { [DispId(2309)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2309)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000850 RID: 2128
		[DispId(2311)]
		bool titleBar { [DispId(2311)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000851 RID: 2129
		[DispId(2312)]
		bool resizable { [DispId(2312)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000852 RID: 2130
		// (set) Token: 0x06000853 RID: 2131
		[DispId(2313)]
		int timerInterval { [DispId(2313)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2313)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000854 RID: 2132
		// (set) Token: 0x06000855 RID: 2133
		[DispId(2314)]
		int minWidth { [DispId(2314)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2314)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000856 RID: 2134
		// (set) Token: 0x06000857 RID: 2135
		[DispId(2315)]
		int maxWidth { [DispId(2315)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2315)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000858 RID: 2136
		// (set) Token: 0x06000859 RID: 2137
		[DispId(2316)]
		int minHeight { [DispId(2316)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2316)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600085A RID: 2138
		// (set) Token: 0x0600085B RID: 2139
		[DispId(2317)]
		int maxHeight { [DispId(2317)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2317)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600085C RID: 2140
		[DispId(2318)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12();

		// Token: 0x0600085D RID: 2141
		[DispId(2319)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_13();

		// Token: 0x0600085E RID: 2142
		[DispId(2320)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14();

		// Token: 0x0600085F RID: 2143
		[DispId(2321)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_15();

		// Token: 0x06000860 RID: 2144
		[DispId(2322)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([MarshalAs(UnmanagedType.BStr)] [In] string bstrDirection);

		// Token: 0x06000861 RID: 2145
		[DispId(2323)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_17();

		// Token: 0x06000862 RID: 2146
		[DispId(2324)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_18();

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000863 RID: 2147
		[DispId(2326)]
		bool maximized { [DispId(2326)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000864 RID: 2148
		[DispId(2327)]
		bool minimized { [DispId(2327)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
