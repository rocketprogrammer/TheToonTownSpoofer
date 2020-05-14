using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AC RID: 172
	[Guid("B2C2D18E-97AF-4B6A-A56B-2FFFF470FB81")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface63
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600088C RID: 2188
		// (set) Token: 0x0600088D RID: 2189
		[DispId(2800)]
		string effectType { [DispId(2800)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2800)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600088E RID: 2190
		// (set) Token: 0x0600088F RID: 2191
		[DispId(2801)]
		int effectPreset { [DispId(2801)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2801)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000890 RID: 2192
		// (set) Token: 0x06000891 RID: 2193
		[DispId(2802)]
		string settingsView { [DispId(2802)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2802)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000892 RID: 2194
		// (set) Token: 0x06000893 RID: 2195
		[DispId(2803)]
		int videoZoom { [DispId(2803)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2803)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000894 RID: 2196
		// (set) Token: 0x06000895 RID: 2197
		[DispId(2804)]
		bool videoShrinkToFit { [DispId(2804)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2804)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000896 RID: 2198
		// (set) Token: 0x06000897 RID: 2199
		[DispId(2805)]
		bool videoStretchToFit { [DispId(2805)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2805)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000898 RID: 2200
		// (set) Token: 0x06000899 RID: 2201
		[DispId(2868)]
		bool userVideoStretchToFit { [DispId(2868)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2868)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600089A RID: 2202
		// (set) Token: 0x0600089B RID: 2203
		[DispId(2807)]
		bool showCaptions { [DispId(2807)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2807)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600089C RID: 2204
		// (set) Token: 0x0600089D RID: 2205
		[DispId(2808)]
		bool showTitles { [DispId(2808)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2808)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600089E RID: 2206
		// (set) Token: 0x0600089F RID: 2207
		[DispId(2809)]
		bool showEffects { [DispId(2809)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2809)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060008A0 RID: 2208
		// (set) Token: 0x060008A1 RID: 2209
		[DispId(2811)]
		bool showFullScreenPlaylist { [DispId(2811)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2811)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060008A2 RID: 2210
		[DispId(2813)]
		string contrastMode { [DispId(2813)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060008A3 RID: 2211
		[DispId(2810)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x060008A4 RID: 2212
		[DispId(2815)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_1([In] int lDurationVal);

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060008A5 RID: 2213
		// (set) Token: 0x060008A6 RID: 2214
		[DispId(2816)]
		string displayView { [DispId(2816)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2816)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060008A7 RID: 2215
		// (set) Token: 0x060008A8 RID: 2216
		[DispId(2817)]
		string metadataView { [DispId(2817)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2817)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008A9 RID: 2217
		// (set) Token: 0x060008AA RID: 2218
		[DispId(2818)]
		bool showSettings { [DispId(2818)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2818)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060008AB RID: 2219
		// (set) Token: 0x060008AC RID: 2220
		[DispId(2819)]
		bool showResizeBars { [DispId(2819)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2819)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060008AD RID: 2221
		// (set) Token: 0x060008AE RID: 2222
		[DispId(2820)]
		bool showPlaylist { [DispId(2820)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2820)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060008AF RID: 2223
		// (set) Token: 0x060008B0 RID: 2224
		[DispId(2821)]
		bool showMetadata { [DispId(2821)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2821)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060008B1 RID: 2225
		// (set) Token: 0x060008B2 RID: 2226
		[DispId(2822)]
		int settingsWidth { [DispId(2822)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2822)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060008B3 RID: 2227
		// (set) Token: 0x060008B4 RID: 2228
		[DispId(2823)]
		int settingsHeight { [DispId(2823)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2823)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060008B5 RID: 2229
		// (set) Token: 0x060008B6 RID: 2230
		[DispId(2824)]
		int playlistWidth { [DispId(2824)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2824)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060008B7 RID: 2231
		// (set) Token: 0x060008B8 RID: 2232
		[DispId(2825)]
		int playlistHeight { [DispId(2825)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2825)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060008B9 RID: 2233
		// (set) Token: 0x060008BA RID: 2234
		[DispId(2826)]
		int metadataWidth { [DispId(2826)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2826)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060008BB RID: 2235
		// (set) Token: 0x060008BC RID: 2236
		[DispId(2827)]
		int metadataHeight { [DispId(2827)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2827)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060008BD RID: 2237
		// (set) Token: 0x060008BE RID: 2238
		[DispId(2828)]
		bool fullScreenAvailable { [DispId(2828)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2828)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008BF RID: 2239
		// (set) Token: 0x060008C0 RID: 2240
		[DispId(2829)]
		bool fullScreenRequest { [DispId(2829)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2829)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008C1 RID: 2241
		// (set) Token: 0x060008C2 RID: 2242
		[DispId(2830)]
		bool quickHide { [DispId(2830)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2830)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008C3 RID: 2243
		// (set) Token: 0x060008C4 RID: 2244
		[DispId(2831)]
		int displayPreset { [DispId(2831)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2831)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008C5 RID: 2245
		// (set) Token: 0x060008C6 RID: 2246
		[DispId(2832)]
		int settingsPreset { [DispId(2832)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2832)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008C7 RID: 2247
		// (set) Token: 0x060008C8 RID: 2248
		[DispId(2833)]
		int metadataPreset { [DispId(2833)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2833)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008C9 RID: 2249
		[DispId(2834)]
		string userDisplayView { [DispId(2834)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008CA RID: 2250
		[DispId(2835)]
		string userWMPDisplayView { [DispId(2835)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008CB RID: 2251
		[DispId(2836)]
		int userDisplayPreset { [DispId(2836)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008CC RID: 2252
		[DispId(2837)]
		int userWMPDisplayPreset { [DispId(2837)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008CD RID: 2253
		// (set) Token: 0x060008CE RID: 2254
		[DispId(2838)]
		int dynamicRangeControl { [DispId(2838)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2838)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008CF RID: 2255
		// (set) Token: 0x060008D0 RID: 2256
		[DispId(2839)]
		float slowRate { [DispId(2839)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2839)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008D1 RID: 2257
		// (set) Token: 0x060008D2 RID: 2258
		[DispId(2840)]
		float fastRate { [DispId(2840)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2840)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008D3 RID: 2259
		// (set) Token: 0x060008D4 RID: 2260
		[DispId(2841)]
		float buttonHueShift { [DispId(2841)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2841)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008D5 RID: 2261
		// (set) Token: 0x060008D6 RID: 2262
		[DispId(2842)]
		float buttonSaturation { [DispId(2842)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2842)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008D7 RID: 2263
		// (set) Token: 0x060008D8 RID: 2264
		[DispId(2843)]
		float backHueShift { [DispId(2843)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2843)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008D9 RID: 2265
		// (set) Token: 0x060008DA RID: 2266
		[DispId(2844)]
		float backSaturation { [DispId(2844)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2844)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008DB RID: 2267
		// (set) Token: 0x060008DC RID: 2268
		[DispId(2845)]
		int vizRequest { [DispId(2845)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2845)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060008DD RID: 2269
		[DispId(2847)]
		string appColorLight { [DispId(2847)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060008DE RID: 2270
		[DispId(2848)]
		string appColorMedium { [DispId(2848)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060008DF RID: 2271
		[DispId(2849)]
		string appColorDark { [DispId(2849)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060008E0 RID: 2272
		[DispId(2856)]
		string toolbarButtonHighlight { [DispId(2856)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060008E1 RID: 2273
		[DispId(2857)]
		string toolbarButtonShadow { [DispId(2857)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060008E2 RID: 2274
		[DispId(2858)]
		string toolbarButtonFace { [DispId(2858)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060008E3 RID: 2275
		[DispId(2850)]
		string itemPlayingColor { [DispId(2850)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060008E4 RID: 2276
		[DispId(2851)]
		string itemPlayingBackgroundColor { [DispId(2851)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060008E5 RID: 2277
		[DispId(2852)]
		string itemErrorColor { [DispId(2852)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060008E6 RID: 2278
		[DispId(2853)]
		bool appColorLimited { [DispId(2853)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060008E7 RID: 2279
		// (set) Token: 0x060008E8 RID: 2280
		[DispId(2854)]
		bool appColorBlackBackground { [DispId(2854)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2854)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060008E9 RID: 2281
		// (set) Token: 0x060008EA RID: 2282
		[DispId(2855)]
		string appColorVideoBorder { [DispId(2855)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2855)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060008EB RID: 2283
		[DispId(2869)]
		string appColorAux1 { [DispId(2869)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060008EC RID: 2284
		[DispId(2870)]
		string appColorAux2 { [DispId(2870)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060008ED RID: 2285
		[DispId(2871)]
		string appColorAux3 { [DispId(2871)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060008EE RID: 2286
		[DispId(2872)]
		string appColorAux4 { [DispId(2872)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060008EF RID: 2287
		[DispId(2873)]
		string appColorAux5 { [DispId(2873)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060008F0 RID: 2288
		[DispId(2874)]
		string appColorAux6 { [DispId(2874)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060008F1 RID: 2289
		[DispId(2875)]
		string appColorAux7 { [DispId(2875)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060008F2 RID: 2290
		[DispId(2876)]
		string appColorAux8 { [DispId(2876)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060008F3 RID: 2291
		[DispId(2877)]
		string appColorAux9 { [DispId(2877)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060008F4 RID: 2292
		[DispId(2878)]
		string appColorAux10 { [DispId(2878)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060008F5 RID: 2293
		[DispId(2879)]
		string appColorAux11 { [DispId(2879)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060008F6 RID: 2294
		[DispId(2880)]
		string appColorAux12 { [DispId(2880)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060008F7 RID: 2295
		[DispId(2881)]
		string appColorAux13 { [DispId(2881)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060008F8 RID: 2296
		[DispId(2882)]
		string appColorAux14 { [DispId(2882)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060008F9 RID: 2297
		[DispId(2883)]
		string appColorAux15 { [DispId(2883)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060008FA RID: 2298
		// (set) Token: 0x060008FB RID: 2299
		[DispId(2884)]
		string status { [DispId(2884)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2884)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060008FC RID: 2300
		[DispId(2859)]
		string userWMPSettingsView { [DispId(2859)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060008FD RID: 2301
		[DispId(2860)]
		int userWMPSettingsPreset { [DispId(2860)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060008FE RID: 2302
		[DispId(2861)]
		bool userWMPShowSettings { [DispId(2861)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060008FF RID: 2303
		[DispId(2862)]
		string userWMPMetadataView { [DispId(2862)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000900 RID: 2304
		[DispId(2863)]
		int userWMPMetadataPreset { [DispId(2863)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000901 RID: 2305
		[DispId(2864)]
		bool userWMPShowMetadata { [DispId(2864)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000902 RID: 2306
		// (set) Token: 0x06000903 RID: 2307
		[DispId(2865)]
		int captionsHeight { [DispId(2865)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2865)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000904 RID: 2308
		// (set) Token: 0x06000905 RID: 2309
		[DispId(2866)]
		bool snapToVideo { [DispId(2866)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2866)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000906 RID: 2310
		// (set) Token: 0x06000907 RID: 2311
		[DispId(2867)]
		bool pinFullScreenControls { [DispId(2867)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2867)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000908 RID: 2312
		[DispId(2887)]
		bool isMultiMon { [DispId(2887)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000909 RID: 2313
		// (set) Token: 0x0600090A RID: 2314
		[DispId(2888)]
		float exclusiveHueShift { [DispId(2888)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2888)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600090B RID: 2315
		// (set) Token: 0x0600090C RID: 2316
		[DispId(2889)]
		float exclusiveSaturation { [DispId(2889)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2889)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600090D RID: 2317
		// (set) Token: 0x0600090E RID: 2318
		[DispId(2892)]
		bool themeBkgColorIsActive { [DispId(2892)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2892)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600090F RID: 2319
		[DispId(2890)]
		string themeBkgColorActive { [DispId(2890)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000910 RID: 2320
		[DispId(2891)]
		string themeBkgColorInactive { [DispId(2891)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
