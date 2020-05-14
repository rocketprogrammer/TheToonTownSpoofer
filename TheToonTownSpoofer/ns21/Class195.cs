using System;
using System.ComponentModel;
using System.Globalization;
using ns20;
using TheToonTownSpoofer.Design;

namespace ns21
{
	// Token: 0x02000255 RID: 597
	internal sealed class Class195 : TypeConverter
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x00008F60 File Offset: 0x00007160
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!(destinationType == typeof(string)))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			if (Struct43.smethod_5((Struct43)value, Struct43.struct43_0))
			{
				return Class195.string_0;
			}
			return value.ToString();
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00008F9F File Offset: 0x0000719F
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(Struct43) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000475B8 File Offset: 0x000457B8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (string.IsNullOrEmpty(text) || text == Class195.string_0)
			{
				return Struct43.struct43_0;
			}
			if (text.smethod_13())
			{
				return new Struct43(text);
			}
			throw new PropertyException("The specified hash is invalid, please use the following format: 'abcd-ef12-3456-7890-abcd-ef12-3456-7890' or 'abcdef1234567890abcdef1234567890'.");
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00008FBD File Offset: 0x000071BD
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x0400074A RID: 1866
		private static readonly string string_0 = "Empty";
	}
}
