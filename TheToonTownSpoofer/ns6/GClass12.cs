using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000E2 RID: 226
	[Guid("BAB3768B-8883-4AEC-9F9B-E14C947913EF")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass12 : GInterface97, GInterface98
	{
		// Token: 0x06000C34 RID: 3124
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass12();

		// Token: 0x06000C35 RID: 3125
		[DispId(6301)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();

		// Token: 0x06000C36 RID: 3126
		[DispId(6302)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_1([In] int nID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrItem);

		// Token: 0x06000C37 RID: 3127
		[DispId(6303)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_2();

		// Token: 0x06000C38 RID: 3128
		[DispId(6304)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3([In] int nID, [In] bool newVal);

		// Token: 0x06000C39 RID: 3129
		[DispId(6305)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4([In] int nID, [In] bool newVal);

		// Token: 0x06000C3A RID: 3130
		[DispId(6306)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_5([In] int nID, [In] bool newVal);

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000C3B RID: 3131
		// (set) Token: 0x06000C3C RID: 3132
		[DispId(6307)]
		public extern int showFlags { [DispId(6307)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6307)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000C3D RID: 3133
		[DispId(6308)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_6();

		// Token: 0x06000C3E RID: 3134
		[DispId(6309)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_7([In] int nID);
	}
}
