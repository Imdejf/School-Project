using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using SzkolnyProjekt.State.Background;
using SzkolnyProjekt.State.Navigator;
using SzkolnyProjekt.ViewModels;
using SzkolnyProjekt.ViewModels.Factories;

namespace SzkolnyProjekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            
            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<ToDoViewModelFactory>();
            services.AddSingleton<IToDoViewModelFactory, ToDoViewModelFactory>();
            #region Views
            services.AddSingleton<ToDoViewModel>();
            services.AddSingleton<CreateViewModel<ToDoViewModel>>(services =>
           {
               return () => services.GetRequiredService<ToDoViewModel>();
           });



            #endregion
            services.AddSingleton<INavigator, Navigator>();
            services.AddSingleton<IBackground, Background>();
            services.AddScoped<MainViewModel>();
            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();
        }
    }
}
