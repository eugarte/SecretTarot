using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Core.ViewModels.Manage
{
    public class UserInfoVm
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
