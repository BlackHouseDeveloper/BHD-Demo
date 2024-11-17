using BHD_Demo.ViewModels.Store;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BHD_Demo.Views.Store
{

    public partial class DetailPage : ContentPage
    {

        public DetailPage(DetailViewModel vm)
        {
            // Set the binding context to the DetailViewModel

            InitializeComponent();
            BindingContext = vm;

            // Debugging: Check the BindingContext and Product property
            Console.WriteLine($"BindingContext: {BindingContext}");
            Console.WriteLine($"Product: {vm.Product?.Name}, {vm.Product?.Description}, {vm.Product?.Price}");

        }


        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            // Log parameter values
            //Console.WriteLine($"ProductName: {ProductName}");
            //Console.WriteLine($"ProductDescription: {ProductDescription}");
            //Console.WriteLine($"ProductPrice: {ProductPrice}");
            Console.WriteLine("Navigated to DetailPage");

            // Debugging: Check the BindingContext and Product property again
            var vm = BindingContext as DetailViewModel;
            Console.WriteLine($"Product after navigation: {vm?.Product?.Name}, {vm?.Product?.Description}, {vm?.Product?.Price}");

            // Update UI or perform any necessary actions
            if (vm != null)
            {
                // Ensure the UI is updated after the data is set
                BindingContext = null;
                BindingContext = vm;
            }

        }
    }
}