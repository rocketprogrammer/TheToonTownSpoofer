using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ns23;

namespace ns31
{
	// Token: 0x02000301 RID: 769
	internal static class Class291
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x0000B75E File Offset: 0x0000995E
		public static string CommonApplicationTheSpoofNetDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_0))
				{
					Directory.CreateDirectory(Class291.string_0, Class363.GetDirectorySecurity);
				}
				return Class291.string_0;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0000B781 File Offset: 0x00009981
		public static string CommonApplicationDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_1))
				{
					Directory.CreateDirectory(Class291.string_1, Class363.GetDirectorySecurity);
				}
				return Class291.string_1;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0000B7A4 File Offset: 0x000099A4
		public static string ScreenshotSaveDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_2))
				{
					Directory.CreateDirectory(Class291.string_2, Class363.GetDirectorySecurity);
				}
				return Class291.string_2;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0000B7C7 File Offset: 0x000099C7
		public static string RaceTrackSettingsDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_3))
				{
					Directory.CreateDirectory(Class291.string_3, Class363.GetDirectorySecurity);
				}
				return Class291.string_3;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0000B7EA File Offset: 0x000099EA
		public static string ToonTownOpenDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_4))
				{
					Directory.CreateDirectory(Class291.string_4, Class363.GetDirectorySecurity);
				}
				return Class291.string_4;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0000B80D File Offset: 0x00009A0D
		public static string ToonTownTestDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_5))
				{
					Directory.CreateDirectory(Class291.string_5, Class363.GetDirectorySecurity);
				}
				return Class291.string_5;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0000B830 File Offset: 0x00009A30
		public static string ContentPackDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_6))
				{
					Directory.CreateDirectory(Class291.string_6, Class363.GetDirectorySecurity);
				}
				return Class291.string_6;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0000B853 File Offset: 0x00009A53
		public static string JoeFishDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_7))
				{
					Directory.CreateDirectory(Class291.string_7, Class363.GetDirectorySecurity);
				}
				return Class291.string_7;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0000B876 File Offset: 0x00009A76
		public static string GardenerFloraDataDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_8))
				{
					Directory.CreateDirectory(Class291.string_8, Class363.GetDirectorySecurity);
				}
				return Class291.string_8;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x0000B899 File Offset: 0x00009A99
		public static string GardenerFloraEstateSettings
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_9))
				{
					Directory.CreateDirectory(Class291.string_9, Class363.GetDirectorySecurity);
				}
				return Class291.string_9;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public static string GardenerFloraCaptureSettingsDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_10))
				{
					Directory.CreateDirectory(Class291.string_10, Class363.GetDirectorySecurity);
				}
				return Class291.string_10;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x0000B8DF File Offset: 0x00009ADF
		public static string JoeFishCaptureSettingsDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_11))
				{
					Directory.CreateDirectory(Class291.string_11, Class363.GetDirectorySecurity);
				}
				return Class291.string_11;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0000B902 File Offset: 0x00009B02
		public static string ToonTownContent_TempFolder
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_12))
				{
					Directory.CreateDirectory(Class291.string_12, Class363.GetDirectorySecurity);
				}
				return Class291.string_12;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0000B925 File Offset: 0x00009B25
		public static string DebugLogDirectory
		{
			[DebuggerStepThrough]
			get
			{
				if (!Directory.Exists(Class291.string_13))
				{
					Directory.CreateDirectory(Class291.string_13, Class363.GetDirectorySecurity);
				}
				return Class291.string_13;
			}
		}

		// Token: 0x04000B6A RID: 2922
		public static readonly string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "The Spoof Net");

		// Token: 0x04000B6B RID: 2923
		public static readonly string string_1 = Path.Combine(Class291.CommonApplicationTheSpoofNetDirectory, "The ToonTown Spoofer");

		// Token: 0x04000B6C RID: 2924
		public static readonly string string_2 = Path.Combine(Class291.CommonApplicationDataDirectory, "Screenshots");

		// Token: 0x04000B6D RID: 2925
		public static readonly string string_3 = Path.Combine(Class291.CommonApplicationDataDirectory, "Race Track");

		// Token: 0x04000B6E RID: 2926
		public static readonly string string_4 = Path.Combine(Class291.CommonApplicationDataDirectory, "ToonTown");

		// Token: 0x04000B6F RID: 2927
		public static readonly string string_5 = Path.Combine(Class291.CommonApplicationDataDirectory, "Test ToonTown");

		// Token: 0x04000B70 RID: 2928
		public static readonly string string_6 = Path.Combine(Class291.CommonApplicationDataDirectory, "Content Packs");

		// Token: 0x04000B71 RID: 2929
		public static readonly string string_7 = Path.Combine(Class291.CommonApplicationDataDirectory, "Joe Fish Data");

		// Token: 0x04000B72 RID: 2930
		public static readonly string string_8 = Path.Combine(Class291.CommonApplicationDataDirectory, "Gardener Flora Data");

		// Token: 0x04000B73 RID: 2931
		public static readonly string string_9 = Path.Combine(Class291.GardenerFloraDataDirectory, "Estate Settings");

		// Token: 0x04000B74 RID: 2932
		public static readonly string string_10 = Path.Combine(Class291.GardenerFloraDataDirectory, "Capture Settings");

		// Token: 0x04000B75 RID: 2933
		public static readonly string string_11 = Path.Combine(Class291.JoeFishDataDirectory, "Capture Settings");

		// Token: 0x04000B76 RID: 2934
		public static readonly string string_12 = Path.Combine(Path.GetTempPath(), "ToonTown Content");

		// Token: 0x04000B77 RID: 2935
		public static readonly string string_13 = Path.Combine(Class291.CommonApplicationDataDirectory, "Debugging");

		// Token: 0x04000B78 RID: 2936
		public static readonly string string_14 = Path.Combine(Class291.CommonApplicationDataDirectory, "ScreenshotThumbs.db");

		// Token: 0x04000B79 RID: 2937
		public static readonly string string_15 = Path.Combine(Class291.CommonApplicationDataDirectory, ".tts");

		// Token: 0x04000B7A RID: 2938
		public static readonly string string_16 = Path.Combine(Class291.CommonApplicationDataDirectory, ".autoupdate");

		// Token: 0x04000B7B RID: 2939
		public static readonly string string_17 = Path.Combine(Class291.CommonApplicationDataDirectory, "trace.log");

		// Token: 0x04000B7C RID: 2940
		public static readonly string string_18 = Path.Combine(Application.StartupPath, "ReleaseNotes.xml");

		// Token: 0x04000B7D RID: 2941
		public static readonly string string_19 = Path.Combine(Application.StartupPath, "DefaultGardenerFloraCaptures.gfc");

		// Token: 0x04000B7E RID: 2942
		public static readonly string string_20 = Path.Combine(Application.StartupPath, "DefaultJoeFishCaptures.jfc");

		// Token: 0x04000B7F RID: 2943
		public static readonly string string_21 = Path.Combine(Application.StartupPath, "DefaultGardenerFloraWayPoints.gfwps");

		// Token: 0x04000B80 RID: 2944
		public static readonly string string_22 = Path.Combine(Application.StartupPath, "DefaultJoeFishWayPoints.wps");

		// Token: 0x04000B81 RID: 2945
		public static readonly string string_23 = Path.Combine(Class291.JoeFishDataDirectory, "JoeFishDocks.dat");

		// Token: 0x04000B82 RID: 2946
		public static readonly string string_24 = Path.Combine(Application.StartupPath, "TheToonTownSpooferGuide.chm");

		// Token: 0x04000B83 RID: 2947
		public static readonly string string_25 = Path.Combine(Application.StartupPath, "NightLifeInstaller.ttp");

		// Token: 0x04000B84 RID: 2948
		public static readonly string string_26 = Path.Combine(Application.StartupPath, "NightLife.ttp");
	}
}
