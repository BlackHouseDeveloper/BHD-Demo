using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store;
public partial class BasketView
{
    public BasketView(BasketViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}