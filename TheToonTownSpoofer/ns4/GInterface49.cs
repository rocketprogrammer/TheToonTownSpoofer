using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns4
{
	// Token: 0x0200009E RID: 158
	[TypeLibType(256)]
	[Guid("39C2F8D5-1CF2-4D5E-AE09-D73492CF9EAA")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface49
	{
		// Token: 0x060006B2 RID: 1714
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_0([In] Enum6 wmplt);

		// Token: 0x060006B3 RID: 1715
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface8 imethod_1([In] Enum6 wmplt, [In] int lIndex);
	}
}
