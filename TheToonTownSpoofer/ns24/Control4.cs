using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns20;
using ns22;
using ns23;
using ns26;

namespace ns24
{
	// Token: 0x02000327 RID: 807
	internal sealed class Control4 : Control, Interface12<Control4.Class311>
	{
		// Token: 0x14000195 RID: 405
		// (add) Token: 0x06001F59 RID: 8025 RVA: 0x0006810C File Offset: 0x0006630C
		// (remove) Token: 0x06001F5A RID: 8026 RVA: 0x00068144 File Offset: 0x00066344
		public event EventHandler<EventArgs21> ButtonClicked
		{
			add
			{
				EventHandler<EventArgs21> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs21> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs21> value2 = (EventHandler<EventArgs21>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs21>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs21> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs21> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs21> value2 = (EventHandler<EventArgs21>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs21>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0000C66B File Offset: 0x0000A86B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0006817C File Offset: 0x0006637C
		public Control4()
		{
			this.ButtonOutline = Color.FromArgb(200, 0, 0, 0);
			this.HoverRadialCenterColor = Color.FromArgb(200, Color.Red);
			this.HoverRadialSurroundColor = Color.FromArgb(0, Color.Red);
			this.SelectedRadialCenterColor = Color.FromArgb(200, Color.Lime);
			this.SelectedRadialSurroundColor = Color.FromArgb(0, Color.Lime);
			this.HoverStartColor = Color.FromArgb(248, 152, 152);
			this.HoverEndColor = Color.FromArgb(157, 0, 18);
			this.NormalStartColor = Color.FromArgb(76, 181, 248);
			this.NormalEndColor = Color.FromArgb(1, 137, 224);
			this.DisabledStartColor = Color.FromArgb(163, 163, 163);
			this.DisabledEndColor = Color.FromArgb(37, 37, 37);
			this.DownStartColor = Color.FromArgb(250, 102, 102);
			this.DownEndColor = Color.FromArgb(111, 2, 14);
			this.SelectedStartColor = Color.FromArgb(152, 248, 165);
			this.SelectedEndColor = Color.FromArgb(0, 157, 0);
			this.class342_0 = new Class342<Control4.Class311, Control4>(this);
			this.dictionary_0 = new Dictionary<Control4.Class311, Rectangle>();
			this.icontainer_0 = new Container();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0000C68A File Offset: 0x0000A88A
		[Editor(typeof(CollectionEditor), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Behavior")]
		[Description("Button Collection")]
		public Class342<Control4.Class311, Control4> Buttons
		{
			get
			{
				return this.class342_0;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0000C692 File Offset: 0x0000A892
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000C69A File Offset: 0x0000A89A
		public Interface16 BackgroundPaint
		{
			get
			{
				return this.interface16_0;
			}
			set
			{
				if (this.interface16_0 != value)
				{
					this.interface16_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x0000C6B2 File Offset: 0x0000A8B2
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000C6BF File Offset: 0x0000A8BF
		public bool ToolTipsEnabled
		{
			get
			{
				return this.toolTip_0.Active;
			}
			set
			{
				if (this.toolTip_0.Active != value)
				{
					this.toolTip_0.Active = value;
					this.toolTip_0.SetToolTip(this, string.Empty);
				}
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000C708 File Offset: 0x0000A908
		public Font TextFont
		{
			get
			{
				if (this.font_0 == null)
				{
					this.font_0 = this.Font;
				}
				return this.font_0;
			}
			set
			{
				if (this.font_0 != value)
				{
					this.font_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0000C720 File Offset: 0x0000A920
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000C728 File Offset: 0x0000A928
		public Color HoverStartColor { get; set; }

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0000C731 File Offset: 0x0000A931
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000C739 File Offset: 0x0000A939
		public Color HoverEndColor { get; set; }

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0000C742 File Offset: 0x0000A942
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000C74A File Offset: 0x0000A94A
		public Color NormalStartColor { get; set; }

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0000C753 File Offset: 0x0000A953
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0000C75B File Offset: 0x0000A95B
		public Color NormalEndColor { get; set; }

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0000C764 File Offset: 0x0000A964
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0000C76C File Offset: 0x0000A96C
		public Color DisabledStartColor { get; set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0000C775 File Offset: 0x0000A975
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000C77D File Offset: 0x0000A97D
		public Color DisabledEndColor { get; set; }

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x0000C786 File Offset: 0x0000A986
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000C78E File Offset: 0x0000A98E
		public Color DownStartColor { get; set; }

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0000C797 File Offset: 0x0000A997
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000C79F File Offset: 0x0000A99F
		public Color DownEndColor { get; set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		public Color SelectedStartColor { get; set; }

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0000C7B9 File Offset: 0x0000A9B9
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
		public Color SelectedEndColor { get; set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0000C7CA File Offset: 0x0000A9CA
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
		public Color HoverRadialCenterColor { get; set; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0000C7DB File Offset: 0x0000A9DB
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0000C7E3 File Offset: 0x0000A9E3
		public Color HoverRadialSurroundColor { get; set; }

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public Color SelectedRadialCenterColor { get; set; }

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0000C7FD File Offset: 0x0000A9FD
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0000C805 File Offset: 0x0000AA05
		public Color SelectedRadialSurroundColor { get; set; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0000C80E File Offset: 0x0000AA0E
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0000C816 File Offset: 0x0000AA16
		public Color ButtonOutline { get; set; }

		// Token: 0x06001F82 RID: 8066 RVA: 0x0000C81F File Offset: 0x0000AA1F
		private void method_0(Rectangle rec)
		{
			if (rec.smethod_2())
			{
				base.Invalidate(rec.smethod_6(2, 2));
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0000C837 File Offset: 0x0000AA37
		private void method_1(Control4.Class311 btn, MouseButtons button)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs21(btn, button));
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00068304 File Offset: 0x00066504
		private LinearGradientBrush method_2(Control4.Class311 btn)
		{
			Rectangle bounds = btn.Bounds;
			if (!btn.Enabled)
			{
				return new LinearGradientBrush(bounds.Location, bounds.smethod_17(), this.DisabledStartColor, this.DisabledEndColor);
			}
			if (btn.Down && !btn.Selected)
			{
				return new LinearGradientBrush(bounds.Location, bounds.smethod_17(), this.DownStartColor, this.DownEndColor);
			}
			if (btn.Selected)
			{
				return new LinearGradientBrush(bounds.Location, bounds.smethod_17(), this.SelectedStartColor, this.SelectedEndColor);
			}
			if (btn.Hover)
			{
				return new LinearGradientBrush(bounds.Location, bounds.smethod_17(), this.HoverStartColor, this.HoverEndColor);
			}
			return new LinearGradientBrush(bounds.Location, bounds.smethod_17(), this.NormalStartColor, this.NormalEndColor);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0000C854 File Offset: 0x0000AA54
		private void method_3(Control4.Class311 sender, string text)
		{
			this.class311_0 = sender;
			if (this.toolTip_0.Active)
			{
				this.toolTip_0.SetToolTip(this, text);
			}
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0000C877 File Offset: 0x0000AA77
		private void method_4(Control4.Class311 sender)
		{
			if (this.class311_0 == sender && this.toolTip_0.Active)
			{
				this.toolTip_0.SetToolTip(this, string.Empty);
			}
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		void Interface12<Control4.Class311>.imethod_0(Control4.Class311 obj)
		{
			this.dictionary_0.Add(obj, obj.Bounds);
			this.method_0(this.dictionary_0[obj]);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0000C8C6 File Offset: 0x0000AAC6
		void Interface12<Control4.Class311>.imethod_1(Control4.Class311 obj)
		{
			this.method_0(this.dictionary_0[obj]);
			this.dictionary_0.Remove(obj);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0000C8E7 File Offset: 0x0000AAE7
		void Interface12<Control4.Class311>.imethod_2(Control4.Class311 obj)
		{
			this.method_0(this.dictionary_0[obj]);
			this.dictionary_0[obj] = obj.Bounds;
			this.method_0(this.dictionary_0[obj]);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000683DC File Offset: 0x000665DC
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (this.interface16_0 != null)
			{
				this.interface16_0.imethod_0(new EventArgs34(e.Graphics, base.ClientRectangle));
			}
			foreach (Control4.Class311 @class in this.Buttons)
			{
				@class.method_2(e);
			}
			base.OnPaint(e);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00068464 File Offset: 0x00066664
		protected override void OnMouseMove(MouseEventArgs e)
		{
			foreach (Control4.Class311 @class in this.Buttons)
			{
				@class.imethod_0(e);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000684BC File Offset: 0x000666BC
		protected override void OnMouseLeave(EventArgs e)
		{
			foreach (Control4.Class311 @class in this.Buttons)
			{
				@class.imethod_3();
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00068510 File Offset: 0x00066710
		protected override void OnMouseDown(MouseEventArgs e)
		{
			foreach (Control4.Class311 @class in this.Buttons)
			{
				@class.imethod_1(e.Button);
			}
			base.OnMouseDown(e);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0006856C File Offset: 0x0006676C
		protected override void OnMouseUp(MouseEventArgs e)
		{
			foreach (Control4.Class311 @class in this.Buttons)
			{
				@class.imethod_2(e.Button);
			}
			base.OnMouseUp(e);
		}

		// Token: 0x04000C21 RID: 3105
		private Dictionary<Control4.Class311, Rectangle> dictionary_0;

		// Token: 0x04000C22 RID: 3106
		private Interface16 interface16_0;

		// Token: 0x04000C23 RID: 3107
		private Font font_0;

		// Token: 0x04000C24 RID: 3108
		private ToolTip toolTip_0;

		// Token: 0x04000C25 RID: 3109
		private IContainer icontainer_0;

		// Token: 0x04000C26 RID: 3110
		private Control4.Class311 class311_0;

		// Token: 0x04000C27 RID: 3111
		private Class342<Control4.Class311, Control4> class342_0;

		// Token: 0x04000C28 RID: 3112
		private EventHandler<EventArgs21> eventHandler_0;

		// Token: 0x04000C29 RID: 3113
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x04000C2A RID: 3114
		[CompilerGenerated]
		private Color color_1;

		// Token: 0x04000C2B RID: 3115
		[CompilerGenerated]
		private Color color_2;

		// Token: 0x04000C2C RID: 3116
		[CompilerGenerated]
		private Color color_3;

		// Token: 0x04000C2D RID: 3117
		[CompilerGenerated]
		private Color color_4;

		// Token: 0x04000C2E RID: 3118
		[CompilerGenerated]
		private Color color_5;

		// Token: 0x04000C2F RID: 3119
		[CompilerGenerated]
		private Color color_6;

		// Token: 0x04000C30 RID: 3120
		[CompilerGenerated]
		private Color color_7;

		// Token: 0x04000C31 RID: 3121
		[CompilerGenerated]
		private Color color_8;

		// Token: 0x04000C32 RID: 3122
		[CompilerGenerated]
		private Color color_9;

		// Token: 0x04000C33 RID: 3123
		[CompilerGenerated]
		private Color color_10;

		// Token: 0x04000C34 RID: 3124
		[CompilerGenerated]
		private Color color_11;

		// Token: 0x04000C35 RID: 3125
		[CompilerGenerated]
		private Color color_12;

		// Token: 0x04000C36 RID: 3126
		[CompilerGenerated]
		private Color color_13;

		// Token: 0x04000C37 RID: 3127
		[CompilerGenerated]
		private Color color_14;

		// Token: 0x02000328 RID: 808
		internal sealed class Class311 : Interface21<Control4.Class311>, Interface14
		{
			// Token: 0x06001F8F RID: 8079 RVA: 0x0000C91F File Offset: 0x0000AB1F
			public Class311()
			{
				this.Name = string.Empty;
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001F90 RID: 8080 RVA: 0x0000C939 File Offset: 0x0000AB39
			// (set) Token: 0x06001F91 RID: 8081 RVA: 0x0000C941 File Offset: 0x0000AB41
			public Enum ButtonType { get; set; }

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001F92 RID: 8082 RVA: 0x0000C94A File Offset: 0x0000AB4A
			// (set) Token: 0x06001F93 RID: 8083 RVA: 0x0000C952 File Offset: 0x0000AB52
			public Control4.Class311.Interface20 Overlay
			{
				get
				{
					return this.interface20_0;
				}
				set
				{
					if (this.interface20_0 != value)
					{
						if (this.interface20_0 != null)
						{
							this.interface20_0.Owner = null;
						}
						this.interface20_0 = value;
						if (this.interface20_0 != null)
						{
							this.interface20_0.Owner = this;
						}
						this.method_1();
					}
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0000C992 File Offset: 0x0000AB92
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0000C99A File Offset: 0x0000AB9A
			public string Name { get; set; }

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0000C9A3 File Offset: 0x0000ABA3
			// (set) Token: 0x06001F97 RID: 8087 RVA: 0x0000C9AB File Offset: 0x0000ABAB
			public bool AcceptRightClick
			{
				get
				{
					return this.bool_0;
				}
				set
				{
					this.bool_0 = value;
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
			// (set) Token: 0x06001F99 RID: 8089 RVA: 0x0000C9BC File Offset: 0x0000ABBC
			[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
			public string Text
			{
				get
				{
					return this.string_0;
				}
				set
				{
					if (this.string_0 != value)
					{
						this.string_0 = value;
						this.method_1();
					}
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0000C9D9 File Offset: 0x0000ABD9
			// (set) Token: 0x06001F9B RID: 8091 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
			public bool Hover
			{
				get
				{
					return this.enum65_0.HasFlag(Control4.Class311.Enum65.flag_1);
				}
				private set
				{
					if (this.Hover != value)
					{
						if (value)
						{
							this.enum65_0 |= Control4.Class311.Enum65.flag_1;
							return;
						}
						this.enum65_0 &= ~Control4.Class311.Enum65.flag_1;
					}
				}
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x0000CA1D File Offset: 0x0000AC1D
			// (set) Token: 0x06001F9D RID: 8093 RVA: 0x0000CA35 File Offset: 0x0000AC35
			public bool Down
			{
				get
				{
					return this.enum65_0.HasFlag(Control4.Class311.Enum65.flag_2);
				}
				private set
				{
					if (this.Down != value)
					{
						if (value)
						{
							this.enum65_0 |= Control4.Class311.Enum65.flag_2;
							return;
						}
						this.enum65_0 &= ~Control4.Class311.Enum65.flag_2;
					}
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0000CA61 File Offset: 0x0000AC61
			// (set) Token: 0x06001F9F RID: 8095 RVA: 0x000685C8 File Offset: 0x000667C8
			public bool Enabled
			{
				get
				{
					return !this.enum65_0.HasFlag(Control4.Class311.Enum65.flag_4);
				}
				set
				{
					if (this.Enabled != value)
					{
						if (value)
						{
							this.enum65_0 &= ~Control4.Class311.Enum65.flag_4;
						}
						else
						{
							this.enum65_0 |= Control4.Class311.Enum65.flag_4;
							this.Hover = false;
							this.Down = false;
						}
						this.method_1();
					}
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0000CA7C File Offset: 0x0000AC7C
			// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x0000CA94 File Offset: 0x0000AC94
			public bool Selected
			{
				get
				{
					return this.enum65_0.HasFlag(Control4.Class311.Enum65.flag_3);
				}
				set
				{
					if (this.Selected != value)
					{
						if (value)
						{
							this.enum65_0 |= Control4.Class311.Enum65.flag_3;
						}
						else
						{
							this.enum65_0 &= ~Control4.Class311.Enum65.flag_3;
						}
						this.method_1();
					}
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0000CAC7 File Offset: 0x0000ACC7
			// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x0000CACF File Offset: 0x0000ACCF
			[DefaultValue(typeof(Image), null)]
			public Image Icon
			{
				get
				{
					return this.image_0;
				}
				set
				{
					if (this.image_0 != value)
					{
						this.image_0 = value;
						this.method_1();
					}
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0000CAE7 File Offset: 0x0000ACE7
			// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x0000CAEF File Offset: 0x0000ACEF
			public Rectangle Bounds
			{
				get
				{
					return this.rectangle_0;
				}
				set
				{
					if (this.rectangle_0 != value)
					{
						this.rectangle_0 = value;
						this.method_0();
					}
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0000CB0C File Offset: 0x0000AD0C
			// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0000CB14 File Offset: 0x0000AD14
			protected Control4 Owner { get; set; }

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0000CB1D File Offset: 0x0000AD1D
			// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0000CB25 File Offset: 0x0000AD25
			Interface12<Control4.Class311> Interface21<Control4.Class311>.Owner
			{
				get
				{
					return this.Owner;
				}
				set
				{
					this.Owner = (Control4)value;
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0000CB33 File Offset: 0x0000AD33
			public Font Font
			{
				get
				{
					if (this.Owner == null)
					{
						return null;
					}
					return this.Owner.Font;
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0000CB4A File Offset: 0x0000AD4A
			public Font TextFont
			{
				get
				{
					if (this.Owner == null)
					{
						return null;
					}
					return this.Owner.TextFont;
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0000CB61 File Offset: 0x0000AD61
			public Color ForeColor
			{
				get
				{
					if (this.Owner == null)
					{
						return Color.Black;
					}
					return this.Owner.ForeColor;
				}
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x00068614 File Offset: 0x00066814
			private void method_0()
			{
				if (((Interface21<Control4.Class311>)this).Owner != null)
				{
					((Interface21<Control4.Class311>)this).Owner.imethod_2(this);
				}
			}

			// Token: 0x06001FAE RID: 8110 RVA: 0x00068638 File Offset: 0x00066838
			public void method_1()
			{
				if (((Interface21<Control4.Class311>)this).Owner != null)
				{
					((Control4)((Interface21<Control4.Class311>)this).Owner).method_0(this.Bounds);
				}
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0000CB7C File Offset: 0x0000AD7C
			public override string ToString()
			{
				return this.Name;
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x00068668 File Offset: 0x00066868
			public void method_2(PaintEventArgs e)
			{
				if (this.Bounds.smethod_2())
				{
					using (GraphicsPath graphicsPath = Class476.smethod_0(this.Bounds, 8, Enum48.flag_5))
					{
						using (LinearGradientBrush linearGradientBrush = this.Owner.method_2(this))
						{
							e.Graphics.FillPath(linearGradientBrush, graphicsPath);
							e.Graphics.SetClip(graphicsPath);
							if (this.enum65_0 == Control4.Class311.Enum65.flag_1 || this.Selected)
							{
								using (GraphicsPath graphicsPath2 = Class341.smethod_0(this.Bounds.smethod_19().smethod_4(40, 40)))
								{
									using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath2))
									{
										if (this.enum65_0 == Control4.Class311.Enum65.flag_1)
										{
											pathGradientBrush.CenterColor = this.Owner.HoverRadialCenterColor;
											pathGradientBrush.SurroundColors = new Color[]
											{
												this.Owner.HoverRadialSurroundColor
											};
										}
										if (this.enum65_0.HasFlag(Control4.Class311.Enum65.flag_3))
										{
											pathGradientBrush.CenterColor = this.Owner.SelectedRadialCenterColor;
											pathGradientBrush.SurroundColors = new Color[]
											{
												this.Owner.SelectedRadialSurroundColor
											};
										}
										e.Graphics.FillPath(pathGradientBrush, graphicsPath2);
									}
								}
							}
							if (this.Icon != null)
							{
								e.Graphics.DrawImage(this.Icon, this.Icon.Size.smethod_22(this.Bounds.smethod_6(-2, -2)));
							}
							if (!string.IsNullOrEmpty(this.string_0) && this.TextFont != null)
							{
								using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
								{
									using (StringFormat stringFormat = new StringFormat())
									{
										stringFormat.Alignment = StringAlignment.Center;
										stringFormat.LineAlignment = StringAlignment.Center;
										e.Graphics.DrawString(this.string_0, this.TextFont, solidBrush, this.Bounds, stringFormat);
									}
								}
							}
							if (this.interface20_0 != null)
							{
								this.interface20_0.imethod_0(new EventArgs34(e.Graphics, this.Bounds));
							}
							e.Graphics.ResetClip();
						}
						using (Pen pen = new Pen(this.Owner.ButtonOutline, 1f))
						{
							e.Graphics.DrawPath(pen, graphicsPath);
						}
					}
				}
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x00068980 File Offset: 0x00066B80
			public void imethod_0(MouseEventArgs e)
			{
				if (this.Enabled)
				{
					if (this.Hover)
					{
						if (!this.Bounds.Contains(e.Location))
						{
							this.Hover = false;
							this.Owner.method_4(this);
							this.method_1();
							return;
						}
					}
					else if (this.Bounds.Contains(e.Location))
					{
						this.Hover = true;
						this.Owner.method_3(this, this.Overlay.ToString());
						this.method_1();
					}
				}
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x00068A08 File Offset: 0x00066C08
			public void imethod_1(MouseButtons button)
			{
				if (this.Enabled)
				{
					if (button == MouseButtons.Right && !this.bool_0)
					{
						return;
					}
					if (this.Hover)
					{
						this.Down = true;
						this.method_1();
						return;
					}
					if (this.Down)
					{
						this.Down = false;
						this.method_1();
					}
				}
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x00068A5C File Offset: 0x00066C5C
			public void imethod_2(MouseButtons button)
			{
				if (this.Enabled)
				{
					if (button == MouseButtons.Right && !this.bool_0)
					{
						return;
					}
					if (this.Down)
					{
						if (this.Hover && ((Interface21<Control4.Class311>)this).Owner != null)
						{
							((Control4)((Interface21<Control4.Class311>)this).Owner).method_1(this, button);
						}
						this.Down = false;
						this.method_1();
					}
				}
			}

			// Token: 0x06001FB4 RID: 8116 RVA: 0x0000CB84 File Offset: 0x0000AD84
			public void imethod_3()
			{
				if (this.Enabled && this.Hover)
				{
					this.Hover = false;
					this.Owner.method_4(this);
					this.method_1();
				}
			}

			// Token: 0x04000C38 RID: 3128
			private Control4.Class311.Interface20 interface20_0;

			// Token: 0x04000C39 RID: 3129
			private Image image_0;

			// Token: 0x04000C3A RID: 3130
			private Rectangle rectangle_0;

			// Token: 0x04000C3B RID: 3131
			private Control4.Class311.Enum65 enum65_0;

			// Token: 0x04000C3C RID: 3132
			private bool bool_0 = true;

			// Token: 0x04000C3D RID: 3133
			private string string_0;

			// Token: 0x04000C3E RID: 3134
			[CompilerGenerated]
			private Enum enum_0;

			// Token: 0x04000C3F RID: 3135
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000C40 RID: 3136
			[CompilerGenerated]
			private Control4 control4_0;

			// Token: 0x02000329 RID: 809
			internal interface Interface20 : Interface16
			{
				// Token: 0x17000873 RID: 2163
				// (get) Token: 0x06001FB5 RID: 8117
				// (set) Token: 0x06001FB6 RID: 8118
				Control4.Class311 Owner { get; set; }

				// Token: 0x06001FB7 RID: 8119
				string ToString();
			}

			// Token: 0x0200032A RID: 810
			[Flags]
			internal enum Enum65
			{
				// Token: 0x04000C42 RID: 3138
				flag_0 = 0,
				// Token: 0x04000C43 RID: 3139
				flag_1 = 1,
				// Token: 0x04000C44 RID: 3140
				flag_2 = 2,
				// Token: 0x04000C45 RID: 3141
				flag_3 = 4,
				// Token: 0x04000C46 RID: 3142
				flag_4 = 8
			}
		}
	}
}
