using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AA RID: 170
	[TypeLibType(4160)]
	[Guid("5AF0BEC1-46AA-11D3-BD45-00C04F6EA5AE")]
	[ComImport]
	public interface GInterface61
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000865 RID: 2149
		[DispId(2200)]
		object srcElement { [DispId(2200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000866 RID: 2150
		[DispId(2201)]
		bool altKey { [DispId(2201)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000867 RID: 2151
		[DispId(2202)]
		bool ctrlKey { [DispId(2202)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000868 RID: 2152
		[DispId(2203)]
		bool shiftKey { [DispId(2203)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000869 RID: 2153
		[DispId(2204)]
		object fromElement { [DispId(2204)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600086A RID: 2154
		[DispId(2205)]
		object toElement { [DispId(2205)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600086C RID: 2156
		// (set) Token: 0x0600086B RID: 2155
		[DispId(2206)]
		int keyCode { [DispId(2206)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(2206)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600086D RID: 2157
		[DispId(2207)]
		int button { [DispId(2207)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600086E RID: 2158
		[DispId(2208)]
		int x { [DispId(2208)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600086F RID: 2159
		[DispId(2209)]
		int y { [DispId(2209)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000870 RID: 2160
		[DispId(2210)]
		int clientX { [DispId(2210)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000871 RID: 2161
		[DispId(2211)]
		int clientY { [DispId(2211)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000872 RID: 2162
		[DispId(2212)]
		int offsetX { [DispId(2212)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000873 RID: 2163
		[DispId(2213)]
		int offsetY { [DispId(2213)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000874 RID: 2164
		[DispId(2214)]
		int screenX { [DispId(2214)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000875 RID: 2165
		[DispId(2215)]
		int screenY { [DispId(2215)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000876 RID: 2166
		[DispId(2216)]
		int screenWidth { [DispId(2216)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000877 RID: 2167
		[DispId(2217)]
		int screenHeight { [DispId(2217)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000878 RID: 2168
		[DispId(2218)]
		bool penOrTouch { [DispId(2218)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
