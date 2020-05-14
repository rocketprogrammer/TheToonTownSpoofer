using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns1
{
	// Token: 0x02000035 RID: 53
	[InterfaceType(1)]
	[Guid("26DABCFA-306B-404D-9A6F-630A8405048D")]
	[ComImport]
	public interface GInterface11 : GInterface3
	{
		// Token: 0x0600013E RID: 318
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x0600013F RID: 319
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x06000140 RID: 320
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x06000141 RID: 321
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x06000142 RID: 322
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x06000143 RID: 323
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x06000144 RID: 324
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x06000145 RID: 325
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x06000146 RID: 326
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x06000147 RID: 327
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x06000148 RID: 328
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x06000149 RID: 329
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x0600014A RID: 330
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x0600014B RID: 331
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x0600014C RID: 332
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x0600014D RID: 333
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x0600014E RID: 334
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x0600014F RID: 335
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000150 RID: 336
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x06000151 RID: 337
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000152 RID: 338
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x06000153 RID: 339
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x06000154 RID: 340
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000155 RID: 341
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000156 RID: 342
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x06000157 RID: 343
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x06000158 RID: 344
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000159 RID: 345
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x0600015A RID: 346
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x0600015B RID: 347
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x0600015C RID: 348
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x0600015D RID: 349
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x0600015E RID: 350
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x0600015F RID: 351
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToPlayerApplication();

		// Token: 0x06000160 RID: 352
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToControl();

		// Token: 0x06000161 RID: 353
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerDockedStateChange();

		// Token: 0x06000162 RID: 354
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerReconnect();

		// Token: 0x06000163 RID: 355
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000164 RID: 356
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000165 RID: 357
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyDown([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x06000166 RID: 358
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyPress([In] short nKeyAscii);

		// Token: 0x06000167 RID: 359
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyUp([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x06000168 RID: 360
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x06000169 RID: 361
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x0600016A RID: 362
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x0600016B RID: 363
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x0600016C RID: 364
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x0600016D RID: 365
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceStatusChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum1 NewStatus);

		// Token: 0x0600016E RID: 366
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum2 NewState);

		// Token: 0x0600016F RID: 367
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncError([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x06000170 RID: 368
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult);

		// Token: 0x06000171 RID: 369
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [In] Enum3 wmprs);

		// Token: 0x06000172 RID: 370
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x06000173 RID: 371
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [In] Enum5 wmpbs);

		// Token: 0x06000174 RID: 372
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x06000175 RID: 373
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.Error)] [In] int hrError);

		// Token: 0x06000176 RID: 374
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x06000177 RID: 375
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x06000178 RID: 376
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void FolderScanStateChange([In] Enum7 wmpfss);

		// Token: 0x06000179 RID: 377
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispStringCollection, [In] Enum8 change, [In] int lCollectionIndex);

		// Token: 0x0600017A RID: 378
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x0600017B RID: 379
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x0600017C RID: 380
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceEstimation([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult, [In] long qwEstimatedUsedSpace, [In] long qwEstimatedSpace);
	}
}
