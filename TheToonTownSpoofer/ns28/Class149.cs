using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using ns16;
using ns20;
using ns30;
using ns31;

namespace ns28
{
	// Token: 0x020004AA RID: 1194
	internal sealed class Class149 : Class123
	{
		// Token: 0x06002C7B RID: 11387 RVA: 0x000AC250 File Offset: 0x000AA450
		public Class149(Class142 toontownWindow)
		{
			this.manualResetEventSlim_0 = new ManualResetEventSlim();
			this.timer_0 = new System.Timers.Timer();
			this.timer_0.Interval = 200.0;
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.class142_0 = toontownWindow;
			Class141 toonTownProcess = this.class142_0.ToonTownProcess;
			EventHandler value = new EventHandler(this.method_6);
			toonTownProcess.ProcessExited += value;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00014FF3 File Offset: 0x000131F3
		protected override void vmethod_0()
		{
			this.manualResetEventSlim_0.Set();
			this.method_5();
			this.manualResetEventSlim_0.Dispose();
			this.timer_0.Dispose();
			base.vmethod_0();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000AC2D8 File Offset: 0x000AA4D8
		public void method_4()
		{
			lock (this.object_0)
			{
				if (!this.timer_0.Enabled)
				{
					this.class142_0.LogMonitor.LogMonitoringPrecision = Enum92.const_2;
					this.timer_0.Enabled = true;
				}
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000AC33C File Offset: 0x000AA53C
		public void method_5()
		{
			lock (this.object_0)
			{
				if (this.timer_0.Enabled)
				{
					this.timer_0.Enabled = false;
					this.class142_0.LogMonitor.LogMonitoringPrecision = Enum92.const_1;
				}
			}
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000AC3A0 File Offset: 0x000AA5A0
		private void timer_0_Elapsed(object sender, EventArgs e)
		{
			if (!base.IsDisposingOrDisposed)
			{
				IntPtr mainWindowHandle = this.class142_0.ToonTownProcess.MainWindowHandle;
				if (this.class142_0.ToonTownProcess.ProcessOpen)
				{
					Class269.smethod_20(mainWindowHandle, this.manualResetEventSlim_0);
				}
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00015022 File Offset: 0x00013222
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			if (!base.IsDisposingOrDisposed)
			{
				this.manualResetEventSlim_0.Set();
				this.method_5();
			}
		}

		// Token: 0x04001761 RID: 5985
		private System.Timers.Timer timer_0;

		// Token: 0x04001762 RID: 5986
		private Class142 class142_0;

		// Token: 0x04001763 RID: 5987
		private ManualResetEventSlim manualResetEventSlim_0;

		// Token: 0x04001764 RID: 5988
		private readonly object object_0 = new object();
	}
}
