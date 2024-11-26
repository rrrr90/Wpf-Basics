using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Basics.Models;
using Wpf_Basics.Services;

namespace Wpf_Basics.ViewModels
{
    internal class MainViewModel: Bases.ViewModelBase
    {
        private readonly IViewService _viewService;

        public StudentSheetViewModel StudentSheetViewModel { get; set; }
        public ControlTemplateViewModel ControlTemplateViewModel { get; set; }
        public PropertyTriggerViewModel PropertyTriggerViewModel { get; set; }
        public EventTriggerViewModel EventTriggerViewModel { get; set; }
        public DataTriggerViewModel DataTriggerViewModel { get; set; }
        public AccessKeyViewModel AccessKeyViewModel { get; set; }
        public RichTextBoxViewModel RichTextBoxViewModel { get; set; }
        public AttachedPropertyViewModel AttachedPropertyViewModel { get; set; }
        public UserControlViewModel UserControlViewModel { get; set; }

        private string _data1 = string.Empty;
        private string _data2 = string.Empty;
        public string Data1
        {
            get => _data1;
            set
            {
                SetProperty(ref _data1, value);
            }
        }
        public string Data2
        {
            get => _data2;
            set
            {
                SetProperty(ref _data2, value);
            }
        }

        public MainViewModel(IViewService viewService)
        {
            StudentSheetViewModel = new StudentSheetViewModel();
            ControlTemplateViewModel = new ControlTemplateViewModel();
            PropertyTriggerViewModel = new PropertyTriggerViewModel();
            EventTriggerViewModel = new EventTriggerViewModel();
            DataTriggerViewModel = new DataTriggerViewModel();
            AccessKeyViewModel = new AccessKeyViewModel();
            RichTextBoxViewModel = new RichTextBoxViewModel();
            AttachedPropertyViewModel = new AttachedPropertyViewModel();
            UserControlViewModel = new UserControlViewModel();
            _viewService = viewService;
        }

        public ICommand ShowSubWindowCommand => new RelayCommand<object>(ShowSubWindow);

        private void ShowSubWindow(object? obj)
        {
            _viewService.ShowSubView(new SubData() { Data1 = _data1, Data2 = _data2 });
        }
    }
}
