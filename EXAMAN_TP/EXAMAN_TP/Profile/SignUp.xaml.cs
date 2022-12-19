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
    public partial class SignUp: ContentPage
    {
        private Service s = new Service();
        public SignUp()
        {
            InitializeComponent();
        }



       

        private void register_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) || string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(Pwd.Text) || string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(phone.Text))
            {
                DisplayAlert("Worning", "complet your all information", "ok");
            }
            else
            {
                this.ajouterAdmin();

            }
            
        }


        public void ajouterAdmin()
        {
            Admin a = new Admin();
            a.First_Name = firstName.Text;
            a.Last_Name = lastName.Text;
            a.Email = Email.Text;
            a.Password = Pwd.Text;
            a.Phone_Number = phone.Text;

            Service s = new Service();

            if ((s.FindAdmin(Email.Text)==false))
            {
                s.insertUsers(a);
               
                DisplayAlert("Success", "Admin added with success", "ok");
            }
            else
            {
                DisplayAlert("Ops...", "Email Already Exist ", "ok");
            }

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SigIn());
        }

    }
}