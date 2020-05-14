using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace ns25
{
	// Token: 0x0200033A RID: 826
	internal sealed class Class315 : SafeHandle
	{
		// Token: 0x06002002 RID: 8194 RVA: 0x0006A370 File Offset: 0x00068570
		public Class315(object target, GCHandleType type) : base(IntPtr.Zero, true)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				base.SetHandle(GCHandle.ToIntPtr(GCHandle.Alloc(target, type)));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0000CF01 File Offset: 0x0000B101
		public GCHandle Handle
		{
			get
			{
				return GCHandle.FromIntPtr(this.handle);
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0000CF0E File Offset: 0x0000B10E
		public override bool IsInvalid
		{
			[PrePrepareMethod]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0006A3B4 File Offset: 0x000685B4
		[PrePrepareMethod]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected override bool ReleaseHandle()
		{
			GCHandle.FromIntPtr(this.handle).Free();
			return true;
		}
	}
}
