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
    public partial class AddProduct : ContentPage
    {
        private Service s = new Service();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Add_Prodcut_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_Product.Text) || string.IsNullOrWhiteSpace(CodProd.Text) || string.IsNullOrWhiteSpace(Description.Text) || string.IsNullOrWhiteSpace(Category.Text) || string.IsNullOrWhiteSpace(Image_Product.Text) || string.IsNullOrWhiteSpace(Price.Text))
            {
                DisplayAlert("Feilds", "Complet All Information of Product", "ok");
                
            }
            else
            {
                this.AjouterProduit();
            }
        }

        async void AjouterProduit()
        {
           
                    ServiceProduit sp = new ServiceProduit();
                    ProductV p = new ProductV();
                    p.Title = Name_Product.Text;
                    p.CodProd = CodProd.Text;
                    p.Description = Description.Text;
                    p.Price = double.Parse(Price.Text);
                    p.ImageUri = Image_Product.Text;
                    p.category = Category.Text;
                    sp.insertProd(p);

               await DisplayAlert("Succed", "Prodcut Added Succeflly", "ok");
               await Navigation.PopModalAsync();

        }




        
    }
}