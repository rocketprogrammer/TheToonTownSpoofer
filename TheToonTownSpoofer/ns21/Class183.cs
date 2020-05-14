using System;
using System.Runtime.CompilerServices;
using ns25;

namespace ns21
{
	// Token: 0x0200023F RID: 575
	internal class Class183
	{
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00008074 File Offset: 0x00006274
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000807C File Offset: 0x0000627C
		public Struct21 Hotkey { get; private set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x00008085 File Offset: 0x00006285
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000808D File Offset: 0x0000628D
		public object State { get; private set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x00008096 File Offset: 0x00006296
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000809E File Offset: 0x0000629E
		public Class318 Owner { get; private set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x000080A7 File Offset: 0x000062A7
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x000080AF File Offset: 0x000062AF
		public bool AllowRepeat { get; private set; }

		// Token: 0x060018A0 RID: 6304 RVA: 0x000033EB File Offset: 0x000015EB
		private Class183()
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000080B8 File Offset: 0x000062B8
		protected Class183(Class318 owner, Struct21 hotkey, bool allow_repeat, object state = null)
		{
			this.Owner = owner;
			this.Hotkey = hotkey;
			this.AllowRepeat = allow_repeat;
			this.State = state;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00042EB0 File Offset: 0x000410B0
		public override string ToString()
		{
			return this.Hotkey.ToString();
		}

		// Token: 0x04000689 RID: 1673
		[CompilerGenerated]
		private Struct21 struct21_0;

		// Token: 0x0400068A RID: 1674
		[CompilerGenerated]
		private object object_0;

		// Token: 0x0400068B RID: 1675
		[CompilerGenerated]
		private Class318 class318_0;

		// Token: 0x0400068C RID: 1676
		[CompilerGenerated]
		private bool bool_0;
	}
}
