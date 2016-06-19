using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinConverters.Converters
{
    public class BirthdayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime bday = (DateTime)value;
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            return age;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}