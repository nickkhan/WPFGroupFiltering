using System;
using System.Globalization;
using System.Windows.Data;

namespace Intuit.PCG.ProFile.DataImport.CRA.Converters
{
    public class LineItemToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value.ToString()))
                return string.Empty;

            var lineitem = String.Format("{0:#.00}", value, CultureInfo.CurrentCulture);
            return lineitem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}