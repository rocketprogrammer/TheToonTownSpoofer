using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;

namespace ns23
{
	// Token: 0x02000389 RID: 905
	internal static class Class356
	{
		// Token: 0x06002354 RID: 9044 RVA: 0x000771D8 File Offset: 0x000753D8
		public static void smethod_0(string[] files, string destinationDirectory)
		{
			Class356.Class357 @class = new Class356.Class357();
			@class.string_0 = files;
			@class.string_1 = destinationDirectory;
			@class.int_0 = 0;
			EventHandler eventHandler = null;
			Class356.Class358 class2 = new Class356.Class358();
			class2.class357_0 = @class;
			class2.loading_0 = new Loading();
			try
			{
				Form loading_ = class2.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class2.method_0);
				}
				loading_.Shown += eventHandler;
				class2.loading_0.ShowDialog();
			}
			finally
			{
				if (class2.loading_0 != null)
				{
					((IDisposable)class2.loading_0).Dispose();
				}
			}
			if (@class.string_0.Length == @class.int_0)
			{
				DialogBox.smethod_3(string.Format("{0} images have been successfully moved.", @class.int_0), "Images Migrated");
				return;
			}
			DialogBox.smethod_3(string.Format("{0} images have been moved. Some images could not be successfully moved.", @class.int_0), "Images Migrated");
		}

		// Token: 0x0200038A RID: 906
		[CompilerGenerated]
		private sealed class Class357
		{
			// Token: 0x0400103D RID: 4157
			public int int_0;

			// Token: 0x0400103E RID: 4158
			public string[] string_0;

			// Token: 0x0400103F RID: 4159
			public string string_1;
		}

		// Token: 0x0200038B RID: 907
		[CompilerGenerated]
		private sealed class Class358
		{
			// Token: 0x06002357 RID: 9047 RVA: 0x0000F0FF File Offset: 0x0000D2FF
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06002358 RID: 9048 RVA: 0x000772B8 File Offset: 0x000754B8
			public void method_1(object _)
			{
				foreach (string text in this.class357_0.string_0)
				{
					try
					{
						string text2 = Path.Combine(this.class357_0.string_1, Path.GetFileName(text));
						if (!File.Exists(text2))
						{
							File.Move(text, text2);
							this.class357_0.int_0++;
						}
					}
					catch (Exception ex)
					{
						ex.smethod_1(new object[]
						{
							text
						});
					}
				}
				this.loading_0.smethod_4(new MethodInvoker(this.method_2));
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x0000F114 File Offset: 0x0000D314
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x04001040 RID: 4160
			public Class356.Class357 class357_0;

			// Token: 0x04001041 RID: 4161
			public Loading loading_0;
		}
	}
}
