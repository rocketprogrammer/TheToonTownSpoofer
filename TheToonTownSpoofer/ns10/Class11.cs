using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using ns7;

namespace ns10
{
	// Token: 0x0200014B RID: 331
	internal sealed class Class11 : IDisposable, Interface9
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00017884 File Offset: 0x00015A84
		private void method_0()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				49,
				141,
				252,
				80,
				172,
				103,
				211,
				17,
				189,
				76,
				0,
				192,
				79,
				110,
				165,
				174
			});
			this.iconnectionPointContainer_0.FindConnectionPoint(ref guid, out connectionPoint);
			this.iconnectionPoint_0 = (IConnectionPoint)connectionPoint;
			this.arrayList_0 = new ArrayList();
		}

		// Token: 0x140000F1 RID: 241
		// (add) Token: 0x06001168 RID: 4456 RVA: 0x00017998 File Offset: 0x00015B98
		// (remove) Token: 0x06001169 RID: 4457 RVA: 0x00017A28 File Offset: 0x00015C28
		public event Delegate69 onblur
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate69_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate69_0 != null && ((@class.delegate69_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F2 RID: 242
		// (add) Token: 0x0600116A RID: 4458 RVA: 0x00017B34 File Offset: 0x00015D34
		// (remove) Token: 0x0600116B RID: 4459 RVA: 0x00017BC4 File Offset: 0x00015DC4
		public event Delegate70 onfocus
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate70_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate70_0 != null && ((@class.delegate70_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F3 RID: 243
		// (add) Token: 0x0600116C RID: 4460 RVA: 0x00017CD0 File Offset: 0x00015ED0
		// (remove) Token: 0x0600116D RID: 4461 RVA: 0x00017D60 File Offset: 0x00015F60
		public event Delegate71 onclick
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate71_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate71_0 != null && ((@class.delegate71_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F4 RID: 244
		// (add) Token: 0x0600116E RID: 4462 RVA: 0x00017E6C File Offset: 0x0001606C
		// (remove) Token: 0x0600116F RID: 4463 RVA: 0x00017EFC File Offset: 0x000160FC
		public event Delegate72 ondblclick
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate72_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate72_0 != null && ((@class.delegate72_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x06001170 RID: 4464 RVA: 0x00018008 File Offset: 0x00016208
		// (remove) Token: 0x06001171 RID: 4465 RVA: 0x00018098 File Offset: 0x00016298
		public event Delegate73 onmousedown
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate73_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate73_0 != null && ((@class.delegate73_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F6 RID: 246
		// (add) Token: 0x06001172 RID: 4466 RVA: 0x000181A4 File Offset: 0x000163A4
		// (remove) Token: 0x06001173 RID: 4467 RVA: 0x00018234 File Offset: 0x00016434
		public event Delegate74 onmouseup
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate74_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate74_0 != null && ((@class.delegate74_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F7 RID: 247
		// (add) Token: 0x06001174 RID: 4468 RVA: 0x00018340 File Offset: 0x00016540
		// (remove) Token: 0x06001175 RID: 4469 RVA: 0x000183D0 File Offset: 0x000165D0
		public event Delegate75 onmousemove
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate75_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate75_0 != null && ((@class.delegate75_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F8 RID: 248
		// (add) Token: 0x06001176 RID: 4470 RVA: 0x000184DC File Offset: 0x000166DC
		// (remove) Token: 0x06001177 RID: 4471 RVA: 0x0001856C File Offset: 0x0001676C
		public event Delegate76 onmouseover
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate76_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate76_0 != null && ((@class.delegate76_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000F9 RID: 249
		// (add) Token: 0x06001178 RID: 4472 RVA: 0x00018678 File Offset: 0x00016878
		// (remove) Token: 0x06001179 RID: 4473 RVA: 0x00018708 File Offset: 0x00016908
		public event Delegate77 onmouseout
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate77_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate77_0 != null && ((@class.delegate77_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000FA RID: 250
		// (add) Token: 0x0600117A RID: 4474 RVA: 0x00018814 File Offset: 0x00016A14
		// (remove) Token: 0x0600117B RID: 4475 RVA: 0x000188A4 File Offset: 0x00016AA4
		public event Delegate78 onkeypress
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate78_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate78_0 != null && ((@class.delegate78_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000FB RID: 251
		// (add) Token: 0x0600117C RID: 4476 RVA: 0x000189B0 File Offset: 0x00016BB0
		// (remove) Token: 0x0600117D RID: 4477 RVA: 0x00018A40 File Offset: 0x00016C40
		public event Delegate79 onkeydown
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate79_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate79_0 != null && ((@class.delegate79_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x140000FC RID: 252
		// (add) Token: 0x0600117E RID: 4478 RVA: 0x00018B4C File Offset: 0x00016D4C
		// (remove) Token: 0x0600117F RID: 4479 RVA: 0x00018BDC File Offset: 0x00016DDC
		public event Delegate80 onkeyup
		{
			add
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.iconnectionPoint_0 == null)
					{
						this.method_0();
					}
					Class10 @class = new Class10();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate80_0 = value;
					this.arrayList_0.Add((object)@class);
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
			remove
			{
				try
				{
					bool flag;
					Monitor.Enter(this, ref flag);
					if (this.arrayList_0 != null)
					{
						int count = this.arrayList_0.Count;
						int num = 0;
						if (0 < count)
						{
							Class10 @class;
							do
							{
								@class = (Class10)this.arrayList_0[num];
								if (@class.delegate80_0 != null && ((@class.delegate80_0.Equals((object)value) ? 1 : 0) & 255) != 0)
								{
									goto Block_5;
								}
								num++;
							}
							while (num < count);
							goto IL_DD;
							Block_5:
							this.arrayList_0.RemoveAt(num);
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							if (count <= 1)
							{
								Marshal.ReleaseComObject(this.iconnectionPoint_0);
								this.iconnectionPoint_0 = null;
								this.arrayList_0 = null;
							}
						}
					}
					IL_DD:;
				}
				finally
				{
					bool flag;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00018CE8 File Offset: 0x00016EE8
		public override void Finalize()
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.iconnectionPoint_0 != null)
				{
					int count = this.arrayList_0.Count;
					int num = 0;
					if (0 < count)
					{
						do
						{
							Class10 @class = (Class10)this.arrayList_0[num];
							this.iconnectionPoint_0.Unadvise(@class.int_0);
							num++;
						}
						while (num < count);
					}
					Marshal.ReleaseComObject(this.iconnectionPoint_0);
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000035A9 File Offset: 0x000017A9
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x040000D2 RID: 210
		private IConnectionPointContainer iconnectionPointContainer_0;

		// Token: 0x040000D3 RID: 211
		private ArrayList arrayList_0;

		// Token: 0x040000D4 RID: 212
		private IConnectionPoint iconnectionPoint_0;
	}
}
