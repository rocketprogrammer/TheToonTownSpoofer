using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns9;

namespace ns10
{
	// Token: 0x02000146 RID: 326
	[Guid("3148E685-B243-423D-8341-8480D6EFF674")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface133 : GInterface121
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001110 RID: 4368
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001111 RID: 4369
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000661 RID: 1633
		// (set) Token: 0x06001112 RID: 4370
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x06001113 RID: 4371
		[DispId(10025)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();
	}
}
