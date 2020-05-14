using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;

namespace ns29
{
	// Token: 0x020004D7 RID: 1239
	internal sealed class Class114 : Class86, IEnumerable<Class524>, IEnumerable
	{
		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x0001635C File Offset: 0x0001455C
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					70,
					73,
					83
				};
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0001636F File Offset: 0x0001456F
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x00016377 File Offset: 0x00014577
		public List<Class524> Files { get; private set; }

		// Token: 0x06002E21 RID: 11809 RVA: 0x00016380 File Offset: 0x00014580
		public Class114()
		{
			this.Files = new List<Class524>();
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class114(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000B0AC4 File Offset: 0x000AECC4
		public void method_4(string filePath)
		{
			Class524 item = new Class524(filePath);
			if (!this.Files.Contains(item))
			{
				this.Files.Add(item);
			}
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000B0AF4 File Offset: 0x000AECF4
		public void method_5(string filePath)
		{
			Class524 item = new Class524(filePath);
			if (this.Files.Contains(item))
			{
				this.Files.Remove(item);
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000B0B24 File Offset: 0x000AED24
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Files = new List<Class524>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				string displayName = reader.ReadString();
				string text = reader.ReadString();
				if (File.Exists(text))
				{
					this.Files.Add(new Class524(displayName, text));
				}
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000B0B78 File Offset: 0x000AED78
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.Files.Count);
			foreach (Class524 @class in this.Files)
			{
				writer.Write(@class.string_0);
				writer.Write(@class.string_1);
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00016393 File Offset: 0x00014593
		public IEnumerator<Class524> GetEnumerator()
		{
			return this.Files.GetEnumerator();
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000163A5 File Offset: 0x000145A5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400183E RID: 6206
		[CompilerGenerated]
		private List<Class524> list_0;
	}
}
