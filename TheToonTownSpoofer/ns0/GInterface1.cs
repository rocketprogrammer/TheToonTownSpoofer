using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000023 RID: 35
	[Guid("1E7601FA-47EA-4107-9EA9-9004ED9684FF")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface1 : GInterface0
	{
		// Token: 0x06000079 RID: 121
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x0600007A RID: 122
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x0600007B RID: 123
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x0600007C RID: 124
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x0600007D RID: 125
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x0600007E RID: 126
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x0600007F RID: 127
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x06000080 RID: 128
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x06000081 RID: 129
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x06000082 RID: 130
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x06000083 RID: 131
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x06000084 RID: 132
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x06000085 RID: 133
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x06000086 RID: 134
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x06000087 RID: 135
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x06000088 RID: 136
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x06000089 RID: 137
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x0600008A RID: 138
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600008B RID: 139
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x0600008C RID: 140
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600008D RID: 141
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x0600008E RID: 142
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x0600008F RID: 143
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000090 RID: 144
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000091 RID: 145
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x06000092 RID: 146
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x06000093 RID: 147
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000094 RID: 148
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000095 RID: 149
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x06000096 RID: 150
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x06000097 RID: 151
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x06000098 RID: 152
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x06000099 RID: 153
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x0600009A RID: 154
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToPlayerApplication();

		// Token: 0x0600009B RID: 155
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToControl();

		// Token: 0x0600009C RID: 156
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerDockedStateChange();

		// Token: 0x0600009D RID: 157
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerReconnect();

		// Token: 0x0600009E RID: 158
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x0600009F RID: 159
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000A0 RID: 160
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyDown([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060000A1 RID: 161
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyPress([In] short nKeyAscii);

		// Token: 0x060000A2 RID: 162
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyUp([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060000A3 RID: 163
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000A4 RID: 164
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000A5 RID: 165
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000A6 RID: 166
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060000A7 RID: 167
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060000A8 RID: 168
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceStatusChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum1 NewStatus);

		// Token: 0x060000A9 RID: 169
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum2 NewState);

		// Token: 0x060000AA RID: 170
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncError([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060000AB RID: 171
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult);
	}
}
