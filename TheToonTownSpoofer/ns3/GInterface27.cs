using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000088 RID: 136
	[TypeLibType(4160)]
	[Guid("3614C646-3B3B-4DE7-A81E-930E3F2127B3")]
	[ComImport]
	public interface GInterface27
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000597 RID: 1431
		[DispId(901)]
		int errorCode { [DispId(901)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000598 RID: 1432
		[DispId(902)]
		string errorDescription { [DispId(902)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000599 RID: 1433
		[DispId(903)]
		object errorContext { [DispId(903)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600059A RID: 1434
		[DispId(904)]
		int remedy { [DispId(904)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600059B RID: 1435
		[DispId(905)]
		string customUrl { [DispId(905)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
