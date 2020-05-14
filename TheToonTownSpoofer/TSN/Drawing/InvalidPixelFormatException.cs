using System;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TSN.Drawing
{
	// Token: 0x020004C0 RID: 1216
	[Serializable]
	public sealed class InvalidPixelFormatException : Exception
	{
		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x00015E09 File Offset: 0x00014009
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00015E11 File Offset: 0x00014011
		public PixelFormat PixelFormat { get; private set; }

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00015E1A File Offset: 0x0001401A
		public InvalidPixelFormatException(PixelFormat pixelFormat)
		{
			this.PixelFormat = pixelFormat;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00015E29 File Offset: 0x00014029
		private InvalidPixelFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.PixelFormat = (PixelFormat)info.GetValue("PixelFormat", typeof(PixelFormat));
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00015E53 File Offset: 0x00014053
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("PixelFormat", this.PixelFormat, typeof(PixelFormat));
		}
	}
}
