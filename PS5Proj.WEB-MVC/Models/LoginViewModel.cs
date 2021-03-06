using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Логин не указан!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль не указан!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
