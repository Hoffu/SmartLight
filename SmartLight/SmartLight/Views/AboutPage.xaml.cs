using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartLight.Models;
using SmartLight.Views;
using SmartLight.ViewModels;
using System.Runtime.CompilerServices;
namespace SmartLight.Views
{
    public partial class AboutPage : ContentPage
    {
        ItemsViewModel _viewModel;
        public AboutPage()
        {
            InitializeComponent();


            BindingContext = _viewModel = new ItemsViewModel();



        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            await Shell.Current.GoToAsync("//ItemsPage");

            BaseViewModel baseViewModel = new BaseViewModel();
            baseViewModel.changeVisibleState();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}