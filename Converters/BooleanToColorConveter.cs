using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Intuit.PCG.ProFile.DataImport.CRA.Converters
{
    public class BooleanToColorConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isError = (bool) value;
            if (isError)
                return new SolidColorBrush(Color.FromRgb(255, 173, 0));
            return new SolidColorBrush(Color.FromRgb(44, 160, 28));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}