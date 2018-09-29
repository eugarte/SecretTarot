using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Tax.Models
{
    public class TaxClass : EntityBase
    {
        public TaxClass() { }

        public TaxClass(long id)
        {
            Id = id;
        }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
