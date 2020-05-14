using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns17;
using ns18;
using ns20;
using ns23;
using ns24;
using ns26;
using ns29;
using ns31;

namespace ns14
{
	// Token: 0x020001CA RID: 458
	internal sealed partial class RaceTrack : SaveForm
	{
		// Token: 0x060014A1 RID: 5281 RVA: 0x00025BC8 File Offset: 0x00023DC8
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RaceTrack));
			this.tabRaces = new TabControl();
			this.tabWelcome = new TabPage();
			this.picWelcome = new PictureBox();
			this.tabSpeedway = new TabPage();
			this.picSpeedway = new PictureBox();
			this.lblSpeedwayQualifiesLabel = new Label();
			this.btnSpeedwayWinsAdd = new Button();
			this.btnSpeedwayWinsSubtract = new Button();
			this.btnSpeedwayWinsModify = new Button();
			this.lblSpeedwayWinsLabel = new Label();
			this.btnSpeedwayQualifiesSubtract = new Button();
			this.btnSpeedwayQualifiesAdd = new Button();
			this.btnSpeedwayQualifiesModify = new Button();
			this.lblSpeedwayWins = new Label();
			this.lblSpeedwayQualifies = new Label();
			this.tabRural = new TabPage();
			this.picRural = new PictureBox();
			this.lblRuralQualifiesLabel = new Label();
			this.btnRuralWinsAdd = new Button();
			this.btnRuralWinsSubtract = new Button();
			this.btnRuralWinsModify = new Button();
			this.lblRuralWinsLabel = new Label();
			this.btnRuralQualifiesSubtract = new Button();
			this.btnRuralQualifiesAdd = new Button();
			this.btnRuralQualifiesModify = new Button();
			this.lblRuralWins = new Label();
			this.lblRuralQualifies = new Label();
			this.tabUrban = new TabPage();
			this.picUrban = new PictureBox();
			this.lblUrbanQualifiesLabel = new Label();
			this.btnUrbanWinsAdd = new Button();
			this.btnUrbanWinsSubtract = new Button();
			this.btnUrbanWinsModify = new Button();
			this.lblUrbanWinsLabel = new Label();
			this.btnUrbanQualifiesSubtract = new Button();
			this.btnUrbanQualifiesAdd = new Button();
			this.btnUrbanQualifiesModify = new Button();
			this.lblUrbanWins = new Label();
			this.lblUrbanQualifies = new Label();
			this.tabTournament = new TabPage();
			this.picTournament = new PictureBox();
			this.btnTournamentSweptAdd = new Button();
			this.btnTournamentSweptSubtract = new Button();
			this.btnTournamentSweptModify = new Button();
			this.lblTournamentSweptLabel = new Label();
			this.lblTournamentSwept = new Label();
			this.lblTournamentQualifiesLabel = new Label();
			this.btnTournamentWinsAdd = new Button();
			this.btnTournamentWinsSubtract = new Button();
			this.btnTournamentWinsModify = new Button();
			this.lblTournamentWinsLabel = new Label();
			this.btnTournamentQualifiesSubtract = new Button();
			this.btnTournamentQualifiesAdd = new Button();
			this.btnTournamentQualifiesModify = new Button();
			this.lblTournamentWins = new Label();
			this.lblTournamentQualifies = new Label();
			this.tabTickets = new TabPage();
			this.cboPlace = new ComboBox();
			this.cboRacers = new ComboBox();
			this.lblTicketsNetProfitValue = new Label();
			this.lblTicketsWonValue = new Label();
			this.lblDepositValue = new Label();
			this.lblTicketsRacers = new Label();
			this.lblTicketsPlace = new Label();
			this.lblTicketsNetProfit = new Label();
			this.lblTicketsWon = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.lblTicketDeposit = new Label();
			this.lblTicketsTrack = new Label();
			this.cboTrack = new ComboBox();
			this.pictureBox1 = new PictureBox();
			this.RaceTrackMenu = new MenuStrip();
			this.mnuFile = new ToolStripMenuItem();
			this.mnuNew = new ToolStripMenuItem();
			this.mnuOpen = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.mnuSave = new ToolStripMenuItem();
			this.SaveAsMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.ExitMenuItem = new ToolStripMenuItem();
			this.OptionsMenuItem = new ToolStripMenuItem();
			this.AutoUpdateMenuItem = new ToolStripMenuItem();
			this.TopMostMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideMenuItem = new ToolStripMenuItem();
			this.tabRaces.SuspendLayout();
			this.tabWelcome.SuspendLayout();
			((ISupportInitialize)this.picWelcome).BeginInit();
			this.tabSpeedway.SuspendLayout();
			((ISupportInitialize)this.picSpeedway).BeginInit();
			this.tabRural.SuspendLayout();
			((ISupportInitialize)this.picRural).BeginInit();
			this.tabUrban.SuspendLayout();
			((ISupportInitialize)this.picUrban).BeginInit();
			this.tabTournament.SuspendLayout();
			((ISupportInitialize)this.picTournament).BeginInit();
			this.tabTickets.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.RaceTrackMenu.SuspendLayout();
			base.SuspendLayout();
			this.tabRaces.Alignment = TabAlignment.Bottom;
			this.tabRaces.Controls.Add(this.tabWelcome);
			this.tabRaces.Controls.Add(this.tabSpeedway);
			this.tabRaces.Controls.Add(this.tabRural);
			this.tabRaces.Controls.Add(this.tabUrban);
			this.tabRaces.Controls.Add(this.tabTournament);
			this.tabRaces.Controls.Add(this.tabTickets);
			this.tabRaces.Dock = DockStyle.Fill;
			this.tabRaces.Font = new Font("Segoe UI", 9f);
			this.tabRaces.HotTrack = true;
			this.tabRaces.Location = new Point(0, 24);
			this.tabRaces.Multiline = true;
			this.tabRaces.Name = "tabRaces";
			this.tabRaces.SelectedIndex = 0;
			this.tabRaces.Size = new Size(362, 208);
			this.tabRaces.TabIndex = 2;
			this.tabWelcome.Controls.Add(this.picWelcome);
			this.tabWelcome.Location = new Point(4, 4);
			this.tabWelcome.Name = "tabWelcome";
			this.tabWelcome.Size = new Size(354, 180);
			this.tabWelcome.TabIndex = 4;
			this.tabWelcome.Text = "Welcome";
			this.picWelcome.Image = (Image)componentResourceManager.GetObject("picWelcome.Image");
			this.picWelcome.Location = new Point(0, 14);
			this.picWelcome.Name = "picWelcome";
			this.picWelcome.Size = new Size(354, 153);
			this.picWelcome.SizeMode = PictureBoxSizeMode.AutoSize;
			this.picWelcome.TabIndex = 0;
			this.picWelcome.TabStop = false;
			this.picWelcome.WaitOnLoad = true;
			this.tabSpeedway.Controls.Add(this.picSpeedway);
			this.tabSpeedway.Controls.Add(this.lblSpeedwayQualifiesLabel);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayWinsAdd);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayWinsSubtract);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayWinsModify);
			this.tabSpeedway.Controls.Add(this.lblSpeedwayWinsLabel);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayQualifiesSubtract);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayQualifiesAdd);
			this.tabSpeedway.Controls.Add(this.btnSpeedwayQualifiesModify);
			this.tabSpeedway.Controls.Add(this.lblSpeedwayWins);
			this.tabSpeedway.Controls.Add(this.lblSpeedwayQualifies);
			this.tabSpeedway.Location = new Point(4, 4);
			this.tabSpeedway.Name = "tabSpeedway";
			this.tabSpeedway.Size = new Size(354, 180);
			this.tabSpeedway.TabIndex = 1;
			this.tabSpeedway.Text = "Speedway";
			this.picSpeedway.Anchor = AnchorStyles.None;
			this.picSpeedway.Image = (Image)componentResourceManager.GetObject("picSpeedway.Image");
			this.picSpeedway.Location = new Point(47, 11);
			this.picSpeedway.Name = "picSpeedway";
			this.picSpeedway.Size = new Size(260, 50);
			this.picSpeedway.TabIndex = 41;
			this.picSpeedway.TabStop = false;
			this.picSpeedway.WaitOnLoad = true;
			this.lblSpeedwayQualifiesLabel.Anchor = AnchorStyles.None;
			this.lblSpeedwayQualifiesLabel.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeedwayQualifiesLabel.Location = new Point(45, 140);
			this.lblSpeedwayQualifiesLabel.Name = "lblSpeedwayQualifiesLabel";
			this.lblSpeedwayQualifiesLabel.Size = new Size(88, 23);
			this.lblSpeedwayQualifiesLabel.TabIndex = 11;
			this.lblSpeedwayQualifiesLabel.Text = "Qualifies:";
			this.lblSpeedwayQualifiesLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnSpeedwayWinsAdd.Anchor = AnchorStyles.None;
			this.btnSpeedwayWinsAdd.Font = new Font("Impact", 12f);
			this.btnSpeedwayWinsAdd.Location = new Point(221, 108);
			this.btnSpeedwayWinsAdd.Name = "btnSpeedwayWinsAdd";
			this.btnSpeedwayWinsAdd.Size = new Size(24, 24);
			this.btnSpeedwayWinsAdd.TabIndex = 0;
			this.btnSpeedwayWinsAdd.Text = "+";
			this.btnSpeedwayWinsSubtract.Anchor = AnchorStyles.None;
			this.btnSpeedwayWinsSubtract.Font = new Font("Impact", 12f);
			this.btnSpeedwayWinsSubtract.Location = new Point(253, 108);
			this.btnSpeedwayWinsSubtract.Name = "btnSpeedwayWinsSubtract";
			this.btnSpeedwayWinsSubtract.Size = new Size(24, 24);
			this.btnSpeedwayWinsSubtract.TabIndex = 1;
			this.btnSpeedwayWinsSubtract.Text = "-";
			this.btnSpeedwayWinsModify.Anchor = AnchorStyles.None;
			this.btnSpeedwayWinsModify.Font = new Font("Impact", 12f);
			this.btnSpeedwayWinsModify.Location = new Point(285, 108);
			this.btnSpeedwayWinsModify.Name = "btnSpeedwayWinsModify";
			this.btnSpeedwayWinsModify.Size = new Size(24, 24);
			this.btnSpeedwayWinsModify.TabIndex = 2;
			this.btnSpeedwayWinsModify.Text = "...";
			this.lblSpeedwayWinsLabel.Anchor = AnchorStyles.None;
			this.lblSpeedwayWinsLabel.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeedwayWinsLabel.Location = new Point(45, 108);
			this.lblSpeedwayWinsLabel.Name = "lblSpeedwayWinsLabel";
			this.lblSpeedwayWinsLabel.Size = new Size(88, 23);
			this.lblSpeedwayWinsLabel.TabIndex = 10;
			this.lblSpeedwayWinsLabel.Text = "Wins:";
			this.lblSpeedwayWinsLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnSpeedwayQualifiesSubtract.Anchor = AnchorStyles.None;
			this.btnSpeedwayQualifiesSubtract.Font = new Font("Impact", 12f);
			this.btnSpeedwayQualifiesSubtract.Location = new Point(253, 140);
			this.btnSpeedwayQualifiesSubtract.Name = "btnSpeedwayQualifiesSubtract";
			this.btnSpeedwayQualifiesSubtract.Size = new Size(24, 24);
			this.btnSpeedwayQualifiesSubtract.TabIndex = 4;
			this.btnSpeedwayQualifiesSubtract.Text = "-";
			this.btnSpeedwayQualifiesAdd.Anchor = AnchorStyles.None;
			this.btnSpeedwayQualifiesAdd.Font = new Font("Impact", 12f);
			this.btnSpeedwayQualifiesAdd.Location = new Point(221, 140);
			this.btnSpeedwayQualifiesAdd.Name = "btnSpeedwayQualifiesAdd";
			this.btnSpeedwayQualifiesAdd.Size = new Size(24, 24);
			this.btnSpeedwayQualifiesAdd.TabIndex = 3;
			this.btnSpeedwayQualifiesAdd.Text = "+";
			this.btnSpeedwayQualifiesModify.Anchor = AnchorStyles.None;
			this.btnSpeedwayQualifiesModify.Font = new Font("Impact", 12f);
			this.btnSpeedwayQualifiesModify.Location = new Point(285, 140);
			this.btnSpeedwayQualifiesModify.Name = "btnSpeedwayQualifiesModify";
			this.btnSpeedwayQualifiesModify.Size = new Size(24, 24);
			this.btnSpeedwayQualifiesModify.TabIndex = 5;
			this.btnSpeedwayQualifiesModify.Text = "...";
			this.lblSpeedwayWins.Anchor = AnchorStyles.None;
			this.lblSpeedwayWins.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeedwayWins.Location = new Point(133, 108);
			this.lblSpeedwayWins.Name = "lblSpeedwayWins";
			this.lblSpeedwayWins.Size = new Size(56, 23);
			this.lblSpeedwayWins.TabIndex = 8;
			this.lblSpeedwayWins.Text = "0";
			this.lblSpeedwayWins.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpeedwayQualifies.Anchor = AnchorStyles.None;
			this.lblSpeedwayQualifies.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeedwayQualifies.Location = new Point(133, 140);
			this.lblSpeedwayQualifies.Name = "lblSpeedwayQualifies";
			this.lblSpeedwayQualifies.Size = new Size(56, 23);
			this.lblSpeedwayQualifies.TabIndex = 9;
			this.lblSpeedwayQualifies.Text = "0";
			this.lblSpeedwayQualifies.TextAlign = ContentAlignment.MiddleLeft;
			this.tabRural.Controls.Add(this.picRural);
			this.tabRural.Controls.Add(this.lblRuralQualifiesLabel);
			this.tabRural.Controls.Add(this.btnRuralWinsAdd);
			this.tabRural.Controls.Add(this.btnRuralWinsSubtract);
			this.tabRural.Controls.Add(this.btnRuralWinsModify);
			this.tabRural.Controls.Add(this.lblRuralWinsLabel);
			this.tabRural.Controls.Add(this.btnRuralQualifiesSubtract);
			this.tabRural.Controls.Add(this.btnRuralQualifiesAdd);
			this.tabRural.Controls.Add(this.btnRuralQualifiesModify);
			this.tabRural.Controls.Add(this.lblRuralWins);
			this.tabRural.Controls.Add(this.lblRuralQualifies);
			this.tabRural.Location = new Point(4, 4);
			this.tabRural.Name = "tabRural";
			this.tabRural.Size = new Size(354, 180);
			this.tabRural.TabIndex = 2;
			this.tabRural.Text = "Rural";
			this.picRural.Anchor = AnchorStyles.None;
			this.picRural.Image = (Image)componentResourceManager.GetObject("picRural.Image");
			this.picRural.Location = new Point(47, 11);
			this.picRural.Name = "picRural";
			this.picRural.Size = new Size(260, 50);
			this.picRural.TabIndex = 41;
			this.picRural.TabStop = false;
			this.picRural.WaitOnLoad = true;
			this.lblRuralQualifiesLabel.Anchor = AnchorStyles.None;
			this.lblRuralQualifiesLabel.Font = new Font("Impact", 12f);
			this.lblRuralQualifiesLabel.Location = new Point(45, 140);
			this.lblRuralQualifiesLabel.Name = "lblRuralQualifiesLabel";
			this.lblRuralQualifiesLabel.Size = new Size(88, 23);
			this.lblRuralQualifiesLabel.TabIndex = 21;
			this.lblRuralQualifiesLabel.Text = "Qualifies:";
			this.lblRuralQualifiesLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnRuralWinsAdd.Anchor = AnchorStyles.None;
			this.btnRuralWinsAdd.Font = new Font("Impact", 12f);
			this.btnRuralWinsAdd.Location = new Point(221, 108);
			this.btnRuralWinsAdd.Name = "btnRuralWinsAdd";
			this.btnRuralWinsAdd.Size = new Size(24, 24);
			this.btnRuralWinsAdd.TabIndex = 0;
			this.btnRuralWinsAdd.Text = "+";
			this.btnRuralWinsSubtract.Anchor = AnchorStyles.None;
			this.btnRuralWinsSubtract.Font = new Font("Impact", 12f);
			this.btnRuralWinsSubtract.Location = new Point(253, 108);
			this.btnRuralWinsSubtract.Name = "btnRuralWinsSubtract";
			this.btnRuralWinsSubtract.Size = new Size(24, 24);
			this.btnRuralWinsSubtract.TabIndex = 1;
			this.btnRuralWinsSubtract.Text = "-";
			this.btnRuralWinsModify.Anchor = AnchorStyles.None;
			this.btnRuralWinsModify.Font = new Font("Impact", 12f);
			this.btnRuralWinsModify.Location = new Point(285, 108);
			this.btnRuralWinsModify.Name = "btnRuralWinsModify";
			this.btnRuralWinsModify.Size = new Size(24, 24);
			this.btnRuralWinsModify.TabIndex = 2;
			this.btnRuralWinsModify.Text = "...";
			this.lblRuralWinsLabel.Anchor = AnchorStyles.None;
			this.lblRuralWinsLabel.Font = new Font("Impact", 12f);
			this.lblRuralWinsLabel.Location = new Point(45, 108);
			this.lblRuralWinsLabel.Name = "lblRuralWinsLabel";
			this.lblRuralWinsLabel.Size = new Size(88, 23);
			this.lblRuralWinsLabel.TabIndex = 20;
			this.lblRuralWinsLabel.Text = "Wins:";
			this.lblRuralWinsLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnRuralQualifiesSubtract.Anchor = AnchorStyles.None;
			this.btnRuralQualifiesSubtract.Font = new Font("Impact", 12f);
			this.btnRuralQualifiesSubtract.Location = new Point(253, 140);
			this.btnRuralQualifiesSubtract.Name = "btnRuralQualifiesSubtract";
			this.btnRuralQualifiesSubtract.Size = new Size(24, 24);
			this.btnRuralQualifiesSubtract.TabIndex = 4;
			this.btnRuralQualifiesSubtract.Text = "-";
			this.btnRuralQualifiesAdd.Anchor = AnchorStyles.None;
			this.btnRuralQualifiesAdd.Font = new Font("Impact", 12f);
			this.btnRuralQualifiesAdd.Location = new Point(221, 140);
			this.btnRuralQualifiesAdd.Name = "btnRuralQualifiesAdd";
			this.btnRuralQualifiesAdd.Size = new Size(24, 24);
			this.btnRuralQualifiesAdd.TabIndex = 3;
			this.btnRuralQualifiesAdd.Text = "+";
			this.btnRuralQualifiesModify.Anchor = AnchorStyles.None;
			this.btnRuralQualifiesModify.Font = new Font("Impact", 12f);
			this.btnRuralQualifiesModify.Location = new Point(285, 140);
			this.btnRuralQualifiesModify.Name = "btnRuralQualifiesModify";
			this.btnRuralQualifiesModify.Size = new Size(24, 24);
			this.btnRuralQualifiesModify.TabIndex = 5;
			this.btnRuralQualifiesModify.Text = "...";
			this.lblRuralWins.Anchor = AnchorStyles.None;
			this.lblRuralWins.Font = new Font("Impact", 12f);
			this.lblRuralWins.Location = new Point(133, 108);
			this.lblRuralWins.Name = "lblRuralWins";
			this.lblRuralWins.Size = new Size(56, 23);
			this.lblRuralWins.TabIndex = 18;
			this.lblRuralWins.Text = "0";
			this.lblRuralWins.TextAlign = ContentAlignment.MiddleLeft;
			this.lblRuralQualifies.Anchor = AnchorStyles.None;
			this.lblRuralQualifies.Font = new Font("Impact", 12f);
			this.lblRuralQualifies.Location = new Point(133, 140);
			this.lblRuralQualifies.Name = "lblRuralQualifies";
			this.lblRuralQualifies.Size = new Size(56, 23);
			this.lblRuralQualifies.TabIndex = 19;
			this.lblRuralQualifies.Text = "0";
			this.lblRuralQualifies.TextAlign = ContentAlignment.MiddleLeft;
			this.tabUrban.Controls.Add(this.picUrban);
			this.tabUrban.Controls.Add(this.lblUrbanQualifiesLabel);
			this.tabUrban.Controls.Add(this.btnUrbanWinsAdd);
			this.tabUrban.Controls.Add(this.btnUrbanWinsSubtract);
			this.tabUrban.Controls.Add(this.btnUrbanWinsModify);
			this.tabUrban.Controls.Add(this.lblUrbanWinsLabel);
			this.tabUrban.Controls.Add(this.btnUrbanQualifiesSubtract);
			this.tabUrban.Controls.Add(this.btnUrbanQualifiesAdd);
			this.tabUrban.Controls.Add(this.btnUrbanQualifiesModify);
			this.tabUrban.Controls.Add(this.lblUrbanWins);
			this.tabUrban.Controls.Add(this.lblUrbanQualifies);
			this.tabUrban.Location = new Point(4, 4);
			this.tabUrban.Name = "tabUrban";
			this.tabUrban.Size = new Size(354, 180);
			this.tabUrban.TabIndex = 0;
			this.tabUrban.Text = "Urban";
			this.picUrban.Anchor = AnchorStyles.None;
			this.picUrban.Image = (Image)componentResourceManager.GetObject("picUrban.Image");
			this.picUrban.Location = new Point(47, 11);
			this.picUrban.Name = "picUrban";
			this.picUrban.Size = new Size(260, 50);
			this.picUrban.TabIndex = 41;
			this.picUrban.TabStop = false;
			this.picUrban.WaitOnLoad = true;
			this.lblUrbanQualifiesLabel.Anchor = AnchorStyles.None;
			this.lblUrbanQualifiesLabel.Font = new Font("Impact", 12f);
			this.lblUrbanQualifiesLabel.Location = new Point(45, 140);
			this.lblUrbanQualifiesLabel.Name = "lblUrbanQualifiesLabel";
			this.lblUrbanQualifiesLabel.Size = new Size(88, 23);
			this.lblUrbanQualifiesLabel.TabIndex = 2;
			this.lblUrbanQualifiesLabel.Text = "Qualifies:";
			this.lblUrbanQualifiesLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnUrbanWinsAdd.Anchor = AnchorStyles.None;
			this.btnUrbanWinsAdd.Font = new Font("Impact", 12f);
			this.btnUrbanWinsAdd.Location = new Point(221, 108);
			this.btnUrbanWinsAdd.Name = "btnUrbanWinsAdd";
			this.btnUrbanWinsAdd.Size = new Size(24, 24);
			this.btnUrbanWinsAdd.TabIndex = 0;
			this.btnUrbanWinsAdd.Text = "+";
			this.btnUrbanWinsSubtract.Anchor = AnchorStyles.None;
			this.btnUrbanWinsSubtract.Font = new Font("Impact", 12f);
			this.btnUrbanWinsSubtract.Location = new Point(253, 108);
			this.btnUrbanWinsSubtract.Name = "btnUrbanWinsSubtract";
			this.btnUrbanWinsSubtract.Size = new Size(24, 24);
			this.btnUrbanWinsSubtract.TabIndex = 1;
			this.btnUrbanWinsSubtract.Text = "-";
			this.btnUrbanWinsModify.Anchor = AnchorStyles.None;
			this.btnUrbanWinsModify.Font = new Font("Impact", 12f);
			this.btnUrbanWinsModify.Location = new Point(285, 108);
			this.btnUrbanWinsModify.Name = "btnUrbanWinsModify";
			this.btnUrbanWinsModify.Size = new Size(24, 24);
			this.btnUrbanWinsModify.TabIndex = 2;
			this.btnUrbanWinsModify.Text = "...";
			this.lblUrbanWinsLabel.Anchor = AnchorStyles.None;
			this.lblUrbanWinsLabel.Font = new Font("Impact", 12f);
			this.lblUrbanWinsLabel.Location = new Point(45, 108);
			this.lblUrbanWinsLabel.Name = "lblUrbanWinsLabel";
			this.lblUrbanWinsLabel.Size = new Size(88, 23);
			this.lblUrbanWinsLabel.TabIndex = 2;
			this.lblUrbanWinsLabel.Text = "Wins:";
			this.lblUrbanWinsLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnUrbanQualifiesSubtract.Anchor = AnchorStyles.None;
			this.btnUrbanQualifiesSubtract.Font = new Font("Impact", 12f);
			this.btnUrbanQualifiesSubtract.Location = new Point(253, 140);
			this.btnUrbanQualifiesSubtract.Name = "btnUrbanQualifiesSubtract";
			this.btnUrbanQualifiesSubtract.Size = new Size(24, 24);
			this.btnUrbanQualifiesSubtract.TabIndex = 4;
			this.btnUrbanQualifiesSubtract.Text = "-";
			this.btnUrbanQualifiesAdd.Anchor = AnchorStyles.None;
			this.btnUrbanQualifiesAdd.Font = new Font("Impact", 12f);
			this.btnUrbanQualifiesAdd.Location = new Point(221, 140);
			this.btnUrbanQualifiesAdd.Name = "btnUrbanQualifiesAdd";
			this.btnUrbanQualifiesAdd.Size = new Size(24, 24);
			this.btnUrbanQualifiesAdd.TabIndex = 3;
			this.btnUrbanQualifiesAdd.Text = "+";
			this.btnUrbanQualifiesModify.Anchor = AnchorStyles.None;
			this.btnUrbanQualifiesModify.Font = new Font("Impact", 12f);
			this.btnUrbanQualifiesModify.Location = new Point(285, 140);
			this.btnUrbanQualifiesModify.Name = "btnUrbanQualifiesModify";
			this.btnUrbanQualifiesModify.Size = new Size(24, 24);
			this.btnUrbanQualifiesModify.TabIndex = 5;
			this.btnUrbanQualifiesModify.Text = "...";
			this.lblUrbanWins.Anchor = AnchorStyles.None;
			this.lblUrbanWins.Font = new Font("Impact", 12f);
			this.lblUrbanWins.Location = new Point(133, 108);
			this.lblUrbanWins.Name = "lblUrbanWins";
			this.lblUrbanWins.Size = new Size(56, 23);
			this.lblUrbanWins.TabIndex = 2;
			this.lblUrbanWins.Text = "0";
			this.lblUrbanWins.TextAlign = ContentAlignment.MiddleLeft;
			this.lblUrbanQualifies.Anchor = AnchorStyles.None;
			this.lblUrbanQualifies.Font = new Font("Impact", 12f);
			this.lblUrbanQualifies.Location = new Point(133, 140);
			this.lblUrbanQualifies.Name = "lblUrbanQualifies";
			this.lblUrbanQualifies.Size = new Size(56, 23);
			this.lblUrbanQualifies.TabIndex = 2;
			this.lblUrbanQualifies.Text = "0";
			this.lblUrbanQualifies.TextAlign = ContentAlignment.MiddleLeft;
			this.tabTournament.Controls.Add(this.picTournament);
			this.tabTournament.Controls.Add(this.btnTournamentSweptAdd);
			this.tabTournament.Controls.Add(this.btnTournamentSweptSubtract);
			this.tabTournament.Controls.Add(this.btnTournamentSweptModify);
			this.tabTournament.Controls.Add(this.lblTournamentSweptLabel);
			this.tabTournament.Controls.Add(this.lblTournamentSwept);
			this.tabTournament.Controls.Add(this.lblTournamentQualifiesLabel);
			this.tabTournament.Controls.Add(this.btnTournamentWinsAdd);
			this.tabTournament.Controls.Add(this.btnTournamentWinsSubtract);
			this.tabTournament.Controls.Add(this.btnTournamentWinsModify);
			this.tabTournament.Controls.Add(this.lblTournamentWinsLabel);
			this.tabTournament.Controls.Add(this.btnTournamentQualifiesSubtract);
			this.tabTournament.Controls.Add(this.btnTournamentQualifiesAdd);
			this.tabTournament.Controls.Add(this.btnTournamentQualifiesModify);
			this.tabTournament.Controls.Add(this.lblTournamentWins);
			this.tabTournament.Controls.Add(this.lblTournamentQualifies);
			this.tabTournament.Location = new Point(4, 4);
			this.tabTournament.Name = "tabTournament";
			this.tabTournament.Size = new Size(354, 180);
			this.tabTournament.TabIndex = 3;
			this.tabTournament.Text = "Tournament";
			this.picTournament.Anchor = AnchorStyles.None;
			this.picTournament.Image = (Image)componentResourceManager.GetObject("picTournament.Image");
			this.picTournament.Location = new Point(47, 11);
			this.picTournament.Name = "picTournament";
			this.picTournament.Size = new Size(260, 50);
			this.picTournament.TabIndex = 40;
			this.picTournament.TabStop = false;
			this.picTournament.WaitOnLoad = true;
			this.btnTournamentSweptAdd.Anchor = AnchorStyles.None;
			this.btnTournamentSweptAdd.Font = new Font("Impact", 12f);
			this.btnTournamentSweptAdd.Location = new Point(221, 76);
			this.btnTournamentSweptAdd.Name = "btnTournamentSweptAdd";
			this.btnTournamentSweptAdd.Size = new Size(24, 24);
			this.btnTournamentSweptAdd.TabIndex = 0;
			this.btnTournamentSweptAdd.Text = "+";
			this.btnTournamentSweptSubtract.Anchor = AnchorStyles.None;
			this.btnTournamentSweptSubtract.Font = new Font("Impact", 12f);
			this.btnTournamentSweptSubtract.Location = new Point(253, 76);
			this.btnTournamentSweptSubtract.Name = "btnTournamentSweptSubtract";
			this.btnTournamentSweptSubtract.Size = new Size(24, 24);
			this.btnTournamentSweptSubtract.TabIndex = 1;
			this.btnTournamentSweptSubtract.Text = "-";
			this.btnTournamentSweptModify.Anchor = AnchorStyles.None;
			this.btnTournamentSweptModify.Font = new Font("Impact", 12f);
			this.btnTournamentSweptModify.Location = new Point(285, 76);
			this.btnTournamentSweptModify.Name = "btnTournamentSweptModify";
			this.btnTournamentSweptModify.Size = new Size(24, 24);
			this.btnTournamentSweptModify.TabIndex = 2;
			this.btnTournamentSweptModify.Text = "...";
			this.lblTournamentSweptLabel.Anchor = AnchorStyles.None;
			this.lblTournamentSweptLabel.Font = new Font("Impact", 12f);
			this.lblTournamentSweptLabel.Location = new Point(45, 76);
			this.lblTournamentSweptLabel.Name = "lblTournamentSweptLabel";
			this.lblTournamentSweptLabel.Size = new Size(88, 23);
			this.lblTournamentSweptLabel.TabIndex = 39;
			this.lblTournamentSweptLabel.Text = "Swept:";
			this.lblTournamentSweptLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblTournamentSwept.Anchor = AnchorStyles.None;
			this.lblTournamentSwept.Font = new Font("Impact", 12f);
			this.lblTournamentSwept.Location = new Point(133, 76);
			this.lblTournamentSwept.Name = "lblTournamentSwept";
			this.lblTournamentSwept.Size = new Size(56, 23);
			this.lblTournamentSwept.TabIndex = 38;
			this.lblTournamentSwept.Text = "0";
			this.lblTournamentSwept.TextAlign = ContentAlignment.MiddleLeft;
			this.lblTournamentQualifiesLabel.Anchor = AnchorStyles.None;
			this.lblTournamentQualifiesLabel.Font = new Font("Impact", 12f);
			this.lblTournamentQualifiesLabel.Location = new Point(45, 140);
			this.lblTournamentQualifiesLabel.Name = "lblTournamentQualifiesLabel";
			this.lblTournamentQualifiesLabel.Size = new Size(88, 23);
			this.lblTournamentQualifiesLabel.TabIndex = 31;
			this.lblTournamentQualifiesLabel.Text = "Qualifies:";
			this.lblTournamentQualifiesLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnTournamentWinsAdd.Anchor = AnchorStyles.None;
			this.btnTournamentWinsAdd.Font = new Font("Impact", 12f);
			this.btnTournamentWinsAdd.Location = new Point(221, 108);
			this.btnTournamentWinsAdd.Name = "btnTournamentWinsAdd";
			this.btnTournamentWinsAdd.Size = new Size(24, 24);
			this.btnTournamentWinsAdd.TabIndex = 3;
			this.btnTournamentWinsAdd.Text = "+";
			this.btnTournamentWinsSubtract.Anchor = AnchorStyles.None;
			this.btnTournamentWinsSubtract.Font = new Font("Impact", 12f);
			this.btnTournamentWinsSubtract.Location = new Point(253, 108);
			this.btnTournamentWinsSubtract.Name = "btnTournamentWinsSubtract";
			this.btnTournamentWinsSubtract.Size = new Size(24, 24);
			this.btnTournamentWinsSubtract.TabIndex = 4;
			this.btnTournamentWinsSubtract.Text = "-";
			this.btnTournamentWinsModify.Anchor = AnchorStyles.None;
			this.btnTournamentWinsModify.Font = new Font("Impact", 12f);
			this.btnTournamentWinsModify.Location = new Point(285, 108);
			this.btnTournamentWinsModify.Name = "btnTournamentWinsModify";
			this.btnTournamentWinsModify.Size = new Size(24, 24);
			this.btnTournamentWinsModify.TabIndex = 5;
			this.btnTournamentWinsModify.Text = "...";
			this.lblTournamentWinsLabel.Anchor = AnchorStyles.None;
			this.lblTournamentWinsLabel.Font = new Font("Impact", 12f);
			this.lblTournamentWinsLabel.Location = new Point(45, 108);
			this.lblTournamentWinsLabel.Name = "lblTournamentWinsLabel";
			this.lblTournamentWinsLabel.Size = new Size(88, 23);
			this.lblTournamentWinsLabel.TabIndex = 30;
			this.lblTournamentWinsLabel.Text = "Wins:";
			this.lblTournamentWinsLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.btnTournamentQualifiesSubtract.Anchor = AnchorStyles.None;
			this.btnTournamentQualifiesSubtract.Font = new Font("Impact", 12f);
			this.btnTournamentQualifiesSubtract.Location = new Point(253, 140);
			this.btnTournamentQualifiesSubtract.Name = "btnTournamentQualifiesSubtract";
			this.btnTournamentQualifiesSubtract.Size = new Size(24, 24);
			this.btnTournamentQualifiesSubtract.TabIndex = 7;
			this.btnTournamentQualifiesSubtract.Text = "-";
			this.btnTournamentQualifiesAdd.Anchor = AnchorStyles.None;
			this.btnTournamentQualifiesAdd.Font = new Font("Impact", 12f);
			this.btnTournamentQualifiesAdd.Location = new Point(221, 140);
			this.btnTournamentQualifiesAdd.Name = "btnTournamentQualifiesAdd";
			this.btnTournamentQualifiesAdd.Size = new Size(24, 24);
			this.btnTournamentQualifiesAdd.TabIndex = 6;
			this.btnTournamentQualifiesAdd.Text = "+";
			this.btnTournamentQualifiesModify.Anchor = AnchorStyles.None;
			this.btnTournamentQualifiesModify.Font = new Font("Impact", 12f);
			this.btnTournamentQualifiesModify.Location = new Point(285, 140);
			this.btnTournamentQualifiesModify.Name = "btnTournamentQualifiesModify";
			this.btnTournamentQualifiesModify.Size = new Size(24, 24);
			this.btnTournamentQualifiesModify.TabIndex = 8;
			this.btnTournamentQualifiesModify.Text = "...";
			this.lblTournamentWins.Anchor = AnchorStyles.None;
			this.lblTournamentWins.Font = new Font("Impact", 12f);
			this.lblTournamentWins.Location = new Point(133, 108);
			this.lblTournamentWins.Name = "lblTournamentWins";
			this.lblTournamentWins.Size = new Size(56, 23);
			this.lblTournamentWins.TabIndex = 28;
			this.lblTournamentWins.Text = "0";
			this.lblTournamentWins.TextAlign = ContentAlignment.MiddleLeft;
			this.lblTournamentQualifies.Anchor = AnchorStyles.None;
			this.lblTournamentQualifies.Font = new Font("Impact", 12f);
			this.lblTournamentQualifies.Location = new Point(133, 140);
			this.lblTournamentQualifies.Name = "lblTournamentQualifies";
			this.lblTournamentQualifies.Size = new Size(56, 23);
			this.lblTournamentQualifies.TabIndex = 29;
			this.lblTournamentQualifies.Text = "0";
			this.lblTournamentQualifies.TextAlign = ContentAlignment.MiddleLeft;
			this.tabTickets.BackColor = SystemColors.Control;
			this.tabTickets.Controls.Add(this.cboPlace);
			this.tabTickets.Controls.Add(this.cboRacers);
			this.tabTickets.Controls.Add(this.lblTicketsNetProfitValue);
			this.tabTickets.Controls.Add(this.lblTicketsWonValue);
			this.tabTickets.Controls.Add(this.lblDepositValue);
			this.tabTickets.Controls.Add(this.lblTicketsRacers);
			this.tabTickets.Controls.Add(this.lblTicketsPlace);
			this.tabTickets.Controls.Add(this.lblTicketsNetProfit);
			this.tabTickets.Controls.Add(this.lblTicketsWon);
			this.tabTickets.Controls.Add(this.label3);
			this.tabTickets.Controls.Add(this.label2);
			this.tabTickets.Controls.Add(this.label1);
			this.tabTickets.Controls.Add(this.lblTicketDeposit);
			this.tabTickets.Controls.Add(this.lblTicketsTrack);
			this.tabTickets.Controls.Add(this.cboTrack);
			this.tabTickets.Controls.Add(this.pictureBox1);
			this.tabTickets.Location = new Point(4, 4);
			this.tabTickets.Name = "tabTickets";
			this.tabTickets.Padding = new Padding(3);
			this.tabTickets.Size = new Size(354, 180);
			this.tabTickets.TabIndex = 5;
			this.tabTickets.Text = "Tickets";
			this.cboPlace.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboPlace.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.cboPlace.FormattingEnabled = true;
			this.cboPlace.Location = new Point(240, 87);
			this.cboPlace.Name = "cboPlace";
			this.cboPlace.Size = new Size(44, 21);
			this.cboPlace.TabIndex = 2;
			this.cboPlace.SelectedIndexChanged += this.cboPlace_SelectedIndexChanged;
			this.cboRacers.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboRacers.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.cboRacers.FormattingEnabled = true;
			this.cboRacers.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4"
			});
			this.cboRacers.Location = new Point(190, 87);
			this.cboRacers.Name = "cboRacers";
			this.cboRacers.Size = new Size(44, 21);
			this.cboRacers.TabIndex = 1;
			this.cboRacers.SelectedIndexChanged += this.cboRacers_SelectedIndexChanged;
			this.lblTicketsNetProfitValue.AutoSize = true;
			this.lblTicketsNetProfitValue.Font = new Font("Segoe UI", 9f);
			this.lblTicketsNetProfitValue.Location = new Point(126, 156);
			this.lblTicketsNetProfitValue.Name = "lblTicketsNetProfitValue";
			this.lblTicketsNetProfitValue.Size = new Size(13, 15);
			this.lblTicketsNetProfitValue.TabIndex = 44;
			this.lblTicketsNetProfitValue.Text = "0";
			this.lblTicketsWonValue.AutoSize = true;
			this.lblTicketsWonValue.Font = new Font("Segoe UI", 9f);
			this.lblTicketsWonValue.Location = new Point(126, 136);
			this.lblTicketsWonValue.Name = "lblTicketsWonValue";
			this.lblTicketsWonValue.Size = new Size(13, 15);
			this.lblTicketsWonValue.TabIndex = 44;
			this.lblTicketsWonValue.Text = "0";
			this.lblDepositValue.AutoSize = true;
			this.lblDepositValue.Font = new Font("Segoe UI", 9f);
			this.lblDepositValue.Location = new Point(126, 116);
			this.lblDepositValue.Name = "lblDepositValue";
			this.lblDepositValue.Size = new Size(13, 15);
			this.lblDepositValue.TabIndex = 44;
			this.lblDepositValue.Text = "0";
			this.lblTicketsRacers.AutoSize = true;
			this.lblTicketsRacers.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketsRacers.Location = new Point(187, 69);
			this.lblTicketsRacers.Name = "lblTicketsRacers";
			this.lblTicketsRacers.Size = new Size(47, 15);
			this.lblTicketsRacers.TabIndex = 44;
			this.lblTicketsRacers.Text = "Racers:";
			this.lblTicketsPlace.AutoSize = true;
			this.lblTicketsPlace.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketsPlace.Location = new Point(237, 69);
			this.lblTicketsPlace.Name = "lblTicketsPlace";
			this.lblTicketsPlace.Size = new Size(39, 15);
			this.lblTicketsPlace.TabIndex = 44;
			this.lblTicketsPlace.Text = "Place:";
			this.lblTicketsNetProfit.AutoSize = true;
			this.lblTicketsNetProfit.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketsNetProfit.Location = new Point(58, 156);
			this.lblTicketsNetProfit.Name = "lblTicketsNetProfit";
			this.lblTicketsNetProfit.Size = new Size(66, 15);
			this.lblTicketsNetProfit.TabIndex = 44;
			this.lblTicketsNetProfit.Text = "Net Profit:";
			this.lblTicketsWon.AutoSize = true;
			this.lblTicketsWon.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketsWon.Location = new Point(45, 136);
			this.lblTicketsWon.Name = "lblTicketsWon";
			this.lblTicketsWon.Size = new Size(79, 15);
			this.lblTicketsWon.TabIndex = 44;
			this.lblTicketsWon.Text = "Tickets Won:";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI", 9f);
			this.label3.Location = new Point(172, 156);
			this.label3.Name = "label3";
			this.label3.Size = new Size(126, 15);
			this.label3.TabIndex = 44;
			this.label3.Text = "(Prize without deposit)";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI", 9f);
			this.label2.Location = new Point(172, 136);
			this.label2.Name = "label2";
			this.label2.Size = new Size(155, 15);
			this.label2.TabIndex = 44;
			this.label2.Text = "(Prize for the selected place)";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI", 9f);
			this.label1.Location = new Point(172, 116);
			this.label1.Name = "label1";
			this.label1.Size = new Size(149, 15);
			this.label1.TabIndex = 44;
			this.label1.Text = "(Number of tickets to race)";
			this.lblTicketDeposit.AutoSize = true;
			this.lblTicketDeposit.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketDeposit.Location = new Point(71, 116);
			this.lblTicketDeposit.Name = "lblTicketDeposit";
			this.lblTicketDeposit.Size = new Size(53, 15);
			this.lblTicketDeposit.TabIndex = 44;
			this.lblTicketDeposit.Text = "Deposit:";
			this.lblTicketsTrack.AutoSize = true;
			this.lblTicketsTrack.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTicketsTrack.Location = new Point(60, 69);
			this.lblTicketsTrack.Name = "lblTicketsTrack";
			this.lblTicketsTrack.Size = new Size(41, 15);
			this.lblTicketsTrack.TabIndex = 44;
			this.lblTicketsTrack.Text = "Track:";
			this.cboTrack.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboTrack.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.cboTrack.FormattingEnabled = true;
			this.cboTrack.Items.AddRange(new object[]
			{
				"Screwball Stadium",
				"Corkscrew Coliseum",
				"Rustic Raceway",
				"Airborne Acres",
				"City Circuit",
				"Blizzard Boulevard"
			});
			this.cboTrack.Location = new Point(63, 87);
			this.cboTrack.Name = "cboTrack";
			this.cboTrack.Size = new Size(121, 21);
			this.cboTrack.TabIndex = 0;
			this.cboTrack.SelectedIndexChanged += this.cboTrack_SelectedIndexChanged;
			this.pictureBox1.Anchor = AnchorStyles.None;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(47, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(260, 50);
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			this.RaceTrackMenu.Items.AddRange(new ToolStripItem[]
			{
				this.mnuFile,
				this.OptionsMenuItem,
				this.HelpMenuItem
			});
			this.RaceTrackMenu.Location = new Point(0, 0);
			this.RaceTrackMenu.Name = "RaceTrackMenu";
			this.RaceTrackMenu.Size = new Size(362, 24);
			this.RaceTrackMenu.TabIndex = 3;
			this.RaceTrackMenu.Text = "menuStrip1";
			this.mnuFile.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mnuNew,
				this.mnuOpen,
				this.toolStripSeparator1,
				this.mnuSave,
				this.SaveAsMenuItem,
				this.toolStripSeparator2,
				this.ExitMenuItem
			});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new Size(37, 20);
			this.mnuFile.Text = "&File";
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.ShortcutKeys = (Keys)131150;
			this.mnuNew.Size = new Size(192, 22);
			this.mnuNew.Text = "&New";
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.ShortcutKeys = (Keys)131151;
			this.mnuOpen.Size = new Size(192, 22);
			this.mnuOpen.Text = "&Open";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(189, 6);
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.ShortcutKeys = (Keys)131155;
			this.mnuSave.Size = new Size(192, 22);
			this.mnuSave.Text = "&Save";
			this.SaveAsMenuItem.Name = "SaveAsMenuItem";
			this.SaveAsMenuItem.ShortcutKeys = (Keys)196691;
			this.SaveAsMenuItem.Size = new Size(192, 22);
			this.SaveAsMenuItem.Text = "Save &As..";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(189, 6);
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.ShortcutKeys = (Keys)131159;
			this.ExitMenuItem.Size = new Size(192, 22);
			this.ExitMenuItem.Text = "&Close";
			this.ExitMenuItem.Click += this.ExitMenuItem_Click;
			this.OptionsMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.AutoUpdateMenuItem,
				this.TopMostMenuItem
			});
			this.OptionsMenuItem.Name = "OptionsMenuItem";
			this.OptionsMenuItem.Size = new Size(61, 20);
			this.OptionsMenuItem.Text = "&Options";
			this.AutoUpdateMenuItem.Checked = true;
			this.AutoUpdateMenuItem.CheckState = CheckState.Checked;
			this.AutoUpdateMenuItem.Name = "AutoUpdateMenuItem";
			this.AutoUpdateMenuItem.Size = new Size(190, 22);
			this.AutoUpdateMenuItem.Text = "&Auto Update Qualifies";
			this.AutoUpdateMenuItem.Click += this.AutoUpdateMenuItem_Click;
			this.TopMostMenuItem.Name = "TopMostMenuItem";
			this.TopMostMenuItem.Size = new Size(190, 22);
			this.TopMostMenuItem.Text = "&Top Most";
			this.TopMostMenuItem.Click += this.TopMostMenuItem_Click;
			this.HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.GuideMenuItem
			});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			this.GuideMenuItem.Name = "GuideMenuItem";
			this.GuideMenuItem.ShortcutKeys = Keys.F1;
			this.GuideMenuItem.Size = new Size(124, 22);
			this.GuideMenuItem.Text = "&Guide";
			this.GuideMenuItem.Click += this.GuideMenuItem_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(362, 232);
			base.Controls.Add(this.tabRaces);
			base.Controls.Add(this.RaceTrackMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.RaceTrackMenu;
			base.MaximizeBox = false;
			base.Name = "RaceTrack";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Race Track : New File";
			this.tabRaces.ResumeLayout(false);
			this.tabWelcome.ResumeLayout(false);
			this.tabWelcome.PerformLayout();
			((ISupportInitialize)this.picWelcome).EndInit();
			this.tabSpeedway.ResumeLayout(false);
			((ISupportInitialize)this.picSpeedway).EndInit();
			this.tabRural.ResumeLayout(false);
			((ISupportInitialize)this.picRural).EndInit();
			this.tabUrban.ResumeLayout(false);
			((ISupportInitialize)this.picUrban).EndInit();
			this.tabTournament.ResumeLayout(false);
			((ISupportInitialize)this.picTournament).EndInit();
			this.tabTickets.ResumeLayout(false);
			this.tabTickets.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.RaceTrackMenu.ResumeLayout(false);
			this.RaceTrackMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000291CC File Offset: 0x000273CC
		public RaceTrack()
		{
			this.InitializeComponent_1();
			this.class114_0 = Class110.Instance.RaceTrackFileIndex;
			this.mnuNew.Click += base.method_0;
			this.mnuOpen.Click += base.method_1;
			this.mnuSave.Click += base.method_2;
			this.SaveAsMenuItem.Click += base.method_3;
			this.class107_0 = new Class107();
			Control control = this.btnRuralQualifiesAdd;
			EventHandler value = new EventHandler(this.method_27);
			control.Click += value;
			Control control2 = this.btnRuralQualifiesSubtract;
			EventHandler value2 = new EventHandler(this.method_28);
			control2.Click += value2;
			Control control3 = this.btnRuralQualifiesModify;
			EventHandler value3 = new EventHandler(this.method_29);
			control3.Click += value3;
			Control control4 = this.btnRuralWinsAdd;
			EventHandler value4 = new EventHandler(this.method_30);
			control4.Click += value4;
			Control control5 = this.btnRuralWinsSubtract;
			EventHandler value5 = new EventHandler(this.method_31);
			control5.Click += value5;
			Control control6 = this.btnRuralWinsModify;
			EventHandler value6 = new EventHandler(this.method_32);
			control6.Click += value6;
			Control control7 = this.btnUrbanQualifiesAdd;
			EventHandler value7 = new EventHandler(this.method_33);
			control7.Click += value7;
			Control control8 = this.btnUrbanQualifiesSubtract;
			EventHandler value8 = new EventHandler(this.method_34);
			control8.Click += value8;
			Control control9 = this.btnUrbanQualifiesModify;
			EventHandler value9 = new EventHandler(this.method_35);
			control9.Click += value9;
			Control control10 = this.btnUrbanWinsAdd;
			EventHandler value10 = new EventHandler(this.method_36);
			control10.Click += value10;
			Control control11 = this.btnUrbanWinsSubtract;
			EventHandler value11 = new EventHandler(this.method_37);
			control11.Click += value11;
			Control control12 = this.btnUrbanWinsModify;
			EventHandler value12 = new EventHandler(this.method_38);
			control12.Click += value12;
			Control control13 = this.btnSpeedwayQualifiesAdd;
			EventHandler value13 = new EventHandler(this.method_39);
			control13.Click += value13;
			Control control14 = this.btnSpeedwayQualifiesSubtract;
			EventHandler value14 = new EventHandler(this.method_40);
			control14.Click += value14;
			Control control15 = this.btnSpeedwayQualifiesModify;
			EventHandler value15 = new EventHandler(this.method_41);
			control15.Click += value15;
			Control control16 = this.btnSpeedwayWinsAdd;
			EventHandler value16 = new EventHandler(this.method_42);
			control16.Click += value16;
			Control control17 = this.btnSpeedwayWinsSubtract;
			EventHandler value17 = new EventHandler(this.method_43);
			control17.Click += value17;
			Control control18 = this.btnSpeedwayWinsModify;
			EventHandler value18 = new EventHandler(this.method_44);
			control18.Click += value18;
			Control control19 = this.btnTournamentQualifiesAdd;
			EventHandler value19 = new EventHandler(this.method_45);
			control19.Click += value19;
			Control control20 = this.btnTournamentQualifiesSubtract;
			EventHandler value20 = new EventHandler(this.method_46);
			control20.Click += value20;
			Control control21 = this.btnTournamentQualifiesModify;
			EventHandler value21 = new EventHandler(this.method_47);
			control21.Click += value21;
			Control control22 = this.btnTournamentWinsAdd;
			EventHandler value22 = new EventHandler(this.method_48);
			control22.Click += value22;
			Control control23 = this.btnTournamentWinsSubtract;
			EventHandler value23 = new EventHandler(this.method_49);
			control23.Click += value23;
			Control control24 = this.btnTournamentWinsModify;
			EventHandler value24 = new EventHandler(this.method_50);
			control24.Click += value24;
			Control control25 = this.btnTournamentSweptAdd;
			EventHandler value25 = new EventHandler(this.method_51);
			control25.Click += value25;
			Control control26 = this.btnTournamentSweptSubtract;
			EventHandler value26 = new EventHandler(this.method_52);
			control26.Click += value26;
			Control control27 = this.btnTournamentSweptModify;
			EventHandler value27 = new EventHandler(this.method_53);
			control27.Click += value27;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0002957C File Offset: 0x0002777C
		private void method_10()
		{
			this.method_11();
			this.method_12();
			this.method_13();
			this.method_14();
			this.method_20();
			this.method_21();
			this.method_18();
			this.method_19();
			this.method_16();
			this.method_17();
			this.method_15();
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00005194 File Offset: 0x00003394
		private void method_11()
		{
			this.TopMostMenuItem.Checked = this.class107_0.TopMost;
			base.TopMost = this.class107_0.TopMost;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000051BD File Offset: 0x000033BD
		private void method_12()
		{
			this.AutoUpdateMenuItem.Checked = this.class107_0.AutoUpdate;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000295CC File Offset: 0x000277CC
		private void method_13()
		{
			this.lblRuralQualifies.Text = this.class107_0.RuralTrackQualifies.ToString();
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000295F8 File Offset: 0x000277F8
		private void method_14()
		{
			this.lblRuralWins.Text = this.class107_0.RuralTrackWins.ToString();
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00029624 File Offset: 0x00027824
		private void method_15()
		{
			this.lblTournamentSwept.Text = this.class107_0.TournamentSwept.ToString();
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00029650 File Offset: 0x00027850
		private void method_16()
		{
			this.lblTournamentQualifies.Text = this.class107_0.TournamentQualifies.ToString();
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0002967C File Offset: 0x0002787C
		private void method_17()
		{
			this.lblTournamentWins.Text = this.class107_0.TournamentWins.ToString();
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000296A8 File Offset: 0x000278A8
		private void method_18()
		{
			this.lblUrbanQualifies.Text = this.class107_0.UrbanTrackQualifies.ToString();
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000296D4 File Offset: 0x000278D4
		private void method_19()
		{
			this.lblUrbanWins.Text = this.class107_0.UrbanTrackWins.ToString();
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00029700 File Offset: 0x00027900
		private void method_20()
		{
			this.lblSpeedwayQualifies.Text = this.class107_0.SpeedwayTrackQualifies.ToString();
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0002972C File Offset: 0x0002792C
		private void method_21()
		{
			this.lblSpeedwayWins.Text = this.class107_0.SpeedwayTrackWins.ToString();
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00029758 File Offset: 0x00027958
		private ushort method_22(ushort value)
		{
			using (IntegerInputForm integerInputForm = new IntegerInputForm())
			{
				integerInputForm.Text = "The ToonTown Spoofer : Race Track Modify Value";
				integerInputForm.LabelMessage = "Please enter a new value:";
				integerInputForm.MaximumValue = 65535;
				integerInputForm.MinimumValue = 0;
				integerInputForm.Value = (int)value;
				if (integerInputForm.ShowDialog() == DialogResult.OK)
				{
					base.FileModified = true;
					return (ushort)integerInputForm.Value;
				}
			}
			return value;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x000297D4 File Offset: 0x000279D4
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (Class524.smethod_0(fileName, null))
			{
				if (modified)
				{
					this.Text = "Race Track : New File*";
					return;
				}
				this.Text = "Race Track : New File";
				return;
			}
			else
			{
				if (modified)
				{
					this.Text = string.Format("Race Track : {0}*", fileName.string_0);
					return;
				}
				this.Text = "Race Track : " + fileName.string_0;
				return;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00029838 File Offset: 0x00027A38
		protected override bool vmethod_6(out Class524 fileName)
		{
			Class524 @class;
			bool result;
			if (result = Class460.smethod_5(out @class))
			{
				fileName = @class;
			}
			else
			{
				fileName = null;
			}
			return result;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0002985C File Offset: 0x00027A5C
		protected override bool vmethod_5(Class524 fileName)
		{
			bool result;
			try
			{
				this.class107_0 = new Class107(fileName.string_1);
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format("Race Track filename: '{0}'.", fileName.string_1)
				});
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000051D5 File Offset: 0x000033D5
		protected override void vmethod_4(Class524 fileName)
		{
			this.method_10();
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000051DD File Offset: 0x000033DD
		protected override void vmethod_0()
		{
			this.class107_0 = new Class107();
			this.method_10();
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000298C4 File Offset: 0x00027AC4
		protected override bool vmethod_3(out Class524 fileName)
		{
			bool result;
			using (StringInputForm stringInputForm = new StringInputForm())
			{
				stringInputForm.LabelMessage = "Please enter a reference name for this Race Track file.";
				stringInputForm.Text = "The ToonTown Spoofer : Race Track File Name";
				if (stringInputForm.ShowDialog() == DialogResult.OK)
				{
					fileName = new Class524(stringInputForm.Value, Class266.smethod_2(Class291.RaceTrackSettingsDirectory, ".race"));
					result = true;
				}
				else
				{
					fileName = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000051F0 File Offset: 0x000033F0
		protected override void vmethod_1(Class524 fileName)
		{
			this.method_23(fileName);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00029938 File Offset: 0x00027B38
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class107_0.method_1(fileName.string_1);
				this.method_23(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format("Race Track filename: '{0}'.", fileName.string_1)
				});
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000051F9 File Offset: 0x000033F9
		private void method_23(Class524 fileName)
		{
			if (!this.class114_0.Files.Contains(fileName))
			{
				this.class114_0.Files.Add(fileName);
				Class110.smethod_1();
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000050D4 File Offset: 0x000032D4
		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00005225 File Offset: 0x00003425
		private void AutoUpdateMenuItem_Click(object sender, EventArgs e)
		{
			this.AutoUpdateMenuItem.Checked = !this.AutoUpdateMenuItem.Checked;
			this.class107_0.AutoUpdate = this.AutoUpdateMenuItem.Checked;
			base.FileModified = true;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000299A4 File Offset: 0x00027BA4
		private void TopMostMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMostMenuItem.Checked = !this.TopMostMenuItem.Checked;
			this.class107_0.TopMost = this.TopMostMenuItem.Checked;
			base.TopMost = this.class107_0.TopMost;
			base.FileModified = true;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0000525D File Offset: 0x0000345D
		private void cboTrack_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00005265 File Offset: 0x00003465
		private void cboRacers_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0000525D File Offset: 0x0000345D
		private void cboPlace_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000299F8 File Offset: 0x00027BF8
		private void method_24()
		{
			this.cboPlace.Items.Clear();
			switch (this.cboRacers.SelectedIndex)
			{
			case 0:
				goto IL_76;
			case 1:
				goto IL_60;
			case 2:
				break;
			case 3:
				this.cboPlace.Items.Insert(0, "4th");
				break;
			default:
				goto IL_8C;
			}
			this.cboPlace.Items.Insert(0, "3rd");
			IL_60:
			this.cboPlace.Items.Insert(0, "2nd");
			IL_76:
			this.cboPlace.Items.Insert(0, "1st");
			IL_8C:
			this.cboPlace.SelectedIndex = 0;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00029AA0 File Offset: 0x00027CA0
		private void method_25()
		{
			if (this.cboRacers.SelectedIndex != -1 && this.cboPlace.SelectedIndex != -1)
			{
				if (this.cboTrack.SelectedIndex != -1)
				{
					switch (this.cboTrack.SelectedIndex)
					{
					case 0:
						this.method_26(RaceTrack.int_0);
						return;
					case 1:
						this.method_26(RaceTrack.int_1);
						return;
					case 2:
						this.method_26(RaceTrack.int_2);
						return;
					case 3:
						this.method_26(RaceTrack.int_3);
						return;
					case 4:
						this.method_26(RaceTrack.int_4);
						return;
					case 5:
						this.method_26(RaceTrack.int_5);
						return;
					default:
						return;
					}
				}
			}
			this.lblDepositValue.Text = "0";
			this.lblTicketsNetProfitValue.Text = "0";
			this.lblTicketsWonValue.Text = "0";
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00029B84 File Offset: 0x00027D84
		private void method_26(int deposit)
		{
			this.lblDepositValue.Text = deposit.ToString();
			int num = 0;
			switch (this.cboRacers.SelectedIndex - this.cboPlace.SelectedIndex)
			{
			case 0:
				num = deposit + (int)Math.Floor((double)((float)deposit * 0.15f));
				break;
			case 1:
				num = deposit + (int)Math.Floor((double)((float)deposit * 0.5f));
				break;
			case 2:
				num = deposit + (int)Math.Floor((double)((float)deposit * 1f));
				break;
			case 3:
				num = deposit + (int)Math.Floor((double)((float)deposit * 3f));
				break;
			}
			this.lblTicketsWonValue.Text = num.ToString();
			this.lblTicketsNetProfitValue.Text = (num - deposit).ToString();
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0000526D File Offset: 0x0000346D
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_10);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00005276 File Offset: 0x00003476
		[CompilerGenerated]
		private void method_27(object sender, EventArgs e)
		{
			if (this.class107_0.RuralTrackQualifies < 65535)
			{
				Class107 @class = this.class107_0;
				@class.RuralTrackQualifies += 1;
				this.method_13();
				base.FileModified = true;
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x000052AB File Offset: 0x000034AB
		[CompilerGenerated]
		private void method_28(object sender, EventArgs e)
		{
			if (this.class107_0.RuralTrackQualifies > 0)
			{
				Class107 @class = this.class107_0;
				@class.RuralTrackQualifies -= 1;
				this.method_13();
				base.FileModified = true;
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x000052DC File Offset: 0x000034DC
		[CompilerGenerated]
		private void method_29(object sender, EventArgs e)
		{
			this.class107_0.RuralTrackQualifies = this.method_22(this.class107_0.RuralTrackQualifies);
			this.method_13();
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00029C4C File Offset: 0x00027E4C
		[CompilerGenerated]
		private void method_30(object sender, EventArgs e)
		{
			if (this.class107_0.RuralTrackWins < 65535)
			{
				Class107 @class = this.class107_0;
				@class.RuralTrackWins += 1;
				this.method_14();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.RuralTrackQualifies += 1;
					this.method_13();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00029CB4 File Offset: 0x00027EB4
		[CompilerGenerated]
		private void method_31(object sender, EventArgs e)
		{
			if (this.class107_0.RuralTrackWins > 0)
			{
				Class107 @class = this.class107_0;
				@class.RuralTrackWins -= 1;
				this.method_14();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.RuralTrackQualifies -= 1;
					this.method_13();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00005300 File Offset: 0x00003500
		[CompilerGenerated]
		private void method_32(object sender, EventArgs e)
		{
			this.class107_0.RuralTrackWins = this.method_22(this.class107_0.RuralTrackWins);
			this.method_14();
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00005324 File Offset: 0x00003524
		[CompilerGenerated]
		private void method_33(object sender, EventArgs e)
		{
			if (this.class107_0.UrbanTrackQualifies < 65535)
			{
				Class107 @class = this.class107_0;
				@class.UrbanTrackQualifies += 1;
				this.method_18();
				base.FileModified = true;
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00005359 File Offset: 0x00003559
		[CompilerGenerated]
		private void method_34(object sender, EventArgs e)
		{
			if (this.class107_0.UrbanTrackQualifies > 0)
			{
				Class107 @class = this.class107_0;
				@class.UrbanTrackQualifies -= 1;
				this.method_18();
				base.FileModified = true;
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0000538A File Offset: 0x0000358A
		[CompilerGenerated]
		private void method_35(object sender, EventArgs e)
		{
			this.class107_0.UrbanTrackQualifies = this.method_22(this.class107_0.UrbanTrackQualifies);
			this.method_18();
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00029D18 File Offset: 0x00027F18
		[CompilerGenerated]
		private void method_36(object sender, EventArgs e)
		{
			if (this.class107_0.UrbanTrackWins < 65535)
			{
				Class107 @class = this.class107_0;
				@class.UrbanTrackWins += 1;
				this.method_19();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.UrbanTrackQualifies += 1;
					this.method_18();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00029D80 File Offset: 0x00027F80
		[CompilerGenerated]
		private void method_37(object sender, EventArgs e)
		{
			if (this.class107_0.UrbanTrackWins > 0)
			{
				Class107 @class = this.class107_0;
				@class.UrbanTrackWins -= 1;
				this.method_19();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.UrbanTrackQualifies -= 1;
					this.method_18();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000053AE File Offset: 0x000035AE
		[CompilerGenerated]
		private void method_38(object sender, EventArgs e)
		{
			this.class107_0.UrbanTrackWins = this.method_22(this.class107_0.UrbanTrackWins);
			this.method_19();
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000053D2 File Offset: 0x000035D2
		[CompilerGenerated]
		private void method_39(object sender, EventArgs e)
		{
			if (this.class107_0.SpeedwayTrackQualifies < 65535)
			{
				Class107 @class = this.class107_0;
				@class.SpeedwayTrackQualifies += 1;
				this.method_20();
				base.FileModified = true;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00005407 File Offset: 0x00003607
		[CompilerGenerated]
		private void method_40(object sender, EventArgs e)
		{
			if (this.class107_0.SpeedwayTrackQualifies > 0)
			{
				Class107 @class = this.class107_0;
				@class.SpeedwayTrackQualifies -= 1;
				this.method_20();
				base.FileModified = true;
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00005438 File Offset: 0x00003638
		[CompilerGenerated]
		private void method_41(object sender, EventArgs e)
		{
			this.class107_0.SpeedwayTrackQualifies = this.method_22(this.class107_0.SpeedwayTrackQualifies);
			this.method_20();
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00029DE4 File Offset: 0x00027FE4
		[CompilerGenerated]
		private void method_42(object sender, EventArgs e)
		{
			if (this.class107_0.SpeedwayTrackWins < 65535)
			{
				Class107 @class = this.class107_0;
				@class.SpeedwayTrackWins += 1;
				this.method_21();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.SpeedwayTrackQualifies += 1;
					this.method_20();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00029E4C File Offset: 0x0002804C
		[CompilerGenerated]
		private void method_43(object sender, EventArgs e)
		{
			if (this.class107_0.SpeedwayTrackWins > 0)
			{
				Class107 @class = this.class107_0;
				@class.SpeedwayTrackWins -= 1;
				this.method_21();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.SpeedwayTrackQualifies -= 1;
					this.method_20();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000545C File Offset: 0x0000365C
		[CompilerGenerated]
		private void method_44(object sender, EventArgs e)
		{
			this.class107_0.SpeedwayTrackWins = this.method_22(this.class107_0.SpeedwayTrackWins);
			this.method_21();
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00005480 File Offset: 0x00003680
		[CompilerGenerated]
		private void method_45(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentQualifies < 65535)
			{
				Class107 @class = this.class107_0;
				@class.TournamentQualifies += 1;
				this.method_16();
				base.FileModified = true;
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000054B5 File Offset: 0x000036B5
		[CompilerGenerated]
		private void method_46(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentQualifies > 0)
			{
				Class107 @class = this.class107_0;
				@class.TournamentQualifies -= 1;
				this.method_16();
				base.FileModified = true;
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000054E6 File Offset: 0x000036E6
		[CompilerGenerated]
		private void method_47(object sender, EventArgs e)
		{
			this.class107_0.TournamentQualifies = this.method_22(this.class107_0.TournamentQualifies);
			this.method_16();
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00029EB0 File Offset: 0x000280B0
		[CompilerGenerated]
		private void method_48(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentWins < 65535)
			{
				Class107 @class = this.class107_0;
				@class.TournamentWins += 1;
				this.method_17();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.TournamentQualifies += 1;
					this.method_16();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00029F18 File Offset: 0x00028118
		[CompilerGenerated]
		private void method_49(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentWins > 0)
			{
				Class107 @class = this.class107_0;
				@class.TournamentWins -= 1;
				this.method_17();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.TournamentQualifies -= 1;
					this.method_16();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0000550A File Offset: 0x0000370A
		[CompilerGenerated]
		private void method_50(object sender, EventArgs e)
		{
			this.class107_0.TournamentWins = this.method_22(this.class107_0.TournamentWins);
			this.method_17();
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00029F7C File Offset: 0x0002817C
		[CompilerGenerated]
		private void method_51(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentSwept < 65535)
			{
				Class107 @class = this.class107_0;
				@class.TournamentSwept += 1;
				this.method_15();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.TournamentWins += 1;
					this.method_17();
					Class107 class3 = this.class107_0;
					class3.TournamentQualifies += 1;
					this.method_16();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0002A000 File Offset: 0x00028200
		[CompilerGenerated]
		private void method_52(object sender, EventArgs e)
		{
			if (this.class107_0.TournamentSwept > 0)
			{
				Class107 @class = this.class107_0;
				@class.TournamentSwept -= 1;
				this.method_15();
				if (this.class107_0.AutoUpdate)
				{
					Class107 class2 = this.class107_0;
					class2.TournamentWins -= 1;
					this.method_17();
					Class107 class3 = this.class107_0;
					class3.TournamentQualifies -= 1;
					this.method_16();
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0000552E File Offset: 0x0000372E
		[CompilerGenerated]
		private void method_53(object sender, EventArgs e)
		{
			this.class107_0.TournamentSwept = this.method_22(this.class107_0.TournamentSwept);
			this.method_15();
		}

		// Token: 0x04000226 RID: 550
		private TabControl tabRaces;

		// Token: 0x04000227 RID: 551
		private TabPage tabWelcome;

		// Token: 0x04000228 RID: 552
		private PictureBox picWelcome;

		// Token: 0x04000229 RID: 553
		private TabPage tabSpeedway;

		// Token: 0x0400022A RID: 554
		private PictureBox picSpeedway;

		// Token: 0x0400022B RID: 555
		private Label lblSpeedwayQualifiesLabel;

		// Token: 0x0400022C RID: 556
		private Button btnSpeedwayWinsAdd;

		// Token: 0x0400022D RID: 557
		private Button btnSpeedwayWinsSubtract;

		// Token: 0x0400022E RID: 558
		private Button btnSpeedwayWinsModify;

		// Token: 0x0400022F RID: 559
		private Label lblSpeedwayWinsLabel;

		// Token: 0x04000230 RID: 560
		private Button btnSpeedwayQualifiesSubtract;

		// Token: 0x04000231 RID: 561
		private Button btnSpeedwayQualifiesAdd;

		// Token: 0x04000232 RID: 562
		private Button btnSpeedwayQualifiesModify;

		// Token: 0x04000233 RID: 563
		private Label lblSpeedwayWins;

		// Token: 0x04000234 RID: 564
		private Label lblSpeedwayQualifies;

		// Token: 0x04000235 RID: 565
		private TabPage tabRural;

		// Token: 0x04000236 RID: 566
		private PictureBox picRural;

		// Token: 0x04000237 RID: 567
		private Label lblRuralQualifiesLabel;

		// Token: 0x04000238 RID: 568
		private Button btnRuralWinsAdd;

		// Token: 0x04000239 RID: 569
		private Button btnRuralWinsSubtract;

		// Token: 0x0400023A RID: 570
		private Button btnRuralWinsModify;

		// Token: 0x0400023B RID: 571
		private Label lblRuralWinsLabel;

		// Token: 0x0400023C RID: 572
		private Button btnRuralQualifiesSubtract;

		// Token: 0x0400023D RID: 573
		private Button btnRuralQualifiesAdd;

		// Token: 0x0400023E RID: 574
		private Button btnRuralQualifiesModify;

		// Token: 0x0400023F RID: 575
		private Label lblRuralWins;

		// Token: 0x04000240 RID: 576
		private Label lblRuralQualifies;

		// Token: 0x04000241 RID: 577
		private TabPage tabUrban;

		// Token: 0x04000242 RID: 578
		private PictureBox picUrban;

		// Token: 0x04000243 RID: 579
		private Label lblUrbanQualifiesLabel;

		// Token: 0x04000244 RID: 580
		private Button btnUrbanWinsAdd;

		// Token: 0x04000245 RID: 581
		private Button btnUrbanWinsSubtract;

		// Token: 0x04000246 RID: 582
		private Button btnUrbanWinsModify;

		// Token: 0x04000247 RID: 583
		private Label lblUrbanWinsLabel;

		// Token: 0x04000248 RID: 584
		private Button btnUrbanQualifiesSubtract;

		// Token: 0x04000249 RID: 585
		private Button btnUrbanQualifiesAdd;

		// Token: 0x0400024A RID: 586
		private Button btnUrbanQualifiesModify;

		// Token: 0x0400024B RID: 587
		private Label lblUrbanWins;

		// Token: 0x0400024C RID: 588
		private Label lblUrbanQualifies;

		// Token: 0x0400024D RID: 589
		private TabPage tabTournament;

		// Token: 0x0400024E RID: 590
		private PictureBox picTournament;

		// Token: 0x0400024F RID: 591
		private Button btnTournamentSweptAdd;

		// Token: 0x04000250 RID: 592
		private Button btnTournamentSweptSubtract;

		// Token: 0x04000251 RID: 593
		private Button btnTournamentSweptModify;

		// Token: 0x04000252 RID: 594
		private Label lblTournamentSweptLabel;

		// Token: 0x04000253 RID: 595
		private Label lblTournamentSwept;

		// Token: 0x04000254 RID: 596
		private Label lblTournamentQualifiesLabel;

		// Token: 0x04000255 RID: 597
		private Button btnTournamentWinsAdd;

		// Token: 0x04000256 RID: 598
		private Button btnTournamentWinsSubtract;

		// Token: 0x04000257 RID: 599
		private Button btnTournamentWinsModify;

		// Token: 0x04000258 RID: 600
		private Label lblTournamentWinsLabel;

		// Token: 0x04000259 RID: 601
		private Button btnTournamentQualifiesSubtract;

		// Token: 0x0400025A RID: 602
		private Button btnTournamentQualifiesAdd;

		// Token: 0x0400025B RID: 603
		private Button btnTournamentQualifiesModify;

		// Token: 0x0400025C RID: 604
		private Label lblTournamentWins;

		// Token: 0x0400025D RID: 605
		private Label lblTournamentQualifies;

		// Token: 0x0400025E RID: 606
		private TabPage tabTickets;

		// Token: 0x0400025F RID: 607
		private PictureBox pictureBox1;

		// Token: 0x04000260 RID: 608
		private ComboBox cboTrack;

		// Token: 0x04000261 RID: 609
		private ComboBox cboRacers;

		// Token: 0x04000262 RID: 610
		private Label lblDepositValue;

		// Token: 0x04000263 RID: 611
		private Label lblTicketsRacers;

		// Token: 0x04000264 RID: 612
		private Label lblTicketDeposit;

		// Token: 0x04000265 RID: 613
		private Label lblTicketsTrack;

		// Token: 0x04000266 RID: 614
		private ComboBox cboPlace;

		// Token: 0x04000267 RID: 615
		private Label lblTicketsNetProfitValue;

		// Token: 0x04000268 RID: 616
		private Label lblTicketsWonValue;

		// Token: 0x04000269 RID: 617
		private Label lblTicketsPlace;

		// Token: 0x0400026A RID: 618
		private Label lblTicketsNetProfit;

		// Token: 0x0400026B RID: 619
		private Label lblTicketsWon;

		// Token: 0x0400026C RID: 620
		private Label label3;

		// Token: 0x0400026D RID: 621
		private Label label2;

		// Token: 0x0400026E RID: 622
		private Label label1;

		// Token: 0x0400026F RID: 623
		private MenuStrip RaceTrackMenu;

		// Token: 0x04000270 RID: 624
		private ToolStripMenuItem mnuFile;

		// Token: 0x04000271 RID: 625
		private ToolStripMenuItem mnuNew;

		// Token: 0x04000272 RID: 626
		private ToolStripMenuItem mnuOpen;

		// Token: 0x04000273 RID: 627
		private ToolStripMenuItem mnuSave;

		// Token: 0x04000274 RID: 628
		private ToolStripMenuItem SaveAsMenuItem;

		// Token: 0x04000275 RID: 629
		private ToolStripMenuItem ExitMenuItem;

		// Token: 0x04000276 RID: 630
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000277 RID: 631
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000278 RID: 632
		private ToolStripMenuItem OptionsMenuItem;

		// Token: 0x04000279 RID: 633
		private ToolStripMenuItem AutoUpdateMenuItem;

		// Token: 0x0400027A RID: 634
		private ToolStripMenuItem TopMostMenuItem;

		// Token: 0x0400027B RID: 635
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x0400027C RID: 636
		private ToolStripMenuItem GuideMenuItem;

		// Token: 0x0400027D RID: 637
		private static readonly int int_0 = 50;

		// Token: 0x0400027E RID: 638
		private static readonly int int_1 = 75;

		// Token: 0x0400027F RID: 639
		private static readonly int int_2 = 100;

		// Token: 0x04000280 RID: 640
		private static readonly int int_3 = 150;

		// Token: 0x04000281 RID: 641
		private static readonly int int_4 = 300;

		// Token: 0x04000282 RID: 642
		private static readonly int int_5 = 400;

		// Token: 0x04000283 RID: 643
		private Class107 class107_0;

		// Token: 0x04000284 RID: 644
		private Class114 class114_0;
	}
}
