using BHD_Demo.Models.Store.Basket;
using BHD_Demo.Models.Store.Catalog;
using BHD_Demo.Models.Store.Marketing;

namespace BHD_Demo.Services.Store.FixUri;

    public interface IFixUriService
{
    void FixCatalogItemPictureUri(IEnumerable<CatalogItem> catalogItems);
    void FixBasketItemPictureUri(IEnumerable<BasketItem> basketItems);
    void FixCampaignItemPictureUri(IEnumerable<CampaignItem> campaignItems);
}
