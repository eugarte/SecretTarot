using System.Linq;
using SecretTarot.Module.Catalog.Models;

namespace SecretTarot.Module.ProductRecentlyViewed.Data
{
    public interface IRecentlyViewedProductRepository
    {
        IQueryable<Product> GetRecentlyViewedProduct(long userId);
    }
}
