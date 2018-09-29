using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Core.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
