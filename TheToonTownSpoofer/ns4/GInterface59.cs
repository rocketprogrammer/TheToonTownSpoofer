using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x020000A8 RID: 168
	[Guid("72F486B1-0D43-11D3-BD3F-00C04F6EA5AE")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface59 : GInterface58
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007C6 RID: 1990
		[DispId(2000)]
		string ID { [DispId(2000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007C7 RID: 1991
		[DispId(2001)]
		string elementType { [DispId(2001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007C8 RID: 1992
		// (set) Token: 0x060007C9 RID: 1993
		[DispId(2002)]
		int left { [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007CA RID: 1994
		// (set) Token: 0x060007CB RID: 1995
		[DispId(2003)]
		int top { [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007CC RID: 1996
		// (set) Token: 0x060007CD RID: 1997
		[DispId(2022)]
		int right { [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007CE RID: 1998
		// (set) Token: 0x060007CF RID: 1999
		[DispId(2023)]
		int bottom { [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007D0 RID: 2000
		// (set) Token: 0x060007D1 RID: 2001
		[DispId(2004)]
		int width { [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007D2 RID: 2002
		// (set) Token: 0x060007D3 RID: 2003
		[DispId(2005)]
		int height { [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007D4 RID: 2004
		// (set) Token: 0x060007D5 RID: 2005
		[DispId(2006)]
		int zIndex { [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007D6 RID: 2006
		// (set) Token: 0x060007D7 RID: 2007
		[DispId(2007)]
		string clippingImage { [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007D8 RID: 2008
		// (set) Token: 0x060007D9 RID: 2009
		[DispId(2008)]
		string clippingColor { [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007DA RID: 2010
		// (set) Token: 0x060007DB RID: 2011
		[DispId(2009)]
		bool visible { [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007DC RID: 2012
		// (set) Token: 0x060007DD RID: 2013
		[DispId(2010)]
		bool enabled { [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007DE RID: 2014
		// (set) Token: 0x060007DF RID: 2015
		[DispId(2011)]
		bool tabStop { [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007E0 RID: 2016
		// (set) Token: 0x060007E1 RID: 2017
		[DispId(2012)]
		bool passThrough { [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060007E2 RID: 2018
		// (set) Token: 0x060007E3 RID: 2019
		[DispId(2013)]
		string horizontalAlignment { [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060007E4 RID: 2020
		// (set) Token: 0x060007E5 RID: 2021
		[DispId(2014)]
		string verticalAlignment { [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060007E6 RID: 2022
		[DispId(2015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x060007E7 RID: 2023
		[DispId(2021)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x060007E8 RID: 2024
		[DispId(2026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([In] int newX, [In] int newY, [In] int newWidth, [In] int newHeight, [In] int moveTime, [In] bool fSlide);

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060007E9 RID: 2025
		// (set) Token: 0x060007EA RID: 2026
		[DispId(2016)]
		int alphaBlend { [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060007EB RID: 2027
		[DispId(2017)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([In] int newVal, [In] int alphaTime);

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060007EC RID: 2028
		// (set) Token: 0x060007ED RID: 2029
		[DispId(2018)]
		string accName { [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060007EE RID: 2030
		// (set) Token: 0x060007EF RID: 2031
		[DispId(2019)]
		string accDescription { [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060007F0 RID: 2032
		// (set) Token: 0x060007F1 RID: 2033
		[DispId(2020)]
		string accKeyboardShortcut { [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060007F2 RID: 2034
		// (set) Token: 0x060007F3 RID: 2035
		[DispId(2024)]
		bool resizeImages { [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060007F4 RID: 2036
		// (set) Token: 0x060007F5 RID: 2037
		[DispId(2025)]
		string nineGridMargins { [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060007F6 RID: 2038
		// (set) Token: 0x060007F7 RID: 2039
		[DispId(2027)]
		string resizeOptimize { [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060007F8 RID: 2040
		// (set) Token: 0x060007F9 RID: 2041
		[DispId(2028)]
		float rotation { [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060007FA RID: 2042
		// (set) Token: 0x060007FB RID: 2043
		[DispId(2300)]
		string transparencyColor { [DispId(2300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2300)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060007FC RID: 2044
		// (set) Token: 0x060007FD RID: 2045
		[DispId(2301)]
		string backgroundColor { [DispId(2301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2301)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060007FE RID: 2046
		// (set) Token: 0x060007FF RID: 2047
		[DispId(2302)]
		string backgroundImage { [DispId(2302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2302)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000800 RID: 2048
		// (set) Token: 0x06000801 RID: 2049
		[DispId(2303)]
		bool backgroundTiled { [DispId(2303)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2303)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000802 RID: 2050
		// (set) Token: 0x06000803 RID: 2051
		[DispId(2304)]
		float backgroundImageHueShift { [DispId(2304)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2304)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000804 RID: 2052
		// (set) Token: 0x06000805 RID: 2053
		[DispId(2305)]
		float backgroundImageSaturation { [DispId(2305)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2305)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000806 RID: 2054
		// (set) Token: 0x06000807 RID: 2055
		[DispId(2306)]
		bool resizeBackgroundImage { [DispId(2306)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2306)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
