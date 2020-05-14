using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TSN.IO
{
	// Token: 0x020003A0 RID: 928
	[Serializable]
	public sealed class InvalidFileVersion<T> : IOException
	{
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0000F77A File Offset: 0x0000D97A
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000F782 File Offset: 0x0000D982
		public T MinimumVersion { get; private set; }

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0000F78B File Offset: 0x0000D98B
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000F793 File Offset: 0x0000D993
		public T MaximumVersion { get; private set; }

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0000F79C File Offset: 0x0000D99C
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		public T ActualVersion { get; private set; }

		// Token: 0x06002405 RID: 9221 RVA: 0x0000F7AD File Offset: 0x0000D9AD
		public InvalidFileVersion(T minimumVersion, T maximumVersion, T actualVersion) : base(InvalidFileVersion<T>.smethod_0(minimumVersion, maximumVersion, actualVersion))
		{
			this.MinimumVersion = minimumVersion;
			this.MaximumVersion = maximumVersion;
			this.ActualVersion = actualVersion;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0000F7D2 File Offset: 0x0000D9D2
		private static string smethod_0(T minimumVersion, T maximumVersion, T actualVersion)
		{
			return string.Format("The file version is out of the range of possible versions. Minimum version: '{0}' Maximum version: '{1}' Actual version: '{2}'.", minimumVersion, maximumVersion, actualVersion);
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0007A164 File Offset: 0x00078364
		private InvalidFileVersion(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ActualVersion = (T)((object)info.GetValue("ActualVersion", typeof(T)));
			this.MinimumVersion = (T)((object)info.GetValue("MinimumVersion", typeof(T)));
			this.MaximumVersion = (T)((object)info.GetValue("MaximumVersion", typeof(T)));
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0007A1DC File Offset: 0x000783DC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ActualVersion", this.ActualVersion, typeof(T));
			info.AddValue("MinimumVersion", this.MinimumVersion, typeof(T));
			info.AddValue("MaximumVersion", this.MaximumVersion, typeof(T));
			base.GetObjectData(info, context);
		}
	}
}
