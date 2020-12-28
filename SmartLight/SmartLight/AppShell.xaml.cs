using System;
using System.Collections.Generic;
using SmartLight.ViewModels;
using SmartLight.Views;
using Xamarin.Forms;

namespace SmartLight
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
           
        }

    }
}
