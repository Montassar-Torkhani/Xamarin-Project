﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMAN_TP.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Flyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPage1Flyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPage1FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPage1FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPage1FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPage1FlyoutMenuItem>(new[]
                {
                    new FlyoutPage1FlyoutMenuItem { Id = 0,Icon="phom" , Title = "Home Page",TargetType=typeof(Home_page)},
                    new FlyoutPage1FlyoutMenuItem { Id = 1,Icon="pspor" , Title = "Sport Cars",TargetType=typeof(VoitureS)},
                    new FlyoutPage1FlyoutMenuItem { Id = 2,Icon="pbig" , Title = "Compact Cars",TargetType=typeof(VoitureB)},
                    new FlyoutPage1FlyoutMenuItem { Id = 3,Icon="pmini" , Title = "Mini Cars",TargetType=typeof(VoitureN)},
                    new FlyoutPage1FlyoutMenuItem { Id = 4,Icon="pm" , Title = "Motors",TargetType=typeof(Motors) },

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}