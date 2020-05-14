using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns29
{
	// Token: 0x020004C7 RID: 1223
	internal sealed class Class515
	{
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x000160B0 File Offset: 0x000142B0
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x000160B8 File Offset: 0x000142B8
		public string ModelPath { get; private set; }

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x000160C1 File Offset: 0x000142C1
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x000160C9 File Offset: 0x000142C9
		public HashSet<string> ImagePaths { get; private set; }

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000160D2 File Offset: 0x000142D2
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x000160DA File Offset: 0x000142DA
		public HashSet<string> Directories { get; private set; }

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000160E3 File Offset: 0x000142E3
		public Class515(string modelpath, HashSet<string> imagePaths, HashSet<string> directories)
		{
			this.ModelPath = modelpath;
			this.ImagePaths = imagePaths;
			this.Directories = directories;
		}

		// Token: 0x04001813 RID: 6163
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04001814 RID: 6164
		[CompilerGenerated]
		private HashSet<string> hashSet_0;

		// Token: 0x04001815 RID: 6165
		[CompilerGenerated]
		private HashSet<string> hashSet_1;
	}
}
