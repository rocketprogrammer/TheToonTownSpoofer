namespace ns16
{
	// Token: 0x020003C6 RID: 966
	internal sealed partial class GardenerFloraCaptureSetup : global::ns15.CaptureSetupForm
	{
		// Token: 0x06002573 RID: 9587 RVA: 0x00010808 File Offset: 0x0000EA08
		protected override void Dispose(bool disposing)
		{
			if (this.class88_0 != null)
			{
				this.class88_0.Dispose();
			}
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x040011AD RID: 4525
		private global::ns14.Class88 class88_0;

		// Token: 0x040011AF RID: 4527
		private global::System.ComponentModel.IContainer icontainer_1;
	}
}
