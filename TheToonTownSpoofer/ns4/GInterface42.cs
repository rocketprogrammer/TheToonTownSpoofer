using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;

namespace ns4
{
	// Token: 0x02000097 RID: 151
	[TypeLibType(4160)]
	[Guid("8BA957F5-FD8C-4791-B82D-F840401EE474")]
	[ComImport]
	public interface GInterface42 : GInterface9
	{
		// Token: 0x0600068D RID: 1677
		[DispId(452)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface7 imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x0600068E RID: 1678
		[DispId(453)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_1();

		// Token: 0x0600068F RID: 1679
		[DispId(454)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000690 RID: 1680
		[DispId(455)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string bstrGenre);

		// Token: 0x06000691 RID: 1681
		[DispId(456)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string bstrAuthor);

		// Token: 0x06000692 RID: 1682
		[DispId(457)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum);

		// Token: 0x06000693 RID: 1683
		[DispId(458)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000694 RID: 1684
		[DispId(459)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfDeleteFile);

		// Token: 0x06000695 RID: 1685
		[DispId(461)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface10 imethod_8([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);

		// Token: 0x06000696 RID: 1686
		[DispId(470)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_9([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000697 RID: 1687
		[DispId(471)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem, [In] bool varfIsDeleted);

		// Token: 0x06000698 RID: 1688
		[DispId(472)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pItem);

		// Token: 0x06000699 RID: 1689
		[DispId(1401)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface43 imethod_43();

		// Token: 0x0600069A RID: 1690
		[DispId(1402)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_44([MarshalAs(UnmanagedType.Interface)] [In] GInterface43 pQuery, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSortAttribute, [In] bool fSortAscending);

		// Token: 0x0600069B RID: 1691
		[DispId(1403)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface10 imethod_45([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.Interface)] [In] GInterface43 pQuery, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSortAttribute, [In] bool fSortAscending);

		// Token: 0x0600069C RID: 1692
		[DispId(1404)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_46([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMediaType);
	}
}
