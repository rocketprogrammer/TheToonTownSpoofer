using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x020003ED RID: 1005
	internal sealed class Class408 : IComparer<string>, IComparer
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x00011094 File Offset: 0x0000F294
		public static Class408 Default
		{
			get
			{
				return Class408.lazy_0.Value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000110A0 File Offset: 0x0000F2A0
		public static Class408 DefaultZeroesFirst
		{
			get
			{
				return Class408.lazy_1.Value;
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000033EB File Offset: 0x000015EB
		private Class408()
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000110AC File Offset: 0x0000F2AC
		private Class408(bool zeroesFirst)
		{
			this.bool_0 = zeroesFirst;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00088D00 File Offset: 0x00086F00
		int IComparer.Compare(object x, object y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			string text = x as string;
			string text2 = y as string;
			if (text != null && text2 != null)
			{
				return Class408.smethod_0(text, text2, this.bool_0);
			}
			return Comparer.Default.Compare(x, y);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000110BB File Offset: 0x0000F2BB
		public int Compare(string x, string y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			return Class408.smethod_0(x, y, this.bool_0);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00088D50 File Offset: 0x00086F50
		private static int smethod_0(string s1, string s2, bool zeroesFirst)
		{
			if (s1 != null && s1.Length != 0)
			{
				if (s2 == null || s2.Length == 0)
				{
					return 1;
				}
				int length = s1.Length;
				int length2 = s2.Length;
				bool flag = char.IsLetterOrDigit(s1[0]);
				bool flag2 = char.IsLetterOrDigit(s2[0]);
				if (flag && !flag2)
				{
					return 1;
				}
				if (!flag && flag2)
				{
					return -1;
				}
				int num = 0;
				int num2 = 0;
				int num3;
				for (;;)
				{
					char c = s1[num];
					char c2 = s2[num2];
					flag = char.IsDigit(c);
					flag2 = char.IsDigit(c2);
					if (!flag && !flag2)
					{
						if (c != c2)
						{
							bool flag3 = char.IsLetter(c);
							bool flag4 = char.IsLetter(c2);
							if (flag3 && flag4)
							{
								c = char.ToUpper(c);
								c2 = char.ToUpper(c2);
								num3 = (int)(c - c2);
								if (num3 != 0)
								{
									return num3;
								}
							}
							else if (!flag3 && !flag4)
							{
								num3 = (int)(c - c2);
								if (num3 != 0)
								{
									return num3;
								}
							}
							else
							{
								if (flag3)
								{
									return 1;
								}
								if (flag4)
								{
									return -1;
								}
							}
						}
					}
					else if (flag && flag2)
					{
						num3 = Class408.smethod_1(ref s1, ref length, ref num, ref s2, ref length2, ref num2, zeroesFirst);
						if (num3 != 0)
						{
							break;
						}
					}
					else
					{
						if (flag)
						{
							return -1;
						}
						if (flag2)
						{
							return 1;
						}
					}
					num++;
					num2++;
					if (num >= length)
					{
						goto IL_156;
					}
					if (num2 >= length2)
					{
						return 1;
					}
				}
				return num3;
				IL_156:
				if (num2 >= length2)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (s2 != null && s2.Length != 0)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00088ED0 File Offset: 0x000870D0
		private static int smethod_1(ref string s1, ref int s1Length, ref int i1, ref string s2, ref int s2Length, ref int i2, bool zeroesFirst)
		{
			int num = i1;
			int num2 = i2;
			int num3 = i1;
			int num4 = i2;
			Class408.smethod_2(ref s1, ref s1Length, i1, ref num, ref num3);
			Class408.smethod_2(ref s2, ref s2Length, i2, ref num2, ref num4);
			int num5 = i1;
			i1 = num3 - 1;
			int num6 = i2;
			i2 = num4 - 1;
			if (zeroesFirst)
			{
				int num7 = num - num5;
				int num8 = num2 - num6;
				if (num7 > num8)
				{
					return -1;
				}
				if (num7 < num8)
				{
					return 1;
				}
			}
			int num9 = num4 - num2;
			int num10 = num3 - num;
			if (num9 == num10)
			{
				int j = num;
				int num11 = num2;
				while (j <= i1)
				{
					int num12 = (int)(s1[j] - s2[num11]);
					if (num12 != 0)
					{
						return num12;
					}
					j++;
					num11++;
				}
				num9 = num3 - num5;
				num10 = num4 - num6;
				if (num9 == num10)
				{
					return 0;
				}
			}
			if (num9 > num10)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00088FA0 File Offset: 0x000871A0
		private static void smethod_2(ref string s, ref int length, int start, ref int nzStart, ref int end)
		{
			nzStart = start;
			end = start;
			bool flag = true;
			char c = s[end];
			do
			{
				if (flag)
				{
					if ('0' == c)
					{
						nzStart++;
					}
					else
					{
						flag = false;
					}
				}
				end++;
				if (end >= length)
				{
					return;
				}
				c = s[end];
			}
			while (char.IsDigit(c));
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00089000 File Offset: 0x00087200
		// Note: this type is marked as 'beforefieldinit'.
		static Class408()
		{
			if (Class408.func_0 == null)
			{
				Class408.func_0 = new Func<Class408>(Class408.smethod_3);
			}
			Class408.lazy_0 = new Lazy<Class408>(Class408.func_0);
			if (Class408.func_1 == null)
			{
				Class408.func_1 = new Func<Class408>(Class408.smethod_4);
			}
			Class408.lazy_1 = new Lazy<Class408>(Class408.func_1);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000110DC File Offset: 0x0000F2DC
		[CompilerGenerated]
		private static Class408 smethod_3()
		{
			return new Class408();
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000110E3 File Offset: 0x0000F2E3
		[CompilerGenerated]
		private static Class408 smethod_4()
		{
			return new Class408(true);
		}

		// Token: 0x040012C7 RID: 4807
		private static readonly Lazy<Class408> lazy_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly Lazy<Class408> lazy_1;

		// Token: 0x040012C9 RID: 4809
		private bool bool_0;

		// Token: 0x040012CA RID: 4810
		[CompilerGenerated]
		private static Func<Class408> func_0;

		// Token: 0x040012CB RID: 4811
		[CompilerGenerated]
		private static Func<Class408> func_1;
	}
}
