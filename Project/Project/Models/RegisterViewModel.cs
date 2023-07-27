using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Username is required!!")]
        [StringLength(15)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!!")]
        [MinLength(6)]
        [MaxLength(12)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Re-Password is required!!")]
        [MinLength(6)]
        [MaxLength(12)]
        [Compare(nameof(Password))] /*Bir propertye bir classın adını yazmak istersek nameof u kullanırız*/
        public string RePassword { get; set; }
    }
}
