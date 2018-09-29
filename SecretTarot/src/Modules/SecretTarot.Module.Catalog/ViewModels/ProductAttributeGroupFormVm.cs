using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Catalog.ViewModels
{
    public class ProductAttributeGroupFormVm
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
