using System;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns8;
using ns9;

namespace ns10
{
	// Token: 0x02000156 RID: 342
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	internal sealed class Class22 : GInterface113
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x0000403F File Offset: 0x0000223F
		public void PlaylistCollectionPlaylistSetAsDeleted(string bstrPlaylistName, bool varfIsDeleted)
		{
			if (this.delegate112_0 != null)
			{
				this.delegate112_0(bstrPlaylistName, varfIsDeleted);
				return;
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00004063 File Offset: 0x00002263
		public void ModeChange(string ModeName, bool NewValue)
		{
			if (this.delegate113_0 != null)
			{
				this.delegate113_0(ModeName, NewValue);
				return;
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00004087 File Offset: 0x00002287
		public void MediaError(object pMediaObject)
		{
			if (this.delegate114_0 != null)
			{
				this.delegate114_0(pMediaObject);
				return;
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000040A7 File Offset: 0x000022A7
		public void OpenPlaylistSwitch(object pItem)
		{
			if (this.delegate115_0 != null)
			{
				this.delegate115_0(pItem);
				return;
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000040C7 File Offset: 0x000022C7
		public void DomainChange(string strDomain)
		{
			if (this.delegate116_0 != null)
			{
				this.delegate116_0(strDomain);
				return;
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000040E7 File Offset: 0x000022E7
		public void StringCollectionChange(object pdispStringCollection, Enum8 change, int lCollectionIndex)
		{
			if (this.delegate117_0 != null)
			{
				this.delegate117_0(pdispStringCollection, change, lCollectionIndex);
				return;
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000410F File Offset: 0x0000230F
		public void MediaCollectionMediaAdded(object pdispMedia)
		{
			if (this.delegate118_0 != null)
			{
				this.delegate118_0(pdispMedia);
				return;
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000412F File Offset: 0x0000232F
		public void MediaCollectionMediaRemoved(object pdispMedia)
		{
			if (this.delegate119_0 != null)
			{
				this.delegate119_0(pdispMedia);
				return;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000414F File Offset: 0x0000234F
		public void OpenStateChange(int NewState)
		{
			if (this.delegate84_0 != null)
			{
				this.delegate84_0(NewState);
				return;
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000416F File Offset: 0x0000236F
		public void PlayStateChange(int NewState)
		{
			if (this.delegate85_0 != null)
			{
				this.delegate85_0(NewState);
				return;
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000418F File Offset: 0x0000238F
		public void AudioLanguageChange(int LangID)
		{
			if (this.delegate86_0 != null)
			{
				this.delegate86_0(LangID);
				return;
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000041AF File Offset: 0x000023AF
		public void StatusChange()
		{
			if (this.delegate87_0 != null)
			{
				this.delegate87_0();
				return;
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000041CB File Offset: 0x000023CB
		public void ScriptCommand(string scType, string Param)
		{
			if (this.delegate88_0 != null)
			{
				this.delegate88_0(scType, Param);
				return;
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000041EF File Offset: 0x000023EF
		public void NewStream()
		{
			if (this.delegate89_0 != null)
			{
				this.delegate89_0();
				return;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0000420B File Offset: 0x0000240B
		public void Disconnect(int Result)
		{
			if (this.delegate90_0 != null)
			{
				this.delegate90_0(Result);
				return;
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000422B File Offset: 0x0000242B
		public void Buffering(bool Start)
		{
			if (this.delegate91_0 != null)
			{
				this.delegate91_0(Start);
				return;
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0000424B File Offset: 0x0000244B
		public void Error()
		{
			if (this.delegate92_0 != null)
			{
				this.delegate92_0();
				return;
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00004267 File Offset: 0x00002467
		public void Warning(int WarningType, int Param, string Description)
		{
			if (this.delegate93_0 != null)
			{
				this.delegate93_0(WarningType, Param, Description);
				return;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0000428F File Offset: 0x0000248F
		public void EndOfStream(int Result)
		{
			if (this.delegate94_0 != null)
			{
				this.delegate94_0(Result);
				return;
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000042AF File Offset: 0x000024AF
		public void PositionChange(double oldPosition, double newPosition)
		{
			if (this.delegate95_0 != null)
			{
				this.delegate95_0(oldPosition, newPosition);
				return;
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000042D3 File Offset: 0x000024D3
		public void MarkerHit(int MarkerNum)
		{
			if (this.delegate96_0 != null)
			{
				this.delegate96_0(MarkerNum);
				return;
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000042F3 File Offset: 0x000024F3
		public void DurationUnitChange(int NewDurationUnit)
		{
			if (this.delegate97_0 != null)
			{
				this.delegate97_0(NewDurationUnit);
				return;
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00004313 File Offset: 0x00002513
		public void CdromMediaChange(int CdromNum)
		{
			if (this.delegate98_0 != null)
			{
				this.delegate98_0(CdromNum);
				return;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00004333 File Offset: 0x00002533
		public void PlaylistChange(object Playlist, Enum0 change)
		{
			if (this.delegate99_0 != null)
			{
				this.delegate99_0(Playlist, change);
				return;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00004357 File Offset: 0x00002557
		public void CurrentPlaylistChange(Enum0 change)
		{
			if (this.delegate100_0 != null)
			{
				this.delegate100_0(change);
				return;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00004377 File Offset: 0x00002577
		public void CurrentPlaylistItemAvailable(string bstrItemName)
		{
			if (this.delegate101_0 != null)
			{
				this.delegate101_0(bstrItemName);
				return;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00004397 File Offset: 0x00002597
		public void MediaChange(object Item)
		{
			if (this.delegate102_0 != null)
			{
				this.delegate102_0(Item);
				return;
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000043B7 File Offset: 0x000025B7
		public void CurrentMediaItemAvailable(string bstrItemName)
		{
			if (this.delegate103_0 != null)
			{
				this.delegate103_0(bstrItemName);
				return;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000043D7 File Offset: 0x000025D7
		public void CurrentItemChange(object pdispMedia)
		{
			if (this.delegate104_0 != null)
			{
				this.delegate104_0(pdispMedia);
				return;
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000043F7 File Offset: 0x000025F7
		public void MediaCollectionChange()
		{
			if (this.delegate105_0 != null)
			{
				this.delegate105_0();
				return;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00004413 File Offset: 0x00002613
		public void MediaCollectionAttributeStringAdded(string bstrAttribName, string bstrAttribVal)
		{
			if (this.delegate106_0 != null)
			{
				this.delegate106_0(bstrAttribName, bstrAttribVal);
				return;
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00004437 File Offset: 0x00002637
		public void MediaCollectionAttributeStringRemoved(string bstrAttribName, string bstrAttribVal)
		{
			if (this.delegate107_0 != null)
			{
				this.delegate107_0(bstrAttribName, bstrAttribVal);
				return;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0000445B File Offset: 0x0000265B
		public void MediaCollectionAttributeStringChanged(string bstrAttribName, string bstrOldAttribVal, string bstrNewAttribVal)
		{
			if (this.delegate108_0 != null)
			{
				this.delegate108_0(bstrAttribName, bstrOldAttribVal, bstrNewAttribVal);
				return;
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00004483 File Offset: 0x00002683
		public void PlaylistCollectionChange()
		{
			if (this.delegate109_0 != null)
			{
				this.delegate109_0();
				return;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0000449F File Offset: 0x0000269F
		public void PlaylistCollectionPlaylistAdded(string bstrPlaylistName)
		{
			if (this.delegate110_0 != null)
			{
				this.delegate110_0(bstrPlaylistName);
				return;
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000044BF File Offset: 0x000026BF
		public void PlaylistCollectionPlaylistRemoved(string bstrPlaylistName)
		{
			if (this.delegate111_0 != null)
			{
				this.delegate111_0(bstrPlaylistName);
				return;
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00020D00 File Offset: 0x0001EF00
		internal Class22()
		{
			this.int_0 = 0;
			this.delegate112_0 = null;
			this.delegate113_0 = null;
			this.delegate114_0 = null;
			this.delegate115_0 = null;
			this.delegate116_0 = null;
			this.delegate117_0 = null;
			this.delegate118_0 = null;
			this.delegate119_0 = null;
			this.delegate84_0 = null;
			this.delegate85_0 = null;
			this.delegate86_0 = null;
			this.delegate87_0 = null;
			this.delegate88_0 = null;
			this.delegate89_0 = null;
			this.delegate90_0 = null;
			this.delegate91_0 = null;
			this.delegate92_0 = null;
			this.delegate93_0 = null;
			this.delegate94_0 = null;
			this.delegate95_0 = null;
			this.delegate96_0 = null;
			this.delegate97_0 = null;
			this.delegate98_0 = null;
			this.delegate99_0 = null;
			this.delegate100_0 = null;
			this.delegate101_0 = null;
			this.delegate102_0 = null;
			this.delegate103_0 = null;
			this.delegate104_0 = null;
			this.delegate105_0 = null;
			this.delegate106_0 = null;
			this.delegate107_0 = null;
			this.delegate108_0 = null;
			this.delegate109_0 = null;
			this.delegate110_0 = null;
			this.delegate111_0 = null;
		}

		// Token: 0x04000131 RID: 305
		public Delegate112 delegate112_0;

		// Token: 0x04000132 RID: 306
		public Delegate113 delegate113_0;

		// Token: 0x04000133 RID: 307
		public Delegate114 delegate114_0;

		// Token: 0x04000134 RID: 308
		public Delegate115 delegate115_0;

		// Token: 0x04000135 RID: 309
		public Delegate116 delegate116_0;

		// Token: 0x04000136 RID: 310
		public Delegate117 delegate117_0;

		// Token: 0x04000137 RID: 311
		public Delegate118 delegate118_0;

		// Token: 0x04000138 RID: 312
		public Delegate119 delegate119_0;

		// Token: 0x04000139 RID: 313
		public Delegate84 delegate84_0;

		// Token: 0x0400013A RID: 314
		public Delegate85 delegate85_0;

		// Token: 0x0400013B RID: 315
		public Delegate86 delegate86_0;

		// Token: 0x0400013C RID: 316
		public Delegate87 delegate87_0;

		// Token: 0x0400013D RID: 317
		public Delegate88 delegate88_0;

		// Token: 0x0400013E RID: 318
		public Delegate89 delegate89_0;

		// Token: 0x0400013F RID: 319
		public Delegate90 delegate90_0;

		// Token: 0x04000140 RID: 320
		public Delegate91 delegate91_0;

		// Token: 0x04000141 RID: 321
		public Delegate92 delegate92_0;

		// Token: 0x04000142 RID: 322
		public Delegate93 delegate93_0;

		// Token: 0x04000143 RID: 323
		public Delegate94 delegate94_0;

		// Token: 0x04000144 RID: 324
		public Delegate95 delegate95_0;

		// Token: 0x04000145 RID: 325
		public Delegate96 delegate96_0;

		// Token: 0x04000146 RID: 326
		public Delegate97 delegate97_0;

		// Token: 0x04000147 RID: 327
		public Delegate98 delegate98_0;

		// Token: 0x04000148 RID: 328
		public Delegate99 delegate99_0;

		// Token: 0x04000149 RID: 329
		public Delegate100 delegate100_0;

		// Token: 0x0400014A RID: 330
		public Delegate101 delegate101_0;

		// Token: 0x0400014B RID: 331
		public Delegate102 delegate102_0;

		// Token: 0x0400014C RID: 332
		public Delegate103 delegate103_0;

		// Token: 0x0400014D RID: 333
		public Delegate104 delegate104_0;

		// Token: 0x0400014E RID: 334
		public Delegate105 delegate105_0;

		// Token: 0x0400014F RID: 335
		public Delegate106 delegate106_0;

		// Token: 0x04000150 RID: 336
		public Delegate107 delegate107_0;

		// Token: 0x04000151 RID: 337
		public Delegate108 delegate108_0;

		// Token: 0x04000152 RID: 338
		public Delegate109 delegate109_0;

		// Token: 0x04000153 RID: 339
		public Delegate110 delegate110_0;

		// Token: 0x04000154 RID: 340
		public Delegate111 delegate111_0;

		// Token: 0x04000155 RID: 341
		public int int_0;
	}
}
