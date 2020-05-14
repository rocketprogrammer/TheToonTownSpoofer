using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ns15;
using ns16;
using ns17;
using ns18;
using ns19;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns20
{
	// Token: 0x0200043B RID: 1083
	internal sealed partial class JoeFishRunning : RunBaseForm
	{
		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x00012DD4 File Offset: 0x00010FD4
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x00012DDC File Offset: 0x00010FDC
		private JoeFishRunning.Enum109 State
		{
			get
			{
				return this.enum109_0;
			}
			set
			{
				this.enum109_0 = value;
				this.smethod_6(new MethodInvoker(this.method_58));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x00012DF7 File Offset: 0x00010FF7
		public DateTime StartTime
		{
			get
			{
				return this.dateTime_0;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x00012DFF File Offset: 0x00010FFF
		public DateTime EndTime
		{
			get
			{
				return this.dateTime_1;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x00012E07 File Offset: 0x00011007
		public uint BucketsSold
		{
			get
			{
				return this.uint_0;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x00012E0F File Offset: 0x0001100F
		public uint FishCaught
		{
			get
			{
				return this.uint_1;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00012E17 File Offset: 0x00011017
		public uint BootsCaught
		{
			get
			{
				return this.uint_2;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x00012E1F File Offset: 0x0001101F
		public uint Casts
		{
			get
			{
				return this.uint_3;
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0009B40C File Offset: 0x0009960C
		public JoeFishRunning(IntPtr hWnd, Enum50 operation, Class98 captures, Class103 docks, Class101 wayPoints) : base(hWnd)
		{
			this.InitializeComponent_1();
			this.size_0 = new Size(576, 432);
			this.struct41_0 = Struct41.smethod_2(new Size(32, 16), new Size(800, 600));
			this.struct41_1 = Struct41.smethod_2(new Size(90, 60), new Size(800, 600));
			this.struct41_2 = Struct41.smethod_2(new Size(12, 8), new Size(1024, 768));
			this.struct46_0 = Struct46.smethod_3(new Rectangle(Point.Empty, new Size(1024, 544)), new Rectangle(Point.Empty, new Size(1024, 768)));
			this.class106_0 = Class110.Instance.JoeFishSettings;
			this.enum50_0 = operation;
			this.class98_0 = captures;
			this.class103_0 = docks;
			this.class101_0 = wayPoints;
			this.State = JoeFishRunning.Enum109.const_0;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00012E27 File Offset: 0x00011027
		private void method_23()
		{
			if (JoeFishRunning.methodInvoker_0 == null)
			{
				JoeFishRunning.methodInvoker_0 = new MethodInvoker(JoeFishRunning.smethod_4);
			}
			base.method_2(JoeFishRunning.methodInvoker_0);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00012E4C File Offset: 0x0001104C
		private void method_24()
		{
			if (JoeFishRunning.methodInvoker_1 == null)
			{
				JoeFishRunning.methodInvoker_1 = new MethodInvoker(JoeFishRunning.smethod_5);
			}
			base.method_2(JoeFishRunning.methodInvoker_1);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00012E71 File Offset: 0x00011071
		private void method_25()
		{
			if (JoeFishRunning.methodInvoker_2 == null)
			{
				JoeFishRunning.methodInvoker_2 = new MethodInvoker(JoeFishRunning.smethod_6);
			}
			base.method_2(JoeFishRunning.methodInvoker_2);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00012E96 File Offset: 0x00011096
		private void method_26()
		{
			if (JoeFishRunning.methodInvoker_3 == null)
			{
				JoeFishRunning.methodInvoker_3 = new MethodInvoker(JoeFishRunning.smethod_7);
			}
			base.method_2(JoeFishRunning.methodInvoker_3);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00012EBB File Offset: 0x000110BB
		private void method_27()
		{
			if (JoeFishRunning.methodInvoker_4 == null)
			{
				JoeFishRunning.methodInvoker_4 = new MethodInvoker(JoeFishRunning.smethod_8);
			}
			base.method_2(JoeFishRunning.methodInvoker_4);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00012EE0 File Offset: 0x000110E0
		private void method_28()
		{
			if (JoeFishRunning.methodInvoker_5 == null)
			{
				JoeFishRunning.methodInvoker_5 = new MethodInvoker(JoeFishRunning.smethod_9);
			}
			base.method_2(JoeFishRunning.methodInvoker_5);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00012F05 File Offset: 0x00011105
		private void method_29()
		{
			if (JoeFishRunning.methodInvoker_6 == null)
			{
				JoeFishRunning.methodInvoker_6 = new MethodInvoker(JoeFishRunning.smethod_10);
			}
			base.method_2(JoeFishRunning.methodInvoker_6);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00012F2A File Offset: 0x0001112A
		private void method_30()
		{
			if (JoeFishRunning.methodInvoker_7 == null)
			{
				JoeFishRunning.methodInvoker_7 = new MethodInvoker(JoeFishRunning.smethod_11);
			}
			base.method_2(JoeFishRunning.methodInvoker_7);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00012F4F File Offset: 0x0001114F
		private void method_31()
		{
			if (JoeFishRunning.methodInvoker_8 == null)
			{
				JoeFishRunning.methodInvoker_8 = new MethodInvoker(JoeFishRunning.smethod_12);
			}
			base.method_2(JoeFishRunning.methodInvoker_8);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00012F74 File Offset: 0x00011174
		private void method_32()
		{
			if (JoeFishRunning.methodInvoker_9 == null)
			{
				JoeFishRunning.methodInvoker_9 = new MethodInvoker(JoeFishRunning.smethod_13);
			}
			base.method_2(JoeFishRunning.methodInvoker_9);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00012F99 File Offset: 0x00011199
		private void method_33()
		{
			if (JoeFishRunning.methodInvoker_10 == null)
			{
				JoeFishRunning.methodInvoker_10 = new MethodInvoker(JoeFishRunning.smethod_14);
			}
			base.method_2(JoeFishRunning.methodInvoker_10);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00012FBE File Offset: 0x000111BE
		private void method_34()
		{
			if (JoeFishRunning.methodInvoker_11 == null)
			{
				JoeFishRunning.methodInvoker_11 = new MethodInvoker(JoeFishRunning.smethod_15);
			}
			base.method_2(JoeFishRunning.methodInvoker_11);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x0009B518 File Offset: 0x00099718
		private void method_35(object sender, EventArgs e)
		{
			if (this.class142_0.Playground != Enum57.const_1)
			{
				if (this.class101_0.WayPoints.ContainsKey(this.class142_0.Playground))
				{
					IEnumerable<KeyValuePair<PointF, Enum99>> source = this.class101_0.WayPoints[this.class142_0.Playground];
					if (JoeFishRunning.func_0 == null)
					{
						JoeFishRunning.func_0 = new Func<KeyValuePair<PointF, Enum99>, bool>(JoeFishRunning.smethod_16);
					}
					if (source.Count(JoeFishRunning.func_0) != 0)
					{
						goto IL_87;
					}
				}
				base.Hide();
				DialogBox.smethod_3(JoeFishRunning.string_73, JoeFishRunning.string_74);
				base.method_1(DialogResult.Abort);
				return;
			}
			IL_87:
			this.task_0 = new Task(new Action(this.method_59));
			this.task_0.Start();
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x0009B5D0 File Offset: 0x000997D0
		private void method_36()
		{
			JoeFishRunning.Class444 @class = new JoeFishRunning.Class444();
			@class.joeFishRunning_0 = this;
			@class.nullable_0 = null;
			List<PointF> path = null;
			@class.bool_0 = false;
			try
			{
				while (!this.manualResetEventSlim_0.IsSet)
				{
					JoeFishRunning.Class445 class2 = new JoeFishRunning.Class445();
					switch (this.State)
					{
					case JoeFishRunning.Enum109.const_3:
						Class335.smethod_2(JoeFishRunning.string_34, true);
						if (!this.method_42(path))
						{
							Class335.smethod_2(JoeFishRunning.string_30, this.manualResetEventSlim_0.IsSet);
							@class.nullable_0 = new DateTime?(DateTime.Now);
							if (!this.manualResetEventSlim_0.IsSet)
							{
								this.method_30();
							}
							return;
						}
						Class335.smethod_2(JoeFishRunning.string_33, true);
						if (!this.method_41())
						{
							Class335.smethod_2(JoeFishRunning.string_31, true);
							return;
						}
						Class335.smethod_2(JoeFishRunning.string_32, true);
						this.State = JoeFishRunning.Enum109.const_4;
						break;
					case JoeFishRunning.Enum109.const_4:
						Class335.smethod_2(JoeFishRunning.string_25, true);
						class2.int_0 = 0;
						class2.bool_0 = false;
						while (!this.manualResetEventSlim_0.IsSet)
						{
							JoeFishRunning.Class446 class3 = new JoeFishRunning.Class446();
							if (!this.class142_0.ToonTownProcess.ProcessOpen)
							{
								@class.nullable_0 = new DateTime?(DateTime.Now);
								this.method_28();
								return;
							}
							class3.enum110_0 = JoeFishRunning.Enum110.const_0;
							JoeFishRunning.Class447 class4 = new JoeFishRunning.Class447();
							class4.cancellationTokenSource_0 = new CancellationTokenSource();
							try
							{
								Func<bool> func = null;
								JoeFishRunning.Class448 class5 = new JoeFishRunning.Class448();
								class5.class447_0 = class4;
								class5.class446_0 = class3;
								class5.class445_0 = class2;
								class5.class444_0 = @class;
								class5.task_0 = new Task<Point[]>(new Func<object, Point[]>(this.method_37), class4.cancellationTokenSource_0.Token, class4.cancellationTokenSource_0.Token);
								try
								{
									if (func == null)
									{
										func = new Func<bool>(class5.method_0);
									}
									Func<bool> func2 = func;
									if (!func2())
									{
										return;
									}
								}
								finally
								{
									if (class5.task_0 != null)
									{
										((IDisposable)class5.task_0).Dispose();
									}
								}
							}
							finally
							{
								if (class4.cancellationTokenSource_0 != null)
								{
									((IDisposable)class4.cancellationTokenSource_0).Dispose();
								}
							}
							if (class2.bool_0)
							{
								break;
							}
						}
						break;
					case JoeFishRunning.Enum109.const_5:
						Class335.smethod_2(JoeFishRunning.string_29, true);
						if (!this.method_43(out path))
						{
							Class335.smethod_2(JoeFishRunning.string_26, this.manualResetEventSlim_0.IsSet);
							@class.nullable_0 = new DateTime?(DateTime.Now);
							if (!this.manualResetEventSlim_0.IsSet)
							{
								this.method_31();
							}
							return;
						}
						Class335.smethod_2(JoeFishRunning.string_28, true);
						base.method_17(this.class98_0.SellFishBounds, this.class106_0);
						this.uint_0 += 1U;
						@class.bool_0 = true;
						Class335.smethod_2(JoeFishRunning.string_27, true);
						this.State = JoeFishRunning.Enum109.const_3;
						break;
					}
				}
			}
			finally
			{
				if (@class.nullable_0 != null)
				{
					this.dateTime_1 = @class.nullable_0.Value;
				}
				else
				{
					this.dateTime_1 = DateTime.Now;
				}
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0009B924 File Offset: 0x00099B24
		private Point[] method_37(object state)
		{
			IntPtr mainWindowHandle = this.class142_0.ToonTownProcess.MainWindowHandle;
			if (!this.class142_0.ToonTownProcess.ProcessOpen)
			{
				return null;
			}
			CancellationToken token = (CancellationToken)state;
			token.ThrowIfCancellationRequested();
			Rectangle rectangle = Class410.smethod_16(mainWindowHandle);
			Size size = this.struct41_2.method_0(rectangle.Size);
			WaitHandle[] waitHandles = new WaitHandle[]
			{
				this.manualResetEventSlim_0.WaitHandle,
				token.WaitHandle
			};
			Point[] array = null;
			List<Point> list = new List<Point>();
			DateTime now = DateTime.Now;
			TimeSpan t = new TimeSpan(0, 0, 45);
			while (!this.manualResetEventSlim_0.IsSet)
			{
				Class335.smethod_2(JoeFishRunning.string_39, true);
				Rectangle[] array2 = this.method_38(token);
				if (array2 != null)
				{
					Point[] array3 = new Point[array2.Length];
					for (int i = 0; i < array2.Length; i++)
					{
						array3[i] = array2[i].smethod_9();
					}
					Class335.smethod_3(JoeFishRunning.string_38, new object[]
					{
						array3
					});
					if (this.class106_0.RequireStableTarget)
					{
						if (array != null && array.Length > 0)
						{
							Class335.smethod_3(JoeFishRunning.string_37, new object[]
							{
								array
							});
							Point[] array4 = array3;
							int j = 0;
							IL_1D5:
							while (j < array4.Length)
							{
								Point item = array4[j];
								foreach (Point point in array)
								{
									if (Math.Abs(item.X - point.X) <= size.Width && Math.Abs(item.Y - point.Y) <= size.Height)
									{
										list.Add(item);
										IL_1CF:
										j++;
										goto IL_1D5;
									}
								}
								goto IL_1CF;
							}
							if (list.Count > 0)
							{
								array3 = list.ToArray();
								Class335.smethod_3(JoeFishRunning.string_35, new object[]
								{
									array3
								});
								return array3;
							}
							Class335.smethod_2(JoeFishRunning.string_36, true);
						}
						array = array3;
					}
					else if (array3.Length > 0)
					{
						return array3;
					}
				}
				else
				{
					Class335.smethod_2(JoeFishRunning.string_40, true);
				}
				WaitHandle.WaitAny(waitHandles, 1000);
				token.ThrowIfCancellationRequested();
				if (DateTime.Now - now > t)
				{
					Class335.smethod_2(JoeFishRunning.string_41, true);
					return null;
				}
			}
			return null;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0009BBB0 File Offset: 0x00099DB0
		private Rectangle[] method_38(CancellationToken token)
		{
			JoeFishRunning.Class449 @class = new JoeFishRunning.Class449();
			if (!this.class142_0.ToonTownProcess.ProcessOpen)
			{
				return null;
			}
			Size minimum_size = this.struct41_0.method_0(this.class108_0.WindowClientSize);
			Size maximum_size = this.struct41_1.method_0(this.class108_0.WindowClientSize);
			@class.rectangle_0 = this.class98_0.CastBounds.method_0(this.class108_0.WindowClientSize);
			base.method_7();
			Rectangle[] array;
			using (Bitmap bitmap = Class364.smethod_3(this.intptr_0, this.class108_0.PondCapture.Bounds))
			{
				array = this.class108_0.PondCapture.method_8(bitmap, minimum_size, maximum_size, token);
			}
			if (array == null)
			{
				return null;
			}
			return array.Where(new Func<Rectangle, bool>(@class.method_0)).ToArray<Rectangle>();
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		public static double smethod_2(Point castButton, Point fishTarget)
		{
			Point p = castButton;
			Point p2 = fishTarget;
			Point p3 = new Point(p2.X, p.Y);
			float num = Class477.smethod_9(p, p2);
			float num2 = Class477.smethod_9(p3, p2);
			double angleB = 90.0;
			return Class477.smethod_10((double)num2, (double)num, angleB);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0009BD0C File Offset: 0x00099F0C
		private static Point? smethod_3(Point castButton, Point[] targets)
		{
			double[] array = new double[targets.Length];
			for (int i = 0; i < targets.Length; i++)
			{
				array[i] = JoeFishRunning.smethod_2(castButton, targets[i]);
			}
			double num = double.MinValue;
			int num2 = -1;
			for (int j = 0; j < targets.Length; j++)
			{
				if (!double.IsNaN(array[j]) && array[j] > num)
				{
					num = array[j];
					num2 = j;
				}
			}
			if (num2 == -1)
			{
				return null;
			}
			return new Point?(targets[num2]);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0009BDA0 File Offset: 0x00099FA0
		private void method_39(out float min_castratio, out float max_castratio)
		{
			switch (this.class108_0.Playground)
			{
			case Enum57.const_1:
				min_castratio = 1.3f;
				max_castratio = 1.37f;
				return;
			case Enum57.const_2:
				min_castratio = 1.3f;
				max_castratio = 1.365f;
				return;
			case Enum57.const_3:
				min_castratio = 1.3f;
				max_castratio = 1.365f;
				return;
			case Enum57.const_4:
				min_castratio = 1.3f;
				max_castratio = 1.365f;
				return;
			case Enum57.const_5:
				min_castratio = 1.3f;
				max_castratio = 1.37f;
				return;
			case Enum57.const_9:
				min_castratio = 1.3f;
				max_castratio = 1.37f;
				return;
			case Enum57.const_10:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			case Enum57.const_11:
				min_castratio = 1.3f;
				max_castratio = 1.37f;
				return;
			case Enum57.const_12:
				min_castratio = 1.3f;
				max_castratio = 1.37f;
				return;
			case Enum57.const_13:
				min_castratio = 1.3f;
				max_castratio = 1.39f;
				return;
			case Enum57.const_14:
				min_castratio = 1.3f;
				max_castratio = 1.39f;
				return;
			case Enum57.const_15:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			case Enum57.const_16:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			case Enum57.const_17:
				min_castratio = 1.3f;
				max_castratio = 1.39f;
				return;
			case Enum57.const_18:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_19:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_20:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_21:
				min_castratio = 1.3f;
				max_castratio = 1.32f;
				return;
			case Enum57.const_22:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_23:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_24:
				min_castratio = 1.3f;
				max_castratio = 1.382f;
				return;
			case Enum57.const_25:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			case Enum57.const_26:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			case Enum57.const_27:
				min_castratio = 1.3f;
				max_castratio = 1.38f;
				return;
			}
			min_castratio = 1.3f;
			max_castratio = 1.34f;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0009BFA8 File Offset: 0x0009A1A8
		private Point method_40(Point castButton, Point fishTarget)
		{
			Point p = castButton;
			Point p2 = fishTarget;
			Point p3 = new Point(p2.X, p.Y);
			float num = Class477.smethod_9(p, p2);
			float num2 = Class477.smethod_9(p3, p2);
			float num3 = Class477.smethod_9(p3, p);
			double angleB = 90.0;
			double num4 = Class477.smethod_10((double)num2, (double)num, angleB);
			float num5;
			float num6;
			this.method_39(out num5, out num6);
			double num7 = num4 / 90.0 * (double)(num6 - num5) + (double)num5;
			double num8 = (double)num2 * num7;
			double num9 = (double)num3 * num7;
			Point result;
			if (p2.X > p.X)
			{
				result = new Point((int)((double)p2.X - num9), (int)((double)p2.Y + num8));
			}
			else
			{
				result = new Point((int)((double)p2.X + num9), (int)((double)p2.Y + num8));
			}
			if (!double.IsNaN(num4) && num4 != 0.0)
			{
				double num10 = (90.0 - num4) / 90.0 * 12.0 + 0.0;
				if (p2.X > p.X)
				{
					num10 *= -1.0;
				}
				num10 = Class477.smethod_11(num10);
				Point empty = Point.Empty;
				empty.X = (int)(Math.Cos(num10) * (double)(result.X - p.X) - Math.Sin(num10) * (double)(result.Y - p.Y) + (double)p.X);
				empty.Y = (int)(Math.Sin(num10) * (double)(result.X - p.X) + Math.Cos(num10) * (double)(result.Y - p.Y) + (double)p.Y);
				return empty;
			}
			return result;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0009C1A4 File Offset: 0x0009A3A4
		private bool method_41()
		{
			switch (base.method_20(1000, this.class98_0.ExitFishingCapture, this.class98_0.ExitFishingBounds, this.class106_0, null))
			{
			case Enum107.const_0:
				return true;
			case Enum107.const_2:
				if (this.enum109_0 == JoeFishRunning.Enum109.const_3)
				{
					this.dateTime_1 = DateTime.Now;
				}
				this.method_27();
				return false;
			}
			return false;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0009C210 File Offset: 0x0009A410
		private bool method_42(List<PointF> path)
		{
			this.class149_0.method_4();
			bool result;
			try
			{
				if (path == null)
				{
					result = Class269.smethod_6(this.class142_0, this.manualResetEventSlim_0, this.class101_0, this.class108_0, this.class106_0);
				}
				else
				{
					result = Class269.smethod_7(this.class142_0, this.manualResetEventSlim_0, path, this.class106_0);
				}
			}
			finally
			{
				this.class149_0.method_5();
			}
			return result;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0009C28C File Offset: 0x0009A48C
		private bool method_43(out List<PointF> reversePath)
		{
			reversePath = null;
			bool result;
			try
			{
				JoeFishRunning.Class450 @class = new JoeFishRunning.Class450();
				this.class149_0.method_4();
				Struct56? @struct = Class269.smethod_0(this.class142_0, this.manualResetEventSlim_0, -1);
				if (@struct == null)
				{
					result = false;
				}
				else
				{
					Enum57 playground = this.class142_0.Playground;
					Dictionary<PointF, Enum99> dictionary;
					if (this.class101_0.WayPoints.ContainsKey(playground))
					{
						dictionary = this.class101_0.WayPoints[playground];
					}
					else
					{
						dictionary = null;
					}
					PointF? pointF = null;
					foreach (KeyValuePair<PointF, Enum99> keyValuePair in dictionary)
					{
						if (keyValuePair.Value == Enum99.flag_1)
						{
							pointF = new PointF?(keyValuePair.Key);
							break;
						}
					}
					if (pointF == null)
					{
						result = false;
					}
					else if (@struct.Value.IsDock && !this.method_44(out @struct))
					{
						result = false;
					}
					else
					{
						List<PointF> list = Class269.smethod_21(dictionary, @struct.Value.Location, pointF.Value);
						reversePath = new List<PointF>(list);
						reversePath.Reverse();
						reversePath.RemoveAt(0);
						reversePath.Add(@struct.Value.Location);
						@class.bool_0 = false;
						if (this.class142_0.ToonTownProcess.ProcessOpen)
						{
							@class.nullable_0 = null;
							EventHandler eventHandler = null;
							JoeFishRunning.Class451 class2 = new JoeFishRunning.Class451();
							class2.class450_0 = @class;
							class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
							try
							{
								try
								{
									JoeFishRunning.Class452 class3 = new JoeFishRunning.Class452();
									Class141 toonTownProcess = this.class142_0.ToonTownProcess;
									if (eventHandler == null)
									{
										eventHandler = new EventHandler(class2.method_0);
									}
									toonTownProcess.ProcessExited += eventHandler;
									class3.waitHandle_0 = new WaitHandle[]
									{
										this.manualResetEventSlim_0.WaitHandle,
										class2.manualResetEventSlim_0.WaitHandle
									};
									Action<object> action = null;
									JoeFishRunning.Class453 class4 = new JoeFishRunning.Class453();
									class4.class452_0 = class3;
									class4.class451_0 = class2;
									class4.class450_0 = @class;
									class4.joeFishRunning_0 = this;
									class4.cancellationTokenSource_0 = new CancellationTokenSource();
									try
									{
										if (action == null)
										{
											action = new Action<object>(class4.method_0);
										}
										using (Task task = new Task(action, class4.cancellationTokenSource_0.Token))
										{
											try
											{
												task.Start();
												Class269.smethod_2(this.class142_0, this.manualResetEventSlim_0, class2.manualResetEventSlim_0, list, this.class106_0, true);
												WaitHandle.WaitAny(class3.waitHandle_0, 2000);
												class2.manualResetEventSlim_0.Set();
												if (!this.class142_0.ToonTownProcess.ProcessOpen)
												{
													return false;
												}
												return @class.nullable_0 != null && @class.nullable_0.Value == Enum107.const_0;
											}
											finally
											{
												class4.cancellationTokenSource_0.Cancel();
												try
												{
													task.Wait();
												}
												catch (AggregateException)
												{
												}
											}
										}
									}
									finally
									{
										if (class4.cancellationTokenSource_0 != null)
										{
											((IDisposable)class4.cancellationTokenSource_0).Dispose();
										}
									}
								}
								finally
								{
									@class.bool_0 = true;
								}
							}
							finally
							{
								if (class2.manualResetEventSlim_0 != null)
								{
									((IDisposable)class2.manualResetEventSlim_0).Dispose();
								}
							}
						}
						result = false;
					}
				}
			}
			finally
			{
				this.class149_0.method_5();
			}
			return result;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0009C69C File Offset: 0x0009A89C
		private bool method_44(out Struct56? coords)
		{
			JoeFishRunning.Class454 @class = new JoeFishRunning.Class454();
			@class.joeFishRunning_0 = this;
			@class.bool_0 = false;
			Action action = null;
			JoeFishRunning.Class455 class2 = new JoeFishRunning.Class455();
			class2.class454_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			bool result;
			try
			{
				try
				{
					if (action == null)
					{
						action = new Action(class2.method_0);
					}
					using (Task task = new Task(action))
					{
						task.Start();
						try
						{
							result = this.method_46(out coords);
						}
						finally
						{
							class2.manualResetEventSlim_0.Set();
							task.Wait();
						}
					}
				}
				finally
				{
					@class.bool_0 = true;
				}
			}
			finally
			{
				if (class2.manualResetEventSlim_0 != null)
				{
					((IDisposable)class2.manualResetEventSlim_0).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0009C770 File Offset: 0x0009A970
		private bool method_45()
		{
			Struct56? @struct;
			return this.method_46(out @struct);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0009C788 File Offset: 0x0009A988
		private bool method_46(out Struct56? coords)
		{
			coords = null;
			try
			{
				this.class149_0.method_4();
				coords = Class269.smethod_1(this.class142_0, this.manualResetEventSlim_0, this.class149_0);
			}
			finally
			{
				this.class149_0.method_5();
			}
			return coords != null;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0009C7E8 File Offset: 0x0009A9E8
		private bool method_47(out Class108 dock)
		{
			this.State = JoeFishRunning.Enum109.const_2;
			dock = null;
			base.method_7();
			Enum107 @enum = Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.CastCapture, this.class98_0.CastBounds, this.class106_0);
			Bitmap[] array = new Bitmap[14];
			Bitmap bitmap = null;
			bool result;
			try
			{
				Enum107 enum2 = @enum;
				if (enum2 == Enum107.const_0)
				{
					Rectangle rectangle = Class410.smethod_16(this.intptr_0);
					bitmap = this.method_57();
					JoeFishRunning.Class456 @class = new JoeFishRunning.Class456();
					@class.timer_0 = new System.Timers.Timer();
					try
					{
						JoeFishRunning.Class457 class2 = new JoeFishRunning.Class457();
						class2.class456_0 = @class;
						class2.joeFishRunning_0 = this;
						Rectangle rectangle2 = Class410.smethod_14(this.intptr_0);
						class2.bool_0 = false;
						class2.bool_1 = true;
						@class.timer_0.Elapsed += class2.method_0;
						@class.timer_0.Interval = 5000.0;
						@class.timer_0.Enabled = true;
						int num = 0;
						while (num < 14 && !this.manualResetEventSlim_0.IsSet)
						{
							if (Class410.smethod_24(this.intptr_0, rectangle2.Size, true))
							{
								base.method_21(this.manualResetEventSlim_0);
								if (this.manualResetEventSlim_0.IsSet)
								{
									break;
								}
							}
							array[num] = this.method_56();
							this.manualResetEventSlim_0.Wait(4000);
							num++;
						}
						class2.bool_1 = false;
						@class.timer_0.Enabled = false;
					}
					finally
					{
						if (@class.timer_0 != null)
						{
							((IDisposable)@class.timer_0).Dispose();
						}
					}
					if (this.manualResetEventSlim_0.IsSet)
					{
						return false;
					}
					do
					{
						base.method_7();
						Enum107 enum3 = Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.ExitFishingCapture, this.class98_0.ExitFishingBounds, this.class106_0);
						if (enum3 == Enum107.const_0)
						{
							goto IL_20F;
						}
						if (enum3 != Enum107.const_1)
						{
							goto IL_201;
						}
					}
					while (DialogBox.smethod_6(JoeFishRunning.string_76, JoeFishRunning.string_77, new Enum39[]
					{
						Enum39.const_3,
						Enum39.const_1
					}) == DialogResult.Retry);
					return false;
					IL_201:
					this.method_27();
					return false;
					IL_20F:
					Struct56? @struct;
					if (!this.method_44(out @struct))
					{
						return false;
					}
					Class95<Struct54> class3 = null;
					Func<Class95<Struct54>> func = null;
					JoeFishRunning.Class458 class4 = new JoeFishRunning.Class458();
					class4.class125_0 = Class125.smethod_2(array);
					try
					{
						if (func == null)
						{
							func = new Func<Class95<Struct54>>(class4.method_0);
						}
						class3 = base.method_3<Class95<Struct54>>(func);
					}
					finally
					{
						if (class4.class125_0 != null)
						{
							((IDisposable)class4.class125_0).Dispose();
						}
					}
					if (class3 == null)
					{
						this.method_24();
						dock = null;
						return false;
					}
					Bitmap bitmap2 = null;
					try
					{
						bitmap2 = this.method_54(bitmap);
						dock = new Class108(this.class142_0.Playground, @struct.Value.Location, rectangle.Size, class3, new Class150(bitmap2, true));
						return true;
					}
					catch
					{
						if (bitmap2 != null)
						{
							bitmap2.Dispose();
						}
						bitmap2 = null;
						throw;
					}
				}
				this.method_25();
				dock = null;
				result = false;
			}
			finally
			{
				array.smethod_1<Bitmap>();
				if (bitmap != null)
				{
					bitmap.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0009CB50 File Offset: 0x0009AD50
		private bool method_48()
		{
			switch (this.method_55())
			{
			case JoeFishRunning.Enum110.const_1:
				base.method_17(this.class98_0.FishCaughtBounds, this.class106_0);
				return true;
			case JoeFishRunning.Enum110.const_2:
				base.method_17(this.class98_0.BootCaughtBounds, this.class106_0);
				return true;
			case JoeFishRunning.Enum110.const_3:
				base.method_17(this.class98_0.FishCaughtDuringBingoBounds, this.class106_0);
				return true;
			case JoeFishRunning.Enum110.const_9:
			case JoeFishRunning.Enum110.const_10:
				return true;
			}
			return false;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0009CBE8 File Offset: 0x0009ADE8
		private bool method_49()
		{
			if (!this.method_48())
			{
				return false;
			}
			Class108 @class = null;
			if (this.method_50(out @class))
			{
				Size sz = Class410.smethod_18(this.intptr_0);
				if (sz != @class.WindowClientSize && Class410.smethod_17(this.intptr_0, @class.WindowClientSize))
				{
					base.method_21(this.manualResetEventSlim_0);
				}
				this.class108_0 = @class;
				return true;
			}
			Class108 item;
			if (this.method_47(out item))
			{
				if (@class != null)
				{
					@class.Dispose();
					this.class103_0.Docks.Remove(@class);
				}
				this.class103_0.Docks.Add(item);
				this.class108_0 = item;
				return true;
			}
			return false;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0009CC90 File Offset: 0x0009AE90
		private bool method_50(out Class108 dock)
		{
			this.State = JoeFishRunning.Enum109.const_1;
			using (Bitmap bitmap = this.method_57())
			{
				if (this.method_51(bitmap, out dock))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0009CCD8 File Offset: 0x0009AED8
		private bool method_51(Bitmap fullPond, out Class108 result)
		{
			using (Bitmap bitmap = this.method_54(fullPond))
			{
				using (Class150 @class = new Class150(bitmap, false))
				{
					foreach (Class108 class2 in this.class103_0.Docks)
					{
						if (class2.Playground == this.class142_0.Playground && Class150.smethod_2(@class, class2.DockReferenceCapture, 0, 0) < 20)
						{
							result = class2;
							return true;
						}
					}
				}
			}
			result = null;
			return false;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0009CDA0 File Offset: 0x0009AFA0
		private bool method_52()
		{
			Class108 @class;
			if (this.method_47(out @class))
			{
				List<Class108> docks = this.class103_0.Docks;
				Class108 class2;
				if (this.method_50(out class2))
				{
					class2.Dispose();
					docks.Remove(class2);
				}
				for (int i = docks.Count - 1; i >= 0; i--)
				{
					class2 = docks[i];
					if (class2.Playground == @class.Playground && Class477.smethod_9(class2.DockLocation, @class.DockLocation) <= 1f)
					{
						docks.Remove(class2);
					}
				}
				docks.Add(@class);
				return true;
			}
			return false;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0009CE30 File Offset: 0x0009B030
		private Bitmap method_53(Bitmap bmp, Size full_size)
		{
			Bitmap bitmap = null;
			Bitmap bitmap2 = null;
			Bitmap result;
			try
			{
				if (bmp.Size == full_size)
				{
					bitmap = bmp;
				}
				else
				{
					bitmap = new Bitmap(full_size.Width, full_size.Height);
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.InterpolationMode = InterpolationMode.High;
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						graphics.DrawImage(bmp, new Rectangle(Point.Empty, full_size));
					}
				}
				Rectangle rectangle = this.struct46_0.method_0(full_size);
				bitmap2 = new Bitmap(rectangle.Width, rectangle.Height);
				using (Graphics graphics2 = Graphics.FromImage(bitmap2))
				{
					graphics2.InterpolationMode = InterpolationMode.High;
					graphics2.SmoothingMode = SmoothingMode.AntiAlias;
					graphics2.DrawImage(bitmap, rectangle, rectangle, GraphicsUnit.Pixel);
				}
				result = bitmap2;
			}
			catch
			{
				if (bitmap2 != null)
				{
					bitmap2.Dispose();
				}
				throw;
			}
			finally
			{
				if (bitmap != null && !object.ReferenceEquals(bmp, bitmap))
				{
					bitmap.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x0009CF4C File Offset: 0x0009B14C
		private Bitmap method_54(Bitmap bmp)
		{
			Bitmap bitmap = null;
			Bitmap result;
			try
			{
				bitmap = new Bitmap(this.size_0.Width, this.size_0.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.InterpolationMode = InterpolationMode.High;
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.DrawImage(bmp, new Rectangle(Point.Empty, this.size_0));
				}
				result = bitmap;
			}
			catch
			{
				if (bitmap != null)
				{
					bitmap.Dispose();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		private JoeFishRunning.Enum110 method_55()
		{
			base.method_7();
			if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.FishCaughtCapture, this.class98_0.FishCaughtBounds, this.class106_0) == Enum107.const_0)
			{
				if (this.class106_0.StopWhenNewSpecies && Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.NewSpeciesCapture, this.class98_0.NewSpeciesBounds, this.class106_0) == Enum107.const_0)
				{
					return JoeFishRunning.Enum110.const_5;
				}
				return JoeFishRunning.Enum110.const_1;
			}
			else
			{
				if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.BootCaughtCapture, this.class98_0.BootCaughtBounds, this.class106_0) == Enum107.const_0)
				{
					return JoeFishRunning.Enum110.const_2;
				}
				if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.FishCaughtDuringBingoCapture, this.class98_0.FishCaughtDuringBingoBounds, this.class106_0) == Enum107.const_0)
				{
					if (this.class106_0.StopWhenNewSpecies && Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.NewSpeciesDuringBingoCapture, this.class98_0.NewSpeciesDuringBingoBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_6;
					}
					return JoeFishRunning.Enum110.const_3;
				}
				else
				{
					if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.BucketFullCapture, this.class98_0.BucketFullBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_4;
					}
					if (this.class142_0.Playground == Enum57.const_1 && Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.EstateSellFishCapture, this.class98_0.EstateSellFishBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_7;
					}
					if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.NoBeansCapture, this.class98_0.NoBeansBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_8;
					}
					if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.CastCapture, this.class98_0.CastBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_9;
					}
					if (Class433.smethod_0(this.class142_0.ToonTownProcess, this.class98_0.ExitFishingCapture, this.class98_0.ExitFishingBounds, this.class106_0) == Enum107.const_0)
					{
						return JoeFishRunning.Enum110.const_10;
					}
					return JoeFishRunning.Enum110.const_0;
				}
			}
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0009D204 File Offset: 0x0009B404
		private Bitmap method_56()
		{
			base.method_7();
			Rectangle rectangle = Class410.smethod_16(this.intptr_0);
			Rectangle rec = this.struct46_0.method_0(rectangle.Size);
			return Class364.smethod_3(this.intptr_0, rec);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x0009D248 File Offset: 0x0009B448
		private Bitmap method_57()
		{
			base.method_7();
			Rectangle rectangle = Class410.smethod_16(this.intptr_0);
			if (rectangle.Width < this.size_0.Width || rectangle.Height < this.size_0.Height)
			{
				int width = Math.Max(this.size_0.Width, rectangle.Width);
				int height = Math.Max(this.size_0.Height, rectangle.Height);
				Class410.smethod_17(this.intptr_0, new Size(width, height));
				base.method_21(this.manualResetEventSlim_0);
			}
			return Class364.smethod_2(this.intptr_0);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0009D2FC File Offset: 0x0009B4FC
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(JoeFishRunning));
			this.JoeFishStatus = new Label();
			base.SuspendLayout();
			this.JoeFishStatus.AutoSize = true;
			this.JoeFishStatus.Location = new Point(12, 14);
			this.JoeFishStatus.Name = "JoeFishStatus";
			this.JoeFishStatus.Size = new Size(102, 13);
			this.JoeFishStatus.TabIndex = 1;
			this.JoeFishStatus.Text = "Joe Fish: Thinking...";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(286, 40);
			base.Controls.Add(this.JoeFishStatus);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "JoeFishRunning";
			base.OnStartRunning += this.method_35;
			base.Controls.SetChildIndex(this.JoeFishStatus, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x0009D41C File Offset: 0x0009B61C
		[CompilerGenerated]
		private void method_58()
		{
			switch (this.enum109_0)
			{
			case JoeFishRunning.Enum109.const_0:
				this.JoeFishStatus.Text = JoeFishRunning.string_66;
				return;
			case JoeFishRunning.Enum109.const_1:
				this.JoeFishStatus.Text = JoeFishRunning.string_68;
				return;
			case JoeFishRunning.Enum109.const_2:
				this.JoeFishStatus.Text = JoeFishRunning.string_67;
				return;
			case JoeFishRunning.Enum109.const_3:
				this.JoeFishStatus.Text = JoeFishRunning.string_69;
				return;
			case JoeFishRunning.Enum109.const_4:
				this.JoeFishStatus.Text = JoeFishRunning.string_70;
				return;
			case JoeFishRunning.Enum109.const_5:
				this.JoeFishStatus.Text = JoeFishRunning.string_71;
				return;
			case JoeFishRunning.Enum109.const_6:
				this.JoeFishStatus.Text = JoeFishRunning.string_72;
				return;
			default:
				return;
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00013015 File Offset: 0x00011215
		[CompilerGenerated]
		private static void smethod_4()
		{
			DialogBox.smethod_3(JoeFishRunning.string_42, JoeFishRunning.string_43);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00013026 File Offset: 0x00011226
		[CompilerGenerated]
		private static void smethod_5()
		{
			DialogBox.smethod_3(JoeFishRunning.string_64, JoeFishRunning.string_65);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00013037 File Offset: 0x00011237
		[CompilerGenerated]
		private static void smethod_6()
		{
			DialogBox.smethod_3(JoeFishRunning.string_62, JoeFishRunning.string_63);
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00013048 File Offset: 0x00011248
		[CompilerGenerated]
		private static void smethod_7()
		{
			DialogBox.smethod_4(JoeFishRunning.string_60, JoeFishRunning.string_61);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00013059 File Offset: 0x00011259
		[CompilerGenerated]
		private static void smethod_8()
		{
			DialogBox.smethod_4(JoeFishRunning.string_58, JoeFishRunning.string_59);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0001306A File Offset: 0x0001126A
		[CompilerGenerated]
		private static void smethod_9()
		{
			DialogBox.smethod_3(JoeFishRunning.string_56, JoeFishRunning.string_57);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0001307B File Offset: 0x0001127B
		[CompilerGenerated]
		private static void smethod_10()
		{
			DialogBox.smethod_3(JoeFishRunning.string_54, JoeFishRunning.string_55);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0001308C File Offset: 0x0001128C
		[CompilerGenerated]
		private static void smethod_11()
		{
			DialogBox.smethod_4(JoeFishRunning.string_52, JoeFishRunning.string_53);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0001309D File Offset: 0x0001129D
		[CompilerGenerated]
		private static void smethod_12()
		{
			DialogBox.smethod_4(JoeFishRunning.string_50, JoeFishRunning.string_51);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000130AE File Offset: 0x000112AE
		[CompilerGenerated]
		private static void smethod_13()
		{
			DialogBox.smethod_3(JoeFishRunning.string_48, JoeFishRunning.string_49);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000130BF File Offset: 0x000112BF
		[CompilerGenerated]
		private static void smethod_14()
		{
			DialogBox.smethod_3(JoeFishRunning.string_46, JoeFishRunning.string_47);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000130D0 File Offset: 0x000112D0
		[CompilerGenerated]
		private static void smethod_15()
		{
			DialogBox.smethod_3(JoeFishRunning.string_44, JoeFishRunning.string_45);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000130E1 File Offset: 0x000112E1
		[CompilerGenerated]
		private static bool smethod_16(KeyValuePair<PointF, Enum99> item)
		{
			return item.Value == Enum99.flag_1;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0009D4CC File Offset: 0x0009B6CC
		[CompilerGenerated]
		private void method_59()
		{
			try
			{
				switch (this.enum50_0)
				{
				case Enum50.const_0:
					if (this.method_41() && this.method_49())
					{
						this.State = JoeFishRunning.Enum109.const_3;
						this.dateTime_0 = DateTime.Now;
						this.method_36();
						base.method_1(DialogResult.OK);
					}
					else
					{
						base.method_1(DialogResult.Cancel);
					}
					break;
				case Enum50.const_1:
					if (this.method_41() && this.method_52())
					{
						this.method_32();
						base.method_1(DialogResult.OK);
					}
					else
					{
						base.method_1(DialogResult.Cancel);
					}
					break;
				default:
					base.method_1(DialogResult.None);
					break;
				}
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(JoeFishRunning.string_75, this.enum50_0.smethod_3())
				});
				this.method_26();
				base.method_1(DialogResult.None);
			}
		}

		// Token: 0x040014DF RID: 5343
		private static readonly string string_6 = "Detected New Species";

		// Token: 0x040014E0 RID: 5344
		private static readonly string string_7 = "Detected Estate Sell Fish Button";

		// Token: 0x040014E1 RID: 5345
		private static readonly string string_8 = "Cannot Continue";

		// Token: 0x040014E2 RID: 5346
		private static readonly string string_9 = "Detected Bucket Full";

		// Token: 0x040014E3 RID: 5347
		private static readonly string string_10 = "Detected Out Of Beans";

		// Token: 0x040014E4 RID: 5348
		private static readonly string string_11 = "Detected Fish Caught";

		// Token: 0x040014E5 RID: 5349
		private static readonly string string_12 = "Detected Boot Caught";

		// Token: 0x040014E6 RID: 5350
		private static readonly string string_13 = "Waiting for Fish Detector";

		// Token: 0x040014E7 RID: 5351
		private static readonly string string_14 = "Target Acquired";

		// Token: 0x040014E8 RID: 5352
		private static readonly string string_15 = "No Valid Fish Target";

		// Token: 0x040014E9 RID: 5353
		private static readonly string string_16 = "Fish Detected";

		// Token: 0x040014EA RID: 5354
		private static readonly string string_17 = "No Fish Detected";

		// Token: 0x040014EB RID: 5355
		private static readonly string string_18 = "Fish Detector Canceled";

		// Token: 0x040014EC RID: 5356
		private static readonly string string_19 = "Located Cast Button, Waiting for Fish Detector";

		// Token: 0x040014ED RID: 5357
		private static readonly string string_20 = "Resetting...";

		// Token: 0x040014EE RID: 5358
		private static readonly string string_21 = "Continuing...";

		// Token: 0x040014EF RID: 5359
		private static readonly string string_22 = "No Visible Captures, Waiting for Fish Detector";

		// Token: 0x040014F0 RID: 5360
		private static readonly string string_23 = "Completed Wait";

		// Token: 0x040014F1 RID: 5361
		private static readonly string string_24 = "Client Size Changed, Waiting For Pixels";

		// Token: 0x040014F2 RID: 5362
		private static readonly string string_25 = "Beginning Actions";

		// Token: 0x040014F3 RID: 5363
		private static readonly string string_26 = "Failed to Navigate to Fisherman";

		// Token: 0x040014F4 RID: 5364
		private static readonly string string_27 = "Sold Fish";

		// Token: 0x040014F5 RID: 5365
		private static readonly string string_28 = "Navigated to Fisherman";

		// Token: 0x040014F6 RID: 5366
		private static readonly string string_29 = "Searching for Fisherman";

		// Token: 0x040014F7 RID: 5367
		private static readonly string string_30 = "Failed to Navigate to Dock";

		// Token: 0x040014F8 RID: 5368
		private static readonly string string_31 = "Exit Fishing Button Not Located";

		// Token: 0x040014F9 RID: 5369
		private static readonly string string_32 = "Exit Fishing Button Located";

		// Token: 0x040014FA RID: 5370
		private static readonly string string_33 = "Waiting for Exit Fishing Button";

		// Token: 0x040014FB RID: 5371
		private static readonly string string_34 = "Searching for Dock";

		// Token: 0x040014FC RID: 5372
		private static readonly string string_35 = "Valid Targets Found";

		// Token: 0x040014FD RID: 5373
		private static readonly string string_36 = "No Valid Targets Found";

		// Token: 0x040014FE RID: 5374
		private static readonly string string_37 = "Comparing with Last Targets";

		// Token: 0x040014FF RID: 5375
		private static readonly string string_38 = "Targets Found";

		// Token: 0x04001500 RID: 5376
		private static readonly string string_39 = "Searching For Fish";

		// Token: 0x04001501 RID: 5377
		private static readonly string string_40 = "No Targets Found";

		// Token: 0x04001502 RID: 5378
		private static readonly string string_41 = "Fish Detector Time Out";

		// Token: 0x04001503 RID: 5379
		private static readonly string string_42 = "Cannot continue fishing at estate without bingo.";

		// Token: 0x04001504 RID: 5380
		private static readonly string string_43 = "Bucket Full";

		// Token: 0x04001505 RID: 5381
		private static readonly string string_44 = "Joe Fish was unable to recognize this pond. The pond was either not setup or Joe Fish failed to recognize due to a technical issue. This can happen for a variety of reasons: graphical interference (e.g. toons or chat bubbles blocking the view), graphical abnormalities or capture failures. Please try again or use the Update Pond Capture option.";

		// Token: 0x04001506 RID: 5382
		private static readonly string string_45 = "Failed to Recognize Pond";

		// Token: 0x04001507 RID: 5383
		private static readonly string string_46 = "The pond region has been updated and is ready to be fished.";

		// Token: 0x04001508 RID: 5384
		private static readonly string string_47 = "Update Complete";

		// Token: 0x04001509 RID: 5385
		private static readonly string string_48 = "The pond has been configured and is ready to be fished.";

		// Token: 0x0400150A RID: 5386
		private static readonly string string_49 = "Training Complete";

		// Token: 0x0400150B RID: 5387
		private static readonly string string_50 = "Joe Fish was unable to navigate to the fisherman. Check if ToonTown is open and your way points/captures are setup properly.";

		// Token: 0x0400150C RID: 5388
		private static readonly string string_51 = "Fisherman Locate Failure";

		// Token: 0x0400150D RID: 5389
		private static readonly string string_52 = "Joe Fish was unable to navigate to the dock. Check if ToonTown is open and your way points are setup properly.";

		// Token: 0x0400150E RID: 5390
		private static readonly string string_53 = "Dock Locate Failure";

		// Token: 0x0400150F RID: 5391
		private static readonly string string_54 = "Your toon is out of beans and Joe Fish cannot continue.";

		// Token: 0x04001510 RID: 5392
		private static readonly string string_55 = "Out Of Beans";

		// Token: 0x04001511 RID: 5393
		private static readonly string string_56 = "ToonTown appears to have exited. Please open ToonTown and try again.";

		// Token: 0x04001512 RID: 5394
		private static readonly string string_57 = "ToonTown Closed";

		// Token: 0x04001513 RID: 5395
		private static readonly string string_58 = "The Exit Fishing button could not be successfully captured and compared. Check if ToonTown is open and your captures are setup properly.";

		// Token: 0x04001514 RID: 5396
		private static readonly string string_59 = "Capture Failure";

		// Token: 0x04001515 RID: 5397
		private static readonly string string_60 = "There has been an unknown error, details have been saved to the log file.";

		// Token: 0x04001516 RID: 5398
		private static readonly string string_61 = "Unknown Error";

		// Token: 0x04001517 RID: 5399
		private static readonly string string_62 = "The cast button was not located, you may need to customize the cast capture or location if the button is visible on your screen.";

		// Token: 0x04001518 RID: 5400
		private static readonly string string_63 = "Cast Button Not Found";

		// Token: 0x04001519 RID: 5401
		private static readonly string string_64 = "Cannot continue without a selected region to target for fishing.";

		// Token: 0x0400151A RID: 5402
		private static readonly string string_65 = "Missing Selected Region";

		// Token: 0x0400151B RID: 5403
		private static readonly string string_66 = "Joe Fish: Waiting for a dock.";

		// Token: 0x0400151C RID: 5404
		private static readonly string string_67 = "Joe Fish: Training...";

		// Token: 0x0400151D RID: 5405
		private static readonly string string_68 = "Joe Fish: Checking resources.";

		// Token: 0x0400151E RID: 5406
		private static readonly string string_69 = "Joe Fish: Searching for dock.";

		// Token: 0x0400151F RID: 5407
		private static readonly string string_70 = "Joe Fish: Fishing.";

		// Token: 0x04001520 RID: 5408
		private static readonly string string_71 = "Joe Fish: Searching for fisherman.";

		// Token: 0x04001521 RID: 5409
		private static readonly string string_72 = "Joe Fish: Complete.";

		// Token: 0x04001522 RID: 5410
		private static readonly string string_73 = "The way point file does not contain a fisherman for this playground. If you are in a valid playground, you may need to reinstall The ToonTown Spoofer or manually add the fisherman's location.";

		// Token: 0x04001523 RID: 5411
		private static readonly string string_74 = "Fisherman 404";

		// Token: 0x04001524 RID: 5412
		private static readonly string string_75 = "Run type: '{0}'.";

		// Token: 0x04001525 RID: 5413
		private static readonly string string_76 = "The exit fishing button is not visible. Try again?";

		// Token: 0x04001526 RID: 5414
		private static readonly string string_77 = "Exit Fishing Button Not Found";

		// Token: 0x04001527 RID: 5415
		private Class98 class98_0;

		// Token: 0x04001528 RID: 5416
		private Class103 class103_0;

		// Token: 0x04001529 RID: 5417
		private Enum50 enum50_0;

		// Token: 0x0400152A RID: 5418
		private Class108 class108_0;

		// Token: 0x0400152B RID: 5419
		private Class101 class101_0;

		// Token: 0x0400152C RID: 5420
		private Class106 class106_0;

		// Token: 0x0400152D RID: 5421
		private JoeFishRunning.Enum109 enum109_0;

		// Token: 0x0400152E RID: 5422
		private readonly Struct41 struct41_0;

		// Token: 0x0400152F RID: 5423
		private readonly Struct41 struct41_1;

		// Token: 0x04001530 RID: 5424
		private readonly Struct41 struct41_2;

		// Token: 0x04001531 RID: 5425
		private readonly Struct46 struct46_0;

		// Token: 0x04001532 RID: 5426
		private readonly Size size_0;

		// Token: 0x04001533 RID: 5427
		private DateTime dateTime_0;

		// Token: 0x04001534 RID: 5428
		private DateTime dateTime_1;

		// Token: 0x04001535 RID: 5429
		private uint uint_0;

		// Token: 0x04001536 RID: 5430
		private uint uint_1;

		// Token: 0x04001537 RID: 5431
		private uint uint_2;

		// Token: 0x04001538 RID: 5432
		private uint uint_3;

		// Token: 0x0400153B RID: 5435
		private Label JoeFishStatus;

		// Token: 0x0400153C RID: 5436
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_0;

		// Token: 0x0400153D RID: 5437
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_1;

		// Token: 0x0400153E RID: 5438
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_2;

		// Token: 0x0400153F RID: 5439
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_3;

		// Token: 0x04001540 RID: 5440
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_4;

		// Token: 0x04001541 RID: 5441
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_5;

		// Token: 0x04001542 RID: 5442
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_6;

		// Token: 0x04001543 RID: 5443
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_7;

		// Token: 0x04001544 RID: 5444
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_8;

		// Token: 0x04001545 RID: 5445
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_9;

		// Token: 0x04001546 RID: 5446
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_10;

		// Token: 0x04001547 RID: 5447
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_11;

		// Token: 0x04001548 RID: 5448
		[CompilerGenerated]
		private static Func<KeyValuePair<PointF, Enum99>, bool> func_0;

		// Token: 0x0200043C RID: 1084
		private enum Enum109
		{
			// Token: 0x0400154A RID: 5450
			const_0,
			// Token: 0x0400154B RID: 5451
			const_1,
			// Token: 0x0400154C RID: 5452
			const_2,
			// Token: 0x0400154D RID: 5453
			const_3,
			// Token: 0x0400154E RID: 5454
			const_4,
			// Token: 0x0400154F RID: 5455
			const_5,
			// Token: 0x04001550 RID: 5456
			const_6
		}

		// Token: 0x0200043D RID: 1085
		private enum Enum110
		{
			// Token: 0x04001552 RID: 5458
			const_0,
			// Token: 0x04001553 RID: 5459
			const_1,
			// Token: 0x04001554 RID: 5460
			const_2,
			// Token: 0x04001555 RID: 5461
			const_3,
			// Token: 0x04001556 RID: 5462
			const_4,
			// Token: 0x04001557 RID: 5463
			const_5,
			// Token: 0x04001558 RID: 5464
			const_6,
			// Token: 0x04001559 RID: 5465
			const_7,
			// Token: 0x0400155A RID: 5466
			const_8,
			// Token: 0x0400155B RID: 5467
			const_9,
			// Token: 0x0400155C RID: 5468
			const_10
		}

		// Token: 0x0200043E RID: 1086
		[CompilerGenerated]
		private sealed class Class444
		{
			// Token: 0x0400155D RID: 5469
			public DateTime? nullable_0;

			// Token: 0x0400155E RID: 5470
			public bool bool_0;

			// Token: 0x0400155F RID: 5471
			public JoeFishRunning joeFishRunning_0;
		}

		// Token: 0x0200043F RID: 1087
		[CompilerGenerated]
		private sealed class Class445
		{
			// Token: 0x04001560 RID: 5472
			public int int_0;

			// Token: 0x04001561 RID: 5473
			public bool bool_0;
		}

		// Token: 0x02000440 RID: 1088
		[CompilerGenerated]
		private sealed class Class446
		{
			// Token: 0x04001562 RID: 5474
			public JoeFishRunning.Enum110 enum110_0;

			// Token: 0x04001563 RID: 5475
			public Point[] point_0;
		}

		// Token: 0x02000441 RID: 1089
		[CompilerGenerated]
		private sealed class Class447
		{
			// Token: 0x04001564 RID: 5476
			public CancellationTokenSource cancellationTokenSource_0;
		}

		// Token: 0x02000442 RID: 1090
		[CompilerGenerated]
		private sealed class Class448
		{
			// Token: 0x06002954 RID: 10580 RVA: 0x0009D880 File Offset: 0x0009BA80
			public bool method_0()
			{
				MethodInvoker methodInvoker = null;
				if (Class410.smethod_17(this.class444_0.joeFishRunning_0.intptr_0, this.class444_0.joeFishRunning_0.class108_0.WindowClientSize))
				{
					Class335.smethod_2(JoeFishRunning.string_24, true);
					this.class444_0.joeFishRunning_0.method_21(this.class444_0.joeFishRunning_0.manualResetEventSlim_0);
					Class335.smethod_2(JoeFishRunning.string_23, true);
				}
				this.task_0.Start();
				this.class446_0.enum110_0 = this.class444_0.joeFishRunning_0.method_55();
				JoeFishRunning.Enum110 enum110_ = this.class446_0.enum110_0;
				if (enum110_ != JoeFishRunning.Enum110.const_0)
				{
					if (enum110_ != JoeFishRunning.Enum110.const_9)
					{
						Class335.smethod_2(JoeFishRunning.string_13, true);
						if (!this.task_0.IsCompleted)
						{
							this.class447_0.cancellationTokenSource_0.Cancel();
						}
						try
						{
							this.task_0.Wait();
						}
						catch (AggregateException)
						{
						}
						switch (this.class446_0.enum110_0)
						{
						case JoeFishRunning.Enum110.const_1:
							Class335.smethod_2(JoeFishRunning.string_11, true);
							this.class444_0.bool_0 = false;
							this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.FishCaughtBounds, this.class444_0.joeFishRunning_0.class106_0);
							this.class444_0.joeFishRunning_0.uint_1 += 1U;
							this.class445_0.int_0++;
							break;
						case JoeFishRunning.Enum110.const_2:
							Class335.smethod_2(JoeFishRunning.string_12, true);
							this.class444_0.bool_0 = false;
							this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.BootCaughtBounds, this.class444_0.joeFishRunning_0.class106_0);
							this.class444_0.joeFishRunning_0.uint_2 += 1U;
							break;
						case JoeFishRunning.Enum110.const_3:
							Class335.smethod_2(JoeFishRunning.string_11, true);
							this.class444_0.bool_0 = false;
							this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.FishCaughtDuringBingoBounds, this.class444_0.joeFishRunning_0.class106_0);
							this.class444_0.joeFishRunning_0.uint_1 += 1U;
							this.class445_0.int_0++;
							break;
						case JoeFishRunning.Enum110.const_4:
						case JoeFishRunning.Enum110.const_8:
						{
							JoeFishRunning.Enum110 enum110_2 = this.class446_0.enum110_0;
							if (enum110_2 != JoeFishRunning.Enum110.const_4)
							{
								if (enum110_2 == JoeFishRunning.Enum110.const_8)
								{
									Class335.smethod_2(JoeFishRunning.string_10, true);
									if (this.class444_0.bool_0)
									{
										Class335.smethod_2(JoeFishRunning.string_8, true);
										this.class444_0.nullable_0 = new DateTime?(DateTime.Now);
										this.class444_0.joeFishRunning_0.method_29();
										return false;
									}
									if (this.class444_0.joeFishRunning_0.class108_0.Playground == Enum57.const_1)
									{
										Class335.smethod_2(JoeFishRunning.string_8, true);
										this.class444_0.nullable_0 = new DateTime?(DateTime.Now);
										this.class444_0.joeFishRunning_0.method_29();
										return false;
									}
									this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.NoBeansBounds, this.class444_0.joeFishRunning_0.class106_0);
								}
							}
							else
							{
								Class335.smethod_2(JoeFishRunning.string_9, true);
								if (this.class444_0.joeFishRunning_0.class108_0.Playground == Enum57.const_1)
								{
									Class335.smethod_2(JoeFishRunning.string_8, true);
									this.class444_0.nullable_0 = new DateTime?(DateTime.Now);
									this.class444_0.joeFishRunning_0.method_23();
									return false;
								}
								this.class444_0.bool_0 = false;
								this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.BucketFullBounds, this.class444_0.joeFishRunning_0.class106_0);
							}
							if (!this.class444_0.joeFishRunning_0.method_45())
							{
								return true;
							}
							this.class444_0.joeFishRunning_0.State = JoeFishRunning.Enum109.const_5;
							this.class445_0.bool_0 = true;
							break;
						}
						case JoeFishRunning.Enum110.const_5:
						case JoeFishRunning.Enum110.const_6:
						{
							Class335.smethod_2(JoeFishRunning.string_6, true);
							this.class444_0.bool_0 = false;
							this.class444_0.nullable_0 = new DateTime?(DateTime.Now);
							this.class444_0.joeFishRunning_0.uint_1 += 1U;
							RunBaseForm joeFishRunning_ = this.class444_0.joeFishRunning_0;
							if (methodInvoker == null)
							{
								methodInvoker = new MethodInvoker(this.method_1);
							}
							joeFishRunning_.method_2(methodInvoker);
							break;
						}
						case JoeFishRunning.Enum110.const_7:
							Class335.smethod_2(JoeFishRunning.string_7, true);
							this.class444_0.joeFishRunning_0.method_17(this.class444_0.joeFishRunning_0.class98_0.EstateSellFishBounds, this.class444_0.joeFishRunning_0.class106_0);
							this.class445_0.int_0 = 0;
							this.class444_0.joeFishRunning_0.uint_0 += 1U;
							this.class444_0.joeFishRunning_0.manualResetEventSlim_0.Wait(3000);
							break;
						}
						return true;
					}
					Class335.smethod_2(JoeFishRunning.string_19, true);
					try
					{
						this.task_0.Wait();
						this.class446_0.point_0 = this.task_0.Result;
					}
					catch (AggregateException)
					{
						Class335.smethod_2(JoeFishRunning.string_18, true);
						this.class446_0.point_0 = null;
					}
					if (this.class446_0.point_0 == null || this.class446_0.point_0.Length == 0)
					{
						Class335.smethod_2(JoeFishRunning.string_17, true);
						return true;
					}
					Class335.smethod_3(JoeFishRunning.string_16, new object[]
					{
						this.class446_0.point_0.Length
					});
					if (!this.class444_0.joeFishRunning_0.class142_0.ToonTownProcess.ProcessOpen)
					{
						return true;
					}
					Point point = this.class444_0.joeFishRunning_0.class98_0.CastBounds.method_0(Class410.smethod_16(this.class444_0.joeFishRunning_0.intptr_0).Size).smethod_9();
					Point? point2 = JoeFishRunning.smethod_3(point, this.class446_0.point_0);
					if (point2 == null)
					{
						Class335.smethod_3(JoeFishRunning.string_15, new object[]
						{
							point,
							this.class446_0.point_0
						});
						return true;
					}
					Point point3 = this.class444_0.joeFishRunning_0.method_40(point, point2.Value);
					Class335.smethod_3(JoeFishRunning.string_14, new object[]
					{
						point3
					});
					this.class444_0.joeFishRunning_0.method_14(point);
					this.class444_0.joeFishRunning_0.manualResetEventSlim_0.Wait(this.class444_0.joeFishRunning_0.class106_0.AfterMoveBeforeClickDelay);
					Class465.smethod_1(MouseButtons.Left);
					this.class444_0.joeFishRunning_0.manualResetEventSlim_0.Wait(this.class444_0.joeFishRunning_0.class106_0.CastDragDelay);
					this.class444_0.joeFishRunning_0.method_14(point3);
					this.class444_0.joeFishRunning_0.manualResetEventSlim_0.Wait(this.class444_0.joeFishRunning_0.class106_0.AfterMoveBeforeClickDelay);
					Class465.smethod_2(MouseButtons.Left);
					this.class444_0.joeFishRunning_0.manualResetEventSlim_0.Wait(this.class444_0.joeFishRunning_0.class106_0.AfterCastDelay);
					this.class444_0.joeFishRunning_0.uint_3 += 1U;
					return true;
				}
				else
				{
					Class335.smethod_2(JoeFishRunning.string_22, true);
					if (!this.task_0.IsCompleted)
					{
						this.class447_0.cancellationTokenSource_0.Cancel();
					}
					try
					{
						this.task_0.Wait();
					}
					catch (AggregateException)
					{
						Class335.smethod_2(JoeFishRunning.string_18, true);
					}
					Struct56? @struct = Class269.smethod_0(this.class444_0.joeFishRunning_0.class142_0, this.class444_0.joeFishRunning_0.manualResetEventSlim_0, -1);
					if (@struct != null && !@struct.Value.IsDock)
					{
						Class335.smethod_3(JoeFishRunning.string_20, new object[]
						{
							this.class445_0.int_0
						});
						if (this.class445_0.int_0 > 0)
						{
							this.class444_0.joeFishRunning_0.State = JoeFishRunning.Enum109.const_5;
						}
						else
						{
							this.class444_0.joeFishRunning_0.State = JoeFishRunning.Enum109.const_3;
						}
						this.class445_0.bool_0 = true;
						return true;
					}
					Class335.smethod_2(JoeFishRunning.string_21, true);
					return true;
				}
			}

			// Token: 0x06002955 RID: 10581 RVA: 0x0009E150 File Offset: 0x0009C350
			private void method_1()
			{
				using (Bitmap bitmap = Class364.smethod_2(this.class444_0.joeFishRunning_0.intptr_0))
				{
					using (JoeFishNewSpeciesCaught joeFishNewSpeciesCaught = new JoeFishNewSpeciesCaught())
					{
						joeFishNewSpeciesCaught.Screenshot = bitmap;
						joeFishNewSpeciesCaught.ShowDialog();
					}
				}
			}

			// Token: 0x04001565 RID: 5477
			public JoeFishRunning.Class447 class447_0;

			// Token: 0x04001566 RID: 5478
			public JoeFishRunning.Class446 class446_0;

			// Token: 0x04001567 RID: 5479
			public JoeFishRunning.Class445 class445_0;

			// Token: 0x04001568 RID: 5480
			public JoeFishRunning.Class444 class444_0;

			// Token: 0x04001569 RID: 5481
			public Task<Point[]> task_0;
		}

		// Token: 0x02000443 RID: 1091
		[CompilerGenerated]
		private sealed class Class449
		{
			// Token: 0x06002957 RID: 10583 RVA: 0x000130ED File Offset: 0x000112ED
			public bool method_0(Rectangle rec)
			{
				return !rec.smethod_0(this.rectangle_0);
			}

			// Token: 0x0400156A RID: 5482
			public Rectangle rectangle_0;
		}

		// Token: 0x02000444 RID: 1092
		[CompilerGenerated]
		private sealed class Class450
		{
			// Token: 0x0400156B RID: 5483
			public bool bool_0;

			// Token: 0x0400156C RID: 5484
			public Enum107? nullable_0;
		}

		// Token: 0x02000445 RID: 1093
		[CompilerGenerated]
		private sealed class Class451
		{
			// Token: 0x0600295A RID: 10586 RVA: 0x000130FE File Offset: 0x000112FE
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class450_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x0400156D RID: 5485
			public JoeFishRunning.Class450 class450_0;

			// Token: 0x0400156E RID: 5486
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x02000446 RID: 1094
		[CompilerGenerated]
		private sealed class Class452
		{
			// Token: 0x0400156F RID: 5487
			public WaitHandle[] waitHandle_0;
		}

		// Token: 0x02000447 RID: 1095
		[CompilerGenerated]
		private sealed class Class453
		{
			// Token: 0x0600295D RID: 10589 RVA: 0x0009E1BC File Offset: 0x0009C3BC
			public void method_0(object obj)
			{
				while (!this.joeFishRunning_0.manualResetEventSlim_0.IsSet && !this.class451_0.manualResetEventSlim_0.IsSet)
				{
					this.cancellationTokenSource_0.Token.ThrowIfCancellationRequested();
					this.joeFishRunning_0.method_7();
					this.class450_0.nullable_0 = new Enum107?(Class433.smethod_0(this.joeFishRunning_0.class142_0.ToonTownProcess, this.joeFishRunning_0.class98_0.SellFishCapture, this.joeFishRunning_0.class98_0.SellFishBounds, this.joeFishRunning_0.class106_0));
					if (this.class450_0.nullable_0 != null && this.class450_0.nullable_0.Value == Enum107.const_0)
					{
						this.class451_0.manualResetEventSlim_0.Set();
						return;
					}
					this.class450_0.nullable_0 = new Enum107?(Class433.smethod_0(this.joeFishRunning_0.class142_0.ToonTownProcess, this.joeFishRunning_0.class98_0.ExitFishingCapture, this.joeFishRunning_0.class98_0.ExitFishingBounds, this.joeFishRunning_0.class106_0));
					if (this.class450_0.nullable_0 != null && this.class450_0.nullable_0.Value == Enum107.const_0)
					{
						this.joeFishRunning_0.method_17(this.joeFishRunning_0.class98_0.ExitFishingBounds, this.joeFishRunning_0.class106_0);
					}
					WaitHandle.WaitAny(this.class452_0.waitHandle_0, 1000);
				}
			}

			// Token: 0x04001570 RID: 5488
			public JoeFishRunning.Class452 class452_0;

			// Token: 0x04001571 RID: 5489
			public JoeFishRunning.Class451 class451_0;

			// Token: 0x04001572 RID: 5490
			public JoeFishRunning.Class450 class450_0;

			// Token: 0x04001573 RID: 5491
			public CancellationTokenSource cancellationTokenSource_0;

			// Token: 0x04001574 RID: 5492
			public JoeFishRunning joeFishRunning_0;
		}

		// Token: 0x02000448 RID: 1096
		[CompilerGenerated]
		private sealed class Class454
		{
			// Token: 0x04001575 RID: 5493
			public bool bool_0;

			// Token: 0x04001576 RID: 5494
			public JoeFishRunning joeFishRunning_0;
		}

		// Token: 0x02000449 RID: 1097
		[CompilerGenerated]
		private sealed class Class455
		{
			// Token: 0x06002960 RID: 10592 RVA: 0x0009E354 File Offset: 0x0009C554
			public void method_0()
			{
				while (!this.class454_0.bool_0 && !this.manualResetEventSlim_0.IsSet)
				{
					this.class454_0.joeFishRunning_0.method_7();
					if (Class433.smethod_0(this.class454_0.joeFishRunning_0.class142_0.ToonTownProcess, this.class454_0.joeFishRunning_0.class98_0.ExitFishingCapture, this.class454_0.joeFishRunning_0.class98_0.ExitFishingBounds, this.class454_0.joeFishRunning_0.class106_0) == Enum107.const_0)
					{
						this.class454_0.joeFishRunning_0.method_17(this.class454_0.joeFishRunning_0.class98_0.ExitFishingBounds, this.class454_0.joeFishRunning_0.class106_0);
					}
					this.class454_0.joeFishRunning_0.method_9();
					if (!this.class454_0.bool_0)
					{
						this.manualResetEventSlim_0.Wait(500);
					}
				}
			}

			// Token: 0x04001577 RID: 5495
			public JoeFishRunning.Class454 class454_0;

			// Token: 0x04001578 RID: 5496
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x0200044A RID: 1098
		[CompilerGenerated]
		private sealed class Class456
		{
			// Token: 0x04001579 RID: 5497
			public System.Timers.Timer timer_0;
		}

		// Token: 0x0200044B RID: 1099
		[CompilerGenerated]
		private sealed class Class457
		{
			// Token: 0x06002963 RID: 10595 RVA: 0x0009E450 File Offset: 0x0009C650
			public void method_0(object sender, ElapsedEventArgs e)
			{
				this.class456_0.timer_0.Enabled = false;
				if (!this.joeFishRunning_0.manualResetEventSlim_0.IsSet)
				{
					Rectangle window_bounds = Class410.smethod_16(this.joeFishRunning_0.intptr_0);
					this.joeFishRunning_0.method_12(window_bounds, this.joeFishRunning_0.class98_0.CastBounds);
					this.joeFishRunning_0.manualResetEventSlim_0.Wait(this.joeFishRunning_0.class106_0.AfterMoveBeforeClickDelay);
					Class465.smethod_1(MouseButtons.Left);
					this.joeFishRunning_0.manualResetEventSlim_0.Wait(this.joeFishRunning_0.class106_0.CastDragDelay);
					if (this.bool_0)
					{
						Class465.smethod_5(window_bounds, new Point(0, window_bounds.Height));
					}
					else
					{
						Class465.smethod_5(window_bounds, new Point(window_bounds.Width, window_bounds.Height));
					}
					this.joeFishRunning_0.manualResetEventSlim_0.Wait(10000);
					Class465.smethod_2(MouseButtons.Left);
					this.joeFishRunning_0.manualResetEventSlim_0.Wait(2000);
					this.bool_0 = !this.bool_0;
					this.class456_0.timer_0.Enabled = this.bool_1;
				}
			}

			// Token: 0x0400157A RID: 5498
			public JoeFishRunning.Class456 class456_0;

			// Token: 0x0400157B RID: 5499
			public bool bool_0;

			// Token: 0x0400157C RID: 5500
			public bool bool_1;

			// Token: 0x0400157D RID: 5501
			public JoeFishRunning joeFishRunning_0;
		}

		// Token: 0x0200044C RID: 1100
		[CompilerGenerated]
		private sealed class Class458
		{
			// Token: 0x06002965 RID: 10597 RVA: 0x0009E590 File Offset: 0x0009C790
			public Class95<Struct54> method_0()
			{
				EventHandler eventHandler = null;
				JoeFishRunning.Class458.Class459 @class = new JoeFishRunning.Class458.Class459();
				@class.class458_0 = this;
				@class.pondRegionSelector_0 = new PondRegionSelector();
				Class95<Struct54> result;
				try
				{
					@class.pondRegionSelector_0.Image = this.class125_0.BaseBitmap;
					Form pondRegionSelector_ = @class.pondRegionSelector_0;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(@class.method_0);
					}
					pondRegionSelector_.Shown += eventHandler;
					if (@class.pondRegionSelector_0.ShowDialog() == DialogResult.OK)
					{
						result = @class.pondRegionSelector_0.method_0<Struct54>();
					}
					else
					{
						result = null;
					}
				}
				finally
				{
					if (@class.pondRegionSelector_0 != null)
					{
						((IDisposable)@class.pondRegionSelector_0).Dispose();
					}
				}
				return result;
			}

			// Token: 0x0400157E RID: 5502
			public Class125 class125_0;

			// Token: 0x0200044D RID: 1101
			private sealed class Class459
			{
				// Token: 0x06002967 RID: 10599 RVA: 0x00013118 File Offset: 0x00011318
				public void method_0(object sender, EventArgs e)
				{
					this.pondRegionSelector_0.Activate();
					this.pondRegionSelector_0.BringToFront();
				}

				// Token: 0x0400157F RID: 5503
				public JoeFishRunning.Class458 class458_0;

				// Token: 0x04001580 RID: 5504
				public PondRegionSelector pondRegionSelector_0;
			}
		}
	}
}
