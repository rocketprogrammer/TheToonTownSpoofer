using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns26;
using ns28;
using ns30;
using ns31;

namespace ns25
{
	// Token: 0x0200033B RID: 827
	internal sealed class Class316
	{
		// Token: 0x06002006 RID: 8198 RVA: 0x0000CF20 File Offset: 0x0000B120
		public Class316()
		{
			this.list_0 = new List<Struct44>();
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0000CF33 File Offset: 0x0000B133
		public Struct44[] method_0()
		{
			return this.list_0.ToArray();
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0000CF40 File Offset: 0x0000B140
		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0006A3D8 File Offset: 0x000685D8
		public Class316 method_1(Keys key)
		{
			Struct44 item = default(Struct44);
			item.enum18_0 = Enum18.const_1;
			item.struct32_0.struct39_0.ushort_0 = (ushort)key;
			item.struct32_0.struct39_0.intptr_0 = Class265.GetMessageExtraInfo();
			item.struct32_0.struct39_0.uint_0 = 0U;
			item.struct32_0.struct39_0.ushort_1 = 0;
			this.list_0.Add(item);
			return this;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0006A450 File Offset: 0x00068650
		public Class316 method_2(Keys key)
		{
			Struct44 item = default(Struct44);
			item.enum18_0 = Enum18.const_1;
			item.struct32_0.struct39_0.ushort_0 = (ushort)key;
			item.struct32_0.struct39_0.enum54_0 = Enum54.const_1;
			item.struct32_0.struct39_0.intptr_0 = Class265.GetMessageExtraInfo();
			item.struct32_0.struct39_0.uint_0 = 0U;
			item.struct32_0.struct39_0.ushort_1 = 0;
			this.list_0.Add(item);
			return this;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0000CF4D File Offset: 0x0000B14D
		public Class316 method_3(Keys key)
		{
			this.method_1(key);
			this.method_2(key);
			return this;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0000CF60 File Offset: 0x0000B160
		public Class316 method_4(Keys modifierKeyCode, Keys keyCode)
		{
			this.method_1(modifierKeyCode);
			this.method_3(keyCode);
			this.method_2(modifierKeyCode);
			return this;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0006A4DC File Offset: 0x000686DC
		public Class316 method_5(Point p)
		{
			Struct44 item = default(Struct44);
			item.enum18_0 = Enum18.const_0;
			item.struct32_0.struct22_0.enum129_0 = (Enum129.flag_0 | Enum129.flag_11);
			item.struct32_0.struct22_0.int_0 = p.X;
			item.struct32_0.struct22_0.int_1 = p.Y;
			this.list_0.Add(item);
			return this;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0006A54C File Offset: 0x0006874C
		public Class316 method_6(MouseButtons button)
		{
			Struct44 item = default(Struct44);
			item.enum18_0 = Enum18.const_0;
			Enum129 enum129_ = button.smethod_0(true);
			item.struct32_0.struct22_0.enum129_0 = enum129_;
			if (button != MouseButtons.XButton1)
			{
				if (button == MouseButtons.XButton2)
				{
					item.struct32_0.struct22_0.uint_0 = 2U;
				}
			}
			else
			{
				item.struct32_0.struct22_0.uint_0 = 1U;
			}
			this.list_0.Add(item);
			return this;
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0006A5CC File Offset: 0x000687CC
		public Class316 method_7(MouseButtons button)
		{
			Struct44 item = default(Struct44);
			item.enum18_0 = Enum18.const_0;
			Enum129 enum129_ = button.smethod_0(false);
			item.struct32_0.struct22_0.enum129_0 = enum129_;
			if (button != MouseButtons.XButton1)
			{
				if (button == MouseButtons.XButton2)
				{
					item.struct32_0.struct22_0.uint_0 = 2U;
				}
			}
			else
			{
				item.struct32_0.struct22_0.uint_0 = 1U;
			}
			this.list_0.Add(item);
			return this;
		}

		// Token: 0x04000C81 RID: 3201
		public static readonly int int_0 = Marshal.SizeOf(typeof(Struct44));

		// Token: 0x04000C82 RID: 3202
		private List<Struct44> list_0;
	}
}
