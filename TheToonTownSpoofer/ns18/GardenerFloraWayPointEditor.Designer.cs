namespace ns18
{
	// Token: 0x02000297 RID: 663
	internal sealed partial class GardenerFloraWayPointEditor : global::ns14.SaveForm
	{
		// Token: 0x06001B63 RID: 7011 RVA: 0x00009FBA File Offset: 0x000081BA
		protected override void Dispose(bool disposing)
		{
			if (this.dictionary_0 != null)
			{
				this.dictionary_0.Clear();
			}
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000906 RID: 2310
		private global::System.Collections.Generic.Dictionary<object, global::ns16.Enum85> dictionary_0;

		// Token: 0x04000907 RID: 2311
		private global::System.ComponentModel.IContainer icontainer_1;
	}
}
