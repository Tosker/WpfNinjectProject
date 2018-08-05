using Ninject.Modules;
using WpfInjection.Services;

namespace WpfInjection.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDialogService>().To<DialogService>();
            Bind<IDataService>().To<DataService>();
        }
    }
}