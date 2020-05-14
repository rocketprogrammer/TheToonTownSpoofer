using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x0200013B RID: 315
	[TypeLibType(4160)]
	[Guid("2E922378-EE70-4CEB-BBAB-CE7CE4A04816")]
	[ComImport]
	public interface GInterface124 : GInterface123
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060010A3 RID: 4259
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060010A4 RID: 4260
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700061B RID: 1563
		// (set) Token: 0x060010A5 RID: 4261
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060010A6 RID: 4262
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060010A7 RID: 4263
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060010A8 RID: 4264
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060010A9 RID: 4265
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060010AA RID: 4266
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010AB RID: 4267
		[DispId(10026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams);

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060010AD RID: 4269
		// (set) Token: 0x060010AC RID: 4268
		[DispId(10027)]
		string SelectedTaskPane { [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060010AE RID: 4270
		[DispId(10009)]
		GInterface125 DownloadManager { [DispId(10009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
