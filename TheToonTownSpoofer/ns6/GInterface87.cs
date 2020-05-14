using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000D4 RID: 212
	[Guid("07EC23DA-EF73-4BDE-A40F-F269E0B7AFD6")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface87
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BAF RID: 2991
		// (set) Token: 0x06000BB0 RID: 2992
		[DispId(5900)]
		int brightness { [DispId(5900)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5900)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BB1 RID: 2993
		// (set) Token: 0x06000BB2 RID: 2994
		[DispId(5901)]
		int contrast { [DispId(5901)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5901)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		[DispId(5902)]
		int hue { [DispId(5902)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5902)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BB5 RID: 2997
		// (set) Token: 0x06000BB6 RID: 2998
		[DispId(5903)]
		int saturation { [DispId(5903)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5903)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000BB7 RID: 2999
		[DispId(5904)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();
	}
}
