using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Inventory.Models
{
    public class Warehouse : EntityBase
    {
        public Warehouse() { }

        public Warehouse(long id)
        {
            Id = id;
        }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }

        public long AddressId { get; set; }

        public long? VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public Address Address { get; set; }
    }
}
