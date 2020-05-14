using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000D2 RID: 210
	[Guid("AE7BFAFE-DCC8-4A73-92C8-CC300CA88859")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass7 : GInterface86, GInterface87
	{
		// Token: 0x06000BA5 RID: 2981
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass7();

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BA6 RID: 2982
		// (set) Token: 0x06000BA7 RID: 2983
		[DispId(5900)]
		public extern int brightness { [DispId(5900)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5900)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BA8 RID: 2984
		// (set) Token: 0x06000BA9 RID: 2985
		[DispId(5901)]
		public extern int contrast { [DispId(5901)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5901)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BAA RID: 2986
		// (set) Token: 0x06000BAB RID: 2987
		[DispId(5902)]
		public extern int hue { [DispId(5902)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5902)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BAC RID: 2988
		// (set) Token: 0x06000BAD RID: 2989
		[DispId(5903)]
		public extern int saturation { [DispId(5903)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5903)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000BAE RID: 2990
		[DispId(5904)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0();
	}
}
