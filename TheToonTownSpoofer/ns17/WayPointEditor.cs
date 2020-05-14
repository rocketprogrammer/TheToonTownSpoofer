using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns16;
using ns18;
using ns19;
using ns20;
using ns21;
using ns27;
using ns29;
using ns31;

namespace ns17
{
	// Token: 0x0200025B RID: 603
	internal sealed partial class WayPointEditor : SaveForm
	{
		// Token: 0x060019E6 RID: 6630 RVA: 0x00047DF0 File Offset: 0x00045FF0
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WayPointEditor));
			this.RemoveWayPoint = new Button();
			this.HelpDescription = new Label();
			this.WayPointTypeComboBox = new ComboBox();
			this.WayPointList = new ListView();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.contextMenu_0 = new ContextMenu();
			this.menuItem_0 = new MenuItem();
			this.menuItem_1 = new MenuItem();
			this.AddWayPoint = new Class479();
			this.PlaygroundList = new ListView();
			this.columnHeader_2 = new ColumnHeader();
			this.Playgrounds = new ComboBox();
			this.ChangeCoordinates = new Button();
			this.WayPointEditorMenu = new MenuStrip();
			this.FileMenuItem = new ToolStripMenuItem();
			this.NewMenuItem = new ToolStripMenuItem();
			this.OpenMenuItem = new ToolStripMenuItem();
			this.OpenSaveSplitItem = new ToolStripSeparator();
			this.SaveMenuItem = new ToolStripMenuItem();
			this.SaveAsMenuItem = new ToolStripMenuItem();
			this.SaveAsCloseSplitItem = new ToolStripSeparator();
			this.CloseMenuItem = new ToolStripMenuItem();
			this.WindowMenuItem = new ToolStripMenuItem();
			this.SelectToonTownWindowMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideMenuItem = new ToolStripMenuItem();
			this.WayPointEditorMenu.SuspendLayout();
			base.SuspendLayout();
			this.saveFileDialog_0.Filter = "Way Point Settings|*.wps";
			this.openFileDialog_0.Filter = "Way Point Settings|*.wps";
			this.RemoveWayPoint.Enabled = false;
			this.RemoveWayPoint.Location = new Point(397, 219);
			this.RemoveWayPoint.Name = "RemoveWayPoint";
			this.RemoveWayPoint.Size = new Size(75, 23);
			this.RemoveWayPoint.TabIndex = 4;
			this.RemoveWayPoint.Text = "Remove";
			this.RemoveWayPoint.UseVisualStyleBackColor = true;
			this.RemoveWayPoint.Click += this.RemoveWayPoint_Click;
			this.HelpDescription.BackColor = Color.Transparent;
			this.HelpDescription.ForeColor = Color.DimGray;
			this.HelpDescription.Location = new Point(7, 250);
			this.HelpDescription.Name = "HelpDescription";
			this.HelpDescription.Size = new Size(609, 57);
			this.HelpDescription.TabIndex = 34;
			this.HelpDescription.Text = componentResourceManager.GetString("HelpDescription.Text");
			this.WayPointTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			this.WayPointTypeComboBox.Enabled = false;
			this.WayPointTypeComboBox.FormattingEnabled = true;
			this.WayPointTypeComboBox.Location = new Point(516, 220);
			this.WayPointTypeComboBox.Name = "WayPointTypeComboBox";
			this.WayPointTypeComboBox.Size = new Size(100, 21);
			this.WayPointTypeComboBox.TabIndex = 6;
			this.WayPointTypeComboBox.SelectedIndexChanged += this.WayPointTypeComboBox_SelectedIndexChanged;
			this.WayPointList.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.WayPointList.FullRowSelect = true;
			this.WayPointList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.WayPointList.HideSelection = false;
			this.WayPointList.Location = new Point(316, 31);
			this.WayPointList.MultiSelect = false;
			this.WayPointList.Name = "WayPointList";
			this.WayPointList.Size = new Size(300, 183);
			this.WayPointList.TabIndex = 2;
			this.WayPointList.UseCompatibleStateImageBehavior = false;
			this.WayPointList.View = View.Details;
			this.WayPointList.SelectedIndexChanged += this.WayPointList_SelectedIndexChanged;
			this.columnHeader_0.Text = "Point";
			this.columnHeader_0.Width = 160;
			this.columnHeader_1.Text = "Type";
			this.columnHeader_1.Width = 110;
			this.contextMenu_0.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem_0,
				this.menuItem_1
			});
			this.menuItem_0.Index = 0;
			this.menuItem_0.Text = "Add From ToonTown";
			this.menuItem_0.Click += this.menuItem_0_Click;
			this.menuItem_1.Enabled = false;
			this.menuItem_1.Index = 1;
			this.menuItem_1.Text = "Add Custom";
			this.menuItem_1.Click += this.menuItem_1_Click;
			this.AddWayPoint.AutoSize = true;
			this.AddWayPoint.Location = new Point(316, 219);
			this.AddWayPoint.Name = "AddWayPoint";
			this.AddWayPoint.ShowSplit = true;
			this.AddWayPoint.Size = new Size(75, 23);
			this.AddWayPoint.SplitMenu = this.contextMenu_0;
			this.AddWayPoint.TabIndex = 3;
			this.AddWayPoint.Text = "Add";
			this.AddWayPoint.UseVisualStyleBackColor = true;
			this.AddWayPoint.Click += this.AddWayPoint_Click;
			this.PlaygroundList.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_2
			});
			this.PlaygroundList.FullRowSelect = true;
			this.PlaygroundList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.PlaygroundList.HideSelection = false;
			this.PlaygroundList.Location = new Point(10, 31);
			this.PlaygroundList.MultiSelect = false;
			this.PlaygroundList.Name = "PlaygroundList";
			this.PlaygroundList.Size = new Size(300, 183);
			this.PlaygroundList.TabIndex = 0;
			this.PlaygroundList.UseCompatibleStateImageBehavior = false;
			this.PlaygroundList.View = View.Details;
			this.PlaygroundList.SelectedIndexChanged += this.PlaygroundList_SelectedIndexChanged;
			this.columnHeader_2.Text = "Playgrounds";
			this.columnHeader_2.Width = 270;
			this.Playgrounds.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Playgrounds.FormattingEnabled = true;
			this.Playgrounds.Location = new Point(12, 220);
			this.Playgrounds.Name = "Playgrounds";
			this.Playgrounds.Size = new Size(298, 21);
			this.Playgrounds.Sorted = true;
			this.Playgrounds.TabIndex = 1;
			this.Playgrounds.SelectedIndexChanged += this.Playgrounds_SelectedIndexChanged;
			this.ChangeCoordinates.Enabled = false;
			this.ChangeCoordinates.Location = new Point(478, 219);
			this.ChangeCoordinates.Name = "ChangeCoordinates";
			this.ChangeCoordinates.Size = new Size(32, 23);
			this.ChangeCoordinates.TabIndex = 5;
			this.ChangeCoordinates.Text = "...";
			this.ChangeCoordinates.UseVisualStyleBackColor = true;
			this.ChangeCoordinates.Click += this.ChangeCoordinates_Click;
			this.WayPointEditorMenu.Items.AddRange(new ToolStripItem[]
			{
				this.FileMenuItem,
				this.WindowMenuItem,
				this.HelpMenuItem
			});
			this.WayPointEditorMenu.Location = new Point(0, 0);
			this.WayPointEditorMenu.Name = "WayPointEditorMenu";
			this.WayPointEditorMenu.Size = new Size(623, 24);
			this.WayPointEditorMenu.TabIndex = 35;
			this.WayPointEditorMenu.Text = "menuStrip1";
			this.FileMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NewMenuItem,
				this.OpenMenuItem,
				this.OpenSaveSplitItem,
				this.SaveMenuItem,
				this.SaveAsMenuItem,
				this.SaveAsCloseSplitItem,
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
			this.SaveAsCloseSplitItem.Name = "SaveAsCloseSplitItem";
			this.SaveAsCloseSplitItem.Size = new Size(189, 6);
			this.CloseMenuItem.Name = "CloseMenuItem";
			this.CloseMenuItem.ShortcutKeys = (Keys)131159;
			this.CloseMenuItem.Size = new Size(192, 22);
			this.CloseMenuItem.Text = "&Close";
			this.WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.SelectToonTownWindowMenuItem
			});
			this.WindowMenuItem.Name = "WindowMenuItem";
			this.WindowMenuItem.Size = new Size(63, 20);
			this.WindowMenuItem.Text = "&Window";
			this.SelectToonTownWindowMenuItem.Name = "SelectToonTownWindowMenuItem";
			this.SelectToonTownWindowMenuItem.Size = new Size(213, 22);
			this.SelectToonTownWindowMenuItem.Text = "&Select ToonTown Window";
			this.SelectToonTownWindowMenuItem.Click += this.SelectToonTownWindowMenuItem_Click;
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
			base.ClientSize = new Size(623, 313);
			base.Controls.Add(this.ChangeCoordinates);
			base.Controls.Add(this.Playgrounds);
			base.Controls.Add(this.PlaygroundList);
			base.Controls.Add(this.AddWayPoint);
			base.Controls.Add(this.WayPointList);
			base.Controls.Add(this.WayPointTypeComboBox);
			base.Controls.Add(this.HelpDescription);
			base.Controls.Add(this.RemoveWayPoint);
			base.Controls.Add(this.WayPointEditorMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.WayPointEditorMenu;
			base.MaximizeBox = false;
			base.Name = "WayPointEditor";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Way Point Editor : New File";
			this.WayPointEditorMenu.ResumeLayout(false);
			this.WayPointEditorMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00048AA4 File Offset: 0x00046CA4
		public WayPointEditor(Class101 settings) : this(false)
		{
			ToolStripItem newMenuItem = this.NewMenuItem;
			ToolStripItem openMenuItem = this.OpenMenuItem;
			ToolStripItem openSaveSplitItem = this.OpenSaveSplitItem;
			ToolStripItem saveMenuItem = this.SaveMenuItem;
			ToolStripItem saveAsMenuItem = this.SaveAsMenuItem;
			ToolStripItem saveAsCloseSplitItem = this.SaveAsCloseSplitItem;
			ToolStripItem newMenuItem2 = this.NewMenuItem;
			ToolStripItem openMenuItem2 = this.OpenMenuItem;
			ToolStripItem openSaveSplitItem2 = this.OpenSaveSplitItem;
			ToolStripItem saveMenuItem2 = this.SaveMenuItem;
			ToolStripItem saveAsMenuItem2 = this.SaveAsMenuItem;
			this.SaveAsCloseSplitItem.Visible = false;
			saveAsMenuItem2.Visible = false;
			saveMenuItem2.Visible = false;
			openSaveSplitItem2.Visible = false;
			openMenuItem2.Visible = false;
			newMenuItem2.Visible = false;
			saveAsCloseSplitItem.Enabled = false;
			saveAsMenuItem.Enabled = false;
			saveMenuItem.Enabled = false;
			openSaveSplitItem.Enabled = false;
			openMenuItem.Enabled = false;
			newMenuItem.Enabled = false;
			base.CanSave = false;
			this.class101_0 = settings;
			this.method_10();
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00048B5C File Offset: 0x00046D5C
		public WayPointEditor(bool joeFish)
		{
			this.InitializeComponent_1();
			this.dictionary_0 = new Dictionary<Enum57, WayPointEditor.Class200>();
			Class256 @class = new Class256();
			this.PlaygroundList.ListViewItemSorter = @class;
			this.PlaygroundList.Sorting = SortOrder.Ascending;
			@class.Order = SortOrder.Ascending;
			this.NewMenuItem.Click += base.method_0;
			this.OpenMenuItem.Click += base.method_1;
			this.SaveAsMenuItem.Click += base.method_3;
			this.SaveMenuItem.Click += base.method_2;
			this.CloseMenuItem.Click += base.method_4;
			this.class141_0 = new Class141();
			ListControl playgrounds = this.Playgrounds;
			if (WayPointEditor.listControlConvertEventHandler_0 == null)
			{
				WayPointEditor.listControlConvertEventHandler_0 = new ListControlConvertEventHandler(WayPointEditor.smethod_1);
			}
			playgrounds.Format += WayPointEditor.listControlConvertEventHandler_0;
			Array values = Enum.GetValues(typeof(Enum57));
			object[] array = new object[values.Length];
			values.CopyTo(array, 0);
			List<object> list = array.ToList<object>();
			list.Remove(Enum57.const_0);
			this.Playgrounds.Items.AddRange(list.ToArray());
			ListControl wayPointTypeComboBox = this.WayPointTypeComboBox;
			if (WayPointEditor.listControlConvertEventHandler_1 == null)
			{
				WayPointEditor.listControlConvertEventHandler_1 = new ListControlConvertEventHandler(WayPointEditor.smethod_2);
			}
			wayPointTypeComboBox.Format += WayPointEditor.listControlConvertEventHandler_1;
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_0);
			if (joeFish)
			{
				this.WayPointTypeComboBox.Items.Add(Enum99.flag_1);
				base.method_5();
				return;
			}
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_5);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_6);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_7);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_8);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_9);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_10);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_11);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_12);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_13);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_14);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_15);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_16);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_17);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_18);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_19);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_20);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_21);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_22);
			this.WayPointTypeComboBox.Items.Add(Enum99.flag_23);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00048EF0 File Offset: 0x000470F0
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (base.CanSave)
			{
				if (modified)
				{
					if (Class524.smethod_0(fileName, null))
					{
						this.Text = "Way Point Editor : New File*";
						return;
					}
					this.Text = string.Format("Way Point Editor : {0}*", Path.GetFileName(fileName.string_1));
					return;
				}
				else
				{
					if (Class524.smethod_0(fileName, null))
					{
						this.Text = "Way Point Editor : New File";
						return;
					}
					this.Text = "Way Point Editor : " + Path.GetFileName(fileName.string_1);
				}
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000091BD File Offset: 0x000073BD
		protected override void vmethod_0()
		{
			this.class101_0 = new Class101();
			this.method_10();
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00048F6C File Offset: 0x0004716C
		protected override bool vmethod_5(Class524 path)
		{
			bool result;
			try
			{
				Class101 @class = new Class101(path.string_1);
				this.class101_0 = @class;
				this.method_10();
				if (this.PlaygroundList.Items.Count > 0)
				{
					this.PlaygroundList.Items[0].Selected = true;
				}
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, path.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00048FE4 File Offset: 0x000471E4
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class101_0.method_1(fileName.string_1);
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00049028 File Offset: 0x00047228
		private void method_10()
		{
			this.PlaygroundList.Items.Clear();
			this.WayPointList.Items.Clear();
			this.dictionary_0.Clear();
			foreach (Enum57 @enum in this.class101_0.WayPoints.Keys)
			{
				WayPointEditor.Class200 value = new WayPointEditor.Class200(@enum);
				this.PlaygroundList.Items.Add(value);
				this.dictionary_0.Add(@enum, value);
			}
			this.PlaygroundList.Sort();
			if (this.PlaygroundList.Items.Count > 0)
			{
				this.PlaygroundList.Items[0].Selected = true;
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000091D0 File Offset: 0x000073D0
		private void SelectToonTownWindowMenuItem_Click(object sender, EventArgs e)
		{
			if (this.class141_0.smethod_2(this, null))
			{
				this.method_11();
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000091E7 File Offset: 0x000073E7
		private void method_11()
		{
			if (!Class142.smethod_2(this.class141_0.MainWindowHandle, out this.class142_0))
			{
				this.class142_0 = Class142.smethod_9(this.class141_0.MainWindowHandle, Enum101.const_0, null);
				this.class142_0.method_5();
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00049108 File Offset: 0x00047308
		private void ChangeCoordinates_Click(object sender, EventArgs e)
		{
			EventHandler<EventArgs43<PointF>> eventHandler = null;
			WayPointEditor.Class201 @class = new WayPointEditor.Class201();
			@class.wayPointEditor_0 = this;
			@class.class198_0 = (this.WayPointList.SelectedItems[0] as WayPointEditor.Class198);
			@class.enum57_0 = (Enum57)this.Playgrounds.SelectedItem;
			using (PointFInput pointFInput = new PointFInput())
			{
				PointFInput pointFInput2 = pointFInput;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler<EventArgs43<PointF>>(@class.method_0);
				}
				pointFInput2.ValueValidating += eventHandler;
				pointFInput.SelectedPoint = @class.class198_0.Point;
				if (pointFInput.ShowDialog() == DialogResult.OK && @class.class198_0.Point != pointFInput.SelectedPoint)
				{
					Enum99 value = this.class101_0.WayPoints[@class.enum57_0][@class.class198_0.Point];
					this.class101_0.WayPoints[@class.enum57_0].Remove(@class.class198_0.Point);
					this.class101_0.WayPoints[@class.enum57_0].Add(pointFInput.SelectedPoint, value);
					@class.class198_0.Point = pointFInput.SelectedPoint;
					base.FileModified = true;
				}
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00049250 File Offset: 0x00047450
		private void menuItem_1_Click(object sender, EventArgs e)
		{
			using (PointFInput pointFInput = new PointFInput())
			{
				WayPointEditor.Class202 @class = new WayPointEditor.Class202();
				@class.wayPointEditor_0 = this;
				@class.enum57_0 = (Enum57)this.Playgrounds.SelectedItem;
				pointFInput.ValueValidating += @class.method_0;
				if (pointFInput.ShowDialog() == DialogResult.OK)
				{
					this.class101_0.WayPoints[@class.enum57_0].Add(pointFInput.SelectedPoint, Enum99.flag_0);
					this.WayPointList.Items.Add(new WayPointEditor.Class198(pointFInput.SelectedPoint, Enum99.flag_0));
					base.FileModified = true;
				}
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00009225 File Offset: 0x00007425
		private void menuItem_0_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00009225 File Offset: 0x00007425
		private void AddWayPoint_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00049304 File Offset: 0x00047504
		private void method_12()
		{
			if (!this.class141_0.ProcessOpen)
			{
				if (!this.class141_0.smethod_1(this))
				{
					return;
				}
				this.method_11();
			}
			Enum57 playground = this.class142_0.Playground;
			if (playground == Enum57.const_0)
			{
				DialogBox.smethod_3("Cannot record the position as ToonTown does not appear to be in a playground.", "Unknown Playground");
				return;
			}
			WayPointEditor.Class203 @class = new WayPointEditor.Class203();
			@class.nullable_0 = null;
			EventHandler eventHandler = null;
			WayPointEditor.Class204 class2 = new WayPointEditor.Class204();
			class2.class203_0 = @class;
			class2.wayPointEditor_0 = this;
			class2.loading_0 = new Loading();
			try
			{
				Form loading_ = class2.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class2.method_0);
				}
				loading_.Shown += eventHandler;
				class2.loading_0.ShowDialog();
			}
			finally
			{
				if (class2.loading_0 != null)
				{
					((IDisposable)class2.loading_0).Dispose();
				}
			}
			if (@class.nullable_0 != null)
			{
				Dictionary<PointF, Enum99> dictionary;
				WayPointEditor.Class200 class3;
				if (this.class101_0.WayPoints.ContainsKey(playground))
				{
					dictionary = this.class101_0.WayPoints[playground];
					class3 = this.dictionary_0[playground];
				}
				else
				{
					dictionary = new Dictionary<PointF, Enum99>();
					this.class101_0.WayPoints.Add(playground, dictionary);
					this.PlaygroundList.Items.Add(class3 = new WayPointEditor.Class200(playground));
					this.dictionary_0.Add(playground, class3);
					this.PlaygroundList.Sort();
				}
				this.PlaygroundList.SelectedItems.Clear();
				if (class3 != null)
				{
					class3.Selected = true;
				}
				PointF location = @class.nullable_0.Value.Location;
				WayPointEditor.Class198 class4 = null;
				if (dictionary.ContainsKey(location))
				{
					WayPointEditor.smethod_0(location);
					using (IEnumerator enumerator = this.WayPointList.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							WayPointEditor.Class198 class5 = (WayPointEditor.Class198)obj;
							if (class5.Point == location)
							{
								class4 = class5;
								IL_1D4:
								goto IL_217;
							}
						}
						goto IL_1D4;
					}
				}
				dictionary.Add(location, Enum99.flag_0);
				this.WayPointList.Items.Add(class4 = new WayPointEditor.Class198(location, Enum99.flag_0));
				base.FileModified = true;
				IL_217:
				foreach (object obj2 in this.WayPointList.SelectedItems)
				{
					WayPointEditor.Class198 class6 = (WayPointEditor.Class198)obj2;
					class6.Selected = false;
				}
				if (class4 != null)
				{
					class4.Selected = true;
					return;
				}
			}
			else
			{
				DialogBox.smethod_3("The Way Point Editor was unable to retrieve your toon's coordinates. Check if ToonTown is responding and your toon is in a Playground.", "Unable to Retrieve Coordinates");
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0000922D File Offset: 0x0000742D
		private static void smethod_0(PointF p)
		{
			DialogBox.smethod_3(string.Format("The point: '{0}' already exists for the playground.", p), "Point Already Exists");
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000495B8 File Offset: 0x000477B8
		private void RemoveWayPoint_Click(object sender, EventArgs e)
		{
			WayPointEditor.Class200 @class = this.PlaygroundList.SelectedItems[0] as WayPointEditor.Class200;
			WayPointEditor.Class198 class2 = this.WayPointList.SelectedItems[0] as WayPointEditor.Class198;
			int num = this.WayPointList.SelectedIndices[0];
			Dictionary<PointF, Enum99> dictionary = this.class101_0.WayPoints[@class.enum57_0];
			dictionary.Remove(class2.Point);
			this.WayPointList.Items.Remove(class2);
			if (dictionary.Count == 0)
			{
				this.PlaygroundList.Items.Remove(@class);
				this.class101_0.WayPoints.Remove(@class.enum57_0);
				this.dictionary_0.Remove(@class.enum57_0);
			}
			int count = this.WayPointList.Items.Count;
			if (num < count)
			{
				this.WayPointList.Items[num].Selected = true;
			}
			else if (count > 0)
			{
				this.WayPointList.Items[count - 1].Selected = true;
			}
			base.FileModified = true;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000496D4 File Offset: 0x000478D4
		private void PlaygroundList_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.WayPointList.Items.Clear();
			if (this.PlaygroundList.SelectedItems.Count > 0)
			{
				foreach (KeyValuePair<PointF, Enum99> keyValuePair in this.class101_0.WayPoints[(this.PlaygroundList.SelectedItems[0] as WayPointEditor.Class200).enum57_0])
				{
					this.WayPointList.Items.Add(new WayPointEditor.Class198(keyValuePair.Key, keyValuePair.Value));
				}
				this.Playgrounds.SelectedItem = (this.PlaygroundList.SelectedItems[0] as WayPointEditor.Class200).enum57_0;
			}
			else if (this.Playgrounds.SelectedItem != null)
			{
				this.Playgrounds.SelectedItem = null;
			}
			this.method_13();
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000497DC File Offset: 0x000479DC
		private void WayPointList_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_13();
			if (this.WayPointList.SelectedItems.Count > 0)
			{
				this.WayPointTypeComboBox.SelectedItem = (this.WayPointList.SelectedItems[0] as WayPointEditor.Class198).WayPointType;
				return;
			}
			this.WayPointTypeComboBox.SelectedIndex = -1;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004983C File Offset: 0x00047A3C
		private void WayPointTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.WayPointTypeComboBox.SelectedIndex > -1)
			{
				WayPointEditor.Class198 @class = this.WayPointList.SelectedItems[0] as WayPointEditor.Class198;
				WayPointEditor.Class200 class2 = this.PlaygroundList.SelectedItems[0] as WayPointEditor.Class200;
				Enum99 @enum = (Enum99)this.WayPointTypeComboBox.SelectedItem;
				if (@class.WayPointType != @enum)
				{
					Dictionary<PointF, Enum99> dictionary = this.class101_0.WayPoints[class2.enum57_0];
					if (@enum == Enum99.flag_1)
					{
						foreach (object obj in this.WayPointList.Items)
						{
							WayPointEditor.Class198 class3 = (WayPointEditor.Class198)obj;
							if (class3.WayPointType == Enum99.flag_1)
							{
								class3.WayPointType = Enum99.flag_0;
								dictionary[class3.Point] = Enum99.flag_0;
							}
						}
					}
					@class.WayPointType = @enum;
					dictionary[@class.Point] = @enum;
				}
				base.FileModified = true;
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00049950 File Offset: 0x00047B50
		private void method_13()
		{
			this.ChangeCoordinates.Enabled = (this.WayPointTypeComboBox.Enabled = (this.RemoveWayPoint.Enabled = (this.WayPointList.SelectedItems.Count > 0)));
			this.menuItem_1.Enabled = (this.PlaygroundList.SelectedItems.Count > 0);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000499B8 File Offset: 0x00047BB8
		private void Playgrounds_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Playgrounds.SelectedItem != null)
			{
				Enum57 @enum = (Enum57)this.Playgrounds.SelectedItem;
				WayPointEditor.Class200 @class;
				if (this.dictionary_0.ContainsKey(@enum))
				{
					@class = this.dictionary_0[@enum];
					if (!@class.Selected)
					{
						this.PlaygroundList.SelectedItems.Clear();
						this.dictionary_0[@enum].Selected = true;
					}
				}
				else
				{
					@class = new WayPointEditor.Class200(@enum);
					this.class101_0.WayPoints.Add(@enum, new Dictionary<PointF, Enum99>());
					this.PlaygroundList.Items.Add(@class);
					this.dictionary_0.Add(@enum, @class);
					@class.Selected = true;
					this.PlaygroundList.Sort();
				}
				this.PlaygroundList.EnsureVisible(@class.Index);
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00009249 File Offset: 0x00007449
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_14);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00009252 File Offset: 0x00007452
		[CompilerGenerated]
		private static void smethod_1(object sender, ListControlConvertEventArgs e)
		{
			e.Value = ((Enum57)e.ListItem).smethod_5();
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0000926A File Offset: 0x0000746A
		[CompilerGenerated]
		private static void smethod_2(object sender, ListControlConvertEventArgs e)
		{
			e.Value = ((Enum99)e.ListItem).smethod_4();
		}

		// Token: 0x04000761 RID: 1889
		private Button RemoveWayPoint;

		// Token: 0x04000762 RID: 1890
		private Label HelpDescription;

		// Token: 0x04000763 RID: 1891
		private ComboBox WayPointTypeComboBox;

		// Token: 0x04000764 RID: 1892
		private ListView WayPointList;

		// Token: 0x04000765 RID: 1893
		private ColumnHeader columnHeader_0;

		// Token: 0x04000766 RID: 1894
		private ColumnHeader columnHeader_1;

		// Token: 0x04000767 RID: 1895
		private ContextMenu contextMenu_0;

		// Token: 0x04000768 RID: 1896
		private Class479 AddWayPoint;

		// Token: 0x04000769 RID: 1897
		private MenuItem menuItem_0;

		// Token: 0x0400076A RID: 1898
		private MenuItem menuItem_1;

		// Token: 0x0400076B RID: 1899
		private ListView PlaygroundList;

		// Token: 0x0400076C RID: 1900
		private ColumnHeader columnHeader_2;

		// Token: 0x0400076D RID: 1901
		private ComboBox Playgrounds;

		// Token: 0x0400076E RID: 1902
		private Button ChangeCoordinates;

		// Token: 0x0400076F RID: 1903
		private MenuStrip WayPointEditorMenu;

		// Token: 0x04000770 RID: 1904
		private ToolStripMenuItem FileMenuItem;

		// Token: 0x04000771 RID: 1905
		private ToolStripMenuItem NewMenuItem;

		// Token: 0x04000772 RID: 1906
		private ToolStripMenuItem OpenMenuItem;

		// Token: 0x04000773 RID: 1907
		private ToolStripSeparator OpenSaveSplitItem;

		// Token: 0x04000774 RID: 1908
		private ToolStripMenuItem SaveMenuItem;

		// Token: 0x04000775 RID: 1909
		private ToolStripMenuItem SaveAsMenuItem;

		// Token: 0x04000776 RID: 1910
		private ToolStripSeparator SaveAsCloseSplitItem;

		// Token: 0x04000777 RID: 1911
		private ToolStripMenuItem CloseMenuItem;

		// Token: 0x04000778 RID: 1912
		private ToolStripMenuItem WindowMenuItem;

		// Token: 0x04000779 RID: 1913
		private ToolStripMenuItem SelectToonTownWindowMenuItem;

		// Token: 0x0400077A RID: 1914
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x0400077B RID: 1915
		private ToolStripMenuItem GuideMenuItem;

		// Token: 0x0400077D RID: 1917
		private Class142 class142_0;

		// Token: 0x0400077E RID: 1918
		private Class101 class101_0;

		// Token: 0x0400077F RID: 1919
		private Dictionary<Enum57, WayPointEditor.Class200> dictionary_0;

		// Token: 0x04000780 RID: 1920
		[CompilerGenerated]
		private static ListControlConvertEventHandler listControlConvertEventHandler_0;

		// Token: 0x04000781 RID: 1921
		[CompilerGenerated]
		private static ListControlConvertEventHandler listControlConvertEventHandler_1;

		// Token: 0x0200025C RID: 604
		private sealed class Class198 : ListViewItem
		{
			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x060019FF RID: 6655 RVA: 0x00009282 File Offset: 0x00007482
			// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0000929A File Offset: 0x0000749A
			public Enum99 WayPointType
			{
				get
				{
					return (base.SubItems[1] as WayPointEditor.Class198.Class199).WayPointType;
				}
				set
				{
					(base.SubItems[1] as WayPointEditor.Class198.Class199).WayPointType = value;
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06001A01 RID: 6657 RVA: 0x000092B3 File Offset: 0x000074B3
			// (set) Token: 0x06001A02 RID: 6658 RVA: 0x000092BB File Offset: 0x000074BB
			public PointF Point
			{
				get
				{
					return this.pointF_0;
				}
				set
				{
					if (this.pointF_0 != value)
					{
						this.pointF_0 = value;
						base.Text = this.pointF_0.ToString();
					}
				}
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x000092E9 File Offset: 0x000074E9
			public Class198(PointF point, Enum99 type)
			{
				this.Point = point;
				base.Text = point.ToString();
				base.SubItems.Add(new WayPointEditor.Class198.Class199(type));
			}

			// Token: 0x04000782 RID: 1922
			private PointF pointF_0;

			// Token: 0x0200025D RID: 605
			private sealed class Class199 : ListViewItem.ListViewSubItem
			{
				// Token: 0x170007A6 RID: 1958
				// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0000931D File Offset: 0x0000751D
				// (set) Token: 0x06001A05 RID: 6661 RVA: 0x00009325 File Offset: 0x00007525
				public Enum99 WayPointType
				{
					get
					{
						return this.enum99_0;
					}
					set
					{
						if (this.enum99_0 != value)
						{
							this.enum99_0 = value;
							base.Text = this.enum99_0.smethod_4();
						}
					}
				}

				// Token: 0x06001A06 RID: 6662 RVA: 0x00009348 File Offset: 0x00007548
				public Class199(Enum99 type)
				{
					this.WayPointType = type;
					base.Text = this.enum99_0.smethod_4();
				}

				// Token: 0x04000783 RID: 1923
				private Enum99 enum99_0;
			}
		}

		// Token: 0x0200025E RID: 606
		private sealed class Class200 : ListViewItem
		{
			// Token: 0x06001A07 RID: 6663 RVA: 0x00009368 File Offset: 0x00007568
			public Class200(Enum57 playground)
			{
				this.enum57_0 = playground;
				base.Text = this.enum57_0.smethod_5();
			}

			// Token: 0x04000784 RID: 1924
			public readonly Enum57 enum57_0;
		}

		// Token: 0x0200025F RID: 607
		[CompilerGenerated]
		private sealed class Class201
		{
			// Token: 0x06001A09 RID: 6665 RVA: 0x00049A8C File Offset: 0x00047C8C
			public void method_0(object sender, EventArgs43<PointF> e)
			{
				if (this.class198_0.Point != e.gparam_0 && this.wayPointEditor_0.class101_0.WayPoints[this.enum57_0].ContainsKey(e.gparam_0))
				{
					WayPointEditor.smethod_0(e.gparam_0);
					e.IsValid = false;
				}
			}

			// Token: 0x04000785 RID: 1925
			public WayPointEditor.Class198 class198_0;

			// Token: 0x04000786 RID: 1926
			public Enum57 enum57_0;

			// Token: 0x04000787 RID: 1927
			public WayPointEditor wayPointEditor_0;
		}

		// Token: 0x02000260 RID: 608
		[CompilerGenerated]
		private sealed class Class202
		{
			// Token: 0x06001A0B RID: 6667 RVA: 0x00009388 File Offset: 0x00007588
			public void method_0(object sender, EventArgs43<PointF> e)
			{
				if (this.wayPointEditor_0.class101_0.WayPoints[this.enum57_0].ContainsKey(e.gparam_0))
				{
					WayPointEditor.smethod_0(e.gparam_0);
					e.IsValid = false;
				}
			}

			// Token: 0x04000788 RID: 1928
			public Enum57 enum57_0;

			// Token: 0x04000789 RID: 1929
			public WayPointEditor wayPointEditor_0;
		}

		// Token: 0x02000261 RID: 609
		[CompilerGenerated]
		private sealed class Class203
		{
			// Token: 0x0400078A RID: 1930
			public Struct56? nullable_0;
		}

		// Token: 0x02000262 RID: 610
		[CompilerGenerated]
		private sealed class Class204
		{
			// Token: 0x06001A0E RID: 6670 RVA: 0x000093C4 File Offset: 0x000075C4
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1));
			}

			// Token: 0x06001A0F RID: 6671 RVA: 0x00049AEC File Offset: 0x00047CEC
			public void method_1(object ob)
			{
				MethodInvoker methodInvoker = null;
				using (ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(false))
				{
					Enum92 logMonitoringPrecision = this.wayPointEditor_0.class142_0.LogMonitor.LogMonitoringPrecision;
					this.wayPointEditor_0.class142_0.LogMonitor.LogMonitoringPrecision = Enum92.const_2;
					try
					{
						this.class203_0.nullable_0 = Class269.smethod_0(this.wayPointEditor_0.class142_0, manualResetEventSlim, 5000);
					}
					finally
					{
						this.wayPointEditor_0.class142_0.LogMonitor.LogMonitoringPrecision = logMonitoringPrecision;
					}
					Control sender = this.wayPointEditor_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_2);
					}
					sender.smethod_6(methodInvoker);
				}
			}

			// Token: 0x06001A10 RID: 6672 RVA: 0x000093D8 File Offset: 0x000075D8
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x0400078B RID: 1931
			public WayPointEditor.Class203 class203_0;

			// Token: 0x0400078C RID: 1932
			public Loading loading_0;

			// Token: 0x0400078D RID: 1933
			public WayPointEditor wayPointEditor_0;
		}
	}
}
