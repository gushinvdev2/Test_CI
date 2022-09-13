using System.ComponentModel;
using Test_CI_Mobile.ViewModels;
using Xamarin.Forms;

namespace Test_CI_Mobile.Views
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