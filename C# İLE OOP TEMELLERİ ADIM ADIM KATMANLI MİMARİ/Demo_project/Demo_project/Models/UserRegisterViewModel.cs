using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_project.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lüfen İsim  Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lüfen Soyisim  Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lüfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lüfen Mail Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lüfen Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lüfen Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz.")]
        public string ConfirmPassword { get; set; }
    }
}
