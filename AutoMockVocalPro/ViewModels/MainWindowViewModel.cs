using System.Collections.ObjectModel;
using System.Windows.Controls;
using AutoMockVocalPro.ViewModels.Items;
using AutoMockVocalPro.Views.Pages;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace AutoMockVocalPro.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _manager;
        private string _title = "Auto Mock Vocal Pro";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableCollection<MainWindowDrawerItemViewModel> DrawerItems { get; set; } =
            new ObservableCollection<MainWindowDrawerItemViewModel>();

        public MainWindowViewModel(IRegionManager manager)
        {
            _manager = manager;

            _manager.RegisterViewWithRegion("MainRegion", typeof(HomeView));

            var drawerItemCommand = new DelegateCommand<string>(s =>
            {
                DrawerHost.CloseDrawerCommand.Execute(Dock.Left, null);

                if (s == "Home")
                {
                    _manager.RegisterViewWithRegion("MainRegion", typeof(HomeView));
                }
            });

            DrawerItems.Add(new MainWindowDrawerItemViewModel
            {
                Name = "Home",
                Command = drawerItemCommand
            });

            for (int i = 0; i < 50; i++)
            {
                DrawerItems.Add(new MainWindowDrawerItemViewModel
                {
                    Name = $"Test {i}",
                    Command = drawerItemCommand
                });
            }

            
        }
    }
}
