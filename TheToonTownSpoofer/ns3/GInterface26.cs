using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000087 RID: 135
	[TypeLibType(4160)]
	[Guid("A12DCF7D-14AB-4C1B-A8CD-63909F06025B")]
	[ComImport]
	public interface GInterface26
	{
		// Token: 0x06000593 RID: 1427
		[DispId(851)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_58();

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000594 RID: 1428
		[DispId(852)]
		int errorCount { [DispId(852)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000595 RID: 1429
		[DispId(853)]
		GInterface27 Item { [DispId(853)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000596 RID: 1430
		[DispId(854)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_59();
	}
}
