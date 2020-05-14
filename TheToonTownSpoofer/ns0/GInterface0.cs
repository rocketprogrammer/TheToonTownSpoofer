using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000021 RID: 33
	[Guid("19A6627B-DA9E-47C1-BB23-00B5E668236A")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface0
	{
		// Token: 0x0600004C RID: 76
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x0600004D RID: 77
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x0600004E RID: 78
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x0600004F RID: 79
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x06000050 RID: 80
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x06000051 RID: 81
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x06000052 RID: 82
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x06000053 RID: 83
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x06000054 RID: 84
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x06000055 RID: 85
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x06000056 RID: 86
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x06000057 RID: 87
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x06000058 RID: 88
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x06000059 RID: 89
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x0600005A RID: 90
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x0600005B RID: 91
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x0600005C RID: 92
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x0600005D RID: 93
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600005E RID: 94
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x0600005F RID: 95
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000060 RID: 96
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x06000061 RID: 97
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x06000062 RID: 98
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000063 RID: 99
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000064 RID: 100
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x06000065 RID: 101
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x06000066 RID: 102
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000067 RID: 103
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000068 RID: 104
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x06000069 RID: 105
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x0600006A RID: 106
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x0600006B RID: 107
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x0600006C RID: 108
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x0600006D RID: 109
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToPlayerApplication();

		// Token: 0x0600006E RID: 110
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToControl();

		// Token: 0x0600006F RID: 111
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerDockedStateChange();

		// Token: 0x06000070 RID: 112
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerReconnect();

		// Token: 0x06000071 RID: 113
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000072 RID: 114
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000073 RID: 115
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyDown([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x06000074 RID: 116
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyPress([In] short nKeyAscii);

		// Token: 0x06000075 RID: 117
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyUp([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x06000076 RID: 118
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000077 RID: 119
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000078 RID: 120
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);
	}
}
