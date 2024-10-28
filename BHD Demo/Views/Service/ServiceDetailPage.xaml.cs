using Microsoft.Maui.Controls;
using BHD_Demo.ViewModels.Service;

namespace BHD_Demo.Views.Service
{
    public partial class ServiceDetailPage : ContentPage
    {
        public ServiceDetailPage(ServiceDetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;  // Set the ViewModel for the page
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);


            // Debugging: Check the BindingContext and ServiceDate property again
            var vm = BindingContext as ServiceDetailViewModel;
            Console.WriteLine($"ServiceDate after navigation: {vm?.ServiceDate}");
            Console.WriteLine($"ServiceTime after navigation: {vm?.ServiceTime}");

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
