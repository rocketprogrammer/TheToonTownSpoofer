using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000C5 RID: 197
	[Guid("A85C0477-714C-4A06-B9F6-7C8CA38B45DC")]
	[InterfaceType(2)]
	[TypeLibType(4096)]
	[ComImport]
	public interface GInterface79
	{
		// Token: 0x06000ACE RID: 2766
		[DispId(5720)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void onvideostart();

		// Token: 0x06000ACF RID: 2767
		[DispId(5721)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void onvideoend();
	}
}
