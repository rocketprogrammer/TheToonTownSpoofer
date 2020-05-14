using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns16;
using ns17;
using ns18;
using ns20;
using ns21;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using TheToonTownSpoofer.Design;

namespace ns28
{
	// Token: 0x020004A7 RID: 1191
	internal sealed class Class504
	{
		// Token: 0x140001DE RID: 478
		// (add) Token: 0x06002C4A RID: 11338 RVA: 0x000AB928 File Offset: 0x000A9B28
		// (remove) Token: 0x06002C4B RID: 11339 RVA: 0x000AB960 File Offset: 0x000A9B60
		internal event EventHandler<EventArgs32> ModifiedStateChanged
		{
			add
			{
				EventHandler<EventArgs32> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs32> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs32> value2 = (EventHandler<EventArgs32>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs32>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs32> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs32> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs32> value2 = (EventHandler<EventArgs32>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs32>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00014CC5 File Offset: 0x00012EC5
		public Class504(Class132 cp)
		{
			if (cp == null)
			{
				throw new ArgumentNullException("cp");
			}
			this.class132_0 = cp;
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00014CE9 File Offset: 0x00012EE9
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00014CF1 File Offset: 0x00012EF1
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal bool Modified
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				if (this.bool_1 == value)
				{
					return;
				}
				this.bool_1 = value;
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, new EventArgs32(this.bool_1));
				}
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00014D23 File Offset: 0x00012F23
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x000AB998 File Offset: 0x000A9B98
		[Description("Defines the URL to check for updates and download paths.")]
		[DisplayName("Update URL")]
		public Uri UpdateUri
		{
			get
			{
				return this.class132_0.UpdateUri;
			}
			set
			{
				if (!(this.class132_0.UpdateUri != value))
				{
					return;
				}
				if (string.IsNullOrEmpty(value.OriginalString))
				{
					this.Modified = true;
					this.class132_0.UpdateUri = value;
					return;
				}
				if (value.smethod_0())
				{
					this.Modified = true;
					this.class132_0.UpdateUri = value;
					return;
				}
				throw new PropertyException("Invalid URL, please enter a valid URL to check for updates or leave this field blank. Example: http://www.yoursite.com/version.txt");
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x00014D30 File Offset: 0x00012F30
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00014D3D File Offset: 0x00012F3D
		[DisplayName("Name")]
		[Category("Content Pack Properties")]
		[DefaultValue("")]
		[Description("The name of your Content Pack which will be displayed on the Content Pack window.")]
		public string Name
		{
			get
			{
				return this.class132_0.Name;
			}
			set
			{
				if (this.class132_0.Name != value)
				{
					if (value.Length > 32)
					{
						throw new PropertyException("Please limit your Content Pack name to 32 characters or less.");
					}
					this.Modified = true;
					this.class132_0.Name = value;
				}
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00014D7A File Offset: 0x00012F7A
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x00014D87 File Offset: 0x00012F87
		[DefaultValue("")]
		[Description("The author is you!")]
		[Category("Content Pack Properties")]
		[DisplayName("Author")]
		public string Author
		{
			get
			{
				return this.class132_0.Author;
			}
			set
			{
				if (this.class132_0.Author != value)
				{
					if (value.Length > 32)
					{
						throw new PropertyException("Please limit your name to 32 characters or less.");
					}
					this.Modified = true;
					this.class132_0.Author = value;
				}
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00014DC4 File Offset: 0x00012FC4
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x00014DD1 File Offset: 0x00012FD1
		[TypeConverter(typeof(Class312))]
		[Description("The description is displayed on the Content Pack window in Rich Text Format.")]
		[Category("Content Pack Properties")]
		[Editor(typeof(Class517), typeof(UITypeEditor))]
		[DefaultValue("")]
		[DisplayName("Description")]
		public string Description
		{
			get
			{
				return this.class132_0.Description;
			}
			set
			{
				if (this.class132_0.Description != value)
				{
					this.Modified = true;
					this.class132_0.Description = value;
				}
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00014DF9 File Offset: 0x00012FF9
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x00014E06 File Offset: 0x00013006
		[Category("Content Pack Properties")]
		[TypeConverter(typeof(Class518))]
		[Description("The version of the Content Pack. This does not have any relevance on checking for updates and is only used for yours and others reference.")]
		[DisplayName("Version")]
		public Version Version
		{
			get
			{
				return this.class132_0.Version;
			}
			set
			{
				if (this.class132_0.Version != value)
				{
					this.Modified = true;
					this.class132_0.Version = value;
				}
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x00014E2E File Offset: 0x0001302E
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x000ABA00 File Offset: 0x000A9C00
		[Category("Content Pack Properties")]
		[DisplayName("Loader Pack")]
		[Description("Determines if the Content Pack will contain no data and instead is simply used to download another Content Pack. We distribute NightLife using this method, users receive a small Content Pack which downloads the full package if users opt-in.")]
		[DefaultValue(false)]
		public bool LoaderPack
		{
			get
			{
				return this.class132_0.LoaderPack;
			}
			set
			{
				if (this.class132_0.LoaderPack != value)
				{
					if (this.bool_0 && value && DialogBox.smethod_6("Loader Content Packs are saved without any data and used to simply download the full package. Are you sure you want to enable this feature?", "Enable Loader Pack", new Enum39[]
					{
						Enum39.const_5,
						Enum39.const_6
					}) != DialogResult.Yes)
					{
						this.bool_0 = false;
						return;
					}
					this.bool_0 = false;
					this.Modified = true;
					this.class132_0.LoaderPack = value;
				}
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00014E3B File Offset: 0x0001303B
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x000ABA6C File Offset: 0x000A9C6C
		[Category("Content Pack Properties")]
		[DisplayName("Icon")]
		[DefaultValue(typeof(Bitmap), null)]
		[Description("An image that will be displayed on the Content Pack window.")]
		[TypeConverter(typeof(Class312))]
		public Bitmap Icon
		{
			get
			{
				return this.class132_0.Icon;
			}
			set
			{
				if (this.class132_0.Icon != value)
				{
					if (value == null)
					{
						this.class132_0.method_5(null);
					}
					else
					{
						try
						{
							using (MemoryStream memoryStream = new MemoryStream())
							{
								Class157.smethod_11(value, memoryStream, Color.Black, 100);
								if (memoryStream.Length > 5242880L && DialogBox.smethod_6("This screenshot file size is very large, include anyways?", "Large Screenshot File Size", new Enum39[]
								{
									Enum39.const_5,
									Enum39.const_6
								}) == DialogResult.No)
								{
									return;
								}
								memoryStream.Position = 0L;
								this.class132_0.method_5(memoryStream);
							}
						}
						catch (Exception ex)
						{
							ex.smethod_0();
							DialogBox.smethod_4("Error converting this image.", "GDI Error");
						}
						value.Dispose();
					}
					this.Modified = true;
				}
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00014E48 File Offset: 0x00013048
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x000ABB54 File Offset: 0x000A9D54
		[Category("Content Pack Properties")]
		[Description("The minimum version of The ToonTown Spoofer this Content Pack supports.")]
		[DisplayName("Minimum Version")]
		[TypeConverter(typeof(Class518))]
		public Version MinimumVersion
		{
			get
			{
				return this.class132_0.MinimumVersion;
			}
			set
			{
				if (this.class132_0.MinimumVersion != value)
				{
					if (value < new Version(6, 0))
					{
						DialogBox.smethod_3("You cannot set the minimum version required to less then 6. Previous versions of The ToonTown Spoofer cannot load the new content pack format.", "Invalid Minimum Version Specified");
						return;
					}
					this.Modified = true;
					this.class132_0.MinimumVersion = value;
				}
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x00014E55 File Offset: 0x00013055
		[ReadOnly(true)]
		[Description("The ID is a unique, random Guid.")]
		[DisplayName("ID")]
		[Category("Content Pack Properties")]
		public Guid ID
		{
			get
			{
				return this.class132_0.ID;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00014E62 File Offset: 0x00013062
		[Category("Content Pack Properties")]
		[DisplayName("Data Hash")]
		[Description("The data hash is an Md5 hash code of the public data structure and is used internally to handle updates.")]
		[ReadOnly(true)]
		[TypeConverter(typeof(Class195))]
		public Struct43 DataHash
		{
			get
			{
				return this.class132_0.DataHash;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00014E6F File Offset: 0x0001306F
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x000ABBA8 File Offset: 0x000A9DA8
		[Description("The password does not guarantee no one can access your Content Pack, it is a simple level of protection to prevent average users from opening your Content Pack and making changes.")]
		[Category("Content Pack Properties")]
		[DisplayName("Password")]
		[PasswordPropertyText(true)]
		public string Password
		{
			get
			{
				return this.class132_0.Password;
			}
			set
			{
				EventHandler<EventArgs43<string>> eventHandler = null;
				Class504.Class505 @class = new Class504.Class505();
				@class.string_0 = value;
				if (this.class132_0.Password != @class.string_0)
				{
					if (string.IsNullOrEmpty(@class.string_0))
					{
						this.Modified = true;
						this.class132_0.Password = @class.string_0;
						return;
					}
					using (StringInputForm stringInputForm = new StringInputForm())
					{
						stringInputForm.Text = "Confirm Password";
						stringInputForm.LabelMessage = "Please confirm your password:";
						stringInputForm.PasswordTextBox = true;
						StringInputFormBase stringInputFormBase = stringInputForm;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler<EventArgs43<string>>(@class.method_0);
						}
						stringInputFormBase.InputValidating += eventHandler;
						if (stringInputForm.ShowDialog() == DialogResult.OK)
						{
							this.Modified = true;
							this.class132_0.Password = @class.string_0;
							if (string.IsNullOrEmpty(@class.string_0))
							{
								this.class132_0.PasswordHash = Struct43.struct43_0;
							}
							else
							{
								this.class132_0.PasswordHash = Encoding.Unicode.GetBytes(@class.string_0).smethod_0();
							}
						}
					}
				}
			}
		}

		// Token: 0x0400174C RID: 5964
		private bool bool_0 = true;

		// Token: 0x0400174D RID: 5965
		private Class132 class132_0;

		// Token: 0x0400174E RID: 5966
		private EventHandler<EventArgs32> eventHandler_0;

		// Token: 0x0400174F RID: 5967
		private bool bool_1;

		// Token: 0x020004A8 RID: 1192
		[CompilerGenerated]
		private sealed class Class505
		{
			// Token: 0x06002C64 RID: 11364 RVA: 0x00014E7C File Offset: 0x0001307C
			public void method_0(object sender, EventArgs43<string> e)
			{
				e.IsValid = (e.gparam_0 == this.string_0);
				if (!e.IsValid)
				{
					DialogBox.smethod_3("Your passwords do not match.", "Invalid Password");
				}
			}

			// Token: 0x04001750 RID: 5968
			public string string_0;
		}
	}
}
