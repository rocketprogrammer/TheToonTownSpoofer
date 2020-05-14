using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns22;
using ns24;
using ns28;
using ns29;
using ns31;

namespace ns20
{
	// Token: 0x0200041E RID: 1054
	internal sealed class Class108 : Class86, IDisposable
	{
		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x00012160 File Offset: 0x00010360
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x00012168 File Offset: 0x00010368
		public Class95<Struct54> PondCapture { get; set; }

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x00012171 File Offset: 0x00010371
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00012179 File Offset: 0x00010379
		public Size WindowClientSize { get; private set; }

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x00012182 File Offset: 0x00010382
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0001218A File Offset: 0x0001038A
		public PointF DockLocation { get; private set; }

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x00012193 File Offset: 0x00010393
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0001219B File Offset: 0x0001039B
		public Enum57 Playground { get; private set; }

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000121A4 File Offset: 0x000103A4
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x000121AC File Offset: 0x000103AC
		public Class150 DockReferenceCapture { get; private set; }

		// Token: 0x06002804 RID: 10244 RVA: 0x000121B5 File Offset: 0x000103B5
		public Class108(Enum57 playground, PointF dockLocation, Size windowClientSize, Class95<Struct54> pondCapture, Class150 dockReferenceCapture)
		{
			this.Playground = playground;
			this.DockLocation = dockLocation;
			this.WindowClientSize = windowClientSize;
			this.PondCapture = pondCapture;
			this.DockReferenceCapture = dockReferenceCapture;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class108(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00093D74 File Offset: 0x00091F74
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.DockLocation = reader.smethod_12();
			this.Playground = (Enum57)reader.ReadUInt16();
			this.WindowClientSize = reader.smethod_14();
			this.PondCapture = reader.smethod_2();
			if (version > 1)
			{
				this.DockReferenceCapture = reader.smethod_4();
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00093DCC File Offset: 0x00091FCC
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_13(this.DockLocation);
			writer.Write((ushort)this.Playground);
			writer.smethod_15(this.WindowClientSize);
			writer.smethod_3(this.PondCapture);
			writer.smethod_5(this.DockReferenceCapture);
			base.vmethod_0(writer);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00093E1C File Offset: 0x0009201C
		~Class108()
		{
			this.method_4(false);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000121E2 File Offset: 0x000103E2
		private void method_4(bool disposing)
		{
			if (disposing && this.DockReferenceCapture != null)
			{
				this.DockReferenceCapture.Dispose();
			}
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000121FA File Offset: 0x000103FA
		public void Dispose()
		{
			this.method_4(true);
		}

		// Token: 0x04001410 RID: 5136
		[CompilerGenerated]
		private Class95<Struct54> class95_0;

		// Token: 0x04001411 RID: 5137
		[CompilerGenerated]
		private Size size_0;

		// Token: 0x04001412 RID: 5138
		[CompilerGenerated]
		private PointF pointF_0;

		// Token: 0x04001413 RID: 5139
		[CompilerGenerated]
		private Enum57 enum57_0;

		// Token: 0x04001414 RID: 5140
		[CompilerGenerated]
		private Class150 class150_0;
	}
}
