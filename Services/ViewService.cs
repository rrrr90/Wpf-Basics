using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf_Basics.Models;
using Wpf_Basics.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Wpf_Basics.Services
{
    public class ViewService(IServiceProvider serviceProvider) : IViewService
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public void ShowView<TView, TViewModel>(object? parameter = null)
            where TView : Window
            where TViewModel : INotifyPropertyChanged
        {
            var viewModel = (INotifyPropertyChanged?)_serviceProvider.GetService(typeof(TViewModel));
            var view = (Window?)_serviceProvider.GetService(typeof(TView))!;

            if(parameter != null && viewModel is IParameterReceiver parameterReceiver)
            {
                parameterReceiver.ReceiveParameter(parameter);
            }

            view.DataContext = viewModel;
            view.Show();
        }

        public void ShowView()
        {
            ShowView<MainWindow, MainViewModel>();
        }

        public void ShowSubView(SubData subdata)
        {
            if (!ActivateWindow<SubWindow>())
            {
                ShowView<SubWindow, SubViewModel>(subdata);
            }
        }

        private bool ActivateWindow<TView>()
            where TView : Window
        {
            var subWindows = Application.Current.Windows.OfType<TView>();
            if (subWindows.Any())
            {
                subWindows.ElementAt(0).Activate();
                return true;
            }
            return false;
        }
    }
}
