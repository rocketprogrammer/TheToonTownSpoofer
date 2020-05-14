using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns17;
using ns20;

namespace ns19
{
	// Token: 0x020003EE RID: 1006
	internal sealed class Class103 : Class86, IDisposable
	{
		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x000110EB File Offset: 0x0000F2EB
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					74,
					70,
					68,
					83
				};
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000110FE File Offset: 0x0000F2FE
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x00011106 File Offset: 0x0000F306
		public List<Class108> Docks { get; private set; }

		// Token: 0x0600266F RID: 9839 RVA: 0x0001110F File Offset: 0x0000F30F
		public Class103()
		{
			this.Docks = new List<Class108>();
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class103(string filePath) : base(filePath)
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0008905C File Offset: 0x0008725C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Docks = new List<Class108>();
			int num = reader.ReadInt32();
			if (version > 1)
			{
				for (int i = 0; i < num; i++)
				{
					Class108 @class = new Class108(reader);
					if (@class.PondCapture != null)
					{
						this.Docks.Add(@class);
					}
					else
					{
						@class.Dispose();
					}
				}
			}
			else
			{
				for (int j = 0; j < num; j++)
				{
					Class108 class2 = new Class108(reader);
					class2.Dispose();
				}
				DialogBox.smethod_3(Class103.string_0, string.Format(Class103.string_1, num));
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000890F0 File Offset: 0x000872F0
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.Docks.Count);
			foreach (Class108 @class in this.Docks)
			{
				if (@class.PondCapture != null)
				{
					@class.method_3(writer);
				}
			}
			base.vmethod_0(writer);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00089164 File Offset: 0x00087364
		~Class103()
		{
			this.method_4(false);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00089194 File Offset: 0x00087394
		private void method_4(bool disposing)
		{
			if (disposing)
			{
				foreach (Class108 @class in this.Docks)
				{
					@class.Dispose();
				}
				this.Docks.Clear();
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00011122 File Offset: 0x0000F322
		public void Dispose()
		{
			this.method_4(true);
		}

		// Token: 0x040012CC RID: 4812
		private static readonly string string_0 = "Due to changes that allow easier dock recognition, existing Joe Fish Dock Settings are no longer valid and must be setup again.\nPlease accept our apologies for any inconvenience!";

		// Token: 0x040012CD RID: 4813
		private static readonly string string_1 = "{0} Joe Fish Dock Setups Removed";

		// Token: 0x040012CE RID: 4814
		[CompilerGenerated]
		private List<Class108> list_0;
	}
}
