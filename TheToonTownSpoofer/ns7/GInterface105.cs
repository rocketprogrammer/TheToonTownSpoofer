using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x020000FB RID: 251
	[TypeLibType(4160)]
	[Guid("58D507B2-2354-11D3-BD41-00C04F6EA5AE")]
	[ComImport]
	public interface GInterface105
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000CF6 RID: 3318
		// (set) Token: 0x06000CF7 RID: 3319
		[DispId(5330)]
		string upToolTip { [DispId(5330)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5330)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000CF8 RID: 3320
		// (set) Token: 0x06000CF9 RID: 3321
		[DispId(5331)]
		string downToolTip { [DispId(5331)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5331)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000CFA RID: 3322
		// (set) Token: 0x06000CFB RID: 3323
		[DispId(5332)]
		string mappingColor { [DispId(5332)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5332)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000CFC RID: 3324
		// (set) Token: 0x06000CFD RID: 3325
		[DispId(5333)]
		bool enabled { [DispId(5333)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5333)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000CFE RID: 3326
		// (set) Token: 0x06000CFF RID: 3327
		[DispId(5339)]
		bool sticky { [DispId(5339)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5339)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D00 RID: 3328
		// (set) Token: 0x06000D01 RID: 3329
		[DispId(5340)]
		bool down { [DispId(5340)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5340)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D02 RID: 3330
		[DispId(5341)]
		int index { [DispId(5341)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D03 RID: 3331
		// (set) Token: 0x06000D04 RID: 3332
		[DispId(5342)]
		bool tabStop { [DispId(5342)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(5342)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D05 RID: 3333
		// (set) Token: 0x06000D06 RID: 3334
		[DispId(5343)]
		string cursor { [DispId(5343)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5343)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000D07 RID: 3335
		[DispId(5344)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D08 RID: 3336
		// (set) Token: 0x06000D09 RID: 3337
		[DispId(5345)]
		string accName { [DispId(5345)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5345)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D0A RID: 3338
		// (set) Token: 0x06000D0B RID: 3339
		[DispId(5346)]
		string accDescription { [DispId(5346)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5346)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D0C RID: 3340
		// (set) Token: 0x06000D0D RID: 3341
		[DispId(5347)]
		string accKeyboardShortcut { [DispId(5347)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(5347)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
