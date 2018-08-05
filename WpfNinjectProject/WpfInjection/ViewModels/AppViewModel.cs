using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInjection.Utility;

namespace WpfInjection.ViewModels
{
    public class AppViewModel : ObservableObject
    {
        private DataViewModel _dataVM;

        private object _current;
        public object Current
        {
            get { return _current; }
            set { OnPropertyChanged(ref _current, value); }
        }

        public AppViewModel(DataViewModel dataVM)
        {
            _dataVM = dataVM;
            Current = _dataVM;
        }

    }
}
