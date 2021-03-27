//using Self_Help_Gamify.Services;
using Self_Help_Gamify.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Self_Help_Gamify
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            //this should inti the exp prop if it is not already set in the app!
            if (!Application.Current.Properties.ContainsKey("EXP"))
            {
                Application.Current.Properties["EXP"] = 0;
                Application.Current.Properties["EXP_to_next_lvl"] = 30;
                Application.Current.Properties["Level"] = 0;
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
