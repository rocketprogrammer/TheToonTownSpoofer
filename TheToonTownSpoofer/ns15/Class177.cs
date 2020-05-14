using System;
using System.Collections.Generic;

namespace ns15
{
	// Token: 0x02000233 RID: 563
	internal sealed class Class177
	{
		// Token: 0x06001852 RID: 6226 RVA: 0x00041C94 File Offset: 0x0003FE94
		static Class177()
		{
			new Class177(522000000U, "Boingy Acres");
			new Class177(364000000U, "Boingy Bay");
			new Class177(528000000U, "Boingy Harbor");
			new Class177(650000000U, "Boingy Summit");
			new Class177(432000000U, "Boingyboro");
			new Class177(754000000U, "Bouncy Summit");
			new Class177(412000000U, "Bouncyville");
			new Class177(608000000U, "Crazy Grove");
			new Class177(756000000U, "Crazy Hills");
			new Class177(404000000U, "Crazy River");
			new Class177(658000000U, "Crazyham");
			new Class177(662000000U, "Funnyfield");
			new Class177(712000000U, "Giggly Bay");
			new Class177(664000000U, "Giggly Grove");
			new Class177(750000000U, "Kookyboro");
			new Class177(616000000U, "Giggly Hills");
			new Class177(360000000U, "Giggly Point");
			new Class177(714000000U, "Giggly Valley");
			new Class177(568000000U, "Gigglyfield");
			new Class177(410000000U, "Gigglyham");
			new Class177(620000000U, "Goofy Valley");
			new Class177(530000000U, "Goofyport");
			new Class177(434000000U, "Kooky Grove");
			new Class177(336000000U, "Kookytown");
			new Class177(452000000U, "Kookywood");
			new Class177(676000000U, "Loony Bluffs");
			new Class177(772000000U, "Loonyburgh");
			new Class177(328000000U, "Loonyville");
			new Class177(454000000U, "Loopy Harbor");
			new Class177(752000000U, "Loopy Valley");
			new Class177(726000000U, "Nutty Hills");
			new Class177(414000000U, "Nutty River");
			new Class177(686000000U, "Nutty Summit");
			new Class177(720000000U, "Nuttyboro");
			new Class177(362000000U, "Nuttyville");
			new Class177(688000000U, "Nuttywood");
			new Class177(550000000U, "Screwy Park");
			new Class177(430000000U, "Screwy Valley");
			new Class177(734000000U, "Silly Rapids");
			new Class177(632000000U, "Silly Valley");
			new Class177(316000000U, "Sillyham");
			new Class177(450000000U, "Toon Valley");
			new Class177(532000000U, "Wacky Falls");
			new Class177(636000000U, "Zany Acres");
			new Class177(520000000U, "Zanytown");
			new Class177(738000000U, "Zanywood");
			new Class177(524000000U, "Zippetyham");
			new Class177(320000000U, "TestTown 1");
			new Class177(330000000U, "TestTown 2");
			new Class177(310000000U, "ToonValley");
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00041FCC File Offset: 0x000401CC
		public static Class177 smethod_0(uint shardID)
		{
			Class177 result;
			lock (Class177.dictionary_0)
			{
				if (!Class177.dictionary_0.ContainsKey(shardID))
				{
					result = new Class177(shardID, "Unknown");
				}
				else
				{
					result = Class177.dictionary_0[shardID];
				}
			}
			return result;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000033EB File Offset: 0x000015EB
		private Class177()
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00007D92 File Offset: 0x00005F92
		private Class177(uint shardID, string name)
		{
			this.uint_0 = shardID;
			this.string_0 = name;
			Class177.dictionary_0.Add(shardID, this);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x04000649 RID: 1609
		private static readonly Dictionary<uint, Class177> dictionary_0 = new Dictionary<uint, Class177>();

		// Token: 0x0400064A RID: 1610
		public readonly uint uint_0;

		// Token: 0x0400064B RID: 1611
		public readonly string string_0;
	}
}
