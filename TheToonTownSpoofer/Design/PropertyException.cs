using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TheToonTownSpoofer.Design
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public sealed class PropertyException : Exception
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x00013771 File Offset: 0x00011971
		public PropertyException(string message) : base(message)
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0000B99E File Offset: 0x00009B9E
		private PropertyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
