using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns9;

namespace ns10
{
	// Token: 0x02000143 RID: 323
	[TypeLibType(4160)]
	[Guid("2D7EF888-1D3C-484A-A906-9F49D99BB344")]
	[ComImport]
	public interface GInterface131 : GInterface122
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060010FE RID: 4350
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060010FF RID: 4351
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000656 RID: 1622
		// (set) Token: 0x06001100 RID: 4352
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001101 RID: 4353
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001102 RID: 4354
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001103 RID: 4355
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001104 RID: 4356
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001105 RID: 4357
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06001106 RID: 4358
		[DispId(10001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrTOC, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMetadata);

		// Token: 0x06001107 RID: 4359
		[DispId(10002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x06001108 RID: 4360
		[DispId(10007)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] Enum12 type, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTypeId, [MarshalAs(UnmanagedType.BStr)] [In] string bstrMetadata, [In] bool fRenameRegroupFiles);

		// Token: 0x06001109 RID: 4361
		[DispId(10008)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string bstrRequestID);

		// Token: 0x0600110A RID: 4362
		[DispId(10011)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x0600110B RID: 4363
		[DispId(10010)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_5();

		// Token: 0x0600110C RID: 4364
		[DispId(10023)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrTitle, [MarshalAs(UnmanagedType.BStr)] [In] string bstrArtist, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAlbum, [MarshalAs(UnmanagedType.BStr)] [In] string bstrUFID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrWMID);
	}
}
