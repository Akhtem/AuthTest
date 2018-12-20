using System;
using System.ComponentModel.DataAnnotations;

namespace SignInForm.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Поле Электронной почты должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Пароля должно быть установлено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}