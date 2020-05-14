using System;
using System.IO;
using ns26;
using ns27;
using TSN.IO;

namespace ns14
{
	// Token: 0x020001D8 RID: 472
	internal abstract class Class86
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00005B4C File Offset: 0x00003D4C
		protected virtual byte[] Header
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x000319D8 File Offset: 0x0002FBD8
		protected virtual int? Version
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual int MinimumVersion
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual int MaximumVersion
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000033EB File Offset: 0x000015EB
		public Class86()
		{
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00005B4F File Offset: 0x00003D4F
		public Class86(BinaryReader reader)
		{
			this.method_0(reader);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000319F0 File Offset: 0x0002FBF0
		public Class86(Stream stream)
		{
			using (Stream3 stream2 = new Stream3(stream))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream2))
				{
					this.method_0(binaryReader);
				}
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00031A4C File Offset: 0x0002FC4C
		public Class86(string fileName)
		{
			using (Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					this.method_0(binaryReader);
				}
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00031AAC File Offset: 0x0002FCAC
		private void method_0(BinaryReader reader)
		{
			byte[] header = this.Header;
			if (header != null && header != null)
			{
				byte[] array = reader.ReadBytes(header.Length);
				if (!array.smethod_9(header))
				{
					throw new InvalidFileType(header, array);
				}
			}
			if (this.Version == null)
			{
				this.vmethod_1(reader);
				return;
			}
			int num = reader.ReadInt32();
			if (num >= this.MinimumVersion && num <= this.MaximumVersion)
			{
				this.vmethod_2(reader, num);
				return;
			}
			throw new InvalidFileVersion<int>(this.MinimumVersion, this.MaximumVersion, num);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00031B30 File Offset: 0x0002FD30
		public void method_1(string fileName)
		{
			using (Stream stream = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(stream))
				{
					this.method_3(binaryWriter);
				}
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00031B8C File Offset: 0x0002FD8C
		public void method_2(Stream stream)
		{
			using (Stream3 stream2 = new Stream3(stream))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(stream2))
				{
					this.method_3(binaryWriter);
				}
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00031BE4 File Offset: 0x0002FDE4
		public void method_3(BinaryWriter writer)
		{
			byte[] header = this.Header;
			if (header != null && header != null)
			{
				writer.Write(header);
			}
			int? version = this.Version;
			if (version != null)
			{
				writer.Write(version.Value);
			}
			this.vmethod_0(writer);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_0(BinaryWriter writer)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_1(BinaryReader reader)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_2(BinaryReader reader, int version)
		{
		}
	}
}
