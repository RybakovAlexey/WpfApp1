using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.models
{
    internal class ParentControl: UserControl, INotifyPropertyChanged
    {
        private string _property;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Property
        {
            get { return _property; }
            set
            {
                _property = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Property)));
            }
        }
        public ParentControl()
        {

            DataContext = this;
        }
    }
}
