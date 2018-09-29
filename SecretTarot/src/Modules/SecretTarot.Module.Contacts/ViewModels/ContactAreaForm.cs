using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Contacts.ViewModels
{
    public class ContactAreaForm
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
