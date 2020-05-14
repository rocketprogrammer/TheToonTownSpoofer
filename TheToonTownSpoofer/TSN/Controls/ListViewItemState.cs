using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TSN.Controls
{
	// Token: 0x020004C4 RID: 1220
	[Serializable]
	public sealed class ListViewItemState<T> : ListViewItem
	{
		// Token: 0x06002DC1 RID: 11713 RVA: 0x00015F88 File Offset: 0x00014188
		public ListViewItemState(T state)
		{
			this.State = state;
			base.Text = state.ToString();
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00015FAA File Offset: 0x000141AA
		public ListViewItemState(T state, string text)
		{
			this.State = state;
			base.Text = text;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00015FC0 File Offset: 0x000141C0
		private ListViewItemState(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.State = (T)((object)info.GetValue("ListViewItemState_State", typeof(T)));
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00015FEA File Offset: 0x000141EA
		protected override void Serialize(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ListViewItemState_State", this.State);
			base.Serialize(info, context);
		}

		// Token: 0x0400180A RID: 6154
		public readonly T State;
	}
}
