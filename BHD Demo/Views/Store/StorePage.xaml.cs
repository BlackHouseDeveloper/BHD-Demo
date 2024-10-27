
using BHD_Demo.ViewModels.Store;

namespace BHD_Demo.Views.Store
{
    public partial class StorePage : ContentPage
    {
        public StorePage(StoreViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
            
        }


    }
}
