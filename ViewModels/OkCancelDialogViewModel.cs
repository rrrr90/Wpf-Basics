using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Wpf_Basics.ViewModels
{
    internal class OkCancelDialogViewModel : Bases.ViewModelBase
    {
        public OkCancelDialogViewModel() { }

        public ICommand OkCommand => new RelayCommand<Window>(Ok);
        private void Ok(Window? window)
        {
            window.DialogResult = true;
        }
    }
}
