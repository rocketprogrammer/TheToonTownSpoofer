using System;
using System.Collections.Generic;
using ns29;
using TSN.Collections;

namespace ns26
{
	// Token: 0x02000458 RID: 1112
	internal sealed class Class464
	{
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x00013296 File Offset: 0x00011496
		public static ReadOnlyDictionary<string, Class464> Cogs
		{
			get
			{
				return Class464.readOnlyDictionary_0;
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000033EB File Offset: 0x000015EB
		private Class464()
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0001329D File Offset: 0x0001149D
		private Class464(string id, string name, Enum132 type)
		{
			this.string_0 = name;
			this.enum132_0 = type;
			this.string_1 = id;
			Class464.dictionary_0.Add(id, this);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000132C6 File Offset: 0x000114C6
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x040015A3 RID: 5539
		private static Dictionary<string, Class464> dictionary_0 = new Dictionary<string, Class464>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040015A4 RID: 5540
		private static ReadOnlyDictionary<string, Class464> readOnlyDictionary_0 = new ReadOnlyDictionary<string, Class464>(Class464.dictionary_0);

		// Token: 0x040015A5 RID: 5541
		public static readonly Class464 class464_0 = new Class464("Unknown", "Unknown", Enum132.const_0);

		// Token: 0x040015A6 RID: 5542
		public static readonly Class464 class464_1 = new Class464("f", "Flunky", Enum132.const_1);

		// Token: 0x040015A7 RID: 5543
		public static readonly Class464 class464_2 = new Class464("p", "Pencil Pusher", Enum132.const_1);

		// Token: 0x040015A8 RID: 5544
		public static readonly Class464 class464_3 = new Class464("ym", "Yesman", Enum132.const_1);

		// Token: 0x040015A9 RID: 5545
		public static readonly Class464 class464_4 = new Class464("mm", "Micro-manager", Enum132.const_1);

		// Token: 0x040015AA RID: 5546
		public static readonly Class464 class464_5 = new Class464("ds", "Downsizer", Enum132.const_1);

		// Token: 0x040015AB RID: 5547
		public static readonly Class464 class464_6 = new Class464("hh", "Head Hunter", Enum132.const_1);

		// Token: 0x040015AC RID: 5548
		public static readonly Class464 class464_7 = new Class464("cr", "Corporate Raider", Enum132.const_1);

		// Token: 0x040015AD RID: 5549
		public static readonly Class464 class464_8 = new Class464("tbc", "The Big Cheese", Enum132.const_1);

		// Token: 0x040015AE RID: 5550
		public static readonly Class464 class464_9 = new Class464("bf", "Bottom Feeder", Enum132.const_3);

		// Token: 0x040015AF RID: 5551
		public static readonly Class464 class464_10 = new Class464("b", "Bloodsucker", Enum132.const_3);

		// Token: 0x040015B0 RID: 5552
		public static readonly Class464 class464_11 = new Class464("dt", "Double Talker", Enum132.const_3);

		// Token: 0x040015B1 RID: 5553
		public static readonly Class464 class464_12 = new Class464("ac", "Ambulance Chaser", Enum132.const_3);

		// Token: 0x040015B2 RID: 5554
		public static readonly Class464 class464_13 = new Class464("bs", "Back Stabber", Enum132.const_3);

		// Token: 0x040015B3 RID: 5555
		public static readonly Class464 class464_14 = new Class464("sd", "Spin Doctor", Enum132.const_3);

		// Token: 0x040015B4 RID: 5556
		public static readonly Class464 class464_15 = new Class464("le", "Legal Eagle", Enum132.const_3);

		// Token: 0x040015B5 RID: 5557
		public static readonly Class464 class464_16 = new Class464("bw", "Big Wig", Enum132.const_3);

		// Token: 0x040015B6 RID: 5558
		public static readonly Class464 class464_17 = new Class464("sc", "Short Change", Enum132.const_2);

		// Token: 0x040015B7 RID: 5559
		public static readonly Class464 class464_18 = new Class464("pp", "Penny Pincher", Enum132.const_2);

		// Token: 0x040015B8 RID: 5560
		public static readonly Class464 class464_19 = new Class464("tw", "Tightwad", Enum132.const_2);

		// Token: 0x040015B9 RID: 5561
		public static readonly Class464 class464_20 = new Class464("bc", "Bean Counter", Enum132.const_2);

		// Token: 0x040015BA RID: 5562
		public static readonly Class464 class464_21 = new Class464("nc", "Number Cruncher", Enum132.const_2);

		// Token: 0x040015BB RID: 5563
		public static readonly Class464 class464_22 = new Class464("mb", "Money Bags", Enum132.const_2);

		// Token: 0x040015BC RID: 5564
		public static readonly Class464 class464_23 = new Class464("ls", "Loan Shark", Enum132.const_2);

		// Token: 0x040015BD RID: 5565
		public static readonly Class464 class464_24 = new Class464("rb", "Robber Barron", Enum132.const_2);

		// Token: 0x040015BE RID: 5566
		public static readonly Class464 class464_25 = new Class464("cc", "Cold Caller", Enum132.const_4);

		// Token: 0x040015BF RID: 5567
		public static readonly Class464 class464_26 = new Class464("tm", "Tele-marketer", Enum132.const_4);

		// Token: 0x040015C0 RID: 5568
		public static readonly Class464 class464_27 = new Class464("nd", "Name Dropper", Enum132.const_4);

		// Token: 0x040015C1 RID: 5569
		public static readonly Class464 class464_28 = new Class464("gh", "Glad Hander", Enum132.const_4);

		// Token: 0x040015C2 RID: 5570
		public static readonly Class464 class464_29 = new Class464("ms", "Mover & Shaker", Enum132.const_4);

		// Token: 0x040015C3 RID: 5571
		public static readonly Class464 class464_30 = new Class464("tf", "Two-Face", Enum132.const_4);

		// Token: 0x040015C4 RID: 5572
		public static readonly Class464 class464_31 = new Class464("m", "The Mingler", Enum132.const_4);

		// Token: 0x040015C5 RID: 5573
		public static readonly Class464 class464_32 = new Class464("mh", "Mr. Hollywood", Enum132.const_4);

		// Token: 0x040015C6 RID: 5574
		public readonly string string_0;

		// Token: 0x040015C7 RID: 5575
		public readonly Enum132 enum132_0;

		// Token: 0x040015C8 RID: 5576
		public readonly string string_1;
	}
}
