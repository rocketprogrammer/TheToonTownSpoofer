using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns19;
using ns20;
using ns21;
using ns23;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x0200021F RID: 543
	internal sealed partial class GardenerFloraRunning : RunBaseForm
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GardenerFloraRunning));
			this.JoeFishStatus = new Label();
			base.SuspendLayout();
			this.JoeFishStatus.AutoSize = true;
			this.JoeFishStatus.Location = new Point(12, 14);
			this.JoeFishStatus.Name = "JoeFishStatus";
			this.JoeFishStatus.Size = new Size(132, 13);
			this.JoeFishStatus.TabIndex = 2;
			this.JoeFishStatus.Text = "Gardener Flora: Working...";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(286, 40);
			base.Controls.Add(this.JoeFishStatus);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "GardenerFloraRunning";
			base.OnStartRunning += this.method_24;
			base.Controls.SetChildIndex(this.JoeFishStatus, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public GardenerFloraRunning(IntPtr hWnd, Class113 settings, Class88 captures, Class90 wayPoints) : base(hWnd)
		{
			this.InitializeComponent_1();
			this.class113_0 = settings;
			this.class88_0 = captures;
			this.class90_0 = wayPoints;
			this.class105_0 = Class110.Instance.GardenerFloraSettings;
			this.list_0 = new List<Enum99>(new Enum99[]
			{
				Enum99.flag_15,
				Enum99.flag_16,
				Enum99.flag_17,
				Enum99.flag_18,
				Enum99.flag_19,
				Enum99.flag_20,
				Enum99.flag_21,
				Enum99.flag_22
			});
			this.list_1 = new List<Enum99>(new Enum99[]
			{
				Enum99.flag_5,
				Enum99.flag_6,
				Enum99.flag_7,
				Enum99.flag_8,
				Enum99.flag_9,
				Enum99.flag_10,
				Enum99.flag_11,
				Enum99.flag_12,
				Enum99.flag_13,
				Enum99.flag_14
			});
			this.dictionary_0 = new Dictionary<Enum85, Dictionary<Enum99, HashSet<PointF>>>();
			Rectangle max_bounds = new Rectangle(Point.Empty, new Size(1024, 768));
			this.struct46_0 = Struct46.smethod_3(new Rectangle(335, 327, 359, 39), max_bounds);
			this.struct46_1 = Struct46.smethod_3(new Rectangle(358, 423, 309, 38), max_bounds);
			this.struct51_0 = Struct51.smethod_2(16, max_bounds.Height);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00007648 File Offset: 0x00005848
		private void method_23()
		{
			if (GardenerFloraRunning.methodInvoker_0 == null)
			{
				GardenerFloraRunning.methodInvoker_0 = new MethodInvoker(GardenerFloraRunning.smethod_5);
			}
			base.method_2(GardenerFloraRunning.methodInvoker_0);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0000766D File Offset: 0x0000586D
		private void method_24(object sender, EventArgs e)
		{
			if (this.class142_0.Playground != Enum57.const_1)
			{
				base.Hide();
				DialogBox.smethod_3("Your toon does not appear to be at your estate.", "Invalid Playground");
				base.method_1(DialogResult.Abort);
				return;
			}
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_52));
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0003E648 File Offset: 0x0003C848
		private void method_25()
		{
			GardenerFloraRunning.Class166 @class = new GardenerFloraRunning.Class166();
			@class.gardenerFloraRunning_0 = this;
			this.method_46();
			List<GardenerFloraRunning.Class165> list = this.method_45();
			@class.list_0 = new List<GardenerFloraRunning.Class165>(list);
			while (list.Count > 0 && base.CanContinue)
			{
				Func<bool> func = null;
				Func<bool> func2 = null;
				Predicate<KeyValuePair<Enum99, Class93>> predicate = null;
				Predicate<KeyValuePair<Enum99, Class109>> predicate2 = null;
				Func<bool> func3 = null;
				Func<bool> func4 = null;
				GardenerFloraRunning.Class167 class2 = new GardenerFloraRunning.Class167();
				class2.class166_0 = @class;
				@class.bool_0 = true;
				if (!this.method_50(list, out class2.class165_0, out class2.enum99_0, true, null))
				{
					return;
				}
				if (class2.class165_0.Customized)
				{
					if (func == null)
					{
						func = new Func<bool>(class2.method_0);
					}
					Func<bool> func5 = func;
					if (func2 == null)
					{
						func2 = new Func<bool>(class2.method_1);
					}
					Func<bool> func6 = func2;
					if (class2.enum99_0.HasFlag(Enum99.flag_3))
					{
						List<KeyValuePair<Enum99, Class93>> flowers = class2.class165_0.Flowers;
						List<KeyValuePair<Enum99, Class93>> flowers2 = class2.class165_0.Flowers;
						if (predicate == null)
						{
							predicate = new Predicate<KeyValuePair<Enum99, Class93>>(class2.method_2);
						}
						flowers.smethod_1(-flowers2.FindIndex(predicate));
						if (func5())
						{
							if (func6())
							{
								goto IL_263;
							}
						}
						return;
					}
					if (class2.enum99_0.HasFlag(Enum99.flag_4))
					{
						List<KeyValuePair<Enum99, Class109>> trees = class2.class165_0.Trees;
						List<KeyValuePair<Enum99, Class109>> trees2 = class2.class165_0.Trees;
						if (predicate2 == null)
						{
							predicate2 = new Predicate<KeyValuePair<Enum99, Class109>>(class2.method_3);
						}
						trees.smethod_1(-trees2.FindIndex(predicate2));
						if (func6())
						{
							if (func5())
							{
								goto IL_263;
							}
						}
						return;
					}
				}
				else
				{
					if (func3 == null)
					{
						func3 = new Func<bool>(class2.method_4);
					}
					Func<bool> func7 = func3;
					if (func4 == null)
					{
						func4 = new Func<bool>(class2.method_5);
					}
					Func<bool> func8 = func4;
					if (class2.enum99_0.HasFlag(Enum99.flag_3))
					{
						this.list_1.smethod_1(-this.list_1.IndexOf(class2.enum99_0));
						if (func7())
						{
							if (func8())
							{
								goto IL_263;
							}
						}
						return;
					}
					if (class2.enum99_0.HasFlag(Enum99.flag_4))
					{
						this.list_0.smethod_1(-this.list_0.IndexOf(class2.enum99_0));
						if (!func8() || !func7())
						{
							return;
						}
					}
				}
				IL_263:
				list.Remove(class2.class165_0);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0003E8DC File Offset: 0x0003CADC
		private bool method_26(GardenerFloraRunning.Class165 estate, Class93 flower = null)
		{
			if (!base.CanContinue)
			{
				return false;
			}
			if (this.method_32() != Enum107.const_0)
			{
				return false;
			}
			if (this.method_31() != Enum107.const_0)
			{
				return false;
			}
			base.method_17(this.class88_0.PlantFlowerBounds, this.class105_0);
			this.manualResetEventSlim_0.Wait(500);
			bool flag = false;
			if (flower != null && flower.BeanCombination != null)
			{
				flag = this.method_29(flower.BeanCombination);
			}
			else
			{
				switch (this.class113_0.PlantMethod)
				{
				case Enum115.const_0:
				{
					int num;
					if (this.method_30(out num))
					{
						int num2 = num * 5;
						int num3;
						if (estate.LastBeanCombinationIndex != null && estate.LastBeanCombinationIndex.Value >= num2)
						{
							num3 = estate.LastBeanCombinationIndex.Value + 1;
							if (num3 >= num2 + 5)
							{
								num3 = num2;
							}
						}
						else
						{
							num3 = num2;
						}
						if (flag = this.method_29(Class322.readOnlyCollection_0[num3]))
						{
							estate.LastBeanCombinationIndex = new int?(num3);
						}
					}
					break;
				}
				case Enum115.const_1:
					if (this.class113_0.BeanCombinations.Count > 0)
					{
						int index = Class124.Instance.method_6(0, this.class113_0.BeanCombinations.Count);
						flag = this.method_29(this.class113_0.BeanCombinations[index]);
					}
					break;
				case Enum115.const_2:
					if (this.class113_0.BeanCombinations.Count > 0)
					{
						int num4;
						if (estate.LastBeanCombinationIndex != null)
						{
							num4 = estate.LastBeanCombinationIndex.Value + 1;
							if (num4 >= this.class113_0.BeanCombinations.Count)
							{
								num4 = 0;
							}
						}
						else
						{
							num4 = 0;
						}
						if (flag = this.method_29(this.class113_0.BeanCombinations[num4]))
						{
							estate.LastBeanCombinationIndex = new int?(num4);
						}
					}
					break;
				}
			}
			if (flag && this.method_35() == Enum107.const_0)
			{
				base.method_17(this.class88_0.FinalPlantBounds, this.class105_0);
				if (this.method_27() == Enum107.const_0)
				{
					return true;
				}
			}
			this.manualResetEventSlim_0.Wait(500);
			if (this.method_33() == Enum107.const_0)
			{
				base.method_17(this.class88_0.PlantFailedBounds, this.class105_0);
			}
			this.manualResetEventSlim_0.Wait(500);
			if (this.method_34() == Enum107.const_0)
			{
				base.method_17(this.class88_0.CancelPlantBounds, this.class105_0);
			}
			return false;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0003EB48 File Offset: 0x0003CD48
		private Enum107 method_27()
		{
			int i = 0;
			while (i < 15000)
			{
				if (this.manualResetEventSlim_0.IsSet)
				{
					return Enum107.const_1;
				}
				switch (this.method_33())
				{
				case Enum107.const_0:
					base.method_17(this.class88_0.PlantFailedBounds, this.class105_0);
					return Enum107.const_1;
				default:
					switch (this.method_28())
					{
					case Enum107.const_0:
						return Enum107.const_0;
					default:
						this.manualResetEventSlim_0.Wait(1000);
						i += 1000;
						break;
					case Enum107.const_2:
						return Enum107.const_2;
					}
					break;
				case Enum107.const_2:
					return Enum107.const_2;
				}
			}
			return Enum107.const_1;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		private Enum107 method_28()
		{
			if (!this.class142_0.ToonTownProcess.ProcessOpen)
			{
				return Enum107.const_2;
			}
			Rectangle window_bounds = Class410.smethod_16(this.intptr_0);
			Rectangle rectangle = this.class88_0.PlantSuccessBounds.method_0(window_bounds.Size);
			int num = this.struct51_0.method_0(window_bounds.Height);
			int num2 = rectangle.Y + num;
			rectangle.Y -= num;
			while (rectangle.Y < num2)
			{
				if (this.manualResetEventSlim_0.IsSet)
				{
					return Enum107.const_1;
				}
				base.method_7();
				switch (Class433.smethod_1(this.class142_0.ToonTownProcess, this.class88_0.PlantSuccessCapture, rectangle, this.class105_0))
				{
				case Enum107.const_0:
					base.method_15(window_bounds, rectangle);
					this.manualResetEventSlim_0.Wait(this.class105_0.AfterMoveBeforeClickDelay);
					base.method_18(this.class105_0);
					return Enum107.const_0;
				default:
					rectangle.Y++;
					break;
				case Enum107.const_2:
					return Enum107.const_2;
				}
			}
			return Enum107.const_1;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		private bool method_29(Class322 combination)
		{
			if (!this.class142_0.ToonTownProcess.ProcessOpen)
			{
				return false;
			}
			Rectangle window_bounds = Class410.smethod_16(this.intptr_0);
			Rectangle rectangle = this.struct46_0.method_0(window_bounds.Size);
			rectangle.Width /= 9;
			base.method_7();
			int[] beans = combination.Beans;
			for (int i = 0; i < beans.Length; i++)
			{
				Rectangle bounds = rectangle;
				bounds.X += bounds.Width * (beans[i] - 1);
				base.method_15(window_bounds, bounds);
				this.manualResetEventSlim_0.Wait(this.class105_0.AfterMoveBeforeClickDelay);
				base.method_18(this.class105_0);
				this.manualResetEventSlim_0.Wait(200);
			}
			return true;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0003EDB8 File Offset: 0x0003CFB8
		private bool method_30(out int beanSlotsCount)
		{
			beanSlotsCount = 0;
			if (!this.class142_0.ToonTownProcess.ProcessOpen)
			{
				return false;
			}
			Rectangle rectangle = Class410.smethod_16(this.intptr_0);
			Rectangle rectangle2 = this.struct46_1.method_0(rectangle.Size);
			Rectangle capture_bounds = this.class88_0.DisabledBeanSlotBounds.method_0(rectangle.Size);
			int num = rectangle2.Width / 8;
			capture_bounds.X = rectangle2.X + (capture_bounds.X - rectangle2.X) % num;
			int i = 1;
			while (i < 8)
			{
				capture_bounds.X += num;
				switch (Class433.smethod_1(this.class142_0.ToonTownProcess, this.class88_0.DisabledBeanSlotCapture, capture_bounds, this.class105_0))
				{
				case Enum107.const_0:
					return true;
				default:
					beanSlotsCount++;
					i++;
					break;
				case Enum107.const_2:
					return false;
				}
			}
			return true;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000076AC File Offset: 0x000058AC
		private Enum107 method_31()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.PlantFlowerCapture, this.class88_0.PlantFlowerBounds, this.class105_0);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000076DA File Offset: 0x000058DA
		private Enum107 method_32()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.NoWaterCapture, this.class88_0.NoWaterBounds, this.class105_0);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00007708 File Offset: 0x00005908
		private Enum107 method_33()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.PlantFailedCapture, this.class88_0.PlantFailedBounds, this.class105_0);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00007736 File Offset: 0x00005936
		private Enum107 method_34()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.CancelPlantCapture, this.class88_0.CancelPlantBounds, this.class105_0);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00007764 File Offset: 0x00005964
		private Enum107 method_35()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.FinalPlantCapture, this.class88_0.FinalPlantBounds, this.class105_0);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		private GardenerFloraRunning.Enum26 method_36(List<GardenerFloraRunning.Class165> estates, bool allowWater, int numberOfWaters)
		{
			if (!base.CanContinue)
			{
				return GardenerFloraRunning.Enum26.flag_0;
			}
			GardenerFloraRunning.Enum26 @enum = GardenerFloraRunning.Enum26.flag_0;
			bool flag = true;
			while (flag)
			{
				switch (this.method_37(estates))
				{
				case GardenerFloraRunning.Enum27.const_0:
					flag = false;
					break;
				case GardenerFloraRunning.Enum27.const_1:
					@enum |= GardenerFloraRunning.Enum26.flag_1;
					flag = false;
					break;
				case GardenerFloraRunning.Enum27.const_2:
					if (!@enum.HasFlag(GardenerFloraRunning.Enum26.flag_2) && allowWater && this.method_43(numberOfWaters))
					{
						@enum |= GardenerFloraRunning.Enum26.flag_2;
					}
					else
					{
						flag = false;
					}
					break;
				}
			}
			return @enum;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003EF1C File Offset: 0x0003D11C
		private GardenerFloraRunning.Enum27 method_37(List<GardenerFloraRunning.Class165> estates)
		{
			if (!base.CanContinue)
			{
				return GardenerFloraRunning.Enum27.const_0;
			}
			switch (this.method_38())
			{
			case Enum107.const_0:
			{
				base.method_17(this.class88_0.PickFlowerBounds, this.class105_0);
				this.manualResetEventSlim_0.Wait(500);
				Point p;
				switch (this.method_40(out p))
				{
				case Enum107.const_0:
				{
					base.method_16(p, this.class105_0);
					this.manualResetEventSlim_0.Wait(500);
					Enum107 @enum = this.method_42();
					if (@enum == Enum107.const_2)
					{
						return GardenerFloraRunning.Enum27.const_0;
					}
					return GardenerFloraRunning.Enum27.const_1;
				}
				case Enum107.const_1:
				{
					Enum107 enum2 = this.method_41();
					if (enum2 == Enum107.const_0)
					{
						base.method_17(this.class88_0.BasketFullBounds, this.class105_0);
						this.manualResetEventSlim_0.Wait(500);
						if (!this.method_47(estates))
						{
							return GardenerFloraRunning.Enum27.const_0;
						}
						return GardenerFloraRunning.Enum27.const_3;
					}
					break;
				}
				}
				break;
			}
			case Enum107.const_1:
				return GardenerFloraRunning.Enum27.const_2;
			}
			return GardenerFloraRunning.Enum27.const_0;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00007792 File Offset: 0x00005992
		private Enum107 method_38()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.PickFlowerCapture, this.class88_0.PickFlowerBounds, this.class105_0);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000077C0 File Offset: 0x000059C0
		private Enum107 method_39()
		{
			return base.method_19(500, 2000, this.class88_0.FinalPickCapture, this.class88_0.FinalPickBounds, this.class105_0);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003F000 File Offset: 0x0003D200
		private Enum107 method_40(out Point mouseTarget)
		{
			Struct51 @struct = Struct51.smethod_2(504, 768);
			Struct51 struct2 = Struct51.smethod_2(546, 768);
			Action action = null;
			GardenerFloraRunning.Class168 @class = new GardenerFloraRunning.Class168();
			@class.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			Enum107 result;
			try
			{
				if (action == null)
				{
					action = new Action(@class.method_0);
				}
				using (Task task = new Task(action))
				{
					try
					{
						task.Start();
						while (!this.manualResetEventSlim_0.IsSet && !@class.manualResetEventSlim_0.IsSet)
						{
							base.method_7();
							IntPtr mainWindowHandle = this.class142_0.ToonTownProcess.MainWindowHandle;
							if (!this.class142_0.ToonTownProcess.ProcessOpen)
							{
								mouseTarget = Point.Empty;
								return Enum107.const_2;
							}
							Rectangle max_bounds = Class410.smethod_16(mainWindowHandle);
							Rectangle rectangle = this.class88_0.FinalPickBounds.method_0(max_bounds.Size);
							int num = @struct.method_0(max_bounds.Height) - rectangle.Height / 2;
							Rectangle rectangle2 = new Rectangle(rectangle.Left - 1, num, rectangle.Width + 2, struct2.method_0(max_bounds.Height) + rectangle.Height / 2 - num);
							Struct46 sourceRatio = Struct46.smethod_3(rectangle2, max_bounds);
							using (Bitmap bitmap = Class364.smethod_3(mainWindowHandle, rectangle2))
							{
								using (Class150 class2 = new Class150(bitmap, false))
								{
									Point point;
									if (Class150.smethod_0(class2, sourceRatio, this.class88_0.FinalPickCapture, this.class88_0.FinalPickBounds, this.class105_0.MaxColorRange, out point))
									{
										mouseTarget = new Point(rectangle2.X + point.X + rectangle.Width / 2, rectangle2.Y + point.Y + rectangle.Height / 2);
										return Enum107.const_0;
									}
								}
							}
							WaitHandle.WaitAny(new WaitHandle[]
							{
								this.manualResetEventSlim_0.WaitHandle,
								@class.manualResetEventSlim_0.WaitHandle
							}, 500);
						}
						mouseTarget = Point.Empty;
						result = Enum107.const_1;
					}
					finally
					{
						@class.manualResetEventSlim_0.Set();
						task.Wait();
					}
				}
			}
			finally
			{
				if (@class.manualResetEventSlim_0 != null)
				{
					((IDisposable)@class.manualResetEventSlim_0).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000077EE File Offset: 0x000059EE
		private Enum107 method_41()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.BasketFullCapture, this.class88_0.BasketFullBounds, this.class105_0);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0000781C File Offset: 0x00005A1C
		private Enum107 method_42()
		{
			return base.method_19(500, 20000, this.class88_0.NoWaterCapture, this.class88_0.NoWaterBounds, this.class105_0);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0003F2E4 File Offset: 0x0003D4E4
		private bool method_43(int numberOfWaters)
		{
			if (!base.CanContinue)
			{
				return false;
			}
			if (this.method_44() != Enum107.const_0)
			{
				return false;
			}
			for (int i = 0; i < numberOfWaters; i++)
			{
				if (!base.CanContinue)
				{
					return false;
				}
				base.method_17(this.class88_0.WaterPlantBounds, this.class105_0);
				base.method_9();
				if (base.method_19(500, 10000, this.class88_0.WaterPlantCapture, this.class88_0.WaterPlantBounds, this.class105_0) != Enum107.const_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0000784A File Offset: 0x00005A4A
		private Enum107 method_44()
		{
			return Class433.smethod_0(this.class142_0.ToonTownProcess, this.class88_0.WaterPlantCapture, this.class88_0.WaterPlantBounds, this.class105_0);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0003F36C File Offset: 0x0003D56C
		private List<GardenerFloraRunning.Class165> method_45()
		{
			List<GardenerFloraRunning.Class165> list = new List<GardenerFloraRunning.Class165>();
			foreach (KeyValuePair<Enum13, Class94> keyValuePair in this.class113_0.EstatePlantSettings)
			{
				Class94 value = keyValuePair.Value;
				if (value.Enabled)
				{
					GardenerFloraRunning.Class165 @class = new GardenerFloraRunning.Class165(value.State, value.GardeningActions, (int)value.WaterCount, value.HouseColor);
					bool flag = false;
					if (@class.Customized)
					{
						foreach (KeyValuePair<Enum99, Class93> item in value.OrderedFlowers)
						{
							Class93 value2 = item.Value;
							Enum36 gardeningActions = value2.GardeningActions;
							if (gardeningActions.HasFlag(Enum36.flag_1) && (gardeningActions.HasFlag(Enum36.flag_2) || gardeningActions.HasFlag(Enum36.flag_3) || gardeningActions.HasFlag(Enum36.flag_4)))
							{
								@class.Flowers.Add(item);
								flag = true;
							}
						}
						foreach (KeyValuePair<Enum99, Class109> item2 in value.OrderedTrees)
						{
							Class109 value3 = item2.Value;
							Enum36 gardeningActions2 = value3.GardeningActions;
							if (gardeningActions2.HasFlag(Enum36.flag_1 | Enum36.flag_4) && value3.WaterCount > 0)
							{
								@class.Trees.Add(item2);
								flag = true;
							}
						}
					}
					else
					{
						flag = ((value.GardenFlowers && ((value.Water && value.WaterCount > 0) || value.Pick || value.Plant)) || (value.GardenTrees && value.Water && value.WaterCount > 0));
					}
					if (flag)
					{
						list.Add(@class);
					}
				}
			}
			return list;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0003F580 File Offset: 0x0003D780
		private void method_46()
		{
			foreach (KeyValuePair<Enum85, Class101> keyValuePair in ((IEnumerable<KeyValuePair<Enum85, Class101>>)this.class90_0.WayPoints))
			{
				Dictionary<Enum99, HashSet<PointF>> dictionary;
				this.dictionary_0.Add(keyValuePair.Key, dictionary = new Dictionary<Enum99, HashSet<PointF>>());
				foreach (KeyValuePair<PointF, Enum99> keyValuePair2 in keyValuePair.Value.WayPoints[Enum57.const_1])
				{
					if (!keyValuePair2.Value.HasFlag(Enum99.flag_2) && keyValuePair2.Value != Enum99.flag_0)
					{
						if (keyValuePair2.Value == Enum99.flag_23)
						{
							this.pointF_0 = keyValuePair2.Key;
						}
					}
					else
					{
						HashSet<PointF> hashSet;
						if (dictionary.ContainsKey(keyValuePair2.Value))
						{
							hashSet = dictionary[keyValuePair2.Value];
						}
						else
						{
							dictionary.Add(keyValuePair2.Value, hashSet = new HashSet<PointF>());
						}
						hashSet.Add(keyValuePair2.Key);
					}
				}
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		private bool method_47(List<GardenerFloraRunning.Class165> estates)
		{
			Struct56? coords = Class269.smethod_0(this.class142_0, this.manualResetEventSlim_0, -1);
			if (coords == null)
			{
				return false;
			}
			this.class149_0.method_4();
			bool result;
			try
			{
				GardenerFloraRunning.Class169 @class = new GardenerFloraRunning.Class169();
				PointF pointF = coords.Value.Location;
				List<PointF> list = new List<PointF>();
				GardenerFloraRunning.Class165 class2;
				if (this.method_49(estates, out class2, false, coords))
				{
					PointF end_location = GardenerFloraRunning.smethod_4(this.dictionary_0[Enum85.const_6], Enum99.flag_0, pointF);
					list.AddRange(Class269.smethod_22(this.dictionary_0[(Enum85)class2.HouseColor][Enum99.flag_0], pointF, end_location));
					pointF = list[list.Count - 1];
				}
				list.AddRange(GardenerFloraRunning.smethod_2(this.dictionary_0[Enum85.const_6], pointF, this.pointF_0));
				@class.bool_0 = false;
				@class.nullable_0 = null;
				EventHandler eventHandler = null;
				GardenerFloraRunning.Class170 class3 = new GardenerFloraRunning.Class170();
				class3.class169_0 = @class;
				class3.manualResetEventSlim_0 = new ManualResetEventSlim(false);
				bool flag;
				try
				{
					try
					{
						GardenerFloraRunning.Class171 class4 = new GardenerFloraRunning.Class171();
						Class141 toonTownProcess = this.class142_0.ToonTownProcess;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler(class3.method_0);
						}
						toonTownProcess.ProcessExited += eventHandler;
						class4.waitHandle_0 = new WaitHandle[]
						{
							this.manualResetEventSlim_0.WaitHandle,
							class3.manualResetEventSlim_0.WaitHandle
						};
						Action<object> action = null;
						GardenerFloraRunning.Class172 class5 = new GardenerFloraRunning.Class172();
						class5.class171_0 = class4;
						class5.class170_0 = class3;
						class5.class169_0 = @class;
						class5.gardenerFloraRunning_0 = this;
						class5.cancellationTokenSource_0 = new CancellationTokenSource();
						try
						{
							if (action == null)
							{
								action = new Action<object>(class5.method_0);
							}
							using (Task task = new Task(action, class5.cancellationTokenSource_0.Token))
							{
								try
								{
									task.Start();
									Class269.smethod_2(this.class142_0, this.manualResetEventSlim_0, class3.manualResetEventSlim_0, list, this.class105_0, true);
									WaitHandle.WaitAny(class4.waitHandle_0, 2000);
									class3.manualResetEventSlim_0.Set();
									if (!this.class142_0.ToonTownProcess.ProcessOpen)
									{
										return false;
									}
								}
								finally
								{
									class5.cancellationTokenSource_0.Cancel();
									try
									{
										task.Wait();
									}
									catch (AggregateException)
									{
									}
								}
								flag = (@class.nullable_0 != null && @class.nullable_0.Value == Enum107.const_0);
							}
						}
						finally
						{
							if (class5.cancellationTokenSource_0 != null)
							{
								((IDisposable)class5.cancellationTokenSource_0).Dispose();
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
					if (class3.manualResetEventSlim_0 != null)
					{
						((IDisposable)class3.manualResetEventSlim_0).Dispose();
					}
				}
				if (!flag)
				{
					result = false;
				}
				else
				{
					base.method_17(this.class88_0.SellFlowersBounds, this.class105_0);
					this.manualResetEventSlim_0.Wait(1000);
					list.RemoveAt(list.Count - 1);
					list.Reverse();
					list.Add(coords.Value.Location);
					result = Class269.smethod_3(this.class142_0, this.manualResetEventSlim_0, list, this.class105_0, false);
				}
			}
			finally
			{
				this.class149_0.method_5();
			}
			return result;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0003FA98 File Offset: 0x0003DC98
		private bool method_48(Enum99 type, bool jump, GardenerFloraRunning.Class165 currentEstate, List<GardenerFloraRunning.Class165> estates, bool startingPath = false)
		{
			Struct56? coords = Class269.smethod_0(this.class142_0, this.manualResetEventSlim_0, -1);
			if (coords == null)
			{
				return false;
			}
			this.class149_0.method_4();
			bool result;
			try
			{
				Dictionary<Enum99, HashSet<PointF>> wayPointDestinations = this.dictionary_0[(Enum85)currentEstate.HouseColor];
				PointF pointF = coords.Value.Location;
				PointF pointF2 = GardenerFloraRunning.smethod_4(wayPointDestinations, type, pointF);
				List<PointF> list = new List<PointF>();
				GardenerFloraRunning.Class165 @class;
				if (startingPath && this.dictionary_0[Enum85.const_6].ContainsKey(Enum99.flag_0) && this.method_49(estates, out @class, false, coords))
				{
					if (currentEstate.HouseColor != @class.HouseColor && this.dictionary_0[(Enum85)@class.HouseColor].ContainsKey(Enum99.flag_0))
					{
						PointF end_location = GardenerFloraRunning.smethod_4(this.dictionary_0[Enum85.const_6], Enum99.flag_0, pointF);
						list.AddRange(Class269.smethod_22(this.dictionary_0[(Enum85)@class.HouseColor][Enum99.flag_0], pointF, end_location));
						pointF = list[list.Count - 1];
					}
					list.AddRange(Class269.smethod_22(this.dictionary_0[Enum85.const_6][Enum99.flag_0], pointF, pointF2));
					list.RemoveAt(list.Count - 1);
					if (list.Count > 0)
					{
						pointF = list[list.Count - 1];
					}
				}
				list.AddRange(GardenerFloraRunning.smethod_2(wayPointDestinations, pointF, pointF2));
				result = Class269.smethod_3(this.class142_0, this.manualResetEventSlim_0, list, this.class105_0, jump);
			}
			finally
			{
				this.class149_0.method_5();
			}
			return result;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0003FC48 File Offset: 0x0003DE48
		private static List<PointF> smethod_2(Dictionary<Enum99, HashSet<PointF>> wayPointDestinations, PointF coords, PointF target)
		{
			List<PointF> result;
			if (wayPointDestinations.ContainsKey(Enum99.flag_0))
			{
				result = Class269.smethod_22(wayPointDestinations[Enum99.flag_0], coords, target);
			}
			else
			{
				result = Class269.smethod_22(null, coords, target);
			}
			return result;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0003FC7C File Offset: 0x0003DE7C
		private bool method_49(List<GardenerFloraRunning.Class165> estates, out GardenerFloraRunning.Class165 estateGardenData, bool allowCustom = true, Struct56? coords = null)
		{
			Enum99 @enum;
			return this.method_50(estates, out estateGardenData, out @enum, allowCustom, coords);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0003FC98 File Offset: 0x0003DE98
		private bool method_50(List<GardenerFloraRunning.Class165> estates, out GardenerFloraRunning.Class165 estateGardenData, out Enum99 nearType, bool allowCustom = true, Struct56? coords = null)
		{
			estateGardenData = null;
			nearType = Enum99.flag_0;
			if (coords == null)
			{
				coords = Class269.smethod_0(this.class142_0, this.manualResetEventSlim_0, -1);
				if (coords == null)
				{
					return false;
				}
			}
			float num = float.MaxValue;
			PointF location = coords.Value.Location;
			foreach (GardenerFloraRunning.Class165 @class in estates)
			{
				float num2 = this.method_51(@class, location, allowCustom, out nearType);
				if (num > num2)
				{
					num = num2;
					estateGardenData = @class;
				}
			}
			return estateGardenData != null;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0003FD44 File Offset: 0x0003DF44
		private float method_51(GardenerFloraRunning.Class165 estate, PointF currentPos, bool allowCustom, out Enum99 nearType)
		{
			float num = float.MaxValue;
			Dictionary<Enum99, HashSet<PointF>> wayPoints = this.dictionary_0[(Enum85)estate.HouseColor];
			nearType = Enum99.flag_0;
			if (estate.Customized && allowCustom)
			{
				foreach (KeyValuePair<Enum99, Class93> keyValuePair in estate.Flowers)
				{
					float num2 = GardenerFloraRunning.smethod_3(wayPoints, keyValuePair.Key, currentPos);
					if (num > num2)
					{
						num = num2;
						nearType = keyValuePair.Key;
					}
				}
				using (List<KeyValuePair<Enum99, Class109>>.Enumerator enumerator2 = estate.Trees.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<Enum99, Class109> keyValuePair2 = enumerator2.Current;
						float num3 = GardenerFloraRunning.smethod_3(wayPoints, keyValuePair2.Key, currentPos);
						if (num > num3)
						{
							num = num3;
							nearType = keyValuePair2.Key;
						}
					}
					return num;
				}
			}
			foreach (Enum99 @enum in this.list_1)
			{
				float num4 = GardenerFloraRunning.smethod_3(wayPoints, @enum, currentPos);
				if (num > num4)
				{
					num = num4;
					nearType = @enum;
				}
			}
			foreach (Enum99 enum2 in this.list_0)
			{
				float num5 = GardenerFloraRunning.smethod_3(wayPoints, enum2, currentPos);
				if (num > num5)
				{
					num = num5;
					nearType = enum2;
				}
			}
			return num;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0003FEF0 File Offset: 0x0003E0F0
		private static float smethod_3(Dictionary<Enum99, HashSet<PointF>> wayPoints, Enum99 target, PointF currentPos)
		{
			float num = float.MaxValue;
			foreach (PointF p in wayPoints[target])
			{
				float num2 = Class477.smethod_9(currentPos, p);
				if (num > num2)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0003FF54 File Offset: 0x0003E154
		private static PointF smethod_4(Dictionary<Enum99, HashSet<PointF>> wayPointDestinations, Enum99 type, PointF currentPos)
		{
			float num = float.MaxValue;
			PointF? pointF = null;
			foreach (PointF pointF2 in wayPointDestinations[type])
			{
				float num2 = Class477.smethod_9(currentPos, pointF2);
				if (num > num2 || pointF == null)
				{
					num = num2;
					pointF = new PointF?(pointF2);
				}
			}
			return pointF.Value;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00007878 File Offset: 0x00005A78
		[CompilerGenerated]
		private static void smethod_5()
		{
			DialogBox.smethod_4("There has been an unknown error, details have been saved to the log file.", "Unknown Error");
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
		[CompilerGenerated]
		private void method_52(object obj)
		{
			try
			{
				this.method_25();
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				this.method_23();
			}
			finally
			{
				base.method_1(DialogResult.None);
			}
		}

		// Token: 0x040005C9 RID: 1481
		private Label JoeFishStatus;

		// Token: 0x040005CA RID: 1482
		private readonly Struct46 struct46_0;

		// Token: 0x040005CB RID: 1483
		private readonly Struct46 struct46_1;

		// Token: 0x040005CC RID: 1484
		private readonly Struct51 struct51_0;

		// Token: 0x040005CD RID: 1485
		private readonly Class113 class113_0;

		// Token: 0x040005CE RID: 1486
		private readonly Class88 class88_0;

		// Token: 0x040005CF RID: 1487
		private readonly Class90 class90_0;

		// Token: 0x040005D0 RID: 1488
		private readonly Dictionary<Enum85, Dictionary<Enum99, HashSet<PointF>>> dictionary_0;

		// Token: 0x040005D1 RID: 1489
		private readonly List<Enum99> list_0;

		// Token: 0x040005D2 RID: 1490
		private readonly List<Enum99> list_1;

		// Token: 0x040005D3 RID: 1491
		private readonly Class105 class105_0;

		// Token: 0x040005D4 RID: 1492
		private PointF pointF_0;

		// Token: 0x040005D5 RID: 1493
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_0;

		// Token: 0x02000220 RID: 544
		private sealed class Class165
		{
			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00007889 File Offset: 0x00005A89
			// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00007891 File Offset: 0x00005A91
			public List<KeyValuePair<Enum99, Class109>> Trees { get; private set; }

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0000789A File Offset: 0x00005A9A
			// (set) Token: 0x060017D7 RID: 6103 RVA: 0x000078A2 File Offset: 0x00005AA2
			public List<KeyValuePair<Enum99, Class93>> Flowers { get; private set; }

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000078AB File Offset: 0x00005AAB
			// (set) Token: 0x060017D9 RID: 6105 RVA: 0x000078B3 File Offset: 0x00005AB3
			public Enum13 HouseColor { get; private set; }

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x060017DA RID: 6106 RVA: 0x000078BC File Offset: 0x00005ABC
			// (set) Token: 0x060017DB RID: 6107 RVA: 0x000078C4 File Offset: 0x00005AC4
			public int? LastBeanCombinationIndex { get; set; }

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x060017DC RID: 6108 RVA: 0x000078CD File Offset: 0x00005ACD
			public bool Customized
			{
				get
				{
					return this.enum131_0.HasFlag(Enum131.flag_1);
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x000078E5 File Offset: 0x00005AE5
			public bool GardenTrees
			{
				get
				{
					return this.enum131_0.HasFlag(Enum131.flag_2);
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x060017DE RID: 6110 RVA: 0x000078FD File Offset: 0x00005AFD
			public int WaterCount
			{
				get
				{
					return this.int_0;
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x00007905 File Offset: 0x00005B05
			public bool GardenFlowers
			{
				get
				{
					return this.enum131_0.HasFlag(Enum131.flag_3);
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0000791D File Offset: 0x00005B1D
			public bool Water
			{
				get
				{
					return this.enum36_0.HasFlag(Enum36.flag_4);
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00007935 File Offset: 0x00005B35
			public bool Plant
			{
				get
				{
					return this.enum36_0.HasFlag(Enum36.flag_3);
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0000794D File Offset: 0x00005B4D
			public bool Pick
			{
				get
				{
					return this.enum36_0.HasFlag(Enum36.flag_2);
				}
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x00007965 File Offset: 0x00005B65
			public Class165(Enum131 targets, Enum36 actions, int waterCount, Enum13 houseColor)
			{
				this.enum131_0 = targets;
				this.enum36_0 = actions;
				this.int_0 = waterCount;
				this.HouseColor = houseColor;
				this.Trees = new List<KeyValuePair<Enum99, Class109>>();
				this.Flowers = new List<KeyValuePair<Enum99, Class93>>();
			}

			// Token: 0x040005D6 RID: 1494
			private Enum131 enum131_0;

			// Token: 0x040005D7 RID: 1495
			private Enum36 enum36_0;

			// Token: 0x040005D8 RID: 1496
			private int int_0;

			// Token: 0x040005D9 RID: 1497
			[CompilerGenerated]
			private List<KeyValuePair<Enum99, Class109>> list_0;

			// Token: 0x040005DA RID: 1498
			[CompilerGenerated]
			private List<KeyValuePair<Enum99, Class93>> list_1;

			// Token: 0x040005DB RID: 1499
			[CompilerGenerated]
			private Enum13 enum13_0;

			// Token: 0x040005DC RID: 1500
			[CompilerGenerated]
			private int? nullable_0;
		}

		// Token: 0x02000221 RID: 545
		[Flags]
		private enum Enum26
		{
			// Token: 0x040005DE RID: 1502
			flag_0 = 0,
			// Token: 0x040005DF RID: 1503
			flag_1 = 1,
			// Token: 0x040005E0 RID: 1504
			flag_2 = 2
		}

		// Token: 0x02000222 RID: 546
		private enum Enum27
		{
			// Token: 0x040005E2 RID: 1506
			const_0,
			// Token: 0x040005E3 RID: 1507
			const_1,
			// Token: 0x040005E4 RID: 1508
			const_2,
			// Token: 0x040005E5 RID: 1509
			const_3
		}

		// Token: 0x02000223 RID: 547
		[CompilerGenerated]
		private sealed class Class166
		{
			// Token: 0x040005E6 RID: 1510
			public List<GardenerFloraRunning.Class165> list_0;

			// Token: 0x040005E7 RID: 1511
			public bool bool_0;

			// Token: 0x040005E8 RID: 1512
			public GardenerFloraRunning gardenerFloraRunning_0;
		}

		// Token: 0x02000224 RID: 548
		[CompilerGenerated]
		private sealed class Class167
		{
			// Token: 0x060017E6 RID: 6118 RVA: 0x00040024 File Offset: 0x0003E224
			public bool method_0()
			{
				foreach (KeyValuePair<Enum99, Class93> keyValuePair in this.class165_0.Flowers)
				{
					if (!this.class166_0.gardenerFloraRunning_0.CanContinue)
					{
						break;
					}
					if (!this.class166_0.gardenerFloraRunning_0.method_48(keyValuePair.Key, false, this.class165_0, this.class166_0.list_0, this.class166_0.bool_0))
					{
						return false;
					}
					Class93 value = keyValuePair.Value;
					GardenerFloraRunning.Enum26 @enum = GardenerFloraRunning.Enum26.flag_0;
					if (value.Pick)
					{
						@enum = this.class166_0.gardenerFloraRunning_0.method_36(this.class166_0.list_0, value.Water, keyValuePair.Value.WaterCount);
						this.class166_0.gardenerFloraRunning_0.method_9();
					}
					if (value.Plant)
					{
						this.class166_0.gardenerFloraRunning_0.method_26(this.class165_0, keyValuePair.Value);
						this.class166_0.gardenerFloraRunning_0.method_9();
					}
					if (value.Water && (@enum.HasFlag(GardenerFloraRunning.Enum26.flag_1) || @enum == GardenerFloraRunning.Enum26.flag_0))
					{
						this.class166_0.gardenerFloraRunning_0.method_43(keyValuePair.Value.WaterCount);
						this.class166_0.gardenerFloraRunning_0.method_9();
					}
					this.class166_0.bool_0 = false;
				}
				return true;
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x000401C0 File Offset: 0x0003E3C0
			public bool method_1()
			{
				foreach (KeyValuePair<Enum99, Class109> keyValuePair in this.class165_0.Trees)
				{
					if (!this.class166_0.gardenerFloraRunning_0.CanContinue)
					{
						break;
					}
					if (!this.class166_0.gardenerFloraRunning_0.method_48(keyValuePair.Key, true, this.class165_0, this.class166_0.list_0, this.class166_0.bool_0))
					{
						return false;
					}
					if (!this.class166_0.gardenerFloraRunning_0.method_4(1000))
					{
						return false;
					}
					this.class166_0.gardenerFloraRunning_0.method_43(keyValuePair.Value.WaterCount);
					this.class166_0.bool_0 = false;
				}
				return true;
			}

			// Token: 0x060017E8 RID: 6120 RVA: 0x000079A0 File Offset: 0x00005BA0
			public bool method_2(KeyValuePair<Enum99, Class93> t)
			{
				return t.Key == this.enum99_0;
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x000079B1 File Offset: 0x00005BB1
			public bool method_3(KeyValuePair<Enum99, Class109> t)
			{
				return t.Key == this.enum99_0;
			}

			// Token: 0x060017EA RID: 6122 RVA: 0x000402B0 File Offset: 0x0003E4B0
			public bool method_4()
			{
				if (this.class165_0.GardenFlowers)
				{
					using (List<Enum99>.Enumerator enumerator = this.class166_0.gardenerFloraRunning_0.list_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Enum99 type = enumerator.Current;
							if (!this.class166_0.gardenerFloraRunning_0.CanContinue)
							{
								IL_16F:
								return true;
							}
							if (!this.class166_0.gardenerFloraRunning_0.method_48(type, false, this.class165_0, this.class166_0.list_0, this.class166_0.bool_0))
							{
								return false;
							}
							GardenerFloraRunning.Enum26 @enum = GardenerFloraRunning.Enum26.flag_0;
							if (this.class165_0.Pick)
							{
								@enum = this.class166_0.gardenerFloraRunning_0.method_36(this.class166_0.list_0, this.class165_0.Water, this.class165_0.WaterCount);
								this.class166_0.gardenerFloraRunning_0.method_9();
							}
							if (this.class165_0.Plant)
							{
								this.class166_0.gardenerFloraRunning_0.method_26(this.class165_0, null);
								this.class166_0.gardenerFloraRunning_0.method_9();
							}
							if (this.class165_0.Water && (@enum.HasFlag(GardenerFloraRunning.Enum26.flag_1) || @enum == GardenerFloraRunning.Enum26.flag_0))
							{
								this.class166_0.gardenerFloraRunning_0.method_43(this.class165_0.WaterCount);
								this.class166_0.gardenerFloraRunning_0.method_9();
							}
							this.class166_0.bool_0 = false;
						}
						goto IL_16F;
					}
					bool result;
					return result;
				}
				return true;
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x0004045C File Offset: 0x0003E65C
			public bool method_5()
			{
				if (this.class165_0.GardenTrees && this.class165_0.Water && this.class165_0.WaterCount > 0)
				{
					using (List<Enum99>.Enumerator enumerator = this.class166_0.gardenerFloraRunning_0.list_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Enum99 type = enumerator.Current;
							if (!this.class166_0.gardenerFloraRunning_0.CanContinue)
							{
								IL_EF:
								return true;
							}
							if (!this.class166_0.gardenerFloraRunning_0.method_48(type, true, this.class165_0, this.class166_0.list_0, this.class166_0.bool_0))
							{
								return false;
							}
							if (!this.class166_0.gardenerFloraRunning_0.method_4(1000))
							{
								return false;
							}
							this.class166_0.gardenerFloraRunning_0.method_43(this.class165_0.WaterCount);
							this.class166_0.bool_0 = false;
						}
						goto IL_EF;
					}
					bool result;
					return result;
				}
				return true;
			}

			// Token: 0x040005E9 RID: 1513
			public GardenerFloraRunning.Class166 class166_0;

			// Token: 0x040005EA RID: 1514
			public GardenerFloraRunning.Class165 class165_0;

			// Token: 0x040005EB RID: 1515
			public Enum99 enum99_0;
		}

		// Token: 0x02000225 RID: 549
		[CompilerGenerated]
		private sealed class Class168
		{
			// Token: 0x060017ED RID: 6125 RVA: 0x000079C2 File Offset: 0x00005BC2
			public void method_0()
			{
				this.manualResetEventSlim_0.Wait(10000);
				this.manualResetEventSlim_0.Set();
			}

			// Token: 0x040005EC RID: 1516
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x02000226 RID: 550
		[CompilerGenerated]
		private sealed class Class169
		{
			// Token: 0x040005ED RID: 1517
			public bool bool_0;

			// Token: 0x040005EE RID: 1518
			public Enum107? nullable_0;
		}

		// Token: 0x02000227 RID: 551
		[CompilerGenerated]
		private sealed class Class170
		{
			// Token: 0x060017F0 RID: 6128 RVA: 0x000079E0 File Offset: 0x00005BE0
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class169_0.bool_0)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x040005EF RID: 1519
			public GardenerFloraRunning.Class169 class169_0;

			// Token: 0x040005F0 RID: 1520
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x02000228 RID: 552
		[CompilerGenerated]
		private sealed class Class171
		{
			// Token: 0x040005F1 RID: 1521
			public WaitHandle[] waitHandle_0;
		}

		// Token: 0x02000229 RID: 553
		[CompilerGenerated]
		private sealed class Class172
		{
			// Token: 0x060017F3 RID: 6131 RVA: 0x0004057C File Offset: 0x0003E77C
			public void method_0(object obj)
			{
				while (!this.class170_0.manualResetEventSlim_0.IsSet && !this.gardenerFloraRunning_0.manualResetEventSlim_0.IsSet)
				{
					this.cancellationTokenSource_0.Token.ThrowIfCancellationRequested();
					this.gardenerFloraRunning_0.method_7();
					this.class169_0.nullable_0 = new Enum107?(Class433.smethod_0(this.gardenerFloraRunning_0.class142_0.ToonTownProcess, this.gardenerFloraRunning_0.class88_0.SellFlowersCapture, this.gardenerFloraRunning_0.class88_0.SellFlowersBounds, this.gardenerFloraRunning_0.class105_0));
					if (this.class169_0.nullable_0 != null && this.class169_0.nullable_0.Value == Enum107.const_0)
					{
						this.class170_0.manualResetEventSlim_0.Set();
						return;
					}
					WaitHandle.WaitAny(this.class171_0.waitHandle_0, 1000);
				}
			}

			// Token: 0x040005F2 RID: 1522
			public GardenerFloraRunning.Class171 class171_0;

			// Token: 0x040005F3 RID: 1523
			public GardenerFloraRunning.Class170 class170_0;

			// Token: 0x040005F4 RID: 1524
			public GardenerFloraRunning.Class169 class169_0;

			// Token: 0x040005F5 RID: 1525
			public CancellationTokenSource cancellationTokenSource_0;

			// Token: 0x040005F6 RID: 1526
			public GardenerFloraRunning gardenerFloraRunning_0;
		}
	}
}
