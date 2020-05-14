using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ns14;
using ns19;
using ns22;
using ns31;

namespace ns16
{
	// Token: 0x020003AD RID: 941
	internal sealed class Class101 : Class86
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x0000FE1D File Offset: 0x0000E01D
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					87,
					80,
					83
				};
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0000FE30 File Offset: 0x0000E030
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0000FE38 File Offset: 0x0000E038
		public Dictionary<Enum57, Dictionary<PointF, Enum99>> WayPoints { get; private set; }

		// Token: 0x06002493 RID: 9363 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class101(string filePath) : base(filePath)
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0000FE41 File Offset: 0x0000E041
		public Class101()
		{
			this.WayPoints = new Dictionary<Enum57, Dictionary<PointF, Enum99>>();
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class101(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0007C1A4 File Offset: 0x0007A3A4
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.WayPoints = new Dictionary<Enum57, Dictionary<PointF, Enum99>>();
			ushort num = reader.ReadUInt16();
			for (int i = 0; i < (int)num; i++)
			{
				Enum57 key = (Enum57)reader.ReadUInt16();
				Dictionary<PointF, Enum99> dictionary = new Dictionary<PointF, Enum99>();
				ushort num2 = reader.ReadUInt16();
				for (ushort num3 = 0; num3 < num2; num3 += 1)
				{
					PointF key2 = reader.smethod_12();
					Enum99 value = (Enum99)reader.ReadUInt16();
					if (!dictionary.ContainsKey(key2))
					{
						dictionary.Add(key2, value);
					}
				}
				if (!this.WayPoints.ContainsKey(key))
				{
					this.WayPoints.Add(key, dictionary);
				}
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0007C240 File Offset: 0x0007A440
		protected override void vmethod_0(BinaryWriter writer)
		{
			IEnumerable<KeyValuePair<Enum57, Dictionary<PointF, Enum99>>> wayPoints = this.WayPoints;
			if (Class101.func_0 == null)
			{
				Class101.func_0 = new Func<KeyValuePair<Enum57, Dictionary<PointF, Enum99>>, bool>(Class101.smethod_0);
			}
			IEnumerable<KeyValuePair<Enum57, Dictionary<PointF, Enum99>>> enumerable = wayPoints.Where(Class101.func_0);
			writer.Write((ushort)enumerable.Count<KeyValuePair<Enum57, Dictionary<PointF, Enum99>>>());
			foreach (KeyValuePair<Enum57, Dictionary<PointF, Enum99>> keyValuePair in enumerable)
			{
				writer.Write((ushort)keyValuePair.Key);
				writer.Write((ushort)keyValuePair.Value.Count);
				foreach (KeyValuePair<PointF, Enum99> keyValuePair2 in keyValuePair.Value)
				{
					writer.smethod_13(keyValuePair2.Key);
					writer.Write((ushort)keyValuePair2.Value);
				}
			}
			base.vmethod_0(writer);
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0000FE54 File Offset: 0x0000E054
		[CompilerGenerated]
		private static bool smethod_0(KeyValuePair<Enum57, Dictionary<PointF, Enum99>> item)
		{
			return item.Value.Count != 0;
		}

		// Token: 0x040010F6 RID: 4342
		[CompilerGenerated]
		private Dictionary<Enum57, Dictionary<PointF, Enum99>> dictionary_0;

		// Token: 0x040010F7 RID: 4343
		[CompilerGenerated]
		private static Func<KeyValuePair<Enum57, Dictionary<PointF, Enum99>>, bool> func_0;
	}
}
