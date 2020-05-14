using System;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns11;
using ns12;
using ns13;
using ns14;
using ns3;

namespace ns10
{
	// Token: 0x02000158 RID: 344
	internal sealed class Class24 : AxHost
	{
		// Token: 0x060012DE RID: 4830 RVA: 0x000044F3 File Offset: 0x000026F3
		public Class24() : base("6bf52a52-394a-11d3-b153-00c04f79faa6")
		{
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00004500 File Offset: 0x00002700
		public void vmethod_0(string string_0)
		{
			if (this.ginterface14_0 == null)
			{
				throw new AxHost.InvalidActiveXStateException("URL", AxHost.ActiveXInvokeKind.PropertySet);
			}
			this.ginterface14_0.URL = string_0;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00004522 File Offset: 0x00002722
		public Enum10 vmethod_1()
		{
			if (this.ginterface14_0 == null)
			{
				throw new AxHost.InvalidActiveXStateException("playState", AxHost.ActiveXInvokeKind.PropertyGet);
			}
			return this.ginterface14_0.playState;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00004543 File Offset: 0x00002743
		public GInterface18 vmethod_2()
		{
			if (this.ginterface14_0 == null)
			{
				throw new AxHost.InvalidActiveXStateException("Ctlcontrols", AxHost.ActiveXInvokeKind.PropertyGet);
			}
			return this.ginterface14_0.controls;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00004564 File Offset: 0x00002764
		public GInterface19 vmethod_3()
		{
			if (this.ginterface14_0 == null)
			{
				throw new AxHost.InvalidActiveXStateException("settings", AxHost.ActiveXInvokeKind.PropertyGet);
			}
			return this.ginterface14_0.settings;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00024A44 File Offset: 0x00022C44
		public void method_0(Delegate152 delegate152_1)
		{
			Delegate152 @delegate = this.delegate152_0;
			Delegate152 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate152 value = (Delegate152)Delegate.Combine(delegate2, delegate152_1);
				@delegate = Interlocked.CompareExchange<Delegate152>(ref this.delegate152_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00024A7C File Offset: 0x00022C7C
		protected override void CreateSink()
		{
			try
			{
				this.class79_0 = new Class79(this);
				this.connectionPointCookie_0 = new AxHost.ConnectionPointCookie(this.ginterface14_0, this.class79_0, typeof(GInterface12));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00024ACC File Offset: 0x00022CCC
		protected override void DetachSink()
		{
			try
			{
				this.connectionPointCookie_0.Disconnect();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00024AFC File Offset: 0x00022CFC
		protected override void AttachInterfaces()
		{
			try
			{
				this.ginterface14_0 = (GInterface14)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00004585 File Offset: 0x00002785
		internal void method_1(object object_0, Class25 class25_0)
		{
			if (this.delegate120_0 != null)
			{
				this.delegate120_0(object_0, class25_0);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000459C File Offset: 0x0000279C
		internal void method_2(object object_0, Class26 class26_0)
		{
			if (this.delegate121_0 != null)
			{
				this.delegate121_0(object_0, class26_0);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000045B3 File Offset: 0x000027B3
		internal void method_3(object object_0, Class27 class27_0)
		{
			if (this.delegate122_0 != null)
			{
				this.delegate122_0(object_0, class27_0);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000045CA File Offset: 0x000027CA
		internal void method_4(object object_0, Class28 class28_0)
		{
			if (this.delegate123_0 != null)
			{
				this.delegate123_0(object_0, class28_0);
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000045E1 File Offset: 0x000027E1
		internal void method_5(object object_0, Class29 class29_0)
		{
			if (this.delegate124_0 != null)
			{
				this.delegate124_0(object_0, class29_0);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000045F8 File Offset: 0x000027F8
		internal void method_6(object object_0, Class30 class30_0)
		{
			if (this.delegate125_0 != null)
			{
				this.delegate125_0(object_0, class30_0);
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0000460F File Offset: 0x0000280F
		internal void method_7(object object_0, Class31 class31_0)
		{
			if (this.delegate126_0 != null)
			{
				this.delegate126_0(object_0, class31_0);
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00004626 File Offset: 0x00002826
		internal void method_8(object object_0, Class32 class32_0)
		{
			if (this.delegate127_0 != null)
			{
				this.delegate127_0(object_0, class32_0);
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0000463D File Offset: 0x0000283D
		internal void method_9(object object_0, Class33 class33_0)
		{
			if (this.delegate128_0 != null)
			{
				this.delegate128_0(object_0, class33_0);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00004654 File Offset: 0x00002854
		internal void method_10(object object_0, Class34 class34_0)
		{
			if (this.delegate129_0 != null)
			{
				this.delegate129_0(object_0, class34_0);
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0000466B File Offset: 0x0000286B
		internal void method_11(object object_0, Class35 class35_0)
		{
			if (this.delegate130_0 != null)
			{
				this.delegate130_0(object_0, class35_0);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00004682 File Offset: 0x00002882
		internal void method_12(object object_0, Class36 class36_0)
		{
			if (this.delegate131_0 != null)
			{
				this.delegate131_0(object_0, class36_0);
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00004699 File Offset: 0x00002899
		internal void method_13(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(sender, e);
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000046B0 File Offset: 0x000028B0
		internal void method_14(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(sender, e);
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000046C7 File Offset: 0x000028C7
		internal void method_15(object sender, EventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(sender, e);
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000046DE File Offset: 0x000028DE
		internal void method_16(object sender, EventArgs e)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(sender, e);
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000046F5 File Offset: 0x000028F5
		internal void method_17(object object_0, Class37 class37_0)
		{
			if (this.delegate132_0 != null)
			{
				this.delegate132_0(object_0, class37_0);
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0000470C File Offset: 0x0000290C
		internal void method_18(object object_0, Class38 class38_0)
		{
			if (this.delegate133_0 != null)
			{
				this.delegate133_0(object_0, class38_0);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00004723 File Offset: 0x00002923
		internal void method_19(object object_0, Class39 class39_0)
		{
			if (this.delegate134_0 != null)
			{
				this.delegate134_0(object_0, class39_0);
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000473A File Offset: 0x0000293A
		internal void method_20(object object_0, Class40 class40_0)
		{
			if (this.delegate135_0 != null)
			{
				this.delegate135_0(object_0, class40_0);
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00004751 File Offset: 0x00002951
		internal void method_21(object object_0, Class41 class41_0)
		{
			if (this.delegate136_0 != null)
			{
				this.delegate136_0(object_0, class41_0);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00004768 File Offset: 0x00002968
		internal void method_22(object object_0, Class42 class42_0)
		{
			if (this.delegate137_0 != null)
			{
				this.delegate137_0(object_0, class42_0);
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0000477F File Offset: 0x0000297F
		internal void method_23(object object_0, Class43 class43_0)
		{
			if (this.delegate138_0 != null)
			{
				this.delegate138_0(object_0, class43_0);
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00004796 File Offset: 0x00002996
		internal void method_24(object object_0, Class44 class44_0)
		{
			if (this.delegate139_0 != null)
			{
				this.delegate139_0(object_0, class44_0);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000047AD File Offset: 0x000029AD
		internal void method_25(object object_0, Class45 class45_0)
		{
			if (this.delegate140_0 != null)
			{
				this.delegate140_0(object_0, class45_0);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000047C4 File Offset: 0x000029C4
		internal void method_26(object object_0, Class46 class46_0)
		{
			if (this.delegate141_0 != null)
			{
				this.delegate141_0(object_0, class46_0);
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000047DB File Offset: 0x000029DB
		internal void method_27(object object_0, Class47 class47_0)
		{
			if (this.delegate142_0 != null)
			{
				this.delegate142_0(object_0, class47_0);
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000047F2 File Offset: 0x000029F2
		internal void method_28(object object_0, Class48 class48_0)
		{
			if (this.delegate143_0 != null)
			{
				this.delegate143_0(object_0, class48_0);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00004809 File Offset: 0x00002A09
		internal void method_29(object object_0, Class49 class49_0)
		{
			if (this.delegate144_0 != null)
			{
				this.delegate144_0(object_0, class49_0);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00004820 File Offset: 0x00002A20
		internal void method_30(object object_0, Class50 class50_0)
		{
			if (this.delegate145_0 != null)
			{
				this.delegate145_0(object_0, class50_0);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00004837 File Offset: 0x00002A37
		internal void method_31(object object_0, Class51 class51_0)
		{
			if (this.delegate146_0 != null)
			{
				this.delegate146_0(object_0, class51_0);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0000484E File Offset: 0x00002A4E
		internal void method_32(object object_0, Class52 class52_0)
		{
			if (this.delegate147_0 != null)
			{
				this.delegate147_0(object_0, class52_0);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00004865 File Offset: 0x00002A65
		internal void method_33(object object_0, Class53 class53_0)
		{
			if (this.delegate148_0 != null)
			{
				this.delegate148_0(object_0, class53_0);
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0000487C File Offset: 0x00002A7C
		internal void method_34(object object_0, Class54 class54_0)
		{
			if (this.delegate149_0 != null)
			{
				this.delegate149_0(object_0, class54_0);
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00004893 File Offset: 0x00002A93
		internal void method_35(object object_0, Class55 class55_0)
		{
			if (this.delegate150_0 != null)
			{
				this.delegate150_0(object_0, class55_0);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000048AA File Offset: 0x00002AAA
		internal void method_36(object object_0, Class56 class56_0)
		{
			if (this.delegate151_0 != null)
			{
				this.delegate151_0(object_0, class56_0);
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000048C1 File Offset: 0x00002AC1
		internal void method_37(object object_0, Class57 class57_0)
		{
			if (this.delegate152_0 != null)
			{
				this.delegate152_0(object_0, class57_0);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000048D8 File Offset: 0x00002AD8
		internal void method_38(object object_0, Class58 class58_0)
		{
			if (this.delegate153_0 != null)
			{
				this.delegate153_0(object_0, class58_0);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000048EF File Offset: 0x00002AEF
		internal void method_39(object sender, EventArgs e)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(sender, e);
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00004906 File Offset: 0x00002B06
		internal void method_40(object object_0, Class59 class59_0)
		{
			if (this.delegate154_0 != null)
			{
				this.delegate154_0(object_0, class59_0);
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0000491D File Offset: 0x00002B1D
		internal void method_41(object sender, EventArgs e)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(sender, e);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00004934 File Offset: 0x00002B34
		internal void method_42(object object_0, Class60 class60_0)
		{
			if (this.delegate155_0 != null)
			{
				this.delegate155_0(object_0, class60_0);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0000494B File Offset: 0x00002B4B
		internal void method_43(object object_0, Class61 class61_0)
		{
			if (this.delegate156_0 != null)
			{
				this.delegate156_0(object_0, class61_0);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00004962 File Offset: 0x00002B62
		internal void method_44(object sender, EventArgs e)
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(sender, e);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00004979 File Offset: 0x00002B79
		internal void method_45(object object_0, Class62 class62_0)
		{
			if (this.delegate157_0 != null)
			{
				this.delegate157_0(object_0, class62_0);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00004990 File Offset: 0x00002B90
		internal void method_46(object object_0, Class63 class63_0)
		{
			if (this.delegate158_0 != null)
			{
				this.delegate158_0(object_0, class63_0);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000049A7 File Offset: 0x00002BA7
		internal void method_47(object object_0, Class64 class64_0)
		{
			if (this.delegate159_0 != null)
			{
				this.delegate159_0(object_0, class64_0);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000049BE File Offset: 0x00002BBE
		internal void method_48(object object_0, Class65 class65_0)
		{
			if (this.delegate160_0 != null)
			{
				this.delegate160_0(object_0, class65_0);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000049D5 File Offset: 0x00002BD5
		internal void method_49(object object_0, Class66 class66_0)
		{
			if (this.delegate161_0 != null)
			{
				this.delegate161_0(object_0, class66_0);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000049EC File Offset: 0x00002BEC
		internal void method_50(object object_0, Class67 class67_0)
		{
			if (this.delegate162_0 != null)
			{
				this.delegate162_0(object_0, class67_0);
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00004A03 File Offset: 0x00002C03
		internal void method_51(object object_0, Class68 class68_0)
		{
			if (this.delegate163_0 != null)
			{
				this.delegate163_0(object_0, class68_0);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00004A1A File Offset: 0x00002C1A
		internal void method_52(object object_0, Class69 class69_0)
		{
			if (this.delegate164_0 != null)
			{
				this.delegate164_0(object_0, class69_0);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00004A31 File Offset: 0x00002C31
		internal void method_53(object object_0, Class70 class70_0)
		{
			if (this.delegate165_0 != null)
			{
				this.delegate165_0(object_0, class70_0);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00004A48 File Offset: 0x00002C48
		internal void method_54(object object_0, Class71 class71_0)
		{
			if (this.delegate166_0 != null)
			{
				this.delegate166_0(object_0, class71_0);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00004A5F File Offset: 0x00002C5F
		internal void method_55(object object_0, Class72 class72_0)
		{
			if (this.delegate167_0 != null)
			{
				this.delegate167_0(object_0, class72_0);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00004A76 File Offset: 0x00002C76
		internal void method_56(object object_0, Class73 class73_0)
		{
			if (this.delegate168_0 != null)
			{
				this.delegate168_0(object_0, class73_0);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00004A8D File Offset: 0x00002C8D
		internal void method_57(object sender, EventArgs e)
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(sender, e);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00004AA4 File Offset: 0x00002CA4
		internal void method_58(object object_0, Class74 class74_0)
		{
			if (this.delegate169_0 != null)
			{
				this.delegate169_0(object_0, class74_0);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00004ABB File Offset: 0x00002CBB
		internal void method_59(object object_0, Class75 class75_0)
		{
			if (this.delegate170_0 != null)
			{
				this.delegate170_0(object_0, class75_0);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00004AD2 File Offset: 0x00002CD2
		internal void method_60(object object_0, Class76 class76_0)
		{
			if (this.delegate171_0 != null)
			{
				this.delegate171_0(object_0, class76_0);
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00004AE9 File Offset: 0x00002CE9
		internal void method_61(object sender, EventArgs e)
		{
			if (this.eventHandler_8 != null)
			{
				this.eventHandler_8(sender, e);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00004B00 File Offset: 0x00002D00
		internal void method_62(object object_0, Class77 class77_0)
		{
			if (this.delegate172_0 != null)
			{
				this.delegate172_0(object_0, class77_0);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00004B17 File Offset: 0x00002D17
		internal void method_63(object object_0, Class78 class78_0)
		{
			if (this.delegate173_0 != null)
			{
				this.delegate173_0(object_0, class78_0);
			}
		}

		// Token: 0x04000159 RID: 345
		private GInterface14 ginterface14_0;

		// Token: 0x0400015A RID: 346
		private Class79 class79_0;

		// Token: 0x0400015B RID: 347
		private AxHost.ConnectionPointCookie connectionPointCookie_0;

		// Token: 0x0400015C RID: 348
		private Delegate120 delegate120_0;

		// Token: 0x0400015D RID: 349
		private Delegate121 delegate121_0;

		// Token: 0x0400015E RID: 350
		private Delegate122 delegate122_0;

		// Token: 0x0400015F RID: 351
		private Delegate123 delegate123_0;

		// Token: 0x04000160 RID: 352
		private Delegate124 delegate124_0;

		// Token: 0x04000161 RID: 353
		private Delegate125 delegate125_0;

		// Token: 0x04000162 RID: 354
		private Delegate126 delegate126_0;

		// Token: 0x04000163 RID: 355
		private Delegate127 delegate127_0;

		// Token: 0x04000164 RID: 356
		private Delegate128 delegate128_0;

		// Token: 0x04000165 RID: 357
		private Delegate129 delegate129_0;

		// Token: 0x04000166 RID: 358
		private Delegate130 delegate130_0;

		// Token: 0x04000167 RID: 359
		private Delegate131 delegate131_0;

		// Token: 0x04000168 RID: 360
		private EventHandler eventHandler_0;

		// Token: 0x04000169 RID: 361
		private EventHandler eventHandler_1;

		// Token: 0x0400016A RID: 362
		private EventHandler eventHandler_2;

		// Token: 0x0400016B RID: 363
		private EventHandler eventHandler_3;

		// Token: 0x0400016C RID: 364
		private Delegate132 delegate132_0;

		// Token: 0x0400016D RID: 365
		private Delegate133 delegate133_0;

		// Token: 0x0400016E RID: 366
		private Delegate134 delegate134_0;

		// Token: 0x0400016F RID: 367
		private Delegate135 delegate135_0;

		// Token: 0x04000170 RID: 368
		private Delegate136 delegate136_0;

		// Token: 0x04000171 RID: 369
		private Delegate137 delegate137_0;

		// Token: 0x04000172 RID: 370
		private Delegate138 delegate138_0;

		// Token: 0x04000173 RID: 371
		private Delegate139 delegate139_0;

		// Token: 0x04000174 RID: 372
		private Delegate140 delegate140_0;

		// Token: 0x04000175 RID: 373
		private Delegate141 delegate141_0;

		// Token: 0x04000176 RID: 374
		private Delegate142 delegate142_0;

		// Token: 0x04000177 RID: 375
		private Delegate143 delegate143_0;

		// Token: 0x04000178 RID: 376
		private Delegate144 delegate144_0;

		// Token: 0x04000179 RID: 377
		private Delegate145 delegate145_0;

		// Token: 0x0400017A RID: 378
		private Delegate146 delegate146_0;

		// Token: 0x0400017B RID: 379
		private Delegate147 delegate147_0;

		// Token: 0x0400017C RID: 380
		private Delegate148 delegate148_0;

		// Token: 0x0400017D RID: 381
		private Delegate149 delegate149_0;

		// Token: 0x0400017E RID: 382
		private Delegate150 delegate150_0;

		// Token: 0x0400017F RID: 383
		private Delegate151 delegate151_0;

		// Token: 0x04000180 RID: 384
		private Delegate152 delegate152_0;

		// Token: 0x04000181 RID: 385
		private Delegate153 delegate153_0;

		// Token: 0x04000182 RID: 386
		private EventHandler eventHandler_4;

		// Token: 0x04000183 RID: 387
		private Delegate154 delegate154_0;

		// Token: 0x04000184 RID: 388
		private EventHandler eventHandler_5;

		// Token: 0x04000185 RID: 389
		private Delegate155 delegate155_0;

		// Token: 0x04000186 RID: 390
		private Delegate156 delegate156_0;

		// Token: 0x04000187 RID: 391
		private EventHandler eventHandler_6;

		// Token: 0x04000188 RID: 392
		private Delegate157 delegate157_0;

		// Token: 0x04000189 RID: 393
		private Delegate158 delegate158_0;

		// Token: 0x0400018A RID: 394
		private Delegate159 delegate159_0;

		// Token: 0x0400018B RID: 395
		private Delegate160 delegate160_0;

		// Token: 0x0400018C RID: 396
		private Delegate161 delegate161_0;

		// Token: 0x0400018D RID: 397
		private Delegate162 delegate162_0;

		// Token: 0x0400018E RID: 398
		private Delegate163 delegate163_0;

		// Token: 0x0400018F RID: 399
		private Delegate164 delegate164_0;

		// Token: 0x04000190 RID: 400
		private Delegate165 delegate165_0;

		// Token: 0x04000191 RID: 401
		private Delegate166 delegate166_0;

		// Token: 0x04000192 RID: 402
		private Delegate167 delegate167_0;

		// Token: 0x04000193 RID: 403
		private Delegate168 delegate168_0;

		// Token: 0x04000194 RID: 404
		private EventHandler eventHandler_7;

		// Token: 0x04000195 RID: 405
		private Delegate169 delegate169_0;

		// Token: 0x04000196 RID: 406
		private Delegate170 delegate170_0;

		// Token: 0x04000197 RID: 407
		private Delegate171 delegate171_0;

		// Token: 0x04000198 RID: 408
		private EventHandler eventHandler_8;

		// Token: 0x04000199 RID: 409
		private Delegate172 delegate172_0;

		// Token: 0x0400019A RID: 410
		private Delegate173 delegate173_0;
	}
}
