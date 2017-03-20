using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using T5008SlipView.ViewModels;

namespace T5008SlipView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            this.DataContext = new DesignModel_GroupByIssuer();
            InitializeComponent();
        }


        private void ListView_PreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (((e.OriginalSource as FrameworkElement).TemplatedParent as ToggleButton) != null || ((e.OriginalSource as FrameworkElement).DataContext as T5008SlipViewModel)==null)
            {
                return;
            }

            var cvg = ((sender as ListView).DataContext) as CollectionViewGroup;
            var elem = this as MainWindow;
            
            var lv = FindChild<ListView>(elem, "T5008ListView");            
            var cc = FindChild<Expander>(lv, "RootExpanderGroupStyle");
            
            var groupExpander = FindChildByGroup<Expander>(cc, cvg.Name.ToString());
            if (groupExpander != null)
            {
                groupExpander.IsExpanded = !groupExpander.IsExpanded;
            }

        }
      
        public static T FindChild<T>(DependencyObject parent) where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

        public static T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

        public static T FindChild<T>(DependencyObject parent, string childName, string groupName) where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName, groupName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        if ((frameworkElement.DataContext as CollectionViewGroup) != null && (frameworkElement.DataContext as CollectionViewGroup).Name.ToString() == groupName)
                        {
                            // if the child's name is of the request name
                            foundChild = (T)child;
                            break;
                        }

                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

        public static T FindChildByGroup<T>(DependencyObject parent, string groupName) where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChildByGroup<T>(child, groupName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(groupName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null )
                    {
                        if ((frameworkElement.DataContext as CollectionViewGroup) != null && (frameworkElement.DataContext as CollectionViewGroup).Name.ToString() == groupName)
                        {
                            // if the child's name is of the request name
                            foundChild = (T)child;
                            break;
                        }

                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

    }

    public class GroupStyleSelector : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            return base.SelectStyle(item, container);
        }
    }

    public class T5008GroupContainerStyleSelector : GroupStyleSelector
    {
        public Style RootGroupStyle { get; set; }
        public Style SingleIssuerGroupStyle { get; set; }

        public Style MultipleIssuerGroupStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var cvg = item as CollectionViewGroup;
            if (cvg == null)
            {
                return base.SelectStyle(item, container);
            }
            if(!cvg.IsBottomLevel)
            {
                return RootGroupStyle;
            }
            if(cvg.Items.Count > 1)
                return MultipleIssuerGroupStyle ;
            else
                return SingleIssuerGroupStyle;
            
        }

    }  

}
