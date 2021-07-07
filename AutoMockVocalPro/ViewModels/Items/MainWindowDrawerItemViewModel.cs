using Prism.Commands;
using Prism.Mvvm;

namespace AutoMockVocalPro.ViewModels.Items
{
    public class MainWindowDrawerItemViewModel : BindableBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public DelegateCommand<string> Command { get; set; }
    }
}