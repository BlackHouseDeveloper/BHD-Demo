using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Main
{
    public class DashboardViewModel : BaseViewModel
    {
        public ICommand NavigateToStoreCommand { get; }
        public ICommand NavigateToServiceCommand { get; }
        public ICommand NavigateToGroupAppCommand { get; }

        public DashboardViewModel()
        {
            // Commands for navigation
            NavigateToStoreCommand = new Command(async () => await Shell.Current.GoToAsync("//store"));
            NavigateToServiceCommand = new Command(async () => await Shell.Current.GoToAsync("//scheduler"));
            NavigateToGroupAppCommand = new Command(async () => await Shell.Current.GoToAsync("//groupapp"));
        }
    }
}
