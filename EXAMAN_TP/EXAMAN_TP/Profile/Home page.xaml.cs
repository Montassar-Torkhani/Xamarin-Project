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
    public partial class Home_page : ContentPage
    {
        List<ProductV> produits;
        public Home_page()
        {
            InitializeComponent();
            ServiceProduit ProduitService = new ServiceProduit();
            produits = ProduitService.GetProd();
            liste.ItemsSource = produits;
        }
        
      

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
         
            liste.ItemsSource = produits.Where(s => s.Title.StartsWith(e.NewTextValue));
            
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            ServiceProduit ProduitService = new ServiceProduit();
            await Navigation.PushAsync(new AddProduct());

        }

        async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            ServiceProduit ProduitService = new ServiceProduit();

            var item = sender as SwipeItem;
            var prod = item.CommandParameter as ProductV;
            await Navigation.PushModalAsync(new UpdProduct(prod));

           

        }

        async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var prod = item.CommandParameter as ProductV;
            var result = await DisplayAlert("vous supprimer", prod.Title + " ? ", "yes", "No");

            if (result)
            {
                ServiceProduit ProduitService = new ServiceProduit();
                ProduitService.DeletProd(prod);
                produits = ProduitService.GetProd();
                liste.ItemsSource = produits;
            }
        }

       
    }
}