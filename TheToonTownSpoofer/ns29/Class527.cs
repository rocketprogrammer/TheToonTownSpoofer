using System;
using System.IO;
using ns22;
using ns23;
using ns30;

namespace ns29
{
	// Token: 0x020004DA RID: 1242
	internal static class Class527
	{
		// Token: 0x06002E2D RID: 11821 RVA: 0x000B0CD8 File Offset: 0x000AEED8
		public static void smethod_0(this Class338 mfd, string path)
		{
			string directoryName = Path.GetDirectoryName(path);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName, Class363.GetDirectorySecurity);
			}
			using (Stream stream = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				mfd.Data.smethod_0(stream);
			}
		}
	}
}
