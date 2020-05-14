using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns17;
using ns21;
using ns22;
using ns23;
using ns29;
using ns31;

namespace ns27
{
	// Token: 0x0200048F RID: 1167
	internal sealed class Class112 : Class86
	{
		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		protected override int? Version
		{
			get
			{
				return new int?(3);
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		protected override int MaximumVersion
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000A918C File Offset: 0x000A738C
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					65,
					83
				};
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x0001430D File Offset: 0x0001250D
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x00014315 File Offset: 0x00012515
		public bool UseVisualMode { get; set; }

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x0001431E File Offset: 0x0001251E
		// (set) Token: 0x06002B69 RID: 11113 RVA: 0x00014326 File Offset: 0x00012526
		public bool HotkeysEnabled { get; set; }

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x0001432F File Offset: 0x0001252F
		// (set) Token: 0x06002B6B RID: 11115 RVA: 0x00014337 File Offset: 0x00012537
		public Dictionary<Struct21, Class87> Hotkeys { get; private set; }

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x00014340 File Offset: 0x00012540
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x00014348 File Offset: 0x00012548
		public Enum78 UpdateType { get; set; }

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x00014351 File Offset: 0x00012551
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00014371 File Offset: 0x00012571
		public string ScreenshotSaveDirectory
		{
			get
			{
				if (!Directory.Exists(this.string_0))
				{
					this.string_0 = Class291.ScreenshotSaveDirectory;
				}
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0001437A File Offset: 0x0001257A
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x00014382 File Offset: 0x00012582
		public bool AcceptedContentPackAgreement { get; set; }

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x0001438B File Offset: 0x0001258B
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x00014393 File Offset: 0x00012593
		public bool FirstTimeOpeningContentPacks { get; set; }

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0001439C File Offset: 0x0001259C
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x000143A4 File Offset: 0x000125A4
		public bool DisplayNotifyBalloon { get; set; }

		// Token: 0x06002B76 RID: 11126 RVA: 0x000A91AC File Offset: 0x000A73AC
		public Class112()
		{
			this.Hotkeys = new Dictionary<Struct21, Class87>();
			this.UpdateType = Enum78.const_0;
			this.UseVisualMode = true;
			this.HotkeysEnabled = true;
			this.AcceptedContentPackAgreement = false;
			this.ScreenshotSaveDirectory = Class291.ScreenshotSaveDirectory;
			this.FirstTimeOpeningContentPacks = true;
			this.DisplayNotifyBalloon = true;
			this.method_4();
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class112(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000143AD File Offset: 0x000125AD
		public void method_4()
		{
			this.Hotkeys.Clear();
			this.method_10();
			this.method_11();
			this.method_9();
			this.method_6();
			this.method_5();
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000A9208 File Offset: 0x000A7408
		private void method_5()
		{
			Class87 @class = new Class87();
			@class.Hotkey = new Struct21(Keys.NumPad8, Keys.None);
			@class.KeyToPress = Keys.Up;
			@class.HotkeyType = Enum40.const_0;
			@class.KeyPressRepeatRate = 32;
			@class.RepeatKeyPress = true;
			@class.StopOtherHotkeys = true;
			@class.MoveMouse = false;
			@class.MoveMouseRate = 0;
			@class.ReleaseKey = false;
			@class.KeyReleaseDelay = 0;
			@class.Description = "This hotkey enables automatic running.";
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000A9288 File Offset: 0x000A7488
		private void method_6()
		{
			Class87 @class = new Class87();
			@class.Hotkey = new Struct21(Keys.NumPad0, Keys.None);
			@class.KeyToPress = Keys.Up;
			@class.HotkeyType = Enum40.const_0;
			@class.KeyPressRepeatRate = 32;
			@class.RepeatKeyPress = true;
			@class.StopOtherHotkeys = true;
			@class.MoveMouse = false;
			@class.MoveMouseRate = 0;
			@class.ReleaseKey = false;
			@class.KeyReleaseDelay = 0;
			@class.Description = "This hotkey enables automatic running.";
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000A9308 File Offset: 0x000A7508
		private Class87 method_7()
		{
			return new Class87
			{
				Hotkey = new Struct21(Keys.None, Keys.Alt),
				KeyToPress = Keys.Up,
				HotkeyType = Enum40.const_0,
				KeyPressRepeatRate = 32,
				RepeatKeyPress = true,
				StopOtherHotkeys = true,
				MoveMouse = false,
				MoveMouseRate = 0,
				ReleaseKey = false,
				KeyReleaseDelay = 0,
				Description = "This hotkey enables automatic running."
			};
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000A937C File Offset: 0x000A757C
		private void method_8()
		{
			Class87 @class = this.method_7();
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000A93A4 File Offset: 0x000A75A4
		private void method_9()
		{
			Class87 @class = new Class87();
			@class.Hotkey = new Struct21(Keys.NumPad1, Keys.None);
			@class.KeyToPress = Keys.Control;
			@class.HotkeyType = Enum40.const_0;
			@class.KeyPressRepeatRate = 32;
			@class.RepeatKeyPress = true;
			@class.StopOtherHotkeys = true;
			@class.MoveMouse = false;
			@class.MoveMouseRate = 0;
			@class.ReleaseKey = false;
			@class.KeyReleaseDelay = 0;
			@class.Description = "This hotkey enables automatic jumping.";
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000A9428 File Offset: 0x000A7628
		private void method_10()
		{
			Class87 @class = new Class87();
			@class.Hotkey = new Struct21(Keys.F4, Keys.None);
			@class.KeyToPress = Keys.End;
			@class.HotkeyType = Enum40.const_0;
			@class.KeyPressRepeatRate = 10000;
			@class.RepeatKeyPress = true;
			@class.StopOtherHotkeys = true;
			@class.MoveMouse = true;
			@class.MoveMouseRate = 30000;
			@class.ReleaseKey = true;
			@class.KeyReleaseDelay = 5000;
			@class.Description = "This hotkey keeps your toon awake.";
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000A94B4 File Offset: 0x000A76B4
		private void method_11()
		{
			Class87 @class = new Class87();
			@class.Hotkey = new Struct21(Keys.F2, Keys.None);
			@class.KeyToPress = Keys.None;
			@class.HotkeyType = Enum40.const_1;
			@class.RepeatKeyPress = false;
			@class.StopOtherHotkeys = false;
			@class.MoveMouse = false;
			@class.MoveMouseRate = 0;
			@class.ReleaseKey = false;
			@class.KeyReleaseDelay = 0;
			@class.Description = "This hotkey tabs to the next ToonTown window.";
			this.Hotkeys.Add(@class.Hotkey, @class);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000A952C File Offset: 0x000A772C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Hotkeys = new Dictionary<Struct21, Class87>();
			reader.ReadString();
			new Struct55(reader.ReadUInt64());
			reader.ReadString();
			reader.smethod_30();
			this.UpdateType = (Enum78)reader.ReadInt32();
			this.UseVisualMode = reader.ReadBoolean();
			this.HotkeysEnabled = reader.ReadBoolean();
			this.ScreenshotSaveDirectory = reader.ReadString();
			this.AcceptedContentPackAgreement = reader.ReadBoolean();
			this.FirstTimeOpeningContentPacks = reader.ReadBoolean();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Class87 @class = new Class87(reader);
				this.Hotkeys.Add(@class.Hotkey, @class);
			}
			if (version == 1)
			{
				Class87 class2 = this.method_7();
				if (this.Hotkeys.ContainsKey(class2.Hotkey))
				{
					Class87 second = this.Hotkeys[class2.Hotkey];
					if (Class112.smethod_0(class2, second))
					{
						this.Hotkeys.Remove(class2.Hotkey);
						return;
					}
				}
			}
			else
			{
				if (version > 2)
				{
					this.DisplayNotifyBalloon = reader.ReadBoolean();
					return;
				}
				this.DisplayNotifyBalloon = true;
			}
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000A9644 File Offset: 0x000A7844
		private static bool smethod_0(Class87 first, Class87 second)
		{
			return first.Description == second.Description && first.HotkeyType == second.HotkeyType && first.InputEventFlags == second.InputEventFlags && first.KeyPressRepeatRate == second.KeyPressRepeatRate && first.KeyReleaseDelay == second.KeyReleaseDelay && first.KeyToPress == second.KeyToPress && first.MoveMouse == second.MoveMouse && first.MoveMouseRate == second.MoveMouseRate && first.ReleaseKey == second.ReleaseKey && first.RepeatKeyPress == second.RepeatKeyPress && first.StopOtherHotkeys == second.StopOtherHotkeys;
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000A96F8 File Offset: 0x000A78F8
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(string.Empty);
			writer.Write(Struct55.smethod_5(Struct55.struct55_0));
			writer.Write(string.Empty);
			writer.smethod_31(DateTime.Now);
			writer.Write((int)this.UpdateType);
			writer.Write(this.UseVisualMode);
			writer.Write(this.HotkeysEnabled);
			writer.Write(this.ScreenshotSaveDirectory);
			writer.Write(this.AcceptedContentPackAgreement);
			writer.Write(this.FirstTimeOpeningContentPacks);
			writer.Write(this.Hotkeys.Count);
			foreach (Class87 @class in this.Hotkeys.Values)
			{
				@class.method_3(writer);
			}
			writer.Write(this.DisplayNotifyBalloon);
		}

		// Token: 0x040016F8 RID: 5880
		private string string_0;

		// Token: 0x040016F9 RID: 5881
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040016FA RID: 5882
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040016FB RID: 5883
		[CompilerGenerated]
		private Dictionary<Struct21, Class87> dictionary_0;

		// Token: 0x040016FC RID: 5884
		[CompilerGenerated]
		private Enum78 enum78_0;

		// Token: 0x040016FD RID: 5885
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040016FE RID: 5886
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040016FF RID: 5887
		[CompilerGenerated]
		private bool bool_4;
	}
}
