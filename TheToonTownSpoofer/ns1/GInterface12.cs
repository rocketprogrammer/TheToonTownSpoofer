using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns1
{
	// Token: 0x02000036 RID: 54
	[TypeLibType(4112)]
	[InterfaceType(2)]
	[Guid("6BF52A51-394A-11D3-B153-00C04F79FAA6")]
	[ComImport]
	public interface GInterface12
	{
		// Token: 0x0600017D RID: 381
		[DispId(5001)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x0600017E RID: 382
		[DispId(5101)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x0600017F RID: 383
		[DispId(5102)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x06000180 RID: 384
		[DispId(5002)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x06000181 RID: 385
		[DispId(5301)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x06000182 RID: 386
		[DispId(5403)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x06000183 RID: 387
		[DispId(5401)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x06000184 RID: 388
		[DispId(5402)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x06000185 RID: 389
		[DispId(5501)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x06000186 RID: 390
		[DispId(5601)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x06000187 RID: 391
		[DispId(5201)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x06000188 RID: 392
		[DispId(5202)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x06000189 RID: 393
		[DispId(5203)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x0600018A RID: 394
		[DispId(5204)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x0600018B RID: 395
		[DispId(5701)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x0600018C RID: 396
		[DispId(5801)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x0600018D RID: 397
		[DispId(5804)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x0600018E RID: 398
		[DispId(5805)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x0600018F RID: 399
		[DispId(5802)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x06000190 RID: 400
		[DispId(5803)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000191 RID: 401
		[DispId(5806)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x06000192 RID: 402
		[DispId(5807)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x06000193 RID: 403
		[DispId(5808)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000194 RID: 404
		[DispId(5809)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000195 RID: 405
		[DispId(5820)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x06000196 RID: 406
		[DispId(5810)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x06000197 RID: 407
		[DispId(5811)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000198 RID: 408
		[DispId(5812)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000199 RID: 409
		[DispId(5818)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x0600019A RID: 410
		[DispId(5819)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x0600019B RID: 411
		[DispId(5821)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x0600019C RID: 412
		[DispId(5823)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x0600019D RID: 413
		[DispId(5822)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x0600019E RID: 414
		[DispId(6501)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToPlayerApplication();

		// Token: 0x0600019F RID: 415
		[DispId(6502)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SwitchedToControl();

		// Token: 0x060001A0 RID: 416
		[DispId(6503)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerDockedStateChange();

		// Token: 0x060001A1 RID: 417
		[DispId(6504)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayerReconnect();

		// Token: 0x060001A2 RID: 418
		[DispId(6505)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Click([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060001A3 RID: 419
		[DispId(6506)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DoubleClick([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060001A4 RID: 420
		[DispId(6507)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyDown([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060001A5 RID: 421
		[DispId(6508)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyPress([In] short nKeyAscii);

		// Token: 0x060001A6 RID: 422
		[DispId(6509)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void KeyUp([In] short nKeyCode, [In] short nShiftState);

		// Token: 0x060001A7 RID: 423
		[DispId(6510)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseDown([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060001A8 RID: 424
		[DispId(6511)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseMove([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060001A9 RID: 425
		[DispId(6512)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MouseUp([In] short nButton, [In] short nShiftState, [In] int fX, [In] int fY);

		// Token: 0x060001AA RID: 426
		[DispId(6513)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060001AB RID: 427
		[DispId(6514)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);

		// Token: 0x060001AC RID: 428
		[DispId(6515)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceStatusChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum1 NewStatus);

		// Token: 0x060001AD RID: 429
		[DispId(6516)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [In] Enum2 NewState);

		// Token: 0x060001AE RID: 430
		[DispId(6517)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceSyncError([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060001AF RID: 431
		[DispId(6518)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CreatePartnershipComplete([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult);

		// Token: 0x060001B0 RID: 432
		[DispId(6527)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DeviceEstimation([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice, [MarshalAs(UnmanagedType.Error)] [In] int hrResult, [In] long qwEstimatedUsedSpace, [In] long qwEstimatedSpace);

		// Token: 0x060001B1 RID: 433
		[DispId(6519)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [In] Enum3 wmprs);

		// Token: 0x060001B2 RID: 434
		[DispId(6520)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromRipMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface4 pCdromRip, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060001B3 RID: 435
		[DispId(6521)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnStateChange([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [In] Enum5 wmpbs);

		// Token: 0x060001B4 RID: 436
		[DispId(6522)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnMediaError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.IDispatch)] [In] object pMedia);

		// Token: 0x060001B5 RID: 437
		[DispId(6523)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromBurnError([MarshalAs(UnmanagedType.Interface)] [In] GInterface5 pCdromBurn, [MarshalAs(UnmanagedType.Error)] [In] int hrError);

		// Token: 0x060001B6 RID: 438
		[DispId(6524)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryConnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x060001B7 RID: 439
		[DispId(6525)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void LibraryDisconnect([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 pLibrary);

		// Token: 0x060001B8 RID: 440
		[DispId(6526)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void FolderScanStateChange([In] Enum7 wmpfss);

		// Token: 0x060001B9 RID: 441
		[DispId(5824)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispStringCollection, [In] Enum8 change, [In] int lCollectionIndex);

		// Token: 0x060001BA RID: 442
		[DispId(5825)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x060001BB RID: 443
		[DispId(5826)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);
	}
}
