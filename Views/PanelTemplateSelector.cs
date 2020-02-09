using PathfinderBuissness.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PathfinderBuissness.Views
{
    class PanelTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
        {

            return item switch
            {
                BuildingVM _ => Application.Current.FindResource("BulidingTemplate") as DataTemplate,
                _ => null
            };
        }
    }
}
