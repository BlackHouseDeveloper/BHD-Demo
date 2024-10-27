using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Main
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand GoogleLoginCommand { get; }
        public ICommand BiometricLoginCommand { get; }

        public LoginViewModel()
        {
            // Commands for login methods
            LoginCommand = new Command(OnLoginClicked);
            GoogleLoginCommand = new Command(OnGoogleLoginClicked);
            BiometricLoginCommand = new Command(OnBiometricLoginClicked);
        }

        // Simulated Email/Password login
        private async void OnLoginClicked()
        {
            // Simulate a delay for user experience
            await Task.Delay(1000);

            // Simulated successful login
            await Shell.Current.GoToAsync("//dashboard");
        }

        // Simulated Google OAuth login
        private async void OnGoogleLoginClicked()
        {
            // Simulate a delay for user experience
            await Task.Delay(1000);

            // Mock success of Google login
            await Shell.Current.GoToAsync("//dashboard");
        }

        // Simulated Biometric Login
        private async void OnBiometricLoginClicked()
        {
            // Simulate biometric login for demo purposes
            await Task.Delay(1000);

            // Mock success of biometric login
            await Shell.Current.GoToAsync("//dashboard");
        }
    }
}
