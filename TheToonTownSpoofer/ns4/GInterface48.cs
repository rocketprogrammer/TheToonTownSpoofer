using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x0200009D RID: 157
	[Guid("8B5050FF-E0A4-4808-B3A8-893A9E1ED894")]
	[InterfaceType(1)]
	[TypeLibType(256)]
	[ComImport]
	public interface GInterface48
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006B0 RID: 1712
		[DispId(1610678272)]
		int deviceCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006B1 RID: 1713
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface2 imethod_0([In] int lIndex);
	}
}
