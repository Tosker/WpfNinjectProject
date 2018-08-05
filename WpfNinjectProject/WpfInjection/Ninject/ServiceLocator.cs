using Ninject;
using WpfInjection.ViewModels;

namespace WpfInjection.Ninject
{
    public class ServiceLocator
    {
        private readonly IKernel kernel;

        public ServiceLocator()
        {
            kernel = new StandardKernel(new ServiceModule());
        }

        public AppViewModel AppViewModel
        {
            get { return kernel.Get<AppViewModel>(); }
        }
    }
}