using System;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.ProductComparison.Models
{
    public class ComparingProduct : EntityBase
    {
        public DateTimeOffset CreatedOn { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }
    }
}
