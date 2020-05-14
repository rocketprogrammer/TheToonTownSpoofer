using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000FC RID: 252
	[InterfaceType(2)]
	[TypeLibType(4096)]
	[Guid("95F45AA4-ED0A-11D2-BA67-0000F80855E6")]
	[ComImport]
	public interface GInterface106
	{
		// Token: 0x06000D0E RID: 3342
		[DispId(5020)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ondragbegin();

		// Token: 0x06000D0F RID: 3343
		[DispId(5021)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ondragend();

		// Token: 0x06000D10 RID: 3344
		[DispId(5022)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void onpositionchange();
	}
}
