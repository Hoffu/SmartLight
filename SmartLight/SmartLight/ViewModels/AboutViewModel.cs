using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SmartLight.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Главная";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}