using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using ns14;
using ns15;
using ns19;
using ns21;
using ns25;
using ns26;
using ns27;
using ns29;
using ns30;
using ns31;

namespace ns17
{
	// Token: 0x02000265 RID: 613
	internal sealed class Class205 : Component
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x0004CA9C File Offset: 0x0004AC9C
		public Class205(IContainer container)
		{
			container.Add(this);
			this.dictionary_0 = new Dictionary<Struct21, Dictionary<IntPtr, Class205.Class127>>();
			this.class318_0 = new Class318();
			this.class318_0.HotkeyActivated += this.method_3;
			this.class112_0 = Class110.Instance.ApplicationSettings;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0004CAF4 File Offset: 0x0004ACF4
		public void method_0()
		{
			if (!Class463.DesignMode)
			{
				lock (this.dictionary_0)
				{
					foreach (Struct21 hotkey in this.class112_0.Hotkeys.Keys)
					{
						this.class318_0.method_9(hotkey, true, null, null);
					}
				}
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0004CB8C File Offset: 0x0004AD8C
		public void method_1()
		{
			if (!Class463.DesignMode)
			{
				lock (this.dictionary_0)
				{
					foreach (Struct21 hotkey in this.class112_0.Hotkeys.Keys)
					{
						this.class318_0.method_12(hotkey);
					}
					foreach (KeyValuePair<Struct21, Dictionary<IntPtr, Class205.Class127>> keyValuePair in this.dictionary_0)
					{
						foreach (Class205.Class127 @class in keyValuePair.Value.Values)
						{
							@class.method_6(true);
							@class.Dispose();
						}
						keyValuePair.Value.Clear();
					}
					this.dictionary_0.Clear();
				}
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004CCCC File Offset: 0x0004AECC
		private void method_2(Class205.Class127 hotkey, bool processEndEvents)
		{
			hotkey.method_6(processEndEvents);
			hotkey.Dispose();
			if (this.dictionary_0.ContainsKey(hotkey.class87_0.Hotkey))
			{
				Dictionary<IntPtr, Class205.Class127> dictionary = this.dictionary_0[hotkey.class87_0.Hotkey];
				dictionary.Remove(hotkey.intptr_0);
				if (dictionary.Count == 0)
				{
					this.dictionary_0.Remove(hotkey.class87_0.Hotkey);
				}
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0004CD44 File Offset: 0x0004AF44
		private void method_3(object sender, EventArgs18 e)
		{
			Class205.Class206 @class = new Class205.Class206();
			@class.eventArgs18_0 = e;
			@class.class205_0 = this;
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(@class.method_0), null);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00009510 File Offset: 0x00007710
		protected override void Dispose(bool disposing)
		{
			this.method_1();
			if (this.class318_0 != null)
			{
				this.class318_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x040007C1 RID: 1985
		private Class318 class318_0;

		// Token: 0x040007C2 RID: 1986
		private readonly Dictionary<Struct21, Dictionary<IntPtr, Class205.Class127>> dictionary_0;

		// Token: 0x040007C3 RID: 1987
		private Class112 class112_0;

		// Token: 0x02000266 RID: 614
		private sealed class Class127 : Class123
		{
			// Token: 0x1400017D RID: 381
			// (add) Token: 0x06001A30 RID: 6704 RVA: 0x0004CD78 File Offset: 0x0004AF78
			// (remove) Token: 0x06001A31 RID: 6705 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
			public event EventHandler Terminated
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

			// Token: 0x06001A32 RID: 6706 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
			public Class127(IntPtr toonTownHandle, Process toontownProcess, Class87 hotkeySettings)
			{
				this.intptr_0 = toonTownHandle;
				this.process_0 = toontownProcess;
				this.class87_0 = hotkeySettings;
				if (this.class87_0.RepeatKeyPress || this.class87_0.ReleaseKey)
				{
					this.timer_0 = new System.Timers.Timer();
					this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
				}
				if (this.class87_0.MoveMouse)
				{
					this.timer_1 = new System.Timers.Timer();
					this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
					this.timer_1.Interval = (double)this.class87_0.MoveMouseRate;
				}
			}

			// Token: 0x06001A33 RID: 6707 RVA: 0x00009532 File Offset: 0x00007732
			private void timer_0_Elapsed(object sender, EventArgs e)
			{
				this.method_4();
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x0004CE94 File Offset: 0x0004B094
			private void method_4()
			{
				if (this.bool_2 && this.class87_0.ReleaseKey)
				{
					this.bool_2 = false;
					this.method_8();
					if (this.class87_0.RepeatKeyPress)
					{
						this.timer_0.Interval = (double)this.class87_0.KeyPressRepeatRate;
						return;
					}
					this.timer_0.Enabled = false;
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, EventArgs.Empty);
						return;
					}
				}
				else
				{
					this.bool_2 = true;
					this.method_7();
					if (this.class87_0.ReleaseKey)
					{
						this.timer_0.Interval = (double)this.class87_0.KeyReleaseDelay;
					}
				}
			}

			// Token: 0x06001A35 RID: 6709 RVA: 0x0004CF40 File Offset: 0x0004B140
			private void timer_1_Elapsed(object sender, EventArgs e)
			{
				Class205.Class127 @class = Interlocked.CompareExchange<Class205.Class127>(ref Class205.Class127.class127_0, this, null);
				Point position = Cursor.Position;
				if (@class == this && position == this.point_0)
				{
					int num = Class124.Instance.method_6(0, 4);
					Rectangle workingArea = Screen.FromPoint(position).WorkingArea;
					switch (num)
					{
					case 0:
						break;
					case 1:
						goto IL_75;
					case 2:
						goto IL_BD;
					case 3:
						goto IL_CF;
					default:
						goto IL_115;
					}
					IL_63:
					if (position.X != workingArea.Left)
					{
						Class465.smethod_3(new Point(position.X - 1, position.Y));
						goto IL_115;
					}
					IL_75:
					if (position.X != workingArea.Right)
					{
						Class465.smethod_3(new Point(position.X + 1, position.Y));
						goto IL_115;
					}
					goto IL_63;
					IL_BD:
					if (position.Y != workingArea.Top)
					{
						Class465.smethod_3(new Point(position.X, position.Y - 1));
						goto IL_115;
					}
					IL_CF:
					if (position.Y == workingArea.Bottom)
					{
						goto IL_BD;
					}
					Class465.smethod_3(new Point(position.X, position.Y + 1));
				}
				IL_115:
				this.point_0 = Cursor.Position;
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x0004D070 File Offset: 0x0004B270
			public void method_5()
			{
				this.method_4();
				bool flag;
				if (!(flag = (this.class87_0.RepeatKeyPress || this.class87_0.ReleaseKey)) && !this.class87_0.MoveMouse)
				{
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, EventArgs.Empty);
					}
				}
				else
				{
					if (flag)
					{
						this.timer_0.Enabled = true;
					}
					if (this.class87_0.MoveMouse)
					{
						Interlocked.CompareExchange<Class205.Class127>(ref Class205.Class127.class127_0, this, null);
						this.point_0 = Cursor.Position;
						this.timer_1.Enabled = true;
						return;
					}
				}
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x0004D10C File Offset: 0x0004B30C
			public void method_6(bool processEndEvents)
			{
				if (this.class87_0.RepeatKeyPress || this.class87_0.ReleaseKey)
				{
					this.timer_0.Enabled = false;
					if (processEndEvents && this.bool_2)
					{
						this.method_8();
					}
				}
				if (this.class87_0.MoveMouse)
				{
					this.timer_1.Enabled = false;
					Interlocked.CompareExchange<Class205.Class127>(ref Class205.Class127.class127_0, null, this);
				}
			}

			// Token: 0x06001A38 RID: 6712 RVA: 0x0004D178 File Offset: 0x0004B378
			private void method_7()
			{
				if (this.class87_0.KeyToPress == Keys.Control)
				{
					Class265.PostMessage(this.intptr_0, Enum16.const_88, 17, 0);
					return;
				}
				if (this.class87_0.KeyToPress != Keys.None)
				{
					Class465.smethod_13(this.intptr_0, this.class87_0.KeyToPress);
				}
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x0004D1D0 File Offset: 0x0004B3D0
			private void method_8()
			{
				if (this.class87_0.KeyToPress == Keys.Control)
				{
					Class265.PostMessage(this.intptr_0, Enum16.const_89, 17, 0);
					return;
				}
				if (this.class87_0.KeyToPress != Keys.None)
				{
					Class465.smethod_14(this.intptr_0, this.class87_0.KeyToPress);
				}
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x0004D228 File Offset: 0x0004B428
			protected override void vmethod_0()
			{
				if (this.timer_0 != null)
				{
					this.timer_0.Enabled = false;
					this.timer_0.Dispose();
				}
				if (this.timer_1 != null)
				{
					this.timer_1.Enabled = false;
					this.timer_1.Dispose();
				}
				if (this.process_0 != null)
				{
					this.process_0.Dispose();
				}
				base.vmethod_0();
			}

			// Token: 0x040007C4 RID: 1988
			private static Class205.Class127 class127_0;

			// Token: 0x040007C5 RID: 1989
			public readonly Class87 class87_0;

			// Token: 0x040007C6 RID: 1990
			private EventHandler eventHandler_2;

			// Token: 0x040007C7 RID: 1991
			public readonly IntPtr intptr_0;

			// Token: 0x040007C8 RID: 1992
			private readonly Process process_0;

			// Token: 0x040007C9 RID: 1993
			private bool bool_2;

			// Token: 0x040007CA RID: 1994
			private readonly System.Timers.Timer timer_0;

			// Token: 0x040007CB RID: 1995
			private readonly System.Timers.Timer timer_1;

			// Token: 0x040007CC RID: 1996
			private Point point_0;
		}

		// Token: 0x02000267 RID: 615
		[CompilerGenerated]
		private sealed class Class206
		{
			// Token: 0x06001A3C RID: 6716 RVA: 0x0004D28C File Offset: 0x0004B48C
			public void method_0(object _)
			{
				IntPtr foregroundWindow = Class265.GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					return;
				}
				Dictionary<IntPtr, Class205.Class127> dictionary = null;
				Struct21 hotkey = this.eventArgs18_0.State.Hotkey;
				lock (this.class205_0.dictionary_0)
				{
					if (this.class205_0.dictionary_0.ContainsKey(hotkey))
					{
						dictionary = this.class205_0.dictionary_0[hotkey];
						if (dictionary.ContainsKey(foregroundWindow))
						{
							this.class205_0.method_2(dictionary[foregroundWindow], true);
							return;
						}
					}
					Process process = null;
					bool flag2 = false;
					try
					{
						process = Class265.smethod_7(foregroundWindow);
						if (flag2 = (process.smethod_2().ToLower() == "toontown"))
						{
							Class87 @class = this.class205_0.class112_0.Hotkeys[hotkey];
							Class205.Class206.Class207 class2 = new Class205.Class206.Class207();
							class2.class206_0 = this;
							switch (@class.HotkeyType)
							{
							case Enum40.const_0:
								if (@class.StopOtherHotkeys)
								{
									List<Class205.Class127> list = new List<Class205.Class127>();
									foreach (KeyValuePair<Struct21, Dictionary<IntPtr, Class205.Class127>> keyValuePair in this.class205_0.dictionary_0)
									{
										if (Struct21.smethod_1(keyValuePair.Key, hotkey) && keyValuePair.Value.ContainsKey(foregroundWindow))
										{
											list.Add(keyValuePair.Value[foregroundWindow]);
										}
									}
									foreach (Class205.Class127 hotkey2 in list)
									{
										this.class205_0.method_2(hotkey2, true);
									}
								}
								if (dictionary == null)
								{
									this.class205_0.dictionary_0.Add(hotkey, dictionary = new Dictionary<IntPtr, Class205.Class127>());
								}
								class2.class127_0 = new Class205.Class127(foregroundWindow, process, @class);
								dictionary.Add(foregroundWindow, class2.class127_0);
								process.EnableRaisingEvents = true;
								process.Exited += class2.method_0;
								class2.class127_0.Terminated += class2.method_1;
								if (process.HasExited)
								{
									this.class205_0.method_2(class2.class127_0, false);
								}
								else
								{
									class2.class127_0.method_5();
								}
								break;
							case Enum40.const_1:
							{
								Process[] array = null;
								try
								{
									array = Class156.smethod_3("toontown");
									if (array.Length > 1)
									{
										int i = 0;
										while (i < array.Length)
										{
											if (!(array[i].smethod_0() == foregroundWindow))
											{
												i++;
											}
											else
											{
												IntPtr intPtr;
												if (i == array.Length - 1)
												{
													intPtr = array[0].smethod_0();
												}
												else
												{
													intPtr = array[i + 1].smethod_0();
												}
												if (intPtr != IntPtr.Zero)
												{
													Class410.smethod_8(this.class205_0, intPtr);
													break;
												}
												break;
											}
										}
									}
								}
								finally
								{
									if (array != null)
									{
										foreach (Process process2 in array)
										{
											process2.Dispose();
										}
									}
								}
								break;
							}
							}
						}
					}
					finally
					{
						if (!flag2 && process != null)
						{
							process.Dispose();
						}
					}
				}
			}

			// Token: 0x040007CD RID: 1997
			public Class205 class205_0;

			// Token: 0x040007CE RID: 1998
			public EventArgs18 eventArgs18_0;

			// Token: 0x02000268 RID: 616
			private sealed class Class207
			{
				// Token: 0x06001A3E RID: 6718 RVA: 0x0004D624 File Offset: 0x0004B824
				public void method_0(object sender, EventArgs e)
				{
					lock (this.class206_0.class205_0.dictionary_0)
					{
						this.class206_0.class205_0.method_2(this.class127_0, false);
					}
				}

				// Token: 0x06001A3F RID: 6719 RVA: 0x0004D680 File Offset: 0x0004B880
				public void method_1(object sender, EventArgs e)
				{
					lock (this.class206_0.class205_0.dictionary_0)
					{
						this.class206_0.class205_0.method_2(this.class127_0, true);
					}
				}

				// Token: 0x040007CF RID: 1999
				public Class205.Class206 class206_0;

				// Token: 0x040007D0 RID: 2000
				public Class205.Class127 class127_0;
			}
		}
	}
}
