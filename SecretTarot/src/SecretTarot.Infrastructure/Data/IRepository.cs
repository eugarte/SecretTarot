using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>
    {
    }
}
