namespace ns17
{
	// Token: 0x02000263 RID: 611
	internal sealed partial class JoeFishStatistics : global::System.Windows.Forms.Form
	{
		// Token: 0x06001A11 RID: 6673 RVA: 0x000093E5 File Offset: 0x000075E5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00049BAC File Offset: 0x00047DAC
		private void InitializeComponent()
		{
			this.OKBtn = new global::System.Windows.Forms.Button();
			this.StatisticsLabel = new global::System.Windows.Forms.Label();
			this.StatisticsList = new global::System.Windows.Forms.ListBox();
			this.ResetBtn = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.OKBtn.Location = new global::System.Drawing.Point(202, 210);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new global::System.Drawing.Size(75, 23);
			this.OKBtn.TabIndex = 0;
			this.OKBtn.Text = "&OK";
			this.OKBtn.UseVisualStyleBackColor = true;
			this.OKBtn.Click += new global::System.EventHandler(this.OKBtn_Click);
			this.StatisticsLabel.AutoSize = true;
			this.StatisticsLabel.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.StatisticsLabel.Location = new global::System.Drawing.Point(7, 11);
			this.StatisticsLabel.Name = "StatisticsLabel";
			this.StatisticsLabel.Size = new global::System.Drawing.Size(88, 26);
			this.StatisticsLabel.TabIndex = 11;
			this.StatisticsLabel.Text = "Statistics";
			this.StatisticsList.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.StatisticsList.FormattingEnabled = true;
			this.StatisticsList.ItemHeight = 16;
			this.StatisticsList.Location = new global::System.Drawing.Point(12, 40);
			this.StatisticsList.Name = "StatisticsList";
			this.StatisticsList.Size = new global::System.Drawing.Size(265, 164);
			this.StatisticsList.TabIndex = 12;
			this.ResetBtn.Location = new global::System.Drawing.Point(121, 210);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new global::System.Drawing.Size(75, 23);
			this.ResetBtn.TabIndex = 13;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new global::System.EventHandler(this.ResetBtn_Click);
			base.AcceptButton = this.OKBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(289, 243);
			base.Controls.Add(this.ResetBtn);
			base.Controls.Add(this.StatisticsList);
			base.Controls.Add(this.StatisticsLabel);
			base.Controls.Add(this.OKBtn);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "JoeFishStatistics";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Joe Fish : Statistics";
			base.Load += new global::System.EventHandler(this.JoeFishStatistics_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400078E RID: 1934
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400078F RID: 1935
		private global::System.Windows.Forms.Button OKBtn;

		// Token: 0x04000790 RID: 1936
		private global::System.Windows.Forms.Label StatisticsLabel;

		// Token: 0x04000791 RID: 1937
		private global::System.Windows.Forms.ListBox StatisticsList;

		// Token: 0x04000792 RID: 1938
		private global::System.Windows.Forms.Button ResetBtn;
	}
}
