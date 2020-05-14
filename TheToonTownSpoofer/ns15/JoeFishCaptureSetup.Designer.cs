namespace ns15
{
	// Token: 0x02000214 RID: 532
	internal sealed partial class JoeFishCaptureSetup : global::ns15.CaptureSetupForm
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x00007090 File Offset: 0x00005290
		protected override void Dispose(bool disposing)
		{
			if (this.class98_0 != null)
			{
				this.class98_0.Dispose();
			}
			this.class141_0.Dispose();
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000523 RID: 1315
		private global::System.ComponentModel.IContainer icontainer_1;

		// Token: 0x0400056A RID: 1386
		private global::ns25.Class98 class98_0;
	}
}
