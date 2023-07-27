using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Username is required!!")]
        [StringLength(15)]
        public string Username { get; set; }

        [DataType(DataType.Password)]  /*passworda dönüstürmek iicn*/
        [Required(ErrorMessage = "Password is required!!")]
        [MinLength(6)]
        [MaxLength(12)]
        public string Password { get; set; }
    }
}
