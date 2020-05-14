using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ns17;
using ns21;

namespace ns23
{
	// Token: 0x020003A5 RID: 933
	internal sealed class Class182 : Class180
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		public Class182()
		{
			this.MaximumValue = float.MaxValue;
			this.MinimumValue = float.MinValue;
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000067F0 File Offset: 0x000049F0
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x00007F7D File Offset: 0x0000617D
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

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0007A69C File Offset: 0x0007889C
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0000F9DA File Offset: 0x0000DBDA
		[Category("Appearance")]
		public float Value
		{
			[DebuggerStepThrough]
			get
			{
				if (this.Text == string.Empty || this.Text == "-" || this.Text == ".")
				{
					return 0f;
				}
				float result;
				if (float.TryParse(this.Text, out result))
				{
					return result;
				}
				return 0f;
			}
			set
			{
				if (this.method_5(value))
				{
					base.Text = value.ToString(Class217.cultureInfo_0);
				}
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0000F9F7 File Offset: 0x0000DBF7
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0000F9FF File Offset: 0x0000DBFF
		[Category("Behavior")]
		public float MaximumValue
		{
			get
			{
				return this.float_0;
			}
			set
			{
				if (this.float_0 != value)
				{
					this.float_0 = value;
					if (this.Value > this.float_0)
					{
						this.Value = this.float_0;
					}
				}
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0000FA2B File Offset: 0x0000DC2B
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0000FA33 File Offset: 0x0000DC33
		[Category("Behavior")]
		public float MinimumValue
		{
			get
			{
				return this.float_1;
			}
			set
			{
				if (this.float_1 != value)
				{
					this.float_1 = value;
					if (this.Value < this.float_1)
					{
						this.Value = this.float_1;
					}
				}
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0000FA5F File Offset: 0x0000DC5F
		protected override bool vmethod_1()
		{
			return this.MinimumValue < 0f;
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x00008035 File Offset: 0x00006235
		// (set) Token: 0x0600242D RID: 9261 RVA: 0x0000FA6E File Offset: 0x0000DC6E
		[DefaultValue("0")]
		[Category("Appearance")]
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

		// Token: 0x0600242E RID: 9262 RVA: 0x0007A6FC File Offset: 0x000788FC
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

		// Token: 0x0600242F RID: 9263 RVA: 0x0007A774 File Offset: 0x00078974
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
					goto IL_135;
				case Keys.D2:
					goto IL_13D;
				case Keys.D3:
					goto IL_145;
				case Keys.D4:
					goto IL_14D;
				case Keys.D5:
					goto IL_155;
				case Keys.D6:
					goto IL_15D;
				case Keys.D7:
					goto IL_165;
				case Keys.D8:
					goto IL_16D;
				case Keys.D9:
					goto IL_175;
				default:
					switch (key)
					{
					case Keys.NumPad0:
						goto IL_12D;
					case Keys.NumPad1:
						goto IL_135;
					case Keys.NumPad2:
						goto IL_13D;
					case Keys.NumPad3:
						goto IL_145;
					case Keys.NumPad4:
						goto IL_14D;
					case Keys.NumPad5:
						goto IL_155;
					case Keys.NumPad6:
						goto IL_15D;
					case Keys.NumPad7:
						goto IL_165;
					case Keys.NumPad8:
						goto IL_16D;
					case Keys.NumPad9:
						goto IL_175;
					case Keys.Multiply:
					case Keys.Add:
					case Keys.Separator:
						goto IL_17B;
					case Keys.Subtract:
						break;
					case Keys.Decimal:
						goto IL_125;
					default:
						switch (key)
						{
						case Keys.OemMinus:
							break;
						case Keys.OemPeriod:
							goto IL_125;
						default:
							goto IL_17B;
						}
						break;
					}
					value = "-";
					goto IL_17B;
					IL_125:
					value = ".";
					goto IL_17B;
				}
				IL_12D:
				value = "0";
				goto IL_17B;
				IL_135:
				value = "1";
				goto IL_17B;
				IL_13D:
				value = "2";
				goto IL_17B;
				IL_145:
				value = "3";
				goto IL_17B;
				IL_14D:
				value = "4";
				goto IL_17B;
				IL_155:
				value = "5";
				goto IL_17B;
				IL_15D:
				value = "6";
				goto IL_17B;
				IL_165:
				value = "7";
				goto IL_17B;
				IL_16D:
				value = "8";
				goto IL_17B;
				IL_175:
				value = "9";
				IL_17B:
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

		// Token: 0x06002430 RID: 9264 RVA: 0x0007A944 File Offset: 0x00078B44
		private bool method_4(string input)
		{
			float value;
			return !string.IsNullOrEmpty(input) && float.TryParse(input, out value) && this.method_5(value);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0000FA8E File Offset: 0x0000DC8E
		private bool method_5(float value)
		{
			return value <= this.MaximumValue && value >= this.MinimumValue;
		}

		// Token: 0x040010CB RID: 4299
		private float float_0;

		// Token: 0x040010CC RID: 4300
		private float float_1;
	}
}
