using Self_Help_Gamify.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Self_Help_Gamify.Views
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