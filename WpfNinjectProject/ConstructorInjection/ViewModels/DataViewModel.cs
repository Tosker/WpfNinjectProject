using ConstructorInjection.Services;
using ConstructorInjection.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConstructorInjection.ViewModels
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

        public DataViewModel(IDataService dataService)
        {
            _dataService = dataService;
            LoadDataCommand = new RelayCommand<object>(LoadData);
        }

        private void LoadData(object obj)
        {
            var data = _dataService.Load();
            DataCollection = new ObservableCollection<string>(data);
        }
    }
}
