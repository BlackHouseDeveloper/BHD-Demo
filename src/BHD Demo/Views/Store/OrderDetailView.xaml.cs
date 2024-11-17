using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store;

public partial class OrderDetailView
{
    public OrderDetailView(OrderDetailViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}