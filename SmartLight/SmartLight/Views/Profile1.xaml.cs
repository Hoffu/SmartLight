using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartLight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile1 : ContentPage
    {
        StackLayout parent;
        int count = 1;

        public Profile1()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                createDevices();
            }
        }

        private static void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
     
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            createDevices();
        }

        private void createDevices()
        {
            StackLayout stackLayout = new StackLayout { Orientation = Xamarin.Forms.StackOrientation.Horizontal, Spacing = 230 };
            Image image = new Image { Source = "line.png" };
            Button newButton = new Button { Text = "Device" + count, TextColor = Color.FromRgb(212, 211, 216), BackgroundColor = Color.FromRgb(19, 19, 21), FontSize = 24 };
            Switch swtch = new Switch { IsToggled = false };

            stackLayout.Children.Add(newButton);
            stackLayout.Children.Add(swtch);
            parent = layout;
            parent.Children.Add(image);
            parent.Children.Add(stackLayout);
            count++;
        }
    }
}