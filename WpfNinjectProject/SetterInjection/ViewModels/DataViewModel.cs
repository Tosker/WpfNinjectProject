using Ninject;
using SetterInjection.Services;
using SetterInjection.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SetterInjection.ViewModels
{
    public class DataViewModel : ObservableObject
    {
        public IDataService _dataService;

        private ObservableCollection<string> _dataCollection;
        public ObservableCollection<string> DataCollection
        {
            get { return _dataCollection; }
            set { OnPropertyChanged(ref _dataCollection, value); }
        }

        public ICommand LoadDataCommand { get; private set; }

        public DataViewModel()
        {
            LoadDataCommand = new RelayCommand<object>(LoadData);
        }

        [Inject]
        public void SetDataService(IDataService dataService)
        {
            _dataService = dataService;
        }

        private void LoadData(object obj)
        {
            var data = _dataService.Load();
            DataCollection = new ObservableCollection<string>(data);
        }
    }
}
