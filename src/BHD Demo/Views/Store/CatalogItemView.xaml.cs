using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store;

public partial class CatalogItemView
{
    public CatalogItemView(CatalogItemViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}