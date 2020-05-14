using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using ns7;

namespace ns10
{
	// Token: 0x02000155 RID: 341
	internal sealed class Class21 : IDisposable, Interface10
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x00020664 File Offset: 0x0001E864
		private void method_0()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				164,
				90,
				244,
				149,
				10,
				237,
				210,
				17,
				186,
				103,
				0,
				0,
				248,
				8,
				85,
				230
			});
			this.iconnectionPointContainer_0.FindConnectionPoint(ref guid, out connectionPoint);
			this.iconnectionPoint_0 = (IConnectionPoint)connectionPoint;
			this.arrayList_0 = new ArrayList();
		}

		// Token: 0x14000142 RID: 322
		// (add) Token: 0x06001266 RID: 4710 RVA: 0x00020778 File Offset: 0x0001E978
		// (remove) Token: 0x06001267 RID: 4711 RVA: 0x00020808 File Offset: 0x0001EA08
		public event Delegate81 ondragbegin
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
					Class20 @class = new Class20();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate81_0 = value;
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
							Class20 @class;
							do
							{
								@class = (Class20)this.arrayList_0[num];
								if (@class.delegate81_0 != null && ((@class.delegate81_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000143 RID: 323
		// (add) Token: 0x06001268 RID: 4712 RVA: 0x00020914 File Offset: 0x0001EB14
		// (remove) Token: 0x06001269 RID: 4713 RVA: 0x000209A4 File Offset: 0x0001EBA4
		public event Delegate82 ondragend
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
					Class20 @class = new Class20();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate82_0 = value;
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
							Class20 @class;
							do
							{
								@class = (Class20)this.arrayList_0[num];
								if (@class.delegate82_0 != null && ((@class.delegate82_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000144 RID: 324
		// (add) Token: 0x0600126A RID: 4714 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		// (remove) Token: 0x0600126B RID: 4715 RVA: 0x00020B40 File Offset: 0x0001ED40
		public event Delegate83 onpositionchange
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
					Class20 @class = new Class20();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate83_0 = value;
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
							Class20 @class;
							do
							{
								@class = (Class20)this.arrayList_0[num];
								if (@class.delegate83_0 != null && ((@class.delegate83_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x0600126C RID: 4716 RVA: 0x00020C4C File Offset: 0x0001EE4C
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
							Class20 @class = (Class20)this.arrayList_0[num];
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

		// Token: 0x0600126D RID: 4717 RVA: 0x0000402B File Offset: 0x0000222B
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400012E RID: 302
		private IConnectionPointContainer iconnectionPointContainer_0;

		// Token: 0x0400012F RID: 303
		private ArrayList arrayList_0;

		// Token: 0x04000130 RID: 304
		private IConnectionPoint iconnectionPoint_0;
	}
}
