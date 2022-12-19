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
    public partial class Login : ContentPage
    {
        private string fn;
        private string text;

        public Login()
        {
            InitializeComponent();
        }

        public Login(string fn, string text)
        {
            InitializeComponent();
            nomv.Text = fn;
            emailv.Text = text;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Admin a = new Admin();
            
            a.Password = pwd.Text;

            Service s = new Service();

            if ((s.FindAdminPwd(emailv.Text,pwd.Text) == true))
            {

                Navigation.PushModalAsync(new profil(emailv.Text, pwd.Text));
            }
            else
            {
                DisplayAlert("Worning", "Password Is Incorecect ", "ok");
            }
        }
    }
}