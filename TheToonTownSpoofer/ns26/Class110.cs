using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns15;
using ns17;
using ns18;
using ns19;
using ns22;
using ns23;
using ns25;
using ns27;
using ns29;
using ns31;

namespace ns26
{
	// Token: 0x02000474 RID: 1140
	internal sealed class Class110 : Class86
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x00013BBA File Offset: 0x00011DBA
		public static Class110 Instance
		{
			[DebuggerStepThrough]
			get
			{
				return Class110.lazy_0.Value;
			}
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000A4234 File Offset: 0x000A2434
		private static Class110 smethod_0()
		{
			if (File.Exists(Class291.string_15))
			{
				Class110 result;
				try
				{
					using (Stream stream = File.Open(Class291.string_15, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							Class470.smethod_1(Class110.string_0, stream, memoryStream);
							memoryStream.Position = 0L;
							result = new Class110(memoryStream);
						}
					}
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						Class291.string_15
					});
					DialogBox.smethod_7(ex, Class291.string_15);
					goto IL_81;
				}
				return result;
			}
			IL_81:
			return new Class110();
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000A42F0 File Offset: 0x000A24F0
		public static bool smethod_1()
		{
			bool result;
			lock (Class110.object_0)
			{
				try
				{
					string text = Path.Combine(Class291.CommonApplicationDataDirectory, Guid.NewGuid().ToString() + ".tmp");
					using (MemoryStream memoryStream = new MemoryStream())
					{
						Class110.Instance.method_2(memoryStream);
						memoryStream.Position = 0L;
						using (Stream stream = File.Open(text, FileMode.Create, FileAccess.Write, FileShare.None))
						{
							Class470.smethod_0(Class110.string_0, memoryStream, stream);
						}
					}
					Class234.smethod_14(text, Class291.string_15, true);
					result = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						Class291.string_15
					});
					DialogBox.smethod_7(ex, Class291.string_15);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x00013BC6 File Offset: 0x00011DC6
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					77,
					83,
					70
				};
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x00013BD9 File Offset: 0x00011DD9
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00013BE1 File Offset: 0x00011DE1
		public Class114 RaceTrackFileIndex { get; private set; }

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x00013BEA File Offset: 0x00011DEA
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00013BF2 File Offset: 0x00011DF2
		public Class89 GagAMaticSettings { get; private set; }

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x00013BFB File Offset: 0x00011DFB
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00013C03 File Offset: 0x00011E03
		public Class100 MakePackageSettings { get; private set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x00013C0C File Offset: 0x00011E0C
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00013C14 File Offset: 0x00011E14
		public Class97 RemoteControllerSettings { get; private set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x00013C1D File Offset: 0x00011E1D
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x00013C25 File Offset: 0x00011E25
		public Class99 ConnectSettings { get; private set; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x00013C2E File Offset: 0x00011E2E
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00013C36 File Offset: 0x00011E36
		public Class106 JoeFishSettings { get; private set; }

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x00013C3F File Offset: 0x00011E3F
		// (set) Token: 0x06002A7F RID: 10879 RVA: 0x00013C47 File Offset: 0x00011E47
		public Class105 GardenerFloraSettings { get; private set; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x00013C50 File Offset: 0x00011E50
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x00013C58 File Offset: 0x00011E58
		public Class112 ApplicationSettings { get; private set; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x00013C61 File Offset: 0x00011E61
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x00013C69 File Offset: 0x00011E69
		public Class111 MyGallerySettings { get; private set; }

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x00013C72 File Offset: 0x00011E72
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x00013C7A File Offset: 0x00011E7A
		public Class114 CreatedFileArchive { get; private set; }

		// Token: 0x06002A86 RID: 10886 RVA: 0x000A4404 File Offset: 0x000A2604
		private Class110()
		{
			this.ConnectSettings = new Class99();
			this.MakePackageSettings = new Class100();
			this.GagAMaticSettings = new Class89();
			this.RemoteControllerSettings = new Class97();
			this.RaceTrackFileIndex = new Class114();
			this.JoeFishSettings = new Class106();
			this.GardenerFloraSettings = new Class105();
			this.ApplicationSettings = new Class112();
			this.MyGallerySettings = new Class111();
			this.CreatedFileArchive = new Class114();
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00013C83 File Offset: 0x00011E83
		private Class110(Stream stream) : base(stream)
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000A4488 File Offset: 0x000A2688
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.ApplicationSettings = new Class112(reader);
			this.ConnectSettings = new Class99(reader);
			this.MakePackageSettings = new Class100(reader);
			this.GagAMaticSettings = new Class89(reader);
			this.RemoteControllerSettings = new Class97(reader);
			this.RaceTrackFileIndex = new Class114(reader);
			this.JoeFishSettings = new Class106(reader);
			this.GardenerFloraSettings = new Class105(reader);
			this.CreatedFileArchive = new Class114(reader);
			this.MyGallerySettings = new Class111(reader);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000A4510 File Offset: 0x000A2710
		protected override void vmethod_0(BinaryWriter writer)
		{
			this.ApplicationSettings.method_3(writer);
			this.ConnectSettings.method_3(writer);
			this.MakePackageSettings.method_3(writer);
			this.GagAMaticSettings.method_3(writer);
			this.RemoteControllerSettings.method_3(writer);
			this.RaceTrackFileIndex.method_3(writer);
			this.JoeFishSettings.method_3(writer);
			this.GardenerFloraSettings.method_3(writer);
			this.CreatedFileArchive.method_3(writer);
			this.MyGallerySettings.method_3(writer);
		}

		// Token: 0x04001669 RID: 5737
		private static readonly string string_0 = "h1;KsBgn.{37v1Nc";

		// Token: 0x0400166A RID: 5738
		private static readonly Lazy<Class110> lazy_0 = new Lazy<Class110>(new Func<Class110>(Class110.smethod_0));

		// Token: 0x0400166B RID: 5739
		private static readonly object object_0 = new object();

		// Token: 0x0400166C RID: 5740
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x0400166D RID: 5741
		[CompilerGenerated]
		private Class89 class89_0;

		// Token: 0x0400166E RID: 5742
		[CompilerGenerated]
		private Class100 class100_0;

		// Token: 0x0400166F RID: 5743
		[CompilerGenerated]
		private Class97 class97_0;

		// Token: 0x04001670 RID: 5744
		[CompilerGenerated]
		private Class99 class99_0;

		// Token: 0x04001671 RID: 5745
		[CompilerGenerated]
		private Class106 class106_0;

		// Token: 0x04001672 RID: 5746
		[CompilerGenerated]
		private Class105 class105_0;

		// Token: 0x04001673 RID: 5747
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04001674 RID: 5748
		[CompilerGenerated]
		private Class111 class111_0;

		// Token: 0x04001675 RID: 5749
		[CompilerGenerated]
		private Class114 class114_1;
	}
}
