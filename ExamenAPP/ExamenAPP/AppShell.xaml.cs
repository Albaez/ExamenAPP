using System;
using System.Collections.Generic;
using ExamenAPP.ViewModels;
using ExamenAPP.Views;
using Xamarin.Forms;

namespace ExamenAPP
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
