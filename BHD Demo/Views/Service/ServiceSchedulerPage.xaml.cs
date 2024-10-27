using Microsoft.Maui.Controls;
using BHD_Demo.ViewModels.Service;

namespace BHD_Demo.Views.Service
{
    public partial class ServiceSchedulerPage : ContentPage
    {
        public ServiceSchedulerPage()
        {
            InitializeComponent();
            BindingContext = new ServiceSchedulerViewModel();  // Set the ViewModel for the page
        }
    }
}
