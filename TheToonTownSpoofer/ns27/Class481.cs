using System;
using System.Collections.Generic;
using System.IO;
using ns15;
using ns18;
using ns20;
using ns22;
using ns23;
using ns26;
using ns29;

namespace ns27
{
	// Token: 0x02000487 RID: 1159
	internal static class Class481
	{
		// Token: 0x06002B39 RID: 11065 RVA: 0x000A78D0 File Offset: 0x000A5AD0
		public static bool smethod_0(EventHandler<EventArgs9> progressChanged, string installPath)
		{
			string path = Path.Combine(installPath, "phase_1.mf");
			string path2 = Path.Combine(installPath, "phase_2.mf");
			bool result;
			try
			{
				using (Stream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					using (Stream stream2 = File.Open(path2, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						using (Class136 @class = new Class136(stream))
						{
							using (Class136 class2 = new Class136(stream2))
							{
								@class.method_10();
								class2.method_10();
								Class337 class3 = @class.method_8("phase_1_index.txt");
								Class337 class4 = class2.method_8("phase_2_index.txt");
								int num = class3.Files.Count + class4.Files.Count;
								int num2 = 0;
								if (progressChanged != null)
								{
									progressChanged(null, new EventArgs9((long)num2, (long)num));
								}
								Class481.smethod_1(progressChanged, installPath, @class, class3, num, ref num2);
								Class481.smethod_1(progressChanged, installPath, class2, class4, num, ref num2);
							}
						}
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				result = false;
			}
			return result;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000A7A20 File Offset: 0x000A5C20
		private static void smethod_1(EventHandler<EventArgs9> progressChanged, string installPath, Class136 mf, Class337 index, int total, ref int count)
		{
			foreach (KeyValuePair<string, Class337.Struct34> keyValuePair in index)
			{
				string text = Path.Combine(installPath, keyValuePair.Key);
				if (!File.Exists(text) || Class234.smethod_11(text) != keyValuePair.Value.ExpectedSize || Struct43.smethod_6(Class513.smethod_0(text), keyValuePair.Value.ExpectedHash))
				{
					if (mf.method_6(keyValuePair.Key))
					{
						Class338 @class = mf[keyValuePair.Key];
						mf.method_15(@class);
						@class.smethod_0(text);
						@class.Data = null;
						Class110.Instance.CreatedFileArchive.method_4(text);
					}
					count++;
					if (progressChanged != null)
					{
						progressChanged(null, new EventArgs9((long)count, (long)total));
					}
				}
			}
		}
	}
}
