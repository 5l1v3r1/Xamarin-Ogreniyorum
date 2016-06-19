using System;
using System.Globalization;
using Xamarin.Forms;
using XamarinConverters.Models;

namespace XamarinConverters.Converters
{
    public class GenderConverter : IValueConverter
    {
        public Color Male { get; set; }
        public Color Female { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Gender gender = (Gender)value;
            return gender == Gender.Male ? Male : Female;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}