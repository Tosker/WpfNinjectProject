using Ninject;

namespace SetterInjection.Services
{
    public class DataService : IDataService
    {
        private IDialogService _dialogService;

        [Inject]
        public void SetDialogService(IDialogService dialogService)
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