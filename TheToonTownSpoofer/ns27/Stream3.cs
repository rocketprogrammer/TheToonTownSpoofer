using System;
using System.Diagnostics;
using System.IO;

namespace ns27
{
	// Token: 0x02000482 RID: 1154
	internal sealed class Stream3 : Stream
	{
		// Token: 0x06002AF0 RID: 10992 RVA: 0x00014042 File Offset: 0x00012242
		[DebuggerStepThrough]
		public Stream3(Stream baseStream) : this(baseStream, 0L)
		{
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x00014054 File Offset: 0x00012254
		[DebuggerStepThrough]
		public Stream3(Stream baseStream, long startingPos) : this(baseStream, startingPos, -1L)
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00014067 File Offset: 0x00012267
		[DebuggerStepThrough]
		public Stream3(Stream baseStream, long startingPos, long endPosition)
		{
			if (baseStream == null)
			{
				throw new ArgumentNullException("baseStream");
			}
			this.long_1 = endPosition;
			this.long_0 = startingPos;
			this.stream_0 = baseStream;
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x00014092 File Offset: 0x00012292
		public override bool CanRead
		{
			[DebuggerStepThrough]
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0001409F File Offset: 0x0001229F
		public override bool CanSeek
		{
			[DebuggerStepThrough]
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000140AC File Offset: 0x000122AC
		public override bool CanWrite
		{
			[DebuggerStepThrough]
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000140B9 File Offset: 0x000122B9
		[DebuggerStepThrough]
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000140C6 File Offset: 0x000122C6
		public override long Length
		{
			[DebuggerStepThrough]
			get
			{
				if (this.long_1 == -1L)
				{
					return this.stream_0.Length - this.long_0;
				}
				return this.long_1 - this.long_0;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000140F9 File Offset: 0x000122F9
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x0001410D File Offset: 0x0001230D
		public override long Position
		{
			[DebuggerStepThrough]
			get
			{
				return this.stream_0.Position - this.long_0;
			}
			[DebuggerStepThrough]
			set
			{
				this.stream_0.Position = value + this.long_0;
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000A6F8C File Offset: 0x000A518C
		[DebuggerStepThrough]
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.long_1 != -1L && this.long_1 < this.stream_0.Position + (long)count)
			{
				count = (int)(this.long_1 - this.stream_0.Position);
			}
			return this.stream_0.Read(buffer, offset, count);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000A6FE4 File Offset: 0x000A51E4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (this.long_1 != -1L && this.long_1 < this.stream_0.Position + (long)count)
			{
				count = (int)(this.long_1 - this.stream_0.Position);
			}
			return this.stream_0.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00014122 File Offset: 0x00012322
		public override int EndRead(IAsyncResult asyncResult)
		{
			return this.stream_0.EndRead(asyncResult);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000A7040 File Offset: 0x000A5240
		[DebuggerStepThrough]
		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
			case SeekOrigin.Begin:
				if (offset < this.long_0)
				{
					return this.stream_0.Seek(this.long_0, SeekOrigin.Begin);
				}
				if (this.long_1 != -1L && offset + this.long_0 > this.long_1)
				{
					return this.stream_0.Seek(this.long_1, SeekOrigin.Begin);
				}
				return this.stream_0.Seek(offset + this.long_0, SeekOrigin.Begin);
			case SeekOrigin.Current:
				if (this.stream_0.Position + offset < this.long_0)
				{
					return this.stream_0.Seek(this.long_0, SeekOrigin.Begin);
				}
				if (this.long_1 != -1L && this.long_1 < this.stream_0.Position + offset)
				{
					return this.stream_0.Seek(this.long_1, SeekOrigin.Begin);
				}
				return this.stream_0.Seek(offset, SeekOrigin.Current);
			case SeekOrigin.End:
				if (this.stream_0.Length + offset < this.long_0)
				{
					return this.stream_0.Seek(this.long_0, SeekOrigin.Begin);
				}
				if (this.long_1 != -1L && this.stream_0.Length + offset > this.long_1)
				{
					return this.stream_0.Seek(this.long_1, SeekOrigin.Begin);
				}
				return this.stream_0.Seek(offset, SeekOrigin.End);
			default:
				throw new NotSupportedException("The specified operation is not supported.");
			}
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00014130 File Offset: 0x00012330
		[DebuggerStepThrough]
		public override void SetLength(long value)
		{
			if (this.long_1 != -1L)
			{
				throw new NotSupportedException("Cannot set the length of a ranged sub stream.");
			}
			this.stream_0.SetLength(value + this.long_0);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00014161 File Offset: 0x00012361
		[DebuggerStepThrough]
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.stream_0.Write(buffer, offset, count);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00014171 File Offset: 0x00012371
		[DebuggerStepThrough]
		public override void WriteByte(byte value)
		{
			this.stream_0.WriteByte(value);
		}

		// Token: 0x040016D4 RID: 5844
		private long long_0;

		// Token: 0x040016D5 RID: 5845
		private long long_1;

		// Token: 0x040016D6 RID: 5846
		private Stream stream_0;
	}
}
