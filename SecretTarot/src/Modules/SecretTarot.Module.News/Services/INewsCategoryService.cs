using System.Threading.Tasks;
using SecretTarot.Module.News.Models;

namespace SecretTarot.Module.News.Services
{
    public interface INewsCategoryService
    {
        Task Create(NewsCategory category);

        Task Update(NewsCategory category);

        Task Delete(long id);

        Task Delete(NewsCategory category);
    }
}
