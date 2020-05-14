using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TSN.Collections;

namespace ns25
{
	// Token: 0x02000346 RID: 838
	internal sealed class Class322
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x0006D41C File Offset: 0x0006B61C
		static Class322()
		{
			Dictionary<int, Class322> dictionary = new Dictionary<int, Class322>();
			dictionary.Add(2, new Class322("Laff-O-Dil", 2));
			dictionary.Add(3, new Class322("Dandy Pansy", 3));
			dictionary.Add(6, new Class322("What-in Carnation", 6));
			dictionary.Add(7, new Class322("School Daisy", 7));
			dictionary.Add(8, new Class322("Lily-of-the-Alley", 8));
			dictionary.Add(28, new Class322("Daffy Dill", 28));
			dictionary.Add(38, new Class322("Chim Pansy", 38));
			dictionary.Add(67, new Class322("Instant Carnation", 67));
			dictionary.Add(71, new Class322("Lazy Daisy", 71));
			dictionary.Add(82, new Class322("Lily Pad", 82));
			dictionary.Add(111, new Class322("Summer's Last Rose", 111));
			dictionary.Add(311, new Class322("Potsen Pansy", 311));
			dictionary.Add(611, new Class322("Hybrid Carnation", 611));
			dictionary.Add(712, new Class322("Midsummer Daisy", 712));
			dictionary.Add(833, new Class322("Tiger Lily", 833));
			dictionary.Add(1737, new Class322("Corn Rose", 1737));
			dictionary.Add(2677, new Class322("Giraff-O-Dil", 2677));
			dictionary.Add(3771, new Class322("Marzi Pansy", 3771));
			dictionary.Add(7183, new Class322("Freshasa Daisy", 7183));
			dictionary.Add(8336, new Class322("Livered Lily", 8336));
			dictionary.Add(26566, new Class322("Time and a Half-O-Dil", 26566));
			dictionary.Add(41544, new Class322("Onelip", 41544));
			dictionary.Add(61251, new Class322("Side Carnation", 61251));
			dictionary.Add(71333, new Class322("Whoopsie Daisy", 71333));
			dictionary.Add(81111, new Class322("Chili Lily", 81111));
			dictionary.Add(163136, new Class322("Tinted Rose", 163136));
			dictionary.Add(366356, new Class322("Smarty Pansy", 366356));
			dictionary.Add(411144, new Class322("Twolip", 411144));
			dictionary.Add(758455, new Class322("Upsy Daisy", 758455));
			dictionary.Add(814444, new Class322("Silly Lily", 814444));
			dictionary.Add(6222272, new Class322("Model Carnation", 6222272));
			dictionary.Add(7213222, new Class322("Crazy Daisy", 7213222));
			dictionary.Add(8485855, new Class322("Indubitab Lily", 8485855));
			dictionary.Add(5454855, new Class322("Car Petunia", 5454855));
			dictionary.Add(1836488, new Class322("Stinking Rose", 1836488));
			dictionary.Add(75484134, new Class322("Hazy Daisy", 75484134));
			dictionary.Add(85778577, new Class322("Dilly Lily", 85778577));
			dictionary.Add(56651377, new Class322("Platoonia", 56651377));
			dictionary.Add(15445565, new Class322("Istilla Rose", 15445565));
			dictionary.Add(47747347, new Class322("Threelip", 47747347));
			Class322.readOnlyCollection_0 = new ReadOnlyCollection<Class322>(dictionary.Values.ToList<Class322>());
			Class322.readOnlyDictionary_0 = new TSN.Collections.ReadOnlyDictionary<int, Class322>(dictionary);
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0006D814 File Offset: 0x0006BA14
		public int[] Beans
		{
			get
			{
				int[] array = new int[(int)this.CombinationSize];
				int num = this.NumericCombination;
				for (int i = 0; i < (int)this.CombinationSize; i++)
				{
					array[i] = num % 10;
					num /= 10;
				}
				Array.Reverse(array);
				return array;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0000D2B6 File Offset: 0x0000B4B6
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x0000D2BE File Offset: 0x0000B4BE
		public char[] Combination { get; private set; }

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0000D2C7 File Offset: 0x0000B4C7
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0000D2CF File Offset: 0x0000B4CF
		public string PlantName { get; private set; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		public int NumericCombination { get; private set; }

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0000D2E9 File Offset: 0x0000B4E9
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
		public byte CombinationSize { get; private set; }

		// Token: 0x0600207B RID: 8315 RVA: 0x0000D2FA File Offset: 0x0000B4FA
		private Class322(string plantName)
		{
			if (string.IsNullOrEmpty(plantName))
			{
				throw new ArgumentNullException("plantName");
			}
			this.PlantName = plantName;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0006D858 File Offset: 0x0006BA58
		private Class322(string plantName, int combination) : this(plantName)
		{
			string text = combination.ToString();
			if (text.Length > 8)
			{
				throw new ArgumentException("Invalid combination size.");
			}
			this.Combination = text.ToCharArray();
			this.NumericCombination = combination;
			this.CombinationSize = (byte)this.Combination.Length;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0000D31C File Offset: 0x0000B51C
		public override string ToString()
		{
			return string.Format("{0} ({1})", this.PlantName, this.method_0());
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0006D8AC File Offset: 0x0006BAAC
		private string method_0()
		{
			string text = string.Empty;
			int num = this.Combination.Length;
			for (int i = 0; i < num; i++)
			{
				switch (this.Combination[i])
				{
				case '1':
					text += "Red";
					break;
				case '2':
					text += "Green";
					break;
				case '3':
					text += "Orange";
					break;
				case '4':
					text += "Violet";
					break;
				case '5':
					text += "Blue";
					break;
				case '6':
					text += "Pink";
					break;
				case '7':
					text += "Yellow";
					break;
				case '8':
					text += "Cyan";
					break;
				case '9':
					text += "Silver";
					break;
				}
				if (i < num - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		// Token: 0x04000D4E RID: 3406
		public static readonly TSN.Collections.ReadOnlyDictionary<int, Class322> readOnlyDictionary_0;

		// Token: 0x04000D4F RID: 3407
		public static readonly ReadOnlyCollection<Class322> readOnlyCollection_0;

		// Token: 0x04000D50 RID: 3408
		[CompilerGenerated]
		private char[] char_0;

		// Token: 0x04000D51 RID: 3409
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000D52 RID: 3410
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000D53 RID: 3411
		[CompilerGenerated]
		private byte byte_0;
	}
}
