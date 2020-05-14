using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000135 RID: 309
	[Guid("F85E2D65-207D-48DB-84B1-915E1735DB17")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface118 : GInterface117
	{
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001069 RID: 4201
		// (set) Token: 0x0600106A RID: 4202
		[DispId(1)]
		string title { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
