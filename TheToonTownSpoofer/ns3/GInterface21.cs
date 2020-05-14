using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x02000082 RID: 130
	[Guid("679409C0-99F7-11D3-9FB7-00105AA620BB")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface21
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000567 RID: 1383
		[DispId(501)]
		int count { [DispId(501)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000568 RID: 1384
		[DispId(502)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_0([In] int lIndex);
	}
}
