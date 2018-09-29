using Microsoft.EntityFrameworkCore;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Core.Data;

namespace SecretTarot.Module.Catalog.Data
{
    // TODO This is just a temporary workaround because EF Core 1.0 hasn't support many-many without an entity class to represent the join table
    public class ProductTemplateProductAttributeRepository : IProductTemplateProductAttributeRepository
    {
        private readonly DbContext dbContext;

        public ProductTemplateProductAttributeRepository(SimplDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Remove(ProductTemplateProductAttribute item)
        {
            dbContext.Set<ProductTemplateProductAttribute>().Remove(item);
        }
    }
}
