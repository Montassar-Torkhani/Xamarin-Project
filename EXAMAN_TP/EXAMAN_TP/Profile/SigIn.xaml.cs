using EXAMAN_TP.base_donneé;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMAN_TP.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigIn : ContentPage
    {
        public SigIn()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Admin> a = new List<Admin>();
          
            Service s = new Service();

            if ((s.FindAdmin(Email.Text) == true))
            {
                a = s.FindObj(Email.Text);
                var fn = a[0].First_Name;
                    
                Navigation.PushModalAsync(new Login(fn , Email.Text) );
            }
            else
            {
                DisplayAlert("Worning", "Email Is Incorecect ", "ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());
        }

    }
}