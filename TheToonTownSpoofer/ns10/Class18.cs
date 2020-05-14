using System;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns2;
using ns3;

namespace ns10
{
	// Token: 0x02000152 RID: 338
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	internal sealed class Class18 : GInterface12
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x00003728 File Offset: 0x00001928
		public void CdromBurnError(GInterface5 pCdromBurn, int hrError)
		{
			if (this.delegate56_0 != null)
			{
				this.delegate56_0(pCdromBurn, hrError);
				return;
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0000374C File Offset: 0x0000194C
		public void LibraryConnect(GInterface8 pLibrary)
		{
			if (this.delegate57_0 != null)
			{
				this.delegate57_0(pLibrary);
				return;
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0000376C File Offset: 0x0000196C
		public void LibraryDisconnect(GInterface8 pLibrary)
		{
			if (this.delegate58_0 != null)
			{
				this.delegate58_0(pLibrary);
				return;
			}
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0000378C File Offset: 0x0000198C
		public void FolderScanStateChange(Enum7 wmpfss)
		{
			if (this.delegate59_0 != null)
			{
				this.delegate59_0(wmpfss);
				return;
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000037AC File Offset: 0x000019AC
		public void StringCollectionChange(object pdispStringCollection, Enum8 change, int lCollectionIndex)
		{
			if (this.delegate60_0 != null)
			{
				this.delegate60_0(pdispStringCollection, change, lCollectionIndex);
				return;
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000037D4 File Offset: 0x000019D4
		public void MediaCollectionMediaAdded(object pdispMedia)
		{
			if (this.delegate61_0 != null)
			{
				this.delegate61_0(pdispMedia);
				return;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000037F4 File Offset: 0x000019F4
		public void MediaCollectionMediaRemoved(object pdispMedia)
		{
			if (this.delegate62_0 != null)
			{
				this.delegate62_0(pdispMedia);
				return;
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00003814 File Offset: 0x00001A14
		public void PlaylistCollectionPlaylistSetAsDeleted(string bstrPlaylistName, bool varfIsDeleted)
		{
			if (this.delegate28_0 != null)
			{
				this.delegate28_0(bstrPlaylistName, varfIsDeleted);
				return;
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00003838 File Offset: 0x00001A38
		public void ModeChange(string ModeName, bool NewValue)
		{
			if (this.delegate29_0 != null)
			{
				this.delegate29_0(ModeName, NewValue);
				return;
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0000385C File Offset: 0x00001A5C
		public void MediaError(object pMediaObject)
		{
			if (this.delegate30_0 != null)
			{
				this.delegate30_0(pMediaObject);
				return;
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000387C File Offset: 0x00001A7C
		public void OpenPlaylistSwitch(object pItem)
		{
			if (this.delegate31_0 != null)
			{
				this.delegate31_0(pItem);
				return;
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0000389C File Offset: 0x00001A9C
		public void DomainChange(string strDomain)
		{
			if (this.delegate32_0 != null)
			{
				this.delegate32_0(strDomain);
				return;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000038BC File Offset: 0x00001ABC
		public void SwitchedToPlayerApplication()
		{
			if (this.delegate33_0 != null)
			{
				this.delegate33_0();
				return;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000038D8 File Offset: 0x00001AD8
		public void SwitchedToControl()
		{
			if (this.delegate34_0 != null)
			{
				this.delegate34_0();
				return;
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000038F4 File Offset: 0x00001AF4
		public void PlayerDockedStateChange()
		{
			if (this.delegate35_0 != null)
			{
				this.delegate35_0();
				return;
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00003910 File Offset: 0x00001B10
		public void PlayerReconnect()
		{
			if (this.delegate36_0 != null)
			{
				this.delegate36_0();
				return;
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000392C File Offset: 0x00001B2C
		public void Click(short nButton, short nShiftState, int fX, int fY)
		{
			if (this.delegate37_0 != null)
			{
				this.delegate37_0(nButton, nShiftState, fX, fY);
				return;
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00003958 File Offset: 0x00001B58
		public void DoubleClick(short nButton, short nShiftState, int fX, int fY)
		{
			if (this.delegate38_0 != null)
			{
				this.delegate38_0(nButton, nShiftState, fX, fY);
				return;
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00003984 File Offset: 0x00001B84
		public void KeyDown(short nKeyCode, short nShiftState)
		{
			if (this.delegate39_0 != null)
			{
				this.delegate39_0(nKeyCode, nShiftState);
				return;
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000039A8 File Offset: 0x00001BA8
		public void KeyPress(short nKeyAscii)
		{
			if (this.delegate40_0 != null)
			{
				this.delegate40_0(nKeyAscii);
				return;
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000039C8 File Offset: 0x00001BC8
		public void KeyUp(short nKeyCode, short nShiftState)
		{
			if (this.delegate41_0 != null)
			{
				this.delegate41_0(nKeyCode, nShiftState);
				return;
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000039EC File Offset: 0x00001BEC
		public void MouseDown(short nButton, short nShiftState, int fX, int fY)
		{
			if (this.delegate42_0 != null)
			{
				this.delegate42_0(nButton, nShiftState, fX, fY);
				return;
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00003A18 File Offset: 0x00001C18
		public void MouseMove(short nButton, short nShiftState, int fX, int fY)
		{
			if (this.delegate43_0 != null)
			{
				this.delegate43_0(nButton, nShiftState, fX, fY);
				return;
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00003A44 File Offset: 0x00001C44
		public void MouseUp(short nButton, short nShiftState, int fX, int fY)
		{
			if (this.delegate44_0 != null)
			{
				this.delegate44_0(nButton, nShiftState, fX, fY);
				return;
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00003A70 File Offset: 0x00001C70
		public void DeviceConnect(GInterface2 pDevice)
		{
			if (this.delegate45_0 != null)
			{
				this.delegate45_0(pDevice);
				return;
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00003A90 File Offset: 0x00001C90
		public void DeviceDisconnect(GInterface2 pDevice)
		{
			if (this.delegate46_0 != null)
			{
				this.delegate46_0(pDevice);
				return;
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00003AB0 File Offset: 0x00001CB0
		public void DeviceStatusChange(GInterface2 pDevice, Enum1 NewStatus)
		{
			if (this.delegate47_0 != null)
			{
				this.delegate47_0(pDevice, NewStatus);
				return;
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public void DeviceSyncStateChange(GInterface2 pDevice, Enum2 NewState)
		{
			if (this.delegate48_0 != null)
			{
				this.delegate48_0(pDevice, NewState);
				return;
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public void DeviceSyncError(GInterface2 pDevice, object pMedia)
		{
			if (this.delegate49_0 != null)
			{
				this.delegate49_0(pDevice, pMedia);
				return;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00003B1C File Offset: 0x00001D1C
		public void CreatePartnershipComplete(GInterface2 pDevice, int hrResult)
		{
			if (this.delegate50_0 != null)
			{
				this.delegate50_0(pDevice, hrResult);
				return;
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00003B40 File Offset: 0x00001D40
		public void DeviceEstimation(GInterface2 pDevice, int hrResult, long qwEstimatedUsedSpace, long qwEstimatedSpace)
		{
			if (this.delegate51_0 != null)
			{
				this.delegate51_0(pDevice, hrResult, qwEstimatedUsedSpace, qwEstimatedSpace);
				return;
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00003B6C File Offset: 0x00001D6C
		public void CdromRipStateChange(GInterface4 pCdromRip, Enum3 wmprs)
		{
			if (this.delegate52_0 != null)
			{
				this.delegate52_0(pCdromRip, wmprs);
				return;
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00003B90 File Offset: 0x00001D90
		public void CdromRipMediaError(GInterface4 pCdromRip, object pMedia)
		{
			if (this.delegate53_0 != null)
			{
				this.delegate53_0(pCdromRip, pMedia);
				return;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public void CdromBurnStateChange(GInterface5 pCdromBurn, Enum5 wmpbs)
		{
			if (this.delegate54_0 != null)
			{
				this.delegate54_0(pCdromBurn, wmpbs);
				return;
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public void CdromBurnMediaError(GInterface5 pCdromBurn, object pMedia)
		{
			if (this.delegate55_0 != null)
			{
				this.delegate55_0(pCdromBurn, pMedia);
				return;
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00003BFC File Offset: 0x00001DFC
		public void OpenStateChange(int NewState)
		{
			if (this.delegate0_0 != null)
			{
				this.delegate0_0(NewState);
				return;
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00003C1C File Offset: 0x00001E1C
		public void PlayStateChange(int NewState)
		{
			if (this.delegate1_0 != null)
			{
				this.delegate1_0(NewState);
				return;
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00003C3C File Offset: 0x00001E3C
		public void AudioLanguageChange(int LangID)
		{
			if (this.delegate2_0 != null)
			{
				this.delegate2_0(LangID);
				return;
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00003C5C File Offset: 0x00001E5C
		public void StatusChange()
		{
			if (this.delegate3_0 != null)
			{
				this.delegate3_0();
				return;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00003C78 File Offset: 0x00001E78
		public void ScriptCommand(string scType, string Param)
		{
			if (this.delegate4_0 != null)
			{
				this.delegate4_0(scType, Param);
				return;
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00003C9C File Offset: 0x00001E9C
		public void NewStream()
		{
			if (this.delegate5_0 != null)
			{
				this.delegate5_0();
				return;
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public void Disconnect(int Result)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(Result);
				return;
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public void Buffering(bool Start)
		{
			if (this.delegate7_0 != null)
			{
				this.delegate7_0(Start);
				return;
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public void Error()
		{
			if (this.delegate8_0 != null)
			{
				this.delegate8_0();
				return;
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00003D14 File Offset: 0x00001F14
		public void Warning(int WarningType, int Param, string Description)
		{
			if (this.delegate9_0 != null)
			{
				this.delegate9_0(WarningType, Param, Description);
				return;
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00003D3C File Offset: 0x00001F3C
		public void EndOfStream(int Result)
		{
			if (this.delegate10_0 != null)
			{
				this.delegate10_0(Result);
				return;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00003D5C File Offset: 0x00001F5C
		public void PositionChange(double oldPosition, double newPosition)
		{
			if (this.delegate11_0 != null)
			{
				this.delegate11_0(oldPosition, newPosition);
				return;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00003D80 File Offset: 0x00001F80
		public void MarkerHit(int MarkerNum)
		{
			if (this.delegate12_0 != null)
			{
				this.delegate12_0(MarkerNum);
				return;
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public void DurationUnitChange(int NewDurationUnit)
		{
			if (this.delegate13_0 != null)
			{
				this.delegate13_0(NewDurationUnit);
				return;
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public void CdromMediaChange(int CdromNum)
		{
			if (this.delegate14_0 != null)
			{
				this.delegate14_0(CdromNum);
				return;
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public void PlaylistChange(object Playlist, Enum0 change)
		{
			if (this.delegate15_0 != null)
			{
				this.delegate15_0(Playlist, change);
				return;
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00003E04 File Offset: 0x00002004
		public void CurrentPlaylistChange(Enum0 change)
		{
			if (this.delegate16_0 != null)
			{
				this.delegate16_0(change);
				return;
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00003E24 File Offset: 0x00002024
		public void CurrentPlaylistItemAvailable(string bstrItemName)
		{
			if (this.delegate17_0 != null)
			{
				this.delegate17_0(bstrItemName);
				return;
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00003E44 File Offset: 0x00002044
		public void MediaChange(object Item)
		{
			if (this.delegate18_0 != null)
			{
				this.delegate18_0(Item);
				return;
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00003E64 File Offset: 0x00002064
		public void CurrentMediaItemAvailable(string bstrItemName)
		{
			if (this.delegate19_0 != null)
			{
				this.delegate19_0(bstrItemName);
				return;
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00003E84 File Offset: 0x00002084
		public void CurrentItemChange(object pdispMedia)
		{
			if (this.delegate20_0 != null)
			{
				this.delegate20_0(pdispMedia);
				return;
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00003EA4 File Offset: 0x000020A4
		public void MediaCollectionChange()
		{
			if (this.delegate21_0 != null)
			{
				this.delegate21_0();
				return;
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00003EC0 File Offset: 0x000020C0
		public void MediaCollectionAttributeStringAdded(string bstrAttribName, string bstrAttribVal)
		{
			if (this.delegate22_0 != null)
			{
				this.delegate22_0(bstrAttribName, bstrAttribVal);
				return;
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00003EE4 File Offset: 0x000020E4
		public void MediaCollectionAttributeStringRemoved(string bstrAttribName, string bstrAttribVal)
		{
			if (this.delegate23_0 != null)
			{
				this.delegate23_0(bstrAttribName, bstrAttribVal);
				return;
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00003F08 File Offset: 0x00002108
		public void MediaCollectionAttributeStringChanged(string bstrAttribName, string bstrOldAttribVal, string bstrNewAttribVal)
		{
			if (this.delegate24_0 != null)
			{
				this.delegate24_0(bstrAttribName, bstrOldAttribVal, bstrNewAttribVal);
				return;
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00003F30 File Offset: 0x00002130
		public void PlaylistCollectionChange()
		{
			if (this.delegate25_0 != null)
			{
				this.delegate25_0();
				return;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00003F4C File Offset: 0x0000214C
		public void PlaylistCollectionPlaylistAdded(string bstrPlaylistName)
		{
			if (this.delegate26_0 != null)
			{
				this.delegate26_0(bstrPlaylistName);
				return;
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00003F6C File Offset: 0x0000216C
		public void PlaylistCollectionPlaylistRemoved(string bstrPlaylistName)
		{
			if (this.delegate27_0 != null)
			{
				this.delegate27_0(bstrPlaylistName);
				return;
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00019C9C File Offset: 0x00017E9C
		internal Class18()
		{
			this.int_0 = 0;
			this.delegate56_0 = null;
			this.delegate57_0 = null;
			this.delegate58_0 = null;
			this.delegate59_0 = null;
			this.delegate60_0 = null;
			this.delegate61_0 = null;
			this.delegate62_0 = null;
			this.delegate28_0 = null;
			this.delegate29_0 = null;
			this.delegate30_0 = null;
			this.delegate31_0 = null;
			this.delegate32_0 = null;
			this.delegate33_0 = null;
			this.delegate34_0 = null;
			this.delegate35_0 = null;
			this.delegate36_0 = null;
			this.delegate37_0 = null;
			this.delegate38_0 = null;
			this.delegate39_0 = null;
			this.delegate40_0 = null;
			this.delegate41_0 = null;
			this.delegate42_0 = null;
			this.delegate43_0 = null;
			this.delegate44_0 = null;
			this.delegate45_0 = null;
			this.delegate46_0 = null;
			this.delegate47_0 = null;
			this.delegate48_0 = null;
			this.delegate49_0 = null;
			this.delegate50_0 = null;
			this.delegate51_0 = null;
			this.delegate52_0 = null;
			this.delegate53_0 = null;
			this.delegate54_0 = null;
			this.delegate55_0 = null;
			this.delegate0_0 = null;
			this.delegate1_0 = null;
			this.delegate2_0 = null;
			this.delegate3_0 = null;
			this.delegate4_0 = null;
			this.delegate5_0 = null;
			this.delegate6_0 = null;
			this.delegate7_0 = null;
			this.delegate8_0 = null;
			this.delegate9_0 = null;
			this.delegate10_0 = null;
			this.delegate11_0 = null;
			this.delegate12_0 = null;
			this.delegate13_0 = null;
			this.delegate14_0 = null;
			this.delegate15_0 = null;
			this.delegate16_0 = null;
			this.delegate17_0 = null;
			this.delegate18_0 = null;
			this.delegate19_0 = null;
			this.delegate20_0 = null;
			this.delegate21_0 = null;
			this.delegate22_0 = null;
			this.delegate23_0 = null;
			this.delegate24_0 = null;
			this.delegate25_0 = null;
			this.delegate26_0 = null;
			this.delegate27_0 = null;
		}

		// Token: 0x040000E7 RID: 231
		public Delegate56 delegate56_0;

		// Token: 0x040000E8 RID: 232
		public Delegate57 delegate57_0;

		// Token: 0x040000E9 RID: 233
		public Delegate58 delegate58_0;

		// Token: 0x040000EA RID: 234
		public Delegate59 delegate59_0;

		// Token: 0x040000EB RID: 235
		public Delegate60 delegate60_0;

		// Token: 0x040000EC RID: 236
		public Delegate61 delegate61_0;

		// Token: 0x040000ED RID: 237
		public Delegate62 delegate62_0;

		// Token: 0x040000EE RID: 238
		public Delegate28 delegate28_0;

		// Token: 0x040000EF RID: 239
		public Delegate29 delegate29_0;

		// Token: 0x040000F0 RID: 240
		public Delegate30 delegate30_0;

		// Token: 0x040000F1 RID: 241
		public Delegate31 delegate31_0;

		// Token: 0x040000F2 RID: 242
		public Delegate32 delegate32_0;

		// Token: 0x040000F3 RID: 243
		public Delegate33 delegate33_0;

		// Token: 0x040000F4 RID: 244
		public Delegate34 delegate34_0;

		// Token: 0x040000F5 RID: 245
		public Delegate35 delegate35_0;

		// Token: 0x040000F6 RID: 246
		public Delegate36 delegate36_0;

		// Token: 0x040000F7 RID: 247
		public Delegate37 delegate37_0;

		// Token: 0x040000F8 RID: 248
		public Delegate38 delegate38_0;

		// Token: 0x040000F9 RID: 249
		public Delegate39 delegate39_0;

		// Token: 0x040000FA RID: 250
		public Delegate40 delegate40_0;

		// Token: 0x040000FB RID: 251
		public Delegate41 delegate41_0;

		// Token: 0x040000FC RID: 252
		public Delegate42 delegate42_0;

		// Token: 0x040000FD RID: 253
		public Delegate43 delegate43_0;

		// Token: 0x040000FE RID: 254
		public Delegate44 delegate44_0;

		// Token: 0x040000FF RID: 255
		public Delegate45 delegate45_0;

		// Token: 0x04000100 RID: 256
		public Delegate46 delegate46_0;

		// Token: 0x04000101 RID: 257
		public Delegate47 delegate47_0;

		// Token: 0x04000102 RID: 258
		public Delegate48 delegate48_0;

		// Token: 0x04000103 RID: 259
		public Delegate49 delegate49_0;

		// Token: 0x04000104 RID: 260
		public Delegate50 delegate50_0;

		// Token: 0x04000105 RID: 261
		public Delegate51 delegate51_0;

		// Token: 0x04000106 RID: 262
		public Delegate52 delegate52_0;

		// Token: 0x04000107 RID: 263
		public Delegate53 delegate53_0;

		// Token: 0x04000108 RID: 264
		public Delegate54 delegate54_0;

		// Token: 0x04000109 RID: 265
		public Delegate55 delegate55_0;

		// Token: 0x0400010A RID: 266
		public Delegate0 delegate0_0;

		// Token: 0x0400010B RID: 267
		public Delegate1 delegate1_0;

		// Token: 0x0400010C RID: 268
		public Delegate2 delegate2_0;

		// Token: 0x0400010D RID: 269
		public Delegate3 delegate3_0;

		// Token: 0x0400010E RID: 270
		public Delegate4 delegate4_0;

		// Token: 0x0400010F RID: 271
		public Delegate5 delegate5_0;

		// Token: 0x04000110 RID: 272
		public Delegate6 delegate6_0;

		// Token: 0x04000111 RID: 273
		public Delegate7 delegate7_0;

		// Token: 0x04000112 RID: 274
		public Delegate8 delegate8_0;

		// Token: 0x04000113 RID: 275
		public Delegate9 delegate9_0;

		// Token: 0x04000114 RID: 276
		public Delegate10 delegate10_0;

		// Token: 0x04000115 RID: 277
		public Delegate11 delegate11_0;

		// Token: 0x04000116 RID: 278
		public Delegate12 delegate12_0;

		// Token: 0x04000117 RID: 279
		public Delegate13 delegate13_0;

		// Token: 0x04000118 RID: 280
		public Delegate14 delegate14_0;

		// Token: 0x04000119 RID: 281
		public Delegate15 delegate15_0;

		// Token: 0x0400011A RID: 282
		public Delegate16 delegate16_0;

		// Token: 0x0400011B RID: 283
		public Delegate17 delegate17_0;

		// Token: 0x0400011C RID: 284
		public Delegate18 delegate18_0;

		// Token: 0x0400011D RID: 285
		public Delegate19 delegate19_0;

		// Token: 0x0400011E RID: 286
		public Delegate20 delegate20_0;

		// Token: 0x0400011F RID: 287
		public Delegate21 delegate21_0;

		// Token: 0x04000120 RID: 288
		public Delegate22 delegate22_0;

		// Token: 0x04000121 RID: 289
		public Delegate23 delegate23_0;

		// Token: 0x04000122 RID: 290
		public Delegate24 delegate24_0;

		// Token: 0x04000123 RID: 291
		public Delegate25 delegate25_0;

		// Token: 0x04000124 RID: 292
		public Delegate26 delegate26_0;

		// Token: 0x04000125 RID: 293
		public Delegate27 delegate27_0;

		// Token: 0x04000126 RID: 294
		public int int_0;
	}
}
