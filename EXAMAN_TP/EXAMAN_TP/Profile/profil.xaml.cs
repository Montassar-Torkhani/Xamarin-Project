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
    public partial class profil : ContentPage
    {
        private string email;
        private string pwd;

        public profil()
        {
            InitializeComponent();
            Task.Run(AnimateBorder);
        }

        public profil(string email, string pwd)
        {
            InitializeComponent();
            Task.Run(AnimateBorder);
            this.email = email;
            this.pwd = pwd;
        }

        private void Pwd_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UpdatePswd(email,pwd));
        }


        private void Iset_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IsetRades());
        }


        private void Cars_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FlyoutPage1());
        }

        private void craousel_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new craous());
        }



        private async void AnimateBorder()
        {
            Action<double> tealMovement = tInput => tealGrad.Offset = (float)tInput;
            Action<double> orangeMovement = oInput => orangeGrad.Offset = (float)oInput;

            while (true)
            {
                mainRect.Animate(name: "forward", callback: tealMovement, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
                mainRect.Animate(name: "backward", callback: tealMovement, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);

                mainRect.Animate(name: "forward2", callback: orangeMovement, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
                mainRect.Animate(name: "backward2", callback: orangeMovement, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
            }


        }

      
    }
}