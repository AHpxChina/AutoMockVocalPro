using System;
using AutoMockVocalPro.Views;
using Prism.Ioc;
using System.Windows;
using Microsoft.Extensions.Configuration;

namespace AutoMockVocalPro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("secrets.json")
                .AddUserSecrets<App>()
                .Build();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
