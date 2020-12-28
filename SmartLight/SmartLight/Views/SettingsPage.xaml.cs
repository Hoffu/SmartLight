using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLight.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartLight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
     
        
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        private int clicked = 1;
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            clicked++;
            if ((clicked % 2) == 0)
            {
                lblStatus.Text = "Вкл";
            }
            else if ((clicked % 2) != 0)
            {
                lblStatus.Text = "Выкл";
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        { /*
            new OAuth2Authenticator {
isUsingNativeUI = true
}
var activity = this.Context as Activity;


var auth = new OAuth2Authenticator(
clientId: "xxxx.apps.googleusercontent.com",
scope: "",
authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/auth"),
redirectUrl: new Uri("myredirecturi"));
auth.Completed += (sender, eventArgs) => {
if (eventArgs.IsAuthenticated)
{
App.SuccessfulLoginAction.Invoke();
App.SaveToken(eventArgs.Account.Properties["access_token"]);
}
};
activity.StartActivity(auth.GetUI(activity));

*/
        }
    }
}