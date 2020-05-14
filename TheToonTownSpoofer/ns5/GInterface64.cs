using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AD RID: 173
	[TypeLibType(4160)]
	[Guid("43D5AE92-4332-477C-8883-E0B3B063C5D2")]
	[ComImport]
	public interface GInterface64
	{
		// Token: 0x06000911 RID: 2321
		[DispId(3300)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([In] int x, [In] int y, [In] int height, [In] int width);

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000912 RID: 2322
		// (set) Token: 0x06000913 RID: 2323
		[DispId(3301)]
		int frameRate { [DispId(3301)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(3301)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000914 RID: 2324
		[DispId(3302)]
		int mouseX { [DispId(3302)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000915 RID: 2325
		[DispId(3303)]
		int mouseY { [DispId(3303)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700032B RID: 811
		// (set) Token: 0x06000916 RID: 2326
		[DispId(3304)]
		object onsizing { [DispId(3304)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x06000917 RID: 2327
		[DispId(3305)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] string bstrViewID);
	}
}
