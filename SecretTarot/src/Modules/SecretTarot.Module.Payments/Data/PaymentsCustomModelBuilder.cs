using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Payments.Models;

namespace SecretTarot.Module.Payments.Data
{
    public class PaymentsCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentProvider>().ToTable("Payments_PaymentProvider");
        }
    }
}
