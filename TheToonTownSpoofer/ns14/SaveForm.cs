using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns17;
using ns29;

namespace ns14
{
	// Token: 0x020001C9 RID: 457
	internal partial class SaveForm : Form
	{
		// Token: 0x06001482 RID: 5250 RVA: 0x00005018 File Offset: 0x00003218
		public SaveForm()
		{
			this.CanSave = true;
			this.PromptToSaveOnClose = true;
			this.InitializeComponent();
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x00005034 File Offset: 0x00003234
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000503C File Offset: 0x0000323C
		protected bool CanSave { get; set; }

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00005045 File Offset: 0x00003245
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000504D File Offset: 0x0000324D
		public bool FileModified
		{
			get
			{
				return this.bool_0;
			}
			protected set
			{
				if (!this.bool_1)
				{
					this.bool_0 = value;
					this.vmethod_7(this.class524_0, this.bool_0);
				}
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00005078 File Offset: 0x00003278
		private protected Class524 FileName
		{
			protected get
			{
				return this.class524_0;
			}
			private set
			{
				if (!this.bool_1)
				{
					this.class524_0 = value;
					this.vmethod_7(this.class524_0, this.bool_0);
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0000509B File Offset: 0x0000329B
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x000050A3 File Offset: 0x000032A3
		protected bool PromptToSaveOnClose { get; set; }

		// Token: 0x0600148B RID: 5259 RVA: 0x000050AC File Offset: 0x000032AC
		protected void method_0(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000050B4 File Offset: 0x000032B4
		protected void method_1(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000050BC File Offset: 0x000032BC
		protected void method_2(object sender, EventArgs e)
		{
			this.method_6(this.FileName);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000050CB File Offset: 0x000032CB
		protected void method_3(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000050D4 File Offset: 0x000032D4
		protected void method_4(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000050DC File Offset: 0x000032DC
		private void SaveForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.PromptToSaveOnClose && this.CanSave)
			{
				e.Cancel = !this.method_9();
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual void vmethod_0()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0002596C File Offset: 0x00023B6C
		protected void method_5()
		{
			this.bool_1 = true;
			try
			{
				if (this.method_9())
				{
					this.vmethod_0();
					this.bool_1 = false;
					this.FileName = null;
					this.FileModified = false;
				}
			}
			finally
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_1(Class524 fileName)
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual bool vmethod_2(Class524 fileName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000259C0 File Offset: 0x00023BC0
		protected bool method_6(Class524 fileName)
		{
			if (Class524.smethod_0(fileName, null))
			{
				return this.method_7();
			}
			string directoryName = Path.GetDirectoryName(fileName.string_1);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			this.bool_1 = true;
			bool flag;
			try
			{
				flag = this.vmethod_2(fileName);
			}
			finally
			{
				this.bool_1 = false;
			}
			if (flag)
			{
				this.FileModified = false;
			}
			return flag;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00005106 File Offset: 0x00003306
		protected virtual bool vmethod_3(out Class524 fileName)
		{
			if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				fileName = new Class524(this.saveFileDialog_0.FileName);
				return true;
			}
			fileName = null;
			return false;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00025A2C File Offset: 0x00023C2C
		protected bool method_7()
		{
			Class524 fileName;
			if (this.vmethod_3(out fileName))
			{
				bool result;
				if (result = this.method_6(fileName))
				{
					this.FileName = fileName;
					this.vmethod_1(this.FileName);
				}
				return result;
			}
			return false;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_4(Class524 fileName)
		{
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000050FD File Offset: 0x000032FD
		protected virtual bool vmethod_5(Class524 fileName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000512E File Offset: 0x0000332E
		protected virtual bool vmethod_6(out Class524 fileName)
		{
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				fileName = new Class524(this.openFileDialog_0.FileName);
				return true;
			}
			fileName = null;
			return false;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00025A64 File Offset: 0x00023C64
		protected void method_8()
		{
			if (this.method_9())
			{
				this.bool_1 = true;
				Class524 fileName;
				bool flag;
				try
				{
					flag = (this.vmethod_6(out fileName) && this.vmethod_5(fileName));
				}
				finally
				{
					this.bool_1 = false;
				}
				if (flag)
				{
					this.FileName = fileName;
					this.FileModified = false;
					this.vmethod_4(this.FileName);
				}
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_7(Class524 fileName, bool modified)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00025ACC File Offset: 0x00023CCC
		private bool method_9()
		{
			if (!this.FileModified)
			{
				return true;
			}
			switch (DialogBox.smethod_6("Would you like to save first?", "Save First", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6,
				Enum39.const_1
			}))
			{
			case DialogResult.Yes:
				return this.method_6(this.FileName);
			case DialogResult.No:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0400021D RID: 541
		private bool bool_0;

		// Token: 0x0400021E RID: 542
		private Class524 class524_0;

		// Token: 0x0400021F RID: 543
		private bool bool_1;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private bool bool_3;
	}
}
