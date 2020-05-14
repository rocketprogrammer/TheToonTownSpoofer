using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns16;
using ns19;
using ns20;
using ns21;
using ns23;
using ns24;

namespace ns22
{
	// Token: 0x0200036B RID: 875
	internal sealed class WindowSelector : UserControl
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0007464C File Offset: 0x0007284C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WindowSelector));
			this.lblWindowTitle = new Label();
			this.btnSelector = new Button();
			this.lblTitle = new Label();
			base.SuspendLayout();
			this.lblWindowTitle.AutoEllipsis = true;
			this.lblWindowTitle.Location = new Point(69, 18);
			this.lblWindowTitle.Name = "lblWindowTitle";
			this.lblWindowTitle.Size = new Size(219, 34);
			this.lblWindowTitle.TabIndex = 1;
			this.btnSelector.Image = (Image)componentResourceManager.GetObject("btnSelector.Image");
			this.btnSelector.Location = new Point(2, 2);
			this.btnSelector.Name = "btnSelector";
			this.btnSelector.Size = new Size(56, 56);
			this.btnSelector.TabIndex = 0;
			this.btnSelector.UseVisualStyleBackColor = true;
			this.btnSelector.MouseDown += this.btnSelector_MouseDown;
			this.btnSelector.MouseMove += this.btnSelector_MouseMove;
			this.btnSelector.MouseUp += this.btnSelector_MouseUp;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new Font("Georgia", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.lblTitle.Location = new Point(62, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new Size(202, 12);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "click and drag the target onto the window";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.lblTitle);
			base.Controls.Add(this.lblWindowTitle);
			base.Controls.Add(this.btnSelector);
			base.Name = "WindowSelector";
			base.Size = new Size(305, 60);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1400019C RID: 412
		// (add) Token: 0x06002246 RID: 8774 RVA: 0x00074890 File Offset: 0x00072A90
		// (remove) Token: 0x06002247 RID: 8775 RVA: 0x000748C8 File Offset: 0x00072AC8
		public event EventHandler<EventArgs14> SelectedHandleChanged
		{
			add
			{
				EventHandler<EventArgs14> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs14> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs14> value2 = (EventHandler<EventArgs14>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs14>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs14> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs14> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs14> value2 = (EventHandler<EventArgs14>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs14>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400019D RID: 413
		// (add) Token: 0x06002248 RID: 8776 RVA: 0x00074900 File Offset: 0x00072B00
		// (remove) Token: 0x06002249 RID: 8777 RVA: 0x00074938 File Offset: 0x00072B38
		public event EventHandler BeginSelecting
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400019E RID: 414
		// (add) Token: 0x0600224A RID: 8778 RVA: 0x00074970 File Offset: 0x00072B70
		// (remove) Token: 0x0600224B RID: 8779 RVA: 0x000749A8 File Offset: 0x00072BA8
		public event EventHandler EndSelecting
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400019F RID: 415
		// (add) Token: 0x0600224C RID: 8780 RVA: 0x000749E0 File Offset: 0x00072BE0
		// (remove) Token: 0x0600224D RID: 8781 RVA: 0x00074A18 File Offset: 0x00072C18
		public event EventHandler<EventArgs15> SelectedHandleChanging
		{
			add
			{
				EventHandler<EventArgs15> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs15> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs15> value2 = (EventHandler<EventArgs15>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs15> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs15> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs15> value2 = (EventHandler<EventArgs15>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs15>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0000E663 File Offset: 0x0000C863
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x0000E66B File Offset: 0x0000C86B
		public int ResourceNumber { get; set; }

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000E674 File Offset: 0x0000C874
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x0000E681 File Offset: 0x0000C881
		public string LabelMessage
		{
			get
			{
				return this.lblTitle.Text;
			}
			set
			{
				this.lblTitle.Text = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x0000E68F File Offset: 0x0000C88F
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00074A50 File Offset: 0x00072C50
		public IntPtr SelectedWindow
		{
			get
			{
				return this.class141_0.MainWindowHandle;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				if (this.class141_0.MainWindowHandle != value)
				{
					this.class141_0.MainWindowHandle = value;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_4);
					}
					this.smethod_6(methodInvoker);
					this.method_1(value);
				}
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00074A9C File Offset: 0x00072C9C
		private bool method_0(IntPtr hWnd)
		{
			if (this.eventHandler_3 != null)
			{
				EventArgs15 eventArgs = new EventArgs15(hWnd);
				this.eventHandler_3(this, eventArgs);
				return eventArgs.IsValid;
			}
			return true;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0000E69C File Offset: 0x0000C89C
		private void method_1(IntPtr hWnd)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs14(hWnd));
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00074AD0 File Offset: 0x00072CD0
		public WindowSelector()
		{
			this.InitializeComponent();
			this.class141_0 = new Class141();
			Class141 @class = this.class141_0;
			EventHandler value = new EventHandler(this.method_5);
			@class.ProcessExited += value;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00074B10 File Offset: 0x00072D10
		protected override void OnLoad(EventArgs e)
		{
			if (!base.DesignMode)
			{
				try
				{
					this.class366_0 = new Class366(this.ResourceNumber, WindowSelector.string_4);
				}
				catch (Exception ex)
				{
					ex.smethod_0();
					this.class366_0 = null;
				}
			}
			base.OnLoad(e);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00074B64 File Offset: 0x00072D64
		protected override void Dispose(bool disposing)
		{
			Cursor.Current = Cursors.Default;
			this.method_3();
			this.class141_0.Dispose();
			if (this.class366_0 != null)
			{
				this.class366_0.Dispose();
				this.class366_0 = null;
			}
			if (this.list_0 != null)
			{
				this.list_0.Clear();
				this.list_0 = null;
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00074BE0 File Offset: 0x00072DE0
		private void btnSelector_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && this.list_0 != null)
			{
				int i = 0;
				while (i < this.list_0.Count)
				{
					KeyValuePair<IntPtr, Rectangle> keyValuePair = this.list_0[i];
					if (!keyValuePair.Value.Contains(Cursor.Position))
					{
						i++;
					}
					else
					{
						if (!(keyValuePair.Key != this.intptr_0))
						{
							break;
						}
						this.method_3();
						if (Control.FromHandle(keyValuePair.Key) == null && this.method_0(keyValuePair.Key))
						{
							Class335.smethod_3(WindowSelector.string_0, new object[]
							{
								keyValuePair.Key
							});
							this.SelectedWindow = keyValuePair.Key;
							Class335.smethod_3(WindowSelector.string_1, new object[]
							{
								this.SelectedWindow
							});
							this.method_2(keyValuePair.Key);
							return;
						}
						this.SelectedWindow = IntPtr.Zero;
						return;
					}
				}
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		private void method_2(IntPtr hWnd)
		{
			this.intptr_0 = hWnd;
			Class301.smethod_0(this.intptr_0);
			this.bool_0 = true;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0000E6D3 File Offset: 0x0000C8D3
		private void method_3()
		{
			if (this.bool_0 && this.intptr_0 != IntPtr.Zero)
			{
				Class301.smethod_1(this.intptr_0);
				this.bool_0 = false;
				this.intptr_0 = IntPtr.Zero;
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00074CEC File Offset: 0x00072EEC
		private void btnSelector_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, EventArgs.Empty);
				}
				Cursor.Current = Cursors.Default;
				this.method_3();
				Class335.smethod_3(WindowSelector.string_3, new object[]
				{
					this.SelectedWindow
				});
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00074D50 File Offset: 0x00072F50
		private void btnSelector_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Class335.smethod_2(WindowSelector.string_2, true);
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, EventArgs.Empty);
				}
				if (this.class366_0 == null)
				{
					Cursor.Current = Cursors.Cross;
				}
				else
				{
					Cursor.Current = this.class366_0.Cursor;
				}
				this.SelectedWindow = IntPtr.Zero;
				this.method_3();
				if (this.list_0 == null)
				{
					this.list_0 = new List<KeyValuePair<IntPtr, Rectangle>>();
				}
				Class410.smethod_12(this.list_0);
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0000E70C File Offset: 0x0000C90C
		[CompilerGenerated]
		private void method_4()
		{
			this.lblWindowTitle.Text = this.class141_0.MainWindowTitle;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0000E724 File Offset: 0x0000C924
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.method_1(IntPtr.Zero);
			this.smethod_6(new MethodInvoker(this.method_6));
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0000E70C File Offset: 0x0000C90C
		[CompilerGenerated]
		private void method_6()
		{
			this.lblWindowTitle.Text = this.class141_0.MainWindowTitle;
		}

		// Token: 0x04000FA9 RID: 4009
		private IContainer icontainer_0;

		// Token: 0x04000FAA RID: 4010
		private Button btnSelector;

		// Token: 0x04000FAB RID: 4011
		private Label lblWindowTitle;

		// Token: 0x04000FAC RID: 4012
		private Label lblTitle;

		// Token: 0x04000FAD RID: 4013
		private static readonly string string_0 = "ToonTown Window Candidate Before Process Wrapper";

		// Token: 0x04000FAE RID: 4014
		private static readonly string string_1 = "ToonTown Window Candidate Before Overlay";

		// Token: 0x04000FAF RID: 4015
		private static readonly string string_2 = "Window Select Beginning";

		// Token: 0x04000FB0 RID: 4016
		private static readonly string string_3 = "ToonTown Window Selection After Overlay";

		// Token: 0x04000FB1 RID: 4017
		private static readonly string string_4 = "RT_ANICURSOR";

		// Token: 0x04000FB2 RID: 4018
		private bool bool_0;

		// Token: 0x04000FB3 RID: 4019
		private Class366 class366_0;

		// Token: 0x04000FB4 RID: 4020
		private List<KeyValuePair<IntPtr, Rectangle>> list_0;

		// Token: 0x04000FB5 RID: 4021
		private Class141 class141_0;

		// Token: 0x04000FB6 RID: 4022
		private IntPtr intptr_0;

		// Token: 0x04000FB7 RID: 4023
		private EventHandler<EventArgs14> eventHandler_0;

		// Token: 0x04000FB8 RID: 4024
		private EventHandler eventHandler_1;

		// Token: 0x04000FB9 RID: 4025
		private EventHandler eventHandler_2;

		// Token: 0x04000FBA RID: 4026
		private EventHandler<EventArgs15> eventHandler_3;

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		private int int_0;
	}
}
