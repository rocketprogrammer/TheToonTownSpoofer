using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200002F RID: 47
	[InterfaceType(1)]
	[Guid("3DF47861-7DF1-4C1F-A81B-4C26F0F7A7C6")]
	[TypeLibType(256)]
	[ComImport]
	public interface GInterface8
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600012C RID: 300
		[DispId(1610678272)]
		string name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600012D RID: 301
		[DispId(1610678273)]
		Enum6 type { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600012E RID: 302
		[DispId(1610678274)]
		GInterface9 mediaCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600012F RID: 303
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_0([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pIWMPLibrary);
	}
}
