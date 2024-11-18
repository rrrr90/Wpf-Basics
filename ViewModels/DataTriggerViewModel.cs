using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Basics.ViewModels
{
    class DataTriggerViewModel : Bases.ViewModelBase
    {
        private string textProperty = "";
        public string TextProperty
        {
            get { return textProperty; }
            set { SetProperty(ref textProperty, value); }
        }
        public DataTriggerViewModel() { }
    }
}
