using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Catalog.Models
{
    public class ProductOption : EntityBase
    {
        public ProductOption()
        {

        }

        public ProductOption(long id)
        {
            Id = id;
        }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
