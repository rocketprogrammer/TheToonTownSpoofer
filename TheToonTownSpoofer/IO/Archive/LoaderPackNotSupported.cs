using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TheToonTownSpoofer.IO.Archive
{
	// Token: 0x02000303 RID: 771
	[Serializable]
	public sealed class LoaderPackNotSupported : Exception
	{
		// Token: 0x06001E4F RID: 7759 RVA: 0x0000B991 File Offset: 0x00009B91
		public LoaderPackNotSupported() : base("Loader packs are not supported.")
		{
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0000B99E File Offset: 0x00009B9E
		private LoaderPackNotSupported(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
