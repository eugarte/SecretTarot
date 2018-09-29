using System.Threading.Tasks;
using SecretTarot.Module.Cms.Models;

namespace SecretTarot.Module.Cms.Services
{
    public interface IPageService
    {
        Task Create(Page page);

        Task Update(Page page);

        Task Delete(Page page);
    }
}
