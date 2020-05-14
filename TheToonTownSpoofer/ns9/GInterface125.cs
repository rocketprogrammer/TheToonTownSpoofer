using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x0200013C RID: 316
	[Guid("E15E9AD1-8F20-4CC4-9EC7-1A328CA86A0D")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface125
	{
		// Token: 0x060010AF RID: 4271
		[DispId(1151)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface126 imethod_0([In] int lCollectionId);

		// Token: 0x060010B0 RID: 4272
		[DispId(1152)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface126 imethod_1();
	}
}
