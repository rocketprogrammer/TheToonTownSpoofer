using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x020000A7 RID: 167
	[TypeLibType(4160)]
	[Guid("21D077C1-4BAA-11D3-BD45-00C04F6EA5AE")]
	[ComImport]
	public interface GInterface58
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000792 RID: 1938
		[DispId(2000)]
		string ID { [DispId(2000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000793 RID: 1939
		[DispId(2001)]
		string elementType { [DispId(2001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000794 RID: 1940
		// (set) Token: 0x06000795 RID: 1941
		[DispId(2002)]
		int left { [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000796 RID: 1942
		// (set) Token: 0x06000797 RID: 1943
		[DispId(2003)]
		int top { [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000798 RID: 1944
		// (set) Token: 0x06000799 RID: 1945
		[DispId(2022)]
		int right { [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2022)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600079A RID: 1946
		// (set) Token: 0x0600079B RID: 1947
		[DispId(2023)]
		int bottom { [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2023)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600079C RID: 1948
		// (set) Token: 0x0600079D RID: 1949
		[DispId(2004)]
		int width { [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600079E RID: 1950
		// (set) Token: 0x0600079F RID: 1951
		[DispId(2005)]
		int height { [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007A0 RID: 1952
		// (set) Token: 0x060007A1 RID: 1953
		[DispId(2006)]
		int zIndex { [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007A2 RID: 1954
		// (set) Token: 0x060007A3 RID: 1955
		[DispId(2007)]
		string clippingImage { [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007A4 RID: 1956
		// (set) Token: 0x060007A5 RID: 1957
		[DispId(2008)]
		string clippingColor { [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007A6 RID: 1958
		// (set) Token: 0x060007A7 RID: 1959
		[DispId(2009)]
		bool visible { [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007A8 RID: 1960
		// (set) Token: 0x060007A9 RID: 1961
		[DispId(2010)]
		bool enabled { [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007AA RID: 1962
		// (set) Token: 0x060007AB RID: 1963
		[DispId(2011)]
		bool tabStop { [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2011)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007AC RID: 1964
		// (set) Token: 0x060007AD RID: 1965
		[DispId(2012)]
		bool passThrough { [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007AE RID: 1966
		// (set) Token: 0x060007AF RID: 1967
		[DispId(2013)]
		string horizontalAlignment { [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2013)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007B0 RID: 1968
		// (set) Token: 0x060007B1 RID: 1969
		[DispId(2014)]
		string verticalAlignment { [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2014)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060007B2 RID: 1970
		[DispId(2015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x060007B3 RID: 1971
		[DispId(2021)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] int newX, [In] int newY, [In] int moveTime);

		// Token: 0x060007B4 RID: 1972
		[DispId(2026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] int newX, [In] int newY, [In] int newWidth, [In] int newHeight, [In] int moveTime, [In] bool fSlide);

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007B5 RID: 1973
		// (set) Token: 0x060007B6 RID: 1974
		[DispId(2016)]
		int alphaBlend { [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2016)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060007B7 RID: 1975
		[DispId(2017)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int newVal, [In] int alphaTime);

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007B8 RID: 1976
		// (set) Token: 0x060007B9 RID: 1977
		[DispId(2018)]
		string accName { [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007BA RID: 1978
		// (set) Token: 0x060007BB RID: 1979
		[DispId(2019)]
		string accDescription { [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2019)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007BC RID: 1980
		// (set) Token: 0x060007BD RID: 1981
		[DispId(2020)]
		string accKeyboardShortcut { [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2020)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007BE RID: 1982
		// (set) Token: 0x060007BF RID: 1983
		[DispId(2024)]
		bool resizeImages { [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2024)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007C0 RID: 1984
		// (set) Token: 0x060007C1 RID: 1985
		[DispId(2025)]
		string nineGridMargins { [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2025)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007C2 RID: 1986
		// (set) Token: 0x060007C3 RID: 1987
		[DispId(2027)]
		string resizeOptimize { [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007C4 RID: 1988
		// (set) Token: 0x060007C5 RID: 1989
		[DispId(2028)]
		float rotation { [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2028)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
