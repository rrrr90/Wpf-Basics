using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf_Basics.Models;

namespace Wpf_Basics.Services
{
    public interface IViewService
    {
        void ShowView<TView, TViewModel>(object? parameter = null)
            where TView : Window
            where TViewModel : INotifyPropertyChanged;

        void ShowView();

        void ShowSubView(SubData subdata);
    }
}
