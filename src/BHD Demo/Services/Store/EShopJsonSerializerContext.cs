using System.Text.Json.Serialization;
using BHD_Demo.Models.Store.Catalog;
using BHD_Demo.Models.Store.Orders;
using BHD_Demo.Models.Store.Token;

namespace BHD_Demo.Services.Store;

[JsonSourceGenerationOptions(
    PropertyNameCaseInsensitive = true,
    NumberHandling = JsonNumberHandling.AllowReadingFromString)]
[JsonSerializable(typeof(CancelOrderCommand))]
[JsonSerializable(typeof(CatalogBrand))]
[JsonSerializable(typeof(CatalogItem))]
[JsonSerializable(typeof(CatalogRoot))]
[JsonSerializable(typeof(CatalogType))]
[JsonSerializable(typeof(Models.Store.Orders.Order))]
[JsonSerializable(typeof(Models.Store.Location.Location))]
[JsonSerializable(typeof(UserToken))]
internal partial class EShopJsonSerializerContext : JsonSerializerContext
{
}