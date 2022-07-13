using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_project.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre  Giriniz")]
        public string Password { get; set; }
    }
}
