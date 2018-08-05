using Ninject;
using SetterInjection.Services;
using SetterInjection.ViewModels;
using System.Windows;

namespace SetterInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDialogService>().To<DialogService>();
            kernel.Bind<IDataService>().To<DataService>();

            var appVM = kernel.Get<AppViewModel>();

            MainWindow = new MainWindow();
            MainWindow.DataContext = appVM;
            MainWindow.Show();
        }
    }
}