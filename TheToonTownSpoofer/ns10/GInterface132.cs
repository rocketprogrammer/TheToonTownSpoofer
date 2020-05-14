using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns9;

namespace ns10
{
	// Token: 0x02000145 RID: 325
	[Guid("F81B2A59-02BC-4003-8B2F-C124AF66FC66")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface132 : GInterface121
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600110D RID: 4365
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600110E RID: 4366
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700065E RID: 1630
		// (set) Token: 0x0600110F RID: 4367
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }
	}
}
