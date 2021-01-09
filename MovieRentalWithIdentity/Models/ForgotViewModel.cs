using System.ComponentModel.DataAnnotations;

namespace MovieRentalWithIdentity.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
