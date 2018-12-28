using System;
using System.Globalization;
using Xamarin.Forms;

namespace STOCI.App
{
    public class AddressToTextConverter:IValueConverter
    {
      

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var address = (Address)value;
            return $"{address.Street} \n{address.City} {address.State} {address.Zip}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
