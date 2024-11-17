using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Main
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            // Command to simulate registration
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            // Simulate registration and navigate to the main dashboard
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Registration successful!", "OK");
                await Shell.Current.GoToAsync("//dashboard");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill in all fields.", "OK");
            }
        }
    }
}
