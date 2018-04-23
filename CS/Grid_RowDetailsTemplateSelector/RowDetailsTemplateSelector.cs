using DevExpress.Xpf.Grid;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Grid_RowDetailsTemplateSelector
{
    class RowDetailsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PrimaryRowDetailsTemplate { get; set; }
        public DataTemplate SecondaryRowDetailsTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            RowData row = item as RowData;
            if (row != null) {
                Person person = row.Row as Person;
                if (person != null)
                    return person.Address.Contains("London") ? PrimaryRowDetailsTemplate : SecondaryRowDetailsTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
