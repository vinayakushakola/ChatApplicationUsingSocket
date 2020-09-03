using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class RegistrationRequest
    {
        [Required]
        [MinLength(3, ErrorMessage = "Your FirstName Length Should be more than 3")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Your LastName Length Should be more than 3")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter a Proper Email-ID")]
        public string Email { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Your UserName Length Should be more than 5")]
        public string UserName { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Your Password Should be Minimum Length of 8")]
        public string Password { get; set; }
    }
}
