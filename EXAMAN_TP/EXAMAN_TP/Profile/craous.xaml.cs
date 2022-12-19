using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMAN_TP.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class craous : ContentPage
    {
        ObservableCollection<VotureE> v;

        
        public craous()
        {
            InitializeComponent();
            v = new ObservableCollection<VotureE>
            {
           new VotureE { Name = "Ferrari Rosso",Image="https://thumbor.forbes.com/thumbor/fit-in/1200x0/filters%3Aformat%28jpg%29/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d35eacaf1176b0008974b54%2F0x0.jpg%3FcropX1%3D790%26cropX2%3D5350%26cropY1%3D784%26cropY2%3D3349",group="Red may be Ferrari’s signature colour but it has many shades"  },
           new VotureE { Name = "Genesis Essentia", Image = "https://cdn.motor1.com/images/mgl/RWr7g/s3/2021-genesis-essentia.webp",group="Electric and electrifying, the Genesis Essentia Concept is the ultimate expression of our athletic elegance design language."  },
           new VotureE { Name = "Aston Vanquish", Image = "https://cdn.motor1.com/images/mgl/V1V9R/s3/aston-martin-vanquish-vision-concept.jpg",group="Vanquish Vision Concept will feature a twin-turbocharged version of Aston Martin's new V6"  }
            };
            cars.ItemsSource = v;
        }


    }
}