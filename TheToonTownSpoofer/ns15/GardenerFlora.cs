using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns18;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns26;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x02000215 RID: 533
	internal sealed partial class GardenerFlora : SaveForm
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x0003B1E0 File Offset: 0x000393E0
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GardenerFlora));
			this.Planters = new Panel();
			this.YellowHousePlanter = new EstatePlantDetailsSelector();
			this.PinkHousePlanter = new EstatePlantDetailsSelector();
			this.BlueHousePlanter = new EstatePlantDetailsSelector();
			this.PurpleHousePlanter = new EstatePlantDetailsSelector();
			this.GreenHousePlanter = new EstatePlantDetailsSelector();
			this.RedHousePlanter = new EstatePlantDetailsSelector();
			this.ShovelReadyLabel = new Label();
			this.AutomaticGardenerLabel = new Label();
			this.GardenerFloraTitle = new Label();
			this.BeginGardening = new Button();
			this.SelectBeanCombinationsBtn = new Button();
			this.SelectGardeningOptionsLabel = new Label();
			this.openFileDialog_1 = new OpenFileDialog();
			this.WateringCanPictureBox = new PictureBox();
			this.ShowHouseSelectorLink = new LinkLabel();
			this.GardenerFloraMenu = new MenuStrip();
			this.FileMenuItem = new ToolStripMenuItem();
			this.NewMenuItem = new ToolStripMenuItem();
			this.OpenMenuItem = new ToolStripMenuItem();
			this.OpenSaveSplitItem = new ToolStripSeparator();
			this.SaveMenuItem = new ToolStripMenuItem();
			this.SaveAsMenuItem = new ToolStripMenuItem();
			this.SaveAsCloseMenuItem = new ToolStripSeparator();
			this.CloseMenuItem = new ToolStripMenuItem();
			this.CustomizeMenuItem = new ToolStripMenuItem();
			this.CapturesMenuItem = new ToolStripMenuItem();
			this.DefaultCapturesMenuItem = new ToolStripMenuItem();
			this.CustomCapturesMenuItem = new ToolStripMenuItem();
			this.CustomCreateSplitItem = new ToolStripSeparator();
			this.CreateCapturesMenuItem = new ToolStripMenuItem();
			this.WayPointsMenuItem = new ToolStripMenuItem();
			this.DefaultWayPointsMenuItem = new ToolStripMenuItem();
			this.CustomWayPointsMenuItem = new ToolStripMenuItem();
			this.WayPointsCustomCreateSplitItem = new ToolStripSeparator();
			this.CreateWayPointsMenuItem = new ToolStripMenuItem();
			this.WayPointsSettingsSplitItem = new ToolStripSeparator();
			this.SettingsMenuItem = new ToolStripMenuItem();
			this.WindowMenuItem = new ToolStripMenuItem();
			this.SelectWindowMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideMenuItem = new ToolStripMenuItem();
			this.Planters.SuspendLayout();
			((ISupportInitialize)this.WateringCanPictureBox).BeginInit();
			this.GardenerFloraMenu.SuspendLayout();
			base.SuspendLayout();
			this.Planters.AutoScroll = true;
			this.Planters.BorderStyle = BorderStyle.Fixed3D;
			this.Planters.Controls.Add(this.YellowHousePlanter);
			this.Planters.Controls.Add(this.PinkHousePlanter);
			this.Planters.Controls.Add(this.BlueHousePlanter);
			this.Planters.Controls.Add(this.PurpleHousePlanter);
			this.Planters.Controls.Add(this.GreenHousePlanter);
			this.Planters.Controls.Add(this.RedHousePlanter);
			this.Planters.Location = new Point(266, 49);
			this.Planters.Name = "Planters";
			this.Planters.Size = new Size(367, 142);
			this.Planters.TabIndex = 1;
			this.YellowHousePlanter.BackColor = SystemColors.Control;
			this.YellowHousePlanter.Dock = DockStyle.Top;
			this.YellowHousePlanter.Location = new Point(0, 350);
			this.YellowHousePlanter.Margin = new Padding(0);
			this.YellowHousePlanter.Name = "YellowHousePlanter";
			this.YellowHousePlanter.Size = new Size(346, 70);
			this.YellowHousePlanter.TabIndex = 6;
			this.YellowHousePlanter.OnModified += this.method_12;
			this.PinkHousePlanter.BackColor = SystemColors.Control;
			this.PinkHousePlanter.Dock = DockStyle.Top;
			this.PinkHousePlanter.Location = new Point(0, 280);
			this.PinkHousePlanter.Margin = new Padding(0);
			this.PinkHousePlanter.Name = "PinkHousePlanter";
			this.PinkHousePlanter.Size = new Size(346, 70);
			this.PinkHousePlanter.TabIndex = 5;
			this.PinkHousePlanter.OnModified += this.method_12;
			this.BlueHousePlanter.BackColor = SystemColors.Control;
			this.BlueHousePlanter.Dock = DockStyle.Top;
			this.BlueHousePlanter.Location = new Point(0, 210);
			this.BlueHousePlanter.Margin = new Padding(0);
			this.BlueHousePlanter.Name = "BlueHousePlanter";
			this.BlueHousePlanter.Size = new Size(346, 70);
			this.BlueHousePlanter.TabIndex = 4;
			this.BlueHousePlanter.OnModified += this.method_12;
			this.PurpleHousePlanter.BackColor = SystemColors.Control;
			this.PurpleHousePlanter.Dock = DockStyle.Top;
			this.PurpleHousePlanter.Location = new Point(0, 140);
			this.PurpleHousePlanter.Margin = new Padding(0);
			this.PurpleHousePlanter.Name = "PurpleHousePlanter";
			this.PurpleHousePlanter.Size = new Size(346, 70);
			this.PurpleHousePlanter.TabIndex = 3;
			this.PurpleHousePlanter.OnModified += this.method_12;
			this.GreenHousePlanter.BackColor = SystemColors.Control;
			this.GreenHousePlanter.Dock = DockStyle.Top;
			this.GreenHousePlanter.Location = new Point(0, 70);
			this.GreenHousePlanter.Margin = new Padding(0);
			this.GreenHousePlanter.Name = "GreenHousePlanter";
			this.GreenHousePlanter.Size = new Size(346, 70);
			this.GreenHousePlanter.TabIndex = 2;
			this.GreenHousePlanter.OnModified += this.method_12;
			this.RedHousePlanter.BackColor = SystemColors.Control;
			this.RedHousePlanter.Dock = DockStyle.Top;
			this.RedHousePlanter.Location = new Point(0, 0);
			this.RedHousePlanter.Margin = new Padding(0);
			this.RedHousePlanter.Name = "RedHousePlanter";
			this.RedHousePlanter.Size = new Size(346, 70);
			this.RedHousePlanter.TabIndex = 2;
			this.RedHousePlanter.OnModified += this.method_12;
			this.ShovelReadyLabel.AutoSize = true;
			this.ShovelReadyLabel.Font = new Font("Segoe UI", 9f);
			this.ShovelReadyLabel.Location = new Point(91, 75);
			this.ShovelReadyLabel.Name = "ShovelReadyLabel";
			this.ShovelReadyLabel.Size = new Size(77, 15);
			this.ShovelReadyLabel.TabIndex = 13;
			this.ShovelReadyLabel.Text = "Shovel ready.";
			this.AutomaticGardenerLabel.AutoSize = true;
			this.AutomaticGardenerLabel.Font = new Font("Segoe UI", 9f);
			this.AutomaticGardenerLabel.Location = new Point(146, 57);
			this.AutomaticGardenerLabel.Name = "AutomaticGardenerLabel";
			this.AutomaticGardenerLabel.Size = new Size(114, 15);
			this.AutomaticGardenerLabel.TabIndex = 12;
			this.AutomaticGardenerLabel.Text = "Automatic Gardener";
			this.GardenerFloraTitle.AutoSize = true;
			this.GardenerFloraTitle.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.GardenerFloraTitle.Location = new Point(9, 49);
			this.GardenerFloraTitle.Name = "GardenerFloraTitle";
			this.GardenerFloraTitle.Size = new Size(139, 26);
			this.GardenerFloraTitle.TabIndex = 11;
			this.GardenerFloraTitle.Text = "Gardener Flora";
			this.BeginGardening.Image = (Image)componentResourceManager.GetObject("BeginGardening.Image");
			this.BeginGardening.ImageAlign = ContentAlignment.MiddleRight;
			this.BeginGardening.Location = new Point(8, 158);
			this.BeginGardening.Name = "BeginGardening";
			this.BeginGardening.Size = new Size(252, 33);
			this.BeginGardening.TabIndex = 15;
			this.BeginGardening.Text = "Begin Gardening";
			this.BeginGardening.UseVisualStyleBackColor = true;
			this.BeginGardening.Click += this.BeginGardening_Click;
			this.SelectBeanCombinationsBtn.Image = (Image)componentResourceManager.GetObject("SelectBeanCombinationsBtn.Image");
			this.SelectBeanCombinationsBtn.ImageAlign = ContentAlignment.MiddleRight;
			this.SelectBeanCombinationsBtn.Location = new Point(8, 119);
			this.SelectBeanCombinationsBtn.Name = "SelectBeanCombinationsBtn";
			this.SelectBeanCombinationsBtn.Size = new Size(252, 33);
			this.SelectBeanCombinationsBtn.TabIndex = 15;
			this.SelectBeanCombinationsBtn.Text = "Select Bean Combinations";
			this.SelectBeanCombinationsBtn.UseVisualStyleBackColor = true;
			this.SelectBeanCombinationsBtn.Click += this.SelectBeanCombinationsBtn_Click;
			this.SelectGardeningOptionsLabel.AutoSize = true;
			this.SelectGardeningOptionsLabel.Font = new Font("Segoe UI", 9f);
			this.SelectGardeningOptionsLabel.Location = new Point(265, 31);
			this.SelectGardeningOptionsLabel.Name = "SelectGardeningOptionsLabel";
			this.SelectGardeningOptionsLabel.Size = new Size(141, 15);
			this.SelectGardeningOptionsLabel.TabIndex = 12;
			this.SelectGardeningOptionsLabel.Text = "Select gardening options:";
			this.openFileDialog_1.Filter = "Gardener Flora Way Point Settings|*.gfwps";
			this.WateringCanPictureBox.Image = (Image)componentResourceManager.GetObject("WateringCanPictureBox.Image");
			this.WateringCanPictureBox.Location = new Point(167, 73);
			this.WateringCanPictureBox.Name = "WateringCanPictureBox";
			this.WateringCanPictureBox.Size = new Size(35, 18);
			this.WateringCanPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			this.WateringCanPictureBox.TabIndex = 16;
			this.WateringCanPictureBox.TabStop = false;
			this.ShowHouseSelectorLink.AutoSize = true;
			this.ShowHouseSelectorLink.Location = new Point(412, 32);
			this.ShowHouseSelectorLink.Name = "ShowHouseSelectorLink";
			this.ShowHouseSelectorLink.Size = new Size(183, 13);
			this.ShowHouseSelectorLink.TabIndex = 17;
			this.ShowHouseSelectorLink.TabStop = true;
			this.ShowHouseSelectorLink.Text = "How do I know which house is mine?";
			this.ShowHouseSelectorLink.LinkClicked += this.ShowHouseSelectorLink_LinkClicked;
			this.GardenerFloraMenu.Items.AddRange(new ToolStripItem[]
			{
				this.FileMenuItem,
				this.CustomizeMenuItem,
				this.WindowMenuItem,
				this.HelpMenuItem
			});
			this.GardenerFloraMenu.Location = new Point(0, 0);
			this.GardenerFloraMenu.Name = "GardenerFloraMenu";
			this.GardenerFloraMenu.Size = new Size(640, 24);
			this.GardenerFloraMenu.TabIndex = 18;
			this.GardenerFloraMenu.Text = "menuStrip1";
			this.FileMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NewMenuItem,
				this.OpenMenuItem,
				this.OpenSaveSplitItem,
				this.SaveMenuItem,
				this.SaveAsMenuItem,
				this.SaveAsCloseMenuItem,
				this.CloseMenuItem
			});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new Size(37, 20);
			this.FileMenuItem.Text = "&File";
			this.NewMenuItem.Name = "NewMenuItem";
			this.NewMenuItem.ShortcutKeys = (Keys)131150;
			this.NewMenuItem.Size = new Size(192, 22);
			this.NewMenuItem.Text = "&New";
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.ShortcutKeys = (Keys)131151;
			this.OpenMenuItem.Size = new Size(192, 22);
			this.OpenMenuItem.Text = "&Open";
			this.OpenSaveSplitItem.Name = "OpenSaveSplitItem";
			this.OpenSaveSplitItem.Size = new Size(189, 6);
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.ShortcutKeys = (Keys)131155;
			this.SaveMenuItem.Size = new Size(192, 22);
			this.SaveMenuItem.Text = "&Save";
			this.SaveAsMenuItem.Name = "SaveAsMenuItem";
			this.SaveAsMenuItem.ShortcutKeys = (Keys)196691;
			this.SaveAsMenuItem.Size = new Size(192, 22);
			this.SaveAsMenuItem.Text = "Save &As..";
			this.SaveAsCloseMenuItem.Name = "SaveAsCloseMenuItem";
			this.SaveAsCloseMenuItem.Size = new Size(189, 6);
			this.CloseMenuItem.Name = "CloseMenuItem";
			this.CloseMenuItem.ShortcutKeys = (Keys)131159;
			this.CloseMenuItem.Size = new Size(192, 22);
			this.CloseMenuItem.Text = "&Close";
			this.CustomizeMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.CapturesMenuItem,
				this.WayPointsMenuItem,
				this.WayPointsSettingsSplitItem,
				this.SettingsMenuItem
			});
			this.CustomizeMenuItem.Name = "CustomizeMenuItem";
			this.CustomizeMenuItem.Size = new Size(75, 20);
			this.CustomizeMenuItem.Text = "&Customize";
			this.CapturesMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.DefaultCapturesMenuItem,
				this.CustomCapturesMenuItem,
				this.CustomCreateSplitItem,
				this.CreateCapturesMenuItem
			});
			this.CapturesMenuItem.Name = "CapturesMenuItem";
			this.CapturesMenuItem.Size = new Size(152, 22);
			this.CapturesMenuItem.Text = "&Captures";
			this.DefaultCapturesMenuItem.Checked = true;
			this.DefaultCapturesMenuItem.CheckState = CheckState.Checked;
			this.DefaultCapturesMenuItem.Name = "DefaultCapturesMenuItem";
			this.DefaultCapturesMenuItem.Size = new Size(116, 22);
			this.DefaultCapturesMenuItem.Text = "&Default";
			this.DefaultCapturesMenuItem.Click += this.DefaultCapturesMenuItem_Click;
			this.CustomCapturesMenuItem.Name = "CustomCapturesMenuItem";
			this.CustomCapturesMenuItem.Size = new Size(116, 22);
			this.CustomCapturesMenuItem.Text = "&Custom";
			this.CustomCapturesMenuItem.Click += this.CustomCapturesMenuItem_Click;
			this.CustomCreateSplitItem.Name = "CustomCreateSplitItem";
			this.CustomCreateSplitItem.Size = new Size(113, 6);
			this.CreateCapturesMenuItem.Name = "CreateCapturesMenuItem";
			this.CreateCapturesMenuItem.Size = new Size(116, 22);
			this.CreateCapturesMenuItem.Text = "C&reate";
			this.CreateCapturesMenuItem.Click += this.CreateCapturesMenuItem_Click;
			this.WayPointsMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.DefaultWayPointsMenuItem,
				this.CustomWayPointsMenuItem,
				this.WayPointsCustomCreateSplitItem,
				this.CreateWayPointsMenuItem
			});
			this.WayPointsMenuItem.Name = "WayPointsMenuItem";
			this.WayPointsMenuItem.Size = new Size(152, 22);
			this.WayPointsMenuItem.Text = "&Way Points";
			this.DefaultWayPointsMenuItem.Checked = true;
			this.DefaultWayPointsMenuItem.CheckState = CheckState.Checked;
			this.DefaultWayPointsMenuItem.Name = "DefaultWayPointsMenuItem";
			this.DefaultWayPointsMenuItem.Size = new Size(116, 22);
			this.DefaultWayPointsMenuItem.Text = "&Default";
			this.DefaultWayPointsMenuItem.Click += this.DefaultWayPointsMenuItem_Click;
			this.CustomWayPointsMenuItem.Name = "CustomWayPointsMenuItem";
			this.CustomWayPointsMenuItem.Size = new Size(116, 22);
			this.CustomWayPointsMenuItem.Text = "&Custom";
			this.CustomWayPointsMenuItem.Click += this.CustomWayPointsMenuItem_Click;
			this.WayPointsCustomCreateSplitItem.Name = "WayPointsCustomCreateSplitItem";
			this.WayPointsCustomCreateSplitItem.Size = new Size(113, 6);
			this.CreateWayPointsMenuItem.Name = "CreateWayPointsMenuItem";
			this.CreateWayPointsMenuItem.Size = new Size(116, 22);
			this.CreateWayPointsMenuItem.Text = "C&reate";
			this.CreateWayPointsMenuItem.Click += this.CreateWayPointsMenuItem_Click;
			this.WayPointsSettingsSplitItem.Name = "WayPointsSettingsSplitItem";
			this.WayPointsSettingsSplitItem.Size = new Size(149, 6);
			this.SettingsMenuItem.Name = "SettingsMenuItem";
			this.SettingsMenuItem.Size = new Size(152, 22);
			this.SettingsMenuItem.Text = "&Settings";
			this.SettingsMenuItem.Click += this.SettingsMenuItem_Click;
			this.WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.SelectWindowMenuItem
			});
			this.WindowMenuItem.Name = "WindowMenuItem";
			this.WindowMenuItem.Size = new Size(63, 20);
			this.WindowMenuItem.Text = "&Window";
			this.SelectWindowMenuItem.Name = "SelectWindowMenuItem";
			this.SelectWindowMenuItem.Size = new Size(213, 22);
			this.SelectWindowMenuItem.Text = "&Select ToonTown Window";
			this.SelectWindowMenuItem.Click += this.SelectWindowMenuItem_Click;
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
			base.ClientSize = new Size(640, 198);
			base.Controls.Add(this.ShowHouseSelectorLink);
			base.Controls.Add(this.WateringCanPictureBox);
			base.Controls.Add(this.SelectBeanCombinationsBtn);
			base.Controls.Add(this.BeginGardening);
			base.Controls.Add(this.ShovelReadyLabel);
			base.Controls.Add(this.SelectGardeningOptionsLabel);
			base.Controls.Add(this.AutomaticGardenerLabel);
			base.Controls.Add(this.GardenerFloraTitle);
			base.Controls.Add(this.Planters);
			base.Controls.Add(this.GardenerFloraMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.GardenerFloraMenu;
			base.MaximizeBox = false;
			base.Name = "GardenerFlora";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer Presents : Gardener Flora : New File";
			this.Planters.ResumeLayout(false);
			((ISupportInitialize)this.WateringCanPictureBox).EndInit();
			this.GardenerFloraMenu.ResumeLayout(false);
			this.GardenerFloraMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0003C610 File Offset: 0x0003A810
		public GardenerFlora()
		{
			this.InitializeComponent_1();
			this.class114_0 = Class110.Instance.GardenerFloraSettings.GardenerFloraFiles;
			this.class141_0 = new Class141();
			this.houseColorDisplay_0 = new HouseColorDisplay();
			this.class359_0 = new Class359(this.houseColorDisplay_0);
			HouseColorDisplay houseColorDisplay = this.houseColorDisplay_0;
			EventHandler value = new EventHandler(this.method_18);
			houseColorDisplay.ClosePopup += value;
			this.NewMenuItem.Click += base.method_0;
			this.OpenMenuItem.Click += base.method_1;
			this.SaveMenuItem.Click += base.method_2;
			this.SaveAsMenuItem.Click += base.method_3;
			this.CloseMenuItem.Click += base.method_4;
			base.method_5();
			string customCaptureFile = Class110.Instance.GardenerFloraSettings.CustomCaptureFile;
			if (!string.IsNullOrEmpty(customCaptureFile) && File.Exists(customCaptureFile))
			{
				if (!this.method_14(customCaptureFile))
				{
					this.method_13(true);
				}
			}
			else
			{
				this.method_13(true);
			}
			string customWayPointSettings = Class110.Instance.GardenerFloraSettings.CustomWayPointSettings;
			if (!string.IsNullOrEmpty(customWayPointSettings) && File.Exists(customWayPointSettings))
			{
				if (!this.method_16(customWayPointSettings))
				{
					this.method_15(true);
				}
				return;
			}
			this.method_15(true);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0003C76C File Offset: 0x0003A96C
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (Class524.smethod_0(fileName, null))
			{
				if (modified)
				{
					this.Text = "The ToonTown Spoofer Presents : Gardener Flora : New File*";
					return;
				}
				this.Text = "The ToonTown Spoofer Presents : Gardener Flora : New File";
				return;
			}
			else
			{
				if (modified)
				{
					this.Text = string.Format("The ToonTown Spoofer Presents : Gardener Flora : {0}*", fileName.string_0);
					return;
				}
				this.Text = "The ToonTown Spoofer Presents : Gardener Flora : " + fileName.string_0;
				return;
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00007149 File Offset: 0x00005349
		protected override void vmethod_0()
		{
			this.class113_0 = new Class113();
			this.method_11();
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0003C7D0 File Offset: 0x0003A9D0
		protected override bool vmethod_6(out Class524 fileName)
		{
			Class524 @class;
			bool result;
			if (result = Class460.smethod_4(out @class))
			{
				fileName = @class;
			}
			else
			{
				fileName = null;
			}
			return result;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		protected override bool vmethod_5(Class524 fileName)
		{
			bool result;
			try
			{
				Class113 @class = new Class113(fileName.string_1);
				this.class113_0 = @class;
				this.method_11();
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format("Gardener Flora filename: '{0}'.", fileName.string_1)
				});
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0003C864 File Offset: 0x0003AA64
		protected override bool vmethod_3(out Class524 filePath)
		{
			using (StringInputForm stringInputForm = new StringInputForm())
			{
				stringInputForm.LabelMessage = "Please enter a reference name for this flora file.";
				stringInputForm.Text = "The ToonTown Spoofer : Gardener Flora File Name";
				if (stringInputForm.ShowDialog() == DialogResult.OK)
				{
					filePath = new Class524(stringInputForm.Value, Class266.smethod_2(Class291.GardenerFloraEstateSettings, ".flora"));
					return true;
				}
			}
			filePath = null;
			return false;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0000715C File Offset: 0x0000535C
		protected override void vmethod_1(Class524 fileName)
		{
			this.method_10(fileName);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class113_0.method_1(fileName.string_1);
				this.method_10(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00007165 File Offset: 0x00005365
		private void method_10(Class524 fileName)
		{
			if (!this.class114_0.Files.Contains(fileName))
			{
				this.class114_0.Files.Add(fileName);
				Class110.smethod_1();
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0003C924 File Offset: 0x0003AB24
		private void method_11()
		{
			this.BlueHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_3];
			this.GreenHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_1];
			this.PinkHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_4];
			this.PurpleHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_2];
			this.RedHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_0];
			this.YellowHousePlanter.FloraEstatePlantingDetails = this.class113_0.EstatePlantSettings[Enum13.const_5];
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00007191 File Offset: 0x00005391
		private void method_12(object sender, EventArgs e)
		{
			base.FileModified = true;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0003C9DC File Offset: 0x0003ABDC
		private void SelectBeanCombinationsBtn_Click(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (BeanCombinations beanCombinations = new BeanCombinations())
				{
					@class.method_0(beanCombinations);
					beanCombinations.PlantMethod = this.class113_0.PlantMethod;
					beanCombinations.CheckedBeanCombinations = this.class113_0.BeanCombinations;
					if (beanCombinations.ShowDialog() == DialogResult.OK)
					{
						this.class113_0.PlantMethod = beanCombinations.PlantMethod;
						this.class113_0.BeanCombinations.Clear();
						this.class113_0.BeanCombinations.AddRange(beanCombinations.CheckedBeanCombinations);
					}
				}
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0000719A File Offset: 0x0000539A
		private void DefaultCapturesMenuItem_Click(object sender, EventArgs e)
		{
			this.method_13(true);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0003CA94 File Offset: 0x0003AC94
		private void CustomCapturesMenuItem_Click(object sender, EventArgs e)
		{
			Class524 @class;
			if (Class460.smethod_3(out @class))
			{
				if (this.method_14(@class.string_1))
				{
					Class110.Instance.GardenerFloraSettings.CustomCaptureFile = @class.string_1;
					return;
				}
				this.method_13(false);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		private static bool smethod_0(Class88 settings)
		{
			return settings.FinalPlantCapture != null && settings.NoWaterCapture != null && settings.PickFlowerCapture != null && settings.PlantFailedCapture != null && settings.PlantFlowerCapture != null && settings.PlantSuccessCapture != null && settings.WaterPlantCapture != null && settings.BasketFullCapture != null && settings.SellFlowersCapture != null && settings.DisabledBeanSlotCapture != null && settings.FinalPickCapture != null && settings.CancelPlantCapture != null;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0003CB4C File Offset: 0x0003AD4C
		private void method_13(bool displayErrorIfFailure)
		{
			Class110.Instance.GardenerFloraSettings.CustomCaptureFile = null;
			if (File.Exists(Class291.string_19))
			{
				bool flag = false;
				Class88 @class = null;
				try
				{
					@class = new Class88(Class291.string_19);
					flag = true;
				}
				catch (Exception ex)
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					@class = null;
					if (displayErrorIfFailure)
					{
						ex.smethod_1(new object[]
						{
							Class291.string_19
						});
					}
				}
				if (flag && GardenerFlora.smethod_0(@class))
				{
					if (this.class88_0 != null)
					{
						this.class88_0.Dispose();
					}
					this.class88_0 = @class;
					this.DefaultCapturesMenuItem.Checked = true;
					this.CustomCapturesMenuItem.Checked = false;
					return;
				}
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				this.DefaultCapturesMenuItem.Checked = false;
				this.CustomCapturesMenuItem.Checked = false;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3("The default Gardener Flora Capture Setup file appears to be incomplete, altered or invalid, reinstalling may fix this issue.", "Incomplete Capture File");
					return;
				}
			}
			else
			{
				if (this.class88_0 != null)
				{
					this.class88_0.Dispose();
				}
				this.class88_0 = null;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3("The default Gardener Flora Capture Setup file appears to be missing. Reinstalling may fix this issue or you can customize captures by creating your own file.", "Missing Settings");
				}
				this.DefaultCapturesMenuItem.Checked = false;
				this.CustomCapturesMenuItem.Checked = false;
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0003CC7C File Offset: 0x0003AE7C
		private bool method_14(string filePath)
		{
			Class88 @class = null;
			bool flag = false;
			try
			{
				@class = new Class88(filePath);
				flag = true;
			}
			catch (Exception ex)
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				ex.smethod_1(new object[]
				{
					string.Format("Gardener Flora Capture Setup filename: '{0}'.", filePath)
				});
				DialogBox.smethod_7(ex, filePath);
			}
			if (flag && GardenerFlora.smethod_0(@class))
			{
				if (this.class88_0 != null)
				{
					this.class88_0.Dispose();
				}
				this.class88_0 = @class;
				this.CustomCapturesMenuItem.Checked = true;
				this.DefaultCapturesMenuItem.Checked = false;
				return true;
			}
			if (@class != null)
			{
				@class.Dispose();
			}
			@class = null;
			DialogBox.smethod_3("This Gardener Flora Capture Setup file is incomplete and cannot be used. Please setup all the captures before attempting to use with Gardener Flora.", "Incomplete Capture File");
			return false;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0003CD34 File Offset: 0x0003AF34
		private void CreateCapturesMenuItem_Click(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (GardenerFloraCaptureSetup gardenerFloraCaptureSetup = new GardenerFloraCaptureSetup())
				{
					@class.method_0(gardenerFloraCaptureSetup);
					gardenerFloraCaptureSetup.ShowDialog();
				}
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0003CD90 File Offset: 0x0003AF90
		private void method_15(bool displayErrorIfFailure)
		{
			Class110.Instance.GardenerFloraSettings.CustomWayPointSettings = null;
			if (File.Exists(Class291.string_21))
			{
				bool flag;
				try
				{
					this.class90_0 = new Class90(Class291.string_21);
					flag = true;
				}
				catch (Exception ex)
				{
					this.class90_0 = null;
					if (displayErrorIfFailure)
					{
						DialogBox.smethod_7(ex, Class291.string_21);
					}
					flag = false;
				}
				if (flag && GardenerFlora.smethod_1(this.class90_0))
				{
					this.DefaultWayPointsMenuItem.Checked = true;
					this.CustomWayPointsMenuItem.Checked = false;
					return;
				}
				this.class90_0 = null;
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = false;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3("The default Gardener Flora way point settings file appears to be incomplete, altered or invalid, reinstalling may fix this issue. Note: a valid Gardener Flora way point file contains all flowers and trees for all houses and the wheelbarrow for general navigation.", "Incomplete Way Point File");
					return;
				}
			}
			else
			{
				this.class90_0 = null;
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = false;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3("The default Gardener Flora way point settings file appears to be missing. Gardener Flora cannot run without a way point settings file. Reinstalling should fix this issue or you can create your own.", "Way Point Settings File Missing");
				}
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0003CE88 File Offset: 0x0003B088
		private bool method_16(string filePath)
		{
			bool flag;
			try
			{
				this.class90_0 = new Class90(filePath);
				flag = true;
			}
			catch (Exception ex)
			{
				this.class90_0 = null;
				DialogBox.smethod_7(ex, filePath);
				flag = false;
			}
			if (flag && GardenerFlora.smethod_1(this.class90_0))
			{
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = true;
				return true;
			}
			DialogBox.smethod_3("This Gardener Flora way point settings file appears to be incomplete, altered or invalid, reinstalling may fix this issue. Note: a valid Gardener Flora way point file contains all flowers and trees for all houses and the wheelbarrow for general navigation.", "Incomplete Way Point File");
			return false;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0003CF04 File Offset: 0x0003B104
		private static bool smethod_1(Class90 settings)
		{
			return settings != null && settings.HasCategories && (GardenerFlora.smethod_2(settings[Enum85.const_3]) && GardenerFlora.smethod_2(settings[Enum85.const_1]) && GardenerFlora.smethod_2(settings[Enum85.const_4]) && GardenerFlora.smethod_2(settings[Enum85.const_2]) && GardenerFlora.smethod_2(settings[Enum85.const_0]) && GardenerFlora.smethod_2(settings[Enum85.const_5])) && settings[Enum85.const_6].WayPoints.ContainsKey(Enum57.const_1) && settings[Enum85.const_6].WayPoints[Enum57.const_1].smethod_3(new Enum99[]
			{
				Enum99.flag_23
			});
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		private static bool smethod_2(Class101 settings)
		{
			return settings.WayPoints.ContainsKey(Enum57.const_1) && settings.WayPoints[Enum57.const_1].smethod_3(new Enum99[]
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
				Enum99.flag_14,
				Enum99.flag_15,
				Enum99.flag_16,
				Enum99.flag_17,
				Enum99.flag_18,
				Enum99.flag_19,
				Enum99.flag_20,
				Enum99.flag_21,
				Enum99.flag_22
			});
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000071A3 File Offset: 0x000053A3
		private void DefaultWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			this.method_15(true);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0003D07C File Offset: 0x0003B27C
		private void CustomWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				Class110.Instance.GardenerFloraSettings.CustomWayPointSettings = string.Empty;
				if (this.method_16(this.openFileDialog_1.FileName))
				{
					Class110.Instance.GardenerFloraSettings.CustomWayPointSettings = this.openFileDialog_1.FileName;
					return;
				}
				this.method_15(false);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		private void CreateWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (GardenerFloraWayPointEditor gardenerFloraWayPointEditor = new GardenerFloraWayPointEditor())
				{
					@class.method_0(gardenerFloraWayPointEditor);
					gardenerFloraWayPointEditor.ShowDialog();
				}
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000071AC File Offset: 0x000053AC
		private void SelectWindowMenuItem_Click(object sender, EventArgs e)
		{
			this.class141_0.smethod_2(this, null);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0003D13C File Offset: 0x0003B33C
		private bool method_17()
		{
			if (!this.class141_0.ProcessOpen && !this.class141_0.smethod_1(this))
			{
				return false;
			}
			if (this.class88_0 == null)
			{
				DialogBox.smethod_3("There is no Gardener Flora Capture Setup file loaded. Please load a file or reinstall The ToonTown Spoofer to restore the default file.", "No Capture File Loaded");
				return false;
			}
			if (this.class90_0 == null)
			{
				DialogBox.smethod_3("Gardener Flora cannot run without a way point settings file.", "No Way Point Settings File Loaded");
				return false;
			}
			bool flag = false;
			foreach (Class94 @class in this.class113_0.EstatePlantSettings.Values)
			{
				if (@class.Enabled)
				{
					if (@class.Customized)
					{
						foreach (Class109 class2 in @class.Trees.Values)
						{
							if (class2.Enabled && class2.Water && class2.WaterCount > 0)
							{
								flag = true;
								break;
							}
						}
						using (Dictionary<Enum99, Class93>.ValueCollection.Enumerator enumerator3 = @class.Flowers.Values.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								Class93 class3 = enumerator3.Current;
								if (class3.Enabled && ((class3.Water && class3.WaterCount > 0) || class3.Pick || class3.Plant))
								{
									flag = true;
									IL_132:
									goto IL_174;
								}
							}
							goto IL_132;
						}
					}
					if ((@class.GardenTrees && @class.Water) || (@class.GardenFlowers && (@class.Pick || @class.Plant || @class.Water)))
					{
						flag = true;
					}
				}
				IL_174:
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				DialogBox.smethod_3("Please enabled estates, flowers or trees to be picked, planted or watered.", "Nothing To Do");
				return false;
			}
			return true;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0003D340 File Offset: 0x0003B540
		private void BeginGardening_Click(object sender, EventArgs e)
		{
			if (!this.method_17())
			{
				return;
			}
			using (Class499 @class = new Class499(this))
			{
				using (GardenerFloraRunning gardenerFloraRunning = new GardenerFloraRunning(this.class141_0.MainWindowHandle, this.class113_0, this.class88_0, this.class90_0))
				{
					@class.method_0(gardenerFloraRunning);
					gardenerFloraRunning.ShowDialog();
				}
			}
			this.class88_0.method_4();
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000071BC File Offset: 0x000053BC
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_4);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000071C4 File Offset: 0x000053C4
		private void ShowHouseSelectorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.class359_0.method_1(this.ShowHouseSelectorLink);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		private void SettingsMenuItem_Click(object sender, EventArgs e)
		{
			using (GardenerFloraSettingsForm gardenerFloraSettingsForm = new GardenerFloraSettingsForm())
			{
				if (gardenerFloraSettingsForm.ShowDialog() == DialogResult.OK)
				{
					Class110.smethod_1();
				}
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000071D7 File Offset: 0x000053D7
		[CompilerGenerated]
		private void method_18(object sender, EventArgs e)
		{
			this.class359_0.Close();
		}

		// Token: 0x0400056D RID: 1389
		private EstatePlantDetailsSelector GreenHousePlanter;

		// Token: 0x0400056E RID: 1390
		private EstatePlantDetailsSelector PurpleHousePlanter;

		// Token: 0x0400056F RID: 1391
		private EstatePlantDetailsSelector BlueHousePlanter;

		// Token: 0x04000570 RID: 1392
		private EstatePlantDetailsSelector PinkHousePlanter;

		// Token: 0x04000571 RID: 1393
		private EstatePlantDetailsSelector YellowHousePlanter;

		// Token: 0x04000572 RID: 1394
		private Panel Planters;

		// Token: 0x04000573 RID: 1395
		private EstatePlantDetailsSelector RedHousePlanter;

		// Token: 0x04000574 RID: 1396
		private Label ShovelReadyLabel;

		// Token: 0x04000575 RID: 1397
		private Label AutomaticGardenerLabel;

		// Token: 0x04000576 RID: 1398
		private Label GardenerFloraTitle;

		// Token: 0x04000577 RID: 1399
		private Button BeginGardening;

		// Token: 0x04000578 RID: 1400
		private Button SelectBeanCombinationsBtn;

		// Token: 0x04000579 RID: 1401
		private Label SelectGardeningOptionsLabel;

		// Token: 0x0400057A RID: 1402
		private OpenFileDialog openFileDialog_1;

		// Token: 0x0400057B RID: 1403
		private PictureBox WateringCanPictureBox;

		// Token: 0x0400057C RID: 1404
		private LinkLabel ShowHouseSelectorLink;

		// Token: 0x0400057D RID: 1405
		private MenuStrip GardenerFloraMenu;

		// Token: 0x0400057E RID: 1406
		private ToolStripMenuItem FileMenuItem;

		// Token: 0x0400057F RID: 1407
		private ToolStripMenuItem NewMenuItem;

		// Token: 0x04000580 RID: 1408
		private ToolStripMenuItem OpenMenuItem;

		// Token: 0x04000581 RID: 1409
		private ToolStripSeparator OpenSaveSplitItem;

		// Token: 0x04000582 RID: 1410
		private ToolStripMenuItem SaveMenuItem;

		// Token: 0x04000583 RID: 1411
		private ToolStripMenuItem SaveAsMenuItem;

		// Token: 0x04000584 RID: 1412
		private ToolStripSeparator SaveAsCloseMenuItem;

		// Token: 0x04000585 RID: 1413
		private ToolStripMenuItem CloseMenuItem;

		// Token: 0x04000586 RID: 1414
		private ToolStripMenuItem CustomizeMenuItem;

		// Token: 0x04000587 RID: 1415
		private ToolStripMenuItem CapturesMenuItem;

		// Token: 0x04000588 RID: 1416
		private ToolStripMenuItem DefaultCapturesMenuItem;

		// Token: 0x04000589 RID: 1417
		private ToolStripMenuItem CustomCapturesMenuItem;

		// Token: 0x0400058A RID: 1418
		private ToolStripSeparator CustomCreateSplitItem;

		// Token: 0x0400058B RID: 1419
		private ToolStripMenuItem CreateCapturesMenuItem;

		// Token: 0x0400058C RID: 1420
		private ToolStripMenuItem WayPointsMenuItem;

		// Token: 0x0400058D RID: 1421
		private ToolStripMenuItem DefaultWayPointsMenuItem;

		// Token: 0x0400058E RID: 1422
		private ToolStripMenuItem CustomWayPointsMenuItem;

		// Token: 0x0400058F RID: 1423
		private ToolStripSeparator WayPointsCustomCreateSplitItem;

		// Token: 0x04000590 RID: 1424
		private ToolStripMenuItem CreateWayPointsMenuItem;

		// Token: 0x04000591 RID: 1425
		private ToolStripSeparator WayPointsSettingsSplitItem;

		// Token: 0x04000592 RID: 1426
		private ToolStripMenuItem SettingsMenuItem;

		// Token: 0x04000593 RID: 1427
		private ToolStripMenuItem WindowMenuItem;

		// Token: 0x04000594 RID: 1428
		private ToolStripMenuItem SelectWindowMenuItem;

		// Token: 0x04000595 RID: 1429
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x04000596 RID: 1430
		private ToolStripMenuItem GuideMenuItem;

		// Token: 0x04000597 RID: 1431
		private Class113 class113_0;

		// Token: 0x04000599 RID: 1433
		private Class90 class90_0;

		// Token: 0x0400059D RID: 1437
		private Class114 class114_0;
	}
}
