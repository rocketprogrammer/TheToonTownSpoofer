using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x0200013D RID: 317
	[TypeLibType(4160)]
	[Guid("0A319C7F-85F9-436C-B88E-82FD88000E1C")]
	[ComImport]
	public interface GInterface126
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060010B1 RID: 4273
		[DispId(1201)]
		int ID { [DispId(1201)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060010B2 RID: 4274
		[DispId(1202)]
		int count { [DispId(1202)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010B3 RID: 4275
		[DispId(1203)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface127 imethod_0([In] int lItem);

		// Token: 0x060010B4 RID: 4276
		[DispId(1204)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface127 imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrSourceURL, [MarshalAs(UnmanagedType.BStr)] [In] string bstrType);

		// Token: 0x060010B5 RID: 4277
		[DispId(1205)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] int lItem);

		// Token: 0x060010B6 RID: 4278
		[DispId(1206)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();
	}
}
