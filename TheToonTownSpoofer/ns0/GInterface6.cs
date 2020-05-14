using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200002C RID: 44
	[TypeLibType(4160)]
	[Guid("D5F0F4F1-130C-11D3-B14E-00C04F79FAA6")]
	[ComImport]
	public interface GInterface6
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600010C RID: 268
		[DispId(201)]
		int count { [DispId(201)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600010D RID: 269
		// (set) Token: 0x0600010E RID: 270
		[DispId(202)]
		string name { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600010F RID: 271
		[DispId(210)]
		int attributeCount { [DispId(210)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000110 RID: 272
		[DispId(211)]
		string attributeName { [DispId(211)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000111 RID: 273
		[DispId(212)]
		GInterface7 Item { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000112 RID: 274
		[DispId(203)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000113 RID: 275
		[DispId(204)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000114 RID: 276
		[DispId(213)]
		bool isIdentical { [DispId(213)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000115 RID: 277
		[DispId(205)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x06000116 RID: 278
		[DispId(206)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int lIndex, [MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000117 RID: 279
		[DispId(207)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000118 RID: 280
		[DispId(208)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x06000119 RID: 281
		[DispId(209)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6(int lIndexOld, int lIndexNew);
	}
}
