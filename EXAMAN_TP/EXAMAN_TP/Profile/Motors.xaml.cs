﻿using EXAMAN_TP.base_donneé;
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
    public partial class Motors : ContentPage
    {
       
        public Motors()
        {
            InitializeComponent();

            ServiceProduit ProduitService = new ServiceProduit();
            List<ProductV> produits = ProduitService.GetProduitByCategorie("Motors");
            liste.ItemsSource = produits;

        }



    }
}