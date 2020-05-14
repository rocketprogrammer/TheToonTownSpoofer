using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ns17;

namespace ns21
{
	// Token: 0x0200023E RID: 574
	internal sealed class Class181 : Class180
	{
		// Token: 0x06001886 RID: 6278 RVA: 0x00007F5F File Offset: 0x0000615F
		public Class181()
		{
			this.MaximumValue = int.MaxValue;
			this.MinimumValue = int.MinValue;
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000067F0 File Offset: 0x000049F0
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00007F7D File Offset: 0x0000617D
		public override bool Multiline
		{
			get
			{
				return false;
			}
			set
			{
				base.Multiline = false;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00042BB8 File Offset: 0x00040DB8
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00007F86 File Offset: 0x00006186
		[Category("Appearance")]
		public int Value
		{
			[DebuggerStepThrough]
			get
			{
				if (this.Text == string.Empty || this.Text == "-")
				{
					return 0;
				}
				int result;
				if (int.TryParse(this.Text, out result))
				{
					return result;
				}
				return 0;
			}
			set
			{
				if (this.method_5(value))
				{
					if (value == 0 && this.IfZeroDisplayEmpty)
					{
						base.Text = string.Empty;
						return;
					}
					base.Text = value.ToString(Class217.cultureInfo_0);
				}
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00007FBA File Offset: 0x000061BA
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x00042C00 File Offset: 0x00040E00
		[Category("Behavior")]
		public bool IfZeroDisplayEmpty
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					if (this.bool_0)
					{
						if (this.Value == 0)
						{
							base.Text = string.Empty;
							return;
						}
					}
					else
					{
						base.Text = this.Value.ToString(Class217.cultureInfo_0);
					}
				}
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00007FC2 File Offset: 0x000061C2
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x00007FCA File Offset: 0x000061CA
		[Category("Behavior")]
		public int MaximumValue
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
					if (this.Value > this.int_0)
					{
						this.Value = this.int_0;
					}
				}
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00007FF6 File Offset: 0x000061F6
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x00007FFE File Offset: 0x000061FE
		[Category("Behavior")]
		public int MinimumValue
		{
			get
			{
				return this.int_1;
			}
			set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					if (this.Value < this.int_1)
					{
						this.Value = this.int_1;
					}
				}
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000802A File Offset: 0x0000622A
		protected override bool vmethod_1()
		{
			return this.MinimumValue < 0;
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00008035 File Offset: 0x00006235
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000803D File Offset: 0x0000623D
		[Category("Appearance")]
		[DefaultValue("0")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				if (base.Text != value && this.method_4(value))
				{
					base.Text = value;
				}
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00042C54 File Offset: 0x00040E54
		protected override bool vmethod_0()
		{
			bool result;
			try
			{
				if (Clipboard.ContainsText())
				{
					string text = Clipboard.GetText();
					if (text == null)
					{
						result = false;
					}
					else
					{
						result = this.method_4(base.Text.Remove(base.SelectionStart, this.SelectionLength).Insert(base.SelectionStart, text));
					}
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00042CCC File Offset: 0x00040ECC
		protected override bool vmethod_2(Keys key)
		{
			string text = base.Text.Remove(base.SelectionStart, base.SelectionLength);
			if (key == Keys.Back)
			{
				if (base.SelectionStart > 0 && base.SelectionLength == 0)
				{
					text = base.Text.Remove(base.SelectionStart - 1, 1);
				}
			}
			else if (key == Keys.Delete)
			{
				if (base.SelectionStart < base.Text.Length - 2 && base.SelectionLength == 0)
				{
					text = base.Text.Remove(base.SelectionStart, 1);
				}
			}
			else
			{
				string value = null;
				switch (key)
				{
				case Keys.D0:
					break;
				case Keys.D1:
					goto IL_11D;
				case Keys.D2:
					goto IL_125;
				case Keys.D3:
					goto IL_12D;
				case Keys.D4:
					goto IL_135;
				case Keys.D5:
					goto IL_13D;
				case Keys.D6:
					goto IL_145;
				case Keys.D7:
					goto IL_14D;
				case Keys.D8:
					goto IL_155;
				case Keys.D9:
					goto IL_15D;
				default:
					switch (key)
					{
					case Keys.NumPad0:
						goto IL_115;
					case Keys.NumPad1:
						goto IL_11D;
					case Keys.NumPad2:
						goto IL_125;
					case Keys.NumPad3:
						goto IL_12D;
					case Keys.NumPad4:
						goto IL_135;
					case Keys.NumPad5:
						goto IL_13D;
					case Keys.NumPad6:
						goto IL_145;
					case Keys.NumPad7:
						goto IL_14D;
					case Keys.NumPad8:
						goto IL_155;
					case Keys.NumPad9:
						goto IL_15D;
					case Keys.Multiply:
					case Keys.Add:
					case Keys.Separator:
						goto IL_163;
					case Keys.Subtract:
						break;
					default:
						if (key != Keys.OemMinus)
						{
							goto IL_163;
						}
						break;
					}
					value = "-";
					goto IL_163;
				}
				IL_115:
				value = "0";
				goto IL_163;
				IL_11D:
				value = "1";
				goto IL_163;
				IL_125:
				value = "2";
				goto IL_163;
				IL_12D:
				value = "3";
				goto IL_163;
				IL_135:
				value = "4";
				goto IL_163;
				IL_13D:
				value = "5";
				goto IL_163;
				IL_145:
				value = "6";
				goto IL_163;
				IL_14D:
				value = "7";
				goto IL_163;
				IL_155:
				value = "8";
				goto IL_163;
				IL_15D:
				value = "9";
				IL_163:
				if (!string.IsNullOrEmpty(value))
				{
					text = text.Insert(base.SelectionStart, value);
				}
			}
			if (text == string.Empty)
			{
				text = "0";
			}
			else if (text == "-")
			{
				text = "-0";
			}
			return this.method_4(text);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00042E84 File Offset: 0x00041084
		private bool method_4(string input)
		{
			int value;
			return !string.IsNullOrEmpty(input) && int.TryParse(input, out value) && this.method_5(value);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0000805D File Offset: 0x0000625D
		private bool method_5(int value)
		{
			return value <= this.MaximumValue && value >= this.MinimumValue;
		}

		// Token: 0x04000686 RID: 1670
		private int int_0;

		// Token: 0x04000687 RID: 1671
		private int int_1;

		// Token: 0x04000688 RID: 1672
		private bool bool_0;
	}
}
