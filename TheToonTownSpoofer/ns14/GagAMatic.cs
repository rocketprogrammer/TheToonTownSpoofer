using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns15;
using ns17;
using ns19;
using ns20;
using ns21;
using ns24;
using ns25;
using ns26;
using ns31;

namespace ns14
{
	// Token: 0x020001D3 RID: 467
	internal sealed partial class GagAMatic : Form0
	{
		// Token: 0x06001528 RID: 5416 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		public GagAMatic()
		{
			this.InitializeComponent();
			this.GagBoard.BackgroundPaint = new Class407();
			this.KeepOnTop.Checked = Class110.Instance.GagAMaticSettings.TopMost;
			this.ShowToolTips.Checked = Class110.Instance.GagAMaticSettings.ShowToolTips;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00005925 File Offset: 0x00003B25
		private void method_1()
		{
			if (this.method_4(Enum32.const_2) == 0)
			{
				this.method_2(true);
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0002CC38 File Offset: 0x0002AE38
		private void method_2(bool select)
		{
			if (!select || this.int_0 < 4)
			{
				foreach (Control4.Class311 @class in this.GagBoard.Buttons.Union(this.SosBoard.Buttons))
				{
					if ((Enum32)@class.ButtonType == Enum32.const_2)
					{
						@class.Selected = select;
					}
				}
				if (select)
				{
					this.int_0++;
					return;
				}
				this.int_0--;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0002CCD8 File Offset: 0x0002AED8
		private void method_3(object sender, EventArgs21 e)
		{
			switch ((Enum32)e.ButtonBoardButton.ButtonType)
			{
			case Enum32.const_1:
				if (e.ButtonBoardButton.Selected)
				{
					if (e.MouseButton == MouseButtons.Left)
					{
						Class324 @class = e.ButtonBoardButton.Overlay as Class324;
						if (@class.NormalQuantity == 0)
						{
							this.method_5(e.ButtonBoardButton, @class);
							int num = this.int_0;
							@class.NormalQuantity = 1;
							this.int_0 = num + 1;
							e.ButtonBoardButton.Selected = true;
							this.method_1();
							goto IL_49A;
						}
						this.method_5(e.ButtonBoardButton, @class);
						goto IL_49A;
					}
					else
					{
						if (!(e.ButtonBoardButton.Overlay.GetType() == typeof(Class325)))
						{
							goto IL_49A;
						}
						Class325 class2 = e.ButtonBoardButton.Overlay as Class325;
						if (class2.OrganicQuantity == 0)
						{
							this.method_6(e.ButtonBoardButton, class2);
							int num2 = this.int_0;
							class2.OrganicQuantity = 1;
							this.int_0 = num2 + 1;
							e.ButtonBoardButton.Selected = true;
							this.method_1();
							goto IL_49A;
						}
						this.method_6(e.ButtonBoardButton, class2);
						goto IL_49A;
					}
				}
				else
				{
					foreach (Control4.Class311 class3 in this.GagBoard.Buttons.Union(this.SosBoard.Buttons))
					{
						if ((Enum32)class3.ButtonType == Enum32.const_1)
						{
							this.method_5(class3, class3.Overlay as Class324);
						}
					}
				}
				break;
			case Enum32.const_2:
				if (e.ButtonBoardButton.Selected)
				{
					this.method_2(false);
					goto IL_49A;
				}
				if (this.int_0 < 4)
				{
					this.method_2(true);
					goto IL_49A;
				}
				this.MaxMessage.method_0();
				goto IL_49A;
			}
			if (e.ButtonBoardButton.Selected)
			{
				if (this.int_0 < 4)
				{
					if (e.MouseButton == MouseButtons.Left)
					{
						(e.ButtonBoardButton.Overlay as Class324).NormalQuantity++;
						this.int_0++;
					}
					else if (e.ButtonBoardButton.Overlay.GetType() == typeof(Class325))
					{
						(e.ButtonBoardButton.Overlay as Class325).OrganicQuantity++;
						this.int_0++;
					}
				}
				else if (e.MouseButton == MouseButtons.Left)
				{
					Class324 class4 = e.ButtonBoardButton.Overlay as Class324;
					if (class4.NormalQuantity == 0)
					{
						this.MaxMessage.method_0();
					}
					else
					{
						this.int_0 -= class4.NormalQuantity;
						class4.NormalQuantity = 0;
						e.ButtonBoardButton.Selected = (class4.NormalQuantity != 0 || (class4.GetType() == typeof(Class325) && (class4 as Class325).OrganicQuantity != 0));
					}
				}
				else if (e.ButtonBoardButton.Overlay.GetType() == typeof(Class325))
				{
					Class325 class5 = e.ButtonBoardButton.Overlay as Class325;
					if (class5.OrganicQuantity == 0)
					{
						this.MaxMessage.method_0();
					}
					else
					{
						this.int_0 -= class5.OrganicQuantity;
						class5.OrganicQuantity = 0;
						e.ButtonBoardButton.Selected = (class5.NormalQuantity != 0 || class5.OrganicQuantity != 0);
					}
				}
			}
			else if (this.int_0 < 4)
			{
				if (e.MouseButton == MouseButtons.Left)
				{
					(e.ButtonBoardButton.Overlay as Class324).NormalQuantity++;
					this.int_0++;
					e.ButtonBoardButton.Selected = true;
					if ((Enum32)e.ButtonBoardButton.ButtonType == Enum32.const_1)
					{
						this.method_1();
					}
				}
				else if (e.ButtonBoardButton.Overlay.GetType() == typeof(Class325))
				{
					(e.ButtonBoardButton.Overlay as Class325).OrganicQuantity++;
					this.int_0++;
					e.ButtonBoardButton.Selected = true;
					if ((Enum32)e.ButtonBoardButton.ButtonType == Enum32.const_1)
					{
						this.method_1();
					}
				}
			}
			else
			{
				this.MaxMessage.method_0();
			}
			IL_49A:
			this.method_7();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0002D198 File Offset: 0x0002B398
		private void btnClear_Click(object sender, EventArgs e)
		{
			bool flag = false;
			IEnumerable<Control4.Class311> source = this.GagBoard.Buttons.Union(this.SosBoard.Buttons);
			if (GagAMatic.func_0 == null)
			{
				GagAMatic.func_0 = new Func<Control4.Class311, bool>(GagAMatic.smethod_4);
			}
			foreach (Control4.Class311 @class in source.Where(GagAMatic.func_0))
			{
				if ((Enum32)@class.ButtonType == Enum32.const_2)
				{
					flag = true;
				}
				else
				{
					this.method_5(@class, @class.Overlay as Class324);
				}
				@class.Selected = false;
			}
			if (flag)
			{
				this.int_0--;
			}
			if (this.Lured.Checked)
			{
				this.Lured.Checked = false;
			}
			else
			{
				this.method_7();
			}
			this.MaxMessage.method_1();
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0002D280 File Offset: 0x0002B480
		private int method_4(Enum32 type)
		{
			GagAMatic.Class84 @class = new GagAMatic.Class84();
			@class.enum32_0 = type;
			return this.GagBoard.Buttons.Union(this.SosBoard.Buttons).Where(new Func<Control4.Class311, bool>(@class.method_0)).Count<Control4.Class311>();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		private void method_5(Control4.Class311 btn, Class324 gag)
		{
			if (gag.GetType() == typeof(Class325))
			{
				this.method_6(btn, gag as Class325);
				return;
			}
			if (gag.NormalQuantity > 0)
			{
				this.int_0 -= gag.NormalQuantity;
				gag.NormalQuantity = 0;
			}
			btn.Selected = false;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0002D328 File Offset: 0x0002B528
		private void method_6(Control4.Class311 btn, Class325 gag)
		{
			if (gag.NormalQuantity > 0)
			{
				this.int_0 -= gag.NormalQuantity;
				gag.NormalQuantity = 0;
			}
			if (gag.OrganicQuantity > 0)
			{
				this.int_0 -= gag.OrganicQuantity;
				gag.OrganicQuantity = 0;
			}
			btn.Selected = false;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0002D384 File Offset: 0x0002B584
		private void method_7()
		{
			bool flag = this.Lured.Checked;
			int num = 0;
			int num2 = 0;
			if (!flag && this.method_4(Enum32.const_2) > 0)
			{
				this.method_8(Enum32.const_1, out num, out num2);
				flag = (num2 == 0);
			}
			int num3 = 0;
			int num4 = 0;
			this.method_8(Enum32.const_3, out num3, out num4);
			int num5;
			if (num4 > 1)
			{
				num5 = GagAMatic.smethod_2(num3);
			}
			else
			{
				num5 = 0;
			}
			if (num4 > 0)
			{
				flag = false;
			}
			int num6 = 0;
			int num7 = 0;
			this.method_8(Enum32.const_4, out num6, out num7);
			int num8;
			if (flag && num7 > 0)
			{
				num8 = GagAMatic.smethod_3(num6);
			}
			else
			{
				num8 = 0;
			}
			int num9;
			if (num7 > 1)
			{
				num9 = GagAMatic.smethod_2(num6);
			}
			else
			{
				num9 = 0;
			}
			if (num7 > 0)
			{
				flag = false;
			}
			int num10 = 0;
			int num11 = 0;
			this.method_8(Enum32.const_5, out num10, out num11);
			int num12;
			if (flag && num11 > 0)
			{
				num12 = GagAMatic.smethod_3(num10);
			}
			else
			{
				num12 = 0;
			}
			int num13;
			if (num11 > 1)
			{
				num13 = GagAMatic.smethod_2(num10);
			}
			else
			{
				num13 = 0;
			}
			if (num11 > 0)
			{
				flag = false;
			}
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			if (!flag)
			{
				this.method_8(Enum32.const_6, out num14, out num15);
				if (num15 > 1)
				{
					num16 = GagAMatic.smethod_2(num14);
				}
			}
			int num17 = num + num3 + num5 + num6 + num8 + num9 + num10 + num12 + num13 + num14 + num16;
			if (num17 >= 200)
			{
				this.MaxCog.Text = "Level 12";
			}
			else if (num17 >= 156)
			{
				this.MaxCog.Text = "Level 11";
			}
			else if (num17 >= 132)
			{
				this.MaxCog.Text = "Level 10";
			}
			else if (num17 >= 110)
			{
				this.MaxCog.Text = "Level 9";
			}
			else if (num17 >= 90)
			{
				this.MaxCog.Text = "Level 8";
			}
			else if (num17 >= 72)
			{
				this.MaxCog.Text = "Level 7";
			}
			else if (num17 >= 56)
			{
				this.MaxCog.Text = "Level 6";
			}
			else if (num17 >= 42)
			{
				this.MaxCog.Text = "Level 5";
			}
			else if (num17 >= 30)
			{
				this.MaxCog.Text = "Level 4";
			}
			else if (num17 >= 20)
			{
				this.MaxCog.Text = "Level 3";
			}
			else if (num17 >= 12)
			{
				this.MaxCog.Text = "Level 2";
			}
			else if (num17 >= 6)
			{
				this.MaxCog.Text = "Level 1";
			}
			else if (num17 >= 0)
			{
				this.MaxCog.Text = "Level 0";
			}
			this.HitPoints.Text = num17.ToString() + " HP";
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0002D61C File Offset: 0x0002B81C
		private void method_8(Enum32 type, out int damage, out int quantity)
		{
			GagAMatic.Class85 @class = new GagAMatic.Class85();
			@class.enum32_0 = type;
			damage = 0;
			quantity = 0;
			foreach (Control4.Class311 class2 in this.GagBoard.Buttons.Union(this.SosBoard.Buttons).Where(new Func<Control4.Class311, bool>(@class.method_0)))
			{
				if (class2.Overlay.GetType() == typeof(Class325))
				{
					Class325 class3 = class2.Overlay as Class325;
					damage += class3.OrganicQuantity * class3.OrganicDamage;
					quantity += class3.OrganicQuantity;
				}
				Class324 class4 = class2.Overlay as Class324;
				damage += class4.NormalQuantity * class4.Damage;
				quantity += class4.NormalQuantity;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00005937 File Offset: 0x00003B37
		private static int smethod_2(int damage)
		{
			return (int)Math.Ceiling((double)damage / 5.0);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0000594B File Offset: 0x00003B4B
		private static int smethod_3(int damage)
		{
			return (int)((double)damage / 2.0);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0002D710 File Offset: 0x0002B910
		private void Lured_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Lured.Checked)
			{
				bool flag = false;
				foreach (Control4.Class311 @class in this.GagBoard.Buttons.Union(this.SosBoard.Buttons))
				{
					switch ((Enum32)@class.ButtonType)
					{
					case Enum32.const_1:
						this.method_5(@class, @class.Overlay as Class324);
						@class.Enabled = false;
						break;
					case Enum32.const_2:
						if (@class.Selected)
						{
							flag = true;
							@class.Selected = false;
						}
						@class.Enabled = false;
						break;
					}
				}
				if (flag)
				{
					this.int_0--;
				}
			}
			else
			{
				foreach (Control4.Class311 class2 in this.GagBoard.Buttons.Union(this.SosBoard.Buttons))
				{
					switch ((Enum32)class2.ButtonType)
					{
					case Enum32.const_1:
					case Enum32.const_2:
						class2.Enabled = true;
						break;
					}
				}
			}
			this.method_7();
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000595A File Offset: 0x00003B5A
		private void KeepOnTop_CheckedChanged(object sender, EventArgs e)
		{
			base.TopMost = this.KeepOnTop.Checked;
			Class110.Instance.GagAMaticSettings.TopMost = this.KeepOnTop.Checked;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0002D864 File Offset: 0x0002BA64
		private void ShowToolTips_CheckedChanged(object sender, EventArgs e)
		{
			this.GagBoard.ToolTipsEnabled = this.ShowToolTips.Checked;
			this.SosBoard.ToolTipsEnabled = this.ShowToolTips.Checked;
			this.toolTip_0.Active = this.ShowToolTips.Checked;
			Class110.Instance.GagAMaticSettings.ShowToolTips = this.ShowToolTips.Checked;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00005987 File Offset: 0x00003B87
		private void GagAMatic_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_12);
			e.Handled = true;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000059B6 File Offset: 0x00003BB6
		[CompilerGenerated]
		private static bool smethod_4(Control4.Class311 item)
		{
			return item.Selected;
		}

		// Token: 0x040002C5 RID: 709
		private int int_0;

		// Token: 0x040002E3 RID: 739
		[CompilerGenerated]
		private static Func<Control4.Class311, bool> func_0;

		// Token: 0x020001D4 RID: 468
		[CompilerGenerated]
		private sealed class Class84
		{
			// Token: 0x0600153C RID: 5436 RVA: 0x000059BE File Offset: 0x00003BBE
			public bool method_0(Control4.Class311 item)
			{
				return item.Selected && (Enum32)item.ButtonType == this.enum32_0;
			}

			// Token: 0x040002E4 RID: 740
			public Enum32 enum32_0;
		}

		// Token: 0x020001D5 RID: 469
		[CompilerGenerated]
		private sealed class Class85
		{
			// Token: 0x0600153E RID: 5438 RVA: 0x000059DD File Offset: 0x00003BDD
			public bool method_0(Control4.Class311 item)
			{
				return item.Selected && (Enum32)item.ButtonType == this.enum32_0;
			}

			// Token: 0x040002E5 RID: 741
			public Enum32 enum32_0;
		}
	}
}
