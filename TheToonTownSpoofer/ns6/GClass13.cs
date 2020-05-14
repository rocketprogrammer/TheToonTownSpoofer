using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns7;

namespace ns6
{
	// Token: 0x020000E5 RID: 229
	[Guid("6B28F900-8D64-4B80-9963-CC52DDD1FBB4")]
	[ClassInterface(0)]
	[ComImport]
	public sealed class GClass13 : GInterface99, GInterface100
	{
		// Token: 0x06000C49 RID: 3145
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass13();

		// Token: 0x06000C4A RID: 3146
		[DispId(6501)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string newVal);
	}
}
