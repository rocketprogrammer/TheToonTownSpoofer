using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000C4 RID: 196
	[Guid("F2BF2C8F-405F-11D3-BB39-00A0C93CA73A")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface78
	{
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A9A RID: 2714
		// (set) Token: 0x06000A9B RID: 2715
		[DispId(5400)]
		string direction { [DispId(5400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5400)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A9C RID: 2716
		// (set) Token: 0x06000A9D RID: 2717
		[DispId(5402)]
		bool slide { [DispId(5402)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5402)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A9E RID: 2718
		// (set) Token: 0x06000A9F RID: 2719
		[DispId(5403)]
		bool tiled { [DispId(5403)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5403)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000AA0 RID: 2720
		// (set) Token: 0x06000AA1 RID: 2721
		[DispId(5404)]
		string foregroundColor { [DispId(5404)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5404)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000AA2 RID: 2722
		// (set) Token: 0x06000AA3 RID: 2723
		[DispId(5405)]
		string foregroundEndColor { [DispId(5405)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5405)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000AA4 RID: 2724
		// (set) Token: 0x06000AA5 RID: 2725
		[DispId(5406)]
		string backgroundColor { [DispId(5406)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5406)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000AA6 RID: 2726
		// (set) Token: 0x06000AA7 RID: 2727
		[DispId(5407)]
		string backgroundEndColor { [DispId(5407)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5407)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000AA8 RID: 2728
		// (set) Token: 0x06000AA9 RID: 2729
		[DispId(5408)]
		string disabledColor { [DispId(5408)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5408)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000AAA RID: 2730
		// (set) Token: 0x06000AAB RID: 2731
		[DispId(5409)]
		string transparencyColor { [DispId(5409)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5409)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000AAC RID: 2732
		// (set) Token: 0x06000AAD RID: 2733
		[DispId(5410)]
		string foregroundImage { [DispId(5410)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5410)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000AAE RID: 2734
		// (set) Token: 0x06000AAF RID: 2735
		[DispId(5411)]
		string backgroundImage { [DispId(5411)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5411)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000AB0 RID: 2736
		// (set) Token: 0x06000AB1 RID: 2737
		[DispId(5412)]
		string backgroundHoverImage { [DispId(5412)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5412)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000AB2 RID: 2738
		// (set) Token: 0x06000AB3 RID: 2739
		[DispId(5413)]
		string disabledImage { [DispId(5413)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5413)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000AB4 RID: 2740
		// (set) Token: 0x06000AB5 RID: 2741
		[DispId(5414)]
		string thumbImage { [DispId(5414)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5414)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000AB6 RID: 2742
		// (set) Token: 0x06000AB7 RID: 2743
		[DispId(5415)]
		string thumbHoverImage { [DispId(5415)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5415)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000AB8 RID: 2744
		// (set) Token: 0x06000AB9 RID: 2745
		[DispId(5416)]
		string thumbDownImage { [DispId(5416)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5416)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000ABA RID: 2746
		// (set) Token: 0x06000ABB RID: 2747
		[DispId(5417)]
		string thumbDisabledImage { [DispId(5417)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5417)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000ABC RID: 2748
		// (set) Token: 0x06000ABD RID: 2749
		[DispId(5418)]
		float min { [DispId(5418)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5418)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000ABE RID: 2750
		// (set) Token: 0x06000ABF RID: 2751
		[DispId(5419)]
		float max { [DispId(5419)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5419)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000AC0 RID: 2752
		// (set) Token: 0x06000AC1 RID: 2753
		[DispId(5420)]
		float value { [DispId(5420)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5420)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000AC2 RID: 2754
		// (set) Token: 0x06000AC3 RID: 2755
		[DispId(5421)]
		string toolTip { [DispId(5421)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5421)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000AC4 RID: 2756
		// (set) Token: 0x06000AC5 RID: 2757
		[DispId(5422)]
		string cursor { [DispId(5422)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5422)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000AC6 RID: 2758
		// (set) Token: 0x06000AC7 RID: 2759
		[DispId(5423)]
		int borderSize { [DispId(5423)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5423)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000AC8 RID: 2760
		// (set) Token: 0x06000AC9 RID: 2761
		[DispId(5424)]
		string foregroundHoverImage { [DispId(5424)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5424)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000ACA RID: 2762
		// (set) Token: 0x06000ACB RID: 2763
		[DispId(5425)]
		float foregroundProgress { [DispId(5425)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5425)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000ACC RID: 2764
		// (set) Token: 0x06000ACD RID: 2765
		[DispId(5426)]
		bool useForegroundProgress { [DispId(5426)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5426)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
