using Microsoft.Maui.Controls;
using BHD_Demo.ViewModels.Service;

namespace BHD_Demo.Views.Service
{
    public partial class ServiceSchedulerPage : ContentPage
    {
        public ServiceSchedulerPage(ServiceSchedulerViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;  // Set the ViewModel for the page
        }
    }
}
