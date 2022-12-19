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
    public partial class UpdatePswd : ContentPage
    {
        private Service s = new Service();
        private string email;
        private string pwd;

        public UpdatePswd()
        {
            InitializeComponent();
        }

       

        public UpdatePswd(string email, string pwd)
        {
            InitializeComponent();
            this.email = email;
            this.pwd = pwd;
        }

        private void Updd_Pasword_Clicked(object sender, EventArgs e)
        {
           


            if ( (Pwd.Text != this.pwd)  || string.IsNullOrWhiteSpace(Pwdn.Text) || string.IsNullOrWhiteSpace(Pwd.Text) )
            {
                DisplayAlert("Worning", "Verife Your Information", "ok");
            }
            else
            {
                Service s = new Service();

                s.UpdateMP(this.email, Pwdn.Text);
                DisplayAlert("Succed", "Password Is Updated ", "ok");
                Navigation.PushModalAsync(new SigIn());


            }




        }
        }



    }
