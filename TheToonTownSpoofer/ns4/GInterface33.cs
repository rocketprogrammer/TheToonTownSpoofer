using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns3;

namespace ns4
{
	// Token: 0x0200008E RID: 142
	[Guid("F75CCEC0-C67C-475C-931E-8719870BEE7D")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface33 : GInterface27
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000606 RID: 1542
		[DispId(901)]
		int errorCode { [DispId(901)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000607 RID: 1543
		[DispId(902)]
		string errorDescription { [DispId(902)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000608 RID: 1544
		[DispId(903)]
		object errorContext { [DispId(903)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000609 RID: 1545
		[DispId(904)]
		int remedy { [DispId(904)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600060A RID: 1546
		[DispId(905)]
		string customUrl { [DispId(905)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600060B RID: 1547
		[DispId(906)]
		int condition { [DispId(906)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
