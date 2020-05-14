using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x0200009B RID: 155
	[Guid("1BB1592F-F040-418A-9F71-17C7512B4D70")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface46 : GInterface45
	{
		// Token: 0x060006A8 RID: 1704
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlugin);

		// Token: 0x060006A9 RID: 1705
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane);

		// Token: 0x060006AA RID: 1706
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFriendlyName);

		// Token: 0x060006AB RID: 1707
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrPriority);
	}
}
