using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ns21
{
	// Token: 0x0200023D RID: 573
	internal abstract class Class180 : TextBox
	{
		// Token: 0x0600187A RID: 6266 RVA: 0x000427C8 File Offset: 0x000409C8
		public Class180()
		{
			this.contextMenu_0 = new ContextMenu();
			Menu.MenuItemCollection menuItems = this.contextMenu_0.MenuItems;
			string text = Class180.string_0;
			EventHandler onClick = new EventHandler(this.method_0);
			menuItems.Add(this.menuItem_0 = new MenuItem(text, onClick));
			this.contextMenu_0.MenuItems.Add(new MenuItem(Class180.string_5));
			this.contextMenu_0.MenuItems.Add(this.menuItem_1 = new MenuItem(Class180.string_1));
			Menu.MenuItemCollection menuItems2 = this.contextMenu_0.MenuItems;
			string text2 = Class180.string_2;
			EventHandler onClick2 = new EventHandler(this.method_1);
			menuItems2.Add(this.menuItem_2 = new MenuItem(text2, onClick2));
			Menu.MenuItemCollection menuItems3 = this.contextMenu_0.MenuItems;
			string text3 = Class180.string_3;
			EventHandler onClick3 = new EventHandler(this.method_2);
			menuItems3.Add(this.menuItem_3 = new MenuItem(text3, onClick3));
			this.contextMenu_0.MenuItems.Add(this.menuItem_4 = new MenuItem(Class180.string_4));
			ContextMenu contextMenu = this.contextMenu_0;
			EventHandler value = new EventHandler(this.method_3);
			contextMenu.Popup += value;
			base.ContextMenu = this.contextMenu_0;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00042918 File Offset: 0x00040B18
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public override bool PreProcessMessage(ref Message msg)
		{
			int msg2 = msg.Msg;
			if (msg2 == 256)
			{
				Keys keys = (Keys)msg.WParam.ToInt32();
				Keys keys2 = keys;
				if (keys2 > Keys.C)
				{
					switch (keys2)
					{
					case Keys.V:
						return Control.ModifierKeys != Keys.Control || !this.vmethod_0();
					case Keys.W:
					case Keys.Y:
					case Keys.LWin:
					case Keys.RWin:
					case Keys.Apps:
					case (Keys)94:
					case Keys.Sleep:
					case Keys.Multiply:
					case Keys.Add:
					case Keys.Separator:
						return true;
					case Keys.X:
						return true;
					case Keys.Z:
						return Control.ModifierKeys != Keys.Control;
					case Keys.NumPad0:
					case Keys.NumPad1:
					case Keys.NumPad2:
					case Keys.NumPad3:
					case Keys.NumPad4:
					case Keys.NumPad5:
					case Keys.NumPad6:
					case Keys.NumPad7:
					case Keys.NumPad8:
					case Keys.NumPad9:
						goto IL_192;
					case Keys.Subtract:
						break;
					case Keys.Decimal:
						return true;
					default:
						switch (keys2)
						{
						case Keys.OemMinus:
							break;
						case Keys.OemPeriod:
							return true;
						default:
							if (keys2 == Keys.Control)
							{
								return false;
							}
							return true;
						}
						break;
					}
					return !this.vmethod_1() || base.SelectionStart != 0 || base.Text.IndexOf('-') != -1 || !this.vmethod_2(keys);
				}
				switch (keys2)
				{
				case Keys.Back:
					goto IL_192;
				case Keys.Tab:
					break;
				default:
					if (keys2 != Keys.Return)
					{
						switch (keys2)
						{
						case Keys.Left:
						case Keys.Up:
						case Keys.Right:
						case Keys.Down:
							break;
						case Keys.Select:
						case Keys.Print:
						case Keys.Execute:
						case Keys.Snapshot:
						case Keys.Insert:
						case Keys.Help:
						case Keys.RButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case Keys.LButton | Keys.RButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case Keys.LButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case Keys.RButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case Keys.LButton | Keys.RButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space:
						case (Keys)64:
						case Keys.B:
							return true;
						case Keys.Delete:
						case Keys.D0:
						case Keys.D1:
						case Keys.D2:
						case Keys.D3:
						case Keys.D4:
						case Keys.D5:
						case Keys.D6:
						case Keys.D7:
						case Keys.D8:
						case Keys.D9:
							goto IL_192;
						case Keys.A:
						case Keys.C:
							return Control.ModifierKeys != Keys.Control;
						default:
							return true;
						}
					}
					break;
				}
				return false;
				IL_192:
				return !this.vmethod_2(keys);
			}
			return base.PreProcessMessage(ref msg);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00042AFC File Offset: 0x00040CFC
		[DebuggerStepThrough]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
			case 768:
			case 771:
				break;
			default:
				base.WndProc(ref m);
				break;
			case 770:
				if (this.vmethod_0())
				{
					base.WndProc(ref m);
					return;
				}
				m.Result = (IntPtr)0;
				return;
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00007EEA File Offset: 0x000060EA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.contextMenu_0 != null)
			{
				this.contextMenu_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual bool vmethod_0()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual bool vmethod_1()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual bool vmethod_2(Keys key)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00007F09 File Offset: 0x00006109
		[CompilerGenerated]
		private void method_0(object sender, EventArgs e)
		{
			base.Undo();
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00007F11 File Offset: 0x00006111
		[CompilerGenerated]
		private void method_1(object sender, EventArgs e)
		{
			base.Copy();
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00007F19 File Offset: 0x00006119
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			base.Paste();
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00042B54 File Offset: 0x00040D54
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			this.menuItem_0.Enabled = base.CanUndo;
			this.menuItem_1.Enabled = false;
			this.menuItem_2.Enabled = (this.SelectedText != string.Empty);
			this.menuItem_3.Enabled = this.vmethod_0();
			this.menuItem_4.Enabled = false;
		}

		// Token: 0x0400067A RID: 1658
		private static readonly string string_0 = "&Undo";

		// Token: 0x0400067B RID: 1659
		private static readonly string string_1 = "Cu&t";

		// Token: 0x0400067C RID: 1660
		private static readonly string string_2 = "&Copy";

		// Token: 0x0400067D RID: 1661
		private static readonly string string_3 = "&Paste";

		// Token: 0x0400067E RID: 1662
		private static readonly string string_4 = "&Delete";

		// Token: 0x0400067F RID: 1663
		private static readonly string string_5 = "-";

		// Token: 0x04000680 RID: 1664
		private ContextMenu contextMenu_0;

		// Token: 0x04000681 RID: 1665
		private MenuItem menuItem_0;

		// Token: 0x04000682 RID: 1666
		private MenuItem menuItem_1;

		// Token: 0x04000683 RID: 1667
		private MenuItem menuItem_2;

		// Token: 0x04000684 RID: 1668
		private MenuItem menuItem_3;

		// Token: 0x04000685 RID: 1669
		private MenuItem menuItem_4;
	}
}
