using Homework1.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{

    public class UserViewModel
    {
        [Required(ErrorMessage ="İsim alanı zorunlu bir alandır.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim alanı zorunlu bir alandır.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-Posta alanı zorunlu bir alandır.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Uygun olmayan E-Posta biçimi. E-Posta adresiniz isim@alan.uzantı şeklinde olmalıdır.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunlu bir alandır.")]
        [RegularExpression("^((?=.*\\d)(?=.*[A-Z])(?=.*\\W).{8,8})$", ErrorMessage = "Şifreniz 8 karakterden oluşmalı ve en az 1 sayı, 1 büyük harf ve 1 özel karakter içermelidir.")]
        /*      (                   # Start of group
                (?=.*\d)        #   must contain at least one digit
                (?=.*[A-Z])     #   must contain at least one uppercase character
                (?=.*\W)        #   must contain at least one special symbol
                .               #   match anything with previous condition checking
                {8,8}           #   length is exactly 8 characters
                )                   # End of group */ 
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxFileSize(1024*1024*2)]
        public IFormFile Image { get; set; }
    }
}
