using System;
using ns25;

namespace ns29
{
	// Token: 0x020004D9 RID: 1241
	internal static class Class526
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x000B0C80 File Offset: 0x000AEE80
		public static string smethod_0(this Enum68 type, bool allowAlphaToJPG)
		{
			switch (type)
			{
			case Enum68.const_1:
				return "JPG Images|*.jpg";
			case Enum68.const_2:
				if (allowAlphaToJPG)
				{
					return "RGB (SGI) Images|*.rgb|JPG Images|*.jpg|PNG Images|*.png";
				}
				return "RGB (SGI) Images|*.rgb";
			case Enum68.const_3:
				return "WAVE Files|*.wav";
			case Enum68.const_4:
				return "MP3 Files|*.mp3";
			case Enum68.const_5:
				return "MIDI Files|*.mid";
			default:
				return string.Empty;
			}
		}
	}
}
