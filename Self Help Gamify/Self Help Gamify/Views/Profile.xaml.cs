using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Self_Help_Gamify.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            Level.Text = $"Level: {Application.Current.Properties["Level"]}";
            EXP.Text = $"{Application.Current.Properties["EXP"]} / {Application.Current.Properties["EXP_to_next_lvl"]} EXP ";
        }
        //updates if there has been changes to exp / level
        protected override void OnAppearing()
        {
            Level.Text = $"Level: {Application.Current.Properties["Level"]}";
            EXP.Text = $"{Application.Current.Properties["EXP"]} / {Application.Current.Properties["EXP_to_next_lvl"]} EXP ";
        }
    }
}