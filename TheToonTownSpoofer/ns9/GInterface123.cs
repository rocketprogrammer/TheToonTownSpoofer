using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x0200013A RID: 314
	[TypeLibType(4160)]
	[Guid("54DF358E-CF38-4010-99F1-F44B0E9000E5")]
	[ComImport]
	public interface GInterface123 : GInterface122
	{
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001098 RID: 4248
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001099 RID: 4249
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000612 RID: 1554
		// (set) Token: 0x0600109A RID: 4250
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600109B RID: 4251
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600109C RID: 4252
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600109D RID: 4253
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600109E RID: 4254
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600109F RID: 4255
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010A0 RID: 4256
		[DispId(10026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams);

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060010A2 RID: 4258
		// (set) Token: 0x060010A1 RID: 4257
		[DispId(10027)]
		string SelectedTaskPane { [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
