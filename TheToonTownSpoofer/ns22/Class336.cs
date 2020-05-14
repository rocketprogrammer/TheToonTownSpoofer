using System;
using System.IO;

namespace ns22
{
	// Token: 0x02000369 RID: 873
	internal static class Class336
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x0007459C File Offset: 0x0007279C
		public static bool smethod_0(string file1, string file2)
		{
			if (string.IsNullOrEmpty(file1))
			{
				throw new ArgumentNullException("file1");
			}
			if (string.IsNullOrEmpty(file2))
			{
				throw new ArgumentNullException("file2");
			}
			if (file1.Length > 3)
			{
				while (file1[file1.Length - 1] == Path.DirectorySeparatorChar)
				{
					file1 = file1.Substring(0, file1.Length - 1);
				}
			}
			if (file2.Length > 3)
			{
				while (file2[file2.Length - 1] == Path.DirectorySeparatorChar)
				{
					file2 = file2.Substring(0, file2.Length - 1);
				}
			}
			file1 = Path.GetFullPath(file1);
			file2 = Path.GetFullPath(file2);
			return string.Equals(file1, file2, StringComparison.OrdinalIgnoreCase);
		}
	}
}
