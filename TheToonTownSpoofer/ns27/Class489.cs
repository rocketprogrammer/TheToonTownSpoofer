using System;

namespace ns27
{
	// Token: 0x02000491 RID: 1169
	internal static class Class489
	{
		// Token: 0x06002B86 RID: 11142 RVA: 0x0001441C File Offset: 0x0001261C
		public static bool smethod_0(this Version version)
		{
			return version.Major == 0 && version.Minor == 0 && version.Revision == 0 && version.Build == 0;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000A97E8 File Offset: 0x000A79E8
		public static byte[] smethod_1(this Version version)
		{
			byte[] array = new byte[16];
			BitConverter.GetBytes(version.Major).CopyTo(array, 0);
			BitConverter.GetBytes(version.Minor).CopyTo(array, 4);
			BitConverter.GetBytes(version.Build).CopyTo(array, 8);
			BitConverter.GetBytes(version.Revision).CopyTo(array, 12);
			return array;
		}
	}
}
