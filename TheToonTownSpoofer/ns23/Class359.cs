using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ns19;
using ns22;
using ns26;
using ns27;
using ns28;
using ns29;

namespace ns23
{
	// Token: 0x0200038C RID: 908
	[ToolboxItem(false)]
	internal sealed class Class359 : ToolStripDropDown
	{
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x0000F121 File Offset: 0x0000D321
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x0000F129 File Offset: 0x0000D329
		public Control Content { get; private set; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0000F132 File Offset: 0x0000D332
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0000F13A File Offset: 0x0000D33A
		public Enum70 ShowingAnimation { get; set; }

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0000F143 File Offset: 0x0000D343
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0000F14B File Offset: 0x0000D34B
		public Enum70 HidingAnimation { get; set; }

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0000F154 File Offset: 0x0000D354
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x0000F15C File Offset: 0x0000D35C
		public int AnimationDuration { get; set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0000F165 File Offset: 0x0000D365
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0000F16D File Offset: 0x0000D36D
		public bool FocusOnOpen { get; set; }

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0000F176 File Offset: 0x0000D376
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0000F17E File Offset: 0x0000D37E
		public bool AcceptAlt { get; set; }

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0000F187 File Offset: 0x0000D387
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000F19C File Offset: 0x0000D39C
		public bool Resizable
		{
			get
			{
				return this.bool_3 && !this.bool_2;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0000F1A5 File Offset: 0x0000D3A5
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0000F1AD File Offset: 0x0000D3AD
		public bool NonInteractive
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				if (value != this.bool_4)
				{
					this.bool_4 = value;
					if (base.IsHandleCreated)
					{
						base.RecreateHandle();
					}
				}
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0000F1CD File Offset: 0x0000D3CD
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0000F1D5 File Offset: 0x0000D3D5
		public new Size MinimumSize { get; set; }

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0000F1DE File Offset: 0x0000D3DE
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
		public new Size MaximumSize { get; set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x00077364 File Offset: 0x00075564
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 134217728;
				if (this.NonInteractive)
				{
					createParams.ExStyle |= 524448;
				}
				return createParams;
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x000773A8 File Offset: 0x000755A8
		public Class359(Control content)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			PaintEventHandler paintEventHandler = null;
			Class359.Class360 @class = new Class359.Class360();
			@class.control_0 = content;
			base..ctor();
			@class.class359_0 = this;
			if (@class.control_0 == null)
			{
				throw new ArgumentNullException("content");
			}
			this.Content = @class.control_0;
			this.FocusOnOpen = true;
			this.AcceptAlt = true;
			this.ShowingAnimation = Enum70.flag_9;
			this.HidingAnimation = Enum70.flag_0;
			this.AnimationDuration = 100;
			this.method_10();
			this.AutoSize = false;
			this.DoubleBuffered = true;
			base.ResizeRedraw = true;
			this.toolStripControlHost_0 = new ToolStripControlHost(@class.control_0);
			base.Padding = (base.Margin = (this.toolStripControlHost_0.Padding = (this.toolStripControlHost_0.Margin = Padding.Empty)));
			if (Class500.IsRunningOnMono)
			{
				@class.control_0.Margin = Padding.Empty;
			}
			this.MinimumSize = @class.control_0.MinimumSize;
			@class.control_0.MinimumSize = @class.control_0.Size;
			this.MaximumSize = @class.control_0.MaximumSize;
			@class.control_0.MaximumSize = @class.control_0.Size;
			base.Size = @class.control_0.Size;
			if (Class500.IsRunningOnMono)
			{
				this.toolStripControlHost_0.Size = @class.control_0.Size;
			}
			@class.control_0.TabStop = true;
			base.TabStop = true;
			@class.control_0.Location = Point.Empty;
			this.Items.Add(this.toolStripControlHost_0);
			Component component = @class.control_0;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(@class.method_0);
			}
			component.Disposed += eventHandler;
			Control control = @class.control_0;
			if (eventHandler2 == null)
			{
				eventHandler2 = new EventHandler(this.method_11);
			}
			control.RegionChanged += eventHandler2;
			Control control2 = @class.control_0;
			if (paintEventHandler == null)
			{
				paintEventHandler = new PaintEventHandler(this.method_12);
			}
			control2.Paint += paintEventHandler;
			this.method_0();
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x000775A0 File Offset: 0x000757A0
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (Class500.IsRunningOnMono)
			{
				return;
			}
			if ((base.Visible && this.ShowingAnimation == Enum70.flag_0) || (!base.Visible && this.HidingAnimation == Enum70.flag_0))
			{
				return;
			}
			Enum120 @enum = base.Visible ? Enum120.flag_0 : Enum120.flag_6;
			Enum70 enum2 = base.Visible ? this.ShowingAnimation : this.HidingAnimation;
			if (enum2 == Enum70.flag_9)
			{
				if (SystemInformation.IsMenuAnimationEnabled)
				{
					if (SystemInformation.IsMenuFadeEnabled)
					{
						enum2 = Enum70.flag_7;
					}
					else
					{
						enum2 = (Enum70.flag_6 | (base.Visible ? Enum70.flag_3 : Enum70.flag_4));
					}
				}
				else
				{
					enum2 = Enum70.flag_0;
				}
			}
			if ((enum2 & (Enum70.flag_5 | Enum70.flag_6 | Enum70.flag_7 | Enum70.flag_8)) == Enum70.flag_0)
			{
				return;
			}
			if (this.bool_0)
			{
				if ((enum2 & Enum70.flag_4) != Enum70.flag_0)
				{
					enum2 = ((enum2 & ~Enum70.flag_4) | Enum70.flag_3);
				}
				else if ((enum2 & Enum70.flag_3) != Enum70.flag_0)
				{
					enum2 = ((enum2 & ~Enum70.flag_3) | Enum70.flag_4);
				}
			}
			if (this.bool_1)
			{
				if ((enum2 & Enum70.flag_2) != Enum70.flag_0)
				{
					enum2 = ((enum2 & ~Enum70.flag_2) | Enum70.flag_1);
				}
				else if ((enum2 & Enum70.flag_1) != Enum70.flag_0)
				{
					enum2 = ((enum2 & ~Enum70.flag_1) | Enum70.flag_2);
				}
			}
			@enum |= (Enum120)((Enum70)1048575 & enum2);
			Class410.smethod_9(this);
			Class410.smethod_11(this, this.AnimationDuration, @enum);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x000776A8 File Offset: 0x000758A8
		[UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (this.AcceptAlt && (keyData & Keys.Alt) == Keys.Alt)
			{
				if ((keyData & Keys.F4) != Keys.F4)
				{
					return false;
				}
				base.Close();
			}
			bool result;
			if (!(result = base.ProcessDialogKey(keyData)) && (keyData == Keys.Tab || keyData == (Keys.LButton | Keys.Back | Keys.Shift)))
			{
				bool flag = (keyData & Keys.Shift) == Keys.Shift;
				this.Content.SelectNextControl(null, !flag, true, true, true);
			}
			return result;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0000F1EF File Offset: 0x0000D3EF
		protected void method_0()
		{
			if (base.Region != null)
			{
				base.Region.Dispose();
				base.Region = null;
			}
			if (this.Content.Region != null)
			{
				base.Region = this.Content.Region.Clone();
			}
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x0000F22E File Offset: 0x0000D42E
		public void method_1(Control control)
		{
			if (control == null)
			{
				throw new ArgumentNullException("control");
			}
			this.method_3(control, control.ClientRectangle);
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00077718 File Offset: 0x00075918
		public void method_2(Rectangle area)
		{
			this.bool_1 = false;
			this.bool_0 = false;
			Point position = new Point(area.Left, area.Top + area.Height);
			Rectangle workingArea = Screen.FromControl(this).WorkingArea;
			if (position.X + base.Size.Width > workingArea.Left + workingArea.Width)
			{
				this.bool_1 = true;
				position.X = workingArea.Left + workingArea.Width - base.Size.Width;
			}
			if (position.Y + base.Size.Height > workingArea.Top + workingArea.Height)
			{
				this.bool_0 = true;
				position.Y -= base.Size.Height + area.Height;
			}
			base.Show(position, ToolStripDropDownDirection.BelowRight);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0007780C File Offset: 0x00075A0C
		public void method_3(Control control, Rectangle area)
		{
			if (control == null)
			{
				throw new ArgumentNullException("control");
			}
			this.method_4(control);
			this.bool_1 = false;
			this.bool_0 = false;
			Point point = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
			Rectangle workingArea = Screen.FromControl(control).WorkingArea;
			if (point.X + base.Size.Width > workingArea.Left + workingArea.Width)
			{
				this.bool_1 = true;
				point.X = workingArea.Left + workingArea.Width - base.Size.Width;
			}
			if (point.Y + base.Size.Height > workingArea.Top + workingArea.Height)
			{
				this.bool_0 = true;
				point.Y -= base.Size.Height + area.Height;
			}
			point = control.PointToClient(point);
			base.Show(control, point, ToolStripDropDownDirection.BelowRight);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00077924 File Offset: 0x00075B24
		private void method_4(Control control)
		{
			if (control == null)
			{
				return;
			}
			if (control is Class359)
			{
				Class359 @class = control as Class359;
				this.class359_0 = @class;
				this.class359_0.class359_1 = this;
				base.OwnerItem = @class.Items[0];
				return;
			}
			if (this.control_0 == null)
			{
				this.control_0 = control;
			}
			if (control.Parent != null)
			{
				this.method_4(control.Parent);
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00077990 File Offset: 0x00075B90
		protected override void OnSizeChanged(EventArgs e)
		{
			if (this.Content != null)
			{
				this.Content.MinimumSize = base.Size;
				this.Content.MaximumSize = base.Size;
				this.Content.Size = base.Size;
				this.Content.Location = Point.Empty;
			}
			base.OnSizeChanged(e);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000779F0 File Offset: 0x00075BF0
		protected override void OnLayout(LayoutEventArgs e)
		{
			if (!Class500.IsRunningOnMono)
			{
				base.OnLayout(e);
				return;
			}
			Size preferredSize = this.GetPreferredSize(Size.Empty);
			if (this.AutoSize && preferredSize != base.Size)
			{
				base.Size = preferredSize;
			}
			this.SetDisplayedItems();
			this.OnLayoutCompleted(EventArgs.Empty);
			base.Invalidate();
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0000F24B File Offset: 0x0000D44B
		protected override void OnOpening(CancelEventArgs e)
		{
			if (!this.Content.IsDisposed && !this.Content.Disposing)
			{
				this.method_0();
				base.OnOpening(e);
				return;
			}
			e.Cancel = true;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0000F27C File Offset: 0x0000D47C
		protected override void OnOpened(EventArgs e)
		{
			if (this.class359_0 != null)
			{
				this.class359_0.bool_2 = true;
			}
			if (this.FocusOnOpen)
			{
				this.Content.Focus();
			}
			base.OnOpened(e);
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0000F2AD File Offset: 0x0000D4AD
		protected override void OnClosed(ToolStripDropDownClosedEventArgs e)
		{
			this.control_0 = null;
			if (this.class359_0 != null)
			{
				this.class359_0.bool_2 = false;
			}
			base.OnClosed(e);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0000F2D1 File Offset: 0x0000D4D1
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			if (this.method_6(ref m, false))
			{
				return;
			}
			base.WndProc(ref m);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x0000F2E5 File Offset: 0x0000D4E5
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public bool method_5(ref Message m)
		{
			return this.method_6(ref m, true);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00077A4C File Offset: 0x00075C4C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private bool method_6(ref Message m, bool contentControl)
		{
			int msg = m.Msg;
			if (msg == 134 && m.WParam != IntPtr.Zero && this.class359_1 != null && this.class359_1.Visible)
			{
				this.class359_1.Hide();
			}
			if (!this.Resizable && !this.NonInteractive)
			{
				return false;
			}
			int msg2 = m.Msg;
			if (msg2 != 36)
			{
				return msg2 == 132 && this.method_8(ref m, contentControl);
			}
			return this.method_7(ref m);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00077AD4 File Offset: 0x00075CD4
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private bool method_7(ref Message m)
		{
			Struct47 @struct = (Struct47)Marshal.PtrToStructure(m.LParam, typeof(Struct47));
			if (!this.MaximumSize.IsEmpty)
			{
				@struct.size_2 = this.MaximumSize;
			}
			@struct.size_1 = this.MinimumSize;
			Marshal.StructureToPtr(@struct, m.LParam, false);
			return true;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00077B3C File Offset: 0x00075D3C
		private bool method_8(ref Message m, bool contentControl)
		{
			if (this.NonInteractive)
			{
				m.Result = (IntPtr)(-1L);
				return true;
			}
			int x = Cursor.Position.X;
			int y = Cursor.Position.Y;
			Point pt = base.PointToClient(new Point(x, y));
			Struct57 @struct = new Struct57(contentControl ? this.Content.ClientRectangle : base.ClientRectangle);
			IntPtr intPtr = new IntPtr(-1);
			if (this.bool_0)
			{
				if (this.bool_1 && @struct.TopLeft.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)13L));
					return true;
				}
				if (!this.bool_1 && @struct.TopRight.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)14L));
					return true;
				}
				if (@struct.Top.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)12L));
					return true;
				}
			}
			else
			{
				if (this.bool_1 && @struct.BottomLeft.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)16L));
					return true;
				}
				if (!this.bool_1 && @struct.BottomRight.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)17L));
					return true;
				}
				if (@struct.Bottom.Contains(pt))
				{
					m.Result = (contentControl ? intPtr : ((IntPtr)15L));
					return true;
				}
			}
			if (this.bool_1 && @struct.Left.Contains(pt))
			{
				m.Result = (contentControl ? intPtr : ((IntPtr)10L));
				return true;
			}
			if (!this.bool_1 && @struct.Right.Contains(pt))
			{
				m.Result = (contentControl ? intPtr : ((IntPtr)11L));
				return true;
			}
			return false;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00077D78 File Offset: 0x00075F78
		public void method_9(PaintEventArgs e)
		{
			if (e != null && e.Graphics != null && this.bool_3)
			{
				Size clientSize = this.Content.ClientSize;
				using (Bitmap bitmap = new Bitmap(16, 16))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						if (Application.RenderWithVisualStyles)
						{
							if (this.visualStyleRenderer_0 == null)
							{
								this.visualStyleRenderer_0 = new VisualStyleRenderer(VisualStyleElement.Status.Gripper.Normal);
							}
							this.visualStyleRenderer_0.DrawBackground(graphics, new Rectangle(0, 0, 16, 16));
						}
						else
						{
							ControlPaint.DrawSizeGrip(graphics, this.Content.BackColor, 0, 0, 16, 16);
						}
					}
					GraphicsState gstate = e.Graphics.Save();
					e.Graphics.ResetTransform();
					if (this.bool_0)
					{
						if (this.bool_1)
						{
							e.Graphics.RotateTransform(180f);
							e.Graphics.TranslateTransform((float)(-(float)clientSize.Width), (float)(-(float)clientSize.Height));
						}
						else
						{
							e.Graphics.ScaleTransform(1f, -1f);
							e.Graphics.TranslateTransform(0f, (float)(-(float)clientSize.Height));
						}
					}
					else if (this.bool_1)
					{
						e.Graphics.ScaleTransform(-1f, 1f);
						e.Graphics.TranslateTransform((float)(-(float)clientSize.Width), 0f);
					}
					e.Graphics.DrawImage(bitmap, clientSize.Width - 16, clientSize.Height - 16 + 1, 16, 16);
					e.Graphics.Restore(gstate);
				}
				return;
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00077F48 File Offset: 0x00076148
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
				if (this.Content != null)
				{
					Control content = this.Content;
					this.Content = null;
					content.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0000F2EF File Offset: 0x0000D4EF
		private void method_10()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		[CompilerGenerated]
		private void method_11(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0000F304 File Offset: 0x0000D504
		[CompilerGenerated]
		private void method_12(object sender, PaintEventArgs e)
		{
			this.method_9(e);
		}

		// Token: 0x04001042 RID: 4162
		private ToolStripControlHost toolStripControlHost_0;

		// Token: 0x04001043 RID: 4163
		private Control control_0;

		// Token: 0x04001044 RID: 4164
		private Class359 class359_0;

		// Token: 0x04001045 RID: 4165
		private Class359 class359_1;

		// Token: 0x04001046 RID: 4166
		private bool bool_0;

		// Token: 0x04001047 RID: 4167
		private bool bool_1;

		// Token: 0x04001048 RID: 4168
		private bool bool_2;

		// Token: 0x04001049 RID: 4169
		private bool bool_3;

		// Token: 0x0400104A RID: 4170
		private bool bool_4;

		// Token: 0x0400104B RID: 4171
		private VisualStyleRenderer visualStyleRenderer_0;

		// Token: 0x0400104C RID: 4172
		private IContainer icontainer_0;

		// Token: 0x0400104D RID: 4173
		[CompilerGenerated]
		private Control control_1;

		// Token: 0x0400104E RID: 4174
		[CompilerGenerated]
		private Enum70 enum70_0;

		// Token: 0x0400104F RID: 4175
		[CompilerGenerated]
		private Enum70 enum70_1;

		// Token: 0x04001050 RID: 4176
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04001051 RID: 4177
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04001052 RID: 4178
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04001053 RID: 4179
		[CompilerGenerated]
		private Size size_0;

		// Token: 0x04001054 RID: 4180
		[CompilerGenerated]
		private Size size_1;

		// Token: 0x0200038D RID: 909
		[CompilerGenerated]
		private sealed class Class360
		{
			// Token: 0x06002387 RID: 9095 RVA: 0x0000F30D File Offset: 0x0000D50D
			public void method_0(object sender, EventArgs e)
			{
				this.control_0 = null;
				this.class359_0.Dispose(true);
			}

			// Token: 0x04001055 RID: 4181
			public Class359 class359_0;

			// Token: 0x04001056 RID: 4182
			public Control control_0;
		}
	}
}
