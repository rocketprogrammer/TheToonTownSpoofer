namespace ns15
{
	// Token: 0x02000215 RID: 533
	internal sealed partial class GardenerFlora : global::ns14.SaveForm
	{
		// Token: 0x06001746 RID: 5958 RVA: 0x0003B168 File Offset: 0x00039368
		protected override void Dispose(bool disposing)
		{
			if (this.class141_0 != null)
			{
				this.class141_0.Dispose();
			}
			if (this.class88_0 != null)
			{
				this.class88_0.Dispose();
			}
			if (disposing)
			{
				if (this.houseColorDisplay_0 != null)
				{
					this.houseColorDisplay_0.Dispose();
				}
				if (this.class359_0 != null)
				{
					this.class359_0.Dispose();
				}
				if (this.icontainer_1 != null)
				{
					this.icontainer_1.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0400056C RID: 1388
		private global::System.ComponentModel.IContainer icontainer_1;

		// Token: 0x04000598 RID: 1432
		private global::ns16.Class141 class141_0;

		// Token: 0x0400059A RID: 1434
		private global::ns14.Class88 class88_0;

		// Token: 0x0400059B RID: 1435
		private global::ns30.HouseColorDisplay houseColorDisplay_0;

		// Token: 0x0400059C RID: 1436
		private global::ns23.Class359 class359_0;
	}
}
