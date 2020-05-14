using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x0200009A RID: 154
	[Guid("1D01FBDB-ADE2-4C8D-9842-C190B95C3306")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface45
	{
		// Token: 0x060006A5 RID: 1701
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlugin);

		// Token: 0x060006A6 RID: 1702
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane);

		// Token: 0x060006A7 RID: 1703
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFriendlyName);
	}
}
