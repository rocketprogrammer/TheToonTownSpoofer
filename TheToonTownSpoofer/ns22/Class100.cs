using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;

namespace ns22
{
	// Token: 0x02000387 RID: 903
	internal sealed class Class100 : Class86
	{
		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x0000F06A File Offset: 0x0000D26A
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x0000F072 File Offset: 0x0000D272
		public string Panda3dPath { get; set; }

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0000F07B File Offset: 0x0000D27B
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					77,
					80,
					83
				};
			}
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000F08E File Offset: 0x0000D28E
		public Class100()
		{
			this.Panda3dPath = string.Empty;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class100(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000F0A1 File Offset: 0x0000D2A1
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Panda3dPath = reader.ReadString();
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0000F0AF File Offset: 0x0000D2AF
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.Panda3dPath);
		}

		// Token: 0x0400103A RID: 4154
		[CompilerGenerated]
		private string string_0;
	}
}
