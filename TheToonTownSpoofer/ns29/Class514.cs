using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ns20;
using ns22;
using TSN.IO;

namespace ns29
{
	// Token: 0x020004C6 RID: 1222
	internal sealed class Class514
	{
		// Token: 0x06002DCE RID: 11726 RVA: 0x00016086 File Offset: 0x00014286
		public Class514()
		{
			this.dictionary_0 = new Dictionary<string, Struct43>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000AFC70 File Offset: 0x000ADE70
		public void method_0(BinaryWriter writer)
		{
			writer.Write(Class514.string_0);
			writer.Write(Class514.int_0);
			writer.Write(this.dictionary_0.Count);
			lock (((ICollection)this.dictionary_0).SyncRoot)
			{
				foreach (KeyValuePair<string, Struct43> keyValuePair in this.dictionary_0)
				{
					writer.Write(keyValuePair.Key);
					writer.smethod_25(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000AFD2C File Offset: 0x000ADF2C
		public static Class514 smethod_0(BinaryReader reader)
		{
			string text = reader.ReadString();
			if (text != Class514.string_0)
			{
				throw new InvalidFileType(Class514.string_0, text);
			}
			int num = reader.ReadInt32();
			if (num != 1)
			{
				throw new InvalidFileVersion<int>(1, 1, num);
			}
			Class514 @class = new Class514();
			int num2 = reader.ReadInt32();
			for (int i = 0; i < num2; i++)
			{
				@class.dictionary_0.Add(reader.ReadString(), reader.smethod_24());
			}
			return @class;
		}

		// Token: 0x04001810 RID: 6160
		private static readonly int int_0 = 1;

		// Token: 0x04001811 RID: 6161
		private static readonly string string_0 = "MFDI";

		// Token: 0x04001812 RID: 6162
		public readonly Dictionary<string, Struct43> dictionary_0;
	}
}
