using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ns25;
using TSN.Controls;

namespace ns23
{
	// Token: 0x0200038F RID: 911
	internal sealed class Class361 : ListView
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0000F3F5 File Offset: 0x0000D5F5
		public int MainColumnWidth
		{
			get
			{
				return this.columnHeader_0.Width;
			}
			set
			{
				this.columnHeader_0.Width = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0000F403 File Offset: 0x0000D603
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new ListView.ListViewItemCollection Items
		{
			get
			{
				return base.Items;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0000F40B File Offset: 0x0000D60B
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new ListView.ColumnHeaderCollection Columns
		{
			get
			{
				return base.Columns;
			}
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0007824C File Offset: 0x0007644C
		public Class361()
		{
			this.method_3();
			this.dictionary_0 = new Dictionary<Class322, ListViewItem>();
			this.columnHeader_0 = new ColumnHeader();
			this.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.columnHeader_0.Text = "Plant Name (Bean Combination)";
			this.columnHeader_0.Width = 380;
			base.BeginUpdate();
			this.lvg1Bean = new ListViewGroup("1 Bean", HorizontalAlignment.Left);
			this.lvg2Beans = new ListViewGroup("2 Beans", HorizontalAlignment.Left);
			this.lvg3Beans = new ListViewGroup("3 Beans", HorizontalAlignment.Left);
			this.lvg4Beans = new ListViewGroup("4 Beans", HorizontalAlignment.Left);
			this.lvg5Beans = new ListViewGroup("5 Beans", HorizontalAlignment.Left);
			this.lvg6Beans = new ListViewGroup("6 Beans", HorizontalAlignment.Left);
			this.lvg7Beans = new ListViewGroup("7 Beans", HorizontalAlignment.Left);
			this.lvg7Beans_1 = new ListViewGroup("8 Beans", HorizontalAlignment.Left);
			foreach (Class322 @class in Class322.readOnlyCollection_0)
			{
				ListViewItem listViewItem = new ListViewItemState<Class322>(@class, @class.ToString());
				switch (@class.CombinationSize)
				{
				case 1:
					listViewItem.Group = this.lvg1Bean;
					break;
				case 2:
					listViewItem.Group = this.lvg2Beans;
					break;
				case 3:
					listViewItem.Group = this.lvg3Beans;
					break;
				case 4:
					listViewItem.Group = this.lvg4Beans;
					break;
				case 5:
					listViewItem.Group = this.lvg5Beans;
					break;
				case 6:
					listViewItem.Group = this.lvg6Beans;
					break;
				case 7:
					listViewItem.Group = this.lvg7Beans;
					break;
				case 8:
					listViewItem.Group = this.lvg7Beans_1;
					break;
				}
				this.Items.Add(listViewItem);
				this.dictionary_0.Add(@class, listViewItem);
			}
			this.lvg1Bean.Header = "1 Bean";
			this.lvg1Bean.Name = "lvg1Bean";
			this.lvg2Beans.Header = "2 Beans";
			this.lvg2Beans.Name = "lvg2Beans";
			this.lvg3Beans.Header = "3 Beans";
			this.lvg3Beans.Name = "lvg3Beans";
			this.lvg4Beans.Header = "4 Beans";
			this.lvg4Beans.Name = "lvg4Beans";
			this.lvg5Beans.Header = "5 Beans";
			this.lvg5Beans.Name = "lvg5Beans";
			this.lvg6Beans.Header = "6 Beans";
			this.lvg6Beans.Name = "lvg6Beans";
			this.lvg7Beans.Header = "7 Beans";
			this.lvg7Beans.Name = "lvg7Beans";
			this.lvg7Beans_1.Header = "8 Beans";
			this.lvg7Beans_1.Name = "lvg7Beans";
			base.Groups.AddRange(new ListViewGroup[]
			{
				this.lvg1Bean,
				this.lvg2Beans,
				this.lvg3Beans,
				this.lvg4Beans,
				this.lvg5Beans,
				this.lvg6Beans,
				this.lvg7Beans,
				this.lvg7Beans_1
			});
			base.EndUpdate();
			base.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000785C0 File Offset: 0x000767C0
		public void method_0(Class322 combo)
		{
			base.SelectedItems.Clear();
			if (combo != null)
			{
				ListViewItem listViewItem = this.dictionary_0[combo];
				listViewItem.Selected = true;
				base.Select();
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000785F8 File Offset: 0x000767F8
		public void method_1(int group)
		{
			switch (group + 1)
			{
			case 1:
				this.method_2(this.lvg1Bean);
				return;
			case 2:
				this.method_2(this.lvg2Beans);
				return;
			case 3:
				this.method_2(this.lvg3Beans);
				return;
			case 4:
				this.method_2(this.lvg4Beans);
				return;
			case 5:
				this.method_2(this.lvg5Beans);
				return;
			case 6:
				this.method_2(this.lvg6Beans);
				return;
			case 7:
				this.method_2(this.lvg7Beans);
				return;
			case 8:
				this.method_2(this.lvg7Beans_1);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0007869C File Offset: 0x0007689C
		private void method_2(ListViewGroup grp)
		{
			base.BeginUpdate();
			foreach (object obj in this.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Checked = (listViewItem.Group == grp);
			}
			base.EndUpdate();
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0000F413 File Offset: 0x0000D613
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0000F432 File Offset: 0x0000D632
		private void method_3()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x0400105B RID: 4187
		private ListViewGroup lvg1Bean;

		// Token: 0x0400105C RID: 4188
		private ListViewGroup lvg2Beans;

		// Token: 0x0400105D RID: 4189
		private ListViewGroup lvg3Beans;

		// Token: 0x0400105E RID: 4190
		private ListViewGroup lvg4Beans;

		// Token: 0x0400105F RID: 4191
		private ListViewGroup lvg5Beans;

		// Token: 0x04001060 RID: 4192
		private ListViewGroup lvg6Beans;

		// Token: 0x04001061 RID: 4193
		private ListViewGroup lvg7Beans;

		// Token: 0x04001062 RID: 4194
		private ListViewGroup lvg7Beans_1;

		// Token: 0x04001063 RID: 4195
		private ColumnHeader columnHeader_0;

		// Token: 0x04001064 RID: 4196
		private Dictionary<Class322, ListViewItem> dictionary_0;

		// Token: 0x04001065 RID: 4197
		private IContainer icontainer_0;
	}
}
