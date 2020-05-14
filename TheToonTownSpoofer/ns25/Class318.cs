using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns17;
using ns21;
using ns23;
using ns24;
using ns26;
using ns29;

namespace ns25
{
	// Token: 0x0200033E RID: 830
	internal sealed class Class318 : Component
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x0000CFB3 File Offset: 0x0000B1B3
		private void method_0()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x14000198 RID: 408
		// (add) Token: 0x06002018 RID: 8216 RVA: 0x0006A9B8 File Offset: 0x00068BB8
		// (remove) Token: 0x06002019 RID: 8217 RVA: 0x0006A9F0 File Offset: 0x00068BF0
		public event EventHandler<EventArgs18> HotkeyActivated
		{
			add
			{
				EventHandler<EventArgs18> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs18> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs18> value2 = (EventHandler<EventArgs18>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs18>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs18> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs18> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs18> value2 = (EventHandler<EventArgs18>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs18>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		static Class318()
		{
			Class318.object_0 = new object();
			Class318.dictionary_1 = new Dictionary<int, Class318.Class184>();
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x0006AA28 File Offset: 0x00068C28
		public static ReadOnlyCollection<Class183> AllHotkeys
		{
			get
			{
				ReadOnlyCollection<Class183> result;
				lock (Class318.object_0)
				{
					result = Class318.dictionary_1.Values.Cast<Class183>().ToList<Class183>().AsReadOnly();
				}
				return result;
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0006AA7C File Offset: 0x00068C7C
		public static bool smethod_0(Struct21 hotkey)
		{
			lock (Class318.object_0)
			{
				foreach (Class318.Class184 @class in Class318.dictionary_1.Values)
				{
					if (Struct21.smethod_0(@class.Hotkey, hotkey))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public static bool smethod_1(Keys key, Keys modifier)
		{
			return Class318.smethod_0(new Struct21(key, modifier));
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0000CFEA File Offset: 0x0000B1EA
		public Class318()
		{
			this.method_0();
			this.method_1();
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0000D009 File Offset: 0x0000B209
		public Class318(IContainer container)
		{
			container.Add(this);
			this.method_0();
			this.method_1();
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0000D02F File Offset: 0x0000B22F
		private void method_1()
		{
			this.class523_0 = new Class523();
			this.class523_0.HotkeyPressed += this.method_2;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0006AB0C File Offset: 0x00068D0C
		private void method_2(object sender, EventArgs41 e)
		{
			Class318.Class184 @class = null;
			lock (Class318.object_0)
			{
				@class = this.dictionary_0[e.HotkeyID];
			}
			bool flag2 = @class.AllowRepeat || DateTime.Now.Subtract(@class.LastTime).TotalMilliseconds > 1000.0;
			@class.LastTime = DateTime.Now;
			if (flag2)
			{
				EventArgs18 e2 = new EventArgs18(@class);
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, e2);
				}
				if (@class.Callback != null)
				{
					@class.Callback(this, e2);
				}
			}
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0006ABD0 File Offset: 0x00068DD0
		private bool method_3(int id)
		{
			bool result;
			lock (Class318.object_0)
			{
				result = this.dictionary_0.ContainsKey(id);
			}
			return result;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0006AC18 File Offset: 0x00068E18
		public bool method_4(Struct21 hotkey, out Class183 state)
		{
			lock (Class318.object_0)
			{
				foreach (Class318.Class184 @class in this.dictionary_0.Values)
				{
					if (Struct21.smethod_0(@class.Hotkey, hotkey))
					{
						state = @class;
						return true;
					}
				}
			}
			state = null;
			return false;
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0000D053 File Offset: 0x0000B253
		public Class183 method_5(Keys key, Keys modifier, bool allow_repeat)
		{
			return this.method_6(key, modifier, allow_repeat, null);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0000D05F File Offset: 0x0000B25F
		public Class183 method_6(Keys key, Keys modifier, bool allow_repeat, object state)
		{
			return this.method_8(key, modifier, allow_repeat, state, null);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0000D06D File Offset: 0x0000B26D
		public Class183 method_7(Keys key, Keys modifier, bool allow_repeat, EventHandler<EventArgs18> callback)
		{
			return this.method_8(key, modifier, allow_repeat, null, callback);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0000D07B File Offset: 0x0000B27B
		public Class183 method_8(Keys key, Keys modifier, bool allow_repeat, object state, EventHandler<EventArgs18> callback)
		{
			return this.method_9(new Struct21(key, modifier), allow_repeat, state, callback);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		public Class183 method_9(Struct21 hotkey, bool allow_repeat, object state, EventHandler<EventArgs18> callback)
		{
			lock (Class318.object_0)
			{
				int num = Class318.int_0++;
				if (Class318.int_0 > 49151)
				{
					Class318.int_0 = 0;
				}
				Class318.Class184 @class = new Class318.Class184(this, num, hotkey, allow_repeat, state, callback);
				if (this.method_13(@class))
				{
					this.dictionary_0.Add(num, @class);
					Class318.dictionary_1.Add(num, @class);
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0006AD44 File Offset: 0x00068F44
		public bool method_10(Class183 state)
		{
			bool result;
			lock (Class318.object_0)
			{
				Class318.Class184 @class = state as Class318.Class184;
				if (!this.dictionary_0.ContainsKey(@class.ID))
				{
					throw new ArgumentException("The specified hotkey does not exist in this component.");
				}
				this.dictionary_0.Remove(@class.ID);
				Class318.dictionary_1.Remove(@class.ID);
				result = this.method_14(@class);
			}
			return result;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0006ADD0 File Offset: 0x00068FD0
		public bool method_11(Keys key, Keys modifier)
		{
			Class183 state;
			return this.method_4(new Struct21(key, modifier), out state) && this.method_10(state);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0000D08F File Offset: 0x0000B28F
		public bool method_12(Struct21 hotkey)
		{
			return this.method_11(hotkey.Key, hotkey.Modifier);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private bool method_13(Class318.Class184 hotkey)
		{
			bool result;
			lock (Class318.object_0)
			{
				try
				{
					Class302.smethod_0(this.class523_0.Handle, hotkey.ID, hotkey.Hotkey.NativeModifier, hotkey.Hotkey.Key);
					result = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						"Failure to register hotkey: " + hotkey.ToString()
					});
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0006AEA0 File Offset: 0x000690A0
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private bool method_14(Class318.Class184 hotkey)
		{
			bool result;
			lock (Class318.object_0)
			{
				try
				{
					Class302.smethod_1(this.class523_0.Handle, hotkey.ID);
					result = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						"Failure to unregister hotkey: " + hotkey.ToString()
					});
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0006AF28 File Offset: 0x00069128
		protected override void Dispose(bool disposing)
		{
			lock (Class318.object_0)
			{
				foreach (Class318.Class184 hotkey in this.dictionary_0.Values)
				{
					this.method_14(hotkey);
				}
				Class318.dictionary_1.smethod_8(this.dictionary_0.Keys);
				this.dictionary_0.Clear();
			}
			if (disposing)
			{
				this.class523_0.Dispose();
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000CF7 RID: 3319
		private IContainer icontainer_0;

		// Token: 0x04000CF8 RID: 3320
		private Class523 class523_0;

		// Token: 0x04000CF9 RID: 3321
		private EventHandler<EventArgs18> eventHandler_0;

		// Token: 0x04000CFA RID: 3322
		private readonly Dictionary<int, Class318.Class184> dictionary_0 = new Dictionary<int, Class318.Class184>();

		// Token: 0x04000CFB RID: 3323
		private static readonly Dictionary<int, Class318.Class184> dictionary_1;

		// Token: 0x04000CFC RID: 3324
		private static readonly object object_0;

		// Token: 0x04000CFD RID: 3325
		private static int int_0 = 0;

		// Token: 0x0200033F RID: 831
		private sealed class Class184 : Class183
		{
			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x0600202F RID: 8239 RVA: 0x0000D0A5 File Offset: 0x0000B2A5
			// (set) Token: 0x06002030 RID: 8240 RVA: 0x0000D0AD File Offset: 0x0000B2AD
			public EventHandler<EventArgs18> Callback { get; private set; }

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06002031 RID: 8241 RVA: 0x0000D0B6 File Offset: 0x0000B2B6
			// (set) Token: 0x06002032 RID: 8242 RVA: 0x0000D0BE File Offset: 0x0000B2BE
			public int ID { get; private set; }

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06002033 RID: 8243 RVA: 0x0000D0C7 File Offset: 0x0000B2C7
			// (set) Token: 0x06002034 RID: 8244 RVA: 0x0000D0CF File Offset: 0x0000B2CF
			public DateTime LastTime { get; set; }

			// Token: 0x06002035 RID: 8245 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
			public Class184(Class318 owner, int id, Struct21 hotkey, bool allow_repeat, object state, EventHandler<EventArgs18> callback) : base(owner, hotkey, allow_repeat, state)
			{
				this.ID = id;
				this.Callback = callback;
				this.LastTime = DateTime.MinValue;
			}

			// Token: 0x06002036 RID: 8246 RVA: 0x0000D100 File Offset: 0x0000B300
			public Class184(Class318 owner, int id, Keys key, Keys modifier, bool allow_repeat, object state, EventHandler<EventArgs18> callback) : this(owner, id, new Struct21(key, modifier), allow_repeat, state, callback)
			{
			}

			// Token: 0x04000CFE RID: 3326
			[CompilerGenerated]
			private EventHandler<EventArgs18> eventHandler_0;

			// Token: 0x04000CFF RID: 3327
			[CompilerGenerated]
			private int int_0;

			// Token: 0x04000D00 RID: 3328
			[CompilerGenerated]
			private DateTime dateTime_0;
		}
	}
}
