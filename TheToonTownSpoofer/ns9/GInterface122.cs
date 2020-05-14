using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000139 RID: 313
	[Guid("D10CCDFF-472D-498C-B5FE-3630E5405E0A")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface122 : GInterface121
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001090 RID: 4240
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001091 RID: 4241
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700060A RID: 1546
		// (set) Token: 0x06001092 RID: 4242
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001093 RID: 4243
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001094 RID: 4244
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001095 RID: 4245
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001096 RID: 4246
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001097 RID: 4247
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
