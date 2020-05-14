using System;
using System.Collections;
using System.ComponentModel;

namespace ns29
{
	// Token: 0x020004BE RID: 1214
	internal static class Class511
	{
		// Token: 0x06002D91 RID: 11665 RVA: 0x00015CF4 File Offset: 0x00013EF4
		public static void smethod_0(this Enum value)
		{
			if (!value.smethod_2())
			{
				throw value.smethod_1();
			}
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00015D05 File Offset: 0x00013F05
		public static InvalidEnumArgumentException smethod_1(this Enum value)
		{
			return new InvalidEnumArgumentException("value", Convert.ToInt32(value), value.GetType());
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00015D1D File Offset: 0x00013F1D
		public static bool smethod_2(this Enum value)
		{
			if (value.smethod_3())
			{
				return value.smethod_5();
			}
			return value.smethod_4();
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00015D34 File Offset: 0x00013F34
		public static bool smethod_3(this Enum value)
		{
			return value.GetType().GetCustomAttributes(typeof(FlagsAttribute), false).Length > 0;
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00015D51 File Offset: 0x00013F51
		private static bool smethod_4(this Enum value)
		{
			return Enum.IsDefined(value.GetType(), value);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000AF494 File Offset: 0x000AD694
		private static bool smethod_5(this Enum value)
		{
			Type type = value.GetType();
			TypeCode typeCode = value.GetTypeCode();
			switch (typeCode)
			{
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
			case TypeCode.Int64:
			{
				long num = Convert.ToInt64(value);
				using (IEnumerator enumerator = Enum.GetValues(type).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object value2 = enumerator.Current;
						long num2 = Convert.ToInt64(value2);
						if (num2 == num)
						{
							return true;
						}
						num &= ~num2;
					}
					return false;
				}
				break;
			}
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				break;
			default:
				throw new ArgumentException(string.Format("Cannot validate Enum '{0}' with invalid TypeCode: '{1}'.", type, typeCode));
			}
			ulong num3 = Convert.ToUInt64(value);
			foreach (object value3 in Enum.GetValues(type))
			{
				ulong num4 = Convert.ToUInt64(value3);
				if (num4 == num3)
				{
					return true;
				}
				num3 &= ~num4;
			}
			return false;
		}
	}
}
