using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000138 RID: 312
	[Guid("E2CC638C-FD2C-409B-A1EA-5DDB72DC8E84")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface121
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600108D RID: 4237
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600108E RID: 4238
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000607 RID: 1543
		// (set) Token: 0x0600108F RID: 4239
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }
	}
}
