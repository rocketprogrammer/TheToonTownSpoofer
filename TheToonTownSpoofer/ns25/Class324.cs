using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using ns16;
using ns23;
using ns24;

namespace ns25
{
	// Token: 0x0200034E RID: 846
	internal class Class324 : Class323
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0000D5FB File Offset: 0x0000B7FB
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0000D603 File Offset: 0x0000B803
		public int NormalQuantity
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					base.method_1();
				}
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0000D61B File Offset: 0x0000B81B
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x0000D623 File Offset: 0x0000B823
		public int Damage { get; set; }

		// Token: 0x060020DB RID: 8411 RVA: 0x0006F47C File Offset: 0x0006D67C
		public override void imethod_0(EventArgs34 e)
		{
			Font font = base.Font;
			Control4.Class311 owner = base.Owner;
			if (!owner.Enabled)
			{
				return;
			}
			if (font != null)
			{
				using (SolidBrush solidBrush = new SolidBrush(base.method_0()))
				{
					e.Graphics.DrawString(this.NormalQuantity.ToString(), font, solidBrush, e.Bounds.Location.smethod_3(2, 2));
				}
			}
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0006F504 File Offset: 0x0006D704
		public override string ToString()
		{
			Control4.Class311 owner = base.Owner;
			if (owner == null)
			{
				return string.Empty;
			}
			return string.Format("{0}, {1} damage.", owner.Name, this.Damage);
		}

		// Token: 0x04000D80 RID: 3456
		private int int_0;

		// Token: 0x04000D81 RID: 3457
		[CompilerGenerated]
		private int int_1;
	}
}
