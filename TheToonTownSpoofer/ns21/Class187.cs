using System;
using System.Collections.Generic;
using System.Text;
using ns23;

namespace ns21
{
	// Token: 0x02000245 RID: 581
	internal static class Class187
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x000446C4 File Offset: 0x000428C4
		public static HashSet<string> smethod_0(byte[] buffer)
		{
			HashSet<string> hashSet = null;
			string @string = Encoding.ASCII.GetString(buffer);
			int i = 0;
			while (i < @string.Length && @string.smethod_10("phase_", ref i))
			{
				int num;
				i = (num = i - "phase_".Length);
				string text;
				if (@string.smethod_8('/', ref i, out text))
				{
					string a;
					if (!Class136.smethod_7(text))
					{
						i = num + "phase_".Length;
					}
					else if (@string.smethod_8('/', ref i, out text) && (a = text.ToLower()) != null)
					{
						string text2;
						if (!(a == "audio"))
						{
							if (!(a == "maps"))
							{
								continue;
							}
							while (i <= @string.Length)
							{
								if (@string.smethod_9('.', ref i) && @string.smethod_4(ref i, 3, out text))
								{
									string a2;
									if ((a2 = text.ToLower()) == null || (!(a2 == "jpg") && !(a2 == "rgb")))
									{
										if (!text.smethod_1())
										{
											break;
										}
									}
									else
									{
										text2 = @string.Substring(num, i - num);
										if (!text2.smethod_1())
										{
											break;
										}
										goto IL_1E7;
									}
								}
							}
							continue;
						}
						else
						{
							string a3;
							if (!@string.smethod_8('/', ref i, out text) || (a3 = text.ToLower()) == null)
							{
								continue;
							}
							if (!(a3 == "bgm") && !(a3 == "dial") && !(a3 == "sfx"))
							{
								continue;
							}
							while (i <= @string.Length)
							{
								if (@string.smethod_9('.', ref i) && @string.smethod_4(ref i, 3, out text))
								{
									string a4;
									if ((a4 = text.ToLower()) == null || (!(a4 == "wav") && !(a4 == "mp3") && !(a4 == "mid")))
									{
										if (!text.smethod_1())
										{
											break;
										}
									}
									else
									{
										text2 = @string.Substring(num, i - num);
										if (text2.smethod_1())
										{
											goto IL_1E7;
										}
										break;
									}
								}
							}
							continue;
						}
						IL_1E7:
						if (hashSet == null)
						{
							hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
						}
						if (!hashSet.Contains(text2))
						{
							hashSet.Add(text2);
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000448E4 File Offset: 0x00042AE4
		private static bool smethod_1(this string str)
		{
			foreach (char c in str)
			{
				if (!char.IsDigit(c) && !char.IsLetter(c) && c != '_' && c != '-' && c != '.' && c != '/')
				{
					return false;
				}
			}
			return true;
		}
	}
}
