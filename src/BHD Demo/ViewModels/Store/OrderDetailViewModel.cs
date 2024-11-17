using BHD_Demo.Models.Store.Orders;
using BHD_Demo.Services.Store;
using BHD_Demo.Services.Store.AppEnvironment;
using BHD_Demo.Services.Store.Settings;
using BHD_Demo.ViewModels.Store.Base;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BHD_Demo.ViewModels.Store;

[QueryProperty(nameof(OrderNumber), "OrderNumber")]
public partial class OrderDetailViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;

    [ObservableProperty] private bool _isSubmittedOrder;

    [ObservableProperty] private Order _order;

    [ObservableProperty] private int _orderNumber;

    [ObservableProperty] private string _orderStatusText;

    public OrderDetailViewModel(
        IAppEnvironmentService appEnvironmentService,
        INavigationService navigationService, ISettingsService settingsService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
    }

    public override async Task InitializeAsync()
    {
        await IsBusyFor(
            async () =>
            {
                // Get order detail info
                Order = await _appEnvironmentService.OrderService.GetOrderAsync(OrderNumber);
                IsSubmittedOrder = Order.OrderStatus.Equals("Submitted", StringComparison.OrdinalIgnoreCase);
                OrderStatusText = Order.OrderStatus;
            });
    }

    [RelayCommand]
    private async Task ToggleCancelOrderAsync()
    {
        var result = await _appEnvironmentService.OrderService.CancelOrderAsync(Order.OrderNumber);

        if (result)
        {
            OrderStatusText = "Cancelled";
        }
        else
        {
            Order = await _appEnvironmentService.OrderService.GetOrderAsync(Order.OrderNumber);
            OrderStatusText = Order.OrderStatus;
        }

        IsSubmittedOrder = false;
    }
}