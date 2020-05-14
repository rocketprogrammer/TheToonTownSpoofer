using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000BB RID: 187
	[Guid("D255DFB8-C22A-42CF-B8B7-F15D7BCF65D6")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface74
	{
		// Token: 0x170003D3 RID: 979
		// (set) Token: 0x06000A47 RID: 2631
		[DispId(6119)]
		string value { [DispId(6119)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
