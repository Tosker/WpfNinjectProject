using SetterInjection.Utility;

namespace SetterInjection.ViewModels
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