namespace ns19
{
	// Token: 0x02000416 RID: 1046
	internal sealed partial class Invasions : global::System.Windows.Forms.Form
	{
		// Token: 0x060027AF RID: 10159 RVA: 0x00092074 File Offset: 0x00090274
		protected override void Dispose(bool disposing)
		{
			global::ns20.Class142.WindowDistrictChanged -= new global::System.EventHandler<global::ns19.EventArgs37>(this.method_1);
			global::ns20.Class142.WindowInvasionStateChanged -= new global::System.EventHandler<global::ns22.EventArgs31>(this.method_2);
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000920C0 File Offset: 0x000902C0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns19.Invasions));
			this.timer_0 = new global::System.Timers.Timer();
			this.grpInvasions = new global::ns24.Class310();
			this.flowLayoutPanel2 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.lblTimeElapsed = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.lblTimeRemaining = new global::System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblCog = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.lblCogType = new global::System.Windows.Forms.Label();
			this.cboDistricts = new global::ns24.Class295();
			this.lblDistricts = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ledDisplay = new global::ns29.Control12();
			this.class343_0 = new global::ns22.Class343(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.timer_0).BeginInit();
			this.grpInvasions.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 1000.0;
			this.timer_0.SynchronizingObject = this;
			this.timer_0.Elapsed += new global::System.Timers.ElapsedEventHandler(this.timer_0_Elapsed);
			this.grpInvasions.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.grpInvasions.Controls.Add(this.flowLayoutPanel2);
			this.grpInvasions.Controls.Add(this.flowLayoutPanel1);
			this.grpInvasions.Controls.Add(this.cboDistricts);
			this.grpInvasions.Controls.Add(this.lblDistricts);
			this.grpInvasions.Controls.Add(this.label3);
			this.grpInvasions.Controls.Add(this.ledDisplay);
			this.grpInvasions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grpInvasions.HeaderHeight = 30;
			this.grpInvasions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("grpInvasions.Image");
			this.grpInvasions.ImageBounds = new global::System.Drawing.Rectangle(400, 34, 86, 70);
			this.grpInvasions.ImageLocation = new global::System.Drawing.Point(400, 34);
			this.grpInvasions.Location = new global::System.Drawing.Point(4, 4);
			this.grpInvasions.Name = "grpInvasions";
			this.grpInvasions.Size = new global::System.Drawing.Size(396, 106);
			this.grpInvasions.TabIndex = 2;
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flowLayoutPanel2.Controls.Add(this.label4);
			this.flowLayoutPanel2.Controls.Add(this.lblTimeElapsed);
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.lblTimeRemaining);
			this.flowLayoutPanel2.Location = new global::System.Drawing.Point(72, 79);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new global::System.Drawing.Size(246, 16);
			this.flowLayoutPanel2.TabIndex = 24;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.ForeColor = global::System.Drawing.Color.DimGray;
			this.label4.Location = new global::System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(74, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Time Elapsed:";
			this.lblTimeElapsed.AutoSize = true;
			this.lblTimeElapsed.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTimeElapsed.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTimeElapsed.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblTimeElapsed.Location = new global::System.Drawing.Point(83, 0);
			this.lblTimeElapsed.Name = "lblTimeElapsed";
			this.lblTimeElapsed.Size = new global::System.Drawing.Size(44, 16);
			this.lblTimeElapsed.TabIndex = 21;
			this.lblTimeElapsed.Text = "00:00";
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.ForeColor = global::System.Drawing.Color.DimGray;
			this.label2.Location = new global::System.Drawing.Point(133, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(60, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Remaining:";
			this.lblTimeRemaining.AutoSize = true;
			this.lblTimeRemaining.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTimeRemaining.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTimeRemaining.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblTimeRemaining.Location = new global::System.Drawing.Point(199, 0);
			this.lblTimeRemaining.Name = "lblTimeRemaining";
			this.lblTimeRemaining.Size = new global::System.Drawing.Size(44, 16);
			this.lblTimeRemaining.TabIndex = 21;
			this.lblTimeRemaining.Text = "00:00";
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.lblCog);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this.lblCogType);
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(72, 45);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(199, 16);
			this.flowLayoutPanel1.TabIndex = 23;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.ForeColor = global::System.Drawing.Color.DimGray;
			this.label1.Location = new global::System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Cog:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCog.AutoSize = true;
			this.lblCog.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCog.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCog.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblCog.Location = new global::System.Drawing.Point(38, 0);
			this.lblCog.Name = "lblCog";
			this.lblCog.Size = new global::System.Drawing.Size(45, 16);
			this.lblCog.TabIndex = 21;
			this.lblCog.Text = "None";
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.ForeColor = global::System.Drawing.Color.DimGray;
			this.label5.Location = new global::System.Drawing.Point(89, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(56, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Cog Type:";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCogType.AutoSize = true;
			this.lblCogType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCogType.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCogType.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblCogType.Location = new global::System.Drawing.Point(151, 0);
			this.lblCogType.Name = "lblCogType";
			this.lblCogType.Size = new global::System.Drawing.Size(45, 16);
			this.lblCogType.TabIndex = 21;
			this.lblCogType.Text = "None";
			this.cboDistricts.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDistricts.FormattingEnabled = true;
			this.cboDistricts.Location = new global::System.Drawing.Point(158, 7);
			this.cboDistricts.Name = "cboDistricts";
			this.cboDistricts.Size = new global::System.Drawing.Size(127, 21);
			this.cboDistricts.TabIndex = 20;
			this.cboDistricts.SelectedIndexChanged += new global::System.EventHandler(this.cboDistricts_SelectedIndexChanged);
			this.lblDistricts.AutoSize = true;
			this.lblDistricts.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDistricts.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblDistricts.ForeColor = global::System.Drawing.Color.DarkGray;
			this.lblDistricts.Location = new global::System.Drawing.Point(85, 9);
			this.lblDistricts.Name = "lblDistricts";
			this.lblDistricts.Size = new global::System.Drawing.Size(67, 19);
			this.lblDistricts.TabIndex = 11;
			this.lblDistricts.Text = "Districts:";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 95);
			this.label3.Location = new global::System.Drawing.Point(7, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(72, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Invasions";
			this.ledDisplay.BackColor = global::System.Drawing.Color.Transparent;
			this.ledDisplay.BaseColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.ledDisplay.Location = new global::System.Drawing.Point(16, 45);
			this.ledDisplay.Name = "ledDisplay";
			this.ledDisplay.On = true;
			this.ledDisplay.Size = new global::System.Drawing.Size(50, 50);
			this.ledDisplay.TabIndex = 0;
			this.ledDisplay.Text = "led1";
			this.class343_0.ContractDistance = 6;
			this.class343_0.ContractedDelay = 2000;
			this.class343_0.ContractRate = 30;
			this.class343_0.ControlToSlide = null;
			this.class343_0.Enabled = false;
			this.class343_0.EndPosition = 330;
			this.class343_0.ExpandDistance = 2;
			this.class343_0.ExpandedDelay = 6000;
			this.class343_0.ExpandRate = 10;
			this.class343_0.RunOnce = true;
			this.class343_0.SlideDirection = global::ns19.Enum100.const_0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.ClientSize = new global::System.Drawing.Size(404, 114);
			base.Controls.Add(this.grpInvasions);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Invasions";
			base.Padding = new global::System.Windows.Forms.Padding(4);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Invasions";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.Invasions_HelpRequested);
			((global::System.ComponentModel.ISupportInitialize)this.timer_0).EndInit();
			this.grpInvasions.ResumeLayout(false);
			this.grpInvasions.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040013D6 RID: 5078
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040013D7 RID: 5079
		private global::ns29.Control12 ledDisplay;

		// Token: 0x040013D8 RID: 5080
		private global::ns24.Class310 grpInvasions;

		// Token: 0x040013D9 RID: 5081
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040013DA RID: 5082
		private global::System.Windows.Forms.Label lblDistricts;

		// Token: 0x040013DB RID: 5083
		private global::ns24.Class295 cboDistricts;

		// Token: 0x040013DC RID: 5084
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040013DD RID: 5085
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040013DE RID: 5086
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040013DF RID: 5087
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040013E0 RID: 5088
		private global::System.Windows.Forms.Label lblCog;

		// Token: 0x040013E1 RID: 5089
		private global::System.Windows.Forms.Label lblCogType;

		// Token: 0x040013E2 RID: 5090
		private global::System.Windows.Forms.Label lblTimeRemaining;

		// Token: 0x040013E3 RID: 5091
		private global::System.Windows.Forms.Label lblTimeElapsed;

		// Token: 0x040013E4 RID: 5092
		private global::System.Timers.Timer timer_0;

		// Token: 0x040013E5 RID: 5093
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

		// Token: 0x040013E6 RID: 5094
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x040013E7 RID: 5095
		private global::ns22.Class343 class343_0;
	}
}
