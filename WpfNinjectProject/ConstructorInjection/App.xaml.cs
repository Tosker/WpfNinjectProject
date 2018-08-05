using ConstructorInjection.Services;
using ConstructorInjection.ViewModels;
using Ninject;
using System.Windows;

namespace ConstructorInjection
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

            //--------------------------------------OPTION 1--------------------------------------
            //var dialogService = new DialogService();
            //var dataService = new DataService(dialogService);
            //var dataVM = new DataViewModel(dataService);
            //var appVM = new AppViewModel(dataVM);
            //
            //MainWindow = new MainWindow();
            //MainWindow.DataContext = appVM;
            //MainWindow.Show();
            //------------------------------------------------------------------------------------

            //--------------------------------------OPTION 2--------------------------------------
            //MainWindow = new MainWindow();
            //MainWindow.DataContext = new AppViewModel(new DataViewModel(new DataService(new DialogService())));
            //MainWindow.Show();
            //------------------------------------------------------------------------------------
        }
    }
}