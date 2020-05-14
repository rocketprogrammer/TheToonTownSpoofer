using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000028 RID: 40
	[InterfaceType(1)]
	[TypeLibType(256)]
	[Guid("56E2294F-69ED-4629-A869-AEA72C0DCC2C")]
	[ComImport]
	public interface GInterface4
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000FA RID: 250
		[DispId(1610678272)]
		Enum3 ripState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000FB RID: 251
		[DispId(1610678273)]
		int ripProgress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060000FC RID: 252
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x060000FD RID: 253
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();
	}
}
