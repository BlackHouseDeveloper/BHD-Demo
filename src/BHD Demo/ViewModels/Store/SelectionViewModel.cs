using CommunityToolkit.Mvvm.ComponentModel;

namespace BHD_Demo.ViewModels.Store;

public partial class SelectionViewModel<T> : ObservableObject
{
    [ObservableProperty] private bool _selected;
    [ObservableProperty] private T _value;
}