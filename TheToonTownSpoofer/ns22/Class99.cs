using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns16;
using ns20;
using ns24;
using ns26;

namespace ns22
{
	// Token: 0x02000352 RID: 850
	internal sealed class Class99 : Class86
	{
		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		protected override int? Version
		{
			get
			{
				return new int?(3);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		protected override int MaximumVersion
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0000D8DB File Offset: 0x0000BADB
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					68,
					67,
					83
				};
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0000D8EE File Offset: 0x0000BAEE
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x0000D8F6 File Offset: 0x0000BAF6
		public bool SpoofedToonTownEnabled { get; set; }

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0000D8FF File Offset: 0x0000BAFF
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0000D907 File Offset: 0x0000BB07
		public Enum106 NewsType { get; set; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0000D910 File Offset: 0x0000BB10
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x0000D918 File Offset: 0x0000BB18
		public List<Class102> ContentPacks { get; private set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0000D921 File Offset: 0x0000BB21
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0000D929 File Offset: 0x0000BB29
		public List<Class91> ToonTownAccounts { get; private set; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0000D932 File Offset: 0x0000BB32
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0000D93A File Offset: 0x0000BB3A
		public Class96 ActualToonTownVersionData { get; private set; }

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0000D943 File Offset: 0x0000BB43
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0000D94B File Offset: 0x0000BB4B
		public Class96 SpoofedToonTownVersionData { get; private set; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0000D954 File Offset: 0x0000BB54
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x0000D95C File Offset: 0x0000BB5C
		public Class96 ActualTestToonTownVersionData { get; set; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x0000D965 File Offset: 0x0000BB65
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x0000D96D File Offset: 0x0000BB6D
		public Class145 PatchServer { get; private set; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0000D976 File Offset: 0x0000BB76
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x0006FA90 File Offset: 0x0006DC90
		public int PatchServerPort
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (this.int_0 == value)
				{
					return;
				}
				if (this.PatchServer != null)
				{
					if (this.PatchServer.Running)
					{
						this.PatchServer.method_6();
					}
					this.PatchServer.Dispose();
				}
				this.int_0 = value;
				this.PatchServer = new Class145(this.int_0, this.SpoofedToonTownVersionData);
				if (this.SpoofedToonTownEnabled)
				{
					this.PatchServer.method_5();
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0000D97E File Offset: 0x0000BB7E
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0000D986 File Offset: 0x0000BB86
		public Enum101 SelectedServer { get; set; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0000D98F File Offset: 0x0000BB8F
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0000D997 File Offset: 0x0000BB97
		public int MaximumSimultaneousDownloads { get; set; }

		// Token: 0x06002144 RID: 8516 RVA: 0x0006FB04 File Offset: 0x0006DD04
		public Class99()
		{
			this.ActualToonTownVersionData = new Class96();
			this.ActualTestToonTownVersionData = new Class96();
			this.SpoofedToonTownVersionData = new Class96();
			this.SpoofedToonTownEnabled = false;
			this.ToonTownAccounts = new List<Class91>();
			this.ContentPacks = new List<Class102>();
			this.NewsType = Enum106.const_0;
			this.PatchServerPort = 3000;
			this.SelectedServer = Enum101.const_1;
			this.MaximumSimultaneousDownloads = 3;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class99(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0006FB78 File Offset: 0x0006DD78
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.ToonTownAccounts = new List<Class91>();
			this.ContentPacks = new List<Class102>();
			this.ActualToonTownVersionData = reader.smethod_9();
			this.SpoofedToonTownVersionData = reader.smethod_9();
			this.ActualTestToonTownVersionData = reader.smethod_9();
			this.SpoofedToonTownEnabled = reader.ReadBoolean();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				this.ToonTownAccounts.Add(new Class91(reader));
			}
			num = reader.ReadInt32();
			for (int j = 0; j < num; j++)
			{
				this.ContentPacks.Add(new Class102(reader));
			}
			this.NewsType = (Enum106)reader.ReadInt16();
			this.PatchServerPort = reader.ReadInt32();
			if (version > 1)
			{
				this.SelectedServer = (Enum101)reader.ReadByte();
			}
			else
			{
				this.SelectedServer = Enum101.const_1;
			}
			if (version > 2)
			{
				this.MaximumSimultaneousDownloads = reader.ReadInt32();
				return;
			}
			this.MaximumSimultaneousDownloads = 3;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0006FC5C File Offset: 0x0006DE5C
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_8(this.ActualToonTownVersionData);
			writer.smethod_8(this.SpoofedToonTownVersionData);
			writer.smethod_8(this.ActualTestToonTownVersionData);
			writer.Write(this.SpoofedToonTownEnabled);
			writer.Write(this.ToonTownAccounts.Count);
			foreach (Class91 @class in this.ToonTownAccounts)
			{
				@class.method_3(writer);
			}
			writer.Write(this.ContentPacks.Count);
			foreach (Class102 class2 in this.ContentPacks)
			{
				class2.method_3(writer);
			}
			writer.Write((short)this.NewsType);
			writer.Write(this.PatchServerPort);
			writer.Write((byte)this.SelectedServer);
			writer.Write(this.MaximumSimultaneousDownloads);
		}

		// Token: 0x04000D9D RID: 3485
		private int int_0;

		// Token: 0x04000D9E RID: 3486
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000D9F RID: 3487
		[CompilerGenerated]
		private Enum106 enum106_0;

		// Token: 0x04000DA0 RID: 3488
		[CompilerGenerated]
		private List<Class102> list_0;

		// Token: 0x04000DA1 RID: 3489
		[CompilerGenerated]
		private List<Class91> list_1;

		// Token: 0x04000DA2 RID: 3490
		[CompilerGenerated]
		private Class96 class96_0;

		// Token: 0x04000DA3 RID: 3491
		[CompilerGenerated]
		private Class96 class96_1;

		// Token: 0x04000DA4 RID: 3492
		[CompilerGenerated]
		private Class96 class96_2;

		// Token: 0x04000DA5 RID: 3493
		[CompilerGenerated]
		private Class145 class145_0;

		// Token: 0x04000DA6 RID: 3494
		[CompilerGenerated]
		private Enum101 enum101_0;

		// Token: 0x04000DA7 RID: 3495
		[CompilerGenerated]
		private int int_1;
	}
}
