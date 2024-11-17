using BHD_Demo.ViewModels.GroupApp;

namespace BHD_Demo.Views.GroupApp
{
    public partial class AddGroupPage : ContentPage
    {
        public AddGroupPage()
        {
            InitializeComponent();
            BindingContext = new AddGroupPageViewModel();  // Set the ViewModel for the page
        }
    }
}