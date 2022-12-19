using EXAMAN_TP.Profile;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMAN_TP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SigIn();
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
