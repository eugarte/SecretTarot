using System;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Catalog.ViewModels;

namespace SecretTarot.Module.Catalog.Services
{
    public interface IProductPricingService
    {
        CalculatedProductPrice CalculateProductPrice(ProductThumbnail productThumbnail);

        CalculatedProductPrice CalculateProductPrice(Product product);

        CalculatedProductPrice CalculateProductPrice(decimal price, decimal? oldPrice, decimal? specialPrice, DateTimeOffset? specialPriceStart, DateTimeOffset? specialPriceEnd);
    }
}
