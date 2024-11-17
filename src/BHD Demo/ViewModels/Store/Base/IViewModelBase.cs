using BHD_Demo.Services.Store;
using CommunityToolkit.Mvvm.Input;

namespace BHD_Demo.ViewModels.Store.Base;
public interface IViewModelBase : IQueryAttributable
{
    public INavigationService NavigationService { get; }

    public IAsyncRelayCommand InitializeAsyncCommand { get; }

    public bool IsBusy { get; }

    public bool IsInitialized { get; }

    Task InitializeAsync();
}