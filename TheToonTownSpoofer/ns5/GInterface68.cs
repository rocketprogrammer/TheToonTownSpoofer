using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000B1 RID: 177
	[TypeLibType(4160)]
	[Guid("946B023E-044C-4473-8018-74954F09DC7E")]
	[ComImport]
	public interface GInterface68
	{
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060009BD RID: 2493
		[DispId(3150)]
		string title { [DispId(3150)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060009BE RID: 2494
		[DispId(3151)]
		string album { [DispId(3151)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060009BF RID: 2495
		[DispId(3153)]
		string URL { [DispId(3153)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700039C RID: 924
		// (set) Token: 0x060009C0 RID: 2496
		[DispId(3152)]
		object image { [DispId(3152)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x1700039D RID: 925
		// (set) Token: 0x060009C1 RID: 2497
		[DispId(3155)]
		bool autoClick { [DispId(3155)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700039E RID: 926
		// (set) Token: 0x060009C2 RID: 2498
		[DispId(3154)]
		bool previewClick { [DispId(3154)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x060009C3 RID: 2499
		[DispId(3156)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();
	}
}
