using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using ns16;

namespace ns21
{
	// Token: 0x0200023A RID: 570
	internal static class Class179
	{
		// Token: 0x06001861 RID: 6241 RVA: 0x00007DE7 File Offset: 0x00005FE7
		public static string smethod_0(this string value)
		{
			if (value == null)
			{
				return null;
			}
			if (value == string.Empty)
			{
				return string.Empty;
			}
			while (value.IndexOf("  ") > -1)
			{
				value = value.Replace("  ", " ");
			}
			return value.Trim();
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000422C4 File Offset: 0x000404C4
		public static bool smethod_1(this string data, char separator, out string key, out string value)
		{
			key = null;
			value = null;
			if (string.IsNullOrEmpty(data))
			{
				return false;
			}
			int num = 0;
			return data.smethod_8(separator, ref num, out key) && data.smethod_7(ref num, out value);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00042300 File Offset: 0x00040500
		public static string smethod_2(this string str, string value, out bool startsWith)
		{
			if (startsWith = str.StartsWith(value))
			{
				return str.Substring(value.Length);
			}
			return str;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00007E27 File Offset: 0x00006027
		public static string[] smethod_3(this string str, StringSplitOptions options, params char[] separator)
		{
			return str.Split(separator, options);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00007E31 File Offset: 0x00006031
		[DebuggerStepThrough]
		public static bool smethod_4(this string line, ref int startIndex, int length, out string value)
		{
			value = null;
			if (line.Length < startIndex + length)
			{
				return false;
			}
			value = line.Substring(startIndex, length);
			startIndex += length;
			return true;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0004232C File Offset: 0x0004052C
		internal static bool smethod_5(this string value)
		{
			if (value == null)
			{
				return false;
			}
			if (value.Length != 19)
			{
				return false;
			}
			int i = 0;
			while (i < value.Length)
			{
				char c = value[i];
				int num = i;
				if (num == 4 || num == 9)
				{
					goto IL_64;
				}
				if (num == 14)
				{
					goto IL_64;
				}
				switch (c)
				{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					break;
				default:
					return false;
				}
				IL_6B:
				i++;
				continue;
				IL_64:
				if (c != '-')
				{
					return false;
				}
				goto IL_6B;
			}
			return true;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000423B8 File Offset: 0x000405B8
		[DebuggerStepThrough]
		public static bool smethod_6(this string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return false;
			}
			int i = 0;
			while (i < value.Length)
			{
				switch (value[i])
				{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					i++;
					break;
				default:
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00007E56 File Offset: 0x00006056
		[DebuggerStepThrough]
		public static bool smethod_7(this string line, ref int startIndex, out string value)
		{
			value = null;
			if (line.Length <= startIndex)
			{
				return false;
			}
			value = line.Substring(startIndex);
			startIndex = line.Length;
			return true;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00042428 File Offset: 0x00040628
		[DebuggerStepThrough]
		public static bool smethod_8(this string line, char c, ref int startIndex, out string value)
		{
			value = null;
			if (line.Length <= startIndex)
			{
				return false;
			}
			int num = line.IndexOf(c, startIndex);
			if (num == -1)
			{
				return false;
			}
			value = line.Substring(startIndex, num - startIndex);
			startIndex = num + 1;
			return true;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00042468 File Offset: 0x00040668
		[DebuggerStepThrough]
		public static bool smethod_9(this string line, char c, ref int startIndex)
		{
			if (line.Length <= startIndex)
			{
				return false;
			}
			int num = line.IndexOf(c, startIndex);
			if (num == -1)
			{
				return false;
			}
			startIndex = num + 1;
			return true;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00042498 File Offset: 0x00040698
		[DebuggerStepThrough]
		public static bool smethod_10(this string line, string s, ref int startIndex)
		{
			if (line.Length < startIndex + s.Length)
			{
				return false;
			}
			int num = line.IndexOf(s, startIndex);
			if (num == -1)
			{
				return false;
			}
			startIndex = num + s.Length;
			return true;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000424D4 File Offset: 0x000406D4
		public static bool smethod_11(this string line, string s, ref int startIndex, out string value)
		{
			value = null;
			if (line.Length < startIndex + s.Length)
			{
				return false;
			}
			int num = line.IndexOf(s, startIndex);
			if (num == -1)
			{
				return false;
			}
			value = line.Substring(startIndex, num - startIndex);
			startIndex = num + s.Length;
			return true;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00042520 File Offset: 0x00040720
		[DebuggerStepThrough]
		public static bool smethod_12(this string line, string s)
		{
			if (line.Length < s.Length)
			{
				return false;
			}
			int num = line.IndexOf(s);
			return num != -1;
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0004254C File Offset: 0x0004074C
		[DebuggerStepThrough]
		public static bool smethod_13(this string value)
		{
			if (value == null)
			{
				return false;
			}
			int length = value.Length;
			if (length != 32)
			{
				return false;
			}
			for (int i = 0; i < length; i++)
			{
				if (!value[i].smethod_0())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0004258C File Offset: 0x0004078C
		[DebuggerStepThrough]
		public static bool smethod_14(this string value, char c, ref int startIndex, out string result)
		{
			int num = -1;
			for (int i = value.Length - 1; i >= startIndex; i--)
			{
				if (value[i] == c)
				{
					num = i;
					IL_26:
					startIndex = num + 1;
					if (num != -1)
					{
						if (value.Length != startIndex)
						{
							result = value.Substring(startIndex);
							return true;
						}
					}
					result = null;
					return false;
				}
			}
			goto IL_26;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000425E4 File Offset: 0x000407E4
		[DebuggerStepThrough]
		public static bool smethod_15(this string value, char c, ref int startIndex)
		{
			for (int i = value.Length - 1; i >= startIndex; i--)
			{
				if (value[i] == c)
				{
					startIndex = i + 1;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0004261C File Offset: 0x0004081C
		public static bool smethod_16(this string value, char c, out string result)
		{
			int num = 0;
			return value.smethod_8(c, ref num, out result);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00007E7A File Offset: 0x0000607A
		public static string smethod_17(this string value, int max_length)
		{
			if (value != null && value.Length > max_length)
			{
				return value.Substring(0, max_length - 1) + '…';
			}
			return value;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00007EA3 File Offset: 0x000060A3
		public static string smethod_18(this string value, int count)
		{
			return string.Format(value, count, (count != 1) ? "s" : "");
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00042638 File Offset: 0x00040838
		public static string smethod_19(this object value)
		{
			if (value == null)
			{
				return "NULL";
			}
			ICollection collection = value as ICollection;
			if (collection == null)
			{
				return "\"" + Convert.ToString(value) + "\"";
			}
			StringBuilder stringBuilder = new StringBuilder("Array: {");
			IEnumerator enumerator = collection.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				if (num > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(enumerator.Current.smethod_19());
				num++;
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000426C4 File Offset: 0x000408C4
		public unsafe static bool smethod_20(this string str, string match)
		{
			IntPtr intPtr2;
			IntPtr intPtr = intPtr2 = match;
			if (intPtr != 0)
			{
				intPtr2 = (IntPtr)((int)intPtr + RuntimeHelpers.OffsetToStringData);
			}
			char* ptr = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = intPtr4 = str;
			if (intPtr3 != 0)
			{
				intPtr4 = (IntPtr)((int)intPtr3 + RuntimeHelpers.OffsetToStringData);
			}
			char* ptr2 = intPtr4;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			while (ptr2[num2] != '\0')
			{
				if (ptr[num] == '*')
				{
					break;
				}
				if (ptr[num] != ptr2[num2] && ptr[num] != '?')
				{
					return false;
				}
				num++;
				num2++;
			}
			while (ptr2[num2] != '\0')
			{
				if (ptr[num] == '*')
				{
					if (ptr[(IntPtr)(++num) * 2] == '\0')
					{
						return true;
					}
					num3 = num;
					num4 = num2 + 1;
				}
				else
				{
					if (ptr[num] != ptr2[num2])
					{
						if (ptr[num] != '?')
						{
							num = num3;
							num2 = num4++;
							continue;
						}
					}
					num++;
					num2++;
				}
			}
			while (ptr[num] == '*')
			{
				num++;
			}
			return '\0' == ptr[num];
		}
	}
}
