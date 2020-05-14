using System;
using System.ComponentModel;
using System.Windows.Forms;
using ns19;
using ns31;

namespace ns24
{
	// Token: 0x02000317 RID: 791
	internal static class Class302
	{
		// Token: 0x06001ECD RID: 7885 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
		public static void smethod_0(IntPtr hWnd, int id, Enum96 modifiers, Keys key)
		{
			if (!Class265.RegisterHotKey(hWnd, id, modifiers, key))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0000BFCA File Offset: 0x0000A1CA
		public static void smethod_1(IntPtr hWnd, int id)
		{
			if (!Class265.UnregisterHotKey(hWnd, id))
			{
				throw new Win32Exception();
			}
		}
	}
}
