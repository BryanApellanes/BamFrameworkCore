using Collusion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Collusion.Views
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