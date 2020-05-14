using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns23;
using ns25;
using TSN.Controls;

namespace ns24
{
	// Token: 0x0200030E RID: 782
	internal sealed class GardeningBeanSelector : UserControl
	{
		// Token: 0x06001E95 RID: 7829 RVA: 0x0000BCF7 File Offset: 0x00009EF7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00064634 File Offset: 0x00062834
		private void InitializeComponent()
		{
			ListViewGroup listViewGroup = new ListViewGroup("1 Bean", HorizontalAlignment.Left);
			ListViewGroup listViewGroup2 = new ListViewGroup("2 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup3 = new ListViewGroup("3 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup4 = new ListViewGroup("4 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup5 = new ListViewGroup("5 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup6 = new ListViewGroup("6 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup7 = new ListViewGroup("7 Beans", HorizontalAlignment.Left);
			ListViewGroup listViewGroup8 = new ListViewGroup("8 Beans", HorizontalAlignment.Left);
			this.InheritOption = new RadioButton();
			this.CustomOption = new RadioButton();
			this.HideBtn = new Button();
			this.BeanComboSelector = new Class361();
			base.SuspendLayout();
			this.InheritOption.AutoSize = true;
			this.InheritOption.Checked = true;
			this.InheritOption.Location = new Point(8, 4);
			this.InheritOption.Name = "InheritOption";
			this.InheritOption.Size = new Size(54, 17);
			this.InheritOption.TabIndex = 1;
			this.InheritOption.TabStop = true;
			this.InheritOption.Text = "Inherit";
			this.InheritOption.UseVisualStyleBackColor = true;
			this.InheritOption.CheckedChanged += this.InheritOption_CheckedChanged;
			this.CustomOption.AutoSize = true;
			this.CustomOption.Location = new Point(68, 4);
			this.CustomOption.Name = "CustomOption";
			this.CustomOption.Size = new Size(60, 17);
			this.CustomOption.TabIndex = 1;
			this.CustomOption.Text = "Custom";
			this.CustomOption.UseVisualStyleBackColor = true;
			this.CustomOption.CheckedChanged += this.CustomOption_CheckedChanged;
			this.HideBtn.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.HideBtn.Location = new Point(187, 3);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new Size(18, 19);
			this.HideBtn.TabIndex = 2;
			this.HideBtn.Text = "X";
			this.HideBtn.UseVisualStyleBackColor = true;
			this.HideBtn.Click += this.HideBtn_Click;
			this.BeanComboSelector.BackColor = Color.White;
			this.BeanComboSelector.Enabled = false;
			listViewGroup.Header = "1 Bean";
			listViewGroup.Name = "lvg1Bean";
			listViewGroup2.Header = "2 Beans";
			listViewGroup2.Name = "lvg2Beans";
			listViewGroup3.Header = "3 Beans";
			listViewGroup3.Name = "lvg3Beans";
			listViewGroup4.Header = "4 Beans";
			listViewGroup4.Name = "lvg4Beans";
			listViewGroup5.Header = "5 Beans";
			listViewGroup5.Name = "lvg5Beans";
			listViewGroup6.Header = "6 Beans";
			listViewGroup6.Name = "lvg6Beans";
			listViewGroup7.Header = "7 Beans";
			listViewGroup7.Name = "lvg7Beans";
			listViewGroup8.Header = "8 Beans";
			listViewGroup8.Name = "lvg7Beans";
			this.BeanComboSelector.Groups.AddRange(new ListViewGroup[]
			{
				listViewGroup,
				listViewGroup2,
				listViewGroup3,
				listViewGroup4,
				listViewGroup5,
				listViewGroup6,
				listViewGroup7,
				listViewGroup8
			});
			this.BeanComboSelector.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.BeanComboSelector.Location = new Point(5, 23);
			this.BeanComboSelector.MainColumnWidth = 176;
			this.BeanComboSelector.MultiSelect = false;
			this.BeanComboSelector.Name = "BeanComboSelector";
			this.BeanComboSelector.Size = new Size(200, 182);
			this.BeanComboSelector.TabIndex = 0;
			this.BeanComboSelector.UseCompatibleStateImageBehavior = false;
			this.BeanComboSelector.View = View.Details;
			this.BeanComboSelector.SelectedIndexChanged += this.BeanComboSelector_SelectedIndexChanged;
			this.BeanComboSelector.MouseDoubleClick += this.BeanComboSelector_MouseDoubleClick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.HideBtn);
			base.Controls.Add(this.CustomOption);
			base.Controls.Add(this.InheritOption);
			base.Controls.Add(this.BeanComboSelector);
			base.Name = "GardeningBeanSelector";
			base.Size = new Size(210, 210);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1400018F RID: 399
		// (add) Token: 0x06001E97 RID: 7831 RVA: 0x00064AF8 File Offset: 0x00062CF8
		// (remove) Token: 0x06001E98 RID: 7832 RVA: 0x00064B30 File Offset: 0x00062D30
		public event EventHandler ClosePopup
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0000BD16 File Offset: 0x00009F16
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x00064B68 File Offset: 0x00062D68
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Class322 BeanCombination
		{
			get
			{
				return this.class322_0;
			}
			set
			{
				if (this.class322_0 != value)
				{
					this.class322_0 = value;
					if (this.class322_0 == null)
					{
						this.InheritOption.Checked = true;
						this.BeanComboSelector.Enabled = false;
					}
					else
					{
						this.CustomOption.Checked = true;
						this.BeanComboSelector.Enabled = true;
					}
					this.BeanComboSelector.method_0(this.class322_0);
				}
			}
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0000BD1E File Offset: 0x00009F1E
		public GardeningBeanSelector()
		{
			this.InitializeComponent();
			this.BeanComboSelector.CheckBoxes = false;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0000BD38 File Offset: 0x00009F38
		private void InheritOption_CheckedChanged(object sender, EventArgs e)
		{
			if (this.BeanCombination != null && this.InheritOption.Checked)
			{
				this.BeanCombination = null;
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0000BD56 File Offset: 0x00009F56
		private void CustomOption_CheckedChanged(object sender, EventArgs e)
		{
			if (this.BeanCombination == null && this.CustomOption.Checked)
			{
				this.BeanCombination = Class322.readOnlyCollection_0[0];
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0000BD7E File Offset: 0x00009F7E
		private void BeanComboSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.BeanComboSelector.SelectedItems.Count > 0)
			{
				this.class322_0 = ((ListViewItemState<Class322>)this.BeanComboSelector.SelectedItems[0]).State;
				return;
			}
			this.class322_0 = null;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0000BDBC File Offset: 0x00009FBC
		private void BeanComboSelector_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.BeanComboSelector.SelectedItems.Count > 0)
			{
				this.method_0();
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0000BDD7 File Offset: 0x00009FD7
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0000BDF2 File Offset: 0x00009FF2
		private void HideBtn_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x04000BB0 RID: 2992
		private IContainer icontainer_0;

		// Token: 0x04000BB1 RID: 2993
		private Class361 BeanComboSelector;

		// Token: 0x04000BB2 RID: 2994
		private RadioButton InheritOption;

		// Token: 0x04000BB3 RID: 2995
		private RadioButton CustomOption;

		// Token: 0x04000BB4 RID: 2996
		private Button HideBtn;

		// Token: 0x04000BB5 RID: 2997
		private Class322 class322_0;

		// Token: 0x04000BB6 RID: 2998
		private EventHandler eventHandler_0;
	}
}
