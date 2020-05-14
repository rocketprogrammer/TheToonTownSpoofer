using System;
using System.Windows.Forms;
using ns19;

namespace ns21
{
	// Token: 0x02000240 RID: 576
	internal struct Struct21
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000080DD File Offset: 0x000062DD
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00042ED4 File Offset: 0x000410D4
		public Keys Key
		{
			get
			{
				return this.keys_0;
			}
			set
			{
				if (this.keys_0 != value)
				{
					this.keys_0 = Keys.None;
					if (value <= Keys.RMenu)
					{
						switch (value)
						{
						case Keys.ShiftKey:
						case Keys.ControlKey:
						case Keys.Menu:
							return;
						default:
							switch (value)
							{
							case Keys.LWin:
							case Keys.RWin:
								return;
							default:
								switch (value)
								{
								case Keys.LShiftKey:
								case Keys.RShiftKey:
								case Keys.LControlKey:
								case Keys.RControlKey:
								case Keys.LMenu:
								case Keys.RMenu:
									return;
								}
								break;
							}
							break;
						}
					}
					else if (value == Keys.Shift || value == Keys.Control || value == Keys.Alt)
					{
						return;
					}
					this.keys_0 = value;
				}
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000080E5 File Offset: 0x000062E5
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x00042F68 File Offset: 0x00041168
		public Keys Modifier
		{
			get
			{
				return this.keys_1;
			}
			set
			{
				if (this.keys_1 != value)
				{
					this.keys_1 = Keys.None;
					if (value.HasFlag(Keys.Control) || value.HasFlag(Keys.ControlKey) || value.HasFlag(Keys.LControlKey) || value.HasFlag(Keys.RControlKey))
					{
						this.keys_1 |= Keys.Control;
					}
					if (value.HasFlag(Keys.Shift) || value.HasFlag(Keys.ShiftKey) || value.HasFlag(Keys.LShiftKey) || value.HasFlag(Keys.RShiftKey))
					{
						this.keys_1 |= Keys.Shift;
					}
					if (value.HasFlag(Keys.Alt) || value.HasFlag(Keys.Menu) || value.HasFlag(Keys.LMenu) || value.HasFlag(Keys.RMenu))
					{
						this.keys_1 |= Keys.Alt;
					}
				}
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000430CC File Offset: 0x000412CC
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0004313C File Offset: 0x0004133C
		public Enum96 NativeModifier
		{
			get
			{
				Enum96 @enum = Enum96.flag_0;
				if (this.keys_1.HasFlag(Keys.Control))
				{
					@enum |= Enum96.flag_2;
				}
				if (this.keys_1.HasFlag(Keys.Shift))
				{
					@enum |= Enum96.flag_3;
				}
				if (this.keys_1.HasFlag(Keys.Alt))
				{
					@enum |= Enum96.flag_1;
				}
				return @enum;
			}
			set
			{
				this.keys_1 = Keys.None;
				if (value.HasFlag(Enum96.flag_2))
				{
					this.keys_1 |= Keys.Control;
				}
				if (value.HasFlag(Enum96.flag_3))
				{
					this.keys_1 |= Keys.Shift;
				}
				if (value.HasFlag(Enum96.flag_1))
				{
					this.keys_1 |= Keys.Alt;
				}
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000080ED File Offset: 0x000062ED
		public Struct21(Keys key, Keys modifier)
		{
			this = default(Struct21);
			this.Key = key;
			this.Modifier = modifier;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00008104 File Offset: 0x00006304
		public Struct21(Keys key)
		{
			this = new Struct21(key, Keys.None);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0000810E File Offset: 0x0000630E
		public static bool smethod_0(Struct21 left, Struct21 right)
		{
			return left.Key == right.Key && left.Modifier == right.Modifier;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00008132 File Offset: 0x00006332
		public static bool smethod_1(Struct21 left, Struct21 right)
		{
			return !Struct21.smethod_0(left, right);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0000813E File Offset: 0x0000633E
		public override bool Equals(object obj)
		{
			return obj is Struct21 && base.Equals(obj) && Struct21.smethod_0((Struct21)obj, this);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000431C0 File Offset: 0x000413C0
		public override int GetHashCode()
		{
			int num = 5893 + this.keys_0.GetHashCode();
			return num * 83 + this.keys_1.GetHashCode();
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00043200 File Offset: 0x00041400
		public override string ToString()
		{
			if (this.keys_0 == Keys.None)
			{
				if (this.keys_1 == Keys.None)
				{
					return "None";
				}
				return this.keys_1.ToString();
			}
			else
			{
				if (this.keys_1 == Keys.None)
				{
					return this.keys_0.ToString();
				}
				return string.Format("{0} + {1}", this.keys_1, this.keys_0);
			}
		}

		// Token: 0x0400068D RID: 1677
		private Keys keys_0;

		// Token: 0x0400068E RID: 1678
		private Keys keys_1;
	}
}
