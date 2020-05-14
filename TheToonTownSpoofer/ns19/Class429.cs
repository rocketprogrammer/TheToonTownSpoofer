using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using ns23;
using ns30;

namespace ns19
{
	// Token: 0x02000414 RID: 1044
	internal sealed class Class429 : IDisposable
	{
		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x00011EEA File Offset: 0x000100EA
		// (set) Token: 0x060027A8 RID: 10152 RVA: 0x00011EF2 File Offset: 0x000100F2
		public Bitmap UserGraphicData { get; private set; }

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x00011EFB File Offset: 0x000100FB
		// (set) Token: 0x060027AA RID: 10154 RVA: 0x00011F03 File Offset: 0x00010103
		public Bitmap ToonTownGraphicData { get; private set; }

		// Token: 0x060027AB RID: 10155 RVA: 0x00011F0C File Offset: 0x0001010C
		public Class429(Bitmap userGraphicData, Bitmap toonTownGraphicData)
		{
			this.UserGraphicData = userGraphicData;
			this.ToonTownGraphicData = toonTownGraphicData;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00091F64 File Offset: 0x00090164
		public Class429(byte[] userGraphicData, byte[] toonTownGraphicData)
		{
			if (userGraphicData != null)
			{
				this.memoryStream_0 = new MemoryStream();
				userGraphicData.smethod_0(this.memoryStream_0);
				this.UserGraphicData = (Bitmap)Image.FromStream(this.memoryStream_0);
			}
			if (toonTownGraphicData != null)
			{
				this.memoryStream_1 = new MemoryStream();
				toonTownGraphicData.smethod_0(this.memoryStream_1);
				this.ToonTownGraphicData = (Bitmap)Image.FromStream(this.memoryStream_1);
			}
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00091FD8 File Offset: 0x000901D8
		public static Class429 smethod_0(byte[] userGraphicData, byte[] toonTownGraphicData)
		{
			Class429 @class = null;
			Class429 result;
			try
			{
				@class = new Class429(userGraphicData, toonTownGraphicData);
				result = @class;
			}
			catch (Exception ex)
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				ex.smethod_0();
				result = null;
			}
			return result;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00092018 File Offset: 0x00090218
		public void Dispose()
		{
			if (this.UserGraphicData != null)
			{
				this.UserGraphicData.Dispose();
			}
			if (this.ToonTownGraphicData != null)
			{
				this.ToonTownGraphicData.Dispose();
			}
			if (this.memoryStream_0 != null)
			{
				this.memoryStream_0.Dispose();
			}
			if (this.memoryStream_1 != null)
			{
				this.memoryStream_1.Dispose();
			}
		}

		// Token: 0x040013B9 RID: 5049
		private MemoryStream memoryStream_0;

		// Token: 0x040013BA RID: 5050
		private MemoryStream memoryStream_1;

		// Token: 0x040013BB RID: 5051
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x040013BC RID: 5052
		[CompilerGenerated]
		private Bitmap bitmap_1;
	}
}
