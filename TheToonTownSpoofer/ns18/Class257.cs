using System;
using System.Windows.Forms;
using ns21;

namespace ns18
{
	// Token: 0x020002C7 RID: 711
	internal sealed class Class257 : TextBox
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0000AA4C File Offset: 0x00008C4C
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0000AA54 File Offset: 0x00008C54
		public Struct21 Hotkey
		{
			get
			{
				return this.struct21_0;
			}
			set
			{
				if (Struct21.smethod_1(this.struct21_0, value))
				{
					this.struct21_0 = value;
					this.method_2();
				}
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0000AA71 File Offset: 0x00008C71
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0000AA7E File Offset: 0x00008C7E
		public Keys Key
		{
			get
			{
				return this.struct21_0.Key;
			}
			set
			{
				this.struct21_0.Key = value;
				this.method_2();
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0000AA92 File Offset: 0x00008C92
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0000AA9F File Offset: 0x00008C9F
		public Keys Modifiers
		{
			get
			{
				return this.struct21_0.Modifier;
			}
			set
			{
				if (this.struct21_0.Modifier != value)
				{
					this.struct21_0.Modifier = value;
					this.method_2();
				}
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0000AAC1 File Offset: 0x00008CC1
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0000AAC9 File Offset: 0x00008CC9
		public override ContextMenu ContextMenu
		{
			get
			{
				return this.contextMenu_0;
			}
			set
			{
				base.ContextMenu = this.contextMenu_0;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x0000AAD7 File Offset: 0x00008CD7
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00007F7D File Offset: 0x0000617D
		public override bool Multiline
		{
			get
			{
				return base.Multiline;
			}
			set
			{
				base.Multiline = false;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00008035 File Offset: 0x00006235
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0000AADF File Offset: 0x00008CDF
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				base.SelectionStart = this.Text.Length;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0000AAF9 File Offset: 0x00008CF9
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0000AB01 File Offset: 0x00008D01
		public bool MultipleKeys
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
					this.method_0();
					this.method_2();
				}
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0005BB74 File Offset: 0x00059D74
		private void method_0()
		{
			if (!this.MultipleKeys && this.struct21_0.Modifier != Keys.None)
			{
				if (this.struct21_0.Modifier.HasFlag(Keys.Control))
				{
					this.struct21_0.Modifier = Keys.Control;
					this.struct21_0.Key = Keys.None;
					return;
				}
				if (this.struct21_0.Modifier.HasFlag(Keys.Alt))
				{
					this.struct21_0.Modifier = Keys.Alt;
					this.struct21_0.Key = Keys.None;
					return;
				}
				if (this.struct21_0.Modifier.HasFlag(Keys.Shift))
				{
					this.struct21_0.Modifier = Keys.Shift;
					this.struct21_0.Key = Keys.None;
				}
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0005BC58 File Offset: 0x00059E58
		public Class257()
		{
			this.ContextMenu = this.contextMenu_0;
			this.Text = "None";
			this.MultipleKeys = true;
			base.KeyPress += this.Class257_KeyPress;
			base.KeyDown += this.Class257_KeyDown;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000AB1F File Offset: 0x00008D1F
		public void method_1()
		{
			this.Key = Keys.None;
			this.Modifiers = Keys.None;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000AB2F File Offset: 0x00008D2F
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData != Keys.Delete)
			{
				if (keyData != (Keys.RButton | Keys.MButton | Keys.Back | Keys.Space | Keys.Control))
				{
					return keyData == (Keys.LButton | Keys.MButton | Keys.Back | Keys.Space | Keys.Shift) || base.ProcessCmdKey(ref msg, keyData);
				}
			}
			this.ResetHotkey();
			return true;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0005BCC4 File Offset: 0x00059EC4
		private void Class257_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Back)
			{
				if (e.KeyCode != Keys.Delete)
				{
					this.struct21_0.Modifier = e.Modifiers;
					this.struct21_0.Key = e.KeyCode;
					this.method_0();
					this.method_2();
					return;
				}
			}
			this.ResetHotkey();
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0000AB5A File Offset: 0x00008D5A
		private void Class257_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0000AB63 File Offset: 0x00008D63
		public void ResetHotkey()
		{
			this.struct21_0.Key = Keys.None;
			this.struct21_0.Modifier = Keys.None;
			this.method_2();
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0000AB83 File Offset: 0x00008D83
		private void method_2()
		{
			this.Text = this.struct21_0.ToString();
		}

		// Token: 0x04000A2A RID: 2602
		private Struct21 struct21_0 = default(Struct21);

		// Token: 0x04000A2B RID: 2603
		private ContextMenu contextMenu_0 = new ContextMenu();

		// Token: 0x04000A2C RID: 2604
		private bool bool_0;
	}
}
