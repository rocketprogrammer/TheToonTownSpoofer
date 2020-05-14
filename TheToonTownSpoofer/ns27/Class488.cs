using System;
using System.Collections.Generic;
using System.IO;
using ns22;

namespace ns27
{
	// Token: 0x02000490 RID: 1168
	internal sealed class Class488 : IEqualityComparer<FileSystemInfo>
	{
		// Token: 0x06002B83 RID: 11139 RVA: 0x000143D8 File Offset: 0x000125D8
		public bool Equals(FileSystemInfo x, FileSystemInfo y)
		{
			return object.ReferenceEquals(x, y) || (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null) && Class336.smethod_0(x.FullName, y.FullName));
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x0001440A File Offset: 0x0001260A
		public int GetHashCode(FileSystemInfo product)
		{
			return StringComparer.CurrentCultureIgnoreCase.GetHashCode(product.FullName);
		}
	}
}
