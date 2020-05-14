using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns8
{
	// Token: 0x02000109 RID: 265
	[Guid("891EADB1-1C45-48B0-B704-49A888DA98C4")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface112
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E0A RID: 3594
		// (set) Token: 0x06000E0B RID: 3595
		[DispId(1610743808)]
		object CurrentContainer { [DispId(1610743808)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [DispId(1610743808)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IUnknown)] [param: In] set; }

		// Token: 0x06000E0C RID: 3596
		[DispId(1610743810)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();
	}
}
