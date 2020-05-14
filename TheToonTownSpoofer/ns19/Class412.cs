using System;

namespace ns19
{
	// Token: 0x020003FE RID: 1022
	internal static class Class412
	{
		// Token: 0x06002706 RID: 9990 RVA: 0x0008C4A4 File Offset: 0x0008A6A4
		public static void smethod_0(this Random rnd, byte[] buffer, byte minValue, byte maxValue)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			for (int i = 0; i < buffer.Length; i++)
			{
				buffer[i] = (byte)rnd.Next((int)minValue, (int)maxValue);
			}
		}
	}
}
