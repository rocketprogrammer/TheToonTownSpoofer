using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000084 RID: 132
	[TypeLibType(4160)]
	[Guid("EE4C8FE2-34B2-11D3-A3BF-006097C9B344")]
	[ComImport]
	public interface GInterface23
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000585 RID: 1413
		[DispId(301)]
		int count { [DispId(301)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000586 RID: 1414
		[DispId(302)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface24 imethod_0([In] int lIndex);

		// Token: 0x06000587 RID: 1415
		[DispId(303)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface24 imethod_68([MarshalAs(UnmanagedType.BStr)] [In] string bstrDriveSpecifier);
	}
}
