using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace ns16
{
	// Token: 0x020003BD RID: 957
	internal sealed class Class385 : TaskScheduler
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x0001020D File Offset: 0x0000E40D
		public Class385(int maxDegreeOfParallelism)
		{
			if (maxDegreeOfParallelism < 1)
			{
				throw new ArgumentOutOfRangeException("maxDegreeOfParallelism");
			}
			this.int_0 = maxDegreeOfParallelism;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
		protected sealed override void QueueTask(Task task)
		{
			lock (this.linkedList_0)
			{
				this.linkedList_0.AddLast(task);
				if (this.int_1 < this.int_0)
				{
					this.int_1++;
					this.method_0();
				}
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00010236 File Offset: 0x0000E436
		private void method_0()
		{
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x0001024B File Offset: 0x0000E44B
		protected sealed override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			if (!Class385.bool_0)
			{
				return false;
			}
			if (taskWasPreviouslyQueued)
			{
				this.TryDequeue(task);
			}
			return base.TryExecuteTask(task);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0007EC20 File Offset: 0x0007CE20
		protected sealed override bool TryDequeue(Task task)
		{
			bool result;
			lock (this.linkedList_0)
			{
				result = this.linkedList_0.Remove(task);
			}
			return result;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00010268 File Offset: 0x0000E468
		public sealed override int MaximumConcurrencyLevel
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0007EC68 File Offset: 0x0007CE68
		protected sealed override IEnumerable<Task> GetScheduledTasks()
		{
			bool flag = false;
			IEnumerable<Task> result;
			try
			{
				Monitor.TryEnter(this.linkedList_0, ref flag);
				if (!flag)
				{
					throw new NotSupportedException();
				}
				result = this.linkedList_0.ToArray<Task>();
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this.linkedList_0);
				}
			}
			return result;
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0007ECBC File Offset: 0x0007CEBC
		[CompilerGenerated]
		private void method_1(object _)
		{
			Class385.bool_0 = true;
			try
			{
				for (;;)
				{
					Task value;
					lock (this.linkedList_0)
					{
						if (this.linkedList_0.Count == 0)
						{
							this.int_1--;
							break;
						}
						value = this.linkedList_0.First.Value;
						this.linkedList_0.RemoveFirst();
					}
					base.TryExecuteTask(value);
				}
			}
			finally
			{
				Class385.bool_0 = false;
			}
		}

		// Token: 0x04001149 RID: 4425
		[ThreadStatic]
		private static bool bool_0;

		// Token: 0x0400114A RID: 4426
		private readonly LinkedList<Task> linkedList_0 = new LinkedList<Task>();

		// Token: 0x0400114B RID: 4427
		private readonly int int_0;

		// Token: 0x0400114C RID: 4428
		private int int_1;
	}
}
