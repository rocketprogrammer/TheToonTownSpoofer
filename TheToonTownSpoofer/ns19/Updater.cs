using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns26;
using ns31;

namespace ns19
{
	// Token: 0x020003F2 RID: 1010
	internal sealed partial class Updater : UpdaterBase
	{
		// Token: 0x060026B2 RID: 9906 RVA: 0x000113DD File Offset: 0x0000F5DD
		public Updater(bool autoCloseOnUpToDate) : base(autoCloseOnUpToDate)
		{
			this.InitializeComponent_1();
			base.UpdateType = Class110.Instance.ApplicationSettings.UpdateType;
			base.Icon = Class283.Icon;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00089910 File Offset: 0x00087B10
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Updater));
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Logo = (Image)componentResourceManager.GetObject("$this.Logo");
			base.Name = "Updater";
			base.Title = "The ToonTown Spoofer";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
