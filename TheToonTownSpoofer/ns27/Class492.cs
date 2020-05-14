using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns15;
using ns16;
using ns19;
using ns30;

namespace ns27
{
	// Token: 0x02000498 RID: 1176
	internal sealed class Class492
	{
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000145F3 File Offset: 0x000127F3
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x000145FB File Offset: 0x000127FB
		public Enum93 Action { get; private set; }

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00014604 File Offset: 0x00012804
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0001460C File Offset: 0x0001280C
		public Enum87 UpdateStep { get; private set; }

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x00014615 File Offset: 0x00012815
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0001461D File Offset: 0x0001281D
		public List<string> ExtraData { get; private set; }

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x00014626 File Offset: 0x00012826
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0001462E File Offset: 0x0001282E
		public List<bool> ExtraDataIsRTF { get; private set; }

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00014637 File Offset: 0x00012837
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0001463F File Offset: 0x0001283F
		public Enum28 ResponseType { get; private set; }

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x00014648 File Offset: 0x00012848
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00014650 File Offset: 0x00012850
		public int Progress { get; private set; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x00014659 File Offset: 0x00012859
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00014661 File Offset: 0x00012861
		public int ProcessID { get; private set; }

		// Token: 0x06002BDA RID: 11226 RVA: 0x0001466A File Offset: 0x0001286A
		public Class492()
		{
			this.Progress = -1;
			this.ResponseType = Enum28.const_1;
			this.ExtraDataIsRTF = new List<bool>();
			this.ExtraData = new List<string>();
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00014696 File Offset: 0x00012896
		public Class492(Enum93 action) : this()
		{
			this.Action = action;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000146A5 File Offset: 0x000128A5
		public Class492(Enum87 step) : this()
		{
			this.Action = Enum93.const_0;
			this.UpdateStep = step;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000AA5E4 File Offset: 0x000A87E4
		public Class492(Enum28 responseType, Enum87 step, string messageTitle, string messageBody) : this(step)
		{
			this.ResponseType = responseType;
			this.ExtraData.Add(messageTitle);
			this.ExtraData.Add(messageBody);
			this.ExtraDataIsRTF.Add(false);
			this.ExtraDataIsRTF.Add(false);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000AA630 File Offset: 0x000A8830
		public byte[] method_0()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Class120.smethod_0(memoryStream, 1, (int)this.Action);
				Class120.smethod_0(memoryStream, 2, (int)this.UpdateStep);
				for (int i = 0; i < this.ExtraData.Count; i++)
				{
					if (!string.IsNullOrEmpty(this.ExtraData[i]))
					{
						if (this.ExtraDataIsRTF[i])
						{
							memoryStream.WriteByte(128);
						}
						Class120.smethod_5(memoryStream, 3, this.ExtraData[i]);
					}
				}
				if (this.ProcessID != 0)
				{
					Class120.smethod_0(memoryStream, 4, this.ProcessID);
				}
				if (this.Progress > -1 && this.Progress <= 100)
				{
					Class120.smethod_0(memoryStream, 5, this.Progress);
				}
				if (this.ResponseType != Enum28.const_1)
				{
					Class120.smethod_0(memoryStream, 6, (int)this.ResponseType);
				}
				memoryStream.WriteByte(byte.MaxValue);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000AA72C File Offset: 0x000A892C
		public static Class492 smethod_0(byte[] data)
		{
			Class492 @class = new Class492();
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				byte b = (byte)memoryStream.ReadByte();
				while (!Class493.smethod_9(memoryStream, b, 255))
				{
					byte b2 = b;
					switch (b2)
					{
					case 1:
						@class.Action = (Enum93)Class493.smethod_4(memoryStream);
						break;
					case 2:
						@class.UpdateStep = (Enum87)Class493.smethod_4(memoryStream);
						break;
					case 3:
						@class.ExtraData.Add(Class493.smethod_1(memoryStream));
						if (@class.ExtraDataIsRTF.Count != @class.ExtraData.Count)
						{
							@class.ExtraDataIsRTF.Add(false);
						}
						break;
					case 4:
						@class.ProcessID = Class493.smethod_4(memoryStream);
						break;
					case 5:
						@class.Progress = Class493.smethod_4(memoryStream);
						break;
					case 6:
						@class.ResponseType = (Enum28)Class493.smethod_4(memoryStream);
						break;
					default:
						if (b2 != 128)
						{
							Class493.smethod_10(memoryStream, b);
						}
						else
						{
							@class.ExtraDataIsRTF.Add(true);
						}
						break;
					}
					b = (byte)memoryStream.ReadByte();
				}
			}
			return @class;
		}

		// Token: 0x04001715 RID: 5909
		[CompilerGenerated]
		private Enum93 enum93_0;

		// Token: 0x04001716 RID: 5910
		[CompilerGenerated]
		private Enum87 enum87_0;

		// Token: 0x04001717 RID: 5911
		[CompilerGenerated]
		private List<string> list_0;

		// Token: 0x04001718 RID: 5912
		[CompilerGenerated]
		private List<bool> list_1;

		// Token: 0x04001719 RID: 5913
		[CompilerGenerated]
		private Enum28 enum28_0;

		// Token: 0x0400171A RID: 5914
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400171B RID: 5915
		[CompilerGenerated]
		private int int_1;
	}
}
