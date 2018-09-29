using System.Linq;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Comments.Models;

namespace SecretTarot.Module.Comments.Data
{
    public interface ICommentRepository : IRepository<Comment>
    {
        IQueryable<CommentListItemDto> List();
    }
}