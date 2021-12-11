using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Имя не указано!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Логин не указан!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль не указан!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно!")]
        public string ConfirmPassword { get; set; }
    }
}
