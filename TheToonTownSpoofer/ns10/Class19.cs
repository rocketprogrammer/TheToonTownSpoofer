using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using ns1;
using ns2;
using ns3;

namespace ns10
{
	// Token: 0x02000153 RID: 339
	internal sealed class Class19 : IDisposable, Interface5
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00019F38 File Offset: 0x00018138
		private void method_0()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				81,
				42,
				245,
				107,
				74,
				57,
				211,
				17,
				177,
				83,
				0,
				192,
				79,
				121,
				250,
				166
			});
			this.iconnectionPointContainer_0.FindConnectionPoint(ref guid, out connectionPoint);
			this.iconnectionPoint_0 = (IConnectionPoint)connectionPoint;
			this.arrayList_0 = new ArrayList();
		}

		// Token: 0x1400013B RID: 315
		// (add) Token: 0x060011E1 RID: 4577 RVA: 0x0001A04C File Offset: 0x0001824C
		// (remove) Token: 0x060011E2 RID: 4578 RVA: 0x0001A0DC File Offset: 0x000182DC
		public event Delegate56 CdromBurnError
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate56_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate56_0 != null && ((@class.delegate56_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400013C RID: 316
		// (add) Token: 0x060011E3 RID: 4579 RVA: 0x0001A1E8 File Offset: 0x000183E8
		// (remove) Token: 0x060011E4 RID: 4580 RVA: 0x0001A278 File Offset: 0x00018478
		public event Delegate57 LibraryConnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate57_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate57_0 != null && ((@class.delegate57_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400013D RID: 317
		// (add) Token: 0x060011E5 RID: 4581 RVA: 0x0001A384 File Offset: 0x00018584
		// (remove) Token: 0x060011E6 RID: 4582 RVA: 0x0001A414 File Offset: 0x00018614
		public event Delegate58 LibraryDisconnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate58_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate58_0 != null && ((@class.delegate58_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400013E RID: 318
		// (add) Token: 0x060011E7 RID: 4583 RVA: 0x0001A520 File Offset: 0x00018720
		// (remove) Token: 0x060011E8 RID: 4584 RVA: 0x0001A5B0 File Offset: 0x000187B0
		public event Delegate59 FolderScanStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate59_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate59_0 != null && ((@class.delegate59_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400013F RID: 319
		// (add) Token: 0x060011E9 RID: 4585 RVA: 0x0001A6BC File Offset: 0x000188BC
		// (remove) Token: 0x060011EA RID: 4586 RVA: 0x0001A74C File Offset: 0x0001894C
		public event Delegate60 StringCollectionChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate60_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate60_0 != null && ((@class.delegate60_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000140 RID: 320
		// (add) Token: 0x060011EB RID: 4587 RVA: 0x0001A858 File Offset: 0x00018A58
		// (remove) Token: 0x060011EC RID: 4588 RVA: 0x0001A8E8 File Offset: 0x00018AE8
		public event Delegate61 MediaCollectionMediaAdded
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate61_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate61_0 != null && ((@class.delegate61_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000141 RID: 321
		// (add) Token: 0x060011ED RID: 4589 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		// (remove) Token: 0x060011EE RID: 4590 RVA: 0x0001AA84 File Offset: 0x00018C84
		public event Delegate62 MediaCollectionMediaRemoved
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate62_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate62_0 != null && ((@class.delegate62_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011F RID: 287
		// (add) Token: 0x060011EF RID: 4591 RVA: 0x0001AB90 File Offset: 0x00018D90
		// (remove) Token: 0x060011F0 RID: 4592 RVA: 0x0001AC20 File Offset: 0x00018E20
		public event Delegate28 PlaylistCollectionPlaylistSetAsDeleted
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate28_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate28_0 != null && ((@class.delegate28_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000120 RID: 288
		// (add) Token: 0x060011F1 RID: 4593 RVA: 0x0001AD2C File Offset: 0x00018F2C
		// (remove) Token: 0x060011F2 RID: 4594 RVA: 0x0001ADBC File Offset: 0x00018FBC
		public event Delegate29 ModeChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate29_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate29_0 != null && ((@class.delegate29_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000121 RID: 289
		// (add) Token: 0x060011F3 RID: 4595 RVA: 0x0001AEC8 File Offset: 0x000190C8
		// (remove) Token: 0x060011F4 RID: 4596 RVA: 0x0001AF58 File Offset: 0x00019158
		public event Delegate30 MediaError
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate30_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate30_0 != null && ((@class.delegate30_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000122 RID: 290
		// (add) Token: 0x060011F5 RID: 4597 RVA: 0x0001B064 File Offset: 0x00019264
		// (remove) Token: 0x060011F6 RID: 4598 RVA: 0x0001B0F4 File Offset: 0x000192F4
		public event Delegate31 OpenPlaylistSwitch
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate31_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate31_0 != null && ((@class.delegate31_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000123 RID: 291
		// (add) Token: 0x060011F7 RID: 4599 RVA: 0x0001B200 File Offset: 0x00019400
		// (remove) Token: 0x060011F8 RID: 4600 RVA: 0x0001B290 File Offset: 0x00019490
		public event Delegate32 DomainChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate32_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate32_0 != null && ((@class.delegate32_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000124 RID: 292
		// (add) Token: 0x060011F9 RID: 4601 RVA: 0x0001B39C File Offset: 0x0001959C
		// (remove) Token: 0x060011FA RID: 4602 RVA: 0x0001B42C File Offset: 0x0001962C
		public event Delegate33 SwitchedToPlayerApplication
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate33_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate33_0 != null && ((@class.delegate33_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000125 RID: 293
		// (add) Token: 0x060011FB RID: 4603 RVA: 0x0001B538 File Offset: 0x00019738
		// (remove) Token: 0x060011FC RID: 4604 RVA: 0x0001B5C8 File Offset: 0x000197C8
		public event Delegate34 SwitchedToControl
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate34_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate34_0 != null && ((@class.delegate34_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000126 RID: 294
		// (add) Token: 0x060011FD RID: 4605 RVA: 0x0001B6D4 File Offset: 0x000198D4
		// (remove) Token: 0x060011FE RID: 4606 RVA: 0x0001B764 File Offset: 0x00019964
		public event Delegate35 PlayerDockedStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate35_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate35_0 != null && ((@class.delegate35_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000127 RID: 295
		// (add) Token: 0x060011FF RID: 4607 RVA: 0x0001B870 File Offset: 0x00019A70
		// (remove) Token: 0x06001200 RID: 4608 RVA: 0x0001B900 File Offset: 0x00019B00
		public event Delegate36 PlayerReconnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate36_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate36_0 != null && ((@class.delegate36_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000128 RID: 296
		// (add) Token: 0x06001201 RID: 4609 RVA: 0x0001BA0C File Offset: 0x00019C0C
		// (remove) Token: 0x06001202 RID: 4610 RVA: 0x0001BA9C File Offset: 0x00019C9C
		public event Delegate37 Click
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate37_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate37_0 != null && ((@class.delegate37_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000129 RID: 297
		// (add) Token: 0x06001203 RID: 4611 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		// (remove) Token: 0x06001204 RID: 4612 RVA: 0x0001BC38 File Offset: 0x00019E38
		public event Delegate38 DoubleClick
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate38_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate38_0 != null && ((@class.delegate38_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012A RID: 298
		// (add) Token: 0x06001205 RID: 4613 RVA: 0x0001BD44 File Offset: 0x00019F44
		// (remove) Token: 0x06001206 RID: 4614 RVA: 0x0001BDD4 File Offset: 0x00019FD4
		public event Delegate39 KeyDown
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate39_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate39_0 != null && ((@class.delegate39_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012B RID: 299
		// (add) Token: 0x06001207 RID: 4615 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
		// (remove) Token: 0x06001208 RID: 4616 RVA: 0x0001BF70 File Offset: 0x0001A170
		public event Delegate40 KeyPress
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate40_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate40_0 != null && ((@class.delegate40_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012C RID: 300
		// (add) Token: 0x06001209 RID: 4617 RVA: 0x0001C07C File Offset: 0x0001A27C
		// (remove) Token: 0x0600120A RID: 4618 RVA: 0x0001C10C File Offset: 0x0001A30C
		public event Delegate41 KeyUp
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate41_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate41_0 != null && ((@class.delegate41_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012D RID: 301
		// (add) Token: 0x0600120B RID: 4619 RVA: 0x0001C218 File Offset: 0x0001A418
		// (remove) Token: 0x0600120C RID: 4620 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		public event Delegate42 MouseDown
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate42_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate42_0 != null && ((@class.delegate42_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012E RID: 302
		// (add) Token: 0x0600120D RID: 4621 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
		// (remove) Token: 0x0600120E RID: 4622 RVA: 0x0001C444 File Offset: 0x0001A644
		public event Delegate43 MouseMove
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate43_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate43_0 != null && ((@class.delegate43_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400012F RID: 303
		// (add) Token: 0x0600120F RID: 4623 RVA: 0x0001C550 File Offset: 0x0001A750
		// (remove) Token: 0x06001210 RID: 4624 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
		public event Delegate44 MouseUp
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate44_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate44_0 != null && ((@class.delegate44_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000130 RID: 304
		// (add) Token: 0x06001211 RID: 4625 RVA: 0x0001C6EC File Offset: 0x0001A8EC
		// (remove) Token: 0x06001212 RID: 4626 RVA: 0x0001C77C File Offset: 0x0001A97C
		public event Delegate45 DeviceConnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate45_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate45_0 != null && ((@class.delegate45_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000131 RID: 305
		// (add) Token: 0x06001213 RID: 4627 RVA: 0x0001C888 File Offset: 0x0001AA88
		// (remove) Token: 0x06001214 RID: 4628 RVA: 0x0001C918 File Offset: 0x0001AB18
		public event Delegate46 DeviceDisconnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate46_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate46_0 != null && ((@class.delegate46_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000132 RID: 306
		// (add) Token: 0x06001215 RID: 4629 RVA: 0x0001CA24 File Offset: 0x0001AC24
		// (remove) Token: 0x06001216 RID: 4630 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		public event Delegate47 DeviceStatusChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate47_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate47_0 != null && ((@class.delegate47_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000133 RID: 307
		// (add) Token: 0x06001217 RID: 4631 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		// (remove) Token: 0x06001218 RID: 4632 RVA: 0x0001CC50 File Offset: 0x0001AE50
		public event Delegate48 DeviceSyncStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate48_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate48_0 != null && ((@class.delegate48_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000134 RID: 308
		// (add) Token: 0x06001219 RID: 4633 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		// (remove) Token: 0x0600121A RID: 4634 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		public event Delegate49 DeviceSyncError
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate49_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate49_0 != null && ((@class.delegate49_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000135 RID: 309
		// (add) Token: 0x0600121B RID: 4635 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		// (remove) Token: 0x0600121C RID: 4636 RVA: 0x0001CF88 File Offset: 0x0001B188
		public event Delegate50 CreatePartnershipComplete
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate50_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate50_0 != null && ((@class.delegate50_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000136 RID: 310
		// (add) Token: 0x0600121D RID: 4637 RVA: 0x0001D094 File Offset: 0x0001B294
		// (remove) Token: 0x0600121E RID: 4638 RVA: 0x0001D124 File Offset: 0x0001B324
		public event Delegate51 DeviceEstimation
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate51_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate51_0 != null && ((@class.delegate51_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000137 RID: 311
		// (add) Token: 0x0600121F RID: 4639 RVA: 0x0001D230 File Offset: 0x0001B430
		// (remove) Token: 0x06001220 RID: 4640 RVA: 0x0001D2C0 File Offset: 0x0001B4C0
		public event Delegate52 CdromRipStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate52_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate52_0 != null && ((@class.delegate52_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000138 RID: 312
		// (add) Token: 0x06001221 RID: 4641 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		// (remove) Token: 0x06001222 RID: 4642 RVA: 0x0001D45C File Offset: 0x0001B65C
		public event Delegate53 CdromRipMediaError
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate53_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate53_0 != null && ((@class.delegate53_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000139 RID: 313
		// (add) Token: 0x06001223 RID: 4643 RVA: 0x0001D568 File Offset: 0x0001B768
		// (remove) Token: 0x06001224 RID: 4644 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		public event Delegate54 CdromBurnStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate54_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate54_0 != null && ((@class.delegate54_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400013A RID: 314
		// (add) Token: 0x06001225 RID: 4645 RVA: 0x0001D704 File Offset: 0x0001B904
		// (remove) Token: 0x06001226 RID: 4646 RVA: 0x0001D794 File Offset: 0x0001B994
		public event Delegate55 CdromBurnMediaError
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate55_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate55_0 != null && ((@class.delegate55_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000103 RID: 259
		// (add) Token: 0x06001227 RID: 4647 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		// (remove) Token: 0x06001228 RID: 4648 RVA: 0x0001D930 File Offset: 0x0001BB30
		public event Delegate0 OpenStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate0_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate0_0 != null && ((@class.delegate0_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000104 RID: 260
		// (add) Token: 0x06001229 RID: 4649 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		// (remove) Token: 0x0600122A RID: 4650 RVA: 0x0001DACC File Offset: 0x0001BCCC
		public event Delegate1 PlayStateChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate1_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate1_0 != null && ((@class.delegate1_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000105 RID: 261
		// (add) Token: 0x0600122B RID: 4651 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		// (remove) Token: 0x0600122C RID: 4652 RVA: 0x0001DC68 File Offset: 0x0001BE68
		public event Delegate2 AudioLanguageChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate2_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate2_0 != null && ((@class.delegate2_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000106 RID: 262
		// (add) Token: 0x0600122D RID: 4653 RVA: 0x0001DD74 File Offset: 0x0001BF74
		// (remove) Token: 0x0600122E RID: 4654 RVA: 0x0001DE04 File Offset: 0x0001C004
		public event Delegate3 StatusChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate3_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate3_0 != null && ((@class.delegate3_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000107 RID: 263
		// (add) Token: 0x0600122F RID: 4655 RVA: 0x0001DF10 File Offset: 0x0001C110
		// (remove) Token: 0x06001230 RID: 4656 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		public event Delegate4 ScriptCommand
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate4_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate4_0 != null && ((@class.delegate4_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000108 RID: 264
		// (add) Token: 0x06001231 RID: 4657 RVA: 0x0001E0AC File Offset: 0x0001C2AC
		// (remove) Token: 0x06001232 RID: 4658 RVA: 0x0001E13C File Offset: 0x0001C33C
		public event Delegate5 NewStream
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate5_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate5_0 != null && ((@class.delegate5_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000109 RID: 265
		// (add) Token: 0x06001233 RID: 4659 RVA: 0x0001E248 File Offset: 0x0001C448
		// (remove) Token: 0x06001234 RID: 4660 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
		public event Delegate6 Disconnect
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate6_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate6_0 != null && ((@class.delegate6_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010A RID: 266
		// (add) Token: 0x06001235 RID: 4661 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
		// (remove) Token: 0x06001236 RID: 4662 RVA: 0x0001E474 File Offset: 0x0001C674
		public event Delegate7 Buffering
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate7_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate7_0 != null && ((@class.delegate7_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010B RID: 267
		// (add) Token: 0x06001237 RID: 4663 RVA: 0x0001E580 File Offset: 0x0001C780
		// (remove) Token: 0x06001238 RID: 4664 RVA: 0x0001E610 File Offset: 0x0001C810
		public event Delegate8 Error
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate8_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate8_0 != null && ((@class.delegate8_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010C RID: 268
		// (add) Token: 0x06001239 RID: 4665 RVA: 0x0001E71C File Offset: 0x0001C91C
		// (remove) Token: 0x0600123A RID: 4666 RVA: 0x0001E7AC File Offset: 0x0001C9AC
		public event Delegate9 Warning
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate9_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate9_0 != null && ((@class.delegate9_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010D RID: 269
		// (add) Token: 0x0600123B RID: 4667 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		// (remove) Token: 0x0600123C RID: 4668 RVA: 0x0001E948 File Offset: 0x0001CB48
		public event Delegate10 EndOfStream
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate10_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate10_0 != null && ((@class.delegate10_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010E RID: 270
		// (add) Token: 0x0600123D RID: 4669 RVA: 0x0001EA54 File Offset: 0x0001CC54
		// (remove) Token: 0x0600123E RID: 4670 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
		public event Delegate11 PositionChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate11_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate11_0 != null && ((@class.delegate11_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400010F RID: 271
		// (add) Token: 0x0600123F RID: 4671 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		// (remove) Token: 0x06001240 RID: 4672 RVA: 0x0001EC80 File Offset: 0x0001CE80
		public event Delegate12 MarkerHit
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate12_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate12_0 != null && ((@class.delegate12_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000110 RID: 272
		// (add) Token: 0x06001241 RID: 4673 RVA: 0x0001ED8C File Offset: 0x0001CF8C
		// (remove) Token: 0x06001242 RID: 4674 RVA: 0x0001EE1C File Offset: 0x0001D01C
		public event Delegate13 DurationUnitChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate13_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate13_0 != null && ((@class.delegate13_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000111 RID: 273
		// (add) Token: 0x06001243 RID: 4675 RVA: 0x0001EF28 File Offset: 0x0001D128
		// (remove) Token: 0x06001244 RID: 4676 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
		public event Delegate14 CdromMediaChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate14_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate14_0 != null && ((@class.delegate14_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000112 RID: 274
		// (add) Token: 0x06001245 RID: 4677 RVA: 0x0001F0C4 File Offset: 0x0001D2C4
		// (remove) Token: 0x06001246 RID: 4678 RVA: 0x0001F154 File Offset: 0x0001D354
		public event Delegate15 PlaylistChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate15_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate15_0 != null && ((@class.delegate15_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000113 RID: 275
		// (add) Token: 0x06001247 RID: 4679 RVA: 0x0001F260 File Offset: 0x0001D460
		// (remove) Token: 0x06001248 RID: 4680 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		public event Delegate16 CurrentPlaylistChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate16_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate16_0 != null && ((@class.delegate16_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000114 RID: 276
		// (add) Token: 0x06001249 RID: 4681 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		// (remove) Token: 0x0600124A RID: 4682 RVA: 0x0001F48C File Offset: 0x0001D68C
		public event Delegate17 CurrentPlaylistItemAvailable
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate17_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate17_0 != null && ((@class.delegate17_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000115 RID: 277
		// (add) Token: 0x0600124B RID: 4683 RVA: 0x0001F598 File Offset: 0x0001D798
		// (remove) Token: 0x0600124C RID: 4684 RVA: 0x0001F628 File Offset: 0x0001D828
		public event Delegate18 MediaChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate18_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate18_0 != null && ((@class.delegate18_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000116 RID: 278
		// (add) Token: 0x0600124D RID: 4685 RVA: 0x0001F734 File Offset: 0x0001D934
		// (remove) Token: 0x0600124E RID: 4686 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		public event Delegate19 CurrentMediaItemAvailable
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate19_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate19_0 != null && ((@class.delegate19_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000117 RID: 279
		// (add) Token: 0x0600124F RID: 4687 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		// (remove) Token: 0x06001250 RID: 4688 RVA: 0x0001F960 File Offset: 0x0001DB60
		public event Delegate20 CurrentItemChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate20_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate20_0 != null && ((@class.delegate20_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000118 RID: 280
		// (add) Token: 0x06001251 RID: 4689 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		// (remove) Token: 0x06001252 RID: 4690 RVA: 0x0001FAFC File Offset: 0x0001DCFC
		public event Delegate21 MediaCollectionChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate21_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate21_0 != null && ((@class.delegate21_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x14000119 RID: 281
		// (add) Token: 0x06001253 RID: 4691 RVA: 0x0001FC08 File Offset: 0x0001DE08
		// (remove) Token: 0x06001254 RID: 4692 RVA: 0x0001FC98 File Offset: 0x0001DE98
		public event Delegate22 MediaCollectionAttributeStringAdded
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate22_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate22_0 != null && ((@class.delegate22_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011A RID: 282
		// (add) Token: 0x06001255 RID: 4693 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		// (remove) Token: 0x06001256 RID: 4694 RVA: 0x0001FE34 File Offset: 0x0001E034
		public event Delegate23 MediaCollectionAttributeStringRemoved
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate23_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate23_0 != null && ((@class.delegate23_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011B RID: 283
		// (add) Token: 0x06001257 RID: 4695 RVA: 0x0001FF40 File Offset: 0x0001E140
		// (remove) Token: 0x06001258 RID: 4696 RVA: 0x0001FFD0 File Offset: 0x0001E1D0
		public event Delegate24 MediaCollectionAttributeStringChanged
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate24_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate24_0 != null && ((@class.delegate24_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011C RID: 284
		// (add) Token: 0x06001259 RID: 4697 RVA: 0x000200DC File Offset: 0x0001E2DC
		// (remove) Token: 0x0600125A RID: 4698 RVA: 0x0002016C File Offset: 0x0001E36C
		public event Delegate25 PlaylistCollectionChange
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate25_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate25_0 != null && ((@class.delegate25_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011D RID: 285
		// (add) Token: 0x0600125B RID: 4699 RVA: 0x00020278 File Offset: 0x0001E478
		// (remove) Token: 0x0600125C RID: 4700 RVA: 0x00020308 File Offset: 0x0001E508
		public event Delegate26 PlaylistCollectionPlaylistAdded
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate26_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate26_0 != null && ((@class.delegate26_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x1400011E RID: 286
		// (add) Token: 0x0600125D RID: 4701 RVA: 0x00020414 File Offset: 0x0001E614
		// (remove) Token: 0x0600125E RID: 4702 RVA: 0x000204A4 File Offset: 0x0001E6A4
		public event Delegate27 PlaylistCollectionPlaylistRemoved
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
					Class18 @class = new Class18();
					int int_ = 0;
					this.iconnectionPoint_0.Advise((object)@class, out int_);
					@class.int_0 = int_;
					@class.delegate27_0 = value;
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
							Class18 @class;
							do
							{
								@class = (Class18)this.arrayList_0[num];
								if (@class.delegate27_0 != null && ((@class.delegate27_0.Equals((object)value) ? 1 : 0) & 255) != 0)
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

		// Token: 0x0600125F RID: 4703 RVA: 0x000205B0 File Offset: 0x0001E7B0
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
							Class18 @class = (Class18)this.arrayList_0[num];
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

		// Token: 0x06001260 RID: 4704 RVA: 0x00003F8C File Offset: 0x0000218C
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000127 RID: 295
		private IConnectionPointContainer iconnectionPointContainer_0;

		// Token: 0x04000128 RID: 296
		private ArrayList arrayList_0;

		// Token: 0x04000129 RID: 297
		private IConnectionPoint iconnectionPoint_0;
	}
}
