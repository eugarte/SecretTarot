using System.Threading.Tasks;
using System.Collections.Generic;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Catalog.ViewModels;

namespace SecretTarot.Module.Catalog.Services
{
    public interface ICategoryService
    {
        Task<IList<CategoryListItem>> GetAll();

        Task Create(Category category);

        Task Update(Category category);

        Task Delete(Category category);
    }
}
