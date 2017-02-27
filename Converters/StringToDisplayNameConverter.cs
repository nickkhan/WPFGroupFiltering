using System;
using System.Globalization;
using System.Windows.Data;
using Intuit.PCG.Accelerators.ServiceContainer;
using Intuit.PCG.Accelerators.Services;
using System.Resources;

namespace T5008SlipView.Converters
{
    public class StringToDisplayNameConverter : IValueConverter
    {
        private const string CRAImportNoNameSelected = "CRAImportNoNameSelected";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return StringResources.ResourceManager.GetString(CRAImportNoNameSelected);
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}