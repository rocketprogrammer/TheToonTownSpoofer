using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns0
{
	// Token: 0x02000031 RID: 49
	[TypeLibType(4160)]
	[Guid("8363BC22-B4B4-4B19-989D-1CD765749DD1")]
	[ComImport]
	public interface GInterface9
	{
		// Token: 0x06000130 RID: 304
		[DispId(452)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface7 imethod_13([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x06000131 RID: 305
		[DispId(453)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_14();

		// Token: 0x06000132 RID: 306
		[DispId(454)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_15([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000133 RID: 307
		[DispId(455)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_16([MarshalAs(UnmanagedType.BStr)] [In] string bstrGenre);

		// Token: 0x06000134 RID: 308
		[DispId(456)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_17([MarshalAs(UnmanagedType.BStr)] [In] string bstrAuthor);

		// Token: 0x06000135 RID: 309
		[DispId(457)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_18([MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum);

		// Token: 0x06000136 RID: 310
		[DispId(458)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_19([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000137 RID: 311
		[DispId(459)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_20([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfDeleteFile);

		// Token: 0x06000138 RID: 312
		[DispId(461)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface10 imethod_21([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x06000139 RID: 313
		[DispId(470)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_22([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600013A RID: 314
		[DispId(471)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_23([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfIsDeleted);

		// Token: 0x0600013B RID: 315
		[DispId(472)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_24([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem);
	}
}
