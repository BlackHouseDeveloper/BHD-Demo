using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.Input;
using BHD_Demo.Models.Store;
using BHD_Demo.Views.Store;

namespace BHD_Demo.ViewModels.Store
{
    public partial class StoreViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; }
       
        [ObservableProperty]
        public Product? selectedProduct;

        public RelayCommand AddToCartCommand { get; }

        public RelayCommand NavigateToDetailCommand { get; }

        public StoreViewModel()
        {
           // Initialize the product list
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", Price = "$10.00", Description = "This is Product 1." },
                new Product { Name = "Product 2", Price = "$20.00", Description = "This is Product 2." },
                new Product { Name = "Product 3", Price = "$30.00", Description = "This is Product 3." }
            };

            // Command to add selected product to cart
            AddToCartCommand = new RelayCommand(OnAddToCart);

            // Command to navigate to the detail page
            NavigateToDetailCommand = new RelayCommand(OnNavigateToDetail);
        }

        private async void OnAddToCart()
        {
            if (SelectedProduct != null)
            {
                await Application.Current.MainPage.DisplayAlert("Cart", $"{SelectedProduct.Name} added to cart.", "OK");
            }
        }

        private async void OnNavigateToDetail()
        {
            if (SelectedProduct != null)
            {
                try
                {
                    // Navigate to the DetailPage and pass the selected product
                    await Shell.Current.GoToAsync($"///detailpage", 
                    new Dictionary<string, object>
                    {
                        { "Product", SelectedProduct }
                    });
                }
                catch (Exception ex)
                {

 
  
              // Handle or log the exception
                    Console.WriteLine($"Navigation failed: {ex.Message}");
                }


 
  
            }
        }
    }
}    
