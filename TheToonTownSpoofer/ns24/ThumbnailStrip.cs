using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns16;
using ns18;
using ns19;
using ns27;
using ns30;
using ns31;

namespace ns24
{
	// Token: 0x0200032F RID: 815
	internal sealed class ThumbnailStrip : UserControl
	{
		// Token: 0x06001FBE RID: 8126 RVA: 0x00068ABC File Offset: 0x00066CBC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (KeyValuePair<string, ThumbnailStrip.Class131> keyValuePair in this.dictionary_0)
				{
					keyValuePair.Value.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00068B34 File Offset: 0x00066D34
		private void InitializeComponent()
		{
			this.PreviousGroup = new Control8();
			this.NextGroup = new Control8();
			this.ThumbnailPanel = new Class264();
			base.SuspendLayout();
			this.PreviousGroup.Cursor = Cursors.Hand;
			this.PreviousGroup.Enabled = false;
			this.PreviousGroup.HoverEndColor = Color.DodgerBlue;
			this.PreviousGroup.HoverStartColor = Color.WhiteSmoke;
			this.PreviousGroup.Location = new Point(3, 76);
			this.PreviousGroup.Name = "PreviousGroup";
			this.PreviousGroup.NormalEndColor = Color.DarkGray;
			this.PreviousGroup.NormalStartColor = Color.WhiteSmoke;
			this.PreviousGroup.Rotation = 270;
			this.PreviousGroup.Size = new Size(34, 34);
			this.PreviousGroup.TabIndex = 3;
			this.PreviousGroup.TabStop = false;
			this.PreviousGroup.Text = "arrowButton2";
			this.PreviousGroup.Click += this.PreviousGroup_Click;
			this.NextGroup.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.NextGroup.Cursor = Cursors.Hand;
			this.NextGroup.Enabled = false;
			this.NextGroup.HoverEndColor = Color.DodgerBlue;
			this.NextGroup.HoverStartColor = Color.WhiteSmoke;
			this.NextGroup.Location = new Point(563, 76);
			this.NextGroup.Name = "NextGroup";
			this.NextGroup.NormalEndColor = Color.DarkGray;
			this.NextGroup.NormalStartColor = Color.WhiteSmoke;
			this.NextGroup.Rotation = 90;
			this.NextGroup.Size = new Size(34, 34);
			this.NextGroup.TabIndex = 2;
			this.NextGroup.TabStop = false;
			this.NextGroup.Text = "arrowButton1";
			this.NextGroup.Click += this.NextGroup_Click;
			this.ThumbnailPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ThumbnailPanel.AutoScroll = true;
			this.ThumbnailPanel.BorderStyle = BorderStyle.Fixed3D;
			this.ThumbnailPanel.Location = new Point(40, 3);
			this.ThumbnailPanel.Name = "ThumbnailPanel";
			this.ThumbnailPanel.Size = new Size(520, 180);
			this.ThumbnailPanel.TabIndex = 1;
			this.ThumbnailPanel.WrapContents = false;
			this.ThumbnailPanel.PreviewKeyDown += this.ThumbnailPanel_PreviewKeyDown;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.PreviousGroup);
			base.Controls.Add(this.NextGroup);
			base.Controls.Add(this.ThumbnailPanel);
			base.Name = "ThumbnailStrip";
			base.Size = new Size(600, 186);
			base.ResumeLayout(false);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00068E44 File Offset: 0x00067044
		public ThumbnailStrip()
		{
			this.InitializeComponent();
			this.int_0 = -1;
			this.dictionary_0 = new Dictionary<string, ThumbnailStrip.Class131>(StringComparer.OrdinalIgnoreCase);
			this.class299_0 = new Class299<ThumbnailStrip.Class131>(50);
			this.class299_0.GroupCreated += this.method_4;
			this.class299_0.GroupDestroyed += this.method_3;
			this.class299_0.ItemAdded += this.method_2;
			this.class299_0.ItemMoved += this.method_1;
			this.class299_0.ItemRemoved += this.method_0;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00068EF4 File Offset: 0x000670F4
		private void method_0(object sender, EventArgs6<ThumbnailStrip.Class131> e)
		{
			this.dictionary_0.Remove(e.Item.class140_0.FileName);
			int num = e.GroupIndex;
			if (this.int_0 == num)
			{
				this.ThumbnailPanel.Controls.Remove(e.Item.thumbnailContainer_0);
			}
			if (e.Item == this.class131_0)
			{
				ThumbnailStrip.Class131 @class;
				if (e.RemovedIndex == this.class299_0.Elements)
				{
					if (this.class299_0.Elements > 0)
					{
						@class = this.class299_0.method_4(this.class299_0.Elements - 1);
					}
					else
					{
						@class = null;
					}
				}
				else
				{
					@class = this.class299_0.method_4(e.RemovedIndex);
				}
				if (@class != null)
				{
					num = this.class299_0.method_2(@class);
					if (this.int_0 != num)
					{
						this.method_8(num, false);
					}
					@class.thumbnailContainer_0.Selected = true;
					if (this.myGalleryViewer_0 != null)
					{
						this.method_11(@class);
					}
				}
			}
			e.Item.Dispose();
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00068FF4 File Offset: 0x000671F4
		private void method_1(object sender, EventArgs4<ThumbnailStrip.Class131> e)
		{
			if (e.NewGroup == this.int_0)
			{
				this.ThumbnailPanel.Controls.Add(e.Item.thumbnailContainer_0);
				return;
			}
			if (e.PreviousGroup == this.int_0)
			{
				this.ThumbnailPanel.Controls.Remove(e.Item.thumbnailContainer_0);
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0000CBFF File Offset: 0x0000ADFF
		private void method_2(object sender, EventArgs5<ThumbnailStrip.Class131> e)
		{
			if (this.int_0 == e.Group)
			{
				this.ThumbnailPanel.Controls.Add(e.Item.thumbnailContainer_0);
			}
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00069054 File Offset: 0x00067254
		private void method_3(object sender, EventArgs35 e)
		{
			if (this.int_0 == this.class299_0.Groups && this.int_0 > 0)
			{
				this.method_8(this.int_0 - 1, true);
			}
			this.PreviousGroup.Enabled = (this.NextGroup.Enabled = (this.class299_0.Groups > 1));
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000690B4 File Offset: 0x000672B4
		private void method_4(object sender, EventArgs35 e)
		{
			if (this.int_0 == -1)
			{
				this.int_0 = e.Group;
			}
			this.PreviousGroup.Enabled = (this.NextGroup.Enabled = (this.class299_0.Groups > 1));
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00069100 File Offset: 0x00067300
		public void method_5(IEnumerable<Class140> items)
		{
			List<Class140> list = new List<Class140>(items);
			List<Class140> list2 = list;
			if (ThumbnailStrip.comparison_0 == null)
			{
				ThumbnailStrip.comparison_0 = new Comparison<Class140>(ThumbnailStrip.smethod_0);
			}
			list2.Sort(ThumbnailStrip.comparison_0);
			foreach (Class140 data in list)
			{
				this.method_6(data);
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0006917C File Offset: 0x0006737C
		public void method_6(Class140 data)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			ThumbnailStrip.Class314 @class = new ThumbnailStrip.Class314();
			@class.thumbnailStrip_0 = this;
			ThumbnailContainer thumbnailContainer = null;
			@class.class131_0 = null;
			try
			{
				thumbnailContainer = new ThumbnailContainer();
				thumbnailContainer.Size = new Size(178, 146);
				thumbnailContainer.FileName = data.FileName;
				thumbnailContainer.Image = data.bitmap_0;
				@class.class131_0 = new ThumbnailStrip.Class131(data, thumbnailContainer);
				ThumbnailContainer thumbnailContainer2 = thumbnailContainer;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(@class.method_0);
				}
				thumbnailContainer2.ButtonSelected += eventHandler;
				ThumbnailContainer thumbnailContainer3 = thumbnailContainer;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(@class.method_1);
				}
				thumbnailContainer3.ShowScreenshot += eventHandler2;
				this.dictionary_0.Add(@class.class131_0.class140_0.FileName, @class.class131_0);
				this.class299_0.method_0(@class.class131_0);
			}
			catch
			{
				if (thumbnailContainer != null)
				{
					thumbnailContainer.Dispose();
				}
				if (@class.class131_0 != null)
				{
					@class.class131_0.Dispose();
				}
				throw;
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00069274 File Offset: 0x00067474
		public bool method_7(string fileName)
		{
			if (this.dictionary_0.ContainsKey(fileName))
			{
				ThumbnailStrip.Class131 item = this.dictionary_0[fileName];
				this.class299_0.method_1(item);
				return true;
			}
			return false;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0000CC2A File Offset: 0x0000AE2A
		private void NextGroup_Click(object sender, EventArgs e)
		{
			if (this.int_0 < this.class299_0.Groups - 1)
			{
				this.method_8(this.int_0 + 1, false);
				return;
			}
			this.method_8(0, false);
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0000CC59 File Offset: 0x0000AE59
		private void PreviousGroup_Click(object sender, EventArgs e)
		{
			if (this.int_0 > 0)
			{
				this.method_8(this.int_0 - 1, true);
				return;
			}
			this.method_8(this.class299_0.Groups - 1, true);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000692AC File Offset: 0x000674AC
		private void method_8(int groupIndex, bool scrollToEnd = false)
		{
			if (this.int_0 == groupIndex)
			{
				return;
			}
			this.int_0 = groupIndex;
			this.ThumbnailPanel.SuspendLayout();
			this.ThumbnailPanel.Controls.Clear();
			ThumbnailStrip.Class131 @class = null;
			foreach (ThumbnailStrip.Class131 class2 in this.class299_0[groupIndex])
			{
				if (!scrollToEnd && @class == null)
				{
					@class = class2;
				}
				this.ThumbnailPanel.Controls.Add(class2.thumbnailContainer_0);
				if (scrollToEnd)
				{
					@class = class2;
				}
			}
			this.ThumbnailPanel.ResumeLayout();
			if (@class != null)
			{
				this.ThumbnailPanel.method_0(@class.thumbnailContainer_0);
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0006936C File Offset: 0x0006756C
		public void method_9()
		{
			if (this.class131_0 == null)
			{
				return;
			}
			int num = this.class299_0.method_3(this.class131_0);
			if (num == this.class299_0.Elements - 1)
			{
				num = 0;
			}
			else
			{
				num++;
			}
			ThumbnailStrip.Class131 @class = this.class299_0.method_4(num);
			this.method_8(this.class299_0.method_2(@class), false);
			@class.thumbnailContainer_0.Selected = true;
			if (this.myGalleryViewer_0 != null)
			{
				this.method_11(@class);
			}
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000693E8 File Offset: 0x000675E8
		public void method_10()
		{
			if (this.class131_0 == null)
			{
				return;
			}
			int num = this.class299_0.method_3(this.class131_0);
			if (num == 0)
			{
				num = this.class299_0.Elements - 1;
			}
			else
			{
				num--;
			}
			ThumbnailStrip.Class131 @class = this.class299_0.method_4(num);
			this.method_8(this.class299_0.method_2(@class), false);
			@class.thumbnailContainer_0.Selected = true;
			if (this.myGalleryViewer_0 != null)
			{
				this.method_11(@class);
			}
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00069464 File Offset: 0x00067664
		protected override void OnLoad(EventArgs args)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			FormClosingEventHandler formClosingEventHandler = null;
			if (!base.DesignMode && base.ParentForm != null)
			{
				Control parentForm = base.ParentForm;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_12);
				}
				parentForm.Resize += eventHandler;
				Form parentForm2 = base.ParentForm;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(this.method_13);
				}
				parentForm2.Activated += eventHandler2;
				Form parentForm3 = base.ParentForm;
				if (formClosingEventHandler == null)
				{
					formClosingEventHandler = new FormClosingEventHandler(this.method_14);
				}
				parentForm3.FormClosing += formClosingEventHandler;
			}
			base.OnLoad(args);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x000694E4 File Offset: 0x000676E4
		private void method_11(ThumbnailStrip.Class131 thumb)
		{
			FormClosedEventHandler formClosedEventHandler = null;
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			if (this.myGalleryViewer_0 == null)
			{
				this.myGalleryViewer_0 = new MyGalleryViewer();
				Form form = this.myGalleryViewer_0;
				if (formClosedEventHandler == null)
				{
					formClosedEventHandler = new FormClosedEventHandler(this.method_15);
				}
				form.FormClosed += formClosedEventHandler;
				Control control = this.myGalleryViewer_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_16);
				}
				control.Resize += eventHandler;
				Form form2 = this.myGalleryViewer_0;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(this.method_17);
				}
				form2.Activated += eventHandler2;
				MyGalleryViewer myGalleryViewer = this.myGalleryViewer_0;
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(this.method_18);
				}
				myGalleryViewer.ShowNextImage += eventHandler3;
				MyGalleryViewer myGalleryViewer2 = this.myGalleryViewer_0;
				if (eventHandler4 == null)
				{
					eventHandler4 = new EventHandler(this.method_19);
				}
				myGalleryViewer2.ShowPreviousImage += eventHandler4;
				this.myGalleryViewer_0.Show();
			}
			this.myGalleryViewer_0.method_1(thumb.class140_0.FilePath);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0003220C File Offset: 0x0003040C
		private void ThumbnailPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Tab)
			{
				return;
			}
			e.IsInputKey = true;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000695C4 File Offset: 0x000677C4
		[CompilerGenerated]
		private static int smethod_0(Class140 x, Class140 y)
		{
			return x.DateCreated.CompareTo(y.DateCreated);
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0000CC88 File Offset: 0x0000AE88
		[CompilerGenerated]
		private void method_12(object sender, EventArgs e)
		{
			if (this.myGalleryViewer_0 != null)
			{
				this.myGalleryViewer_0.WindowState = base.ParentForm.WindowState;
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[CompilerGenerated]
		private void method_13(object sender, EventArgs e)
		{
			if (this.myGalleryViewer_0 != null)
			{
				Class410.smethod_10(base.ParentForm, this.myGalleryViewer_0);
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0000CCC3 File Offset: 0x0000AEC3
		[CompilerGenerated]
		private void method_14(object sender, FormClosingEventArgs e)
		{
			if (this.myGalleryViewer_0 != null)
			{
				this.myGalleryViewer_0.Close();
			}
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[CompilerGenerated]
		private void method_15(object sender, FormClosedEventArgs e)
		{
			this.myGalleryViewer_0.Dispose();
			this.myGalleryViewer_0 = null;
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000695E8 File Offset: 0x000677E8
		[CompilerGenerated]
		private void method_16(object sender, EventArgs e)
		{
			switch (this.myGalleryViewer_0.WindowState)
			{
			case FormWindowState.Normal:
			case FormWindowState.Minimized:
				base.ParentForm.WindowState = this.myGalleryViewer_0.WindowState;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		[CompilerGenerated]
		private void method_17(object sender, EventArgs e)
		{
			Class410.smethod_10(this.myGalleryViewer_0, base.ParentForm);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0000CCFF File Offset: 0x0000AEFF
		[CompilerGenerated]
		private void method_18(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0000CD07 File Offset: 0x0000AF07
		[CompilerGenerated]
		private void method_19(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x04000C4D RID: 3149
		private IContainer icontainer_0;

		// Token: 0x04000C4E RID: 3150
		private Class264 ThumbnailPanel;

		// Token: 0x04000C4F RID: 3151
		private Control8 NextGroup;

		// Token: 0x04000C50 RID: 3152
		private Control8 PreviousGroup;

		// Token: 0x04000C51 RID: 3153
		private readonly Class299<ThumbnailStrip.Class131> class299_0;

		// Token: 0x04000C52 RID: 3154
		private readonly Dictionary<string, ThumbnailStrip.Class131> dictionary_0;

		// Token: 0x04000C53 RID: 3155
		private MyGalleryViewer myGalleryViewer_0;

		// Token: 0x04000C54 RID: 3156
		private ThumbnailStrip.Class131 class131_0;

		// Token: 0x04000C55 RID: 3157
		private int int_0;

		// Token: 0x04000C56 RID: 3158
		[CompilerGenerated]
		private static Comparison<Class140> comparison_0;

		// Token: 0x02000330 RID: 816
		private sealed class Class131 : Class123
		{
			// Token: 0x06001FDA RID: 8154 RVA: 0x0000CD0F File Offset: 0x0000AF0F
			public Class131(Class140 data, ThumbnailContainer control)
			{
				this.class140_0 = data;
				this.thumbnailContainer_0 = control;
			}

			// Token: 0x06001FDB RID: 8155 RVA: 0x0000CD25 File Offset: 0x0000AF25
			protected override void vmethod_0()
			{
				this.thumbnailContainer_0.Dispose();
				base.vmethod_0();
			}

			// Token: 0x04000C57 RID: 3159
			public Class140 class140_0;

			// Token: 0x04000C58 RID: 3160
			public ThumbnailContainer thumbnailContainer_0;
		}

		// Token: 0x02000331 RID: 817
		[CompilerGenerated]
		private sealed class Class314
		{
			// Token: 0x06001FDD RID: 8157 RVA: 0x00069628 File Offset: 0x00067828
			public void method_0(object sender, EventArgs e)
			{
				if (this.thumbnailStrip_0.class131_0 != this.class131_0)
				{
					if (this.thumbnailStrip_0.class131_0 != null)
					{
						this.thumbnailStrip_0.class131_0.thumbnailContainer_0.Selected = false;
					}
					this.thumbnailStrip_0.class131_0 = this.class131_0;
				}
				this.thumbnailStrip_0.ThumbnailPanel.method_0(this.thumbnailStrip_0.class131_0.thumbnailContainer_0);
			}

			// Token: 0x06001FDE RID: 8158 RVA: 0x0000CD38 File Offset: 0x0000AF38
			public void method_1(object sender, EventArgs e)
			{
				this.thumbnailStrip_0.method_11(this.class131_0);
			}

			// Token: 0x04000C59 RID: 3161
			public ThumbnailStrip.Class131 class131_0;

			// Token: 0x04000C5A RID: 3162
			public ThumbnailStrip thumbnailStrip_0;
		}
	}
}
