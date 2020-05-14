using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x020000A4 RID: 164
	[TypeLibType(4160)]
	[Guid("5F9CFD92-8CAD-11D3-9A7E-00C04F8EFB70")]
	[ComImport]
	public interface GInterface55
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006EB RID: 1771
		// (set) Token: 0x060006EC RID: 1772
		[DispId(5601)]
		GInterface6 Playlist { [DispId(5601)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(5601)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006ED RID: 1773
		// (set) Token: 0x060006EE RID: 1774
		[DispId(5602)]
		string columns { [DispId(5602)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5602)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006EF RID: 1775
		[DispId(5603)]
		int columnCount { [DispId(5603)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006F0 RID: 1776
		// (set) Token: 0x060006F1 RID: 1777
		[DispId(5604)]
		string columnOrder { [DispId(5604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5604)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006F2 RID: 1778
		// (set) Token: 0x060006F3 RID: 1779
		[DispId(5605)]
		bool columnsVisible { [DispId(5605)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5605)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006F4 RID: 1780
		// (set) Token: 0x060006F5 RID: 1781
		[DispId(5607)]
		bool dropDownVisible { [DispId(5607)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5607)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006F6 RID: 1782
		// (set) Token: 0x060006F7 RID: 1783
		[DispId(5608)]
		bool playlistItemsVisible { [DispId(5608)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5608)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006F8 RID: 1784
		// (set) Token: 0x060006F9 RID: 1785
		[DispId(5609)]
		bool checkboxesVisible { [DispId(5609)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5609)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006FA RID: 1786
		// (set) Token: 0x060006FB RID: 1787
		[DispId(5612)]
		string backgroundColor { [DispId(5612)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5612)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006FC RID: 1788
		// (set) Token: 0x060006FD RID: 1789
		[DispId(5613)]
		string foregroundColor { [DispId(5613)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5613)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006FE RID: 1790
		// (set) Token: 0x060006FF RID: 1791
		[DispId(5614)]
		string disabledItemColor { [DispId(5614)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5614)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000700 RID: 1792
		// (set) Token: 0x06000701 RID: 1793
		[DispId(5615)]
		string itemPlayingColor { [DispId(5615)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5615)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000702 RID: 1794
		// (set) Token: 0x06000703 RID: 1795
		[DispId(5616)]
		string itemPlayingBackgroundColor { [DispId(5616)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5616)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000704 RID: 1796
		// (set) Token: 0x06000705 RID: 1797
		[DispId(5617)]
		string backgroundImage { [DispId(5617)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5617)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000706 RID: 1798
		// (set) Token: 0x06000707 RID: 1799
		[DispId(5618)]
		bool allowItemEditing { [DispId(5618)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5618)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000708 RID: 1800
		// (set) Token: 0x06000709 RID: 1801
		[DispId(5619)]
		bool allowColumnSorting { [DispId(5619)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5619)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600070A RID: 1802
		// (set) Token: 0x0600070B RID: 1803
		[DispId(5620)]
		string dropDownList { [DispId(5620)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5620)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600070C RID: 1804
		// (set) Token: 0x0600070D RID: 1805
		[DispId(5621)]
		string dropDownToolTip { [DispId(5621)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5621)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600070E RID: 1806
		// (set) Token: 0x0600070F RID: 1807
		[DispId(5622)]
		bool copying { [DispId(5622)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5622)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000710 RID: 1808
		[DispId(5623)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x06000711 RID: 1809
		[DispId(5624)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x06000712 RID: 1810
		[DispId(5625)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x06000713 RID: 1811
		[DispId(5626)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x06000714 RID: 1812
		[DispId(5628)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x06000715 RID: 1813
		[DispId(5629)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x06000716 RID: 1814
		[DispId(5630)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pdispPlaylist);

		// Token: 0x06000717 RID: 1815
		[DispId(5631)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_7([In] int nStartIndex);

		// Token: 0x06000718 RID: 1816
		[DispId(5632)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_8([In] int nStartIndex);

		// Token: 0x06000719 RID: 1817
		[DispId(5633)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([In] int nIndex, [In] bool vbSelected);

		// Token: 0x0600071A RID: 1818
		[DispId(5634)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([In] int nIndex, [In] bool vbChecked);

		// Token: 0x0600071B RID: 1819
		[DispId(5635)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([In] int nIndex);

		// Token: 0x0600071C RID: 1820
		[DispId(5636)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12([In] int nIndex, [MarshalAs(UnmanagedType.BStr)] [In] string newMode);

		// Token: 0x0600071D RID: 1821
		[DispId(5637)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_13([In] int nIndex, [In] int nWidth);

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600071E RID: 1822
		// (set) Token: 0x0600071F RID: 1823
		[DispId(5642)]
		string itemErrorColor { [DispId(5642)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5642)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000720 RID: 1824
		[DispId(5643)]
		int itemCount { [DispId(5643)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000721 RID: 1825
		[DispId(5644)]
		GInterface7 itemMedia { [DispId(5644)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000722 RID: 1826
		[DispId(5645)]
		GInterface6 itemPlaylist { [DispId(5645)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000723 RID: 1827
		[DispId(5646)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_14([In] int nStartIndex);

		// Token: 0x06000724 RID: 1828
		[DispId(5647)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_15([In] int nStartIndex);

		// Token: 0x06000725 RID: 1829
		[DispId(5648)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([In] int nIndex, [In] bool vbSelected);

		// Token: 0x06000726 RID: 1830
		[DispId(5649)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_17([In] int nIndex, [In] bool vbChecked);

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000727 RID: 1831
		// (set) Token: 0x06000728 RID: 1832
		[DispId(5650)]
		string leftStatus { [DispId(5650)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5650)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000729 RID: 1833
		// (set) Token: 0x0600072A RID: 1834
		[DispId(5651)]
		string rightStatus { [DispId(5651)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5651)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600072B RID: 1835
		// (set) Token: 0x0600072C RID: 1836
		[DispId(5652)]
		bool editButtonVisible { [DispId(5652)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5652)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600072D RID: 1837
		// (set) Token: 0x0600072E RID: 1838
		[DispId(5653)]
		string dropDownImage { [DispId(5653)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5653)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600072F RID: 1839
		// (set) Token: 0x06000730 RID: 1840
		[DispId(5654)]
		string dropDownBackgroundImage { [DispId(5654)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5654)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000731 RID: 1841
		// (set) Token: 0x06000732 RID: 1842
		[DispId(5655)]
		float hueShift { [DispId(5655)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5655)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000733 RID: 1843
		// (set) Token: 0x06000734 RID: 1844
		[DispId(5656)]
		float saturation { [DispId(5656)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5656)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000735 RID: 1845
		// (set) Token: 0x06000736 RID: 1846
		[DispId(5658)]
		string statusColor { [DispId(5658)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5658)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000737 RID: 1847
		// (set) Token: 0x06000738 RID: 1848
		[DispId(5660)]
		bool toolbarVisible { [DispId(5660)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5660)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000739 RID: 1849
		// (set) Token: 0x0600073A RID: 1850
		[DispId(5662)]
		string itemSelectedColor { [DispId(5662)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5662)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600073B RID: 1851
		// (set) Token: 0x0600073C RID: 1852
		[DispId(5663)]
		string itemSelectedFocusLostColor { [DispId(5663)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5663)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600073D RID: 1853
		// (set) Token: 0x0600073E RID: 1854
		[DispId(5664)]
		string itemSelectedBackgroundColor { [DispId(5664)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5664)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600073F RID: 1855
		// (set) Token: 0x06000740 RID: 1856
		[DispId(5665)]
		string itemSelectedBackgroundFocusLostColor { [DispId(5665)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5665)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000741 RID: 1857
		// (set) Token: 0x06000742 RID: 1858
		[DispId(5666)]
		string backgroundSplitColor { [DispId(5666)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5666)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000743 RID: 1859
		// (set) Token: 0x06000744 RID: 1860
		[DispId(5667)]
		string statusTextColor { [DispId(5667)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5667)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
