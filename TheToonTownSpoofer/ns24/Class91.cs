using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns20;

namespace ns24
{
	// Token: 0x02000308 RID: 776
	internal sealed class Class91 : Class86
	{
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					65,
					67,
					83
				};
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0000B9F7 File Offset: 0x00009BF7
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0000B9FF File Offset: 0x00009BFF
		public string Username { get; set; }

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0000BA08 File Offset: 0x00009C08
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000BA10 File Offset: 0x00009C10
		public string Password { get; set; }

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0000BA19 File Offset: 0x00009C19
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0000BA21 File Offset: 0x00009C21
		public string ReferenceName { get; set; }

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0000BA2A File Offset: 0x00009C2A
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0000BA32 File Offset: 0x00009C32
		public Enum101 ToonTownAccountType { get; set; }

		// Token: 0x06001E6A RID: 7786 RVA: 0x0000BA3B File Offset: 0x00009C3B
		public Class91(string referenceName, string username, string password, Enum101 type)
		{
			this.ReferenceName = referenceName;
			this.Username = username;
			this.Password = password;
			this.ToonTownAccountType = type;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class91(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0000BA60 File Offset: 0x00009C60
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Username = reader.ReadString();
			this.Password = reader.ReadString();
			this.ReferenceName = reader.ReadString();
			this.ToonTownAccountType = (Enum101)reader.ReadInt16();
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0000BA92 File Offset: 0x00009C92
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.Username);
			writer.Write(this.Password);
			writer.Write(this.ReferenceName);
			writer.Write((short)this.ToonTownAccountType);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0000BAC5 File Offset: 0x00009CC5
		public override string ToString()
		{
			return this.ReferenceName;
		}

		// Token: 0x04000B94 RID: 2964
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000B95 RID: 2965
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000B96 RID: 2966
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000B97 RID: 2967
		[CompilerGenerated]
		private Enum101 enum101_0;
	}
}
