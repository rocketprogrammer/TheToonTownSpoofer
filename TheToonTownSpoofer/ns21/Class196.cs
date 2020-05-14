using System;

namespace ns21
{
	// Token: 0x02000256 RID: 598
	internal sealed class Class196 : ICustomFormatter, IFormatProvider
	{
		// Token: 0x060019C1 RID: 6593 RVA: 0x00008FEF File Offset: 0x000071EF
		object IFormatProvider.GetFormat(Type formatType)
		{
			if (formatType == typeof(ICustomFormatter))
			{
				return this;
			}
			return null;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0004760C File Offset: 0x0004580C
		string ICustomFormatter.Format(string format, object arg, IFormatProvider formatProvider)
		{
			long num;
			if (arg is long)
			{
				num = (long)arg;
			}
			else
			{
				if (!(arg is int))
				{
					throw new NotSupportedException(string.Format("Cannot format invalid type: '{0}'.", arg.GetType().FullName));
				}
				num = (long)((int)arg);
			}
			if ((double)num > Class196.double_3)
			{
				return Math.Round((double)num / Class196.double_3, 2, MidpointRounding.AwayFromZero).ToString() + " GB";
			}
			if ((double)num > Class196.double_2)
			{
				return Math.Round((double)num / Class196.double_2, 2, MidpointRounding.AwayFromZero).ToString() + " MB";
			}
			if ((double)num > Class196.double_1)
			{
				return Math.Round((double)num / Class196.double_1, 2, MidpointRounding.AwayFromZero).ToString() + " KB";
			}
			return Math.Round((double)num / Class196.double_0, 2, MidpointRounding.AwayFromZero).ToString() + " B";
		}

		// Token: 0x0400074B RID: 1867
		private static readonly double double_0 = 1.0;

		// Token: 0x0400074C RID: 1868
		private static readonly double double_1 = 1024.0 * Class196.double_0;

		// Token: 0x0400074D RID: 1869
		private static readonly double double_2 = 1024.0 * Class196.double_1;

		// Token: 0x0400074E RID: 1870
		private static readonly double double_3 = 1024.0 * Class196.double_2;
	}
}
