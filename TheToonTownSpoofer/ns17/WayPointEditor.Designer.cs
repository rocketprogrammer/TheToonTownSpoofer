namespace ns17
{
	// Token: 0x0200025B RID: 603
	internal sealed partial class WayPointEditor : global::ns14.SaveForm
	{
		// Token: 0x060019E5 RID: 6629 RVA: 0x0000918B File Offset: 0x0000738B
		protected override void Dispose(bool disposing)
		{
			if (this.class141_0 != null)
			{
				this.class141_0.Dispose();
			}
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000760 RID: 1888
		private global::System.ComponentModel.IContainer icontainer_1;

		// Token: 0x0400077C RID: 1916
		private global::ns16.Class141 class141_0;
	}
}
