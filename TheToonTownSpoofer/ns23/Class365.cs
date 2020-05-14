using System;
using System.ComponentModel;
using ns25;
using ns26;
using ns31;

namespace ns23
{
	// Token: 0x02000399 RID: 921
	internal static class Class365
	{
		// Token: 0x060023D0 RID: 9168 RVA: 0x0000F65D File Offset: 0x0000D85D
		public static bool smethod_0(Class316 builder)
		{
			return Class365.smethod_1(builder.method_0());
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0000F66A File Offset: 0x0000D86A
		public static bool smethod_1(Struct44[] inputs)
		{
			if (Class265.SendInput((uint)inputs.Length, inputs, Class316.int_0) == 0U)
			{
				new Win32Exception().smethod_0();
				return false;
			}
			return true;
		}
	}
}
