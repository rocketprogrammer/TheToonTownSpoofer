using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x02000032 RID: 50
	[TypeLibType(4160)]
	[Guid("4A976298-8C0D-11D3-B389-00C04F68574B")]
	[ComImport]
	public interface GInterface10
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013C RID: 316
		[DispId(401)]
		int count { [DispId(401)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600013D RID: 317
		[DispId(402)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([In] int lIndex);
	}
}
