using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Project.Entities

{
    [Table("UserData")]
    public class User
    {
        [Key]
        public Guid Id { get; set; } /*guid sqlde unique identifiera denk geliyor*/

        [StringLength(50)]
        public string? FullName { get; set; } /*string? yazarsak illla veritabında da null alabilsin diye yaparız*/

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        public bool Locked { get; set; } = false;

        
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [StringLength(255)]
        public string? ProfileImageFileName { get; set; } = "No-Image-Available.jpg";
        //p_098BG-ASD97.jpg      (picture_id(guid).jpg) ---uploadsın icine kaydedicem


        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";  /*ben yeni kullanıcı eklerken user rolü ver*/



    }


}
