using System;

namespace TSN.wyUpdate.Controls
{
	// Token: 0x02000315 RID: 789
	[Serializable]
	public sealed class FailedToInitializeException : Exception
	{
		// Token: 0x06001EC9 RID: 7881 RVA: 0x0000BF6C File Offset: 0x0000A16C
		public FailedToInitializeException() : base(FailedToInitializeException.Exception_MustInitialize)
		{
		}

		// Token: 0x04000BCF RID: 3023
		private static readonly string Exception_MustInitialize = "You must call the Initialize function before you can use any other functions.";
	}
}
