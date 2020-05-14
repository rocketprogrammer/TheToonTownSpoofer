using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using ns30;

namespace ns16
{
	// Token: 0x020003BE RID: 958
	internal sealed class Class140 : Class123
	{
		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x00010270 File Offset: 0x0000E470
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00010278 File Offset: 0x0000E478
		public string FileName { get; private set; }

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x00010281 File Offset: 0x0000E481
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x00010289 File Offset: 0x0000E489
		public DateTime DateCreated { get; private set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x00010292 File Offset: 0x0000E492
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x0001029A File Offset: 0x0000E49A
		public string FilePath { get; private set; }

		// Token: 0x06002505 RID: 9477 RVA: 0x000102A3 File Offset: 0x0000E4A3
		public Class140(string fileName, string filePath, DateTime dateCreated)
		{
			this.FileName = fileName;
			this.DateCreated = dateCreated;
			this.FilePath = filePath;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000102C0 File Offset: 0x0000E4C0
		protected override void vmethod_0()
		{
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
			}
			this.bitmap_0 = null;
			base.vmethod_0();
		}

		// Token: 0x0400114D RID: 4429
		public Bitmap bitmap_0;

		// Token: 0x0400114E RID: 4430
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400114F RID: 4431
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04001150 RID: 4432
		[CompilerGenerated]
		private string string_1;
	}
}
