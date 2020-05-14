using System;
using System.ComponentModel;
using System.Globalization;
using TheToonTownSpoofer.Design;

namespace ns29
{
	// Token: 0x020004CB RID: 1227
	internal sealed class Class518 : TypeConverter
	{
		// Token: 0x06002DEE RID: 11758 RVA: 0x0001620D File Offset: 0x0001440D
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				return value.ToString();
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00016234 File Offset: 0x00014434
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(Version) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000B04E4 File Offset: 0x000AE6E4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (string.IsNullOrEmpty(text))
			{
				return new Version(0, 0, 0, 0);
			}
			Version result;
			if (!Version.TryParse(text, out result))
			{
				throw new PropertyException("The specified version is invalid, please use the following format: '##.##.##.##' e.g. '1.0.0.0'.");
			}
			return result;
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00008FBD File Offset: 0x000071BD
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}
	}
}
