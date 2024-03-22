using CommunityToolkit.Mvvm.ComponentModel;
using ListIt_Maui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ListItMaui.Services;

namespace ListIt_Maui.Viewmodels
{
    public partial class ProductViewmodel : ObservableObject
    {
        #region properties

        private readonly IProductService _productService;

        [ObservableProperty] 
        private ObservableCollection<Product> _itemsList;
        
        #endregion

        #region constructor

        public ProductViewmodel()
        {
            _productService = new ProductService();
            PopulateList();
        }
        
        #endregion

        #region commands

        [RelayCommand]
        private void NavigateToAddProd()
        {
            Shell.Current.GoToAsync("//AddProductShell");
        }
        #endregion

        #region methods
        
        public int ItemCount => ItemsList.Count;
        public double TotalValue => (double)ItemsList.Sum(item => item.Value);

        private void PopulateList()
        {
            ItemsList = new ObservableCollection<Product>()
            {
                new Product()
                {
                    Name = "teste",
                    Category = CategoryType.Eletronicos,
                    Value = 29.90m,
                    Quantity = 5,
                    Image = ImageConstants.CategoryImageMap[CategoryType.Eletronicos]
                },
                new Product()
                {
                    Name = "eita",
                    Category = CategoryType.Oficina,
                    Value = 29.90m,
                    Quantity = 5,
                    Image = ImageConstants.CategoryImageMap[CategoryType.Oficina]
                },new Product()
                {
                    Name = "arroz",
                    Category = CategoryType.Mercado,
                    Value = 29.90m,
                    Quantity = 5,
                    Image = ImageConstants.CategoryImageMap[CategoryType.Mercado]
                },
                new Product()
                {
                    Name = "Minoxidil",
                    Category = CategoryType.Farmacia,
                    Value = 9.00m,
                    Quantity = 5,
                    Image = ImageConstants.CategoryImageMap[CategoryType.Farmacia]
                }
            };
            ItemsList.CollectionChanged += OnItemsListChanged;
        }
        
        private void OnItemsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ItemCount));
            OnPropertyChanged(nameof(TotalValue));

        }
        
        #endregion
    }
}
