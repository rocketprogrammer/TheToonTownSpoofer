using System;
using System.IO;

namespace ns29
{
	// Token: 0x020004D6 RID: 1238
	internal sealed class Class524
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x000B0A28 File Offset: 0x000AEC28
		public Class524(string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				throw new ArgumentNullException("fileName");
			}
			if (fileName.Length > 3)
			{
				while (fileName[fileName.Length - 1] == Path.DirectorySeparatorChar)
				{
					fileName = fileName.Substring(0, fileName.Length - 1);
				}
			}
			this.string_0 = string.Empty;
			this.string_1 = Path.GetFullPath(fileName);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00016307 File Offset: 0x00014507
		public Class524(string displayName, string fileName) : this(fileName)
		{
			if (displayName != null)
			{
				this.string_0 = displayName;
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x0001631A File Offset: 0x0001451A
		public static bool smethod_0(Class524 a, object b)
		{
			return object.ReferenceEquals(a, b) || (a != null && b != null && a.Equals(b));
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00016336 File Offset: 0x00014536
		public static bool smethod_1(Class524 a, object b)
		{
			return !Class524.smethod_0(a, b);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000B0A98 File Offset: 0x000AEC98
		public override bool Equals(object obj)
		{
			Class524 @class = obj as Class524;
			return @class != null && string.Equals(this.string_1, @class.string_1, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00016342 File Offset: 0x00014542
		public override int GetHashCode()
		{
			return StringComparer.CurrentCultureIgnoreCase.GetHashCode(this.string_1);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00016354 File Offset: 0x00014554
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x0400183C RID: 6204
		public readonly string string_0;

		// Token: 0x0400183D RID: 6205
		public readonly string string_1;
	}
}
