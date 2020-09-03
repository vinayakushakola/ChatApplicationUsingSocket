using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class LoginRequest
    {
        [Required]
        [MinLength(5, ErrorMessage = "Your UserName Length Should be more than 5")]
        public string UserName { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Your Password Should be Minimum Length of 8")]
        public string Password { get; set; }
    }
}
