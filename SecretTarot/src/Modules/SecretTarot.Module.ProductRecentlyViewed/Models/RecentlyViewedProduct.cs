using System;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.ProductRecentlyViewed.Models
{
    public class RecentlyViewedProduct : EntityBase
    {
        public long UserId { get; set; }

        public long ProductId { get; set; }

        public DateTimeOffset LatestViewedOn { get; set; }
    }
}
