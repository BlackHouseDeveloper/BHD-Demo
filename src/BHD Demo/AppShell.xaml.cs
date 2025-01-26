using BHD_Demo.Services.Store;
using BHD_Demo.Views.Store;

namespace BHD_Demo;

public partial class AppShell : Shell
{
private readonly INavigationService _navigationService;
    
    public AppShell(INavigationService navigationService)
    {   
        _navigationService = navigationService;
        InitializeRouting();

        InitializeComponent();
        
    }

    

 
    private static void InitializeRouting()
    {
        //Routing.RegisterRoute("Login", typeof(LoginView));
        Routing.RegisterRoute("Filter", typeof(FiltersView));
        Routing.RegisterRoute("ViewCatalogItem", typeof(CatalogItemView));
        Routing.RegisterRoute("Basket", typeof(BasketView));
        Routing.RegisterRoute("Settings", typeof(SettingsView));
        Routing.RegisterRoute("OrderDetail", typeof(OrderDetailView));
        Routing.RegisterRoute("Checkout", typeof(CheckoutView));
    }

    protected override async void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);

        // Apply fade-in animation after navigating
        await CurrentPage.FadeTo(1, 250);   // Fade in new page
    }

    

}