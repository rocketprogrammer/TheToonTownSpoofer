using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns18;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns26;
using ns27;
using ns28;
using ns29;
using ns31;

namespace ns17
{
	// Token: 0x02000280 RID: 640
	internal sealed partial class Connect : Form
	{
		// Token: 0x06001AD0 RID: 6864 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		public Connect()
		{
			this.InitializeComponent();
			this.class99_0 = Class110.Instance.ConnectSettings;
			this.ShowFavoritesButton.Visible = (this.class99_0.ToonTownAccounts.Count > 0);
			switch (this.class99_0.SelectedServer)
			{
			case Enum101.const_1:
				this.OpenServerRadioButton.Checked = true;
				this.TestServerRadioButton.Checked = false;
				break;
			case Enum101.const_2:
				this.TestServerRadioButton.Checked = true;
				this.OpenServerRadioButton.Checked = false;
				break;
			}
			this.method_0();
			this.TheToonTownSpooferNewsBrowser.Navigate(new Uri(Class502.string_6));
			this.TestServerRadioButton.CheckedChanged += this.OpenServerRadioButton_CheckedChanged;
			this.OpenServerRadioButton.CheckedChanged += this.OpenServerRadioButton_CheckedChanged;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00009A60 File Offset: 0x00007C60
		private void OpenServerRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.OpenServerRadioButton.Checked)
			{
				this.class99_0.SelectedServer = Enum101.const_1;
			}
			else
			{
				this.class99_0.SelectedServer = Enum101.const_2;
			}
			if (this.class99_0.NewsType == Enum106.const_0)
			{
				this.method_0();
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00050B88 File Offset: 0x0004ED88
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void method_0()
		{
			switch (this.class99_0.NewsType)
			{
			case Enum106.const_0:
				if (this.NewsTabControl.SelectedTab != this.TTNewsTab)
				{
					this.NewsTabControl.SelectTab(this.TTNewsTab);
				}
				if (this.OpenServerRadioButton.Checked)
				{
					this.ToonTownNewsBrowser.Navigate(new Uri(Class502.string_4));
					return;
				}
				this.ToonTownNewsBrowser.Navigate(new Uri(Class502.string_5));
				return;
			case Enum106.const_1:
				if (this.NewsTabControl.SelectedTab != this.TTSNewsTab)
				{
					this.NewsTabControl.SelectTab(this.TTSNewsTab);
				}
				this.ToonTownNewsBrowser.Navigate(new Uri(Class502.string_7));
				return;
			default:
				return;
			}
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00050C48 File Offset: 0x0004EE48
		private void NewsTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NewsTabControl.SelectedTab == this.TTNewsTab)
			{
				if (this.class99_0.NewsType != Enum106.const_0)
				{
					this.class99_0.NewsType = Enum106.const_0;
					this.method_0();
					return;
				}
			}
			else if (this.NewsTabControl.SelectedTab == this.TTSNewsTab && this.class99_0.NewsType != Enum106.const_1)
			{
				this.class99_0.NewsType = Enum106.const_1;
				this.method_0();
			}
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00050CBC File Offset: 0x0004EEBC
		private void method_1()
		{
			Connect.Class220 @class = new Connect.Class220();
			@class.connect_0 = this;
			if (!Class509.CanLoginToToonTownOrDialog)
			{
				return;
			}
			Class509.InstallingOrLoggingIn = true;
			@class.string_0 = this.txtUsername.Text;
			string text = this.txtPassword.Text;
			if (string.IsNullOrEmpty(@class.string_0) || string.IsNullOrEmpty(text))
			{
				DialogBox.smethod_3(Connect.string_0, Connect.string_1);
				Class509.InstallingOrLoggingIn = false;
				return;
			}
			@class.enum101_0 = (this.TestServerRadioButton.Checked ? Enum101.const_2 : (this.OpenServerRadioButton.Checked ? Enum101.const_1 : Enum101.const_1));
			if (Class142.smethod_1(@class.enum101_0, @class.string_0) && DialogBox.smethod_6(Connect.string_2, Connect.string_3, new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) != DialogResult.Yes)
			{
				Class509.InstallingOrLoggingIn = false;
				return;
			}
			Connect.Class221 class2 = new Connect.Class221();
			class2.class147_0 = new Class147(@class.enum101_0, @class.string_0, text);
			try
			{
				EventHandler eventHandler = null;
				Connect.Class222 class3 = new Connect.Class222();
				class3.class221_0 = class2;
				class3.class220_0 = @class;
				class3.loading_0 = new Loading();
				try
				{
					Form loading_ = class3.loading_0;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(class3.method_0);
					}
					loading_.Shown += eventHandler;
					class3.loading_0.ShowDialog();
				}
				finally
				{
					if (class3.loading_0 != null)
					{
						((IDisposable)class3.loading_0).Dispose();
					}
				}
			}
			finally
			{
				if (class2.class147_0 != null)
				{
					((IDisposable)class2.class147_0).Dispose();
				}
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00009A9C File Offset: 0x00007C9C
		private void ConnectButton_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000050D4 File Offset: 0x000032D4
		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00050E54 File Offset: 0x0004F054
		private void AccountManagerButton_Click(object sender, EventArgs e)
		{
			using (SelectAccount selectAccount = new SelectAccount())
			{
				if (selectAccount.ShowDialog() == DialogResult.OK)
				{
					Class91 selectedAccount = selectAccount.SelectedAccount;
					this.method_2(selectedAccount);
				}
			}
			this.ShowFavoritesButton.Visible = (this.class99_0.ToonTownAccounts.Count > 0);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00050EB8 File Offset: 0x0004F0B8
		private void method_2(Class91 act)
		{
			this.txtUsername.Text = act.Username;
			this.txtPassword.Text = act.Password;
			if (act.ToonTownAccountType == Enum101.const_1)
			{
				this.OpenServerRadioButton.Checked = true;
				return;
			}
			this.TestServerRadioButton.Checked = true;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00050F0C File Offset: 0x0004F10C
		private void ShowFavoritesButton_Click(object sender, EventArgs e)
		{
			Connect.Class226 @class = new Connect.Class226();
			@class.connect_0 = this;
			this.FavoriteAccountsMenu.Items.Clear();
			List<Class91> toonTownAccounts = this.class99_0.ToonTownAccounts;
			@class.class362_0 = new Class362[toonTownAccounts.Count];
			for (int i = 0; i < toonTownAccounts.Count; i++)
			{
				Class91 class2 = toonTownAccounts[i];
				Class362 class3 = @class.class362_0[i] = new Class362(class2);
				class3.Text = class2.ReferenceName;
			}
			this.FavoriteAccountsMenu.Items.AddRange(@class.class362_0);
			this.FavoriteAccountsMenu.ItemClicked += @class.method_0;
			this.FavoriteAccountsMenu.Closed += @class.method_1;
			this.FavoriteAccountsMenu.Show(this.ShowFavoritesButton, this.ShowFavoritesButton.PointToClient(Control.MousePosition));
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00009AA4 File Offset: 0x00007CA4
		private void DuckBlinker_Click(object sender, EventArgs e)
		{
			if (!this.class343_0.Enabled)
			{
				this.class343_0.Enabled = true;
			}
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00009ABF File Offset: 0x00007CBF
		private void Connect_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_25);
			e.Handled = true;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00050FF8 File Offset: 0x0004F1F8
		private void TheToonTownSpooferNewsBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			MethodInvoker methodInvoker = null;
			MethodInvoker methodInvoker2 = null;
			MethodInvoker methodInvoker3 = null;
			HtmlDocument document = this.TheToonTownSpooferNewsBrowser.Document;
			if (document != null)
			{
				HtmlElement elementById = document.GetElementById("nav_manager");
				if (elementById != null)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_3);
					}
					this.smethod_4(methodInvoker);
				}
				HtmlElement elementById2 = document.GetElementById("session_id");
				if (elementById2 != null)
				{
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(this.method_4);
					}
					this.smethod_4(methodInvoker2);
				}
				HtmlElement elementById3 = document.GetElementById("date_manager");
				if (elementById3 != null)
				{
					if (methodInvoker3 == null)
					{
						methodInvoker3 = new MethodInvoker(this.method_5);
					}
					this.smethod_4(methodInvoker3);
				}
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00009ACF File Offset: 0x00007CCF
		[CompilerGenerated]
		private void method_3()
		{
			if (this.NewsTabControl.SelectedTab != this.TTSNewsTab)
			{
				this.NewsTabControl.SelectTab(this.TTSNewsTab);
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00009AF5 File Offset: 0x00007CF5
		[CompilerGenerated]
		private void method_4()
		{
			this.bool_0 = true;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00009AFE File Offset: 0x00007CFE
		[CompilerGenerated]
		private void method_5()
		{
			this.ConnectButton.Enabled = false;
			this.ShowFavoritesButton.Enabled = false;
			this.FavoriteAccountsMenu.Close();
		}

		// Token: 0x0400084D RID: 2125
		private static readonly string string_0 = "Please enter your username and password.";

		// Token: 0x0400084E RID: 2126
		private static readonly string string_1 = "Missing Account Information";

		// Token: 0x0400084F RID: 2127
		private static readonly string string_2 = "You appear to already be logged into this account. If you log in to the same account multiple times, ToonTown will automatically disconnect you. Proceed?";

		// Token: 0x04000850 RID: 2128
		private static readonly string string_3 = "Duplicate Account Detected";

		// Token: 0x04000851 RID: 2129
		private static readonly string string_4 = "The ToonTown Spoofer has made several attempts but was unable to successfully connect to ToonTown to log in. There could be several reasons why the connection has failed. To attempt to locate the problem: try checking if you can browse the internet, temporarily disabling your firewall or checking your proxy settings.";

		// Token: 0x04000852 RID: 2130
		private static readonly string string_5 = "Please check your network settings.";

		// Token: 0x04000853 RID: 2131
		private static readonly string string_6 = "LOGIN_ACTION";

		// Token: 0x04000854 RID: 2132
		private static readonly string string_7 = "ToonTown has failed to install or update properly. Please try again or reinstall The ToonTown Spoofer.";

		// Token: 0x04000855 RID: 2133
		private static readonly string string_8 = "Internal Error";

		// Token: 0x04000856 RID: 2134
		private static readonly string string_9 = "Please close ToonTown and try again.";

		// Token: 0x04000857 RID: 2135
		private static readonly string string_10 = "Pending Updates Required";

		// Token: 0x04000858 RID: 2136
		private static readonly string string_11 = "ToonTown has terminated unexpectedly. This may indicate corrupted files or an internal error. Please try again or reinstall The ToonTown Spoofer.";

		// Token: 0x04000859 RID: 2137
		private static readonly string string_12 = "ToonTown Has Crashed";

		// Token: 0x0400085A RID: 2138
		private static readonly string string_13 = "ToonTown has failed to launch. This may indicate a failure to install ToonTown. Please try again or reinstall The ToonTown Spoofer.";

		// Token: 0x0400085B RID: 2139
		private static readonly string string_14 = "ToonTown Launch Failure";

		// Token: 0x0400085C RID: 2140
		private static readonly string string_15 = "PROMPT_URL";

		// Token: 0x0400085D RID: 2141
		private static readonly string string_16 = "Your web browser will now open to ToonTown.com where you will be prompted to log in and update your account.";

		// Token: 0x0400085E RID: 2142
		private static readonly string string_17 = "Account Migration";

		// Token: 0x0400085F RID: 2143
		private static readonly string string_18 = "Please visit ToonTown.com and log in, where you will be prompted to update your account.";

		// Token: 0x04000860 RID: 2144
		private static readonly string string_19 = "GLOBAL_DISPLAYTEXT";

		// Token: 0x04000861 RID: 2145
		private static readonly string string_20 = "Log In Failed";

		// Token: 0x04000862 RID: 2146
		private static readonly string string_21 = "There has been an unknown error while logging in.";

		// Token: 0x04000863 RID: 2147
		private static readonly string string_22 = "errorMsg";

		// Token: 0x04000864 RID: 2148
		private Class99 class99_0;

		// Token: 0x04000865 RID: 2149
		private bool bool_0;

		// Token: 0x02000281 RID: 641
		[CompilerGenerated]
		private sealed class Class220
		{
			// Token: 0x04000866 RID: 2150
			public string string_0;

			// Token: 0x04000867 RID: 2151
			public Enum101 enum101_0;

			// Token: 0x04000868 RID: 2152
			public Connect connect_0;
		}

		// Token: 0x02000282 RID: 642
		[CompilerGenerated]
		private sealed class Class221
		{
			// Token: 0x04000869 RID: 2153
			public Class147 class147_0;
		}

		// Token: 0x02000283 RID: 643
		[CompilerGenerated]
		private sealed class Class222
		{
			// Token: 0x06001AE4 RID: 6884 RVA: 0x000511A8 File Offset: 0x0004F3A8
			public void method_0(object sender, EventArgs e)
			{
				this.class221_0.class147_0.AuthenticationFailed += this.method_1;
				this.class221_0.class147_0.AuthenticationComplete += this.method_2;
				this.class221_0.class147_0.method_7();
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x00009B23 File Offset: 0x00007D23
			public void method_1(object sender, EventArgs8 e)
			{
				this.class220_0.connect_0.smethod_6(new MethodInvoker(this.method_3));
			}

			// Token: 0x06001AE6 RID: 6886 RVA: 0x00051200 File Offset: 0x0004F400
			public void method_2(object sender, EventArgs16 e)
			{
				Connect.Class222.Class223 @class = new Connect.Class222.Class223();
				@class.class222_0 = this;
				@class.class221_0 = this.class221_0;
				@class.class220_0 = this.class220_0;
				@class.eventArgs16_0 = e;
				this.class220_0.connect_0.smethod_6(new MethodInvoker(@class.method_0));
			}

			// Token: 0x06001AE7 RID: 6887 RVA: 0x00051258 File Offset: 0x0004F458
			public void method_3()
			{
				this.class221_0.class147_0.Dispose();
				this.loading_0.method_1();
				this.loading_0.Dispose();
				this.class220_0.connect_0.BringToFront();
				this.class220_0.connect_0.Activate();
				if (this.class220_0.connect_0.bool_0)
				{
					Class509.InstallingOrLoggingIn = false;
					return;
				}
				DialogBox.smethod_2(Connect.string_4, Connect.string_5, Enum121.const_2);
				Class509.InstallingOrLoggingIn = false;
			}

			// Token: 0x0400086A RID: 2154
			public Connect.Class221 class221_0;

			// Token: 0x0400086B RID: 2155
			public Connect.Class220 class220_0;

			// Token: 0x0400086C RID: 2156
			public Loading loading_0;

			// Token: 0x02000284 RID: 644
			private sealed class Class223
			{
				// Token: 0x06001AE9 RID: 6889 RVA: 0x000512DC File Offset: 0x0004F4DC
				public void method_0()
				{
					Action<KeyValuePair<string, string>> action = null;
					Connect.Class222.Class223.Class224 @class = new Connect.Class222.Class223.Class224();
					@class.class223_0 = this;
					@class.class222_0 = this.class222_0;
					@class.class221_0 = this.class221_0;
					@class.class220_0 = this.class220_0;
					@class.class96_0 = this.class221_0.class147_0.PatchData;
					this.class221_0.class147_0.Dispose();
					this.class222_0.loading_0.method_1();
					this.class222_0.loading_0.Dispose();
					if (this.class220_0.connect_0.bool_0)
					{
						this.class220_0.connect_0.BringToFront();
						this.class220_0.connect_0.Activate();
						Class509.InstallingOrLoggingIn = false;
						return;
					}
					if (this.eventArgs16_0.NewFormat)
					{
						Dictionary<string, string> result = this.eventArgs16_0.Result;
						string string_ = Connect.string_6;
						if (action == null)
						{
							action = new Action<KeyValuePair<string, string>>(@class.method_0);
						}
						result.smethod_5(string_, action);
						return;
					}
					Dictionary<string, string> result2 = this.eventArgs16_0.Result;
					string string_2 = Connect.string_22;
					if (Connect.Class222.Class223.action_0 == null)
					{
						Connect.Class222.Class223.action_0 = new Action<KeyValuePair<string, string>>(Connect.Class222.Class223.smethod_0);
					}
					if (!result2.smethod_5(string_2, Connect.Class222.Class223.action_0))
					{
						this.class220_0.connect_0.BringToFront();
						this.class220_0.connect_0.Activate();
						DialogBox.smethod_2(Connect.string_21, Connect.string_20, Enum121.const_2);
					}
					Class509.InstallingOrLoggingIn = false;
				}

				// Token: 0x06001AEA RID: 6890 RVA: 0x00009B41 File Offset: 0x00007D41
				private static void smethod_0(KeyValuePair<string, string> errorMessage)
				{
					DialogBox.smethod_3(errorMessage.Value, Connect.string_20);
				}

				// Token: 0x0400086D RID: 2157
				public Connect.Class222 class222_0;

				// Token: 0x0400086E RID: 2158
				public Connect.Class221 class221_0;

				// Token: 0x0400086F RID: 2159
				public Connect.Class220 class220_0;

				// Token: 0x04000870 RID: 2160
				public EventArgs16 eventArgs16_0;

				// Token: 0x04000871 RID: 2161
				private static Action<KeyValuePair<string, string>> action_0;

				// Token: 0x02000285 RID: 645
				private sealed class Class224
				{
					// Token: 0x06001AEC RID: 6892 RVA: 0x0005143C File Offset: 0x0004F63C
					public void method_0(KeyValuePair<string, string> LOGIN_ACTION)
					{
						Action<KeyValuePair<string, string>> action = null;
						Action<KeyValuePair<string, string>> action2 = null;
						string value;
						if ((value = LOGIN_ACTION.Value) != null)
						{
							if (value == "PLAY")
							{
								Connect.Class222.Class223.Class224.Class225 @class = new Connect.Class222.Class223.Class224.Class225();
								@class.class224_0 = this;
								@class.class223_0 = this.class223_0;
								@class.class222_0 = this.class222_0;
								@class.class221_0 = this.class221_0;
								@class.class220_0 = this.class220_0;
								this.class220_0.connect_0.Hide();
								@class.installing_0 = new Installing(this.class96_0, this.class220_0.enum101_0, this.class220_0.string_0, this.class223_0.eventArgs16_0.Result);
								@class.installing_0.FormClosed += @class.method_0;
								@class.installing_0.Show();
								return;
							}
							if (value == "TT_DFAM_PROMPT")
							{
								Dictionary<string, string> result = this.class223_0.eventArgs16_0.Result;
								string string_ = Connect.string_15;
								if (action == null)
								{
									action = new Action<KeyValuePair<string, string>>(this.method_1);
								}
								if (!result.smethod_5(string_, action))
								{
									this.class220_0.connect_0.BringToFront();
									this.class220_0.connect_0.Activate();
									DialogBox.smethod_2(Connect.string_18, Connect.string_17, Enum121.const_2);
								}
								Class509.InstallingOrLoggingIn = false;
								return;
							}
							if (!(value == "LOGIN"))
							{
								return;
							}
							Dictionary<string, string> result2 = this.class223_0.eventArgs16_0.Result;
							string string_2 = Connect.string_19;
							if (action2 == null)
							{
								action2 = new Action<KeyValuePair<string, string>>(this.method_2);
							}
							if (!result2.smethod_5(string_2, action2))
							{
								this.class220_0.connect_0.BringToFront();
								this.class220_0.connect_0.Activate();
								DialogBox.smethod_2(Connect.string_21, Connect.string_20, Enum121.const_2);
							}
							Class509.InstallingOrLoggingIn = false;
						}
					}

					// Token: 0x06001AED RID: 6893 RVA: 0x00009B54 File Offset: 0x00007D54
					private void method_1(KeyValuePair<string, string> arg)
					{
						this.class220_0.connect_0.BringToFront();
						this.class220_0.connect_0.Activate();
						DialogBox.smethod_2(Connect.string_16, Connect.string_17, Enum121.const_2);
						Class512.smethod_2(arg.Value);
					}

					// Token: 0x06001AEE RID: 6894 RVA: 0x00009B92 File Offset: 0x00007D92
					private void method_2(KeyValuePair<string, string> arg)
					{
						this.class220_0.connect_0.BringToFront();
						this.class220_0.connect_0.Activate();
						DialogBox.smethod_2(arg.Value, Connect.string_20, Enum121.const_2);
					}

					// Token: 0x04000872 RID: 2162
					public Connect.Class222.Class223 class223_0;

					// Token: 0x04000873 RID: 2163
					public Connect.Class222 class222_0;

					// Token: 0x04000874 RID: 2164
					public Connect.Class221 class221_0;

					// Token: 0x04000875 RID: 2165
					public Connect.Class220 class220_0;

					// Token: 0x04000876 RID: 2166
					public Class96 class96_0;

					// Token: 0x02000286 RID: 646
					private sealed class Class225
					{
						// Token: 0x06001AF0 RID: 6896 RVA: 0x000515FC File Offset: 0x0004F7FC
						public void method_0(object sender, FormClosedEventArgs e)
						{
							this.class220_0.connect_0.Show();
							this.installing_0.Dispose();
							switch (this.installing_0.InstallerResult)
							{
							case Enum42.const_1:
								this.class220_0.connect_0.BringToFront();
								this.class220_0.connect_0.Activate();
								DialogBox.smethod_4(Connect.string_7, Connect.string_8);
								break;
							case Enum42.const_2:
								this.class220_0.connect_0.txtUsername.Text = string.Empty;
								this.class220_0.connect_0.txtPassword.Text = string.Empty;
								this.class220_0.connect_0.WindowState = FormWindowState.Minimized;
								break;
							case Enum42.const_4:
								this.class220_0.connect_0.BringToFront();
								this.class220_0.connect_0.Activate();
								DialogBox.smethod_4(Connect.string_13, Connect.string_14);
								break;
							case Enum42.const_5:
								this.class220_0.connect_0.BringToFront();
								this.class220_0.connect_0.Activate();
								DialogBox.smethod_4(Connect.string_11, Connect.string_12);
								break;
							case Enum42.const_6:
								this.class220_0.connect_0.BringToFront();
								this.class220_0.connect_0.Activate();
								DialogBox.smethod_3(Connect.string_9, Connect.string_10);
								break;
							}
							Class509.InstallingOrLoggingIn = false;
						}

						// Token: 0x04000877 RID: 2167
						public Connect.Class222.Class223.Class224 class224_0;

						// Token: 0x04000878 RID: 2168
						public Connect.Class222.Class223 class223_0;

						// Token: 0x04000879 RID: 2169
						public Connect.Class222 class222_0;

						// Token: 0x0400087A RID: 2170
						public Connect.Class221 class221_0;

						// Token: 0x0400087B RID: 2171
						public Connect.Class220 class220_0;

						// Token: 0x0400087C RID: 2172
						public Installing installing_0;
					}
				}
			}
		}

		// Token: 0x02000287 RID: 647
		[CompilerGenerated]
		private sealed class Class226
		{
			// Token: 0x06001AF2 RID: 6898 RVA: 0x0005176C File Offset: 0x0004F96C
			public void method_0(object sender, ToolStripItemClickedEventArgs e)
			{
				if (this.class362_0 != null)
				{
					Class362 @class = e.ClickedItem as Class362;
					this.connect_0.method_2(@class.class91_0);
					this.connect_0.FavoriteAccountsMenu.Close();
					this.connect_0.method_1();
				}
			}

			// Token: 0x06001AF3 RID: 6899 RVA: 0x00009BC6 File Offset: 0x00007DC6
			public void method_1(object sender, ToolStripDropDownClosedEventArgs e)
			{
				if (this.class362_0 != null)
				{
					this.class362_0.smethod_1<Class362>();
					this.class362_0 = null;
				}
			}

			// Token: 0x0400087D RID: 2173
			public Class362[] class362_0;

			// Token: 0x0400087E RID: 2174
			public Connect connect_0;
		}
	}
}
