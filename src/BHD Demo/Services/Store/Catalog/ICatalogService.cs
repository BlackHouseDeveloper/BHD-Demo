using BHD_Demo.Models.Store.Catalog;

namespace BHD_Demo.Services.Store.Catalog;

public interface ICatalogService
{
    Task<IEnumerable<CatalogBrand>> GetCatalogBrandAsync();
    Task<IEnumerable<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId);
    Task<IEnumerable<CatalogType>> GetCatalogTypeAsync();
    Task<IEnumerable<CatalogItem>> GetCatalogAsync();

    Task<CatalogItem> GetCatalogItemAsync(int catalogItemId);
}