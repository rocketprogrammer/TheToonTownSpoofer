using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000137 RID: 311
	[TypeLibType(4160)]
	[Guid("33E9291A-F6A9-11D2-9435-00A0C92A2F2D")]
	[ComImport]
	public interface GInterface120
	{
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600106D RID: 4205
		// (set) Token: 0x0600106E RID: 4206
		[DispId(8000)]
		int displayMode { [DispId(8000)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600106F RID: 4207
		// (set) Token: 0x06001070 RID: 4208
		[DispId(8001)]
		bool showPeaks { [DispId(8001)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001071 RID: 4209
		// (set) Token: 0x06001072 RID: 4210
		[DispId(8002)]
		int peakHangTime { [DispId(8002)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001073 RID: 4211
		// (set) Token: 0x06001074 RID: 4212
		[DispId(8003)]
		float peakFallbackAcceleration { [DispId(8003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001075 RID: 4213
		// (set) Token: 0x06001076 RID: 4214
		[DispId(8004)]
		float peakFallbackSpeed { [DispId(8004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001077 RID: 4215
		// (set) Token: 0x06001078 RID: 4216
		[DispId(8005)]
		float levelFallbackAcceleration { [DispId(8005)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001079 RID: 4217
		// (set) Token: 0x0600107A RID: 4218
		[DispId(8006)]
		float levelFallbackSpeed { [DispId(8006)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600107B RID: 4219
		// (set) Token: 0x0600107C RID: 4220
		[DispId(8007)]
		string backgroundColor { [DispId(8007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(8007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600107D RID: 4221
		// (set) Token: 0x0600107E RID: 4222
		[DispId(8008)]
		string levelColor { [DispId(8008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(8008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600107F RID: 4223
		// (set) Token: 0x06001080 RID: 4224
		[DispId(8009)]
		string peakColor { [DispId(8009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(8009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001081 RID: 4225
		// (set) Token: 0x06001082 RID: 4226
		[DispId(8010)]
		int horizontalSpacing { [DispId(8010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001083 RID: 4227
		// (set) Token: 0x06001084 RID: 4228
		[DispId(8012)]
		int levelWidth { [DispId(8012)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8012)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001085 RID: 4229
		// (set) Token: 0x06001086 RID: 4230
		[DispId(8013)]
		float levelScale { [DispId(8013)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8013)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001087 RID: 4231
		// (set) Token: 0x06001088 RID: 4232
		[DispId(8014)]
		int fadeRate { [DispId(8014)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8014)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001089 RID: 4233
		// (set) Token: 0x0600108A RID: 4234
		[DispId(8015)]
		int fadeMode { [DispId(8015)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8015)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600108B RID: 4235
		// (set) Token: 0x0600108C RID: 4236
		[DispId(8016)]
		bool transparent { [DispId(8016)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(8016)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
