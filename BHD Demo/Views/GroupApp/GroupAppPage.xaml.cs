using BHD_Demo.ViewModels.GroupApp;

namespace BHD_Demo.Views.GroupApp
{
    public partial class GroupAppPage : ContentPage
    {
        public GroupAppPage()
        {
            InitializeComponent();
             BindingContext = new GroupAppViewModel();  // Set the ViewModel for the page
        }
    }
}
