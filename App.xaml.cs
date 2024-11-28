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
        private readonly ServiceProvider _services;

        private static ServiceProvider ConfigurationService()
        {
            IServiceCollection services = new ServiceCollection();
            // Views
            services.AddSingleton<MainWindow>();
            services.AddTransient<SubWindow>();

            // Serivces
            services.AddSingleton<IViewService, ViewService>();

            // ViewModels
            services.AddSingleton<ViewModels.MainViewModel>();
            services.AddTransient<ViewModels.SubViewModel>();

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
            viewService?.ShowView();
        }
    }

}
