//using System;
//using System.Collections.ObjectModel;
//using System.Globalization;
//using System.Linq;
//using System.Windows.Data;
//using Intuit.PCG.ProFile.DataImport.CRA.UserInterface.Model;

//namespace Intuit.PCG.ProFile.DataImport.CRA.Converters
//{
//    public class ItemsToSelectedItemConverter : IValueConverter
//    {
//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            var client = (value as ClientDataViewModel);
//            var selectedGroup = parameter as String;
//            var items = client.GovernmentSlips.Where(s => s.Type == selectedGroup).Select(s=>s as ISelectable).ToList();
//            items.AddRange(client.TuitionSlips.Where(s => s.Type == selectedGroup).Select(s => s as ISelectable).ToList());
//            if (items != null)
//            {
//                if (items.Select(i => i as ISelectable)
//                    .All(i => i.IsSelected))
//                {
//                    return true;
//                }
//                if (items.Select(i => i as ISelectable)
//                    .All(i => i.IsSelected))
//                {
//                    return null;
//                }
//                return false;
//            }
//            return false;
//        }

//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}