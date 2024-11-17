
using BHD_Demo.Models.Store.Basket;

namespace BHD_Demo.Services.Store.Basket;

public interface IBasketService
{
    IEnumerable<BasketItem> LocalBasketItems { get; set; }
    Task<CustomerBasket> GetBasketAsync();
    Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket);
    Task ClearBasketAsync();
}