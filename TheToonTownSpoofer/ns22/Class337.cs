using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ns20;
using ns21;
using TSN.Collections;

namespace ns22
{
	// Token: 0x0200036D RID: 877
	internal sealed class Class337 : IEnumerable<KeyValuePair<string, Class337.Struct34>>, IEnumerable
	{
		// Token: 0x06002262 RID: 8802 RVA: 0x0000E777 File Offset: 0x0000C977
		public Class337()
		{
			this.dictionary_0 = new Dictionary<string, Class337.Struct34>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x0000E78F File Offset: 0x0000C98F
		public ReadOnlyDictionary<string, Class337.Struct34> Files
		{
			get
			{
				if (this.readOnlyDictionary_0 == null)
				{
					this.readOnlyDictionary_0 = new ReadOnlyDictionary<string, Class337.Struct34>(this.dictionary_0);
				}
				return this.readOnlyDictionary_0;
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00074DE4 File Offset: 0x00072FE4
		public void method_0(string data)
		{
			string[] array = data.Split(new char[]
			{
				'\n'
			}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string line in array)
			{
				string text;
				long expectedSize;
				Struct43 expectedHash;
				if (Class337.smethod_0(line, out text, out expectedSize, out expectedHash) && Class337.smethod_1(text))
				{
					Class337.Struct34 value = new Class337.Struct34(expectedSize, expectedHash);
					if (this.dictionary_0.ContainsKey(text))
					{
						this.dictionary_0[text] = value;
					}
					else
					{
						this.dictionary_0.Add(text, value);
					}
				}
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00074E74 File Offset: 0x00073074
		private static bool smethod_0(string line, out string fileName, out long expectedSize, out Struct43 expectedHash)
		{
			fileName = null;
			expectedSize = 0L;
			expectedHash = default(Struct43);
			int num = 0;
			string text;
			if (!line.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			string text2;
			if (!line.smethod_8(' ', ref num, out text2))
			{
				return false;
			}
			long num2;
			if (!long.TryParse(text2, out num2))
			{
				return false;
			}
			if (!line.smethod_7(ref num, out text2))
			{
				return false;
			}
			if (!text2.smethod_13())
			{
				return false;
			}
			fileName = text;
			expectedSize = num2;
			expectedHash = new Struct43(text2);
			return true;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00074EF0 File Offset: 0x000730F0
		private static bool smethod_1(string fileName)
		{
			string a;
			return (a = Path.GetExtension(fileName).ToLower()) == null || (!(a == ".lnk") && !(a == ".url"));
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public IEnumerator<KeyValuePair<string, Class337.Struct34>> GetEnumerator()
		{
			return this.dictionary_0.GetEnumerator();
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.dictionary_0.GetEnumerator();
		}

		// Token: 0x04000FC7 RID: 4039
		private Dictionary<string, Class337.Struct34> dictionary_0;

		// Token: 0x04000FC8 RID: 4040
		private ReadOnlyDictionary<string, Class337.Struct34> readOnlyDictionary_0;

		// Token: 0x0200036E RID: 878
		internal struct Struct34
		{
			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x0000E7C2 File Offset: 0x0000C9C2
			public long ExpectedSize
			{
				get
				{
					return this.long_0;
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x0600226A RID: 8810 RVA: 0x0000E7CA File Offset: 0x0000C9CA
			public Struct43 ExpectedHash
			{
				get
				{
					return this.struct43_0;
				}
			}

			// Token: 0x0600226B RID: 8811 RVA: 0x0000E7D2 File Offset: 0x0000C9D2
			public Struct34(long expectedSize, Struct43 expectedHash)
			{
				this.long_0 = expectedSize;
				this.struct43_0 = expectedHash;
			}

			// Token: 0x04000FC9 RID: 4041
			private long long_0;

			// Token: 0x04000FCA RID: 4042
			private Struct43 struct43_0;
		}
	}
}
