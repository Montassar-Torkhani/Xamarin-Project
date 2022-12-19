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
    public partial class UpdProduct : ContentPage
    {
        private ProductV produit;

        public UpdProduct()
        {
            InitializeComponent();

        }

        public UpdProduct(ProductV prod)
        {
            InitializeComponent();
            this.produit = new ProductV();
            this.produit.Id=prod.Id;

            Name_Product.Text = prod.Title;
            CodProd.Text = prod.CodProd;
            Description.Text = prod.Description;
            Price.Text = prod.Price.ToString();
            Image_Product.Text = prod.ImageUri;
            Category.Text = prod.category;
            Name_Product.Focus();

        }


        async void Updd_Prodcut_Clicked(object sender, EventArgs e)
        {
            ServiceProduit sp = new ServiceProduit();
            ProductV p = new ProductV();
            p.Id = this.produit.Id;

            p.Title = Name_Product.Text;
            p.CodProd = CodProd.Text;
            p.Description = Description.Text;
            p.Price = double.Parse(Price.Text);
            p.ImageUri = Image_Product.Text;
            p.category = Category.Text;



            if (string.IsNullOrWhiteSpace(Name_Product.Text) || string.IsNullOrWhiteSpace(CodProd.Text) || string.IsNullOrWhiteSpace(Description.Text) || string.IsNullOrWhiteSpace(Category.Text) || string.IsNullOrWhiteSpace(Image_Product.Text) || string.IsNullOrWhiteSpace(Price.Text))
            {

                await DisplayAlert("Fialed", "Complet all information of Product", "ok");
            }

            else
            {
                if (sp.UpdatProd(p))
                {
                    await DisplayAlert("Succed", "Prodcut Update Succeflly", "ok");

                    await Navigation.PopModalAsync();
                }
                else
                {
                    await DisplayAlert("worning", "Prodcut Not updated", "ok");
                }


            }
        }







    }
}