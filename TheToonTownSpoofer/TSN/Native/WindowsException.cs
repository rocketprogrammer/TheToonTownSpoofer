using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using ns16;
using ns23;
using TSN.Native.Enums;

namespace TSN.Native
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public sealed class WindowsException : Exception
	{
		// Token: 0x06001A65 RID: 6757 RVA: 0x00009600 File Offset: 0x00007800
		public WindowsException()
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00009608 File Offset: 0x00007808
		public WindowsException(Win32Error errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00009617 File Offset: 0x00007817
		public WindowsException(NtStatus status)
		{
			this.Status = status;
			this.ErrorCode = status.smethod_7();
			this.IsNT_STATUS = true;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		private WindowsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.m_sMessage = info.GetString("WindowsException_Message");
			this.Status = (NtStatus)info.GetValue("WindowsException_Status", typeof(NtStatus));
			this.ErrorCode = (Win32Error)info.GetValue("WindowsException_ErrorCode", typeof(Win32Error));
			this.IsNT_STATUS = info.GetBoolean("WindowsException_IsNT_STATUS");
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0004E324 File Offset: 0x0004C524
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("WindowsException_Message", this.m_sMessage);
			info.AddValue("WindowsException_Status", this.Status, typeof(NtStatus));
			info.AddValue("WindowsException_ErrorCode", this.ErrorCode, typeof(Win32Error));
			info.AddValue("WindowsException_IsNT_STATUS", this.IsNT_STATUS);
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00009639 File Offset: 0x00007839
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x00009641 File Offset: 0x00007841
		public bool IsNT_STATUS { get; private set; }

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0000964A File Offset: 0x0000784A
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x00009652 File Offset: 0x00007852
		public Win32Error ErrorCode { get; private set; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0000965B File Offset: 0x0000785B
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x00009663 File Offset: 0x00007863
		public NtStatus Status { get; private set; }

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0004E39C File Offset: 0x0004C59C
		public override string Message
		{
			get
			{
				if (this.m_sMessage == null)
				{
					if (this.IsNT_STATUS && this.Status != (NtStatus)3221225506U && this.Status != (NtStatus)3221225477U)
					{
						string text = this.Status.smethod_0();
						if (text == null)
						{
							text = string.Format("Could not retrieve the error message (0x{0:x}).", (int)this.Status);
						}
						this.m_sMessage = text;
					}
					else
					{
						this.m_sMessage = this.ErrorCode.smethod_1();
					}
				}
				return this.m_sMessage;
			}
		}

		// Token: 0x040007F0 RID: 2032
		private string m_sMessage;
	}
}
