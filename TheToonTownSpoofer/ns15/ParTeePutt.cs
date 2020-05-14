using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns19;
using ns20;
using ns27;
using ns28;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x0200022B RID: 555
	internal sealed partial class ParTeePutt : Form
	{
		// Token: 0x060017FC RID: 6140 RVA: 0x00007A44 File Offset: 0x00005C44
		public ParTeePutt()
		{
			this.InitializeComponent();
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00040C7C File Offset: 0x0003EE7C
		private void DrawGuideLineButton_Click(object sender, EventArgs e)
		{
			Action action = null;
			Action action2 = null;
			Action action3 = null;
			Action action4 = null;
			FormClosedEventHandler formClosedEventHandler = null;
			FormClosingEventHandler formClosingEventHandler = null;
			FormClosedEventHandler formClosedEventHandler2 = null;
			this.toonTownParentForm_0 = ToonTownParentForm.smethod_2(this);
			if (this.toonTownParentForm_0 != null)
			{
				ParTeePutt.Class173 @class = new ParTeePutt.Class173();
				@class.parTeePutt_0 = this;
				base.Hide();
				this.parTeePuttGuideLine_0 = new ParTeePuttGuideLine();
				ParTeePutt.Class173 class2 = @class;
				if (action == null)
				{
					action = new Action(this.method_0);
				}
				class2.action_0 = action;
				ParTeePutt.Class173 class3 = @class;
				if (action2 == null)
				{
					action2 = new Action(this.method_1);
				}
				class3.action_1 = action2;
				ParTeePutt.Class173 class4 = @class;
				if (action3 == null)
				{
					action3 = new Action(this.method_2);
				}
				class4.action_2 = action3;
				ParTeePutt.Class173 class5 = @class;
				if (action4 == null)
				{
					action4 = new Action(this.method_3);
				}
				class5.action_3 = action4;
				Form form = this.parTeePuttGuideLine_0;
				if (formClosedEventHandler == null)
				{
					formClosedEventHandler = new FormClosedEventHandler(this.method_4);
				}
				form.FormClosed += formClosedEventHandler;
				this.toonTownParentForm_0.LocationChanged += @class.method_0;
				this.toonTownParentForm_0.SizeChanged += @class.method_1;
				this.toonTownParentForm_0.OnResizeStarted += @class.method_2;
				this.toonTownParentForm_0.OnResizeEnded += @class.method_3;
				this.toonTownParentForm_0.WindowStateChanged += @class.method_4;
				Form form2 = this.toonTownParentForm_0;
				if (formClosingEventHandler == null)
				{
					formClosingEventHandler = new FormClosingEventHandler(this.method_5);
				}
				form2.FormClosing += formClosingEventHandler;
				Form form3 = this.toonTownParentForm_0;
				if (formClosedEventHandler2 == null)
				{
					formClosedEventHandler2 = new FormClosedEventHandler(this.method_6);
				}
				form3.FormClosed += formClosedEventHandler2;
				this.toonTownParentForm_0.GotFocus += @class.method_5;
				this.toonTownParentForm_0.LostFocus += @class.method_6;
				@class.action_0();
				@class.action_1();
				this.parTeePuttGuideLine_0.TopMost = true;
				this.parTeePuttGuideLine_0.Show();
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00007A52 File Offset: 0x00005C52
		private void ParTeePutt_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.toonTownParentForm_0 != null)
			{
				this.toonTownParentForm_0.Close();
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00007A67 File Offset: 0x00005C67
		private void ParTeePutt_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_28);
			e.Handled = true;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00007A77 File Offset: 0x00005C77
		[CompilerGenerated]
		private void method_0()
		{
			this.parTeePuttGuideLine_0.Size = ParTeePutt.struct41_0.method_0(this.toonTownParentForm_0.ClientSize);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00040E5C File Offset: 0x0003F05C
		[CompilerGenerated]
		private void method_1()
		{
			Rectangle rectangle = Class410.smethod_16(this.toonTownParentForm_0.Handle);
			this.parTeePuttGuideLine_0.Location = new Point(rectangle.Location.X + (rectangle.Width / 2 - this.parTeePuttGuideLine_0.Width / 2), rectangle.Location.Y + ParTeePutt.struct51_0.method_0(rectangle.Height));
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00007A99 File Offset: 0x00005C99
		[CompilerGenerated]
		private void method_2()
		{
			Class265.ShowWindow(new HandleRef(this, this.parTeePuttGuideLine_0.Handle), Enum117.const_11);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00007AB3 File Offset: 0x00005CB3
		[CompilerGenerated]
		private void method_3()
		{
			Class265.ShowWindow(new HandleRef(this, this.parTeePuttGuideLine_0.Handle), Enum117.const_1);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00007ACD File Offset: 0x00005CCD
		[CompilerGenerated]
		private void method_4(object sender, FormClosedEventArgs e)
		{
			this.parTeePuttGuideLine_0.Dispose();
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00007ADA File Offset: 0x00005CDA
		[CompilerGenerated]
		private void method_5(object sender, FormClosingEventArgs e)
		{
			base.Close();
			this.parTeePuttGuideLine_0.Close();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00007AED File Offset: 0x00005CED
		[CompilerGenerated]
		private void method_6(object sender, FormClosedEventArgs e)
		{
			this.toonTownParentForm_0.Dispose();
		}

		// Token: 0x04000600 RID: 1536
		private ToonTownParentForm toonTownParentForm_0;

		// Token: 0x04000601 RID: 1537
		private ParTeePuttGuideLine parTeePuttGuideLine_0;

		// Token: 0x04000602 RID: 1538
		private static Struct41 struct41_0 = Struct41.smethod_2(new Size(12, 430), new Size(800, 600));

		// Token: 0x04000603 RID: 1539
		private static Struct51 struct51_0 = Struct51.smethod_2(32, 600);

		// Token: 0x0200022C RID: 556
		[CompilerGenerated]
		private sealed class Class173
		{
			// Token: 0x06001809 RID: 6153 RVA: 0x00007B32 File Offset: 0x00005D32
			public void method_0(object sender, EventArgs e)
			{
				this.action_1();
			}

			// Token: 0x0600180A RID: 6154 RVA: 0x00007B3F File Offset: 0x00005D3F
			public void method_1(object sender, EventArgs e)
			{
				this.action_0();
				this.action_1();
			}

			// Token: 0x0600180B RID: 6155 RVA: 0x00007B57 File Offset: 0x00005D57
			public void method_2(object sender, EventArgs e)
			{
				this.action_3();
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x00007B64 File Offset: 0x00005D64
			public void method_3(object sender, EventArgs e)
			{
				this.action_2();
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x00040ED4 File Offset: 0x0003F0D4
			public void method_4(object sender, EventArgs e)
			{
				switch (this.parTeePutt_0.toonTownParentForm_0.WindowState)
				{
				case FormWindowState.Normal:
				case FormWindowState.Maximized:
					this.action_2();
					return;
				case FormWindowState.Minimized:
					this.action_3();
					return;
				default:
					return;
				}
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x00007B64 File Offset: 0x00005D64
			public void method_5(object sender, EventArgs e)
			{
				this.action_2();
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x00007B57 File Offset: 0x00005D57
			public void method_6(object sender, EventArgs e)
			{
				this.action_3();
			}

			// Token: 0x04000604 RID: 1540
			public Action action_0;

			// Token: 0x04000605 RID: 1541
			public Action action_1;

			// Token: 0x04000606 RID: 1542
			public Action action_2;

			// Token: 0x04000607 RID: 1543
			public Action action_3;

			// Token: 0x04000608 RID: 1544
			public ParTeePutt parTeePutt_0;
		}
	}
}
