using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartLight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }
       
        private static void Switch_Toggled(object sender, ToggledEventArgs e)
        {
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile1());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile2());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile3());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile4());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile5());
        }
    }
    
}