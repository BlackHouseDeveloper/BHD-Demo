using BHD_Demo.ViewModels.Main;

namespace BHD_Demo.Views.Main
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            BindingContext = new DashboardViewModel();  // Set the ViewModel for the page
        }



    }
}