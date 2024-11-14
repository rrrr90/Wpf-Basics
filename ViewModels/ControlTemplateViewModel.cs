using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Basics.Models;

namespace Wpf_Basics.ViewModels
{
    class ControlTemplateViewModel : Bases.ViewModelBase
    {
        public List<ComboItem> Items { get; set; }
        public ControlTemplateViewModel()
        {
            this.Items = ComboItem.Items;
        }
    }
}
