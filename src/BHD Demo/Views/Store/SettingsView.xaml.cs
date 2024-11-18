



using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store;

public partial class SettingsView : ContentPage
{
    public SettingsView(SettingsViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}