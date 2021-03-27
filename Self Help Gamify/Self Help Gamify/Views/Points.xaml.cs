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
    public partial class Points : ContentPage
    {
        public Points()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //this is a temp method that will add one exp when the button is clicked

            //So Properties will save the value in a int obj so it needs to be converted to a int to work
            int NewEXP = Convert.ToInt32(Application.Current.Properties["EXP"]) + 1;
            Application.Current.Properties["EXP"] = NewEXP;
            Application.Current.SavePropertiesAsync();
            EXPLable.Text = $"Your Curent EXP is {Application.Current.Properties["EXP"]}"; //update the exp lable
        }
    }
}