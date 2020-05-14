using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns20;
using ns21;
using ns28;
using ns29;
using ns31;

namespace ns18
{
	// Token: 0x02000297 RID: 663
	internal sealed partial class GardenerFloraWayPointEditor : SaveForm
	{
		// Token: 0x06001B5C RID: 7004 RVA: 0x00054AA4 File Offset: 0x00052CA4
		public GardenerFloraWayPointEditor()
		{
			this.InitializeComponent_1();
			this.vmethod_0();
			this.NewMenuItem.Click += base.method_0;
			this.OpenMenuItem.Click += base.method_1;
			this.SaveAsMenuItem.Click += base.method_3;
			this.SaveMenuItem.Click += base.method_2;
			this.CloseMenuItem.Click += base.method_4;
			this.dictionary_0 = new Dictionary<object, Enum85>();
			this.dictionary_0.Add(this.EditBlueHouse, Enum85.const_3);
			this.dictionary_0.Add(this.EditGeneralNavigation, Enum85.const_6);
			this.dictionary_0.Add(this.EditGreenHouse, Enum85.const_1);
			this.dictionary_0.Add(this.EditPinkHouse, Enum85.const_4);
			this.dictionary_0.Add(this.EditPurpleHouse, Enum85.const_2);
			this.dictionary_0.Add(this.EditRedHouse, Enum85.const_0);
			this.dictionary_0.Add(this.EditYellowHouse, Enum85.const_5);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00054BC0 File Offset: 0x00052DC0
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (modified)
			{
				if (Class524.smethod_0(fileName, null))
				{
					this.Text = "Gardener Flora : WayPoint Setup : New File*";
					return;
				}
				this.Text = string.Format("Gardener Flora : WayPoint Setup : {0}*", Path.GetFileName(fileName.string_1));
				return;
			}
			else
			{
				if (Class524.smethod_0(fileName, null))
				{
					this.Text = "Gardener Flora : WayPoint Setup : New File";
					return;
				}
				this.Text = "Gardener Flora : WayPoint Setup : " + Path.GetFileName(fileName.string_1);
				return;
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00009FAD File Offset: 0x000081AD
		protected override void vmethod_0()
		{
			this.class90_0 = new Class90();
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00054C34 File Offset: 0x00052E34
		protected override bool vmethod_5(Class524 path)
		{
			bool result;
			try
			{
				Class90 @class = new Class90(path.string_1);
				this.class90_0 = @class;
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, path.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00054C7C File Offset: 0x00052E7C
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class90_0.method_1(fileName.string_1);
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00054CC0 File Offset: 0x00052EC0
		private void EditGeneralNavigation_Click(object sender, EventArgs e)
		{
			if (!this.dictionary_0.ContainsKey(sender))
			{
				return;
			}
			Enum85 @enum = this.dictionary_0[sender];
			using (Class499 @class = new Class499(this))
			{
				using (WayPointEditor wayPointEditor = new WayPointEditor(this.class90_0[@enum]))
				{
					@class.method_0(wayPointEditor);
					wayPointEditor.Text = "WayPoint Editor : " + @enum.smethod_2();
					wayPointEditor.ShowDialog();
					if (wayPointEditor.FileModified)
					{
						base.FileModified = true;
					}
				}
			}
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00009249 File Offset: 0x00007449
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_14);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00054D6C File Offset: 0x00052F6C
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GardenerFloraWayPointEditor));
			this.EditRedHouse = new Button();
			this.EditGreenHouse = new Button();
			this.EditPurpleHouse = new Button();
			this.EditBlueHouse = new Button();
			this.EditPinkHouse = new Button();
			this.EditYellowHouse = new Button();
			this.EditGeneralNavigation = new Button();
			this.HelpDescription = new Label();
			this.GardenerFloraWayPointEditorMenu = new MenuStrip();
			this.FileMenuItem = new ToolStripMenuItem();
			this.NewMenuItem = new ToolStripMenuItem();
			this.OpenMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.SaveMenuItem = new ToolStripMenuItem();
			this.SaveAsMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.CloseMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideMenuItem = new ToolStripMenuItem();
			this.GardenerFloraWayPointEditorMenu.SuspendLayout();
			base.SuspendLayout();
			this.saveFileDialog_0.Filter = "Gardener Flora WayPoint Settings|*.gfwps";
			this.openFileDialog_0.Filter = "Gardener Flora WayPoint Settings|*.gfwps";
			this.EditRedHouse.Location = new Point(13, 55);
			this.EditRedHouse.Name = "EditRedHouse";
			this.EditRedHouse.Size = new Size(196, 23);
			this.EditRedHouse.TabIndex = 0;
			this.EditRedHouse.Text = "Red House";
			this.EditRedHouse.UseVisualStyleBackColor = true;
			this.EditRedHouse.Click += this.EditGeneralNavigation_Click;
			this.EditGreenHouse.Location = new Point(13, 84);
			this.EditGreenHouse.Name = "EditGreenHouse";
			this.EditGreenHouse.Size = new Size(196, 23);
			this.EditGreenHouse.TabIndex = 1;
			this.EditGreenHouse.Text = "Green House";
			this.EditGreenHouse.UseVisualStyleBackColor = true;
			this.EditGreenHouse.Click += this.EditGeneralNavigation_Click;
			this.EditPurpleHouse.Location = new Point(13, 113);
			this.EditPurpleHouse.Name = "EditPurpleHouse";
			this.EditPurpleHouse.Size = new Size(196, 23);
			this.EditPurpleHouse.TabIndex = 2;
			this.EditPurpleHouse.Text = "Purple House";
			this.EditPurpleHouse.UseVisualStyleBackColor = true;
			this.EditPurpleHouse.Click += this.EditGeneralNavigation_Click;
			this.EditBlueHouse.Location = new Point(13, 142);
			this.EditBlueHouse.Name = "EditBlueHouse";
			this.EditBlueHouse.Size = new Size(196, 23);
			this.EditBlueHouse.TabIndex = 3;
			this.EditBlueHouse.Text = "Blue House";
			this.EditBlueHouse.UseVisualStyleBackColor = true;
			this.EditBlueHouse.Click += this.EditGeneralNavigation_Click;
			this.EditPinkHouse.Location = new Point(13, 171);
			this.EditPinkHouse.Name = "EditPinkHouse";
			this.EditPinkHouse.Size = new Size(196, 23);
			this.EditPinkHouse.TabIndex = 4;
			this.EditPinkHouse.Text = "Pink House";
			this.EditPinkHouse.UseVisualStyleBackColor = true;
			this.EditPinkHouse.Click += this.EditGeneralNavigation_Click;
			this.EditYellowHouse.Location = new Point(13, 200);
			this.EditYellowHouse.Name = "EditYellowHouse";
			this.EditYellowHouse.Size = new Size(196, 23);
			this.EditYellowHouse.TabIndex = 5;
			this.EditYellowHouse.Text = "Yellow House";
			this.EditYellowHouse.UseVisualStyleBackColor = true;
			this.EditYellowHouse.Click += this.EditGeneralNavigation_Click;
			this.EditGeneralNavigation.Location = new Point(13, 229);
			this.EditGeneralNavigation.Name = "EditGeneralNavigation";
			this.EditGeneralNavigation.Size = new Size(196, 23);
			this.EditGeneralNavigation.TabIndex = 6;
			this.EditGeneralNavigation.Text = "General Navigation";
			this.EditGeneralNavigation.UseVisualStyleBackColor = true;
			this.EditGeneralNavigation.Click += this.EditGeneralNavigation_Click;
			this.HelpDescription.BackColor = Color.Transparent;
			this.HelpDescription.ForeColor = Color.DimGray;
			this.HelpDescription.Location = new Point(10, 35);
			this.HelpDescription.Name = "HelpDescription";
			this.HelpDescription.Size = new Size(196, 20);
			this.HelpDescription.TabIndex = 35;
			this.HelpDescription.Text = "Select a WayPoint category to edit.";
			this.GardenerFloraWayPointEditorMenu.Items.AddRange(new ToolStripItem[]
			{
				this.FileMenuItem,
				this.HelpMenuItem
			});
			this.GardenerFloraWayPointEditorMenu.Location = new Point(0, 0);
			this.GardenerFloraWayPointEditorMenu.Name = "GardenerFloraWayPointEditorMenu";
			this.GardenerFloraWayPointEditorMenu.Size = new Size(223, 24);
			this.GardenerFloraWayPointEditorMenu.TabIndex = 36;
			this.GardenerFloraWayPointEditorMenu.Text = "menuStrip1";
			this.FileMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NewMenuItem,
				this.OpenMenuItem,
				this.toolStripSeparator2,
				this.SaveMenuItem,
				this.SaveAsMenuItem,
				this.toolStripSeparator1,
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
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(189, 6);
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.ShortcutKeys = (Keys)131155;
			this.SaveMenuItem.Size = new Size(192, 22);
			this.SaveMenuItem.Text = "&Save";
			this.SaveAsMenuItem.Name = "SaveAsMenuItem";
			this.SaveAsMenuItem.ShortcutKeys = (Keys)196691;
			this.SaveAsMenuItem.Size = new Size(192, 22);
			this.SaveAsMenuItem.Text = "Save &As..";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(189, 6);
			this.CloseMenuItem.Name = "CloseMenuItem";
			this.CloseMenuItem.ShortcutKeys = (Keys)131159;
			this.CloseMenuItem.Size = new Size(192, 22);
			this.CloseMenuItem.Text = "&Close";
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
			base.ClientSize = new Size(223, 263);
			base.Controls.Add(this.EditRedHouse);
			base.Controls.Add(this.HelpDescription);
			base.Controls.Add(this.EditGeneralNavigation);
			base.Controls.Add(this.EditYellowHouse);
			base.Controls.Add(this.EditPinkHouse);
			base.Controls.Add(this.EditBlueHouse);
			base.Controls.Add(this.EditPurpleHouse);
			base.Controls.Add(this.EditGreenHouse);
			base.Controls.Add(this.GardenerFloraWayPointEditorMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.GardenerFloraWayPointEditorMenu;
			base.MaximizeBox = false;
			base.Name = "GardenerFloraWayPointEditor";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Gardener Flora : WayPoint Setup : New File";
			this.GardenerFloraWayPointEditorMenu.ResumeLayout(false);
			this.GardenerFloraWayPointEditorMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000905 RID: 2309
		private Class90 class90_0;

		// Token: 0x04000908 RID: 2312
		private Button EditRedHouse;

		// Token: 0x04000909 RID: 2313
		private Button EditGreenHouse;

		// Token: 0x0400090A RID: 2314
		private Button EditPurpleHouse;

		// Token: 0x0400090B RID: 2315
		private Button EditBlueHouse;

		// Token: 0x0400090C RID: 2316
		private Button EditPinkHouse;

		// Token: 0x0400090D RID: 2317
		private Button EditYellowHouse;

		// Token: 0x0400090E RID: 2318
		private Button EditGeneralNavigation;

		// Token: 0x0400090F RID: 2319
		private Label HelpDescription;

		// Token: 0x04000910 RID: 2320
		private MenuStrip GardenerFloraWayPointEditorMenu;

		// Token: 0x04000911 RID: 2321
		private ToolStripMenuItem FileMenuItem;

		// Token: 0x04000912 RID: 2322
		private ToolStripMenuItem NewMenuItem;

		// Token: 0x04000913 RID: 2323
		private ToolStripMenuItem OpenMenuItem;

		// Token: 0x04000914 RID: 2324
		private ToolStripMenuItem SaveMenuItem;

		// Token: 0x04000915 RID: 2325
		private ToolStripMenuItem SaveAsMenuItem;

		// Token: 0x04000916 RID: 2326
		private ToolStripMenuItem CloseMenuItem;

		// Token: 0x04000917 RID: 2327
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x04000918 RID: 2328
		private ToolStripMenuItem GuideMenuItem;

		// Token: 0x04000919 RID: 2329
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400091A RID: 2330
		private ToolStripSeparator toolStripSeparator1;
	}
}
