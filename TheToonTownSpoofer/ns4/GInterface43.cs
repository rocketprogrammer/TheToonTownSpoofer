using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x02000098 RID: 152
	[TypeLibType(4160)]
	[Guid("A00918F3-A6B0-4BFB-9189-FD834C7BC5A5")]
	[ComImport]
	public interface GInterface43
	{
		// Token: 0x0600069D RID: 1693
		[DispId(1351)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribute, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOperator, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x0600069E RID: 1694
		[DispId(1352)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();
	}
}
