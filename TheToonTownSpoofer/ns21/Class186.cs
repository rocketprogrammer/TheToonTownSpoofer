using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns15;
using ns18;
using ns20;
using ns29;
using ns31;

namespace ns21
{
	// Token: 0x02000243 RID: 579
	internal sealed class Class186
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x000081B7 File Offset: 0x000063B7
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x000081BF File Offset: 0x000063BF
		public string Version { get; set; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x000081C8 File Offset: 0x000063C8
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x000081D0 File Offset: 0x000063D0
		public long ExpectedSize { get; set; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000081D9 File Offset: 0x000063D9
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x000081E1 File Offset: 0x000063E1
		public Struct43 ExpectedHash { get; set; }

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x000081EA File Offset: 0x000063EA
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x000081F2 File Offset: 0x000063F2
		public List<Class282> Patches { get; private set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x000081FB File Offset: 0x000063FB
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00008203 File Offset: 0x00006403
		public bool ForceRecheck { get; set; }

		// Token: 0x060018C1 RID: 6337 RVA: 0x0000820C File Offset: 0x0000640C
		public Class186()
		{
			this.Patches = new List<Class282>();
			this.ForceRecheck = false;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00008226 File Offset: 0x00006426
		public Class186(long expectedSize, Struct43 expectedHash, string version) : this()
		{
			this.ExpectedSize = expectedSize;
			this.ExpectedHash = expectedHash;
			this.Version = version;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000432A8 File Offset: 0x000414A8
		public Class186 method_0()
		{
			return new Class186
			{
				Version = this.Version,
				ExpectedSize = this.ExpectedSize,
				ExpectedHash = this.ExpectedHash
			};
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000432E0 File Offset: 0x000414E0
		public Class186 method_1(Struct43 expectedHash)
		{
			Class186 @class = this.method_0();
			lock (((ICollection)this.Patches).SyncRoot)
			{
				for (int i = this.Patches.Count - 1; i >= 0; i--)
				{
					if (Struct43.smethod_5(expectedHash, this.Patches[i].ExpectedHash))
					{
						while (i < this.Patches.Count)
						{
							@class.Patches.Add(this.Patches[i].imethod_0());
							i++;
						}
						break;
					}
				}
			}
			return @class;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00043388 File Offset: 0x00041588
		public bool method_2(Struct43 hash)
		{
			lock (((ICollection)this.Patches).SyncRoot)
			{
				foreach (Class282 @class in this.Patches)
				{
					if (Struct43.smethod_5(@class.ExpectedHash, hash))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0004341C File Offset: 0x0004161C
		public Enum23 method_3(string filename, out Struct43 actualFileHash)
		{
			long num;
			return this.method_4(filename, out actualFileHash, out num);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00043434 File Offset: 0x00041634
		public Enum23 method_4(string filename, out Struct43 actualFileHash, out long actualFileSize)
		{
			actualFileSize = 0L;
			actualFileHash = default(Struct43);
			Enum23 result;
			try
			{
				if (File.Exists(filename))
				{
					actualFileHash = Class513.smethod_0(filename);
					if (this.ExpectedSize == (actualFileSize = Class234.smethod_11(filename)))
					{
						if (Struct43.smethod_5(this.ExpectedHash, actualFileHash))
						{
							result = Enum23.const_2;
						}
						else
						{
							result = Enum23.const_1;
						}
					}
					else
					{
						result = Enum23.const_1;
					}
				}
				else
				{
					result = Enum23.const_0;
				}
			}
			finally
			{
				this.ForceRecheck = false;
			}
			return result;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000434B8 File Offset: 0x000416B8
		public Enum23 method_5(Class186 lastFile, string filename, out Struct43 actualFileHash)
		{
			actualFileHash = default(Struct43);
			Enum23 result;
			try
			{
				if (File.Exists(filename))
				{
					if (!this.ForceRecheck && !lastFile.ForceRecheck && !(this.Version != lastFile.Version))
					{
						if (this.ExpectedSize == Class234.smethod_11(filename))
						{
							return Enum23.const_2;
						}
					}
					actualFileHash = Class513.smethod_0(filename);
					if (Struct43.smethod_5(this.ExpectedHash, actualFileHash))
					{
						result = Enum23.const_2;
					}
					else
					{
						result = Enum23.const_1;
					}
				}
				else
				{
					result = Enum23.const_0;
				}
			}
			finally
			{
				this.ForceRecheck = false;
			}
			return result;
		}

		// Token: 0x04000691 RID: 1681
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000692 RID: 1682
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000693 RID: 1683
		[CompilerGenerated]
		private Struct43 struct43_0;

		// Token: 0x04000694 RID: 1684
		[CompilerGenerated]
		private List<Class282> list_0;

		// Token: 0x04000695 RID: 1685
		[CompilerGenerated]
		private bool bool_0;
	}
}
