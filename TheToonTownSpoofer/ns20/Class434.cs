using System;
using System.Collections.Generic;
using ns28;

namespace ns20
{
	// Token: 0x02000420 RID: 1056
	internal static class Class434
	{
		// Token: 0x0600280D RID: 10253 RVA: 0x00093FD4 File Offset: 0x000921D4
		public static string smethod_0(SortedList<DateTime, KeyValuePair<Version, string[]>> lst)
		{
			string text = string.Concat(new string[]
			{
				Class434.string_1,
				Environment.NewLine,
				Class434.string_5,
				Environment.NewLine,
				Class434.string_2,
				Environment.NewLine
			});
			if (lst != null)
			{
				using (IEnumerator<KeyValuePair<DateTime, KeyValuePair<Version, string[]>>> enumerator = lst.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string str = text;
						string format = Class434.string_0;
						object[] array = new object[5];
						array[0] = Class434.string_3;
						object[] array2 = array;
						int num = 1;
						KeyValuePair<DateTime, KeyValuePair<Version, string[]>> keyValuePair = enumerator.Current;
						array2[num] = keyValuePair.Key.ToShortDateString();
						object[] array3 = array;
						int num2 = 2;
						KeyValuePair<DateTime, KeyValuePair<Version, string[]>> keyValuePair2 = enumerator.Current;
						array3[num2] = keyValuePair2.Value.Key.ToString(4);
						array[3] = Class434.string_4;
						array[4] = Environment.NewLine;
						text = str + string.Format(format, array);
						int num3 = 0;
						for (;;)
						{
							int num4 = num3;
							KeyValuePair<DateTime, KeyValuePair<Version, string[]>> keyValuePair3 = enumerator.Current;
							if (num4 >= keyValuePair3.Value.Value.Length)
							{
								break;
							}
							if (num3 == 0)
							{
								string text2 = text;
								string[] array4 = new string[5];
								array4[0] = text2;
								array4[1] = Class434.string_6;
								string[] array5 = array4;
								int num5 = 2;
								KeyValuePair<DateTime, KeyValuePair<Version, string[]>> keyValuePair4 = enumerator.Current;
								array5[num5] = keyValuePair4.Value.Value[num3];
								array4[3] = Class434.string_7;
								array4[4] = Environment.NewLine;
								text = string.Concat(array4);
							}
							else
							{
								string text3 = text;
								string[] array6 = new string[5];
								array6[0] = text3;
								array6[1] = Class434.string_8;
								string[] array7 = array6;
								int num6 = 2;
								KeyValuePair<DateTime, KeyValuePair<Version, string[]>> keyValuePair5 = enumerator.Current;
								array7[num6] = keyValuePair5.Value.Value[num3];
								array6[3] = Class434.string_9;
								array6[4] = Environment.NewLine;
								text = string.Concat(array6);
							}
							num3++;
						}
					}
				}
			}
			text = text + Class434.string_10 + Environment.NewLine;
			text += Class434.string_11;
			return text;
		}

		// Token: 0x04001415 RID: 5141
		private static readonly string string_0 = "{0}{1} - {2}{3}{4}";

		// Token: 0x04001416 RID: 5142
		private static readonly string string_1 = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\deflang1049{\\fonttbl{\\f0\\fnil\\fcharset0 Calibri;}{\\f1\\fnil\\fcharset2 Symbol;}}";

		// Token: 0x04001417 RID: 5143
		private static readonly string string_2 = "{\\*\\generator The ToonTown Spoofer " + Class500.Current.AssemblyVersion.ToString(4) + ";}\\viewkind4\\uc1\\pard\\sa200\\sl276\\slmult1\\qc\\lang9\\b\\f0\\fs22 The ToonTown Spoofer Release Notes\\b0\\par";

		// Token: 0x04001418 RID: 5144
		private static readonly string string_3 = "\\pard\\sa200\\sl276\\slmult1\\b ";

		// Token: 0x04001419 RID: 5145
		private static readonly string string_4 = "\\b0\\par";

		// Token: 0x0400141A RID: 5146
		private static readonly string string_5 = "\\par";

		// Token: 0x0400141B RID: 5147
		private static readonly string string_6 = "\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlblt\\pnf1\\pnindent0{\\pntxtb\\'B7}}\\fi-360\\li720\\sa200\\sl276\\slmult1 ";

		// Token: 0x0400141C RID: 5148
		private static readonly string string_7 = "\\par";

		// Token: 0x0400141D RID: 5149
		private static readonly string string_8 = "{\\pntext\\f1\\'B7\\tab}";

		// Token: 0x0400141E RID: 5150
		private static readonly string string_9 = "\\par";

		// Token: 0x0400141F RID: 5151
		private static readonly string string_10 = "\\pard\\qc\\'a92012 The Spoof Net. All Rights Reserved. \\par";

		// Token: 0x04001420 RID: 5152
		private static readonly string string_11 = "}";
	}
}
