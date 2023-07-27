﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Project.Models
{
    public class UserViewModel

        //veritabanından cektiğim dataları ekrana koyucam
    {
   
        public Guid Id { get; set; }


        public string? FullName { get; set; } = null;

        public string Username { get; set; }

        public bool Locked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string? ProfileImageFileName { get; set; } = "No-Image-Available.jpg";
   
        public string Role { get; set; } = "user";  


      
     //bendatayıcektikten sonra bu classa cevirip alıcam --usercontrollara gidiyoz


    }

    public class CreateUserModel
    {

   
    [Required(ErrorMessage = "Username is required!!")]
    [StringLength(15)]
    public string Username { get; set; }



    [Required]
    [StringLength(50)]
    public string FullName { get; set; }

        public bool Locked { get; set; }


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



    [Required]
    [StringLength(50)]
    public string Role { get; set; } = "user";

        public string? Done { get; set; }
    }





    public class EditUserModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        public bool Locked { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";

        public string? Done { get; set; }
    }
}

