using System;
using System.Runtime.Serialization;

namespace TheToonTownSpoofer.IO.Compression.BZip2
{
	// Token: 0x02000324 RID: 804
	[Serializable]
	public sealed class BZip2Exception : SharpZipBaseException
	{
		// Token: 0x06001F31 RID: 7985 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
		protected BZip2Exception(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		public BZip2Exception()
		{
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public BZip2Exception(string message) : base(message)
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0000C3DD File Offset: 0x0000A5DD
		public BZip2Exception(string message, Exception exception) : base(message, exception)
		{
		}
	}
}
