using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000E7 RID: 231
	[TypeLibType(4160)]
	[Guid("1AD13E0B-4F3A-41DF-9BE2-F9E6FE0A7875")]
	[ComImport]
	public interface GInterface100
	{
		// Token: 0x06000C4B RID: 3147
		[DispId(6501)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string newVal);
	}
}
