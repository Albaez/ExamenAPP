using System.ComponentModel;
using Xamarin.Forms;
using ExamenAPP.ViewModels;

namespace ExamenAPP.Views
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