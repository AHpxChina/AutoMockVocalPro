using System;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;

namespace AutoMockVocalPro.ViewModels.Pages
{
    public class HomeViewModel : BindableBase
    {
        public DelegateCommand<Uri> NavigateToTTS { get; set; }

        public HomeViewModel()
        {
            NavigateToTTS = new DelegateCommand<Uri>(s =>
            {
                Process.Start("explorer.exe", s.ToString());
            });
        }
    }
}