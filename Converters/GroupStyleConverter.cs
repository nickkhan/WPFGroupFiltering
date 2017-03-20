using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Globalization;
using System.Windows.Data;
using T5008SlipView.ViewModels;
using System.Windows.Controls;

namespace T5008SlipView.Converters
{
    public class GrossProceedsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var collection = value as ReadOnlyObservableCollection<object>;

            float gross=0;
            foreach (T5008SlipViewModel t5008slip in collection.ToArray())
            {
                gross += float.Parse(t5008slip.Gross, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            return (int)gross;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CostConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var collection = value as ReadOnlyObservableCollection<object>;

            float costs = 0;
            foreach (T5008SlipViewModel t5008slip in collection.ToArray())
            {               
                costs += float.Parse(t5008slip.Cost, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            return costs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ListToTopItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var collection = value as ReadOnlyObservableCollection<object>;
            
            if (collection == null || collection.Count == 0)
                return value;

            return collection.First();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }        
    }
    public class GroupedIssuerSelectConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {

            return values.ToList();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}