namespace ns20
{
	// Token: 0x0200043B RID: 1083
	internal sealed partial class JoeFishRunning : global::ns15.RunBaseForm
	{
		// Token: 0x0600293D RID: 10557 RVA: 0x00012FE3 File Offset: 0x000111E3
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.task_0 != null)
				{
					this.task_0.Dispose();
				}
				if (this.icontainer_1 != null)
				{
					this.icontainer_1.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04001539 RID: 5433
		private global::System.Threading.Tasks.Task task_0;

		// Token: 0x0400153A RID: 5434
		private global::System.ComponentModel.IContainer icontainer_1;
	}
}
