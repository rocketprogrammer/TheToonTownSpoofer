using System;
using System.IO;
using System.Windows.Forms;
using ns17;
using ns23;
using ns29;
using ns31;

namespace ns20
{
	// Token: 0x02000452 RID: 1106
	internal static class Class462
	{
		// Token: 0x06002983 RID: 10627 RVA: 0x0009F45C File Offset: 0x0009D65C
		public static void smethod_0(Enum51 topic)
		{
			try
			{
				if (!topic.smethod_2())
				{
					topic = Enum51.const_0;
				}
				using (Control control = new Control())
				{
					control.CreateControl();
					if (File.Exists(Class291.string_24))
					{
						Control parent = control;
						string string_ = Class291.string_24;
						HelpNavigator command = HelpNavigator.TopicId;
						int num = (int)topic;
						Help.ShowHelp(parent, string_, command, num.ToString(Class217.cultureInfo_0));
					}
					else
					{
						DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, Class462.string_3, new object[]
						{
							Path.GetFileName(Class291.string_24)
						}), Class462.string_4);
					}
				}
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, Class462.string_0, new object[]
					{
						Class291.string_24
					})
				});
				DialogBox.smethod_4(Class462.string_1, Class462.string_2);
			}
		}

		// Token: 0x04001593 RID: 5523
		private static readonly string string_0 = "Help file path: '{0}'";

		// Token: 0x04001594 RID: 5524
		private static readonly string string_1 = "There was an error opening the help file.";

		// Token: 0x04001595 RID: 5525
		private static readonly string string_2 = "Error Launching Help File";

		// Token: 0x04001596 RID: 5526
		private static readonly string string_3 = "The help file {0} was not located in the install directory. Reinstalling or repairing may fix this issue.";

		// Token: 0x04001597 RID: 5527
		private static readonly string string_4 = "Help File Missing";
	}
}
