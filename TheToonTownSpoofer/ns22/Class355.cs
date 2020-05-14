using System;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x02000386 RID: 902
	internal sealed class Class355
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x0000F01A File Offset: 0x0000D21A
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000F022 File Offset: 0x0000D222
		public string AudioFile { get; private set; }

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0000F02B File Offset: 0x0000D22B
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000F033 File Offset: 0x0000D233
		public byte[] UserAudioData { get; private set; }

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000F044 File Offset: 0x0000D244
		public byte[] ToonTownAudioData { get; private set; }

		// Token: 0x0600233E RID: 9022 RVA: 0x0000F04D File Offset: 0x0000D24D
		public Class355(string audioFile, byte[] userAudioData, byte[] toonTownAudioData)
		{
			this.AudioFile = audioFile;
			this.UserAudioData = userAudioData;
			this.ToonTownAudioData = toonTownAudioData;
		}

		// Token: 0x04001037 RID: 4151
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001038 RID: 4152
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x04001039 RID: 4153
		[CompilerGenerated]
		private byte[] byte_1;
	}
}
