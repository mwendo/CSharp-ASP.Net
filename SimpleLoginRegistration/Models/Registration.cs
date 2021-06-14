using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class Registration
    {
        [Required]
        public string FirstName { get;set;}

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Email { get; set; }
    }
}