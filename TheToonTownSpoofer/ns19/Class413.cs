using System;

namespace ns19
{
	// Token: 0x020003FF RID: 1023
	internal static class Class413
	{
		// Token: 0x06002707 RID: 9991 RVA: 0x00011755 File Offset: 0x0000F955
		public static Version smethod_0(this byte[] data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return new Version(BitConverter.ToInt32(data, 0), BitConverter.ToInt32(data, 4), BitConverter.ToInt32(data, 8), BitConverter.ToInt32(data, 12));
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		public static short smethod_1(this byte[] bytes, int startIndex)
		{
			byte[] array = new byte[2];
			Array.Copy(bytes, startIndex, array, 0, 2);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt16(array, 0);
		}
	}
}
