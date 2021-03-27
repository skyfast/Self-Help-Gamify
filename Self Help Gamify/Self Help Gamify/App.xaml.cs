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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
