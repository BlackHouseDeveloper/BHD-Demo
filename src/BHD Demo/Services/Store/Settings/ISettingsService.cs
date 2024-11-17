#nullable enable
using BHD_Demo.Models.Store.Token;

namespace BHD_Demo.Services.Store.Settings;

public interface ISettingsService
{
    bool UseMocks { get; set; }

    string DefaultEndpoint { get; set; }

    string RegistrationEndpoint { get; set; }

    string ClientId { get; set; }

    string ClientSecret { get; set; }

    string CallbackUri { get; set; }

    string IdentityEndpointBase { get; set; }

    string GatewayCatalogEndpointBase { get; set; }

    string GatewayOrdersEndpointBase { get; set; }

    string GatewayBasketEndpointBase { get; set; }

    bool UseFakeLocation { get; set; }

    string Latitude { get; set; }

    string Longitude { get; set; }

    bool AllowGpsLocation { get; set; }
    Task<UserToken?> GetUserTokenAsync();

    Task SetUserTokenAsync(UserToken? userToken);
}