using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store
{
    public partial class CheckoutView
    {
        public CheckoutView(CheckoutViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}