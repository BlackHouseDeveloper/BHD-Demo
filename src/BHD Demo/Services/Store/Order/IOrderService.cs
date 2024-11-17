using BHD_Demo.Models.Store.Basket;

namespace BHD_Demo.Services.Store.Order;

public interface IOrderService
{
    Task CreateOrderAsync(Models.Store.Orders.Order newOrder);

    Task<IEnumerable<Models.Store.Orders.Order>> GetOrdersAsync();

    Task<Models.Store.Orders.Order> GetOrderAsync(int orderId);

    Task<bool> CancelOrderAsync(int orderId);

    OrderCheckout MapOrderToBasket(Models.Store.Orders.Order order);
}