using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store;

public partial class FiltersView : ContentPage
{
    public FiltersView(CatalogViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}