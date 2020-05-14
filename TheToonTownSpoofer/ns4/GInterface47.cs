using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x0200009C RID: 156
	[Guid("CBB92747-741F-44FE-AB5B-F1A48F3B2A59")]
	[TypeLibType(256)]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface47
	{
		// Token: 0x060006AC RID: 1708
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] out string pbstrType);

		// Token: 0x060006AD RID: 1709
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] out string pbstrName);

		// Token: 0x060006AE RID: 1710
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] out string pbstrName, [MarshalAs(UnmanagedType.IDispatch)] out object ppDispatch);

		// Token: 0x060006AF RID: 1711
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([MarshalAs(UnmanagedType.BStr)] out string pbstrFile);
	}
}
