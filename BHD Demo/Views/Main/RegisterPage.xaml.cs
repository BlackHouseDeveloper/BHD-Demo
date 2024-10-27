using BHD_Demo.ViewModels.Main;

namespace BHD_Demo.Views.Main
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();  // Set the ViewModel for the page
        }
    }
}
