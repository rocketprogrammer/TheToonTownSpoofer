using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000BE RID: 190
	[ClassInterface(0)]
	[ComSourceInterfaces("WMPLib.IWMPSliderCtrlEvents\0\0")]
	[Guid("F2BF2C90-405F-11D3-BB39-00A0C93CA73A")]
	[ComImport]
	public sealed class GClass3 : Interface7, GInterface77, GInterface78
	{
		// Token: 0x06000A53 RID: 2643
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass3();

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A54 RID: 2644
		// (set) Token: 0x06000A55 RID: 2645
		[DispId(5400)]
		public extern string direction { [DispId(5400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5400)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A56 RID: 2646
		// (set) Token: 0x06000A57 RID: 2647
		[DispId(5402)]
		public extern bool slide { [DispId(5402)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5402)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A58 RID: 2648
		// (set) Token: 0x06000A59 RID: 2649
		[DispId(5403)]
		public extern bool tiled { [DispId(5403)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5403)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A5A RID: 2650
		// (set) Token: 0x06000A5B RID: 2651
		[DispId(5404)]
		public extern string foregroundColor { [DispId(5404)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5404)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A5C RID: 2652
		// (set) Token: 0x06000A5D RID: 2653
		[DispId(5405)]
		public extern string foregroundEndColor { [DispId(5405)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5405)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A5E RID: 2654
		// (set) Token: 0x06000A5F RID: 2655
		[DispId(5406)]
		public extern string backgroundColor { [DispId(5406)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5406)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A60 RID: 2656
		// (set) Token: 0x06000A61 RID: 2657
		[DispId(5407)]
		public extern string backgroundEndColor { [DispId(5407)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5407)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A62 RID: 2658
		// (set) Token: 0x06000A63 RID: 2659
		[DispId(5408)]
		public extern string disabledColor { [DispId(5408)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5408)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A64 RID: 2660
		// (set) Token: 0x06000A65 RID: 2661
		[DispId(5409)]
		public extern string transparencyColor { [DispId(5409)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5409)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A66 RID: 2662
		// (set) Token: 0x06000A67 RID: 2663
		[DispId(5410)]
		public extern string foregroundImage { [DispId(5410)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5410)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A68 RID: 2664
		// (set) Token: 0x06000A69 RID: 2665
		[DispId(5411)]
		public extern string backgroundImage { [DispId(5411)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5411)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A6A RID: 2666
		// (set) Token: 0x06000A6B RID: 2667
		[DispId(5412)]
		public extern string backgroundHoverImage { [DispId(5412)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5412)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A6C RID: 2668
		// (set) Token: 0x06000A6D RID: 2669
		[DispId(5413)]
		public extern string disabledImage { [DispId(5413)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5413)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A6E RID: 2670
		// (set) Token: 0x06000A6F RID: 2671
		[DispId(5414)]
		public extern string thumbImage { [DispId(5414)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5414)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A70 RID: 2672
		// (set) Token: 0x06000A71 RID: 2673
		[DispId(5415)]
		public extern string thumbHoverImage { [DispId(5415)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5415)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A72 RID: 2674
		// (set) Token: 0x06000A73 RID: 2675
		[DispId(5416)]
		public extern string thumbDownImage { [DispId(5416)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5416)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A74 RID: 2676
		// (set) Token: 0x06000A75 RID: 2677
		[DispId(5417)]
		public extern string thumbDisabledImage { [DispId(5417)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5417)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A76 RID: 2678
		// (set) Token: 0x06000A77 RID: 2679
		[DispId(5418)]
		public extern float min { [DispId(5418)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5418)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A78 RID: 2680
		// (set) Token: 0x06000A79 RID: 2681
		[DispId(5419)]
		public extern float max { [DispId(5419)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5419)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000A7A RID: 2682
		// (set) Token: 0x06000A7B RID: 2683
		[DispId(5420)]
		public extern float value { [DispId(5420)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5420)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000A7C RID: 2684
		// (set) Token: 0x06000A7D RID: 2685
		[DispId(5421)]
		public extern string toolTip { [DispId(5421)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5421)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000A7E RID: 2686
		// (set) Token: 0x06000A7F RID: 2687
		[DispId(5422)]
		public extern string cursor { [DispId(5422)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5422)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A80 RID: 2688
		// (set) Token: 0x06000A81 RID: 2689
		[DispId(5423)]
		public extern int borderSize { [DispId(5423)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5423)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A82 RID: 2690
		// (set) Token: 0x06000A83 RID: 2691
		[DispId(5424)]
		public extern string foregroundHoverImage { [DispId(5424)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5424)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A84 RID: 2692
		// (set) Token: 0x06000A85 RID: 2693
		[DispId(5425)]
		public extern float foregroundProgress { [DispId(5425)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5425)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A86 RID: 2694
		// (set) Token: 0x06000A87 RID: 2695
		[DispId(5426)]
		public extern bool useForegroundProgress { [DispId(5426)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5426)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x06000A88 RID: 2696
		// (remove) Token: 0x06000A89 RID: 2697
		public extern event Delegate64 ondragbegin;

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06000A8A RID: 2698
		// (remove) Token: 0x06000A8B RID: 2699
		public extern event Delegate65 ondragend;

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06000A8C RID: 2700
		// (remove) Token: 0x06000A8D RID: 2701
		public extern event Delegate66 onpositionchange;
	}
}
