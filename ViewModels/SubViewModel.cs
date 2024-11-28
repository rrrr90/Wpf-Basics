using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Basics.Models;

namespace Wpf_Basics.ViewModels
{
    class SubViewModel : Bases.ViewModelBase, IParameterReceiver
    {
        public SubData SubData { get; set; } = default!;
        public void ReceiveParameter(object parameter)
        {
            if (parameter is SubData subdata)
                SubData = subdata;
        }
    }
}
