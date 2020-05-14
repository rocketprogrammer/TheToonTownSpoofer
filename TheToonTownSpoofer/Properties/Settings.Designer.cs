using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace TheToonTownSpoofer.Properties
{
	// Token: 0x020002E4 RID: 740
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	public sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0000B0B6 File Offset: 0x000092B6
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x04000AC4 RID: 2756
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
