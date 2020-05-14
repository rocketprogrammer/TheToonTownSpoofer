using System;
using System.ComponentModel;
using System.Globalization;

namespace ns24
{
	// Token: 0x0200032C RID: 812
	internal sealed class Class312 : TypeConverter
	{
		// Token: 0x06001FBA RID: 8122 RVA: 0x0000CBAF File Offset: 0x0000ADAF
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				return "";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return !(sourceType == typeof(string)) && base.CanConvertFrom(context, sourceType);
		}
	}
}
