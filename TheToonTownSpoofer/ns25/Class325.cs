using System;
using System.Drawing;
using ns16;
using ns20;
using ns23;
using ns24;

namespace ns25
{
	// Token: 0x0200034F RID: 847
	internal sealed class Class325 : Class324
	{
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0000D634 File Offset: 0x0000B834
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0000D63C File Offset: 0x0000B83C
		public int OrganicQuantity
		{
			get
			{
				return this.int_2;
			}
			set
			{
				if (this.int_2 != value)
				{
					this.int_2 = value;
					base.method_1();
				}
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0006F53C File Offset: 0x0006D73C
		public int OrganicDamage
		{
			get
			{
				double num = Math.Floor((double)base.Damage / 10.0);
				return base.Damage + ((num > 1.0) ? ((int)num) : 1);
			}
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0006F578 File Offset: 0x0006D778
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
					e.Graphics.DrawString(base.NormalQuantity.ToString(), font, solidBrush, e.Bounds.Location.smethod_3(2, 2));
					string text = this.OrganicQuantity.ToString();
					SizeF sizeF = e.Graphics.MeasureString(text, font);
					e.Graphics.DrawString(this.OrganicQuantity.ToString(), font, solidBrush, e.Bounds.smethod_20().smethod_3(-1 - (int)sizeF.Width, 2));
				}
			}
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0006F65C File Offset: 0x0006D85C
		public override string ToString()
		{
			Control4.Class311 owner = base.Owner;
			if (owner == null)
			{
				return string.Empty;
			}
			return string.Format("{0}, {1} damage, {2} organic damage.", owner.Name, base.Damage, this.OrganicDamage);
		}

		// Token: 0x04000D82 RID: 3458
		private int int_2;
	}
}
