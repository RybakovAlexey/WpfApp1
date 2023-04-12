using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.models
{
    internal class ChildControl: UserControl
    {
        public static readonly DependencyProperty PropertyProperty = DependencyProperty.Register(
        nameof(Property), typeof(string), typeof(ChildControl), new PropertyMetadata(default(string)));
        public string Property

        {
            get { return (string)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }



        public ChildControl()
        {
            SetBinding(PropertyProperty, new Binding(nameof(ParentControl.Property)) { Mode = BindingMode.OneWay });
        }

    }
}
