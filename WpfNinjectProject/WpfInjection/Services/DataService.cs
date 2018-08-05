using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfInjection.Services
{
    public class DataService : IDataService
    {
        private IDialogService _dialogService;

        public DataService(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public string[] Load()
        {
            var data = new string[]
            {
                "[DATA 1]",
                "[DATA 2]",
                "[DATA 3]"
            };

            _dialogService.ShowMessage("Data has been loaded!");
            return data;
        }
    }
}
