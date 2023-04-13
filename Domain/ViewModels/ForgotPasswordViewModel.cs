using System.ComponentModel.DataAnnotations;

namespace SharedLayer.Domain.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
