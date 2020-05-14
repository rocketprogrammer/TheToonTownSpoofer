using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns6
{
	// Token: 0x020000DA RID: 218
	[TypeLibType(4160)]
	[Guid("B738FCAE-F089-45DF-AED6-034B9E7DB632")]
	[ComImport]
	public interface GInterface91
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000BD4 RID: 3028
		// (set) Token: 0x06000BD5 RID: 3029
		[DispId(6401)]
		bool dropDownVisible { [DispId(6401)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6401)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000BD6 RID: 3030
		// (set) Token: 0x06000BD7 RID: 3031
		[DispId(6402)]
		string foregroundColor { [DispId(6402)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6402)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000BD8 RID: 3032
		// (set) Token: 0x06000BD9 RID: 3033
		[DispId(6403)]
		string backgroundColor { [DispId(6403)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6403)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000BDA RID: 3034
		// (set) Token: 0x06000BDB RID: 3035
		[DispId(6404)]
		int fontSize { [DispId(6404)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6404)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000BDC RID: 3036
		// (set) Token: 0x06000BDD RID: 3037
		[DispId(6405)]
		string fontStyle { [DispId(6405)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6405)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000BDE RID: 3038
		// (set) Token: 0x06000BDF RID: 3039
		[DispId(6406)]
		string fontFace { [DispId(6406)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6406)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000BE0 RID: 3040
		// (set) Token: 0x06000BE1 RID: 3041
		[DispId(6407)]
		string filter { [DispId(6407)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6407)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000BE2 RID: 3042
		// (set) Token: 0x06000BE3 RID: 3043
		[DispId(6408)]
		string expandState { [DispId(6408)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6408)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000BE4 RID: 3044
		// (set) Token: 0x06000BE5 RID: 3045
		[DispId(6409)]
		GInterface6 Playlist { [DispId(6409)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6409)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000BE6 RID: 3046
		[DispId(6410)]
		GInterface6 selectedPlaylist { [DispId(6410)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000BE7 RID: 3047
		[DispId(6411)]
		GInterface7 selectedMedia { [DispId(6411)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
