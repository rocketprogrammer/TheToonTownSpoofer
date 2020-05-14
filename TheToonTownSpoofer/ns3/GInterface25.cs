using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000086 RID: 134
	[Guid("4F2DF574-C588-11D3-9ED0-00C04FB6E937")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface25
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600058B RID: 1419
		// (set) Token: 0x0600058C RID: 1420
		[DispId(951)]
		string SAMIStyle { [DispId(951)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(951)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600058D RID: 1421
		// (set) Token: 0x0600058E RID: 1422
		[DispId(952)]
		string SAMILang { [DispId(952)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(952)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600058F RID: 1423
		// (set) Token: 0x06000590 RID: 1424
		[DispId(953)]
		string SAMIFileName { [DispId(953)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(953)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000591 RID: 1425
		// (set) Token: 0x06000592 RID: 1426
		[DispId(954)]
		string captioningId { [DispId(954)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(954)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
