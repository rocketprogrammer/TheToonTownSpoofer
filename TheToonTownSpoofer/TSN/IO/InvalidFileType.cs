using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;
using ns17;

namespace TSN.IO
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public sealed class InvalidFileType : IOException
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0000A337 File Offset: 0x00008537
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000A33F File Offset: 0x0000853F
		public string FileName { get; private set; }

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000A348 File Offset: 0x00008548
		public InvalidFileType(string fileName) : base(InvalidFileType.smethod_0(fileName, null, null))
		{
			this.FileName = fileName;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0000A35F File Offset: 0x0000855F
		public InvalidFileType(byte[] expectedHeader, byte[] actualHeader) : base(InvalidFileType.smethod_0(string.Empty, expectedHeader, actualHeader))
		{
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0000A373 File Offset: 0x00008573
		public InvalidFileType(string expectedHeader, string actualHeader) : base(InvalidFileType.smethod_1(string.Empty, expectedHeader, actualHeader))
		{
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000A387 File Offset: 0x00008587
		public InvalidFileType(string fileName, byte[] expectedHeader, byte[] actualHeader) : base(InvalidFileType.smethod_0(fileName, expectedHeader, actualHeader))
		{
			this.FileName = fileName;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0000A39E File Offset: 0x0000859E
		public InvalidFileType(string fileName, string expectedHeader, string actualHeader) : base(InvalidFileType.smethod_1(fileName, expectedHeader, actualHeader))
		{
			this.FileName = fileName;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000A3B5 File Offset: 0x000085B5
		private InvalidFileType(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("InvalidFileType_FileName");
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0000A3D0 File Offset: 0x000085D0
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InvalidFileType_FileName", this.FileName, typeof(string));
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00056F88 File Offset: 0x00055188
		private static string smethod_0(string fileName, byte[] expectedHeader, byte[] actualHeader)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				return string.Format(Class217.cultureInfo_0, InvalidFileType.g_sStreamMessage, new object[]
				{
					InvalidFileType.smethod_2(expectedHeader),
					InvalidFileType.smethod_2(actualHeader)
				});
			}
			return string.Format(Class217.cultureInfo_0, InvalidFileType.g_sFileMessage, new object[]
			{
				fileName,
				InvalidFileType.smethod_2(expectedHeader),
				InvalidFileType.smethod_2(actualHeader)
			});
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00056FF4 File Offset: 0x000551F4
		private static string smethod_1(string fileName, string expectedHeader, string actualHeader)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				return string.Format(Class217.cultureInfo_0, InvalidFileType.g_sStreamMessage, new object[]
				{
					expectedHeader ?? "null",
					actualHeader ?? "null"
				});
			}
			return string.Format(Class217.cultureInfo_0, InvalidFileType.g_sFileMessage, new object[]
			{
				fileName,
				expectedHeader ?? "null",
				actualHeader ?? "null"
			});
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00057070 File Offset: 0x00055270
		private static string smethod_2(byte[] b)
		{
			if (b == null)
			{
				return "null";
			}
			string text = string.Empty;
			for (int i = 0; i < b.Length; i++)
			{
				if (text != string.Empty)
				{
					text += ", ";
				}
				text += b[i].ToString(Class217.cultureInfo_0);
			}
			return text;
		}

		// Token: 0x04000977 RID: 2423
		private static readonly string g_sFileMessage = "Attempted to read an invalid file type in file: '{0}'. Expected header: '{1}', actual header: '{2}'.";

		// Token: 0x04000978 RID: 2424
		private static readonly string g_sStreamMessage = "Attempted to read an invalid file type. Expected header: '{0}', actual header: '{1}'.";
	}
}
