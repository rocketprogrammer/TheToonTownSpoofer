using System;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x02000337 RID: 823
	internal struct Struct27
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public string Key { get; private set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0000CEC5 File Offset: 0x0000B0C5
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public string Value { get; private set; }

		// Token: 0x06002001 RID: 8193 RVA: 0x0000CED6 File Offset: 0x0000B0D6
		public Struct27(string key, string value)
		{
			this = default(Struct27);
			if (key == null)
			{
				key = string.Empty;
			}
			if (value == null)
			{
				value = string.Empty;
			}
			this.Key = key;
			this.Value = value;
		}

		// Token: 0x04000C75 RID: 3189
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000C76 RID: 3190
		[CompilerGenerated]
		private string string_1;
	}
}
