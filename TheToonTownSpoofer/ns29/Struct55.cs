using System;
using ns21;

namespace ns29
{
	// Token: 0x020004C3 RID: 1219
	internal struct Struct55 : IComparable<Struct55>, IEquatable<Struct55>, IComparable, IFormattable
	{
		// Token: 0x06002DAC RID: 11692 RVA: 0x00015E7D File Offset: 0x0001407D
		public Struct55(ulong code)
		{
			this.ulong_0 = code;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00015E86 File Offset: 0x00014086
		public Struct55(string code)
		{
			this.ulong_0 = Struct55.smethod_8(code);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00015ED3 File Offset: 0x000140D3
		public override string ToString()
		{
			return this.ToString("D", null);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00015EE1 File Offset: 0x000140E1
		public string method_0(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00015EEB File Offset: 0x000140EB
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return Struct55.smethod_9(this.ulong_0, format);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000AF900 File Offset: 0x000ADB00
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is Struct55))
			{
				throw new ArgumentException(Struct55.string_4);
			}
			Struct55 value2 = (Struct55)value;
			return this.CompareTo(value2);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00015EF9 File Offset: 0x000140F9
		public int CompareTo(Struct55 value)
		{
			if (value.ulong_0 == this.ulong_0)
			{
				return 0;
			}
			if (this.ulong_0 < value.ulong_0)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00015F1E File Offset: 0x0001411E
		public bool Equals(Struct55 code)
		{
			return code.ulong_0 == this.ulong_0;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000AF934 File Offset: 0x000ADB34
		public override bool Equals(object obj)
		{
			return obj != null && obj is Struct55 && ((Struct55)obj).ulong_0 == this.ulong_0;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000AF968 File Offset: 0x000ADB68
		public override int GetHashCode()
		{
			return 3723 + this.ulong_0.GetHashCode();
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00015F32 File Offset: 0x00014132
		public static bool smethod_0(Struct55 a, Struct55 b)
		{
			return a.ulong_0 == b.ulong_0;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00015F47 File Offset: 0x00014147
		public static bool smethod_1(Struct55 a, Struct55 b)
		{
			return !Struct55.smethod_0(a, b);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00015F53 File Offset: 0x00014153
		public static Struct55 smethod_2(ulong l)
		{
			return new Struct55(l);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00015F5B File Offset: 0x0001415B
		public static Struct55 smethod_3(string s)
		{
			return new Struct55(s);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00015F63 File Offset: 0x00014163
		public static string smethod_4(Struct55 c)
		{
			return c.ToString();
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00015F72 File Offset: 0x00014172
		public static ulong smethod_5(Struct55 c)
		{
			return c.ulong_0;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00015F7B File Offset: 0x0001417B
		public static Struct55 smethod_6(string input)
		{
			return new Struct55(Struct55.smethod_8(input));
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000AF98C File Offset: 0x000ADB8C
		public static bool smethod_7(string input, out Struct55 result)
		{
			if (input == null)
			{
				result = default(Struct55);
				return false;
			}
			if ((input.Length == 16 && input.smethod_6()) || (input.Length == 19 && input.smethod_5()))
			{
				result = Struct55.smethod_3(input);
				return true;
			}
			result = default(Struct55);
			return false;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000AF9E0 File Offset: 0x000ADBE0
		private static ulong smethod_8(string input)
		{
			if (input == null)
			{
				return 0UL;
			}
			if (input.Length == 16 && input.smethod_6())
			{
				return ulong.Parse(input);
			}
			if (input.Length != 19 || !input.smethod_5())
			{
				throw new FormatException(Struct55.string_3);
			}
			return ulong.Parse(input.Substring(0, 4) + input.Substring(5, 4) + input.Substring(10, 4) + input.Substring(15, 4));
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000AFA5C File Offset: 0x000ADC5C
		private static string smethod_9(ulong input, string format)
		{
			if (format == null || format.Length == 0)
			{
				format = "D";
			}
			if (format.Length != 1)
			{
				throw new FormatException(string.Format(Struct55.string_2, format));
			}
			char c = format[0];
			if (c == 'D')
			{
				return input.ToString(Struct55.string_0).Insert(4, Struct55.string_1).Insert(9, Struct55.string_1).Insert(14, Struct55.string_1);
			}
			if (c != 'N')
			{
				throw new FormatException(string.Format(Struct55.string_2, format));
			}
			return input.ToString(Struct55.string_0);
		}

		// Token: 0x04001803 RID: 6147
		private static readonly string string_0 = "D16";

		// Token: 0x04001804 RID: 6148
		private static readonly string string_1 = "-";

		// Token: 0x04001805 RID: 6149
		private static readonly string string_2 = "Invalid Code format specification: '{0}'.";

		// Token: 0x04001806 RID: 6150
		private static readonly string string_3 = "The input string was not in any recognizable code format.";

		// Token: 0x04001807 RID: 6151
		private static readonly string string_4 = "Argument must be Code";

		// Token: 0x04001808 RID: 6152
		public static readonly Struct55 struct55_0 = default(Struct55);

		// Token: 0x04001809 RID: 6153
		private readonly ulong ulong_0;
	}
}
