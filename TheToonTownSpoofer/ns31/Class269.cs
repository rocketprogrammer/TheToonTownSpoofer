using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns16;
using ns18;
using ns19;
using ns20;
using ns26;
using ns27;
using ns28;
using ns29;

namespace ns31
{
	// Token: 0x020002E6 RID: 742
	internal static class Class269
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x0005E410 File Offset: 0x0005C610
		public static Struct56? smethod_0(Class142 toontownWindow, ManualResetEventSlim waitHandle, int timeOut = -1)
		{
			Class269.Class270 @class = new Class269.Class270();
			@class.nullable_0 = null;
			@class.bool_0 = false;
			EventHandler<EventArgs22> eventHandler = null;
			EventHandler eventHandler2 = null;
			Class269.Class271 class2 = new Class269.Class271();
			class2.class270_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			try
			{
				try
				{
					Class129 logMonitor = toontownWindow.LogMonitor;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs22>(class2.method_0);
					}
					logMonitor.CoordinatesChanged += eventHandler;
					Class141 toonTownProcess = toontownWindow.ToonTownProcess;
					if (eventHandler2 == null)
					{
						eventHandler2 = new EventHandler(class2.method_1);
					}
					toonTownProcess.ProcessExited += eventHandler2;
					IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
					if (!toontownWindow.ToonTownProcess.ProcessOpen)
					{
						return null;
					}
					Class269.smethod_20(mainWindowHandle, class2.manualResetEventSlim_0);
					WaitHandle.WaitAny(new WaitHandle[]
					{
						waitHandle.WaitHandle,
						class2.manualResetEventSlim_0.WaitHandle
					}, timeOut);
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
			return @class.nullable_0;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0005E534 File Offset: 0x0005C734
		public static Struct56? smethod_1(Class142 toontownWindow, ManualResetEventSlim waitHandle, Class149 coordinatePoll)
		{
			Class269.Class272 @class = new Class269.Class272();
			@class.nullable_0 = null;
			@class.bool_0 = false;
			EventHandler<EventArgs22> eventHandler = null;
			EventHandler eventHandler2 = null;
			Class269.Class273 class2 = new Class269.Class273();
			class2.class272_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			try
			{
				try
				{
					Class129 logMonitor = toontownWindow.LogMonitor;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs22>(class2.method_0);
					}
					logMonitor.CoordinatesChanged += eventHandler;
					Class141 toonTownProcess = toontownWindow.ToonTownProcess;
					if (eventHandler2 == null)
					{
						eventHandler2 = new EventHandler(class2.method_1);
					}
					toonTownProcess.ProcessExited += eventHandler2;
					if (!toontownWindow.ToonTownProcess.ProcessOpen)
					{
						return null;
					}
					coordinatePoll.method_4();
					WaitHandle.WaitAny(new WaitHandle[]
					{
						waitHandle.WaitHandle,
						class2.manualResetEventSlim_0.WaitHandle
					});
					coordinatePoll.method_5();
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
			return @class.nullable_0;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0005E644 File Offset: 0x0005C844
		public static bool smethod_2(Class142 toontownWindow, ManualResetEventSlim waitHandle, ManualResetEventSlim navigateWaitHandle, List<PointF> path, Class104 settings, bool jump = true)
		{
			for (int i = 0; i < path.Count; i++)
			{
				if (!Class269.smethod_5(toontownWindow, waitHandle, navigateWaitHandle, settings, path[i], jump, i == path.Count - 1))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0005E688 File Offset: 0x0005C888
		public static bool smethod_3(Class142 toontownWindow, ManualResetEventSlim waitHandle, List<PointF> path, Class104 settings, bool jump = true)
		{
			Class269.Class274 @class = new Class269.Class274();
			@class.bool_0 = false;
			EventHandler eventHandler = null;
			Class269.Class275 class2 = new Class269.Class275();
			class2.class274_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			bool result;
			try
			{
				try
				{
					Class141 toonTownProcess = toontownWindow.ToonTownProcess;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(class2.method_0);
					}
					toonTownProcess.ProcessExited += eventHandler;
					result = Class269.smethod_2(toontownWindow, waitHandle, class2.manualResetEventSlim_0, path, settings, jump);
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

		// Token: 0x06001D6C RID: 7532 RVA: 0x0005E728 File Offset: 0x0005C928
		public static bool smethod_4(Class142 toontownWindow, ManualResetEventSlim waitHandle, Class104 settings, PointF target, bool jump, bool finalTarget)
		{
			Class269.Class276 @class = new Class269.Class276();
			@class.bool_0 = false;
			EventHandler eventHandler = null;
			Class269.Class277 class2 = new Class269.Class277();
			class2.class276_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			bool result;
			try
			{
				try
				{
					Class141 toonTownProcess = toontownWindow.ToonTownProcess;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(class2.method_0);
					}
					toonTownProcess.ProcessExited += eventHandler;
					result = Class269.smethod_5(toontownWindow, waitHandle, class2.manualResetEventSlim_0, settings, target, jump, finalTarget);
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

		// Token: 0x06001D6D RID: 7533 RVA: 0x0005E7C8 File Offset: 0x0005C9C8
		public static bool smethod_5(Class142 toontownWindow, ManualResetEventSlim waitHandle, ManualResetEventSlim navigateWaitHandle, Class104 settings, PointF target, bool jump, bool finalTarget)
		{
			Class269.Class278 @class = new Class269.Class278();
			IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
			if (!toontownWindow.ToonTownProcess.ProcessOpen)
			{
				return false;
			}
			Class269.Enum58 @enum = Class269.Enum58.flag_0;
			@class.struct56_0 = Struct56.struct56_0;
			Struct56 a = Struct56.struct56_0;
			DateTime t = DateTime.Now.AddMilliseconds(2000.0);
			float num = finalTarget ? settings.TargetRange : settings.IntermediateTargetRange;
			@class.bool_0 = false;
			EventHandler<EventArgs22> eventHandler = null;
			Class269.Class279 class2 = new Class269.Class279();
			class2.class278_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			try
			{
				try
				{
					Class129 logMonitor = toontownWindow.LogMonitor;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs22>(class2.method_0);
					}
					logMonitor.CoordinatesChanged += eventHandler;
					WaitHandle[] waitHandles = new WaitHandle[]
					{
						waitHandle.WaitHandle,
						class2.manualResetEventSlim_0.WaitHandle,
						navigateWaitHandle.WaitHandle
					};
					WaitHandle.WaitAny(waitHandles);
					WaitHandle[] waitHandles2 = new WaitHandle[]
					{
						waitHandle.WaitHandle,
						navigateWaitHandle.WaitHandle
					};
					DateTime t2 = DateTime.Now.AddMilliseconds(2000.0);
					try
					{
						while (!waitHandle.IsSet && !navigateWaitHandle.IsSet)
						{
							Struct56 struct56_ = @class.struct56_0;
							PointF location = struct56_.Location;
							if (Class477.smethod_0(target, num, location))
							{
								return true;
							}
							float num2 = struct56_.method_0(target);
							float num3 = Math.Abs(num2 - struct56_.float_3);
							float num4 = Class477.smethod_9(target, struct56_.Location);
							if (t < DateTime.Now)
							{
								if (Struct56.smethod_0(a, struct56_))
								{
									Class269.smethod_16(mainWindowHandle, ref @enum);
									Class269.smethod_15(mainWindowHandle, ref @enum);
									Class269.smethod_14(mainWindowHandle, ref @enum);
									Class269.smethod_19(mainWindowHandle);
								}
								t = DateTime.Now.AddMilliseconds(2000.0);
							}
							bool flag2;
							if ((num4 > 20f && num3 > 20f) || (num4 <= 20f && Class237.smethod_0(target, num, location, struct56_.float_3) == null))
							{
								Class269.smethod_16(mainWindowHandle, ref @enum);
								bool flag = num3 > 180f;
								if (num2 < struct56_.float_3)
								{
									if (flag)
									{
										flag2 = Class269.smethod_9(mainWindowHandle, ref @enum, waitHandles2, num3);
									}
									else
									{
										flag2 = Class269.smethod_10(mainWindowHandle, ref @enum, waitHandles2, num3);
									}
								}
								else if (flag)
								{
									flag2 = Class269.smethod_10(mainWindowHandle, ref @enum, waitHandles2, num3);
								}
								else
								{
									flag2 = Class269.smethod_9(mainWindowHandle, ref @enum, waitHandles2, num3);
								}
							}
							else
							{
								Class269.smethod_15(mainWindowHandle, ref @enum);
								Class269.smethod_14(mainWindowHandle, ref @enum);
								if (jump && t2 < DateTime.Now)
								{
									Class269.smethod_18(mainWindowHandle, waitHandles2);
									t2 = DateTime.Now.AddMilliseconds(2000.0);
								}
								flag2 = Class269.smethod_11(mainWindowHandle, ref @enum, waitHandles2, num4 - settings.TargetRange);
							}
							if (!flag2)
							{
								class2.manualResetEventSlim_0.Reset();
								WaitHandle.WaitAny(waitHandles);
							}
							if (Class477.smethod_0(target, num, @class.struct56_0.Location))
							{
								return true;
							}
							WaitHandle.WaitAny(waitHandles2, 25);
							a = struct56_;
						}
					}
					finally
					{
						Class269.smethod_16(mainWindowHandle, ref @enum);
						Class269.smethod_15(mainWindowHandle, ref @enum);
						Class269.smethod_14(mainWindowHandle, ref @enum);
						Class269.smethod_19(mainWindowHandle);
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
			return false;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0005EB80 File Offset: 0x0005CD80
		public static bool smethod_6(Class142 toontownWindow, ManualResetEventSlim waitHandle, Class101 wayPointsSettings, Class108 dock, Class104 settings)
		{
			Struct56? @struct = Class269.smethod_0(toontownWindow, waitHandle, -1);
			if (@struct == null)
			{
				return false;
			}
			if (@struct.Value.IsDock)
			{
				return true;
			}
			Enum57 playground = toontownWindow.Playground;
			Dictionary<PointF, Enum99> points_dic;
			if (wayPointsSettings.WayPoints.ContainsKey(playground))
			{
				points_dic = wayPointsSettings.WayPoints[playground];
			}
			else
			{
				points_dic = null;
			}
			List<PointF> path = Class269.smethod_21(points_dic, @struct.Value.Location, dock.DockLocation);
			return Class269.smethod_7(toontownWindow, waitHandle, path, settings);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0005EC04 File Offset: 0x0005CE04
		public static bool smethod_7(Class142 toontownWindow, ManualResetEventSlim waitHandle, List<PointF> path, Class104 settings)
		{
			for (int i = 0; i < path.Count; i++)
			{
				if (i == path.Count - 1)
				{
					return Class269.smethod_8(toontownWindow, waitHandle, settings, path[i], true);
				}
				if (!Class269.smethod_4(toontownWindow, waitHandle, settings, path[i], true, false))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0005EC58 File Offset: 0x0005CE58
		public static bool smethod_8(Class142 toontownWindow, ManualResetEventSlim waitHandle, Class104 settings, PointF target, bool jump)
		{
			Class269.Class280 @class = new Class269.Class280();
			@class.bool_0 = false;
			IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
			if (!toontownWindow.ToonTownProcess.ProcessOpen)
			{
				return false;
			}
			EventHandler eventHandler = null;
			EventHandler<EventArgs22> eventHandler2 = null;
			Class269.Class281 class2 = new Class269.Class281();
			class2.class280_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			bool result;
			try
			{
				try
				{
					Class141 toonTownProcess = toontownWindow.ToonTownProcess;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(class2.method_0);
					}
					toonTownProcess.ProcessExited += eventHandler;
					Class129 logMonitor = toontownWindow.LogMonitor;
					if (eventHandler2 == null)
					{
						eventHandler2 = new EventHandler<EventArgs22>(class2.method_1);
					}
					logMonitor.CoordinatesChanged += eventHandler2;
					while (!class2.manualResetEventSlim_0.IsSet && !waitHandle.IsSet)
					{
						if (jump)
						{
							Class269.smethod_18(mainWindowHandle, new WaitHandle[]
							{
								waitHandle.WaitHandle,
								class2.manualResetEventSlim_0.WaitHandle
							});
						}
						if (!Class269.smethod_5(toontownWindow, waitHandle, class2.manualResetEventSlim_0, settings, target, jump, true))
						{
							class2.manualResetEventSlim_0.Wait(100);
						}
					}
					result = (class2.manualResetEventSlim_0.IsSet && !waitHandle.IsSet);
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

		// Token: 0x06001D71 RID: 7537 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		private static bool smethod_9(IntPtr hWnd, ref Class269.Enum58 direction, WaitHandle[] waitHandles, float minimum_h)
		{
			Class269.smethod_15(hWnd, ref direction);
			if ((double)minimum_h < 1.3)
			{
				Class269.smethod_12(hWnd, waitHandles, 15);
				return false;
			}
			if ((double)minimum_h < 2.6)
			{
				Class269.smethod_12(hWnd, waitHandles, 30);
				return false;
			}
			if ((double)minimum_h < 5.2)
			{
				Class269.smethod_12(hWnd, waitHandles, 60);
				return false;
			}
			if ((double)minimum_h < 10.4)
			{
				Class269.smethod_12(hWnd, waitHandles, 120);
				return false;
			}
			Class465.smethod_13(hWnd, Keys.Left);
			direction |= Class269.Enum58.flag_1;
			return true;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0005EE28 File Offset: 0x0005D028
		private static bool smethod_10(IntPtr hWnd, ref Class269.Enum58 direction, WaitHandle[] waitHandles, float minimum_h)
		{
			Class269.smethod_14(hWnd, ref direction);
			if ((double)minimum_h < 1.3)
			{
				Class269.smethod_13(hWnd, waitHandles, 15);
				return false;
			}
			if ((double)minimum_h < 2.6)
			{
				Class269.smethod_13(hWnd, waitHandles, 30);
				return false;
			}
			if ((double)minimum_h < 5.2)
			{
				Class269.smethod_13(hWnd, waitHandles, 60);
				return false;
			}
			if ((double)minimum_h < 10.4)
			{
				Class269.smethod_13(hWnd, waitHandles, 120);
				return false;
			}
			Class465.smethod_13(hWnd, Keys.Right);
			direction |= Class269.Enum58.flag_2;
			return true;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0005EEAC File Offset: 0x0005D0AC
		private static bool smethod_11(IntPtr hWnd, ref Class269.Enum58 direction, WaitHandle[] waitHandles, float minimum_distance)
		{
			if (minimum_distance < 0.25f)
			{
				Class269.smethod_17(hWnd, ref direction, waitHandles, 20);
				return false;
			}
			if (minimum_distance < 1f)
			{
				Class269.smethod_17(hWnd, ref direction, waitHandles, 40);
				return false;
			}
			if (minimum_distance < 2f)
			{
				Class269.smethod_17(hWnd, ref direction, waitHandles, 80);
				return false;
			}
			Class465.smethod_13(hWnd, Keys.Up);
			direction |= Class269.Enum58.flag_3;
			return true;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0000B0DB File Offset: 0x000092DB
		private static void smethod_12(IntPtr hWnd, WaitHandle[] waitHandles, int time)
		{
			Class465.smethod_10(hWnd, Keys.Left, waitHandles, time);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0000B0E7 File Offset: 0x000092E7
		private static void smethod_13(IntPtr hWnd, WaitHandle[] waitHandles, int time)
		{
			Class465.smethod_10(hWnd, Keys.Right, waitHandles, time);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0000B0F3 File Offset: 0x000092F3
		private static void smethod_14(IntPtr hWnd, ref Class269.Enum58 direction)
		{
			if (direction.HasFlag(Class269.Enum58.flag_1))
			{
				Class465.smethod_14(hWnd, Keys.Left);
				direction &= ~Class269.Enum58.flag_1;
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0000B118 File Offset: 0x00009318
		private static void smethod_15(IntPtr hWnd, ref Class269.Enum58 direction)
		{
			if (direction.HasFlag(Class269.Enum58.flag_2))
			{
				Class465.smethod_14(hWnd, Keys.Right);
				direction &= ~Class269.Enum58.flag_2;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0000B13D File Offset: 0x0000933D
		private static void smethod_16(IntPtr hWnd, ref Class269.Enum58 direction)
		{
			if (direction.HasFlag(Class269.Enum58.flag_3))
			{
				Class465.smethod_14(hWnd, Keys.Up);
				direction &= ~Class269.Enum58.flag_3;
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0000B162 File Offset: 0x00009362
		private static void smethod_17(IntPtr hWnd, ref Class269.Enum58 direction, WaitHandle[] waitHandles, int time)
		{
			Class465.smethod_10(hWnd, Keys.Up, waitHandles, time);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0000B16E File Offset: 0x0000936E
		private static void smethod_18(IntPtr hWnd, WaitHandle[] waitHandles)
		{
			Class465.smethod_10(hWnd, Keys.ControlKey, waitHandles, 10);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000B17B File Offset: 0x0000937B
		private static void smethod_19(IntPtr hWnd)
		{
			Class465.smethod_14(hWnd, Keys.ControlKey);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0000B185 File Offset: 0x00009385
		public static void smethod_20(IntPtr hWnd, ManualResetEventSlim waitHandle)
		{
			Class465.smethod_13(hWnd, Keys.ShiftKey);
			Class465.smethod_11(hWnd, Keys.F1, waitHandle, 10);
			Class465.smethod_14(hWnd, Keys.ShiftKey);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0005EF04 File Offset: 0x0005D104
		public static List<PointF> smethod_21(Dictionary<PointF, Enum99> points_dic, PointF initial_location, PointF end_location)
		{
			HashSet<PointF> hashSet = null;
			if (points_dic != null)
			{
				hashSet = new HashSet<PointF>();
				foreach (KeyValuePair<PointF, Enum99> keyValuePair in points_dic)
				{
					if (keyValuePair.Value == Enum99.flag_0)
					{
						hashSet.Add(keyValuePair.Key);
					}
				}
			}
			return Class269.smethod_22(hashSet, initial_location, end_location);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0005EF78 File Offset: 0x0005D178
		public static List<PointF> smethod_22(HashSet<PointF> points, PointF initial_location, PointF end_location)
		{
			List<PointF> list = new List<PointF>();
			float num = Class477.smethod_9(initial_location, end_location);
			PointF p = initial_location;
			if (points != null)
			{
				for (;;)
				{
					PointF? pointF = null;
					float num2 = num;
					float num3 = num;
					foreach (PointF pointF2 in points)
					{
						float num4 = Class477.smethod_9(pointF2, end_location);
						if (num4 < num)
						{
							float num5 = Class477.smethod_9(p, pointF2);
							if (num5 < num3 && pointF2 != initial_location && pointF2 != end_location)
							{
								num3 = num5;
								num2 = num4;
								pointF = new PointF?(pointF2);
							}
						}
					}
					if (pointF == null)
					{
						break;
					}
					num = num2;
					PointF value = pointF.Value;
					list.Add(value);
					points.Remove(value);
					p = value;
				}
			}
			list.Add(end_location);
			return list;
		}

		// Token: 0x020002E7 RID: 743
		[Flags]
		private enum Enum58
		{
			// Token: 0x04000AE8 RID: 2792
			flag_0 = 0,
			// Token: 0x04000AE9 RID: 2793
			flag_1 = 1,
			// Token: 0x04000AEA RID: 2794
			flag_2 = 2,
			// Token: 0x04000AEB RID: 2795
			flag_3 = 4
		}

		// Token: 0x020002E8 RID: 744
		[CompilerGenerated]
		private sealed class Class270
		{
			// Token: 0x04000AEC RID: 2796
			public Struct56? nullable_0;

			// Token: 0x04000AED RID: 2797
			public bool bool_0;
		}

		// Token: 0x020002E9 RID: 745
		[CompilerGenerated]
		private sealed class Class271
		{
			// Token: 0x06001D81 RID: 7553 RVA: 0x0005F064 File Offset: 0x0005D264
			public void method_0(object sender, EventArgs22 e)
			{
				if (!this.class270_0.bool_0 && this.class270_0.nullable_0 == null)
				{
					this.class270_0.nullable_0 = new Struct56?(e.Coordinates);
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x0000B1A2 File Offset: 0x000093A2
			public void method_1(object sender, EventArgs e)
			{
				if (!this.class270_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AEE RID: 2798
			public Class269.Class270 class270_0;

			// Token: 0x04000AEF RID: 2799
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x020002EA RID: 746
		[CompilerGenerated]
		private sealed class Class272
		{
			// Token: 0x04000AF0 RID: 2800
			public Struct56? nullable_0;

			// Token: 0x04000AF1 RID: 2801
			public bool bool_0;
		}

		// Token: 0x020002EB RID: 747
		[CompilerGenerated]
		private sealed class Class273
		{
			// Token: 0x06001D85 RID: 7557 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
			public void method_0(object sender, EventArgs22 e)
			{
				if (!this.class272_0.bool_0 && !e.Coordinates.IsDock && this.class272_0.nullable_0 == null)
				{
					this.class272_0.nullable_0 = new Struct56?(e.Coordinates);
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x0000B1BC File Offset: 0x000093BC
			public void method_1(object sender, EventArgs e)
			{
				if (!this.class272_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AF2 RID: 2802
			public Class269.Class272 class272_0;

			// Token: 0x04000AF3 RID: 2803
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x020002EC RID: 748
		[CompilerGenerated]
		private sealed class Class274
		{
			// Token: 0x04000AF4 RID: 2804
			public bool bool_0;
		}

		// Token: 0x020002ED RID: 749
		[CompilerGenerated]
		private sealed class Class275
		{
			// Token: 0x06001D89 RID: 7561 RVA: 0x0000B1D6 File Offset: 0x000093D6
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class274_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AF5 RID: 2805
			public Class269.Class274 class274_0;

			// Token: 0x04000AF6 RID: 2806
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x020002EE RID: 750
		[CompilerGenerated]
		private sealed class Class276
		{
			// Token: 0x04000AF7 RID: 2807
			public bool bool_0;
		}

		// Token: 0x020002EF RID: 751
		[CompilerGenerated]
		private sealed class Class277
		{
			// Token: 0x06001D8C RID: 7564 RVA: 0x0000B1F0 File Offset: 0x000093F0
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class276_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AF8 RID: 2808
			public Class269.Class276 class276_0;

			// Token: 0x04000AF9 RID: 2809
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x020002F0 RID: 752
		[CompilerGenerated]
		private sealed class Class278
		{
			// Token: 0x04000AFA RID: 2810
			public Struct56 struct56_0;

			// Token: 0x04000AFB RID: 2811
			public bool bool_0;
		}

		// Token: 0x020002F1 RID: 753
		[CompilerGenerated]
		private sealed class Class279
		{
			// Token: 0x06001D8F RID: 7567 RVA: 0x0000B20A File Offset: 0x0000940A
			public void method_0(object sender, EventArgs22 e)
			{
				if (!this.class278_0.bool_0)
				{
					this.class278_0.struct56_0 = e.Coordinates;
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AFC RID: 2812
			public Class269.Class278 class278_0;

			// Token: 0x04000AFD RID: 2813
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x020002F2 RID: 754
		[CompilerGenerated]
		private sealed class Class280
		{
			// Token: 0x04000AFE RID: 2814
			public bool bool_0;
		}

		// Token: 0x020002F3 RID: 755
		[CompilerGenerated]
		private sealed class Class281
		{
			// Token: 0x06001D92 RID: 7570 RVA: 0x0000B235 File Offset: 0x00009435
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class280_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x06001D93 RID: 7571 RVA: 0x0005F114 File Offset: 0x0005D314
			public void method_1(object sender, EventArgs22 e)
			{
				if (!this.class280_0.bool_0 && e.Coordinates.IsDock)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x04000AFF RID: 2815
			public Class269.Class280 class280_0;

			// Token: 0x04000B00 RID: 2816
			public ManualResetEventSlim manualResetEventSlim_0;
		}
	}
}
