using Microsoft.Maui.Controls;
using BHD_Demo.ViewModels.Service;

namespace BHD_Demo.Views.Service
{
    public partial class ServiceDetailPage : ContentPage
    {
        public ServiceDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve query parameters for service details (e.g., date and time)
        }
    }
}
