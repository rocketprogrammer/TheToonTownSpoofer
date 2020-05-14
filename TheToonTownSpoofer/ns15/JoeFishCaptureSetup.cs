using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns17;
using ns20;
using ns21;
using ns23;
using ns24;
using ns25;
using ns26;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x02000214 RID: 532
	internal sealed partial class JoeFishCaptureSetup : CaptureSetupForm
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x000385D8 File Offset: 0x000367D8
		private void InitializeComponent_2()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(JoeFishCaptureSetup));
			this.JoeFishCaptureSetupPanel = new Class310();
			this.EstateSellFishButtonState = new Control12();
			this.CastButton = new LinkLabel();
			this.NoBeansButton = new LinkLabel();
			this.BootCaughtButton = new LinkLabel();
			this.FishCaughtDuringBingoStatus = new Control12();
			this.EstateSellFishButton = new LinkLabel();
			this.ExitFishingButton = new LinkLabel();
			this.NewSpeciesTitleDuringBingo = new LinkLabel();
			this.NewSpeciesTitle = new LinkLabel();
			this.FishCaughtState = new Control12();
			this.CaptureLabel = new Label();
			this.BucketFullButton = new LinkLabel();
			this.CaptureLogo = new PictureBox();
			this.NoBeansButtonState = new Control12();
			this.NewSpeciesTitleDuringBingoState = new Control12();
			this.StatusLabel = new Label();
			this.NewSpeciesTitleState = new Control12();
			this.SellFishButton = new LinkLabel();
			this.BucketFullButtonState = new Control12();
			this.HelpDescription = new Label();
			this.BootCaughtButtonState = new Control12();
			this.SellFishButtonState = new Control12();
			this.CastButtonState = new Control12();
			this.FishCaughtDuringBingoButton = new LinkLabel();
			this.FishCaughtButton = new LinkLabel();
			this.ExitFishingButtonState = new Control12();
			this.lblContentPackTitle = new Label();
			this.JoeFishCaptureSetupContainer = new Panel();
			this.JoeFishCaptureSetupMenu = new MenuStrip();
			this.FileMenu = new ToolStripMenuItem();
			this.NewFileMenuItem = new ToolStripMenuItem();
			this.OpenFileMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.SaveFileMenuItem = new ToolStripMenuItem();
			this.SaveAsFileMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.CloseFileMenuItem = new ToolStripMenuItem();
			this.WindowMenu = new ToolStripMenuItem();
			this.SelectWindowMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideHelpMenuItem = new ToolStripMenuItem();
			this.JoeFishCaptureSetupPanel.SuspendLayout();
			((ISupportInitialize)this.CaptureLogo).BeginInit();
			this.JoeFishCaptureSetupContainer.SuspendLayout();
			this.JoeFishCaptureSetupMenu.SuspendLayout();
			base.SuspendLayout();
			this.JoeFishCaptureSetupPanel.CenterColor = Color.FromArgb(224, 224, 224);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.EstateSellFishButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CastButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoBeansButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BootCaughtButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FishCaughtDuringBingoStatus);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.EstateSellFishButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.ExitFishingButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NewSpeciesTitleDuringBingo);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NewSpeciesTitle);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FishCaughtState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CaptureLabel);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BucketFullButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CaptureLogo);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoBeansButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NewSpeciesTitleDuringBingoState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.StatusLabel);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NewSpeciesTitleState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.SellFishButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BucketFullButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.HelpDescription);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BootCaughtButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.SellFishButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CastButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FishCaughtDuringBingoButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FishCaughtButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.ExitFishingButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.lblContentPackTitle);
			this.JoeFishCaptureSetupPanel.Dock = DockStyle.Fill;
			this.JoeFishCaptureSetupPanel.HeaderHeight = 30;
			this.JoeFishCaptureSetupPanel.ImageBounds = new Rectangle(0, 0, 0, 0);
			this.JoeFishCaptureSetupPanel.ImageLocation = new Point(0, 0);
			this.JoeFishCaptureSetupPanel.Location = new Point(0, 0);
			this.JoeFishCaptureSetupPanel.Name = "JoeFishCaptureSetupPanel";
			this.JoeFishCaptureSetupPanel.Size = new Size(466, 348);
			this.JoeFishCaptureSetupPanel.TabIndex = 31;
			this.EstateSellFishButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.EstateSellFishButtonState.Location = new Point(24, 131);
			this.EstateSellFishButtonState.Name = "EstateSellFishButtonState";
			this.EstateSellFishButtonState.On = true;
			this.EstateSellFishButtonState.Size = new Size(19, 19);
			this.EstateSellFishButtonState.TabIndex = 28;
			this.EstateSellFishButtonState.Text = "led1";
			this.CastButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.CastButton.AutoSize = true;
			this.CastButton.BackColor = Color.Transparent;
			this.CastButton.Font = new Font("Calibri", 12f);
			this.CastButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.CastButton.Location = new Point(55, 110);
			this.CastButton.Name = "CastButton";
			this.CastButton.Size = new Size(85, 19);
			this.CastButton.TabIndex = 40;
			this.CastButton.TabStop = true;
			this.CastButton.Text = "Cast Button";
			this.CastButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.CastButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.CastButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.NoBeansButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.NoBeansButton.AutoSize = true;
			this.NoBeansButton.BackColor = Color.Transparent;
			this.NoBeansButton.Font = new Font("Calibri", 12f);
			this.NoBeansButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.NoBeansButton.Location = new Point(55, 295);
			this.NoBeansButton.Name = "NoBeansButton";
			this.NoBeansButton.Size = new Size(118, 19);
			this.NoBeansButton.TabIndex = 37;
			this.NoBeansButton.TabStop = true;
			this.NoBeansButton.Text = "No Beans Button";
			this.NoBeansButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.NoBeansButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.NoBeansButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.BootCaughtButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.BootCaughtButton.AutoSize = true;
			this.BootCaughtButton.BackColor = Color.Transparent;
			this.BootCaughtButton.Font = new Font("Calibri", 12f);
			this.BootCaughtButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.BootCaughtButton.Location = new Point(55, 68);
			this.BootCaughtButton.Name = "BootCaughtButton";
			this.BootCaughtButton.Size = new Size(136, 19);
			this.BootCaughtButton.TabIndex = 36;
			this.BootCaughtButton.TabStop = true;
			this.BootCaughtButton.Text = "Boot Caught Button";
			this.BootCaughtButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.BootCaughtButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.BootCaughtButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.FishCaughtDuringBingoStatus.BackColor = Color.FromArgb(224, 224, 224);
			this.FishCaughtDuringBingoStatus.Location = new Point(24, 194);
			this.FishCaughtDuringBingoStatus.Name = "FishCaughtDuringBingoStatus";
			this.FishCaughtDuringBingoStatus.On = true;
			this.FishCaughtDuringBingoStatus.Size = new Size(19, 19);
			this.FishCaughtDuringBingoStatus.TabIndex = 27;
			this.FishCaughtDuringBingoStatus.Text = "led1";
			this.EstateSellFishButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.EstateSellFishButton.AutoSize = true;
			this.EstateSellFishButton.BackColor = Color.Transparent;
			this.EstateSellFishButton.Font = new Font("Calibri", 12f);
			this.EstateSellFishButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.EstateSellFishButton.Location = new Point(55, 131);
			this.EstateSellFishButton.Name = "EstateSellFishButton";
			this.EstateSellFishButton.Size = new Size(154, 19);
			this.EstateSellFishButton.TabIndex = 38;
			this.EstateSellFishButton.TabStop = true;
			this.EstateSellFishButton.Text = "Estate Sell Fish Button";
			this.EstateSellFishButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.EstateSellFishButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.EstateSellFishButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.ExitFishingButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.ExitFishingButton.AutoSize = true;
			this.ExitFishingButton.BackColor = Color.Transparent;
			this.ExitFishingButton.Font = new Font("Calibri", 12f);
			this.ExitFishingButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.ExitFishingButton.Location = new Point(55, 152);
			this.ExitFishingButton.Name = "ExitFishingButton";
			this.ExitFishingButton.Size = new Size(130, 19);
			this.ExitFishingButton.TabIndex = 35;
			this.ExitFishingButton.TabStop = true;
			this.ExitFishingButton.Text = "Exit Fishing Button";
			this.ExitFishingButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.ExitFishingButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.ExitFishingButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.NewSpeciesTitleDuringBingo.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.NewSpeciesTitleDuringBingo.AutoSize = true;
			this.NewSpeciesTitleDuringBingo.BackColor = Color.Transparent;
			this.NewSpeciesTitleDuringBingo.Font = new Font("Calibri", 12f);
			this.NewSpeciesTitleDuringBingo.LinkColor = Color.FromArgb(51, 153, 255);
			this.NewSpeciesTitleDuringBingo.Location = new Point(55, 255);
			this.NewSpeciesTitleDuringBingo.Name = "NewSpeciesTitleDuringBingo";
			this.NewSpeciesTitleDuringBingo.Size = new Size(124, 38);
			this.NewSpeciesTitleDuringBingo.TabIndex = 34;
			this.NewSpeciesTitleDuringBingo.TabStop = true;
			this.NewSpeciesTitleDuringBingo.Text = "New Species Title\r\nDuring Bingo";
			this.NewSpeciesTitleDuringBingo.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.NewSpeciesTitleDuringBingo.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.NewSpeciesTitleDuringBingo.MouseHover += this.FishCaughtButton_MouseHover;
			this.NewSpeciesTitle.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.NewSpeciesTitle.AutoSize = true;
			this.NewSpeciesTitle.BackColor = Color.Transparent;
			this.NewSpeciesTitle.Font = new Font("Calibri", 12f);
			this.NewSpeciesTitle.LinkColor = Color.FromArgb(51, 153, 255);
			this.NewSpeciesTitle.Location = new Point(55, 234);
			this.NewSpeciesTitle.Name = "NewSpeciesTitle";
			this.NewSpeciesTitle.Size = new Size(124, 19);
			this.NewSpeciesTitle.TabIndex = 34;
			this.NewSpeciesTitle.TabStop = true;
			this.NewSpeciesTitle.Text = "New Species Title";
			this.NewSpeciesTitle.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.NewSpeciesTitle.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.NewSpeciesTitle.MouseHover += this.FishCaughtButton_MouseHover;
			this.FishCaughtState.BackColor = Color.FromArgb(224, 224, 224);
			this.FishCaughtState.Location = new Point(24, 173);
			this.FishCaughtState.Name = "FishCaughtState";
			this.FishCaughtState.On = true;
			this.FishCaughtState.Size = new Size(19, 19);
			this.FishCaughtState.TabIndex = 30;
			this.FishCaughtState.Text = "led1";
			this.CaptureLabel.AutoSize = true;
			this.CaptureLabel.BackColor = Color.Transparent;
			this.CaptureLabel.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.CaptureLabel.ForeColor = Color.DimGray;
			this.CaptureLabel.Location = new Point(55, 46);
			this.CaptureLabel.Name = "CaptureLabel";
			this.CaptureLabel.Size = new Size(60, 19);
			this.CaptureLabel.TabIndex = 44;
			this.CaptureLabel.Text = "Capture";
			this.BucketFullButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.BucketFullButton.AutoSize = true;
			this.BucketFullButton.BackColor = Color.Transparent;
			this.BucketFullButton.Font = new Font("Calibri", 12f);
			this.BucketFullButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.BucketFullButton.Location = new Point(55, 89);
			this.BucketFullButton.Name = "BucketFullButton";
			this.BucketFullButton.Size = new Size(126, 19);
			this.BucketFullButton.TabIndex = 39;
			this.BucketFullButton.TabStop = true;
			this.BucketFullButton.Text = "Bucket Full Button";
			this.BucketFullButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.BucketFullButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.BucketFullButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.CaptureLogo.BackColor = Color.FromArgb(224, 224, 224);
			this.CaptureLogo.Image = (Image)componentResourceManager.GetObject("CaptureLogo.Image");
			this.CaptureLogo.Location = new Point(389, 271);
			this.CaptureLogo.Name = "CaptureLogo";
			this.CaptureLogo.Size = new Size(64, 64);
			this.CaptureLogo.SizeMode = PictureBoxSizeMode.AutoSize;
			this.CaptureLogo.TabIndex = 46;
			this.CaptureLogo.TabStop = false;
			this.NoBeansButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.NoBeansButtonState.Location = new Point(24, 295);
			this.NoBeansButtonState.Name = "NoBeansButtonState";
			this.NoBeansButtonState.On = true;
			this.NoBeansButtonState.Size = new Size(19, 19);
			this.NoBeansButtonState.TabIndex = 23;
			this.NoBeansButtonState.Text = "led1";
			this.NewSpeciesTitleDuringBingoState.BackColor = Color.FromArgb(224, 224, 224);
			this.NewSpeciesTitleDuringBingoState.Location = new Point(24, 255);
			this.NewSpeciesTitleDuringBingoState.Name = "NewSpeciesTitleDuringBingoState";
			this.NewSpeciesTitleDuringBingoState.On = true;
			this.NewSpeciesTitleDuringBingoState.Size = new Size(19, 19);
			this.NewSpeciesTitleDuringBingoState.TabIndex = 22;
			this.NewSpeciesTitleDuringBingoState.Text = "led1";
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = Color.Transparent;
			this.StatusLabel.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.StatusLabel.ForeColor = Color.DimGray;
			this.StatusLabel.Location = new Point(13, 46);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new Size(42, 19);
			this.StatusLabel.TabIndex = 45;
			this.StatusLabel.Text = "State";
			this.NewSpeciesTitleState.BackColor = Color.FromArgb(224, 224, 224);
			this.NewSpeciesTitleState.Location = new Point(24, 234);
			this.NewSpeciesTitleState.Name = "NewSpeciesTitleState";
			this.NewSpeciesTitleState.On = true;
			this.NewSpeciesTitleState.Size = new Size(19, 19);
			this.NewSpeciesTitleState.TabIndex = 22;
			this.NewSpeciesTitleState.Text = "led1";
			this.SellFishButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.SellFishButton.AutoSize = true;
			this.SellFishButton.BackColor = Color.Transparent;
			this.SellFishButton.Font = new Font("Calibri", 12f);
			this.SellFishButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.SellFishButton.Location = new Point(55, 316);
			this.SellFishButton.Name = "SellFishButton";
			this.SellFishButton.Size = new Size(109, 19);
			this.SellFishButton.TabIndex = 43;
			this.SellFishButton.TabStop = true;
			this.SellFishButton.Text = "Sell Fish Button";
			this.SellFishButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.SellFishButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.SellFishButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.BucketFullButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.BucketFullButtonState.Location = new Point(24, 89);
			this.BucketFullButtonState.Name = "BucketFullButtonState";
			this.BucketFullButtonState.On = true;
			this.BucketFullButtonState.Size = new Size(19, 19);
			this.BucketFullButtonState.TabIndex = 21;
			this.BucketFullButtonState.Text = "led1";
			this.HelpDescription.BackColor = Color.Transparent;
			this.HelpDescription.ForeColor = Color.DimGray;
			this.HelpDescription.Location = new Point(214, 72);
			this.HelpDescription.Name = "HelpDescription";
			this.HelpDescription.Size = new Size(238, 163);
			this.HelpDescription.TabIndex = 33;
			this.HelpDescription.Text = componentResourceManager.GetString("HelpDescription.Text");
			this.BootCaughtButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.BootCaughtButtonState.Location = new Point(24, 68);
			this.BootCaughtButtonState.Name = "BootCaughtButtonState";
			this.BootCaughtButtonState.On = true;
			this.BootCaughtButtonState.Size = new Size(19, 19);
			this.BootCaughtButtonState.TabIndex = 26;
			this.BootCaughtButtonState.Text = "led1";
			this.SellFishButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.SellFishButtonState.Location = new Point(24, 316);
			this.SellFishButtonState.Name = "SellFishButtonState";
			this.SellFishButtonState.On = true;
			this.SellFishButtonState.Size = new Size(19, 19);
			this.SellFishButtonState.TabIndex = 29;
			this.SellFishButtonState.Text = "led1";
			this.CastButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.CastButtonState.Location = new Point(24, 110);
			this.CastButtonState.Name = "CastButtonState";
			this.CastButtonState.On = true;
			this.CastButtonState.Size = new Size(19, 19);
			this.CastButtonState.TabIndex = 25;
			this.CastButtonState.Text = "led1";
			this.FishCaughtDuringBingoButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.FishCaughtDuringBingoButton.AutoSize = true;
			this.FishCaughtDuringBingoButton.BackColor = Color.Transparent;
			this.FishCaughtDuringBingoButton.Font = new Font("Calibri", 12f);
			this.FishCaughtDuringBingoButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.FishCaughtDuringBingoButton.Location = new Point(55, 194);
			this.FishCaughtDuringBingoButton.Name = "FishCaughtDuringBingoButton";
			this.FishCaughtDuringBingoButton.Size = new Size(132, 38);
			this.FishCaughtDuringBingoButton.TabIndex = 42;
			this.FishCaughtDuringBingoButton.TabStop = true;
			this.FishCaughtDuringBingoButton.Text = "Fish Caught During\r\nBingo Button";
			this.FishCaughtDuringBingoButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.FishCaughtDuringBingoButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.FishCaughtDuringBingoButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.FishCaughtButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.FishCaughtButton.AutoSize = true;
			this.FishCaughtButton.BackColor = Color.Transparent;
			this.FishCaughtButton.Font = new Font("Calibri", 12f);
			this.FishCaughtButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.FishCaughtButton.Location = new Point(55, 173);
			this.FishCaughtButton.Name = "FishCaughtButton";
			this.FishCaughtButton.Size = new Size(132, 19);
			this.FishCaughtButton.TabIndex = 41;
			this.FishCaughtButton.TabStop = true;
			this.FishCaughtButton.Text = "Fish Caught Button";
			this.FishCaughtButton.LinkClicked += this.FishCaughtButton_LinkClicked;
			this.FishCaughtButton.MouseLeave += this.FishCaughtButton_MouseLeave;
			this.FishCaughtButton.MouseHover += this.FishCaughtButton_MouseHover;
			this.ExitFishingButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.ExitFishingButtonState.Location = new Point(24, 152);
			this.ExitFishingButtonState.Name = "ExitFishingButtonState";
			this.ExitFishingButtonState.On = true;
			this.ExitFishingButtonState.Size = new Size(19, 19);
			this.ExitFishingButtonState.TabIndex = 24;
			this.ExitFishingButtonState.Text = "led1";
			this.lblContentPackTitle.AutoSize = true;
			this.lblContentPackTitle.BackColor = Color.Transparent;
			this.lblContentPackTitle.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.lblContentPackTitle.ForeColor = Color.Gray;
			this.lblContentPackTitle.Location = new Point(10, 8);
			this.lblContentPackTitle.Name = "lblContentPackTitle";
			this.lblContentPackTitle.Size = new Size(171, 19);
			this.lblContentPackTitle.TabIndex = 32;
			this.lblContentPackTitle.Text = "Joe Fish : Capture Setup";
			this.JoeFishCaptureSetupContainer.Controls.Add(this.JoeFishCaptureSetupPanel);
			this.JoeFishCaptureSetupContainer.Dock = DockStyle.Fill;
			this.JoeFishCaptureSetupContainer.Location = new Point(0, 24);
			this.JoeFishCaptureSetupContainer.Name = "JoeFishCaptureSetupContainer";
			this.JoeFishCaptureSetupContainer.Size = new Size(466, 348);
			this.JoeFishCaptureSetupContainer.TabIndex = 47;
			this.JoeFishCaptureSetupMenu.Items.AddRange(new ToolStripItem[]
			{
				this.FileMenu,
				this.WindowMenu,
				this.HelpMenuItem
			});
			this.JoeFishCaptureSetupMenu.Location = new Point(0, 0);
			this.JoeFishCaptureSetupMenu.Name = "JoeFishCaptureSetupMenu";
			this.JoeFishCaptureSetupMenu.Size = new Size(466, 24);
			this.JoeFishCaptureSetupMenu.TabIndex = 48;
			this.JoeFishCaptureSetupMenu.Text = "menuStrip1";
			this.FileMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NewFileMenuItem,
				this.OpenFileMenuItem,
				this.toolStripSeparator2,
				this.SaveFileMenuItem,
				this.SaveAsFileMenuItem,
				this.toolStripSeparator1,
				this.CloseFileMenuItem
			});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new Size(37, 20);
			this.FileMenu.Text = "&File";
			this.NewFileMenuItem.Name = "NewFileMenuItem";
			this.NewFileMenuItem.ShortcutKeys = (Keys)131150;
			this.NewFileMenuItem.Size = new Size(192, 22);
			this.NewFileMenuItem.Text = "&New";
			this.OpenFileMenuItem.Name = "OpenFileMenuItem";
			this.OpenFileMenuItem.ShortcutKeys = (Keys)131151;
			this.OpenFileMenuItem.Size = new Size(192, 22);
			this.OpenFileMenuItem.Text = "&Open";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(189, 6);
			this.SaveFileMenuItem.Name = "SaveFileMenuItem";
			this.SaveFileMenuItem.ShortcutKeys = (Keys)131155;
			this.SaveFileMenuItem.Size = new Size(192, 22);
			this.SaveFileMenuItem.Text = "&Save";
			this.SaveAsFileMenuItem.Name = "SaveAsFileMenuItem";
			this.SaveAsFileMenuItem.ShortcutKeys = (Keys)196691;
			this.SaveAsFileMenuItem.Size = new Size(192, 22);
			this.SaveAsFileMenuItem.Text = "Save &As..";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(189, 6);
			this.CloseFileMenuItem.Name = "CloseFileMenuItem";
			this.CloseFileMenuItem.ShortcutKeys = (Keys)131159;
			this.CloseFileMenuItem.Size = new Size(192, 22);
			this.CloseFileMenuItem.Text = "&Close";
			this.WindowMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.SelectWindowMenuItem
			});
			this.WindowMenu.Name = "WindowMenu";
			this.WindowMenu.Size = new Size(63, 20);
			this.WindowMenu.Text = "&Window";
			this.SelectWindowMenuItem.Name = "SelectWindowMenuItem";
			this.SelectWindowMenuItem.Size = new Size(213, 22);
			this.SelectWindowMenuItem.Text = "&Select ToonTown Window";
			this.SelectWindowMenuItem.Click += this.SelectWindowMenuItem_Click;
			this.HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.GuideHelpMenuItem
			});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			this.GuideHelpMenuItem.Name = "GuideHelpMenuItem";
			this.GuideHelpMenuItem.ShortcutKeys = Keys.F1;
			this.GuideHelpMenuItem.Size = new Size(124, 22);
			this.GuideHelpMenuItem.Text = "&Guide";
			this.GuideHelpMenuItem.Click += this.GuideHelpMenuItem_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(218, 228, 246);
			base.ClientSize = new Size(466, 372);
			base.Controls.Add(this.JoeFishCaptureSetupContainer);
			base.Controls.Add(this.JoeFishCaptureSetupMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MainMenuStrip = this.JoeFishCaptureSetupMenu;
			base.MaximizeBox = false;
			this.MaximumSize = new Size(472, 400);
			this.MinimumSize = new Size(472, 400);
			base.Name = "JoeFishCaptureSetup";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Joe Fish : Capture Setup : New File";
			this.JoeFishCaptureSetupPanel.ResumeLayout(false);
			this.JoeFishCaptureSetupPanel.PerformLayout();
			((ISupportInitialize)this.CaptureLogo).EndInit();
			this.JoeFishCaptureSetupContainer.ResumeLayout(false);
			this.JoeFishCaptureSetupMenu.ResumeLayout(false);
			this.JoeFishCaptureSetupMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0003A534 File Offset: 0x00038734
		public JoeFishCaptureSetup()
		{
			this.InitializeComponent_2();
			this.class114_0 = Class110.Instance.JoeFishSettings.JoeFishCaptureSettings;
			this.NewFileMenuItem.Click += base.method_0;
			this.OpenFileMenuItem.Click += base.method_1;
			this.SaveAsFileMenuItem.Click += base.method_3;
			this.SaveFileMenuItem.Click += base.method_2;
			this.CloseFileMenuItem.Click += base.method_4;
			base.method_5();
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0003A5DC File Offset: 0x000387DC
		protected override bool vmethod_3(out Class524 filePath)
		{
			using (StringInputForm stringInputForm = new StringInputForm())
			{
				stringInputForm.LabelMessage = JoeFishCaptureSetup.string_21;
				stringInputForm.Text = JoeFishCaptureSetup.string_22;
				if (stringInputForm.ShowDialog() == DialogResult.OK)
				{
					filePath = new Class524(stringInputForm.Value, Class266.smethod_2(Class291.JoeFishCaptureSettingsDirectory, ".jfc"));
					return true;
				}
			}
			filePath = null;
			return false;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000070CD File Offset: 0x000052CD
		protected override void vmethod_1(Class524 fileName)
		{
			this.method_13(fileName);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0003A650 File Offset: 0x00038850
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class98_0.method_1(fileName.string_1);
				this.method_13(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000070D6 File Offset: 0x000052D6
		private void method_13(Class524 fileName)
		{
			if (!this.class114_0.Files.Contains(fileName))
			{
				this.class114_0.Files.Add(fileName);
				Class110.smethod_1();
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0003A69C File Offset: 0x0003889C
		protected override bool vmethod_6(out Class524 fileName)
		{
			Class524 @class;
			bool result;
			if (result = Class460.smethod_2(out @class))
			{
				fileName = @class;
			}
			else
			{
				fileName = null;
			}
			return result;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0003A6C0 File Offset: 0x000388C0
		protected override bool vmethod_5(Class524 fileName)
		{
			bool result;
			try
			{
				Class98 @class = new Class98(fileName.string_1);
				if (this.class98_0 != null)
				{
					this.class98_0.Dispose();
				}
				this.class98_0 = @class;
				this.method_14();
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(JoeFishCaptureSetup.string_23, fileName.string_1)
				});
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00007102 File Offset: 0x00005302
		protected override void vmethod_0()
		{
			if (this.class98_0 != null)
			{
				this.class98_0.Dispose();
			}
			this.class98_0 = new Class98();
			this.method_14();
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0003A740 File Offset: 0x00038940
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (Class524.smethod_0(fileName, null))
			{
				if (modified)
				{
					this.Text = JoeFishCaptureSetup.string_24;
					return;
				}
				this.Text = JoeFishCaptureSetup.string_25;
				return;
			}
			else
			{
				if (modified)
				{
					this.Text = string.Format(JoeFishCaptureSetup.string_26, fileName.string_0);
					return;
				}
				this.Text = JoeFishCaptureSetup.string_27 + fileName.string_0;
				return;
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0003A7A4 File Offset: 0x000389A4
		private void method_14()
		{
			CaptureSetupForm.smethod_0(this.class98_0.BootCaughtCapture, this.BootCaughtButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.BucketFullCapture, this.BucketFullButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.CastCapture, this.CastButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.EstateSellFishCapture, this.EstateSellFishButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.ExitFishingCapture, this.ExitFishingButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.FishCaughtCapture, this.FishCaughtState);
			CaptureSetupForm.smethod_0(this.class98_0.FishCaughtDuringBingoCapture, this.FishCaughtDuringBingoStatus);
			CaptureSetupForm.smethod_0(this.class98_0.NewSpeciesCapture, this.NewSpeciesTitleState);
			CaptureSetupForm.smethod_0(this.class98_0.NewSpeciesDuringBingoCapture, this.NewSpeciesTitleDuringBingoState);
			CaptureSetupForm.smethod_0(this.class98_0.NoBeansCapture, this.NoBeansButtonState);
			CaptureSetupForm.smethod_0(this.class98_0.SellFishCapture, this.SellFishButtonState);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		private void FishCaughtButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			base.method_12();
			Class125 @class = null;
			try
			{
				Struct46 @struct;
				if (object.ReferenceEquals(sender, this.CastButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_0, JoeFishCaptureSetup.string_1, this.class98_0.CastBounds, out @class, out @struct))
					{
						if (this.class98_0.CastCapture != null)
						{
							this.class98_0.CastCapture.Dispose();
							this.class98_0.CastCapture = null;
						}
						this.class98_0.CastCapture = new Class150(@class);
						this.class98_0.CastBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.ExitFishingButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_2, JoeFishCaptureSetup.string_1, this.class98_0.ExitFishingBounds, out @class, out @struct))
					{
						if (this.class98_0.ExitFishingCapture != null)
						{
							this.class98_0.ExitFishingCapture.Dispose();
							this.class98_0.ExitFishingCapture = null;
						}
						this.class98_0.ExitFishingCapture = new Class150(@class);
						this.class98_0.ExitFishingBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.FishCaughtButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_3, JoeFishCaptureSetup.string_4, this.class98_0.FishCaughtBounds, out @class, out @struct))
					{
						if (this.class98_0.FishCaughtCapture != null)
						{
							this.class98_0.FishCaughtCapture.Dispose();
							this.class98_0.FishCaughtCapture = null;
						}
						this.class98_0.FishCaughtCapture = new Class150(@class);
						this.class98_0.FishCaughtBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.FishCaughtDuringBingoButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_5, JoeFishCaptureSetup.string_6, this.class98_0.FishCaughtDuringBingoBounds, out @class, out @struct))
					{
						if (this.class98_0.FishCaughtDuringBingoCapture != null)
						{
							this.class98_0.FishCaughtDuringBingoCapture.Dispose();
							this.class98_0.FishCaughtDuringBingoCapture = null;
						}
						this.class98_0.FishCaughtDuringBingoCapture = new Class150(@class);
						this.class98_0.FishCaughtDuringBingoBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.BootCaughtButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_7, JoeFishCaptureSetup.string_8, this.class98_0.BootCaughtBounds, out @class, out @struct))
					{
						if (this.class98_0.BootCaughtCapture != null)
						{
							this.class98_0.BootCaughtCapture.Dispose();
							this.class98_0.BootCaughtCapture = null;
						}
						this.class98_0.BootCaughtCapture = new Class150(@class);
						this.class98_0.BootCaughtBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.BucketFullButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_9, JoeFishCaptureSetup.string_10, this.class98_0.BucketFullBounds, out @class, out @struct))
					{
						if (this.class98_0.BucketFullCapture != null)
						{
							this.class98_0.BucketFullCapture.Dispose();
							this.class98_0.BucketFullCapture = null;
						}
						this.class98_0.BucketFullCapture = new Class150(@class);
						this.class98_0.BucketFullBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.SellFishButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_11, JoeFishCaptureSetup.string_12, this.class98_0.SellFishBounds, out @class, out @struct))
					{
						if (this.class98_0.SellFishCapture != null)
						{
							this.class98_0.SellFishCapture.Dispose();
							this.class98_0.SellFishCapture = null;
						}
						this.class98_0.SellFishCapture = new Class150(@class);
						this.class98_0.SellFishBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.NoBeansButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_13, JoeFishCaptureSetup.string_14, this.class98_0.NoBeansBounds, out @class, out @struct))
					{
						if (this.class98_0.NoBeansCapture != null)
						{
							this.class98_0.NoBeansCapture.Dispose();
							this.class98_0.NoBeansCapture = null;
						}
						this.class98_0.NoBeansCapture = new Class150(@class);
						this.class98_0.NoBeansBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.EstateSellFishButton))
				{
					if (base.method_10(JoeFishCaptureSetup.string_15, JoeFishCaptureSetup.string_16, this.class98_0.EstateSellFishBounds, out @class, out @struct))
					{
						if (this.class98_0.EstateSellFishCapture != null)
						{
							this.class98_0.EstateSellFishCapture.Dispose();
							this.class98_0.EstateSellFishCapture = null;
						}
						this.class98_0.EstateSellFishCapture = new Class150(@class);
						this.class98_0.EstateSellFishBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.NewSpeciesTitle))
				{
					if (base.method_10(JoeFishCaptureSetup.string_17, JoeFishCaptureSetup.string_18, this.class98_0.NewSpeciesBounds, out @class, out @struct))
					{
						if (this.class98_0.NewSpeciesCapture != null)
						{
							this.class98_0.NewSpeciesCapture.Dispose();
							this.class98_0.NewSpeciesCapture = null;
						}
						this.class98_0.NewSpeciesCapture = new Class150(@class);
						this.class98_0.NewSpeciesBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.NewSpeciesTitleDuringBingo) && base.method_10(JoeFishCaptureSetup.string_19, JoeFishCaptureSetup.string_20, this.class98_0.NewSpeciesDuringBingoBounds, out @class, out @struct))
				{
					if (this.class98_0.NewSpeciesDuringBingoCapture != null)
					{
						this.class98_0.NewSpeciesDuringBingoCapture.Dispose();
						this.class98_0.NewSpeciesDuringBingoCapture = null;
					}
					this.class98_0.NewSpeciesDuringBingoCapture = new Class150(@class);
					this.class98_0.NewSpeciesDuringBingoBounds = @struct;
					base.FileModified = true;
				}
			}
			catch
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				throw;
			}
			this.method_14();
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00007128 File Offset: 0x00005328
		private void SelectWindowMenuItem_Click(object sender, EventArgs e)
		{
			this.class141_0.smethod_2(this, null);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0003AE8C File Offset: 0x0003908C
		private void FishCaughtButton_MouseHover(object sender, EventArgs e)
		{
			Class150 @class = null;
			Control control = null;
			if (object.ReferenceEquals(sender, this.CastButton))
			{
				@class = this.class98_0.CastCapture;
				control = this.CastButton;
			}
			else if (object.ReferenceEquals(sender, this.ExitFishingButton))
			{
				@class = this.class98_0.ExitFishingCapture;
				control = this.ExitFishingButton;
			}
			else if (object.ReferenceEquals(sender, this.FishCaughtButton))
			{
				@class = this.class98_0.FishCaughtCapture;
				control = this.FishCaughtButton;
			}
			else if (object.ReferenceEquals(sender, this.FishCaughtDuringBingoButton))
			{
				@class = this.class98_0.FishCaughtDuringBingoCapture;
				control = this.FishCaughtDuringBingoButton;
			}
			else if (object.ReferenceEquals(sender, this.BootCaughtButton))
			{
				@class = this.class98_0.BootCaughtCapture;
				control = this.BootCaughtButton;
			}
			else if (object.ReferenceEquals(sender, this.BucketFullButton))
			{
				@class = this.class98_0.BucketFullCapture;
				control = this.BucketFullButton;
			}
			else if (object.ReferenceEquals(sender, this.SellFishButton))
			{
				@class = this.class98_0.SellFishCapture;
				control = this.SellFishButton;
			}
			else if (object.ReferenceEquals(sender, this.NoBeansButton))
			{
				@class = this.class98_0.NoBeansCapture;
				control = this.NoBeansButton;
			}
			else if (object.ReferenceEquals(sender, this.EstateSellFishButton))
			{
				@class = this.class98_0.EstateSellFishCapture;
				control = this.EstateSellFishButton;
			}
			else if (object.ReferenceEquals(sender, this.NewSpeciesTitle))
			{
				@class = this.class98_0.NewSpeciesCapture;
				control = this.NewSpeciesTitle;
			}
			else if (object.ReferenceEquals(sender, this.NewSpeciesTitleDuringBingo))
			{
				@class = this.class98_0.NewSpeciesDuringBingoCapture;
				control = this.NewSpeciesTitleDuringBingo;
			}
			if (@class != null && control != null)
			{
				base.method_11(@class, control);
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00007138 File Offset: 0x00005338
		private void FishCaughtButton_MouseLeave(object sender, EventArgs e)
		{
			base.method_12();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00007140 File Offset: 0x00005340
		private void GuideHelpMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_21);
		}

		// Token: 0x04000524 RID: 1316
		private Control12 EstateSellFishButtonState;

		// Token: 0x04000525 RID: 1317
		private LinkLabel NoBeansButton;

		// Token: 0x04000526 RID: 1318
		private Control12 FishCaughtDuringBingoStatus;

		// Token: 0x04000527 RID: 1319
		private LinkLabel ExitFishingButton;

		// Token: 0x04000528 RID: 1320
		private Control12 FishCaughtState;

		// Token: 0x04000529 RID: 1321
		private LinkLabel BucketFullButton;

		// Token: 0x0400052A RID: 1322
		private Control12 NoBeansButtonState;

		// Token: 0x0400052B RID: 1323
		private Control12 NewSpeciesTitleState;

		// Token: 0x0400052C RID: 1324
		private Control12 BucketFullButtonState;

		// Token: 0x0400052D RID: 1325
		private Control12 BootCaughtButtonState;

		// Token: 0x0400052E RID: 1326
		private LinkLabel CastButton;

		// Token: 0x0400052F RID: 1327
		private LinkLabel FishCaughtDuringBingoButton;

		// Token: 0x04000530 RID: 1328
		private Control12 ExitFishingButtonState;

		// Token: 0x04000531 RID: 1329
		private Label lblContentPackTitle;

		// Token: 0x04000532 RID: 1330
		private LinkLabel FishCaughtButton;

		// Token: 0x04000533 RID: 1331
		private Control12 CastButtonState;

		// Token: 0x04000534 RID: 1332
		private Control12 SellFishButtonState;

		// Token: 0x04000535 RID: 1333
		private Label HelpDescription;

		// Token: 0x04000536 RID: 1334
		private LinkLabel SellFishButton;

		// Token: 0x04000537 RID: 1335
		private Label StatusLabel;

		// Token: 0x04000538 RID: 1336
		private PictureBox CaptureLogo;

		// Token: 0x04000539 RID: 1337
		private Label CaptureLabel;

		// Token: 0x0400053A RID: 1338
		private LinkLabel NewSpeciesTitle;

		// Token: 0x0400053B RID: 1339
		private LinkLabel EstateSellFishButton;

		// Token: 0x0400053C RID: 1340
		private Class310 JoeFishCaptureSetupPanel;

		// Token: 0x0400053D RID: 1341
		private LinkLabel BootCaughtButton;

		// Token: 0x0400053E RID: 1342
		private LinkLabel NewSpeciesTitleDuringBingo;

		// Token: 0x0400053F RID: 1343
		private Control12 NewSpeciesTitleDuringBingoState;

		// Token: 0x04000540 RID: 1344
		private Panel JoeFishCaptureSetupContainer;

		// Token: 0x04000541 RID: 1345
		private MenuStrip JoeFishCaptureSetupMenu;

		// Token: 0x04000542 RID: 1346
		private ToolStripMenuItem FileMenu;

		// Token: 0x04000543 RID: 1347
		private ToolStripMenuItem NewFileMenuItem;

		// Token: 0x04000544 RID: 1348
		private ToolStripMenuItem OpenFileMenuItem;

		// Token: 0x04000545 RID: 1349
		private ToolStripMenuItem SaveFileMenuItem;

		// Token: 0x04000546 RID: 1350
		private ToolStripMenuItem SaveAsFileMenuItem;

		// Token: 0x04000547 RID: 1351
		private ToolStripMenuItem CloseFileMenuItem;

		// Token: 0x04000548 RID: 1352
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000549 RID: 1353
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400054A RID: 1354
		private ToolStripMenuItem WindowMenu;

		// Token: 0x0400054B RID: 1355
		private ToolStripMenuItem SelectWindowMenuItem;

		// Token: 0x0400054C RID: 1356
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x0400054D RID: 1357
		private ToolStripMenuItem GuideHelpMenuItem;

		// Token: 0x0400054E RID: 1358
		private static readonly string string_0 = "Click to drag a selection rectangle around the cast button.";

		// Token: 0x0400054F RID: 1359
		private static readonly string string_1 = "Please stand on a dock.";

		// Token: 0x04000550 RID: 1360
		private static readonly string string_2 = "Click to drag a selection rectangle around the exit fishing button.";

		// Token: 0x04000551 RID: 1361
		private static readonly string string_3 = "Click to drag a selection rectangle around the button to close the fish caught panel.";

		// Token: 0x04000552 RID: 1362
		private static readonly string string_4 = "Please catch any fish.";

		// Token: 0x04000553 RID: 1363
		private static readonly string string_5 = "Click to drag a selection rectangle around the button to close the fish caught panel during bingo.";

		// Token: 0x04000554 RID: 1364
		private static readonly string string_6 = "Please catch a fish during bingo.";

		// Token: 0x04000555 RID: 1365
		private static readonly string string_7 = "Click to drag a selection rectangle around the button to close the boot caught panel.";

		// Token: 0x04000556 RID: 1366
		private static readonly string string_8 = "Please catch a boot.";

		// Token: 0x04000557 RID: 1367
		private static readonly string string_9 = "Click to drag a selection rectangle around the button to close the bucket full panel.";

		// Token: 0x04000558 RID: 1368
		private static readonly string string_10 = "Please catch fish until your bucket is full and the full bucket panel displays.";

		// Token: 0x04000559 RID: 1369
		private static readonly string string_11 = "Click to drag a selection rectangle around the button to close the sell fish panel.";

		// Token: 0x0400055A RID: 1370
		private static readonly string string_12 = "Please visit any fisherman when you have at least one fish in your bucket.";

		// Token: 0x0400055B RID: 1371
		private static readonly string string_13 = "Click to drag a selection rectangle around the button to close the no beans left panel.";

		// Token: 0x0400055C RID: 1372
		private static readonly string string_14 = "Please attempt to cast when your have no beans. (Hint: Place your beans back into your bank.)";

		// Token: 0x0400055D RID: 1373
		private static readonly string string_15 = "Click to drag a selection rectangle around the Yes button to close the sell fish panel at your estate.";

		// Token: 0x0400055E RID: 1374
		private static readonly string string_16 = "Please catch fish at your estate, until your bucket is full and the option to sell fish appears during bingo.";

		// Token: 0x0400055F RID: 1375
		private static readonly string string_17 = "Click to drag a selection rectangle around the New Species title text after catching a new fish.";

		// Token: 0x04000560 RID: 1376
		private static readonly string string_18 = "Please catch a new fish. (Hint: Create a new toon.)";

		// Token: 0x04000561 RID: 1377
		private static readonly string string_19 = "Click to drag a selection rectangle around the New Species title text after catching a new fish during bingo.";

		// Token: 0x04000562 RID: 1378
		private static readonly string string_20 = "Please catch a new fish during bingo. (Hint: Create a new toon.)";

		// Token: 0x04000563 RID: 1379
		private static readonly string string_21 = "Please enter a reference name for this capture file.";

		// Token: 0x04000564 RID: 1380
		private static readonly string string_22 = "The ToonTown Spoofer : Joe Fish Capture Setup File Name";

		// Token: 0x04000565 RID: 1381
		private static readonly string string_23 = "Joe Fish Capture Setup filename: '{0}'.";

		// Token: 0x04000566 RID: 1382
		private static readonly string string_24 = "Joe Fish : Capture Setup : New File*";

		// Token: 0x04000567 RID: 1383
		private static readonly string string_25 = "Joe Fish : Capture Setup : New File";

		// Token: 0x04000568 RID: 1384
		private static readonly string string_26 = "Joe Fish : Capture Setup : {0}*";

		// Token: 0x04000569 RID: 1385
		private static readonly string string_27 = "Joe Fish : Capture Setup : ";

		// Token: 0x0400056B RID: 1387
		private Class114 class114_0;
	}
}
