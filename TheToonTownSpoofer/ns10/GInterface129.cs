using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns9;

namespace ns10
{
	// Token: 0x02000141 RID: 321
	[Guid("5F0248C1-62B3-42D7-B927-029119E6AD14")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface129 : GInterface123
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060010C8 RID: 4296
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060010C9 RID: 4297
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000631 RID: 1585
		// (set) Token: 0x060010CA RID: 4298
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060010CB RID: 4299
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060010CC RID: 4300
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060010CD RID: 4301
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060010CE RID: 4302
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060010CF RID: 4303
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010D0 RID: 4304
		[DispId(10026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams);

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060010D2 RID: 4306
		// (set) Token: 0x060010D1 RID: 4305
		[DispId(10027)]
		string SelectedTaskPane { [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060010D3 RID: 4307
		[DispId(10004)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);
	}
}
