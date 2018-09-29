using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Reviews.Models;
using System.Linq;

namespace SecretTarot.Module.Reviews.Data
{
    public interface IReplyRepository : IRepository<Reply>
    {
        IQueryable<ReplyListItemDto> List();
    }
}
