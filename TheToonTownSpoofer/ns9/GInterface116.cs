using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000133 RID: 307
	[TypeLibType(4160)]
	[Guid("F8578BFA-CD8F-4CE1-A684-5B7E85FCA7DC")]
	[ComImport]
	public interface GInterface116
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001065 RID: 4197
		[DispId(1)]
		int presetCount { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001066 RID: 4198
		[DispId(2)]
		object preset { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }
	}
}
