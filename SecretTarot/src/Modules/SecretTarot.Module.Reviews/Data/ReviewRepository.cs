﻿using SecretTarot.Module.Core.Data;
using SecretTarot.Module.Core.Models;
using SecretTarot.Module.Reviews.Models;
using System.Linq;

namespace SecretTarot.Module.Reviews.Data
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(SimplDbContext context) : base(context)
        {
        }

        public IQueryable<ReviewListItemDto> List()
        {
            var items = DbSet.Join(Context.Set<Entity>(),
                r => new { key1 = r.EntityId, key2 = r.EntityTypeId },
                u => new { key1 = u.EntityId, key2 = u.EntityTypeId },
                (r, u) => new ReviewListItemDto
                {
                    EntityTypeId = r.EntityTypeId,
                    Id = r.Id,
                    ReviewerName = r.ReviewerName,
                    Rating = r.Rating,
                    Title = r.Title,
                    Comment = r.Comment,
                    Status = r.Status,
                    CreatedOn = r.CreatedOn,
                    EntityName = u.Name,
                    EntitySlug = u.Slug
                });

            return items;
        }
    }
}