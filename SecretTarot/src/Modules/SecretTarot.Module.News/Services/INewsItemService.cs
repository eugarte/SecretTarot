using System.Threading.Tasks;
using SecretTarot.Module.News.Models;

namespace SecretTarot.Module.News.Services
{
    public interface INewsItemService
    {
        void Create(NewsItem newsItem);

        void Update(NewsItem newsItem);

        Task Delete(long id);

        Task Delete(NewsItem newsItem);
    }
}
