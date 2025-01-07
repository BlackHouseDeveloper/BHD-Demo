using BHD_Demo.Services.Store;
using Microsoft.Maui.Controls;

namespace BHD_Demo.Views.Store
{



    public partial class StoreSplashView : ContentPage
    {

        private readonly INavigationService _navigationService;
        public StoreSplashView(INavigationService navigationService)
        {
            InitializeComponent();

            InitializeStore();

        }

        private async void InitializeStore()
        {

            App.Current.UserAppTheme = AppTheme.Light;
            // Navigate to Store's main page
            await Shell.Current.GoToAsync("//Login");
        }

        /*protected override async void OnHandlerChanged()
        {
            base.OnHandlerChanged();

            if (Handler is not null)
            {
                await _navigationService.InitializeAsync();
            }
        }
*/
    }
}