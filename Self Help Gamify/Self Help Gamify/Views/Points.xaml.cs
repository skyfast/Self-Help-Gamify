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
            //get the current player level
            int Exp = Convert.ToInt32(Application.Current.Properties["EXP"]);
            Application.Current.Properties["Level"] = (Exp / 30)+1;
            
            //get the exp to the next level
            int levelConvert = Convert.ToInt32(Application.Current.Properties["Level"]);
            Application.Current.Properties["EXP_to_next_lvl"] = levelConvert * 30;

            LvlLable.Text = $"Level {Application.Current.Properties["Level"]}";
            EXPLable.Text = $"EXP {Application.Current.Properties["EXP"]} / {Application.Current.Properties["EXP_to_next_lvl"]}"; //update the exp lable
            Application.Current.SavePropertiesAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //this is a temp method that will add one exp when the button is clicked

            //So Properties will save the value in a int obj so it needs to be converted to a int to work
            int NewEXP = Convert.ToInt32(Application.Current.Properties["EXP"]) + 1;
            Application.Current.Properties["EXP"] = NewEXP;

            //check for a level up
            int LvlEXP = Convert.ToInt32(Application.Current.Properties["EXP_to_next_lvl"]);

            if(NewEXP >= LvlEXP)
            {
                Application.Current.Properties["Level"] = (NewEXP / 30) + 1;
                Application.Current.Properties["EXP_to_next_lvl"] = LvlEXP + 30;
                LvlLable.Text = $"Level {Application.Current.Properties["Level"]}";
                DisplayAlert("Level Up", "Congratz, You have leveled up, keep up the good work!", "Nice!");
            }
            Application.Current.SavePropertiesAsync();
            EXPLable.Text = $"EXP {Application.Current.Properties["EXP"]} / {Application.Current.Properties["EXP_to_next_lvl"]}"; //update the exp lable
        }
    }
}