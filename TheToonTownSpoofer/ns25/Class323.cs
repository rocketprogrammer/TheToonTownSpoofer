using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using ns16;
using ns17;
using ns24;

namespace ns25
{
	// Token: 0x0200034D RID: 845
	internal class Class323 : Interface16, Control4.Class311.Interface20
	{
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000D5E1 File Offset: 0x0000B7E1
		Control4.Class311 Control4.Class311.Interface20.Owner
		{
			get
			{
				return this.Owner;
			}
			set
			{
				this.Owner = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0000D5EA File Offset: 0x0000B7EA
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
		protected Control4.Class311 Owner { get; set; }

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0006F3C8 File Offset: 0x0006D5C8
		protected Font Font
		{
			get
			{
				Control4.Class311 owner = this.Owner;
				if (owner == null)
				{
					return null;
				}
				return owner.Font;
			}
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0006F3E8 File Offset: 0x0006D5E8
		protected Color method_0()
		{
			Control4.Class311 owner = this.Owner;
			if (owner != null)
			{
				if (owner.Down && !owner.Selected)
				{
					return Class294.color_7;
				}
				if (owner.Selected)
				{
					return Class294.color_8;
				}
				if (owner.Hover)
				{
					return Class294.color_9;
				}
			}
			return Class294.color_10;
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0006F438 File Offset: 0x0006D638
		protected void method_1()
		{
			Control4.Class311 owner = this.Owner;
			if (owner != null)
			{
				owner.method_1();
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0006F458 File Offset: 0x0006D658
		public override string ToString()
		{
			Control4.Class311 owner = this.Owner;
			if (owner == null)
			{
				return string.Empty;
			}
			return owner.Name;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00005104 File Offset: 0x00003304
		public virtual void imethod_0(EventArgs34 e)
		{
		}

		// Token: 0x04000D7F RID: 3455
		[CompilerGenerated]
		private Control4.Class311 class311_0;
	}
}
