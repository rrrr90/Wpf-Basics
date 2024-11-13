using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Basics.Models;

namespace Wpf_Basics.ViewModels
{
    internal class MainViewModel: Bases.ViewModelBase
    {
        public StudentSheetViewModel StudentSheetViewModel { get; set; }

        public MainViewModel()
        {
            StudentSheetViewModel = new StudentSheetViewModel();
        }
    }
}
