using Microsoft.EntityFrameworkCore;

namespace SecretTarot.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
