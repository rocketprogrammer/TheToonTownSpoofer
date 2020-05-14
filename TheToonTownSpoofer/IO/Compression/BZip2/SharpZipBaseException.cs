using System;
using System.Runtime.Serialization;

namespace TheToonTownSpoofer.IO.Compression.BZip2
{
	// Token: 0x02000323 RID: 803
	[Serializable]
	public class SharpZipBaseException : ApplicationException
	{
		// Token: 0x06001F2D RID: 7981 RVA: 0x0000C39D File Offset: 0x0000A59D
		protected SharpZipBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0000C3A7 File Offset: 0x0000A5A7
		public SharpZipBaseException()
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0000C3AF File Offset: 0x0000A5AF
		public SharpZipBaseException(string message) : base(message)
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public SharpZipBaseException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
