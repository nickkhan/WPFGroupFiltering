using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Globalization;
using System.Windows.Data;
using T5008SlipView.ViewModels;

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
                gross += float.Parse(t5008slip.Gross);
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
                costs += float.Parse(t5008slip.Cost);
            }

            return (int)costs;
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

            if (collection.Count > 1)
            {
                List<object> col = new List<object>();
                col.Add(collection.First());

                return col.AsEnumerable<object>() ;
            }
            else
            {
                List<object> col = new List<object>();
                col.Add(collection.First());
                return col.AsEnumerable<object>();
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}