using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
