using BHD_Demo.ViewModels.Main;

namespace BHD_Demo.Views.Main
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomeViewModel();  // Set the ViewModel for the page
        }

protected override bool OnBackButtonPressed()
{
    // If you want to show a confirmation dialog before exiting
    Dispatcher.Dispatch(async () =>
    {
        bool shouldLeave = await Application.Current.MainPage.DisplayAlert("Exit?", 
            "Do you want to exit the app?", "Yes", "No");
    
        if (shouldLeave)
        {
            base.OnBackButtonPressed();
        }
    });

    // Prevent default behavior
    return true;
}

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            // Navigate to the dashboard page
            Shell.Current.GoToAsync("//dashboard");
        }
    }
}
