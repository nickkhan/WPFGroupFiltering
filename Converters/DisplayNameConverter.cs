using System;
using System.Globalization;
using System.Windows.Data;
using Intuit.PCG.Accelerators.ServiceContainer;
using Intuit.PCG.Accelerators.Services;
using Intuit.PCG.ProFile.DataImport.CRA.Model;

namespace Intuit.PCG.ProFile.DataImport.CRA.Converters
{
    public class DisplayNameConverter : IValueConverter
    {
        private const string CRAImportNoNameSelected = "CRAImportNoNameSelected";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var clientMetadata = value as ClientMetadata;
            if (clientMetadata != null)
            {
                if (!String.IsNullOrEmpty(clientMetadata.FirstName) && !String.IsNullOrEmpty(clientMetadata.LastName))
                {
                    return String.Format("{0}, {1}", clientMetadata.LastName, clientMetadata.FirstName);
                }
                else if (!String.IsNullOrEmpty(clientMetadata.FirstName))
                {
                    return clientMetadata.FirstName;
                }
                else if (!String.IsNullOrEmpty(clientMetadata.LastName))
                {
                    return clientMetadata.LastName;
                }
            }

            var languageService = ServiceContainer.Resolve<ILanguageService>();
            return languageService.GetDisplayString(CRAImportNoNameSelected);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}