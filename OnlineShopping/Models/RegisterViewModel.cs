using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class RegisterViewModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address")]
        public string Username { get; set; }
        [DataType(DataType.Password, ErrorMessage = "Invalid password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password Length must be greater than 6 characters.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password, ErrorMessage = "Invalid password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password Length must be greater than 6 characters.")]
        public string ConfirmPassword { get; set; }
    }
}
