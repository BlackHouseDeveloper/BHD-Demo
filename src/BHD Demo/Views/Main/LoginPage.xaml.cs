using BHD_Demo.ViewModels.Main;

namespace BHD_Demo.Views.Main
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();  // Set the ViewModel for the page
        }
    }
}
