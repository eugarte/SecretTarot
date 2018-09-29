using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Reviews.Models;
using System.Linq;

namespace SecretTarot.Module.Reviews.Data
{
    public interface IReviewRepository : IRepository<Review>
    {
        IQueryable<ReviewListItemDto> List();
    }
}