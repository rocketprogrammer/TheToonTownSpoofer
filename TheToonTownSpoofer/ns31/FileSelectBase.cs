using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns17;
using ns18;
using ns22;
using ns23;
using ns26;
using ns27;
using ns29;

namespace ns31
{
	// Token: 0x020002CC RID: 716
	internal partial class FileSelectBase : Form
	{
		// Token: 0x06001C84 RID: 7300 RVA: 0x0000ABF9 File Offset: 0x00008DF9
		public FileSelectBase()
		{
			this.InitializeComponent();
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0000AC07 File Offset: 0x00008E07
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0000AC0F File Offset: 0x00008E0F
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class524 SelectedFileInfo { get; private set; }

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0000AC18 File Offset: 0x00008E18
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0000AC20 File Offset: 0x00008E20
		public string InputLabelMessage { get; set; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0000AC29 File Offset: 0x00008E29
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000AC31 File Offset: 0x00008E31
		public string InputText { get; set; }

		// Token: 0x14000181 RID: 385
		// (add) Token: 0x06001C8B RID: 7307 RVA: 0x0005C22C File Offset: 0x0005A42C
		// (remove) Token: 0x06001C8C RID: 7308 RVA: 0x0005C264 File Offset: 0x0005A464
		public event EventHandler<EventArgs43<string>> InputValidating
		{
			add
			{
				EventHandler<EventArgs43<string>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<string>> value2 = (EventHandler<EventArgs43<string>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<string>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs43<string>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<string>> value2 = (EventHandler<EventArgs43<string>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<string>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0000AC3A File Offset: 0x00008E3A
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0005C29C File Offset: 0x0005A49C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class524[] FileInfo
		{
			get
			{
				return this.lbFiles.Items.OfType<Class524>().ToArray<Class524>();
			}
			set
			{
				this.lbFiles.BeginUpdate();
				this.lbFiles.Sorted = false;
				this.lbFiles.Items.Clear();
				this.lbFiles.Items.AddRange(value);
				this.lbFiles.Sorted = true;
				this.lbFiles.EndUpdate();
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0000AC51 File Offset: 0x00008E51
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000AC5E File Offset: 0x00008E5E
		public string Filter
		{
			get
			{
				return this.openFileDialog_0.Filter;
			}
			set
			{
				this.openFileDialog_0.Filter = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0000AC6C File Offset: 0x00008E6C
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0000AC74 File Offset: 0x00008E74
		public string InstallFolder { get; set; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0000AC7D File Offset: 0x00008E7D
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000AC85 File Offset: 0x00008E85
		public string FileExtension { get; set; }

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000AC8E File Offset: 0x00008E8E
		public void method_0<T>() where T : StringInputFormBase
		{
			this.type_0 = typeof(T);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (this.method_2())
			{
				this.method_1();
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		private void method_1()
		{
			this.SelectedFileInfo = (this.lbFiles.SelectedItem as Class524);
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00006181 File Offset: 0x00004381
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.method_2())
			{
				Class524 @class = this.lbFiles.SelectedItem as Class524;
				if (DialogBox.smethod_6(string.Format(FileSelectBase.string_3, @class.string_0), FileSelectBase.string_4, new Enum39[]
				{
					Enum39.const_5,
					Enum39.const_6
				}) == DialogResult.Yes)
				{
					Class369.smethod_3(@class.string_1);
					this.lbFiles.Items.Remove(@class);
				}
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0005C368 File Offset: 0x0005A568
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			EventHandler<EventArgs43<string>> eventHandler = null;
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				FileSelectBase.Class258 @class = new FileSelectBase.Class258();
				@class.string_0 = this.openFileDialog_0.FileName.ToLower(CultureInfo.InstalledUICulture);
				@class.class524_0 = null;
				if (this.FileInfo.smethod_10(new Func<Class524, bool>(@class.method_0)))
				{
					this.SelectedFileInfo = @class.class524_0;
					base.DialogResult = DialogResult.OK;
					return;
				}
				Type typeFromHandle = typeof(StringInputFormBase);
				if (this.type_0 != null)
				{
					typeFromHandle = this.type_0;
				}
				using (StringInputFormBase stringInputFormBase = (StringInputFormBase)Activator.CreateInstance(typeFromHandle))
				{
					stringInputFormBase.LabelMessage = this.InputLabelMessage;
					stringInputFormBase.Text = this.InputText;
					StringInputFormBase stringInputFormBase2 = stringInputFormBase;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs43<string>>(this.method_3);
					}
					stringInputFormBase2.InputValidating += eventHandler;
					if (stringInputFormBase.ShowDialog() == DialogResult.OK)
					{
						if (this.InstallFolder != null && !Class336.smethod_0(this.InstallFolder, Path.GetDirectoryName(@class.string_0)))
						{
							if (string.IsNullOrEmpty(this.FileExtension))
							{
								throw new InvalidOperationException(FileSelectBase.string_0);
							}
							string destFileName = Class266.smethod_2(this.InstallFolder, this.FileExtension);
							try
							{
								File.Copy(@class.string_0, destFileName);
							}
							catch (Exception ex)
							{
								DialogBox.smethod_7(ex, @class.string_0);
								return;
							}
							@class.string_0 = destFileName;
						}
						this.SelectedFileInfo = new Class524(stringInputFormBase.Value, @class.string_0);
						this.lbFiles.Items.Add(new Class524(this.SelectedFileInfo.string_0, this.SelectedFileInfo.string_1));
						base.DialogResult = DialogResult.OK;
					}
				}
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0000ACCF File Offset: 0x00008ECF
		private void btnLocate_Click(object sender, EventArgs e)
		{
			if (this.method_2())
			{
				Class512.smethod_1((this.lbFiles.SelectedItem as Class524).string_1);
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0000ACF3 File Offset: 0x00008EF3
		private bool method_2()
		{
			if (this.lbFiles.SelectedIndex == -1)
			{
				DialogBox.smethod_3(FileSelectBase.string_1, FileSelectBase.string_2);
				return false;
			}
			return true;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0000AD15 File Offset: 0x00008F15
		private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnOpen.Enabled = (this.lbFiles.SelectedIndex > -1);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000AD30 File Offset: 0x00008F30
		private void lbFiles_DoubleClick(object sender, EventArgs e)
		{
			if (this.lbFiles.SelectedIndex > -1)
			{
				this.method_1();
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000AD46 File Offset: 0x00008F46
		[CompilerGenerated]
		private void method_3(object sender, EventArgs43<string> e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
			e.IsValid = true;
		}

		// Token: 0x04000A58 RID: 2648
		private static readonly string string_0 = "Cannot generate a filename without a valid extension.";

		// Token: 0x04000A59 RID: 2649
		private static readonly string string_1 = "Please select a file.";

		// Token: 0x04000A5A RID: 2650
		private static readonly string string_2 = "No File Selected";

		// Token: 0x04000A5B RID: 2651
		private static readonly string string_3 = "Are you sure you want to permanently delete: '{0}'?";

		// Token: 0x04000A5C RID: 2652
		private static readonly string string_4 = "Confirm delete";

		// Token: 0x04000A5D RID: 2653
		private Type type_0;

		// Token: 0x04000A5E RID: 2654
		private EventHandler<EventArgs43<string>> eventHandler_0;

		// Token: 0x04000A5F RID: 2655
		[CompilerGenerated]
		private Class524 class524_0;

		// Token: 0x04000A60 RID: 2656
		[CompilerGenerated]
		private string string_5;

		// Token: 0x04000A61 RID: 2657
		[CompilerGenerated]
		private string string_6;

		// Token: 0x04000A62 RID: 2658
		[CompilerGenerated]
		private string string_7;

		// Token: 0x04000A63 RID: 2659
		[CompilerGenerated]
		private string string_8;

		// Token: 0x020002CD RID: 717
		[CompilerGenerated]
		private sealed class Class258
		{
			// Token: 0x06001CA2 RID: 7330 RVA: 0x0005C534 File Offset: 0x0005A734
			public bool method_0(Class524 item)
			{
				this.class524_0 = item;
				return Class524.smethod_0(item, this.string_0);
			}

			// Token: 0x04000A64 RID: 2660
			public string string_0;

			// Token: 0x04000A65 RID: 2661
			public Class524 class524_0;
		}
	}
}
