using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x0200008A RID: 138
	[TypeLibType(4160)]
	[Guid("40897764-CEAB-47BE-AD4A-8E28537F9BBF")]
	[ComImport]
	public interface GInterface29
	{
		// Token: 0x060005A2 RID: 1442
		[DispId(1101)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x060005A3 RID: 1443
		[DispId(1102)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005A4 RID: 1444
		[DispId(1103)]
		bool playerDocked { [DispId(1103)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005A5 RID: 1445
		[DispId(1104)]
		bool hasDisplay { [DispId(1104)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
