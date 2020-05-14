using System;
using System.Runtime.InteropServices;
using ns2;
using ns3;

namespace ns1
{
	// Token: 0x02000038 RID: 56
	[TypeLibType(16)]
	[ComVisible(false)]
	internal interface Interface5
	{
		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060003D3 RID: 979
		// (remove) Token: 0x060003D4 RID: 980
		event Delegate0 OpenStateChange;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060003D5 RID: 981
		// (remove) Token: 0x060003D6 RID: 982
		event Delegate1 PlayStateChange;

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060003D7 RID: 983
		// (remove) Token: 0x060003D8 RID: 984
		event Delegate2 AudioLanguageChange;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060003D9 RID: 985
		// (remove) Token: 0x060003DA RID: 986
		event Delegate3 StatusChange;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060003DB RID: 987
		// (remove) Token: 0x060003DC RID: 988
		event Delegate4 ScriptCommand;

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060003DD RID: 989
		// (remove) Token: 0x060003DE RID: 990
		event Delegate5 NewStream;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060003DF RID: 991
		// (remove) Token: 0x060003E0 RID: 992
		event Delegate6 Disconnect;

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060003E1 RID: 993
		// (remove) Token: 0x060003E2 RID: 994
		event Delegate7 Buffering;

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060003E3 RID: 995
		// (remove) Token: 0x060003E4 RID: 996
		event Delegate8 Error;

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060003E5 RID: 997
		// (remove) Token: 0x060003E6 RID: 998
		event Delegate9 Warning;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060003E7 RID: 999
		// (remove) Token: 0x060003E8 RID: 1000
		event Delegate10 EndOfStream;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060003E9 RID: 1001
		// (remove) Token: 0x060003EA RID: 1002
		event Delegate11 PositionChange;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060003EB RID: 1003
		// (remove) Token: 0x060003EC RID: 1004
		event Delegate12 MarkerHit;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060003ED RID: 1005
		// (remove) Token: 0x060003EE RID: 1006
		event Delegate13 DurationUnitChange;

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060003EF RID: 1007
		// (remove) Token: 0x060003F0 RID: 1008
		event Delegate14 CdromMediaChange;

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060003F1 RID: 1009
		// (remove) Token: 0x060003F2 RID: 1010
		event Delegate15 PlaylistChange;

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060003F3 RID: 1011
		// (remove) Token: 0x060003F4 RID: 1012
		event Delegate16 CurrentPlaylistChange;

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060003F5 RID: 1013
		// (remove) Token: 0x060003F6 RID: 1014
		event Delegate17 CurrentPlaylistItemAvailable;

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060003F7 RID: 1015
		// (remove) Token: 0x060003F8 RID: 1016
		event Delegate18 MediaChange;

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060003F9 RID: 1017
		// (remove) Token: 0x060003FA RID: 1018
		event Delegate19 CurrentMediaItemAvailable;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060003FB RID: 1019
		// (remove) Token: 0x060003FC RID: 1020
		event Delegate20 CurrentItemChange;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060003FD RID: 1021
		// (remove) Token: 0x060003FE RID: 1022
		event Delegate21 MediaCollectionChange;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060003FF RID: 1023
		// (remove) Token: 0x06000400 RID: 1024
		event Delegate22 MediaCollectionAttributeStringAdded;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000401 RID: 1025
		// (remove) Token: 0x06000402 RID: 1026
		event Delegate23 MediaCollectionAttributeStringRemoved;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000403 RID: 1027
		// (remove) Token: 0x06000404 RID: 1028
		event Delegate24 MediaCollectionAttributeStringChanged;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000405 RID: 1029
		// (remove) Token: 0x06000406 RID: 1030
		event Delegate25 PlaylistCollectionChange;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000407 RID: 1031
		// (remove) Token: 0x06000408 RID: 1032
		event Delegate26 PlaylistCollectionPlaylistAdded;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000409 RID: 1033
		// (remove) Token: 0x0600040A RID: 1034
		event Delegate27 PlaylistCollectionPlaylistRemoved;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x0600040B RID: 1035
		// (remove) Token: 0x0600040C RID: 1036
		event Delegate28 PlaylistCollectionPlaylistSetAsDeleted;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600040D RID: 1037
		// (remove) Token: 0x0600040E RID: 1038
		event Delegate29 ModeChange;

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600040F RID: 1039
		// (remove) Token: 0x06000410 RID: 1040
		event Delegate30 MediaError;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000411 RID: 1041
		// (remove) Token: 0x06000412 RID: 1042
		event Delegate31 OpenPlaylistSwitch;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000413 RID: 1043
		// (remove) Token: 0x06000414 RID: 1044
		event Delegate32 DomainChange;

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000415 RID: 1045
		// (remove) Token: 0x06000416 RID: 1046
		event Delegate33 SwitchedToPlayerApplication;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000417 RID: 1047
		// (remove) Token: 0x06000418 RID: 1048
		event Delegate34 SwitchedToControl;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000419 RID: 1049
		// (remove) Token: 0x0600041A RID: 1050
		event Delegate35 PlayerDockedStateChange;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x0600041B RID: 1051
		// (remove) Token: 0x0600041C RID: 1052
		event Delegate36 PlayerReconnect;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x0600041D RID: 1053
		// (remove) Token: 0x0600041E RID: 1054
		event Delegate37 Click;

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x0600041F RID: 1055
		// (remove) Token: 0x06000420 RID: 1056
		event Delegate38 DoubleClick;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000421 RID: 1057
		// (remove) Token: 0x06000422 RID: 1058
		event Delegate39 KeyDown;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000423 RID: 1059
		// (remove) Token: 0x06000424 RID: 1060
		event Delegate40 KeyPress;

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000425 RID: 1061
		// (remove) Token: 0x06000426 RID: 1062
		event Delegate41 KeyUp;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000427 RID: 1063
		// (remove) Token: 0x06000428 RID: 1064
		event Delegate42 MouseDown;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000429 RID: 1065
		// (remove) Token: 0x0600042A RID: 1066
		event Delegate43 MouseMove;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600042B RID: 1067
		// (remove) Token: 0x0600042C RID: 1068
		event Delegate44 MouseUp;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x0600042D RID: 1069
		// (remove) Token: 0x0600042E RID: 1070
		event Delegate45 DeviceConnect;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x0600042F RID: 1071
		// (remove) Token: 0x06000430 RID: 1072
		event Delegate46 DeviceDisconnect;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06000431 RID: 1073
		// (remove) Token: 0x06000432 RID: 1074
		event Delegate47 DeviceStatusChange;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06000433 RID: 1075
		// (remove) Token: 0x06000434 RID: 1076
		event Delegate48 DeviceSyncStateChange;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06000435 RID: 1077
		// (remove) Token: 0x06000436 RID: 1078
		event Delegate49 DeviceSyncError;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000437 RID: 1079
		// (remove) Token: 0x06000438 RID: 1080
		event Delegate50 CreatePartnershipComplete;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000439 RID: 1081
		// (remove) Token: 0x0600043A RID: 1082
		event Delegate51 DeviceEstimation;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x0600043B RID: 1083
		// (remove) Token: 0x0600043C RID: 1084
		event Delegate52 CdromRipStateChange;

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x0600043D RID: 1085
		// (remove) Token: 0x0600043E RID: 1086
		event Delegate53 CdromRipMediaError;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x0600043F RID: 1087
		// (remove) Token: 0x06000440 RID: 1088
		event Delegate54 CdromBurnStateChange;

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06000441 RID: 1089
		// (remove) Token: 0x06000442 RID: 1090
		event Delegate55 CdromBurnMediaError;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x06000443 RID: 1091
		// (remove) Token: 0x06000444 RID: 1092
		event Delegate56 CdromBurnError;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x06000445 RID: 1093
		// (remove) Token: 0x06000446 RID: 1094
		event Delegate57 LibraryConnect;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06000447 RID: 1095
		// (remove) Token: 0x06000448 RID: 1096
		event Delegate58 LibraryDisconnect;

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000449 RID: 1097
		// (remove) Token: 0x0600044A RID: 1098
		event Delegate59 FolderScanStateChange;

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x0600044B RID: 1099
		// (remove) Token: 0x0600044C RID: 1100
		event Delegate60 StringCollectionChange;

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x0600044D RID: 1101
		// (remove) Token: 0x0600044E RID: 1102
		event Delegate61 MediaCollectionMediaAdded;

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x0600044F RID: 1103
		// (remove) Token: 0x06000450 RID: 1104
		event Delegate62 MediaCollectionMediaRemoved;
	}
}
