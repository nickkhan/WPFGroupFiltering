using System;
using System.Globalization;
using System.Windows.Data;
using Intuit.PCG.Accelerators.ServiceContainer;
using Intuit.PCG.Accelerators.Services;

namespace Intuit.PCG.ProFile.DataImport.CRA.Converters
{
    public class BooleanToSuccessConverter : IValueConverter
    {
        private const string CRAImportSuccessKey = "CRAImportSuccessKey";
        private const string CRAImportFailureKey = "CRAImportFailureKey";
        private readonly ILanguageService languageService;

        public BooleanToSuccessConverter()
        {
            languageService = ServiceContainer.Resolve<ILanguageService>();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isError = (bool) value;
            if (isError) return languageService.GetDisplayString(CRAImportFailureKey);
            return languageService.GetDisplayString(CRAImportSuccessKey);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}