using System;
using ns14;
using ns16;
using ns18;
using ns19;
using ns29;
using ns31;

namespace ns20
{
	// Token: 0x02000423 RID: 1059
	internal static class Class437
	{
		// Token: 0x06002818 RID: 10264 RVA: 0x00094390 File Offset: 0x00092590
		public static string smethod_0(this Enum132 type)
		{
			switch (type)
			{
			case Enum132.const_1:
				return "BossBot";
			case Enum132.const_2:
				return "CashBot";
			case Enum132.const_3:
				return "LawBot";
			case Enum132.const_4:
				return "SellBot";
			default:
				return "Unknown";
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000943D4 File Offset: 0x000925D4
		public static string smethod_1(this Enum13 house)
		{
			switch (house)
			{
			case Enum13.const_0:
				return "Red House";
			case Enum13.const_1:
				return "Green House";
			case Enum13.const_2:
				return "Purple House";
			case Enum13.const_3:
				return "Blue House";
			case Enum13.const_4:
				return "Pink House";
			case Enum13.const_5:
				return "Yellow House";
			default:
				throw new NotSupportedException(string.Format("Cannot format house color: '{0}'.", house));
			}
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x0009443C File Offset: 0x0009263C
		public static string smethod_2(this Enum85 wayPointType)
		{
			switch (wayPointType)
			{
			case Enum85.const_0:
				return "Red House";
			case Enum85.const_1:
				return "Green House";
			case Enum85.const_2:
				return "Purple House";
			case Enum85.const_3:
				return "Blue House";
			case Enum85.const_4:
				return "Pink House";
			case Enum85.const_5:
				return "Yellow House";
			case Enum85.const_6:
				return "General Navigation";
			default:
				throw new NotSupportedException(string.Format("Cannot format Gardener Flora way point type: '{0}'.", wayPointType));
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000944B0 File Offset: 0x000926B0
		public static string smethod_3(this Enum50 runType)
		{
			switch (runType)
			{
			case Enum50.const_0:
				return "Normal";
			case Enum50.const_1:
				return "Update Capture";
			default:
				return "Unknown";
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000944E0 File Offset: 0x000926E0
		public static string smethod_4(this Enum99 wayPointType)
		{
			if (wayPointType <= Enum99.flag_9)
			{
				if (wayPointType <= Enum99.flag_16)
				{
					if (wayPointType <= Enum99.flag_5)
					{
						switch (wayPointType)
						{
						case Enum99.flag_0:
							return "Dummy Point";
						case Enum99.flag_1:
							return "Fisherman";
						default:
							if (wayPointType == Enum99.flag_5)
							{
								return "Flower 1";
							}
							break;
						}
					}
					else
					{
						if (wayPointType == Enum99.flag_15)
						{
							return "Tree 1";
						}
						if (wayPointType == Enum99.flag_6)
						{
							return "Flower 2";
						}
						if (wayPointType == Enum99.flag_16)
						{
							return "Tree 2";
						}
					}
				}
				else if (wayPointType <= Enum99.flag_17)
				{
					if (wayPointType == Enum99.flag_7)
					{
						return "Flower 3";
					}
					if (wayPointType == Enum99.flag_17)
					{
						return "Tree 3";
					}
				}
				else
				{
					if (wayPointType == Enum99.flag_8)
					{
						return "Flower 4";
					}
					if (wayPointType == Enum99.flag_18)
					{
						return "Tree 4";
					}
					if (wayPointType == Enum99.flag_9)
					{
						return "Flower 5";
					}
				}
			}
			else if (wayPointType <= Enum99.flag_21)
			{
				if (wayPointType <= Enum99.flag_10)
				{
					if (wayPointType == Enum99.flag_19)
					{
						return "Tree 5";
					}
					if (wayPointType == Enum99.flag_10)
					{
						return "Flower 6";
					}
				}
				else
				{
					if (wayPointType == Enum99.flag_20)
					{
						return "Tree 6";
					}
					if (wayPointType == Enum99.flag_11)
					{
						return "Flower 7";
					}
					if (wayPointType == Enum99.flag_21)
					{
						return "Tree 7";
					}
				}
			}
			else if (wayPointType <= Enum99.flag_22)
			{
				if (wayPointType == Enum99.flag_12)
				{
					return "Flower 8";
				}
				if (wayPointType == Enum99.flag_22)
				{
					return "Tree 8";
				}
			}
			else
			{
				if (wayPointType == Enum99.flag_13)
				{
					return "Flower 9";
				}
				if (wayPointType == Enum99.flag_14)
				{
					return "Flower 10";
				}
				if (wayPointType == Enum99.flag_23)
				{
					return "Wheelbarrow";
				}
			}
			throw new NotSupportedException(string.Format("Cannot format way point type: '{0}'.", wayPointType));
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0009466C File Offset: 0x0009286C
		public static string smethod_5(this Enum57 playGround)
		{
			switch (playGround)
			{
			default:
				return "Unknown";
			case Enum57.const_1:
				return "Estate";
			case Enum57.const_2:
				return "ToonTown Central";
			case Enum57.const_3:
				return "ToonTown Central : Loopy Lane";
			case Enum57.const_4:
				return "ToonTown Central : Punchline Place";
			case Enum57.const_5:
				return "ToonTown Central : Silly Street";
			case Enum57.const_6:
				return "Goofy Speedway";
			case Enum57.const_7:
				return "Chip 'n Dale's Acorn Acres";
			case Enum57.const_8:
				return "Chip 'n Dale's Golf";
			case Enum57.const_9:
				return "Daisy Gardens";
			case Enum57.const_10:
				return "Daisy Gardens : Elm Street";
			case Enum57.const_11:
				return "Daisy Gardens : Maple Street";
			case Enum57.const_12:
				return "Daisy Gardens : Oak Street";
			case Enum57.const_13:
				return "Donald's Dock";
			case Enum57.const_14:
				return "Donald's Dock : Barnacle Boulevard";
			case Enum57.const_15:
				return "Donald's Dock : Lighthouse Lane";
			case Enum57.const_16:
				return "Donald's Dock : Seaweed Street";
			case Enum57.const_17:
				return "Minnie's Melodyland";
			case Enum57.const_18:
				return "Minnie's Melodyland : Alto Avenue";
			case Enum57.const_19:
				return "Minnie's Melodyland : Baritone Boulevard";
			case Enum57.const_20:
				return "Minnie's Melodyland : Tenor Terrace";
			case Enum57.const_21:
				return "The Brrrgh";
			case Enum57.const_22:
				return "The Brrrgh : Polar Place";
			case Enum57.const_23:
				return "The Brrrgh : Sleet Street";
			case Enum57.const_24:
				return "The Brrrgh : Walrus Way";
			case Enum57.const_25:
				return "Donald's Dreamland";
			case Enum57.const_26:
				return "Donald's Dreamland : Lullaby Lane";
			case Enum57.const_27:
				return "Donald's Dreamland : Pajama Place";
			case Enum57.const_28:
				return "Bossbot HQ";
			case Enum57.const_29:
				return "Cashbot HQ";
			case Enum57.const_30:
				return "Sellbot HQ";
			case Enum57.const_31:
				return "Lawbot HQ";
			case Enum57.const_32:
				return "Party Grounds";
			}
		}
	}
}
