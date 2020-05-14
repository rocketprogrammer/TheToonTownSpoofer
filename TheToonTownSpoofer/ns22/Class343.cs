using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using ns16;
using ns19;

namespace ns22
{
	// Token: 0x02000379 RID: 889
	internal sealed class Class343 : Component
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x000766F4 File Offset: 0x000748F4
		public int ExpandDistance
		{
			get
			{
				return this.int_6;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class344 @class = new Class343.Class344();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (@class.int_0 <= 0)
				{
					throw new ArgumentException("The value cannot be equal to or less then 0.");
				}
				if (this.int_6 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x0000EECC File Offset: 0x0000D0CC
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x00076754 File Offset: 0x00074954
		public int ContractDistance
		{
			get
			{
				return this.int_7;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class345 @class = new Class343.Class345();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (@class.int_0 <= 0)
				{
					throw new ArgumentException("The value cannot be equal to or less then 0.");
				}
				if (this.int_7 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x000767B4 File Offset: 0x000749B4
		public bool RunOnce
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class346 @class = new Class343.Class346();
				@class.bool_0 = value;
				@class.class343_0 = this;
				if (this.bool_1 != @class.bool_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x0000EEDC File Offset: 0x0000D0DC
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x00076800 File Offset: 0x00074A00
		public int ContractedDelay
		{
			get
			{
				return this.int_4;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class347 @class = new Class343.Class347();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (this.int_4 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0007684C File Offset: 0x00074A4C
		public int ExpandedDelay
		{
			get
			{
				return this.int_5;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class348 @class = new Class343.Class348();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (this.int_5 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x00076898 File Offset: 0x00074A98
		public bool Enabled
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					lock (this.object_0)
					{
						if (base.DesignMode)
						{
							this.bool_0 = value;
						}
						else
						{
							this.timer_0.Enabled = false;
							this.bool_0 = value;
							this.method_3();
							if (this.control_0 == null)
							{
								this.bool_0 = false;
								this.enum77_0 = Class343.Enum77.const_0;
							}
							else if (this.bool_0)
							{
								this.timer_0.Interval = (double)this.int_4;
								this.timer_0.Enabled = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x00076948 File Offset: 0x00074B48
		public Enum100 SlideDirection
		{
			get
			{
				return this.enum100_0;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				MethodInvoker methodInvoker2 = null;
				Class343.Class349 @class = new Class343.Class349();
				@class.enum100_0 = value;
				@class.class343_0 = this;
				if (this.enum100_0 != @class.enum100_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					MethodInvoker del = methodInvoker;
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(this.method_5);
					}
					this.method_0(del, methodInvoker2);
				}
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x000769A4 File Offset: 0x00074BA4
		public Control ControlToSlide
		{
			get
			{
				return this.control_0;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				MethodInvoker methodInvoker2 = null;
				Class343.Class350 @class = new Class343.Class350();
				@class.control_0 = value;
				@class.class343_0 = this;
				if (this.control_0 != @class.control_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					MethodInvoker del = methodInvoker;
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(this.method_6);
					}
					this.method_0(del, methodInvoker2);
				}
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0000EF04 File Offset: 0x0000D104
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00076A00 File Offset: 0x00074C00
		public int ContractRate
		{
			get
			{
				return this.int_3;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class351 @class = new Class343.Class351();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (this.int_3 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0000EF0C File Offset: 0x0000D10C
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00076A4C File Offset: 0x00074C4C
		public int ExpandRate
		{
			get
			{
				return this.int_2;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class352 @class = new Class343.Class352();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (this.int_2 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0000EF14 File Offset: 0x0000D114
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x00076A98 File Offset: 0x00074C98
		public int EndPosition
		{
			get
			{
				return this.int_1;
			}
			set
			{
				MethodInvoker methodInvoker = null;
				Class343.Class353 @class = new Class343.Class353();
				@class.int_0 = value;
				@class.class343_0 = this;
				if (this.int_1 != @class.int_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.method_0(methodInvoker, null);
				}
			}
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00076AE4 File Offset: 0x00074CE4
		private void method_0(MethodInvoker del, MethodInvoker extraDel = null)
		{
			lock (this.object_0)
			{
				if (base.DesignMode)
				{
					del();
				}
				else
				{
					bool enabled = this.Enabled;
					this.Enabled = false;
					this.method_3();
					del();
					if (extraDel != null)
					{
						extraDel();
					}
					this.Enabled = enabled;
				}
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00076B58 File Offset: 0x00074D58
		public Class343()
		{
			this.timer_0 = new System.Timers.Timer();
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.object_0 = new object();
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0000EF1C File Offset: 0x0000D11C
		public Class343(IContainer container) : this()
		{
			if (container == null)
			{
				throw new ArgumentNullException("container");
			}
			container.Add(this);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00076BCC File Offset: 0x00074DCC
		private void timer_0_Elapsed(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			if (this.control_0 == null)
			{
				this.enum77_0 = Class343.Enum77.const_0;
				return;
			}
			switch (this.enum77_0)
			{
			default:
				this.timer_0.Enabled = false;
				goto IL_E0;
			case Class343.Enum77.const_1:
				goto IL_B9;
			case Class343.Enum77.const_2:
				this.enum77_0 = Class343.Enum77.const_3;
				this.timer_0.Interval = (double)this.int_3;
				break;
			case Class343.Enum77.const_3:
				break;
			case Class343.Enum77.const_4:
				this.enum77_0 = Class343.Enum77.const_1;
				this.timer_0.Interval = (double)this.int_2;
				goto IL_B9;
			}
			if (this.method_1(this.int_7))
			{
				goto IL_E0;
			}
			if (this.bool_1)
			{
				this.Enabled = false;
				return;
			}
			this.timer_0.Interval = (double)this.int_4;
			this.enum77_0 = Class343.Enum77.const_4;
			goto IL_E0;
			IL_B9:
			if (!this.method_1(this.int_6))
			{
				this.timer_0.Interval = (double)this.int_5;
				this.enum77_0 = Class343.Enum77.const_2;
			}
			IL_E0:
			this.timer_0.Enabled = true;
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00076CC8 File Offset: 0x00074EC8
		private bool method_1(int step)
		{
			switch (this.enum100_0)
			{
			case Enum100.const_0:
				if (this.enum77_0 == Class343.Enum77.const_1)
				{
					step = -step;
				}
				return this.method_2(this.control_0.Location.X + step, this.int_1, this.int_0);
			case Enum100.const_1:
				if (this.enum77_0 == Class343.Enum77.const_3)
				{
					step = -step;
				}
				return this.method_2(this.control_0.Location.X + step, this.int_0, this.int_1);
			case Enum100.const_2:
				if (this.enum77_0 == Class343.Enum77.const_1)
				{
					step = -step;
				}
				return this.method_2(this.control_0.Location.Y + step, this.int_1, this.int_0);
			case Enum100.const_3:
				if (this.enum77_0 == Class343.Enum77.const_3)
				{
					step = -step;
				}
				return this.method_2(this.control_0.Location.Y + step, this.int_0, this.int_1);
			default:
				throw new InvalidOperationException("The SlideDirection is not supported.");
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00076DD4 File Offset: 0x00074FD4
		private bool method_2(int position, int minPos, int maxPos)
		{
			Class343.Class354 @class = new Class343.Class354();
			@class.int_0 = position;
			@class.int_1 = minPos;
			@class.int_2 = maxPos;
			@class.class343_0 = this;
			return this.control_0.smethod_5(new Func<bool>(@class.method_0));
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0000EF39 File Offset: 0x0000D139
		protected override void Dispose(bool disposing)
		{
			this.Enabled = false;
			this.timer_0.Dispose();
			base.Dispose(disposing);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00076E1C File Offset: 0x0007501C
		private void method_3()
		{
			MethodInvoker methodInvoker = null;
			MethodInvoker methodInvoker2 = null;
			if (this.control_0 != null)
			{
				switch (this.enum100_0)
				{
				case Enum100.const_0:
				case Enum100.const_1:
				{
					Control sender = this.control_0;
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(this.method_8);
					}
					sender.smethod_6(methodInvoker2);
					break;
				}
				case Enum100.const_2:
				case Enum100.const_3:
				{
					Control sender2 = this.control_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_7);
					}
					sender2.smethod_6(methodInvoker);
					break;
				}
				}
				this.enum77_0 = Class343.Enum77.const_4;
			}
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00076E98 File Offset: 0x00075098
		private void method_4()
		{
			if (this.control_0 == null)
			{
				this.int_0 = 0;
				return;
			}
			switch (this.enum100_0)
			{
			case Enum100.const_0:
			case Enum100.const_1:
				this.int_0 = this.control_0.Location.X;
				return;
			case Enum100.const_2:
			case Enum100.const_3:
				this.int_0 = this.control_0.Location.Y;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0000EF54 File Offset: 0x0000D154
		[CompilerGenerated]
		private void method_5()
		{
			this.method_4();
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0000EF54 File Offset: 0x0000D154
		[CompilerGenerated]
		private void method_6()
		{
			this.method_4();
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00076F08 File Offset: 0x00075108
		[CompilerGenerated]
		private void method_7()
		{
			this.control_0.Location = new Point(this.control_0.Location.X, this.int_0);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00076F40 File Offset: 0x00075140
		[CompilerGenerated]
		private void method_8()
		{
			this.control_0.Location = new Point(this.int_0, this.control_0.Location.Y);
		}

		// Token: 0x0400100A RID: 4106
		private Control control_0;

		// Token: 0x0400100B RID: 4107
		private System.Timers.Timer timer_0;

		// Token: 0x0400100C RID: 4108
		private bool bool_0;

		// Token: 0x0400100D RID: 4109
		private readonly object object_0;

		// Token: 0x0400100E RID: 4110
		private Class343.Enum77 enum77_0;

		// Token: 0x0400100F RID: 4111
		private Enum100 enum100_0;

		// Token: 0x04001010 RID: 4112
		private int int_0;

		// Token: 0x04001011 RID: 4113
		private int int_1;

		// Token: 0x04001012 RID: 4114
		private int int_2 = 30;

		// Token: 0x04001013 RID: 4115
		private int int_3 = 10;

		// Token: 0x04001014 RID: 4116
		private int int_4 = 5000;

		// Token: 0x04001015 RID: 4117
		private int int_5 = 6000;

		// Token: 0x04001016 RID: 4118
		private bool bool_1;

		// Token: 0x04001017 RID: 4119
		private int int_6 = 6;

		// Token: 0x04001018 RID: 4120
		private int int_7 = 2;

		// Token: 0x0200037A RID: 890
		private enum Enum77
		{
			// Token: 0x0400101A RID: 4122
			const_0,
			// Token: 0x0400101B RID: 4123
			const_1,
			// Token: 0x0400101C RID: 4124
			const_2,
			// Token: 0x0400101D RID: 4125
			const_3,
			// Token: 0x0400101E RID: 4126
			const_4
		}

		// Token: 0x0200037B RID: 891
		[CompilerGenerated]
		private sealed class Class344
		{
			// Token: 0x06002323 RID: 8995 RVA: 0x0000EF5C File Offset: 0x0000D15C
			public void method_0()
			{
				this.class343_0.int_6 = this.int_0;
			}

			// Token: 0x0400101F RID: 4127
			public Class343 class343_0;

			// Token: 0x04001020 RID: 4128
			public int int_0;
		}

		// Token: 0x0200037C RID: 892
		[CompilerGenerated]
		private sealed class Class345
		{
			// Token: 0x06002325 RID: 8997 RVA: 0x0000EF6F File Offset: 0x0000D16F
			public void method_0()
			{
				this.class343_0.int_7 = this.int_0;
			}

			// Token: 0x04001021 RID: 4129
			public Class343 class343_0;

			// Token: 0x04001022 RID: 4130
			public int int_0;
		}

		// Token: 0x0200037D RID: 893
		[CompilerGenerated]
		private sealed class Class346
		{
			// Token: 0x06002327 RID: 8999 RVA: 0x0000EF82 File Offset: 0x0000D182
			public void method_0()
			{
				this.class343_0.bool_1 = this.bool_0;
			}

			// Token: 0x04001023 RID: 4131
			public Class343 class343_0;

			// Token: 0x04001024 RID: 4132
			public bool bool_0;
		}

		// Token: 0x0200037E RID: 894
		[CompilerGenerated]
		private sealed class Class347
		{
			// Token: 0x06002329 RID: 9001 RVA: 0x0000EF95 File Offset: 0x0000D195
			public void method_0()
			{
				this.class343_0.int_4 = this.int_0;
			}

			// Token: 0x04001025 RID: 4133
			public Class343 class343_0;

			// Token: 0x04001026 RID: 4134
			public int int_0;
		}

		// Token: 0x0200037F RID: 895
		[CompilerGenerated]
		private sealed class Class348
		{
			// Token: 0x0600232B RID: 9003 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
			public void method_0()
			{
				this.class343_0.int_5 = this.int_0;
			}

			// Token: 0x04001027 RID: 4135
			public Class343 class343_0;

			// Token: 0x04001028 RID: 4136
			public int int_0;
		}

		// Token: 0x02000380 RID: 896
		[CompilerGenerated]
		private sealed class Class349
		{
			// Token: 0x0600232D RID: 9005 RVA: 0x0000EFBB File Offset: 0x0000D1BB
			public void method_0()
			{
				this.class343_0.enum100_0 = this.enum100_0;
			}

			// Token: 0x04001029 RID: 4137
			public Class343 class343_0;

			// Token: 0x0400102A RID: 4138
			public Enum100 enum100_0;
		}

		// Token: 0x02000381 RID: 897
		[CompilerGenerated]
		private sealed class Class350
		{
			// Token: 0x0600232F RID: 9007 RVA: 0x0000EFCE File Offset: 0x0000D1CE
			public void method_0()
			{
				this.class343_0.control_0 = this.control_0;
			}

			// Token: 0x0400102B RID: 4139
			public Class343 class343_0;

			// Token: 0x0400102C RID: 4140
			public Control control_0;
		}

		// Token: 0x02000382 RID: 898
		[CompilerGenerated]
		private sealed class Class351
		{
			// Token: 0x06002331 RID: 9009 RVA: 0x0000EFE1 File Offset: 0x0000D1E1
			public void method_0()
			{
				this.class343_0.int_3 = this.int_0;
			}

			// Token: 0x0400102D RID: 4141
			public Class343 class343_0;

			// Token: 0x0400102E RID: 4142
			public int int_0;
		}

		// Token: 0x02000383 RID: 899
		[CompilerGenerated]
		private sealed class Class352
		{
			// Token: 0x06002333 RID: 9011 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
			public void method_0()
			{
				this.class343_0.int_2 = this.int_0;
			}

			// Token: 0x0400102F RID: 4143
			public Class343 class343_0;

			// Token: 0x04001030 RID: 4144
			public int int_0;
		}

		// Token: 0x02000384 RID: 900
		[CompilerGenerated]
		private sealed class Class353
		{
			// Token: 0x06002335 RID: 9013 RVA: 0x0000F007 File Offset: 0x0000D207
			public void method_0()
			{
				this.class343_0.int_1 = this.int_0;
			}

			// Token: 0x04001031 RID: 4145
			public Class343 class343_0;

			// Token: 0x04001032 RID: 4146
			public int int_0;
		}

		// Token: 0x02000385 RID: 901
		[CompilerGenerated]
		private sealed class Class354
		{
			// Token: 0x06002337 RID: 9015 RVA: 0x00076F78 File Offset: 0x00075178
			public bool method_0()
			{
				switch (this.class343_0.enum100_0)
				{
				case Enum100.const_0:
				case Enum100.const_1:
					if (this.int_0 < this.int_1)
					{
						this.class343_0.control_0.Location = new Point(this.int_1, this.class343_0.control_0.Location.Y);
						return false;
					}
					if (this.int_0 > this.int_2)
					{
						this.class343_0.control_0.Location = new Point(this.int_2, this.class343_0.control_0.Location.Y);
						return false;
					}
					this.class343_0.control_0.Location = new Point(this.int_0, this.class343_0.control_0.Location.Y);
					return true;
				case Enum100.const_2:
				case Enum100.const_3:
					if (this.int_0 < this.int_1)
					{
						this.class343_0.control_0.Location = new Point(this.class343_0.control_0.Location.X, this.int_1);
						return false;
					}
					if (this.int_0 > this.int_2)
					{
						this.class343_0.control_0.Location = new Point(this.class343_0.control_0.Location.X, this.int_2);
						return false;
					}
					this.class343_0.control_0.Location = new Point(this.class343_0.control_0.Location.X, this.int_0);
					return true;
				default:
					throw new InvalidOperationException("The SlideDirection is not supported.");
				}
			}

			// Token: 0x04001033 RID: 4147
			public Class343 class343_0;

			// Token: 0x04001034 RID: 4148
			public int int_0;

			// Token: 0x04001035 RID: 4149
			public int int_1;

			// Token: 0x04001036 RID: 4150
			public int int_2;
		}
	}
}
