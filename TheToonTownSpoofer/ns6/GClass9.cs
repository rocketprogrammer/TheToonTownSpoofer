using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns6
{
	// Token: 0x020000D8 RID: 216
	[ClassInterface(0)]
	[Guid("D9DE732A-AEE9-4503-9D11-5605589977A8")]
	[ComImport]
	public sealed class GClass9 : GInterface90, GInterface91
	{
		// Token: 0x06000BBF RID: 3007
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass9();

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BC0 RID: 3008
		// (set) Token: 0x06000BC1 RID: 3009
		[DispId(6401)]
		public extern bool dropDownVisible { [DispId(6401)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6401)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BC2 RID: 3010
		// (set) Token: 0x06000BC3 RID: 3011
		[DispId(6402)]
		public extern string foregroundColor { [DispId(6402)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6402)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000BC4 RID: 3012
		// (set) Token: 0x06000BC5 RID: 3013
		[DispId(6403)]
		public extern string backgroundColor { [DispId(6403)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6403)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000BC6 RID: 3014
		// (set) Token: 0x06000BC7 RID: 3015
		[DispId(6404)]
		public extern int fontSize { [DispId(6404)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6404)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000BC8 RID: 3016
		// (set) Token: 0x06000BC9 RID: 3017
		[DispId(6405)]
		public extern string fontStyle { [DispId(6405)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6405)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000BCA RID: 3018
		// (set) Token: 0x06000BCB RID: 3019
		[DispId(6406)]
		public extern string fontFace { [DispId(6406)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6406)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000BCC RID: 3020
		// (set) Token: 0x06000BCD RID: 3021
		[DispId(6407)]
		public extern string filter { [DispId(6407)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6407)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000BCE RID: 3022
		// (set) Token: 0x06000BCF RID: 3023
		[DispId(6408)]
		public extern string expandState { [DispId(6408)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6408)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000BD0 RID: 3024
		// (set) Token: 0x06000BD1 RID: 3025
		[DispId(6409)]
		public extern GInterface6 Playlist { [DispId(6409)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6409)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000BD2 RID: 3026
		[DispId(6410)]
		public extern GInterface6 selectedPlaylist { [DispId(6410)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000BD3 RID: 3027
		[DispId(6411)]
		public extern GInterface7 selectedMedia { [DispId(6411)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
