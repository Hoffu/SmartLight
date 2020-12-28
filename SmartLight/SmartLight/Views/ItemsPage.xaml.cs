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
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        
        
        public ItemsPage()
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

            await Shell.Current.GoToAsync("//AboutPage");

            BaseViewModel baseViewModel = new BaseViewModel();
            baseViewModel.changeVisibleState();
        }

        void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            
            // Perform required operation
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}