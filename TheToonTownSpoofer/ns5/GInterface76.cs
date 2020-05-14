using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000BD RID: 189
	[Guid("CDAC14D2-8BE4-11D3-BB48-00A0C93CA73A")]
	[TypeLibType(4096)]
	[InterfaceType(2)]
	[ComImport]
	public interface GInterface76
	{
		// Token: 0x06000A50 RID: 2640
		[DispId(5430)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ondragbegin();

		// Token: 0x06000A51 RID: 2641
		[DispId(5431)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ondragend();

		// Token: 0x06000A52 RID: 2642
		[DispId(5432)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void onpositionchange();
	}
}
