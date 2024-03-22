﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListIt_Maui.Models;

namespace ListIt_Maui.Viewmodels
{
    public partial class AddProductViewmodel : ObservableObject
    {
        #region Properties

        [ObservableProperty] 
        private ObservableCollection<Product> _categoriesList;

        [ObservableProperty] 
        private string _nameSave;

        [ObservableProperty] 
        private CategoryType _categorySave;

        [ObservableProperty] 
        private int _quantitySave;

        [ObservableProperty] 
        private decimal _valueSave;
        
        #endregion

        #region Constructor

        public AddProductViewmodel()
        {
            CategoryList();
        }
        
        #endregion

        #region Commands

        [RelayCommand]
        private void BackProductPage()
        {
            Shell.Current.GoToAsync("//ProductPageShell");
        }

        [RelayCommand]
        private void SaveProduct()
        {
            var item = new Product()
            {
                Name = NameSave,
                Category = CategorySave,
                Quantity = QuantitySave,
                Value = ValueSave
            };
            
            BackProductPage();
        }
        
        #endregion

        #region Methods

        private void CategoryList()
        {
            CategoriesList = new ObservableCollection<Product>();

            foreach (var categoryMapping in ImageConstants.CategoryImageMap)
            {
                CategoriesList.Add(new Product()
                {
                    Category = categoryMapping.Key,
                    Image = categoryMapping.Value
                });
            }
        }
        
        #endregion
    }
}
