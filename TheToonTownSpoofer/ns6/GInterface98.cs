using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000E4 RID: 228
	[Guid("158A7ADC-33DA-4039-A553-BDDBBE389F5C")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface98
	{
		// Token: 0x06000C3F RID: 3135
		[DispId(6301)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x06000C40 RID: 3136
		[DispId(6302)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] int nID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrItem);

		// Token: 0x06000C41 RID: 3137
		[DispId(6303)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x06000C42 RID: 3138
		[DispId(6304)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int nID, [In] bool newVal);

		// Token: 0x06000C43 RID: 3139
		[DispId(6305)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([In] int nID, [In] bool newVal);

		// Token: 0x06000C44 RID: 3140
		[DispId(6306)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([In] int nID, [In] bool newVal);

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000C45 RID: 3141
		// (set) Token: 0x06000C46 RID: 3142
		[DispId(6307)]
		int showFlags { [DispId(6307)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6307)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000C47 RID: 3143
		[DispId(6308)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_6();

		// Token: 0x06000C48 RID: 3144
		[DispId(6309)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([In] int nID);
	}
}
