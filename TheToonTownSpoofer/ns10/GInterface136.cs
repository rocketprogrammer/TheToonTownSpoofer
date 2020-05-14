using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns10
{
	// Token: 0x02000149 RID: 329
	[Guid("FF4B1BDA-19F0-42CF-8DDA-19162950C543")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface136
	{
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600114D RID: 4429
		[DispId(1)]
		string LastChange { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600114E RID: 4430
		[DispId(2)]
		string PresetNameList { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600114F RID: 4431
		[DispId(3)]
		bool mute { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001150 RID: 4432
		[DispId(4)]
		ushort volume { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001151 RID: 4433
		[DispId(5)]
		string A_ARG_TYPE_Channel { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001152 RID: 4434
		[DispId(6)]
		uint A_ARG_TYPE_InstanceID { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001153 RID: 4435
		[DispId(7)]
		string A_ARG_TYPE_PresetName { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06001154 RID: 4436
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrCurrentPresetList);

		// Token: 0x06001155 RID: 4437
		[DispId(9)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPresetName);

		// Token: 0x06001156 RID: 4438
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrChannel, [In] [Out] ref bool pbCurrentMute);

		// Token: 0x06001157 RID: 4439
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrChannel, [In] bool bDesiredMute);

		// Token: 0x06001158 RID: 4440
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrChannel, [In] [Out] ref ushort puiCurrentVolume);

		// Token: 0x06001159 RID: 4441
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrChannel, [In] ushort uiDesiredVolume);
	}
}
