using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartLight.Views
{
    
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PopAsync();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                if (entry1.Text != null && entry2.Text != null && entry3.Text != null && entry4.Text != null && entry5.Text != null
                && picker.Items[picker.SelectedIndex] != null && picker1.Items[picker.SelectedIndex] != null && picker2.Items[picker.SelectedIndex] != null)
                {
                    Random random = new Random();
                    int a = random.Next(1, 8);
                    calcOutput.Text = a.ToString();
                }
            }
            catch
            {

            }
        }
    }
}