using IconsTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IconsTest.Views
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