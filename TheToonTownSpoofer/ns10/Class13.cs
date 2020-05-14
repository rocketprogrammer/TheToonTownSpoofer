using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using ns5;

namespace ns10
{
	// Token: 0x0200014D RID: 333
	internal sealed class Class13 : IDisposable, Interface6
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x00018D9C File Offset: 0x00016F9C
		private void method_0()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				247,
				byte.MaxValue,
				23,
				187,
				146,
				22,
				85,
				69,
				145,
				138,
				106,
				247,
				191,
				172,
				237,
				210
			});
			this.iconnectionPointContainer_0.FindConnectionPoint(ref guid, out connectionPoint);
			this.iconnectionPoint_0 = (IConnectionPoint)connectionPoint;
			this.arrayList_0 = new ArrayList();
		}

		// Token: 0x140000FD RID: 253
		// (add) Token: 0x06001185 RID: 4485 RVA: 0x00018EB0 File Offset: 0x000170B0
		// (remove) Token: 0x06001186 RID: 4486 RVA: 0x00018F40 File Offset: 0x00017140
		public event Delegate63 onclick
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
					Class12 @class = new Class12();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate63_0 = value;
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
							Class12 @class;
							do
							{
								@class = (Class12)this.arrayList_0[num];
								if (@class.delegate63_0 != null && ((@class.delegate63_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x06001187 RID: 4487 RVA: 0x0001904C File Offset: 0x0001724C
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
							Class12 @class = (Class12)this.arrayList_0[num];
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

		// Token: 0x06001188 RID: 4488 RVA: 0x000035FC File Offset: 0x000017FC
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x040000D7 RID: 215
		private IConnectionPointContainer iconnectionPointContainer_0;

		// Token: 0x040000D8 RID: 216
		private ArrayList arrayList_0;

		// Token: 0x040000D9 RID: 217
		private IConnectionPoint iconnectionPoint_0;
	}
}
