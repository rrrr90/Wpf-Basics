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
        public ControlTemplateViewModel ControlTemplateViewModel { get; set; }
        public PropertyTriggerViewModel PropertyTriggerViewModel { get; set; }
        public EventTriggerViewModel EventTriggerViewModel { get; set; }
        public DataTriggerViewModel DataTriggerViewModel { get; set; }
        public AccessKeyViewModel AccessKeyViewModel { get; set; }

        public MainViewModel()
        {
            StudentSheetViewModel = new StudentSheetViewModel();
            ControlTemplateViewModel = new ControlTemplateViewModel();
            PropertyTriggerViewModel = new PropertyTriggerViewModel();
            EventTriggerViewModel = new EventTriggerViewModel();
            DataTriggerViewModel = new DataTriggerViewModel();
            AccessKeyViewModel = new AccessKeyViewModel();
        }
    }
}
