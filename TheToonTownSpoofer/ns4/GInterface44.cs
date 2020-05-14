using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns4
{
	// Token: 0x02000099 RID: 153
	[TypeLibType(4160)]
	[Guid("46AD648D-53F1-4A74-92E2-2A1B68D63FD4")]
	[ComImport]
	public interface GInterface44 : GInterface10
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600069F RID: 1695
		[DispId(401)]
		int count { [DispId(401)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006A0 RID: 1696
		[DispId(402)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_1([In] int lIndex);

		// Token: 0x060006A1 RID: 1697
		[DispId(1451)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_2([MarshalAs(UnmanagedType.Interface)] [In] GInterface44 pIWMPStringCollection2);

		// Token: 0x060006A2 RID: 1698
		[DispId(1452)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_47([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060006A3 RID: 1699
		[DispId(1453)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_48([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage);

		// Token: 0x060006A4 RID: 1700
		[DispId(1454)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object imethod_49([In] int lCollectionIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLanguage, [In] int lAttributeIndex);
	}
}
