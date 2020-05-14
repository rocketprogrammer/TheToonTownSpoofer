using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ns15;
using ns25;
using ns26;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns23
{
	// Token: 0x020003A2 RID: 930
	internal static class Class371
	{
		// Token: 0x06002415 RID: 9237 RVA: 0x0007A408 File Offset: 0x00078608
		public static Enum29 smethod_0(this OperatingSystem os)
		{
			Struct15 @struct = default(Struct15);
			@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Struct15));
			if (!Class265.GetVersionEx(ref @struct))
			{
				throw new Win32Exception();
			}
			Enum29 result = Enum29.const_0;
			Struct53 struct2 = default(Struct53);
			Class265.GetSystemInfo(ref struct2);
			switch (@struct.enum113_0)
			{
			case Enum113.const_0:
				result = Enum29.const_1;
				break;
			case Enum113.const_1:
			{
				uint uint_ = @struct.uint_1;
				if (uint_ == 4U)
				{
					uint uint_2 = @struct.uint_2;
					if (uint_2 != 0U)
					{
						if (uint_2 != 10U)
						{
							if (uint_2 == 90U)
							{
								result = Enum29.const_6;
							}
						}
						else if (@struct.string_0[0] == 'A')
						{
							result = Enum29.const_5;
						}
						else
						{
							result = Enum29.const_4;
						}
					}
					else
					{
						if (@struct.string_0[0] != 'B')
						{
							if (@struct.string_0[0] != 'C')
							{
								result = Enum29.const_2;
								break;
							}
						}
						result = Enum29.const_3;
					}
				}
				break;
			}
			case Enum113.const_2:
				switch (@struct.uint_1)
				{
				case 3U:
					result = Enum29.const_7;
					break;
				case 4U:
					switch (@struct.enum128_0)
					{
					case Enum128.const_2:
						result = Enum29.const_8;
						break;
					case Enum128.const_1:
						result = Enum29.const_9;
						break;
					}
					break;
				case 5U:
					switch (@struct.uint_2)
					{
					case 0U:
						result = Enum29.const_10;
						break;
					case 1U:
						result = Enum29.const_11;
						break;
					case 2U:
						if (@struct.enum112_0.HasFlag(Enum112.flag_12))
						{
							result = Enum29.const_13;
						}
						else if (@struct.enum128_0 == Enum128.const_2 && struct2.enum133_0 == Enum133.const_0)
						{
							result = Enum29.const_12;
						}
						else
						{
							result = ((Class265.GetSystemMetrics(Enum67.const_91) == 0) ? Enum29.const_14 : Enum29.const_15);
						}
						break;
					}
					break;
				case 6U:
					switch (@struct.uint_2)
					{
					case 0U:
						result = ((@struct.enum128_0 == Enum128.const_2) ? Enum29.const_16 : Enum29.const_17);
						break;
					case 1U:
						result = ((@struct.enum128_0 == Enum128.const_2) ? Enum29.const_19 : Enum29.const_18);
						break;
					default:
						if (@struct.uint_2 > 1U)
						{
							result = Enum29.const_20;
						}
						break;
					}
					break;
				default:
					if (@struct.uint_1 > 6U)
					{
						result = Enum29.const_20;
					}
					break;
				}
				break;
			}
			return result;
		}
	}
}
