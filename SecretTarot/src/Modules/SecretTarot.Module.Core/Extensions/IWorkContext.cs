using System.Threading.Tasks;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Extensions
{
    public interface IWorkContext
    {
        Task<User> GetCurrentUser();
    }
}
