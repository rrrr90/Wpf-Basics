using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Basics.ViewModels
{
    class DataTriggerViewModel : Bases.ViewModelBase
    {
        public string TextProperty { get; set; } = default!;
        public DataTriggerViewModel() { }
    }
}
