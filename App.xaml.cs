using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using Wpf_Basics.Services;

namespace Wpf_Basics
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _services = default!;

        private IServiceProvider ConfigurationService()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<IViewService, ViewService>();
            services.AddSingleton<ViewModels.MainViewModel>();
            return services.BuildServiceProvider();
        }

        public App()
        {
            _services = ConfigurationService();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewService = (IViewService?)_services.GetService(typeof(IViewService));
            viewService.ShowView();
        }
    }

}
