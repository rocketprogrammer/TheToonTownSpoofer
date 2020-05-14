using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000D5 RID: 213
	[ClassInterface(0)]
	[Guid("1EA16D11-DCB1-41FE-BC17-42CDFBEF8F53")]
	[ComImport]
	public sealed class GClass8 : GInterface88, GInterface89
	{
		// Token: 0x06000BB8 RID: 3000
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass8();

		// Token: 0x06000BB9 RID: 3001
		[DispId(5950)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BBA RID: 3002
		// (set) Token: 0x06000BBB RID: 3003
		[DispId(5951)]
		public extern int currentPreset { [DispId(5951)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5951)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
