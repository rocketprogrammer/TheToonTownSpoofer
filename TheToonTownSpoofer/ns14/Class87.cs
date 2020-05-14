using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns17;
using ns20;
using ns21;
using ns29;

namespace ns14
{
	// Token: 0x020001D9 RID: 473
	internal sealed class Class87 : Class86
	{
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00005B69 File Offset: 0x00003D69
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					72,
					75,
					83
				};
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x00005B84 File Offset: 0x00003D84
		public Struct21 Hotkey { get; set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00005B8D File Offset: 0x00003D8D
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x00005B95 File Offset: 0x00003D95
		public Keys KeyToPress { get; set; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00005B9E File Offset: 0x00003D9E
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00005BA6 File Offset: 0x00003DA6
		public Enum108 InputEventFlags
		{
			get
			{
				return this.enum108_0;
			}
			set
			{
				value.smethod_0();
				this.enum108_0 = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00005BBA File Offset: 0x00003DBA
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00005BC2 File Offset: 0x00003DC2
		public Enum40 HotkeyType
		{
			get
			{
				return this.enum40_0;
			}
			set
			{
				value.smethod_0();
				this.enum40_0 = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00005BD6 File Offset: 0x00003DD6
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x00005BDE File Offset: 0x00003DDE
		public int KeyPressRepeatRate { get; set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00005BE7 File Offset: 0x00003DE7
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00005BEF File Offset: 0x00003DEF
		public int KeyReleaseDelay { get; set; }

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00005C00 File Offset: 0x00003E00
		public int MoveMouseRate { get; set; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00005C09 File Offset: 0x00003E09
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00005C21 File Offset: 0x00003E21
		public bool RepeatKeyPress
		{
			get
			{
				return this.InputEventFlags.HasFlag(Enum108.flag_1);
			}
			set
			{
				if (value != this.RepeatKeyPress)
				{
					switch (value)
					{
					case false:
						this.InputEventFlags &= ~Enum108.flag_1;
						break;
					case true:
						this.InputEventFlags |= Enum108.flag_1;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00005C5D File Offset: 0x00003E5D
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x00005C75 File Offset: 0x00003E75
		public bool ReleaseKey
		{
			get
			{
				return this.InputEventFlags.HasFlag(Enum108.flag_2);
			}
			set
			{
				if (value != this.ReleaseKey)
				{
					switch (value)
					{
					case false:
						this.InputEventFlags &= ~Enum108.flag_2;
						break;
					case true:
						this.InputEventFlags |= Enum108.flag_2;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00005CB1 File Offset: 0x00003EB1
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x00005CC9 File Offset: 0x00003EC9
		public bool MoveMouse
		{
			get
			{
				return this.InputEventFlags.HasFlag(Enum108.flag_3);
			}
			set
			{
				if (value != this.MoveMouse)
				{
					switch (value)
					{
					case false:
						this.InputEventFlags &= ~Enum108.flag_3;
						break;
					case true:
						this.InputEventFlags |= Enum108.flag_3;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00005D05 File Offset: 0x00003F05
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x00005D1D File Offset: 0x00003F1D
		public bool StopOtherHotkeys
		{
			get
			{
				return this.InputEventFlags.HasFlag(Enum108.flag_4);
			}
			set
			{
				if (value != this.StopOtherHotkeys)
				{
					switch (value)
					{
					case false:
						this.InputEventFlags &= ~Enum108.flag_4;
						break;
					case true:
						this.InputEventFlags |= Enum108.flag_4;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00005D59 File Offset: 0x00003F59
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00005D61 File Offset: 0x00003F61
		public string Description { get; set; }

		// Token: 0x0600157B RID: 5499 RVA: 0x00005D6A File Offset: 0x00003F6A
		public Class87()
		{
			this.HotkeyType = Enum40.const_0;
			this.InputEventFlags = Enum108.flag_0;
			this.Description = string.Empty;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class87(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00031C2C File Offset: 0x0002FE2C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Hotkey = new Struct21((Keys)reader.ReadInt32(), (Keys)reader.ReadInt32());
			this.HotkeyType = (Enum40)reader.ReadInt16();
			Enum40 hotkeyType = this.HotkeyType;
			if (hotkeyType == Enum40.const_0)
			{
				this.InputEventFlags = (Enum108)reader.ReadInt16();
				this.KeyToPress = (Keys)reader.ReadInt32();
				if (this.RepeatKeyPress)
				{
					this.KeyPressRepeatRate = reader.ReadInt32();
				}
				if (this.ReleaseKey)
				{
					this.KeyReleaseDelay = reader.ReadInt32();
				}
				if (this.MoveMouse)
				{
					this.MoveMouseRate = reader.ReadInt32();
				}
			}
			this.Description = reader.ReadString();
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((int)this.Hotkey.Key);
			writer.Write((int)this.Hotkey.Modifier);
			writer.Write((short)this.HotkeyType);
			Enum40 hotkeyType = this.HotkeyType;
			if (hotkeyType == Enum40.const_0)
			{
				writer.Write((short)this.InputEventFlags);
				writer.Write((int)this.KeyToPress);
				if (this.RepeatKeyPress)
				{
					writer.Write(this.KeyPressRepeatRate);
				}
				if (this.ReleaseKey)
				{
					writer.Write(this.KeyReleaseDelay);
				}
				if (this.MoveMouse)
				{
					writer.Write(this.MoveMouseRate);
				}
			}
			writer.Write(this.Description);
		}

		// Token: 0x040002F5 RID: 757
		private Enum108 enum108_0;

		// Token: 0x040002F6 RID: 758
		private Enum40 enum40_0;

		// Token: 0x040002F7 RID: 759
		[CompilerGenerated]
		private Struct21 struct21_0;

		// Token: 0x040002F8 RID: 760
		[CompilerGenerated]
		private Keys keys_0;

		// Token: 0x040002F9 RID: 761
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040002FA RID: 762
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040002FB RID: 763
		[CompilerGenerated]
		private int int_2;

		// Token: 0x040002FC RID: 764
		[CompilerGenerated]
		private string string_0;
	}
}
