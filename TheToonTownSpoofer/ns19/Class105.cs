using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns23;
using ns26;
using ns29;

namespace ns19
{
	// Token: 0x020003F0 RID: 1008
	internal sealed class Class105 : Class104
	{
		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x000111EE File Offset: 0x0000F3EE
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					71,
					70,
					83
				};
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00011201 File Offset: 0x0000F401
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x00011209 File Offset: 0x0000F409
		public Class114 GardenerFloraFiles { get; private set; }

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00011212 File Offset: 0x0000F412
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0001121A File Offset: 0x0000F41A
		public Class114 GardenerFloraCaptureFiles { get; private set; }

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x00011223 File Offset: 0x0000F423
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x0001122B File Offset: 0x0000F42B
		public string CustomCaptureFile { get; set; }

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x00011234 File Offset: 0x0000F434
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0001123C File Offset: 0x0000F43C
		public string CustomWayPointSettings { get; set; }

		// Token: 0x06002692 RID: 9874 RVA: 0x00011245 File Offset: 0x0000F445
		public Class105()
		{
			this.GardenerFloraFiles = new Class114();
			this.GardenerFloraCaptureFiles = new Class114();
			base.MaxColorRange = Class105.int_5;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0001126E File Offset: 0x0000F46E
		public Class105(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0008929C File Offset: 0x0008749C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.GardenerFloraFiles = new Class114(reader);
			this.GardenerFloraCaptureFiles = new Class114(reader);
			if (reader.ReadBoolean())
			{
				this.CustomCaptureFile = reader.ReadString();
			}
			if (reader.ReadBoolean())
			{
				this.CustomWayPointSettings = reader.ReadString();
			}
			base.vmethod_2(reader, version);
			if (version == 1)
			{
				if (base.MaxColorRange == Class105.int_6)
				{
					base.MaxColorRange = Class105.int_5;
				}
				Class524[] array = this.GardenerFloraFiles.Files.ToArray();
				Class524[] array2 = array;
				int i = 0;
				while (i < array2.Length)
				{
					Class524 @class = array2[i];
					bool flag = false;
					try
					{
						using (Stream stream = File.Open(@class.string_1, FileMode.Open, FileAccess.Read, FileShare.None))
						{
							using (BinaryReader binaryReader = new BinaryReader(stream))
							{
								byte[] enumeration = binaryReader.ReadBytes(Class88.byte_0.Length);
								flag = enumeration.smethod_9(Class88.byte_0);
							}
						}
						goto IL_14B;
					}
					catch (Exception ex)
					{
						ex.smethod_1(new object[]
						{
							@class.string_1
						});
						flag = true;
						goto IL_14B;
					}
					goto Block_7;
					IL_140:
					i++;
					continue;
					Block_7:
					try
					{
						IL_102:
						File.Delete(@class.string_1);
						this.GardenerFloraFiles.Files.Remove(@class);
					}
					catch (Exception ex2)
					{
						ex2.smethod_1(new object[]
						{
							@class.string_1
						});
					}
					goto IL_140;
					IL_14B:
					if (flag)
					{
						goto IL_102;
					}
					goto IL_140;
				}
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00089430 File Offset: 0x00087630
		protected override void vmethod_0(BinaryWriter writer)
		{
			this.GardenerFloraFiles.method_3(writer);
			this.GardenerFloraCaptureFiles.method_3(writer);
			if (string.IsNullOrEmpty(this.CustomCaptureFile))
			{
				writer.Write(false);
			}
			else
			{
				writer.Write(true);
				writer.Write(this.CustomCaptureFile);
			}
			if (string.IsNullOrEmpty(this.CustomWayPointSettings))
			{
				writer.Write(false);
			}
			else
			{
				writer.Write(true);
				writer.Write(this.CustomWayPointSettings);
			}
			base.vmethod_0(writer);
		}

		// Token: 0x040012D8 RID: 4824
		public static readonly int int_5 = 25;

		// Token: 0x040012D9 RID: 4825
		public static readonly int int_6 = 10;

		// Token: 0x040012DA RID: 4826
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040012DB RID: 4827
		[CompilerGenerated]
		private Class114 class114_1;

		// Token: 0x040012DC RID: 4828
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040012DD RID: 4829
		[CompilerGenerated]
		private string string_1;
	}
}
