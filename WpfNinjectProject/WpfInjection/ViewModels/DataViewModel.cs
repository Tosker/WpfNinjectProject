﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfInjection.Services;
using WpfInjection.Utility;

namespace WpfInjection.ViewModels
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