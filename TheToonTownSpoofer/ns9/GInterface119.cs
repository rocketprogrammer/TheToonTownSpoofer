using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000136 RID: 310
	[Guid("876E7208-0172-4EBB-B08B-2E1D30DFE44C")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface119 : GInterface117
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600106B RID: 4203
		// (set) Token: 0x0600106C RID: 4204
		[DispId(1)]
		string title { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
