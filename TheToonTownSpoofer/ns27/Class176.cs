using System;
using System.Runtime.CompilerServices;
using ns15;
using ns28;
using ns31;

namespace ns27
{
	// Token: 0x02000486 RID: 1158
	internal sealed class Class176 : Class175
	{
		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000141BF File Offset: 0x000123BF
		public static Class176 Instance
		{
			get
			{
				return Class176.lazy_0.Value;
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000141CB File Offset: 0x000123CB
		private Class176(string autoUpdateID) : base(autoUpdateID, Class291.string_16)
		{
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000141D9 File Offset: 0x000123D9
		// Note: this type is marked as 'beforefieldinit'.
		static Class176()
		{
			if (Class176.func_0 == null)
			{
				Class176.func_0 = new Func<Class176>(Class176.smethod_0);
			}
			Class176.lazy_0 = new Lazy<Class176>(Class176.func_0);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00014202 File Offset: 0x00012402
		[CompilerGenerated]
		private static Class176 smethod_0()
		{
			return new Class176(Class500.Current.Guid.ToString());
		}

		// Token: 0x040016DF RID: 5855
		private static Lazy<Class176> lazy_0;

		// Token: 0x040016E0 RID: 5856
		[CompilerGenerated]
		private static Func<Class176> func_0;
	}
}
