using github_tracker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace github_tracker.Views
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