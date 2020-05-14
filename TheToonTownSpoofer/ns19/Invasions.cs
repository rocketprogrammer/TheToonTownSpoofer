using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using ns15;
using ns16;
using ns20;
using ns22;
using ns24;
using ns26;
using ns29;
using ns31;

namespace ns19
{
	// Token: 0x02000416 RID: 1046
	internal sealed partial class Invasions : Form
	{
		// Token: 0x060027B1 RID: 10161 RVA: 0x00092D40 File Offset: 0x00090F40
		public Invasions()
		{
			this.InitializeComponent();
			this.method_3(null, null);
			Class142.WindowDistrictChanged += this.method_1;
			Class142.WindowInvasionStateChanged += this.method_2;
			this.method_0();
			this.control_0 = new Control();
			this.control_0.Location = this.grpInvasions.ImageBounds.Location;
			Control control = this.control_0;
			EventHandler value = new EventHandler(this.method_10);
			control.LocationChanged += value;
			this.class343_0.ControlToSlide = this.control_0;
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00092DFC File Offset: 0x00090FFC
		private void method_0()
		{
			this.cboDistricts.Items.Clear();
			this.dictionary_0.Clear();
			this.dictionary_1.Clear();
			ReadOnlyCollection<Class142> openToonTownWindows = Class142.OpenToonTownWindows;
			lock (((ICollection)openToonTownWindows).SyncRoot)
			{
				foreach (Class142 @class in openToonTownWindows)
				{
					if (@class.District != null)
					{
						Invasions.Class430 class2;
						if (!this.dictionary_0.ContainsKey(@class.District))
						{
							this.dictionary_0.Add(@class.District, class2 = new Invasions.Class430(@class.District));
						}
						else
						{
							class2 = this.dictionary_0[@class.District];
						}
						class2.Windows.Add(@class);
						this.dictionary_1.Add(@class, class2);
					}
				}
			}
			IEnumerable<Invasions.Class430> values = this.dictionary_0.Values;
			if (Invasions.func_0 == null)
			{
				Invasions.func_0 = new Func<Invasions.Class430, string>(Invasions.smethod_2);
			}
			object[] array = values.OrderBy(Invasions.func_0).ToArray<Invasions.Class430>();
			this.cboDistricts.Items.AddRange(array);
			if (array.Length > 0)
			{
				this.cboDistricts.SelectedItem = array[0];
				return;
			}
			this.cboDistricts.SelectedItem = null;
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00092F68 File Offset: 0x00091168
		private void method_1(object sender, EventArgs37 e)
		{
			Invasions.Class431 @class = new Invasions.Class431();
			@class.object_0 = sender;
			@class.eventArgs37_0 = e;
			@class.invasions_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00092FA4 File Offset: 0x000911A4
		private void method_2(object sender, EventArgs31 e)
		{
			Invasions.Class432 @class = new Invasions.Class432();
			@class.object_0 = sender;
			@class.eventArgs31_0 = e;
			@class.invasions_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00092FE0 File Offset: 0x000911E0
		private void method_3(Class177 district, Struct26? state)
		{
			this.nullable_0 = null;
			this.nullable_1 = null;
			if (state != null && district != null)
			{
				this.nullable_1 = new TimeSpan?(DateTime.Now - state.Value.dateTime_0);
				this.ledDisplay.On = true;
				Struct26 value = state.Value;
				this.method_4(value.class464_0.enum132_0);
				this.lblCog.Text = value.class464_0.string_0;
				this.lblCogType.Text = value.class464_0.enum132_0.smethod_0();
				this.lblTimeElapsed.Text = Invasions.smethod_0(this.nullable_1.Value);
				if (this.nullable_0 != null)
				{
					this.lblTimeRemaining.Text = Invasions.smethod_0(this.nullable_0.Value);
				}
				else
				{
					this.lblTimeRemaining.Text = "Unknown";
				}
				this.timer_0.Enabled = true;
			}
			else
			{
				this.timer_0.Enabled = false;
				this.ledDisplay.On = false;
				this.method_4(Enum132.const_0);
				this.lblCog.Text = "None";
				this.lblCogType.Text = "None";
				this.lblTimeElapsed.Text = "00:00";
				this.lblTimeRemaining.Text = "00:00";
			}
			this.method_7();
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x0009315C File Offset: 0x0009135C
		private void method_4(Enum132 type)
		{
			switch (type)
			{
			case Enum132.const_1:
				this.ledDisplay.BaseColor = Color.FromArgb(255, 0, 0);
				return;
			case Enum132.const_2:
				this.ledDisplay.BaseColor = Color.FromArgb(153, 255, 54);
				return;
			case Enum132.const_3:
				this.ledDisplay.BaseColor = Color.FromArgb(200, 100, 0);
				return;
			case Enum132.const_4:
				this.ledDisplay.BaseColor = Color.FromArgb(14, 0, 200);
				return;
			default:
				this.ledDisplay.BaseColor = Color.FromArgb(64, 64, 64);
				return;
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00011F22 File Offset: 0x00010122
		private void timer_0_Elapsed(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_11));
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00093200 File Offset: 0x00091400
		private static string smethod_0(TimeSpan ts)
		{
			if (ts.Days > 0)
			{
				return ts.ToString("dd") + " Days";
			}
			if (ts.Hours > 0)
			{
				return ts.ToString("hh':'mm':'ss");
			}
			return ts.ToString("mm':'ss");
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00093254 File Offset: 0x00091454
		private void method_5(DateTime startTime)
		{
			if (startTime < DateTime.Now - this.nullable_1.Value)
			{
				this.nullable_1 = new TimeSpan?(DateTime.Now - startTime);
				this.lblTimeElapsed.Text = Invasions.smethod_0(this.nullable_1.Value);
			}
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000932B0 File Offset: 0x000914B0
		private void method_6(DateTime startTime, uint estimatedDuration)
		{
			DateTime dateTime = startTime + new TimeSpan(0, 0, (int)estimatedDuration);
			DateTime now = DateTime.Now;
			if (now > dateTime)
			{
				this.nullable_0 = new TimeSpan?(TimeSpan.Zero);
			}
			else
			{
				this.nullable_0 = new TimeSpan?(dateTime - now);
			}
			this.lblTimeRemaining.Text = Invasions.smethod_0(this.nullable_0.Value);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0009331C File Offset: 0x0009151C
		private void method_7()
		{
			if (this.nullable_0 == null)
			{
				this.lblTimeRemaining.ForeColor = Color.DimGray;
				return;
			}
			if (this.nullable_0.Value.TotalSeconds < 60.0)
			{
				this.lblTimeRemaining.ForeColor = Color.Red;
				return;
			}
			if (this.nullable_0.Value.TotalSeconds < 120.0)
			{
				this.lblTimeRemaining.ForeColor = Color.FromArgb(255, 153, 0);
				return;
			}
			this.lblTimeRemaining.ForeColor = Color.DimGray;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000933C0 File Offset: 0x000915C0
		private void method_8(Class177 district, string cogID, uint cogsRemaining, bool skelecog, DateTime startTime)
		{
			if (district == null)
			{
				throw new ArgumentNullException("district");
			}
			if (string.IsNullOrEmpty(cogID))
			{
				throw new ArgumentNullException("cogID");
			}
			if (!Class464.Cogs.ContainsKey(cogID))
			{
				throw new ArgumentException("The cog type is invalid: " + cogID);
			}
			this.nullable_0 = null;
			uint? num;
			Struct40.smethod_1(district, Class464.Cogs[cogID], cogsRemaining, skelecog, startTime, out num, out startTime);
			startTime = startTime.ToLocalTime();
			if (num != null)
			{
				this.method_6(startTime, num.Value);
			}
			else
			{
				this.lblTimeRemaining.Text = "Unknown";
			}
			this.method_5(startTime);
			this.method_7();
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00011F36 File Offset: 0x00010136
		private void method_9(Class177 district)
		{
			Struct40.smethod_3(district);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00093474 File Offset: 0x00091674
		private void cboDistricts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cboDistricts.SelectedItem == null)
			{
				this.method_3(null, null);
				return;
			}
			Invasions.Class430 @class = this.cboDistricts.SelectedItem as Invasions.Class430;
			Class142 class2 = Invasions.smethod_1(@class.Windows);
			if (class2 == null)
			{
				this.method_3(null, null);
				return;
			}
			this.method_3(class2.District, class2.Invasion);
			Struct26 value = class2.Invasion.Value;
			this.method_8(class2.District, value.class464_0.string_1, value.uint_0, value.bool_0, value.dateTime_0);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00093520 File Offset: 0x00091720
		private static Class142 smethod_1(ICollection<Class142> windows)
		{
			uint num = 0U;
			Class142 result = null;
			foreach (Class142 @class in windows)
			{
				if (@class.Invasion != null && num < @class.Invasion.Value.uint_0)
				{
					num = @class.Invasion.Value.uint_0;
					result = @class;
				}
			}
			return result;
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00011F3E File Offset: 0x0001013E
		private void Invasions_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_6);
			e.Handled = true;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00011F4D File Offset: 0x0001014D
		[CompilerGenerated]
		private void method_10(object sender, EventArgs e)
		{
			this.grpInvasions.ImageLocation = this.control_0.Location;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00011F65 File Offset: 0x00010165
		[CompilerGenerated]
		private static string smethod_2(Invasions.Class430 item)
		{
			return item.District.string_0;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000935A8 File Offset: 0x000917A8
		[CompilerGenerated]
		private void method_11()
		{
			if (this.nullable_1 != null)
			{
				this.nullable_1 = new TimeSpan?(this.nullable_1.Value.Add(Invasions.timeSpan_0));
				this.lblTimeElapsed.Text = Invasions.smethod_0(this.nullable_1.Value);
				if (this.nullable_0 != null && this.nullable_0.Value.TotalSeconds > 0.0)
				{
					this.nullable_0 = new TimeSpan?(this.nullable_0.Value.Subtract(Invasions.timeSpan_0));
					this.lblTimeRemaining.Text = Invasions.smethod_0(this.nullable_0.Value);
					this.method_7();
				}
			}
		}

		// Token: 0x040013E8 RID: 5096
		private static readonly TimeSpan timeSpan_0 = new TimeSpan(0, 0, 1);

		// Token: 0x040013E9 RID: 5097
		private TimeSpan? nullable_0;

		// Token: 0x040013EA RID: 5098
		private TimeSpan? nullable_1;

		// Token: 0x040013EB RID: 5099
		private Dictionary<Class177, Invasions.Class430> dictionary_0 = new Dictionary<Class177, Invasions.Class430>();

		// Token: 0x040013EC RID: 5100
		private Dictionary<Class142, Invasions.Class430> dictionary_1 = new Dictionary<Class142, Invasions.Class430>();

		// Token: 0x040013ED RID: 5101
		private Control control_0;

		// Token: 0x040013EE RID: 5102
		[CompilerGenerated]
		private static Func<Invasions.Class430, string> func_0;

		// Token: 0x02000417 RID: 1047
		private sealed class Class430
		{
			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x060027C5 RID: 10181 RVA: 0x00011F81 File Offset: 0x00010181
			// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00011F89 File Offset: 0x00010189
			public List<Class142> Windows { get; private set; }

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00011F92 File Offset: 0x00010192
			// (set) Token: 0x060027C8 RID: 10184 RVA: 0x00011F9A File Offset: 0x0001019A
			public Class177 District { get; private set; }

			// Token: 0x060027C9 RID: 10185 RVA: 0x00011FA3 File Offset: 0x000101A3
			public Class430(Class177 district)
			{
				if (district == null)
				{
					throw new ArgumentNullException("district");
				}
				this.Windows = new List<Class142>();
				this.District = district;
			}

			// Token: 0x060027CA RID: 10186 RVA: 0x00011FCB File Offset: 0x000101CB
			public override string ToString()
			{
				return this.District.string_0 + this.method_0();
			}

			// Token: 0x060027CB RID: 10187 RVA: 0x00093674 File Offset: 0x00091874
			private string method_0()
			{
				string result;
				lock (((ICollection)this.Windows).SyncRoot)
				{
					if (this.Windows.Count == 0)
					{
						result = string.Empty;
					}
					else
					{
						string str = " (";
						for (int i = 0; i < this.Windows.Count; i++)
						{
							if (i > 0)
							{
								str += ", ";
							}
							str += this.Windows[i].Username;
						}
						result = str + ")";
					}
				}
				return result;
			}

			// Token: 0x040013EF RID: 5103
			[CompilerGenerated]
			private List<Class142> list_0;

			// Token: 0x040013F0 RID: 5104
			[CompilerGenerated]
			private Class177 class177_0;
		}

		// Token: 0x02000418 RID: 1048
		[CompilerGenerated]
		private sealed class Class431
		{
			// Token: 0x060027CD RID: 10189 RVA: 0x0009371C File Offset: 0x0009191C
			public void method_0()
			{
				Class142 @class = this.object_0 as Class142;
				bool flag = false;
				this.invasions_0.cboDistricts.BeginUpdate();
				if (this.invasions_0.dictionary_1.ContainsKey(@class))
				{
					Invasions.Class430 class2 = this.invasions_0.dictionary_1[@class];
					if (this.invasions_0.cboDistricts.SelectedItem == class2)
					{
						flag = (class2.Windows.IndexOf(@class) == 0 && class2.Windows.Count == 1);
					}
					class2.Windows.Remove(@class);
					this.invasions_0.dictionary_1.Remove(@class);
					if (class2.Windows.Count == 0)
					{
						this.invasions_0.dictionary_0.Remove(class2.District);
						this.invasions_0.cboDistricts.Items.Remove(class2);
					}
				}
				if (this.eventArgs37_0.District == null)
				{
					if (this.invasions_0.cboDistricts.Items.Count > 0)
					{
						if (flag)
						{
							this.invasions_0.cboDistricts.SelectedIndex = 0;
						}
					}
					else
					{
						this.invasions_0.method_3(null, null);
					}
				}
				else
				{
					Invasions.Class430 class3;
					if (this.invasions_0.dictionary_0.ContainsKey(this.eventArgs37_0.District))
					{
						class3 = this.invasions_0.dictionary_0[this.eventArgs37_0.District];
					}
					else
					{
						this.invasions_0.dictionary_0.Add(this.eventArgs37_0.District, class3 = new Invasions.Class430(this.eventArgs37_0.District));
						this.invasions_0.cboDistricts.Items.Add(class3);
					}
					class3.Windows.Add(@class);
					this.invasions_0.dictionary_1.Add(@class, class3);
					this.invasions_0.cboDistricts.imethod_2(class3);
					if (flag || this.invasions_0.cboDistricts.SelectedItem == null)
					{
						this.invasions_0.cboDistricts.SelectedItem = class3;
					}
				}
				this.invasions_0.cboDistricts.EndUpdate();
			}

			// Token: 0x040013F1 RID: 5105
			public Invasions invasions_0;

			// Token: 0x040013F2 RID: 5106
			public object object_0;

			// Token: 0x040013F3 RID: 5107
			public EventArgs37 eventArgs37_0;
		}

		// Token: 0x02000419 RID: 1049
		[CompilerGenerated]
		private sealed class Class432
		{
			// Token: 0x060027CF RID: 10191 RVA: 0x0009393C File Offset: 0x00091B3C
			public void method_0()
			{
				Class142 @class = this.object_0 as Class142;
				Invasions.Class430 class2 = this.invasions_0.cboDistricts.SelectedItem as Invasions.Class430;
				if (class2 != null)
				{
					Class177 district = class2.District;
					if (class2.Windows.IndexOf(@class) == 0 && district == @class.District)
					{
						switch (this.eventArgs31_0.InvasionState.enum97_0)
						{
						case Enum97.const_0:
						case Enum97.const_2:
							if (!this.invasions_0.class343_0.Enabled)
							{
								this.invasions_0.class343_0.Enabled = true;
							}
							this.invasions_0.method_3(@class.District, new Struct26?(this.eventArgs31_0.InvasionState));
							this.invasions_0.method_8(@class.District, this.eventArgs31_0.InvasionState.class464_0.string_1, this.eventArgs31_0.InvasionState.uint_0, this.eventArgs31_0.InvasionState.bool_0, this.eventArgs31_0.InvasionState.dateTime_0);
							break;
						case (Enum97)1:
							break;
						case Enum97.const_1:
							this.invasions_0.method_3(null, null);
							this.invasions_0.method_9(@class.District);
							return;
						default:
							return;
						}
					}
				}
			}

			// Token: 0x040013F4 RID: 5108
			public Invasions invasions_0;

			// Token: 0x040013F5 RID: 5109
			public object object_0;

			// Token: 0x040013F6 RID: 5110
			public EventArgs31 eventArgs31_0;
		}
	}
}
