using BHD_Demo.Services.Store;
using BHD_Demo.ViewModels.Store.Base;
using CommunityToolkit.Mvvm.Input;

namespace BHD_Demo.ViewModels.Store;
public partial class MainViewModel : ViewModelBase
{
    public MainViewModel(INavigationService navigationService)
        : base(navigationService)
    {
    }

    [RelayCommand]
    private async Task SettingsAsync()
    {
        await NavigationService.NavigateToAsync("Settings");
    }
}