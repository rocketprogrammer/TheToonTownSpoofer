using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using ns5;

namespace ns10
{
	// Token: 0x02000151 RID: 337
	internal sealed class Class17 : IDisposable, Interface7
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x00019600 File Offset: 0x00017800
		private void method_0()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				210,
				20,
				172,
				205,
				228,
				139,
				211,
				17,
				187,
				72,
				0,
				160,
				201,
				60,
				167,
				58
			});
			this.iconnectionPointContainer_0.FindConnectionPoint(ref guid, out connectionPoint);
			this.iconnectionPoint_0 = (IConnectionPoint)connectionPoint;
			this.arrayList_0 = new ArrayList();
		}

		// Token: 0x14000100 RID: 256
		// (add) Token: 0x06001198 RID: 4504 RVA: 0x00019714 File Offset: 0x00017914
		// (remove) Token: 0x06001199 RID: 4505 RVA: 0x000197A4 File Offset: 0x000179A4
		public event Delegate64 ondragbegin
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
					Class16 @class = new Class16();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate64_0 = value;
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
							Class16 @class;
							do
							{
								@class = (Class16)this.arrayList_0[num];
								if (@class.delegate64_0 != null && ((@class.delegate64_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000101 RID: 257
		// (add) Token: 0x0600119A RID: 4506 RVA: 0x000198B0 File Offset: 0x00017AB0
		// (remove) Token: 0x0600119B RID: 4507 RVA: 0x00019940 File Offset: 0x00017B40
		public event Delegate65 ondragend
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
					Class16 @class = new Class16();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate65_0 = value;
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
							Class16 @class;
							do
							{
								@class = (Class16)this.arrayList_0[num];
								if (@class.delegate65_0 != null && ((@class.delegate65_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000102 RID: 258
		// (add) Token: 0x0600119C RID: 4508 RVA: 0x00019A4C File Offset: 0x00017C4C
		// (remove) Token: 0x0600119D RID: 4509 RVA: 0x00019ADC File Offset: 0x00017CDC
		public event Delegate66 onpositionchange
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
					Class16 @class = new Class16();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate66_0 = value;
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
							Class16 @class;
							do
							{
								@class = (Class16)this.arrayList_0[num];
								if (@class.delegate66_0 != null && ((@class.delegate66_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x0600119E RID: 4510 RVA: 0x00019BE8 File Offset: 0x00017DE8
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
							Class16 @class = (Class16)this.arrayList_0[num];
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

		// Token: 0x0600119F RID: 4511 RVA: 0x00003714 File Offset: 0x00001914
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x040000E4 RID: 228
		private IConnectionPointContainer iconnectionPointContainer_0;

		// Token: 0x040000E5 RID: 229
		private ArrayList arrayList_0;

		// Token: 0x040000E6 RID: 230
		private IConnectionPoint iconnectionPoint_0;
	}
}
