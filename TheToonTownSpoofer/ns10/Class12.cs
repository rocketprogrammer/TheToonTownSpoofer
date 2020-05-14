using System;
using System.Runtime.InteropServices;
using ns5;

namespace ns10
{
	// Token: 0x0200014C RID: 332
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	internal sealed class Class12 : GInterface69
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x000035BD File Offset: 0x000017BD
		public void onclick()
		{
			if (this.delegate63_0 != null)
			{
				this.delegate63_0();
				return;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000035D9 File Offset: 0x000017D9
		internal Class12()
		{
			this.int_0 = 0;
			this.delegate63_0 = null;
		}

		// Token: 0x040000D5 RID: 213
		public Delegate63 delegate63_0;

		// Token: 0x040000D6 RID: 214
		public int int_0;
	}
}
