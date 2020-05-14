using System;
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
using ns22;
using ns23;
using ns25;
using ns26;
using ns27;
using TSN.Controls;

namespace ns31
{
	// Token: 0x020002CF RID: 719
	internal sealed partial class CustomizeContentPack : Form
	{
		// Token: 0x06001CA6 RID: 7334 RVA: 0x0005C5CC File Offset: 0x0005A7CC
		public CustomizeContentPack(Class102 settings)
		{
			this.InitializeComponent();
			this.Text = string.Format("Customizing {0} Content Pack", string.IsNullOrEmpty(settings.Name) ? "Untitled" : settings.Name);
			base.Icon = Class480.Content_Icon;
			this.class374_0 = new Class374();
			this.class102_0 = settings;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0000ADCB File Offset: 0x00008FCB
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			this.class374_0.method_2(new Action<object>(this.method_6));
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0005C62C File Offset: 0x0005A82C
		private void OKButton_Click(object sender, EventArgs e)
		{
			CustomizeContentPack.Class259 @class = new CustomizeContentPack.Class259();
			@class.customizeContentPack_0 = this;
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			@class.listViewItemState_0 = new ListViewItemState<string>[this.FilesList.Items.Count];
			this.FilesList.Items.CopyTo(@class.listViewItemState_0, 0);
			this.class374_0.method_2(new Action<object>(@class.method_0));
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		private void CustomizeContentPack_FormClosing(object sender, FormClosingEventArgs e)
		{
			Action<object> action = null;
			if (!this.bool_0)
			{
				e.Cancel = true;
				this.bool_0 = true;
				Class374 @class = this.class374_0;
				if (action == null)
				{
					action = new Action<object>(this.method_8);
				}
				@class.method_2(action);
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0005C6E4 File Offset: 0x0005A8E4
		private bool method_0(string file)
		{
			foreach (Class102 @class in Class110.Instance.ConnectSettings.ContentPacks)
			{
				if (@class != this.class102_0 && @class.InstallState != Enum76.const_0 && @class.dictionary_0.ContainsKey(file))
				{
					switch (@class.dictionary_0[file].enum76_0)
					{
					case Enum76.const_1:
					case Enum76.const_2:
					case Enum76.const_3:
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0005C788 File Offset: 0x0005A988
		private void CustomizeContentPack_Shown(object sender, EventArgs e)
		{
			EventHandler eventHandler = null;
			CustomizeContentPack.Class260 @class = new CustomizeContentPack.Class260();
			@class.customizeContentPack_0 = this;
			@class.loading_0 = new Loading();
			try
			{
				Form loading_ = @class.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(@class.method_0);
				}
				loading_.Shown += eventHandler;
				@class.loading_0.ShowDialog();
			}
			finally
			{
				if (@class.loading_0 != null)
				{
					((IDisposable)@class.loading_0).Dispose();
				}
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0005C800 File Offset: 0x0005AA00
		private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			if (this.FilesList.SelectedItems.Count == 0)
			{
				this.class374_0.method_2(new Action<object>(this.method_1));
				return;
			}
			this.class374_0.method_3(new Action<object>(this.method_1), this.FilesList.SelectedItems[0].Text);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0005C870 File Offset: 0x0005AA70
		private void method_1(object state)
		{
			string text = state as string;
			if (string.IsNullOrEmpty(text))
			{
				this.class374_0.method_4(new Action<object>(this.method_4));
				this.class374_0.method_4(new Action<object>(this.method_2));
				return;
			}
			byte[] array = null;
			if (this.class132_0.Data.MultiFileData.ContainsKey(text))
			{
				Class338 @class = this.class132_0.Data.MultiFileData[text];
				array = @class.Data;
			}
			switch (Class136.smethod_4(text))
			{
			case Enum68.const_0:
				break;
			case Enum68.const_1:
				this.class374_0.method_5(new Action<object>(this.method_2), Class429.smethod_0(array, null));
				this.class374_0.method_4(new Action<object>(this.method_4));
				return;
			case Enum68.const_2:
				using (MemoryStream memoryStream = new MemoryStream(array))
				{
					this.class374_0.method_5(new Action<object>(this.method_2), new Class429(Class486.smethod_2(memoryStream), null));
				}
				this.class374_0.method_4(new Action<object>(this.method_4));
				return;
			case Enum68.const_3:
			case Enum68.const_4:
			case Enum68.const_5:
				this.class374_0.method_5(new Action<object>(this.method_4), new Class355(text, array, null));
				this.class374_0.method_4(new Action<object>(this.method_2));
				break;
			default:
				return;
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0005C9E8 File Offset: 0x0005ABE8
		private void method_2(object state)
		{
			CustomizeContentPack.Class262 @class = new CustomizeContentPack.Class262();
			@class.customizeContentPack_0 = this;
			@class.class429_0 = (state as Class429);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0005CA20 File Offset: 0x0005AC20
		private void method_3(Class429 gr)
		{
			if (gr != null && gr.UserGraphicData != null)
			{
				this.picUserContent.Image = gr.UserGraphicData;
				this.picUserContent.Size = this.picUserContent.Image.Size.smethod_2(224, 244);
			}
			else
			{
				this.picUserContent.Image = null;
			}
			if (this.class429_0 != null)
			{
				this.class429_0.Dispose();
			}
			this.class429_0 = gr;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0005CA9C File Offset: 0x0005AC9C
		private void method_4(object state)
		{
			CustomizeContentPack.Class263 @class = new CustomizeContentPack.Class263();
			@class.customizeContentPack_0 = this;
			@class.class355_0 = (state as Class355);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0005CAD4 File Offset: 0x0005ACD4
		private void method_5(Class355 audioData)
		{
			if (audioData == null)
			{
				this.wmpUserPlayer.method_2();
				this.picUserContentAudioFile.Visible = false;
				return;
			}
			if (audioData.UserAudioData == null)
			{
				this.wmpUserPlayer.method_2();
			}
			else
			{
				this.wmpUserPlayer.method_0(audioData.AudioFile, audioData.UserAudioData);
			}
			this.picUserContentAudioFile.Visible = true;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		private void CheckAvailableButton_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_10));
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0000AE16 File Offset: 0x00009016
		private void CheckAllButton_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_12));
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0000AE38 File Offset: 0x00009038
		private void UncheckAllButton_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_14));
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0000AE5A File Offset: 0x0000905A
		private void CustomizeContentPack_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_18);
			e.Handled = true;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0000AE9C File Offset: 0x0000909C
		[CompilerGenerated]
		private void method_6(object _)
		{
			this.smethod_4(new MethodInvoker(this.method_7));
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0000587F File Offset: 0x00003A7F
		[CompilerGenerated]
		private void method_7()
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0000AEB0 File Offset: 0x000090B0
		[CompilerGenerated]
		private void method_8(object _)
		{
			this.smethod_4(new MethodInvoker(this.method_9));
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0000587F File Offset: 0x00003A7F
		[CompilerGenerated]
		private void method_9()
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0000AEC4 File Offset: 0x000090C4
		[CompilerGenerated]
		private void method_10(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_11));
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0005D424 File Offset: 0x0005B624
		[CompilerGenerated]
		private void method_11()
		{
			this.FilesList.BeginUpdate();
			foreach (object obj in this.FilesList.Items)
			{
				ListViewItemState<string> listViewItemState = (ListViewItemState<string>)obj;
				listViewItemState.Checked = !this.method_0(listViewItemState.Text);
			}
			this.FilesList.EndUpdate();
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0000AED8 File Offset: 0x000090D8
		[CompilerGenerated]
		private void method_12(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_13));
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0005D4A8 File Offset: 0x0005B6A8
		[CompilerGenerated]
		private void method_13()
		{
			this.FilesList.BeginUpdate();
			foreach (object obj in this.FilesList.Items)
			{
				ListViewItemState<string> listViewItemState = (ListViewItemState<string>)obj;
				listViewItemState.Checked = true;
			}
			this.FilesList.EndUpdate();
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0000AEEC File Offset: 0x000090EC
		[CompilerGenerated]
		private void method_14(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_15));
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0005D520 File Offset: 0x0005B720
		[CompilerGenerated]
		private void method_15()
		{
			this.FilesList.BeginUpdate();
			foreach (object obj in this.FilesList.Items)
			{
				ListViewItemState<string> listViewItemState = (ListViewItemState<string>)obj;
				listViewItemState.Checked = false;
			}
			this.FilesList.EndUpdate();
		}

		// Token: 0x04000A67 RID: 2663
		private Class429 class429_0;

		// Token: 0x04000A68 RID: 2664
		private Class102 class102_0;

		// Token: 0x04000A6A RID: 2666
		private Class374 class374_0;

		// Token: 0x04000A6B RID: 2667
		private bool bool_0;

		// Token: 0x020002D0 RID: 720
		[CompilerGenerated]
		private sealed class Class259
		{
			// Token: 0x06001CC3 RID: 7363 RVA: 0x0000AF00 File Offset: 0x00009100
			public void method_0(object _)
			{
				this.customizeContentPack_0.smethod_4(new MethodInvoker(this.method_1));
			}

			// Token: 0x06001CC4 RID: 7364 RVA: 0x0005D598 File Offset: 0x0005B798
			public void method_1()
			{
				foreach (ListViewItemState<string> listViewItemState in this.listViewItemState_0)
				{
					Class102.Class403 @class = this.customizeContentPack_0.class102_0.dictionary_0[listViewItemState.Text];
					switch (listViewItemState.Checked)
					{
					case false:
						switch (@class.enum76_0)
						{
						case Enum76.const_1:
							@class.enum76_0 = Enum76.const_2;
							break;
						case Enum76.const_3:
							@class.enum76_0 = Enum76.const_0;
							break;
						}
						break;
					case true:
						foreach (Class102 class2 in Class110.Instance.ConnectSettings.ContentPacks)
						{
							if (class2 != this.customizeContentPack_0.class102_0 && class2.dictionary_0.ContainsKey(listViewItemState.Text))
							{
								Enum76 installState = class2.InstallState;
								if (installState == Enum76.const_0)
								{
									Enum76 enum76_ = class2.dictionary_0[listViewItemState.Text].enum76_0;
									if (enum76_ == Enum76.const_3)
									{
										class2.dictionary_0[listViewItemState.Text].enum76_0 = Enum76.const_0;
									}
								}
								else
								{
									switch (class2.dictionary_0[listViewItemState.Text].enum76_0)
									{
									case Enum76.const_1:
										class2.dictionary_0[listViewItemState.Text].enum76_0 = Enum76.const_2;
										break;
									case Enum76.const_3:
										class2.dictionary_0[listViewItemState.Text].enum76_0 = Enum76.const_0;
										break;
									}
								}
							}
						}
						switch (@class.enum76_0)
						{
						case Enum76.const_0:
							@class.enum76_0 = Enum76.const_3;
							break;
						case Enum76.const_2:
							@class.enum76_0 = Enum76.const_1;
							break;
						}
						break;
					}
				}
				this.customizeContentPack_0.DialogResult = DialogResult.OK;
				this.customizeContentPack_0.Close();
			}

			// Token: 0x04000A7A RID: 2682
			public ListViewItemState<string>[] listViewItemState_0;

			// Token: 0x04000A7B RID: 2683
			public CustomizeContentPack customizeContentPack_0;
		}

		// Token: 0x020002D1 RID: 721
		[CompilerGenerated]
		private sealed class Class260
		{
			// Token: 0x06001CC6 RID: 7366 RVA: 0x0000AF19 File Offset: 0x00009119
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001CC7 RID: 7367 RVA: 0x0005D798 File Offset: 0x0005B998
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				CustomizeContentPack.Class260.Class261 @class = new CustomizeContentPack.Class260.Class261();
				@class.class260_0 = this;
				@class.hashSet_0 = null;
				try
				{
					this.customizeContentPack_0.class132_0 = new Class132(this.customizeContentPack_0.class102_0.FileName, false, true);
					@class.hashSet_0 = new HashSet<ListViewItemState<string>>();
					foreach (KeyValuePair<string, Class102.Class403> keyValuePair in this.customizeContentPack_0.class102_0.dictionary_0)
					{
						ListViewItemState<string> listViewItemState = new ListViewItemState<string>(keyValuePair.Key);
						if (this.customizeContentPack_0.method_0(keyValuePair.Key))
						{
							listViewItemState.ForeColor = Color.Red;
							switch (keyValuePair.Value.enum76_0)
							{
							case Enum76.const_1:
							case Enum76.const_3:
								listViewItemState.Checked = true;
								break;
							}
						}
						else
						{
							switch (keyValuePair.Value.enum76_0)
							{
							case Enum76.const_0:
								listViewItemState.ForeColor = Color.DarkGray;
								break;
							case Enum76.const_1:
							case Enum76.const_3:
								listViewItemState.ForeColor = Color.Green;
								listViewItemState.Checked = true;
								break;
							case Enum76.const_2:
								listViewItemState.ForeColor = Color.Black;
								break;
							}
						}
						@class.hashSet_0.Add(listViewItemState);
					}
				}
				finally
				{
					Control sender = this.customizeContentPack_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					sender.smethod_4(methodInvoker);
				}
			}

			// Token: 0x04000A7C RID: 2684
			public Loading loading_0;

			// Token: 0x04000A7D RID: 2685
			public CustomizeContentPack customizeContentPack_0;

			// Token: 0x020002D2 RID: 722
			private sealed class Class261
			{
				// Token: 0x06001CC9 RID: 7369 RVA: 0x0005D938 File Offset: 0x0005BB38
				public void method_0()
				{
					if (this.hashSet_0 != null)
					{
						ListViewItemState<string>[] array = this.hashSet_0.ToArray<ListViewItemState<string>>();
						Array.Sort<ListViewItemState<string>>(array, Class236.Default);
						this.class260_0.customizeContentPack_0.FilesList.Items.AddRange(array);
					}
					this.class260_0.loading_0.method_1();
				}

				// Token: 0x04000A7E RID: 2686
				public CustomizeContentPack.Class260 class260_0;

				// Token: 0x04000A7F RID: 2687
				public HashSet<ListViewItemState<string>> hashSet_0;
			}
		}

		// Token: 0x020002D3 RID: 723
		[CompilerGenerated]
		private sealed class Class262
		{
			// Token: 0x06001CCB RID: 7371 RVA: 0x0000AF2E File Offset: 0x0000912E
			public void method_0()
			{
				this.customizeContentPack_0.method_3(this.class429_0);
			}

			// Token: 0x04000A80 RID: 2688
			public Class429 class429_0;

			// Token: 0x04000A81 RID: 2689
			public CustomizeContentPack customizeContentPack_0;
		}

		// Token: 0x020002D4 RID: 724
		[CompilerGenerated]
		private sealed class Class263
		{
			// Token: 0x06001CCD RID: 7373 RVA: 0x0000AF41 File Offset: 0x00009141
			public void method_0()
			{
				this.customizeContentPack_0.method_5(this.class355_0);
			}

			// Token: 0x04000A82 RID: 2690
			public Class355 class355_0;

			// Token: 0x04000A83 RID: 2691
			public CustomizeContentPack customizeContentPack_0;
		}
	}
}
