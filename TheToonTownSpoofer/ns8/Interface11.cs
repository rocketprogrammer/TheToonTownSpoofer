using System;
using System.Runtime.InteropServices;
using ns9;

namespace ns8
{
	// Token: 0x0200010C RID: 268
	[ComVisible(false)]
	[TypeLibType(16)]
	internal interface Interface11
	{
		// Token: 0x140000CD RID: 205
		// (add) Token: 0x06000FB7 RID: 4023
		// (remove) Token: 0x06000FB8 RID: 4024
		event Delegate84 OpenStateChange;

		// Token: 0x140000CE RID: 206
		// (add) Token: 0x06000FB9 RID: 4025
		// (remove) Token: 0x06000FBA RID: 4026
		event Delegate85 PlayStateChange;

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x06000FBB RID: 4027
		// (remove) Token: 0x06000FBC RID: 4028
		event Delegate86 AudioLanguageChange;

		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x06000FBD RID: 4029
		// (remove) Token: 0x06000FBE RID: 4030
		event Delegate87 StatusChange;

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x06000FBF RID: 4031
		// (remove) Token: 0x06000FC0 RID: 4032
		event Delegate88 ScriptCommand;

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x06000FC1 RID: 4033
		// (remove) Token: 0x06000FC2 RID: 4034
		event Delegate89 NewStream;

		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x06000FC3 RID: 4035
		// (remove) Token: 0x06000FC4 RID: 4036
		event Delegate90 Disconnect;

		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06000FC5 RID: 4037
		// (remove) Token: 0x06000FC6 RID: 4038
		event Delegate91 Buffering;

		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06000FC7 RID: 4039
		// (remove) Token: 0x06000FC8 RID: 4040
		event Delegate92 Error;

		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06000FC9 RID: 4041
		// (remove) Token: 0x06000FCA RID: 4042
		event Delegate93 Warning;

		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x06000FCB RID: 4043
		// (remove) Token: 0x06000FCC RID: 4044
		event Delegate94 EndOfStream;

		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06000FCD RID: 4045
		// (remove) Token: 0x06000FCE RID: 4046
		event Delegate95 PositionChange;

		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06000FCF RID: 4047
		// (remove) Token: 0x06000FD0 RID: 4048
		event Delegate96 MarkerHit;

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06000FD1 RID: 4049
		// (remove) Token: 0x06000FD2 RID: 4050
		event Delegate97 DurationUnitChange;

		// Token: 0x140000DB RID: 219
		// (add) Token: 0x06000FD3 RID: 4051
		// (remove) Token: 0x06000FD4 RID: 4052
		event Delegate98 CdromMediaChange;

		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06000FD5 RID: 4053
		// (remove) Token: 0x06000FD6 RID: 4054
		event Delegate99 PlaylistChange;

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06000FD7 RID: 4055
		// (remove) Token: 0x06000FD8 RID: 4056
		event Delegate100 CurrentPlaylistChange;

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06000FD9 RID: 4057
		// (remove) Token: 0x06000FDA RID: 4058
		event Delegate101 CurrentPlaylistItemAvailable;

		// Token: 0x140000DF RID: 223
		// (add) Token: 0x06000FDB RID: 4059
		// (remove) Token: 0x06000FDC RID: 4060
		event Delegate102 MediaChange;

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06000FDD RID: 4061
		// (remove) Token: 0x06000FDE RID: 4062
		event Delegate103 CurrentMediaItemAvailable;

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x06000FDF RID: 4063
		// (remove) Token: 0x06000FE0 RID: 4064
		event Delegate104 CurrentItemChange;

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x06000FE1 RID: 4065
		// (remove) Token: 0x06000FE2 RID: 4066
		event Delegate105 MediaCollectionChange;

		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x06000FE3 RID: 4067
		// (remove) Token: 0x06000FE4 RID: 4068
		event Delegate106 MediaCollectionAttributeStringAdded;

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x06000FE5 RID: 4069
		// (remove) Token: 0x06000FE6 RID: 4070
		event Delegate107 MediaCollectionAttributeStringRemoved;

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x06000FE7 RID: 4071
		// (remove) Token: 0x06000FE8 RID: 4072
		event Delegate108 MediaCollectionAttributeStringChanged;

		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x06000FE9 RID: 4073
		// (remove) Token: 0x06000FEA RID: 4074
		event Delegate109 PlaylistCollectionChange;

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x06000FEB RID: 4075
		// (remove) Token: 0x06000FEC RID: 4076
		event Delegate110 PlaylistCollectionPlaylistAdded;

		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x06000FED RID: 4077
		// (remove) Token: 0x06000FEE RID: 4078
		event Delegate111 PlaylistCollectionPlaylistRemoved;

		// Token: 0x140000E9 RID: 233
		// (add) Token: 0x06000FEF RID: 4079
		// (remove) Token: 0x06000FF0 RID: 4080
		event Delegate112 PlaylistCollectionPlaylistSetAsDeleted;

		// Token: 0x140000EA RID: 234
		// (add) Token: 0x06000FF1 RID: 4081
		// (remove) Token: 0x06000FF2 RID: 4082
		event Delegate113 ModeChange;

		// Token: 0x140000EB RID: 235
		// (add) Token: 0x06000FF3 RID: 4083
		// (remove) Token: 0x06000FF4 RID: 4084
		event Delegate114 MediaError;

		// Token: 0x140000EC RID: 236
		// (add) Token: 0x06000FF5 RID: 4085
		// (remove) Token: 0x06000FF6 RID: 4086
		event Delegate115 OpenPlaylistSwitch;

		// Token: 0x140000ED RID: 237
		// (add) Token: 0x06000FF7 RID: 4087
		// (remove) Token: 0x06000FF8 RID: 4088
		event Delegate116 DomainChange;

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x06000FF9 RID: 4089
		// (remove) Token: 0x06000FFA RID: 4090
		event Delegate117 StringCollectionChange;

		// Token: 0x140000EF RID: 239
		// (add) Token: 0x06000FFB RID: 4091
		// (remove) Token: 0x06000FFC RID: 4092
		event Delegate118 MediaCollectionMediaAdded;

		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x06000FFD RID: 4093
		// (remove) Token: 0x06000FFE RID: 4094
		event Delegate119 MediaCollectionMediaRemoved;
	}
}
