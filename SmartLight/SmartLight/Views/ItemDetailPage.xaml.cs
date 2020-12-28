using System.ComponentModel;
using Xamarin.Forms;
using SmartLight.ViewModels;

namespace SmartLight.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}