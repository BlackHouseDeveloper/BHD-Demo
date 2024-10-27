using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Main
{
    public class WelcomeViewModel : BaseViewModel
    {
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegisterCommand { get; }
        public ICommand SkipToDashboardCommand { get; }

        public WelcomeViewModel()
        {
            // Command to navigate to the login page
            NavigateToLoginCommand = new Command(async () => await Shell.Current.GoToAsync("//login"));

            // Command to navigate to the registration page
            NavigateToRegisterCommand = new Command(async () => await Shell.Current.GoToAsync("//register"));

            // Command to skip to the main dashboard
            SkipToDashboardCommand = new Command(async () => await Shell.Current.GoToAsync("//dashboard"));
        }
    }
}
