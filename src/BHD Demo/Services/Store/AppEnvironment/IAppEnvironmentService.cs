using BHD_Demo.Services.Store.Basket;
using BHD_Demo.Services.Store.Catalog;
using BHD_Demo.Services.Store.Identity;
using BHD_Demo.Services.Store.Order;

namespace BHD_Demo.Services.Store.AppEnvironment;

public interface IAppEnvironmentService
{
    IBasketService BasketService { get; }

    ICatalogService CatalogService { get; }

    IOrderService OrderService { get; }

    IIdentityService IdentityService { get; }

    void UpdateDependencies(bool useMockServices);
}