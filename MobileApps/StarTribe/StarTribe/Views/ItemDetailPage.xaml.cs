using StarTribe.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StarTribe.Views
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