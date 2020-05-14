using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000D7 RID: 215
	[Guid("BBD6801A-A1D4-4D05-9F2D-29E0024C3FD9")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface89
	{
		// Token: 0x06000BBC RID: 3004
		[DispId(5950)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BBD RID: 3005
		// (set) Token: 0x06000BBE RID: 3006
		[DispId(5951)]
		int currentPreset { [DispId(5951)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5951)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
