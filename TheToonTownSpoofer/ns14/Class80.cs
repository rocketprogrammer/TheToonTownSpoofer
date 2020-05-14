using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using ns20;
using ns22;
using ns23;
using ns24;
using ns26;
using ns28;
using ns31;

namespace ns14
{
	// Token: 0x020001C6 RID: 454
	internal static class Class80
	{
		// Token: 0x06001474 RID: 5236 RVA: 0x00025520 File Offset: 0x00023720
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static bool smethod_0(Enum101 type, string username, Dictionary<string, string> variables, out Class142 toontownWindow)
		{
			toontownWindow = null;
			Process process = null;
			bool result;
			try
			{
				Class96 @class;
				switch (type)
				{
				case Enum101.const_1:
				{
					Class99 connectSettings = Class110.Instance.ConnectSettings;
					if (connectSettings.SpoofedToonTownEnabled)
					{
						@class = Class110.Instance.ConnectSettings.SpoofedToonTownVersionData;
						Class80.smethod_1(Class80.string_0, connectSettings.PatchServer.PANDA_DOWNLOAD_URL);
					}
					else
					{
						@class = Class110.Instance.ConnectSettings.ActualToonTownVersionData;
						Class80.smethod_1(Class80.string_0, @class.Properties.PANDA_DOWNLOAD_URL);
					}
					Class80.smethod_1(Class80.string_1, Class80.string_19);
					Class80.smethod_1(Class80.string_2, Class80.string_25);
					break;
				}
				case Enum101.const_2:
					@class = Class110.Instance.ConnectSettings.ActualTestToonTownVersionData;
					Class80.smethod_1(Class80.string_0, @class.Properties.PANDA_DOWNLOAD_URL);
					Class80.smethod_1(Class80.string_1, Class80.string_20);
					Class80.smethod_1(Class80.string_2, Class80.string_24);
					break;
				default:
					throw new NotSupportedException(Class80.string_3);
				}
				Class80.smethod_1(Class80.string_4, string.Empty);
				Class80.smethod_1(Class80.string_5, string.Empty);
				Class80.smethod_1(Class80.string_6, Class80.string_22);
				Class80.smethod_1(Class80.string_7, Class80.string_23);
				Class80.smethod_1(Class80.string_8, string.Empty);
				Class80.smethod_1(Class80.string_9, Class80.string_21);
				Class80.smethod_1(Class80.string_10, @class.Properties.GAME_VERSION_TEXT);
				Class80.smethod_1(Class80.string_11, @class.Properties.GAME_SERVER);
				Class80.smethod_1(Class80.string_12, @class.Properties.ACCOUNT_SERVER);
				string key = Class80.string_13;
				if (Class80.action_0 == null)
				{
					Class80.action_0 = new Action<KeyValuePair<string, string>>(Class80.smethod_2);
				}
				variables.smethod_5(key, Class80.action_0);
				string key2 = Class80.string_14;
				if (Class80.action_1 == null)
				{
					Class80.action_1 = new Action<KeyValuePair<string, string>>(Class80.smethod_3);
				}
				variables.smethod_5(key2, Class80.action_1);
				string key3 = Class80.string_15;
				if (Class80.action_2 == null)
				{
					Class80.action_2 = new Action<KeyValuePair<string, string>>(Class80.smethod_4);
				}
				variables.smethod_5(key3, Class80.action_2);
				string key4 = Class80.string_16;
				if (Class80.action_3 == null)
				{
					Class80.action_3 = new Action<KeyValuePair<string, string>>(Class80.smethod_5);
				}
				variables.smethod_5(key4, Class80.action_3);
				string key5 = Class80.string_17;
				if (Class80.action_4 == null)
				{
					Class80.action_4 = new Action<KeyValuePair<string, string>>(Class80.smethod_6);
				}
				variables.smethod_5(key5, Class80.action_4);
				process = new Process();
				process.EnableRaisingEvents = true;
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				switch (type)
				{
				default:
					processStartInfo.WorkingDirectory = Class291.ToonTownOpenDataDirectory;
					processStartInfo.FileName = Path.Combine(Class291.ToonTownOpenDataDirectory, Class502.string_8);
					break;
				case Enum101.const_2:
					processStartInfo.WorkingDirectory = Class291.ToonTownTestDataDirectory;
					processStartInfo.FileName = Path.Combine(Class291.ToonTownTestDataDirectory, Class502.string_8);
					break;
				}
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = string.Empty;
				processStartInfo.UseShellExecute = true;
				process.StartInfo = processStartInfo;
				toontownWindow = Class142.smethod_8(process, type, username, false);
				process.Start();
				result = true;
			}
			catch (Exception ex)
			{
				if (process != null)
				{
					process.Dispose();
				}
				ex.smethod_0();
				result = false;
			}
			return result;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00004F93 File Offset: 0x00003193
		private static void smethod_1(string variable, string value)
		{
			Environment.SetEnvironmentVariable(variable, value, EnvironmentVariableTarget.Process);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00004F9D File Offset: 0x0000319D
		[CompilerGenerated]
		private static void smethod_2(KeyValuePair<string, string> args)
		{
			Class80.smethod_1(args.Key, args.Value);
			Class80.smethod_1(Class80.string_18, args.Value);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00004FC3 File Offset: 0x000031C3
		[CompilerGenerated]
		private static void smethod_3(KeyValuePair<string, string> args)
		{
			Class80.smethod_1(args.Key, args.Value);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00004FC3 File Offset: 0x000031C3
		[CompilerGenerated]
		private static void smethod_4(KeyValuePair<string, string> args)
		{
			Class80.smethod_1(args.Key, args.Value);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00004FC3 File Offset: 0x000031C3
		[CompilerGenerated]
		private static void smethod_5(KeyValuePair<string, string> args)
		{
			Class80.smethod_1(args.Key, args.Value);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00004FC3 File Offset: 0x000031C3
		[CompilerGenerated]
		private static void smethod_6(KeyValuePair<string, string> args)
		{
			Class80.smethod_1(args.Key, args.Value);
		}

		// Token: 0x040001FC RID: 508
		private static readonly string string_0 = "DOWNLOAD_SERVER";

		// Token: 0x040001FD RID: 509
		private static readonly string string_1 = "IS_TEST_SERVER";

		// Token: 0x040001FE RID: 510
		private static readonly string string_2 = "GAME_ADFRAME_BUTTON_7";

		// Token: 0x040001FF RID: 511
		private static readonly string string_3 = "Only Open and Test are supported.";

		// Token: 0x04000200 RID: 512
		private static readonly string string_4 = "GAME_ADFRAME_BUTTON_1";

		// Token: 0x04000201 RID: 513
		private static readonly string string_5 = "GAME_ADFRAME_BUTTON_2";

		// Token: 0x04000202 RID: 514
		private static readonly string string_6 = "GAME_ADFRAME_BUTTON_3";

		// Token: 0x04000203 RID: 515
		private static readonly string string_7 = "GAME_ADFRAME_BUTTON_4";

		// Token: 0x04000204 RID: 516
		private static readonly string string_8 = "GAME_ADFRAME_BUTTON_5";

		// Token: 0x04000205 RID: 517
		private static readonly string string_9 = "GAME_ADFRAME_BUTTON_6";

		// Token: 0x04000206 RID: 518
		private static readonly string string_10 = "GAME_VERSION_TEXT";

		// Token: 0x04000207 RID: 519
		private static readonly string string_11 = "GAME_SERVER";

		// Token: 0x04000208 RID: 520
		private static readonly string string_12 = "ACCOUNT_SERVER";

		// Token: 0x04000209 RID: 521
		private static readonly string string_13 = "LOGIN_TOKEN";

		// Token: 0x0400020A RID: 522
		private static readonly string string_14 = "GAME_USERNAME";

		// Token: 0x0400020B RID: 523
		private static readonly string string_15 = "GAME_DISL_ID";

		// Token: 0x0400020C RID: 524
		private static readonly string string_16 = "USER_TOONTOWN_ACCESS";

		// Token: 0x0400020D RID: 525
		private static readonly string string_17 = "GAME_CHAT_ELIGIBLE";

		// Token: 0x0400020E RID: 526
		private static readonly string string_18 = "DISLTOKEN";

		// Token: 0x0400020F RID: 527
		private static readonly string string_19 = "0";

		// Token: 0x04000210 RID: 528
		private static readonly string string_20 = "1";

		// Token: 0x04000211 RID: 529
		private static readonly string string_21 = "http://toontown.go.com/membership/account-management/";

		// Token: 0x04000212 RID: 530
		private static readonly string string_22 = "http://toontown.go.com/toon-hq/top-toons";

		// Token: 0x04000213 RID: 531
		private static readonly string string_23 = "http://toontown.go.com/help/players-guide/";

		// Token: 0x04000214 RID: 532
		private static readonly string string_24 = "http://test.toontown.go.com/report-bug-launcher";

		// Token: 0x04000215 RID: 533
		private static readonly string string_25 = "http://toontown.go.com/help/report-bug";

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private static Action<KeyValuePair<string, string>> action_0;

		// Token: 0x04000217 RID: 535
		[CompilerGenerated]
		private static Action<KeyValuePair<string, string>> action_1;

		// Token: 0x04000218 RID: 536
		[CompilerGenerated]
		private static Action<KeyValuePair<string, string>> action_2;

		// Token: 0x04000219 RID: 537
		[CompilerGenerated]
		private static Action<KeyValuePair<string, string>> action_3;

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		private static Action<KeyValuePair<string, string>> action_4;
	}
}
