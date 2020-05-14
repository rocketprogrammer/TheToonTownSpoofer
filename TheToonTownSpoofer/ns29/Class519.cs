using System;
using System.Collections.Generic;
using System.Diagnostics;
using TSN.Collections;

namespace ns29
{
	// Token: 0x020004CC RID: 1228
	internal sealed class Class519<TKey, TValue>
	{
		// Token: 0x06002DF3 RID: 11763 RVA: 0x00016252 File Offset: 0x00014452
		public Class519(ReadOnlyDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this.idictionary_0 = dictionary;
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x000B0520 File Offset: 0x000AE720
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePair<TKey, TValue>[] Items
		{
			get
			{
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this.idictionary_0.Count];
				this.idictionary_0.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x0400181D RID: 6173
		private IDictionary<TKey, TValue> idictionary_0;
	}
}
