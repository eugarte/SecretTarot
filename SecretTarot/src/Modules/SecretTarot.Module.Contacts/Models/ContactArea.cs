using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Contacts.Models
{
    public class ContactArea : EntityBase
    {
        [Required]
        [StringLength(450)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}
