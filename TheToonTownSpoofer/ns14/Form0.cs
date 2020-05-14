using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns15;
using ns17;
using ns19;
using ns22;
using ns23;
using ns29;
using ns30;
using ns31;

namespace ns14
{
	// Token: 0x020001CB RID: 459
	internal partial class Form0 : Form
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00005587 File Offset: 0x00003787
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0002A080 File Offset: 0x00028280
		public bool EnableCloseButton
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
					if (base.IsHandleCreated)
					{
						IntPtr systemMenu = Class265.GetSystemMenu(base.Handle, false);
						Enum134 @enum = Enum134.const_0;
						if (this.bool_0)
						{
							@enum = @enum;
						}
						else
						{
							@enum |= (Enum134)3U;
						}
						Class265.EnableMenuItem(systemMenu, Enum71.const_0, @enum);
					}
				}
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0000558F File Offset: 0x0000378F
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00005597 File Offset: 0x00003797
		public virtual bool UseOpacity
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				if (this.bool_3 == value)
				{
					return;
				}
				this.bool_3 = value;
				if (base.IsHandleCreated)
				{
					base.RecreateHandle();
				}
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000055B8 File Offset: 0x000037B8
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000055C0 File Offset: 0x000037C0
		public bool CustomPainting
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				if (this.bool_4 == value)
				{
					return;
				}
				this.bool_4 = value;
				if (base.IsHandleCreated)
				{
					base.RecreateHandle();
				}
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000055E1 File Offset: 0x000037E1
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x000055E9 File Offset: 0x000037E9
		public bool AllowFormDrag
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				if (this.bool_1 != value)
				{
					this.bool_1 = value;
					if (!this.bool_1)
					{
						this.bool_2 = false;
					}
				}
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0000560A File Offset: 0x0000380A
		public Form0(bool enableCloseButton)
		{
			this.EnableCloseButton = enableCloseButton;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00005620 File Offset: 0x00003820
		public Form0() : this(true)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0002A0D4 File Offset: 0x000282D4
		protected void method_0()
		{
			Enum17 @enum = (Enum17)Class265.smethod_2(base.Handle, Enum55.const_4);
			if (!@enum.HasFlag(Enum17.flag_7))
			{
				Class265.smethod_4(base.Handle, Enum55.const_4, (int)(@enum | Enum17.flag_7));
			}
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					this.vmethod_0(graphics);
				}
				Class410.smethod_0(base.Handle, base.Location, base.Size, bitmap);
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_0(Graphics gr)
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0000563E File Offset: 0x0000383E
		protected override void OnShown(EventArgs e)
		{
			Form0.class121_0.Add(this);
			if (Form0.formClosingEventHandler_0 == null)
			{
				Form0.formClosingEventHandler_0 = new FormClosingEventHandler(Form0.smethod_1);
			}
			base.FormClosing += Form0.formClosingEventHandler_0;
			base.OnShown(e);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0002A188 File Offset: 0x00028388
		private static bool smethod_0()
		{
			EventArgs19 eventArgs = new EventArgs19();
			using (IEnumerator<Form0> enumerator = Form0.class121_0.LiveList.GetEnumerator())
			{
				Form0.Class81 @class = new Form0.Class81();
				while (enumerator.MoveNext())
				{
					Form0 form0_ = enumerator.Current;
					@class.form0_0 = form0_;
					@class.form0_0.vmethod_1(eventArgs);
					if (eventArgs.Cancel)
					{
						Form0.Class82 class2 = new Form0.Class82();
						class2.class81_0 = @class;
						Enum29 @enum = Environment.OSVersion.smethod_0();
						if (!string.IsNullOrEmpty(eventArgs.CancelReason) && (@enum <= Enum29.const_0 || @enum >= Enum29.const_16))
						{
							class2.bool_0 = Class265.ShutdownBlockReasonCreate(@class.form0_0.Handle, eventArgs.CancelReason);
						}
						else
						{
							class2.bool_0 = false;
						}
						@class.form0_0.FormClosed += class2.method_0;
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_1(EventArgs19 e)
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00005675 File Offset: 0x00003875
		protected override void OnSizeChanged(EventArgs e)
		{
			if (this.CustomPainting && this.UseOpacity && !base.DesignMode)
			{
				this.method_0();
			}
			base.OnSizeChanged(e);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0000569C File Offset: 0x0000389C
		protected override void OnPaint(PaintEventArgs e)
		{
			if (!this.CustomPainting)
			{
				base.OnPaint(e);
				return;
			}
			if (this.UseOpacity && !base.DesignMode)
			{
				this.method_0();
				return;
			}
			this.vmethod_0(e.Graphics);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000056D1 File Offset: 0x000038D1
		protected override void OnLoad(EventArgs e)
		{
			if (this.UseOpacity && this.CustomPainting && !base.DesignMode)
			{
				this.method_0();
			}
			base.OnLoad(e);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000056F8 File Offset: 0x000038F8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (this.bool_1 && !base.DesignMode)
			{
				this.bool_2 = true;
				this.point_0 = e.Location;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00005724 File Offset: 0x00003924
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this.bool_1)
			{
				this.bool_2 = false;
			}
			base.OnMouseUp(e);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0002A270 File Offset: 0x00028470
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.bool_1 && this.bool_2)
			{
				base.Location = new Point(base.Location.X + (e.X - this.point_0.X), base.Location.Y + (e.Y - this.point_0.Y));
			}
			base.OnMouseMove(e);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0000573C File Offset: 0x0000393C
		protected override void OnLostFocus(EventArgs e)
		{
			if (this.bool_1)
			{
				this.bool_2 = false;
			}
			base.OnLostFocus(e);
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0002A2E4 File Offset: 0x000284E4
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				CreateParams createParams = base.CreateParams;
				if (!this.EnableCloseButton)
				{
					createParams.ClassStyle |= 512;
				}
				if (!base.DesignMode && this.UseOpacity)
				{
					createParams.ExStyle |= 524288;
				}
				if (base.FormBorderStyle == FormBorderStyle.None && base.ControlBox)
				{
					createParams.Style |= 34078720;
					if (base.MinimizeBox)
					{
						createParams.Style |= 131072;
					}
					else
					{
						createParams.Style &= -131073;
					}
					if (base.MaximizeBox)
					{
						createParams.Style |= 65536;
					}
					else
					{
						createParams.Style &= -65537;
					}
				}
				return createParams;
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0002A3B4 File Offset: 0x000285B4
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			Enum16 msg = (Enum16)m.Msg;
			if (msg == Enum16.const_67)
			{
				base.RecreateHandle();
			}
			base.WndProc(ref m);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0002A3DC File Offset: 0x000285DC
		[CompilerGenerated]
		private static void smethod_1(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown)
			{
				return;
			}
			if (!e.Cancel && !Form0.smethod_0())
			{
				e.Cancel = true;
			}
		}

		// Token: 0x04000286 RID: 646
		private bool bool_0 = true;

		// Token: 0x04000287 RID: 647
		private bool bool_1;

		// Token: 0x04000288 RID: 648
		private bool bool_2;

		// Token: 0x04000289 RID: 649
		private Point point_0;

		// Token: 0x0400028A RID: 650
		private bool bool_3;

		// Token: 0x0400028B RID: 651
		private bool bool_4;

		// Token: 0x0400028C RID: 652
		[CompilerGenerated]
		private static FormClosingEventHandler formClosingEventHandler_0;

		// Token: 0x020001CC RID: 460
		[CompilerGenerated]
		private sealed class Class81
		{
			// Token: 0x0400028D RID: 653
			public Form0 form0_0;
		}

		// Token: 0x020001CD RID: 461
		[CompilerGenerated]
		private sealed class Class82
		{
			// Token: 0x060014FC RID: 5372 RVA: 0x00005760 File Offset: 0x00003960
			public void method_0(object sender, FormClosedEventArgs e)
			{
				if (this.bool_0)
				{
					Class265.ShutdownBlockReasonDestroy(this.class81_0.form0_0.Handle);
				}
				if (Form0.smethod_0())
				{
					Application.Exit();
				}
			}

			// Token: 0x0400028E RID: 654
			public Form0.Class81 class81_0;

			// Token: 0x0400028F RID: 655
			public bool bool_0;
		}
	}
}
