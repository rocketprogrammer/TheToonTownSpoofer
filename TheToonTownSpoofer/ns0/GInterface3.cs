using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns0
{
	// Token: 0x02000027 RID: 39
	[Guid("1F504270-A66B-4223-8E96-26A06C63D69F")]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface3 : GInterface1
	{
		// Token: 0x060000BC RID: 188
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x060000BD RID: 189
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x060000BE RID: 190
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x060000BF RID: 191
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x060000C0 RID: 192
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x060000C1 RID: 193
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x060000C2 RID: 194
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x060000C3 RID: 195
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x060000C4 RID: 196
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x060000C5 RID: 197
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x060000C6 RID: 198
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x060000C7 RID: 199
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x060000C8 RID: 200
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x060000C9 RID: 201
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x060000CA RID: 202
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x060000CB RID: 203
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x060000CC RID: 204
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x060000CD RID: 205
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060000CE RID: 206
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x060000CF RID: 207
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060000D0 RID: 208
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x060000D1 RID: 209
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x060000D2 RID: 210
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x060000D3 RID: 211
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x060000D4 RID: 212
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x060000D5 RID: 213
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x060000D6 RID: 214
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x060000D7 RID: 215
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x060000D8 RID: 216
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x060000D9 RID: 217
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x060000DA RID: 218
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x060000DB RID: 219
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x060000DC RID: 220
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x060000DD RID: 221
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToPlayerApplication();

		// Token: 0x060000DE RID: 222
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToControl();

		// Token: 0x060000DF RID: 223
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerDockedStateChange();

		// Token: 0x060000E0 RID: 224
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerReconnect();

		// Token: 0x060000E1 RID: 225
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000E2 RID: 226
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000E3 RID: 227
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyDown([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060000E4 RID: 228
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyPress([In] short nKeyAscii);

		// Token: 0x060000E5 RID: 229
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyUp([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060000E6 RID: 230
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000E7 RID: 231
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000E8 RID: 232
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060000E9 RID: 233
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060000EA RID: 234
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060000EB RID: 235
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceStatusChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum1 NewStatus);

		// Token: 0x060000EC RID: 236
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum2 NewState);

		// Token: 0x060000ED RID: 237
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncError([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060000EE RID: 238
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult);

		// Token: 0x060000EF RID: 239
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [In] Enum3 wmprs);

		// Token: 0x060000F0 RID: 240
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060000F1 RID: 241
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [In] Enum5 wmpbs);

		// Token: 0x060000F2 RID: 242
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060000F3 RID: 243
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.Error)] [In] int hrError);

		// Token: 0x060000F4 RID: 244
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x060000F5 RID: 245
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x060000F6 RID: 246
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void FolderScanStateChange([In] Enum7 wmpfss);

		// Token: 0x060000F7 RID: 247
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispStringCollection, [In] Enum8 change, [In] int lCollectionIndex);

		// Token: 0x060000F8 RID: 248
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x060000F9 RID: 249
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);
	}
}
