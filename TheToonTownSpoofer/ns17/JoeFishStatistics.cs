using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns26;
using ns27;
using ns28;

namespace ns17
{
	// Token: 0x02000263 RID: 611
	internal sealed partial class JoeFishStatistics : Form
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00009404 File Offset: 0x00007604
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000940C File Offset: 0x0000760C
		public Struct52? JoeFishRunStatistics { get; set; }

		// Token: 0x06001A15 RID: 6677 RVA: 0x00009415 File Offset: 0x00007615
		public JoeFishStatistics()
		{
			this.InitializeComponent();
			base.Icon = Class480.PenPaper_Icon;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0000942E File Offset: 0x0000762E
		private void JoeFishStatistics_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00049EB0 File Offset: 0x000480B0
		private void method_0()
		{
			if (this.JoeFishRunStatistics != null)
			{
				Struct52 value = this.JoeFishRunStatistics.Value;
				this.StatisticsList.Items.Add("Started: " + value.StartTime.ToString("g"));
				this.StatisticsList.Items.Add("Ended: " + value.EndTime.ToString("g"));
				TimeSpan time = value.EndTime - value.StartTime;
				this.StatisticsList.Items.Add("Run time: " + JoeFishStatistics.smethod_1(time));
				this.StatisticsList.Items.Add("Fish caught: " + value.FishCaught.ToString());
				this.StatisticsList.Items.Add("Casts: " + value.Casts.ToString());
				this.StatisticsList.Items.Add("Success rate: " + JoeFishStatistics.smethod_0(value.FishCaught, value.Casts));
				this.StatisticsList.Items.Add("Boots caught: " + value.BootsCaught.ToString());
				this.StatisticsList.Items.Add("Buckets sold: " + value.BucketsSold.ToString());
			}
			Struct50 joeFishTotalRunStatistics = Class110.Instance.JoeFishSettings.JoeFishTotalRunStatistics;
			this.StatisticsList.Items.Add("Total run time: " + JoeFishStatistics.smethod_1(joeFishTotalRunStatistics.TotalRunTime));
			this.StatisticsList.Items.Add("Total fish caught: " + joeFishTotalRunStatistics.TotalFishCaught.ToString());
			this.StatisticsList.Items.Add("Total casts: " + joeFishTotalRunStatistics.TotalCasts.ToString());
			this.StatisticsList.Items.Add("Total success rate: " + JoeFishStatistics.smethod_0(joeFishTotalRunStatistics.TotalFishCaught, joeFishTotalRunStatistics.TotalCasts));
			this.StatisticsList.Items.Add("Total boots caught: " + joeFishTotalRunStatistics.TotalBootsCaught.ToString());
			this.StatisticsList.Items.Add("Total buckets sold: " + joeFishTotalRunStatistics.TotalBucketsSold.ToString());
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00005870 File Offset: 0x00003A70
		private void OKBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0004A160 File Offset: 0x00048360
		private void ResetBtn_Click(object sender, EventArgs e)
		{
			if (DialogBox.smethod_6("Are you sure you want to reset Joe Fish statistics?", "Stat Reset", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) == DialogResult.Yes)
			{
				this.JoeFishRunStatistics = null;
				Class110.Instance.JoeFishSettings.JoeFishTotalRunStatistics = Struct50.struct50_0;
				this.StatisticsList.Items.Clear();
				this.method_0();
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00009436 File Offset: 0x00007636
		private static string smethod_0(uint fishCaught, uint totalCasts)
		{
			if (totalCasts == 0U)
			{
				return "Unknown";
			}
			return string.Format("{0:0.00}%", fishCaught / totalCasts * 100.0);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0004A1C8 File Offset: 0x000483C8
		private static string smethod_1(TimeSpan time)
		{
			string str = string.Empty;
			if (time.Days > 0)
			{
				str = str + time.Days.ToString() + " days, ";
			}
			return str + time.ToString("h':'mm':'ss");
		}

		// Token: 0x04000793 RID: 1939
		[CompilerGenerated]
		private Struct52? nullable_0;
	}
}
