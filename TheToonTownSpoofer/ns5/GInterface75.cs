using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000BC RID: 188
	[TypeLibType(4160)]
	[Guid("63D9D30F-AE4C-4678-8CA8-5720F4FE4419")]
	[ComImport]
	public interface GInterface75
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A48 RID: 2632
		// (set) Token: 0x06000A49 RID: 2633
		[DispId(5670)]
		string columnName { [DispId(5670)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5670)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A4A RID: 2634
		// (set) Token: 0x06000A4B RID: 2635
		[DispId(5671)]
		string columnID { [DispId(5671)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5671)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A4C RID: 2636
		// (set) Token: 0x06000A4D RID: 2637
		[DispId(5672)]
		string columnResizeMode { [DispId(5672)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5672)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A4E RID: 2638
		// (set) Token: 0x06000A4F RID: 2639
		[DispId(5673)]
		int columnWidth { [DispId(5673)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5673)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
