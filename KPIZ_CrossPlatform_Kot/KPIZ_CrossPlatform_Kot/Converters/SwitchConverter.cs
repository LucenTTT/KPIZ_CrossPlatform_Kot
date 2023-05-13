using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace KPIZ_CrossPlatform_Kot.Converters
{
    [ContentProperty("Cases")]
    public class SwitchConverter : IValueConverter
    {
        public SwitchConverter()
        {
            Cases = new List<SwitchConverterCase>();
        }

        public List<SwitchConverterCase> Cases { get; set; }
        public object Default { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Cases != null)
            {
                foreach (var switchConverterCase in Cases)
                {
                    if (Equals(value, switchConverterCase.When))
                    {
                        if (switchConverterCase != null) return switchConverterCase.Then;
                    }
                }
            }
            return Default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    [ContentProperty("Then")]
    public sealed class SwitchConverterCase
    {
        public object When { get; set; }
        public object Then { get; set; }
        public SwitchConverterCase()
        {
        }

        public SwitchConverterCase(object when, object then)
        {
            When = when;
            Then = then;
        }
    }
}
