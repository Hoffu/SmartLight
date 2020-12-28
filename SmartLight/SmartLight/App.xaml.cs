using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartLight.Services;
using SmartLight.Views;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SmartLight
{

    
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
           
            MainPage = new NavigationPage(new ItemsPage());
            MainPage = new NavigationPage(new AboutPage());
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
    
}
