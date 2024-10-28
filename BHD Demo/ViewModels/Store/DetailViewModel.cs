using BHD_Demo.Models.Store;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BHD_Demo.ViewModels.Store
{
    [QueryProperty(nameof(Product), nameof(Product))]
    public partial class DetailViewModel : BaseViewModel
    {
        public RelayCommand NavigateToStoreCommand { get; }

        public RelayCommand NavigateToCartCommand { get; }


        [ObservableProperty]
        Product product;



        public DetailViewModel()
        {
            // Initialize with dummy data for testing
            Product = new Product
            {
                Name = "Sample Product",
                Description = "This is a sample product description.",
                Price = "99.99"
            };

            // Commands for navigation
            NavigateToStoreCommand = new RelayCommand(async () => await Shell.Current.GoToAsync("//store"));
            //NavigateToCartCommand = new RelayCommand(async () => await Shell.Current.GoToAsync("//cart"));
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.PropertyName == nameof(Product))
            {
                Console.WriteLine($"Product changed: {Product?.Name}, {Product?.Description}, {Product?.Price}");
                OnPropertyChanged(nameof(Product)); // Explicitly raise PropertyChanged event
            }
        }
    }



}
