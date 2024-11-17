namespace BHD_Demo.Models.Store.Orders;

public class CancelOrderCommand
{
    public CancelOrderCommand(int orderNumber)
    {
        OrderNumber = orderNumber;
    }

    public int OrderNumber { get; }
}